using Microsoft.DirectX;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace DienTapLib
{
	public class CScript
	{
		public CThucHanh myThucHanh;
		public string ScrptFile;
		public int StartTickCount;
		public int StopTickCount;
		public List<CAct> acts;
		public CScript(CThucHanh pThucHanh, string pScrptFile)
		{
			this.myThucHanh = pThucHanh;
			this.ScrptFile = pScrptFile;
			this.StartTickCount = 0;
			this.StopTickCount = 0;
			this.acts = new List<CAct>();
		}
		public CScript(CThucHanh pThucHanh, string pScrptFile, int pStartTickCount, int pStopTickCount)
		{
			this.myThucHanh = pThucHanh;
			this.ScrptFile = pScrptFile;
			this.StartTickCount = pStartTickCount;
			this.StopTickCount = pStopTickCount;
			this.acts = new List<CAct>();
		}
		public override string ToString()
		{
			return this.ScrptFile;
		}
		public void UpdateStart(int pStart)
		{
			int num = pStart - this.StartTickCount;
			foreach (CAct current in this.acts)
			{
				current.StartTickCount += num;
				current.StopTickCount += num;
			}
			this.StartTickCount = pStart;
			this.StopTickCount += num;
		}
		public int LoadActions()
		{
			string scrptFile = this.ScrptFile;
			int result = this.StartTickCount;
			this.acts = new List<CAct>();
			try
			{
				XmlTextReader xmlTextReader = new XmlTextReader(scrptFile);
				result = this.XML2Actions(xmlTextReader);
				xmlTextReader.Close();
			}
			catch
			{
			}
			return result;
		}
		private int XML2Actions(XmlTextReader rr)
		{
			int num = this.StartTickCount;
			int num2 = 0;
			List<CExplodeDcl> list = new List<CExplodeDcl>();
			string text = "";
			string pName = "";
			string text2 = "Appear";
			int num3 = 0;
			string text3 = "";
			int pisound = -1;
			int num4 = 0;
			string name = "";
			int num5 = 0;
			int psteps = 10;
			float pPartial = 1f;
			float pspeed = 0f;
			int num6 = 1;
			float pCenterX = 0.5f;
			float pCenterY = 0.5f;
			Vector3 cameraPos = new Vector3(0f, 0f, 0f);
			float pangleZ = 0f;
			float pangleX = 0f;
			string pCornerText = "";
			string pDescText = "";
			DescPos pPos = DescPos.Duoi;
			bool pSaBanHide = false;
			float num7 = -45f;
			bool flag = false;
			float pdstopangleZ = 0f;
			float valueX = 0f;
			float valueY = 0f;
			float valueZ = 0f;
			List<Vector3> list2 = new List<Vector3>();
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 pFromPos = new Vector3(0f, 0f, 0f);
			float pShiftZ = 0f;
			string texfile = "";
			float num8 = 0f;
			float num9 = 0f;
			while (rr.Read())
			{
				XmlNodeType nodeType = rr.NodeType;
				XmlNodeType xmlNodeType = nodeType;
				string text4;
				if (xmlNodeType != XmlNodeType.Element)
				{
					if (xmlNodeType == XmlNodeType.EndElement)
					{
						if ((text4 = rr.Name) != null)
						{
							if (!(text4 == "Target"))
							{
								if (!(text4 == "From"))
								{
									if (!(text4 == "Targets"))
									{
										if (text4 == "Action")
										{
											bool loop = false;
											switch (text4 = text2)
											{
											case "Hide":
											{
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CHide(this.myThucHanh, pName, actObjByName, num3, num5, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "Unhide":
											{
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int i = 0; i < num6; i++)
														{
															int start = num3 + i * num5;
															CAct cAct = new CUnhide(this.myThucHanh, pName, actObjByName, start, num5, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start2 = num3 + num6 * num5;
															CAct cAct = new CHide(this.myThucHanh, pName, actObjByName, start2, num5, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "Spin":
											{
												CModel modelByName = this.myThucHanh.GetModelByName(name);
												if (modelByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CSpin(this.myThucHanh, pName, modelByName, num3, num5, num7, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "SpinTo":
											{
												CModel modelByName = this.myThucHanh.GetModelByName(name);
												if (modelByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CSpinTo(this.myThucHanh, pName, modelByName, num3, num5, vector, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												else
												{
													CBillboard billboardByName = this.myThucHanh.GetBillboardByName(name);
													if (billboardByName != null)
													{
														if (text3.Length > 0)
														{
															pisound = this.myThucHanh.GetSoundIndex(text3);
														}
														if (num4 == 1)
														{
															loop = true;
														}
														CAct cAct = new CSpinToBB(this.myThucHanh, pName, billboardByName, num3, num5, vector, pisound, loop);
														this.acts.Add(cAct);
														num2 = cAct.StopTickCount;
													}
												}
												break;
											}
											case "Appear":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int j = 0; j < num6; j++)
														{
															int start3 = num3 + j * num5;
															CAct cAct = new CAppear(this.myThucHanh, pName, texObjByName, start3, num5, psteps, pPartial, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start4 = num3 + num6 * num5;
															CAct cAct = new CDisappear(this.myThucHanh, pName, texObjByName, start4, num5, psteps, pPartial, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "AppearLeft":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int k = 0; k < num6; k++)
														{
															int start5 = num3 + k * num5;
															CAct cAct = new CAppearLeft(this.myThucHanh, pName, texObjByName, start5, num5, psteps, pPartial, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start6 = num3 + num6 * num5;
															CAct cAct = new CDisappearLeft(this.myThucHanh, pName, texObjByName, start6, num5, psteps, pPartial, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "AppearDown":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int l = 0; l < num6; l++)
														{
															int start7 = num3 + l * num5;
															CAct cAct = new CAppearDown(this.myThucHanh, pName, texObjByName, start7, num5, psteps, pPartial, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start8 = num3 + num6 * num5;
															CAct cAct = new CDisappearDown(this.myThucHanh, pName, texObjByName, start8, num5, psteps, pPartial, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "AppearUp":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int m = 0; m < num6; m++)
														{
															int start9 = num3 + m * num5;
															CAct cAct = new CAppearUp(this.myThucHanh, pName, texObjByName, start9, num5, psteps, pPartial, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start10 = num3 + num6 * num5;
															CAct cAct = new CDisappearUp(this.myThucHanh, pName, texObjByName, start10, num5, psteps, pPartial, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "AppearA":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (num6 > 0)
													{
														for (int n = 0; n < num6; n++)
														{
															int start11 = num3 + n * num5;
															CAct cAct = new CAppearA(this.myThucHanh, pName, texObjByName, start11, num5, psteps, pPartial, false, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (flag)
														{
															int start12 = num3 + num6 * num5;
															CAct cAct = new CDisappearA(this.myThucHanh, pName, texObjByName, start12, num5, psteps, pPartial, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
													}
												}
												break;
											}
											case "Disappear":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CDisappear(this.myThucHanh, pName, texObjByName, num3, num5, psteps, pPartial, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "DisappearLeft":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CDisappearLeft(this.myThucHanh, pName, texObjByName, num3, num5, psteps, pPartial, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "DisappearDown":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CDisappearDown(this.myThucHanh, pName, texObjByName, num3, num5, psteps, pPartial, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "DisappearUp":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CDisappearUp(this.myThucHanh, pName, texObjByName, num3, num5, psteps, pPartial, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "DisappearA":
											{
												CTexObj texObjByName = this.myThucHanh.GetTexObjByName(name);
												if (texObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CDisappearA(this.myThucHanh, pName, texObjByName, num3, num5, psteps, pPartial, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "Blink":
											{
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CBlink(this.myThucHanh, pName, actObjByName, num3, num5, pspeed, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "Move":
											{
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													if (actObjByName.ObjType == "TexObj")
													{
														CAct cAct = new CMoveTexObj(this.myThucHanh, pName, actObjByName, num3, num5, list2, flag, pisound, loop);
														this.acts.Add(cAct);
														num2 = cAct.StopTickCount;
													}
													else if (actObjByName.ObjType == "Billboard")
													{
														CAct cAct = new CMove(this.myThucHanh, pName, actObjByName, num3, num5, list2, flag, pdstopangleZ, pisound, loop);
														this.acts.Add(cAct);
														num2 = cAct.StopTickCount;
													}
													else
													{
														CAct cAct = new CMove(this.myThucHanh, pName, actObjByName, num3, num5, list2, flag, pisound, loop);
														this.acts.Add(cAct);
														num2 = cAct.StopTickCount;
													}
												}
												break;
											}
											case "Fly":
											{
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													if (text3.Length > 0)
													{
														pisound = this.myThucHanh.GetSoundIndex(text3);
													}
													if (num4 == 1)
													{
														loop = true;
													}
													CAct cAct = new CFly(this.myThucHanh, pName, actObjByName, num3, num5, list2, flag, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "Shoot":
											{
												if (text3.Length > 0)
												{
													pisound = this.myThucHanh.GetSoundIndex(text3);
												}
												if (num4 == 1)
												{
													loop = true;
												}
												if (num8 <= 0f)
												{
													num8 = 0.5f;
												}
												if (num9 <= 0f)
												{
													num9 = 1.5f;
												}
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (num6 > 0)
												{
													for (int num11 = 0; num11 < num6; num11++)
													{
														int num12 = num3 + num11 * num5;
														if (actObjByName != null)
														{
															CAct cAct = new CShootFrom(this.myThucHanh, pName, texfile, num8, num9, num12, num5, pspeed, actObjByName, vector, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														else
														{
															CAct cAct = new CShoot(this.myThucHanh, pName, texfile, num8, num9, num12, num5, pspeed, pFromPos, vector, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														if (text.Length > 0)
														{
															CExplodeDcl expl = this.GetExpl(text, list);
															if (expl != null)
															{
																int start13 = num12 + num5;
																CAct cAct = new CExplodeObj(this.myThucHanh, expl.DclID, expl.TextureFile, expl.Width, expl.Height, expl.ShiftZ, start13, expl.Duration, expl.Speed, vector, expl.Isound, expl.SoundLoop);
																this.acts.Add(cAct);
															}
														}
													}
												}
												break;
											}
											case "Bombard":
											{
												if (text3.Length > 0)
												{
													pisound = this.myThucHanh.GetSoundIndex(text3);
												}
												if (num4 == 1)
												{
													loop = true;
												}
												if (num8 <= 0f)
												{
													num8 = 0.5f;
												}
												if (num9 <= 0f)
												{
													num9 = 1.5f;
												}
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (num6 > 0)
												{
													int num13 = 0;
													while (num13 < num6)
													{
														int num14 = num3 + num13 * num5;
														if (actObjByName != null)
														{
															try
															{
																CAct cAct = new CBombardO2P(this.myThucHanh, pName, texfile, num8, num9, num14, num5, pspeed, num7, actObjByName, vector, pisound, loop);
																this.acts.Add(cAct);
																num2 = cAct.StopTickCount;
																goto IL_17A0;
															}
															catch
															{
																goto IL_17A0;
															}
															goto Block_127;
														}
														goto IL_1761;

														IL_17A0:
														if (text.Length > 0)
														{
															CExplodeDcl expl2 = this.GetExpl(text, list);
															if (expl2 != null)
															{
																int start14 = num14 + num5;
																CAct cAct = new CExplodeObj(this.myThucHanh, expl2.DclID, expl2.TextureFile, expl2.Width, expl2.Height, expl2.ShiftZ, start14, expl2.Duration, expl2.Speed, vector, expl2.Isound, expl2.SoundLoop);
																this.acts.Add(cAct);
															}
														}
														num13++;
														continue;
														Block_127:
                                                        IL_1761:
														try
														{
															CAct cAct = new CBombard(this.myThucHanh, pName, texfile, num8, num9, num14, num5, pspeed, num7, pFromPos, vector, pisound, loop);
															this.acts.Add(cAct);
															num2 = cAct.StopTickCount;
														}
														catch
														{
														}
														goto IL_17A0;
													}
												}
												break;
											}
											case "FocusAt":
											{
												CAct cAct = new CFocusAt(this.myThucHanh, pName, num3, num5, pCenterX, pCenterY, cameraPos, pangleZ, pangleX);
												this.acts.Add(cAct);
												num2 = cAct.StopTickCount;
												break;
											}
											case "CornerTitle":
											{
												CAct cAct = new CCornerTitle(this.myThucHanh, pName, num3, num5, pCornerText);
												this.acts.Add(cAct);
												num2 = cAct.StopTickCount;
												break;
											}
											case "Description":
											{
												if (text3.Length > 0)
												{
													pisound = this.myThucHanh.GetSoundIndex(text3);
												}
												if (num4 == 1)
												{
													loop = true;
												}
												CAct cAct = new CDescription(this.myThucHanh, pName, num3, num5, pDescText, pPos, pSaBanHide, pisound, loop);
												this.acts.Add(cAct);
												num2 = cAct.StopTickCount;
												break;
											}
											case "Explode":
											{
												if (text3.Length > 0)
												{
													pisound = this.myThucHanh.GetSoundIndex(text3);
												}
												if (num4 == 1)
												{
													loop = true;
												}
												if (num8 <= 0f)
												{
													num8 = 3f;
												}
												if (num9 <= 0f)
												{
													num9 = 3f;
												}
												CActObj actObjByName = this.myThucHanh.GetActObjByName(name);
												if (actObjByName != null)
												{
													CAct cAct;
													if (actObjByName.ObjType == "Model")
													{
														cAct = new CExplodeMObj(this.myThucHanh, pName, texfile, num8, num9, pShiftZ, num3, num5, pspeed, actObjByName, pisound, loop);
													}
													else if (actObjByName.ObjType == "Billboard")
													{
														cAct = new CExplodeBbObj(this.myThucHanh, pName, texfile, num8, num9, pShiftZ, num3, num5, pspeed, actObjByName, pisound, loop);
													}
													else
													{
														cAct = new CExplodeObj(this.myThucHanh, pName, texfile, num8, num9, pShiftZ, num3, num5, pspeed, actObjByName, pisound, loop);
													}
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												else
												{
													CAct cAct = new CExplodeObj(this.myThucHanh, pName, texfile, num8, num9, pShiftZ, num3, num5, pspeed, vector, pisound, loop);
													this.acts.Add(cAct);
													num2 = cAct.StopTickCount;
												}
												break;
											}
											case "ExplodeDcl":
											{
												if (text3.Length > 0)
												{
													pisound = this.myThucHanh.GetSoundIndex(text3);
												}
												if (num4 == 1)
												{
													loop = true;
												}
												if (num8 <= 0f)
												{
													num8 = 3f;
												}
												if (num9 <= 0f)
												{
													num9 = 3f;
												}
												CExplodeDcl item = new CExplodeDcl(pName, texfile, num8, num9, pShiftZ, num5, pspeed, pisound, loop);
												list.Add(item);
												break;
											}
											}
											if (num2 > num)
											{
												num = num2;
											}
										}
									}
								}
								else
								{
									pFromPos = new Vector3(valueX, valueY, valueZ);
								}
							}
							else
							{
								vector = new Vector3(valueX, valueY, valueZ);
								list2.Add(vector);
							}
						}
					}
				}
				else if ((text4 = rr.Name) != null && !(text4 == "Actions"))
				{
					if (!(text4 == "Action"))
					{
						if (!(text4 == "Targets"))
						{
							if (!(text4 == "Target"))
							{
								if (text4 == "From")
								{
									if (rr.AttributeCount > 0)
									{
										while (rr.MoveToNextAttribute())
										{
											if ((text4 = rr.Name) != null)
											{
												if (!(text4 == "X"))
												{
													if (!(text4 == "Y"))
													{
														if (text4 == "Z")
														{
															valueZ = CHelper.myToSingle(rr.Value);
														}
													}
													else
													{
														valueY = CHelper.myToSingle(rr.Value);
													}
												}
												else
												{
													valueX = CHelper.myToSingle(rr.Value);
												}
											}
										}
									}
								}
							}
							else if (rr.AttributeCount > 0)
							{
								while (rr.MoveToNextAttribute())
								{
									if ((text4 = rr.Name) != null)
									{
										if (!(text4 == "X"))
										{
											if (!(text4 == "Y"))
											{
												if (text4 == "Z")
												{
													valueZ = CHelper.myToSingle(rr.Value);
												}
											}
											else
											{
												valueY = CHelper.myToSingle(rr.Value);
											}
										}
										else
										{
											valueX = CHelper.myToSingle(rr.Value);
										}
									}
								}
							}
						}
					}
					else
					{
						pName = "";
						text2 = "";
						num3 = 0;
						text3 = "";
						pisound = -1;
						num4 = 0;
						name = "";
						num5 = 0;
						psteps = 1;
						pspeed = 1f;
						num6 = 1;
						pPartial = 1f;
						texfile = "";
						num8 = 0f;
						num9 = 0f;
						num7 = -45f;
						pCenterX = 0.5f;
						pCenterY = 0.5f;
						cameraPos = this.myThucHanh.cameraPos;
						pangleZ = this.myThucHanh.getAngleZ();
						pangleX = this.myThucHanh.getAngleX();
						pCornerText = "";
						pDescText = "";
						pPos = DescPos.Duoi;
						pSaBanHide = false;
						pShiftZ = 0f;
						flag = false;
						pdstopangleZ = 0f;
						list2 = new List<Vector3>();
						text = "";
						if (rr.AttributeCount > 0)
						{
							while (rr.MoveToNextAttribute())
							{
								switch (text4 = rr.Name)
								{
								case "ID":
									pName = rr.Value;
									break;
								case "Type":
									text2 = rr.Value;
									break;
								case "ObjName":
									name = rr.Value;
									break;
								case "Start":
									num3 = this.GetStart(rr.Value, this.acts);
									break;
								case "Duration":
									num5 = this.GetDuration(rr.Value, this.acts, num3);
									break;
								case "Steps":
									psteps = Convert.ToInt32(rr.Value);
									break;
								case "Speed":
									pspeed = CHelper.myToSingle(rr.Value);
									break;
								case "Partial":
									pPartial = CHelper.myToSingle(rr.Value);
									break;
								case "Delay":
									CHelper.myToSingle(rr.Value);
									break;
								case "Repeat":
									num6 = Convert.ToInt32(rr.Value);
									break;
								case "CanAjust":
									Convert.ToBoolean(rr.Value);
									break;
								case "dAngle":
									num7 = CHelper.myToSingle(rr.Value);
									break;
								case "CenterX":
									pCenterX = CHelper.myToSingle(rr.Value);
									break;
								case "CenterY":
									pCenterY = CHelper.myToSingle(rr.Value);
									break;
								case "cameraPosX":
									cameraPos.X = CHelper.myToSingle(rr.Value);
									break;
								case "cameraPosY":
									cameraPos.Y = CHelper.myToSingle(rr.Value);
									break;
								case "cameraPosZ":
									cameraPos.Z = CHelper.myToSingle(rr.Value);
									break;
								case "angleZ":
									pangleZ = CHelper.myToSingle(rr.Value);
									break;
								case "angleX":
									pangleX = CHelper.myToSingle(rr.Value);
									break;
								case "CornerText":
									pCornerText = rr.Value;
									break;
								case "DescText":
									pDescText = rr.Value;
									break;
								case "Pos":
									pPos = ((rr.Value == "Tren") ? DescPos.Tren : ((rr.Value == "Giua") ? DescPos.Giua : DescPos.Duoi));
									break;
								case "SaBanHide":
									pSaBanHide = Convert.ToBoolean(rr.Value);
									break;
								case "GravityZ":
									CHelper.myToSingle(rr.Value);
									break;
								case "SoundName":
									text3 = CHelper.GetSoundName(rr.Value);
									break;
								case "iSound":
									pisound = Convert.ToInt32(rr.Value);
									break;
								case "SoundLoop":
									num4 = Convert.ToInt32(rr.Value);
									break;
								case "Hide":
									flag = Convert.ToBoolean(rr.Value);
									break;
								case "StopAngleZ":
									pdstopangleZ = CHelper.myToSingle(rr.Value);
									break;
								case "ImageFile":
									texfile = rr.Value;
									break;
								case "Width":
									num8 = CHelper.myToSingle(rr.Value);
									break;
								case "Height":
									num9 = CHelper.myToSingle(rr.Value);
									break;
								case "ShiftZ":
									pShiftZ = CHelper.myToSingle(rr.Value);
									break;
								case "ExplID":
									text = rr.Value;
									break;
								}
							}
						}
					}
				}
			}
			return num;
		}
		private CExplodeDcl GetExpl(string pexplid, List<CExplodeDcl> pexpldcls)
		{
			CExplodeDcl result = null;
			for (int i = pexpldcls.Count - 1; i >= 0; i--)
			{
				if (pexpldcls[i].DclID.ToUpper() == pexplid.ToUpper())
				{
					result = pexpldcls[i];
					break;
				}
			}
			return result;
		}
		private string GetStartStopStr(string pstr)
		{
			StringBuilder stringBuilder = new StringBuilder("", 50);
			if (pstr.Length > 0)
			{
				for (int i = 0; i < pstr.Length; i++)
				{
					if (pstr[i] != ' ')
					{
						if (pstr[i] == 's')
						{
							stringBuilder.Append("S");
						}
						else
						{
							stringBuilder.Append(pstr[i]);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}
		private int GetStart(string pstartstr, List<CAct> pacts)
		{
			string startStopStr = this.GetStartStopStr(pstartstr);
			int num = 0;
			if (startStopStr.ToLower().StartsWith("stop"))
			{
				int num2;
				int num3;
				if ((num2 = startStopStr.IndexOf("(")) > 0 && (num3 = startStopStr.IndexOf(")")) > 0 && num3 > num2 + 1)
				{
					string text = startStopStr.Substring(num2 + 1, num3 - num2 - 1);
					if (text.Length > 0)
					{
						num = this.getActstop(text, pacts);
					}
				}
				else if (pacts.Count > 0)
				{
					num = pacts[pacts.Count - 1].StopTickCount;
				}
				else
				{
					num = 0;
				}
				if ((num2 = startStopStr.IndexOf("+")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num += num4;
				}
				if ((num2 = startStopStr.IndexOf("-")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num -= num4;
				}
			}
			else if (startStopStr.ToLower().StartsWith("start"))
			{
				int num2;
				int num3;
				if ((num2 = startStopStr.IndexOf("(")) > 0 && (num3 = startStopStr.IndexOf(")")) > 0 && num3 > num2 + 1)
				{
					string text = startStopStr.Substring(num2 + 1, num3 - num2 - 1);
					if (text.Length > 0)
					{
						num = this.getActstart(text, pacts);
					}
				}
				else if (pacts.Count > 0)
				{
					num = pacts[pacts.Count - 1].StartTickCount;
				}
				else
				{
					num = 0;
				}
				if ((num2 = startStopStr.IndexOf("+")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num += num4;
				}
				if ((num2 = startStopStr.IndexOf("-")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num -= num4;
				}
			}
			else
			{
				num = (int)(CHelper.myToSingle(startStopStr) * 1000f);
			}
			return num;
		}
		private int getActstart(string name, List<CAct> pacts)
		{
			int result = -1;
			bool flag = false;
			for (int i = 0; i < pacts.Count; i++)
			{
				CAct cAct = pacts[i];
				if (cAct.Name.Length == name.Length && cAct.Name.ToUpper() == name.ToUpper())
				{
					result = cAct.StartTickCount;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				if (pacts.Count > 0)
				{
					result = pacts[pacts.Count - 1].StartTickCount;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}
		private int getActstop(string name, List<CAct> pacts)
		{
			int result = -1;
			bool flag = false;
			for (int i = pacts.Count - 1; i >= 0; i--)
			{
				CAct cAct = pacts[i];
				if (cAct.Name.Length == name.Length && cAct.Name.ToUpper() == name.ToUpper())
				{
					result = cAct.StopTickCount;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				if (pacts.Count > 0)
				{
					result = pacts[pacts.Count - 1].StopTickCount;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}
		private int GetDuration(string pdurationstr, List<CAct> pacts, int pStart)
		{
			string startStopStr = this.GetStartStopStr(pdurationstr);
			int num = 0;
			if (startStopStr.ToLower().StartsWith("stop"))
			{
				int num2;
				int num3;
				if ((num2 = startStopStr.IndexOf("(")) > 0 && (num3 = startStopStr.IndexOf(")")) > 0 && num3 > num2 + 1)
				{
					string text = startStopStr.Substring(num2 + 1, num3 - num2 - 1);
					if (text.Length > 0)
					{
						num = this.getActstop(text, pacts);
					}
				}
				else if (pacts.Count > 0)
				{
					num = pacts[pacts.Count - 1].StopTickCount;
				}
				else
				{
					num = 0;
				}
				if ((num2 = startStopStr.IndexOf("+")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num += num4;
				}
				if ((num2 = startStopStr.IndexOf("-")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num -= num4;
				}
				num -= pStart;
			}
			else if (startStopStr.ToLower().StartsWith("start"))
			{
				int num2;
				int num3;
				if ((num2 = startStopStr.IndexOf("(")) > 0 && (num3 = startStopStr.IndexOf(")")) > 0 && num3 > num2 + 1)
				{
					string text = startStopStr.Substring(num2 + 1, num3 - num2 - 1);
					if (text.Length > 0)
					{
						num = this.getActstart(text, pacts);
					}
				}
				else if (pacts.Count > 0)
				{
					num = pacts[pacts.Count - 1].StartTickCount;
				}
				else
				{
					num = 0;
				}
				if ((num2 = startStopStr.IndexOf("+")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num += num4;
				}
				if ((num2 = startStopStr.IndexOf("-")) > 0)
				{
					string strSingle = startStopStr.Substring(num2 + 1);
					int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
					num -= num4;
				}
				num -= pStart;
			}
			else
			{
				num = (int)(CHelper.myToSingle(startStopStr) * 1000f);
			}
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}
	}
}
