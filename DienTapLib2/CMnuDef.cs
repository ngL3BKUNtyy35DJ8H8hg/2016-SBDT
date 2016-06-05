using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
namespace DienTapLib
{
	public class CMnuDef
	{
		public static List<CMnuItem> GetMnuItems(string pFileName)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(pFileName);
			List<CMnuItem> result = CMnuDef.XML2Items(xmlTextReader);
			xmlTextReader.Close();
			return result;
		}
		private static List<CMnuItem> XML2Items(XmlTextReader rr)
		{
			List<CMnuItem> list = new List<CMnuItem>();
			string pid = "";
			string pName = "";
			string pTitle = "";
			int pPosX = 0;
			int pPosY = 0;
			int pWidth = 40;
			int pHeight = 20;
			List<CScriptDef> list2 = new List<CScriptDef>();
			try
			{
				while (rr.Read())
				{
					XmlNodeType nodeType = rr.NodeType;
					XmlNodeType xmlNodeType = nodeType;
					string name2;
					if (xmlNodeType != XmlNodeType.Element)
					{
						if (xmlNodeType == XmlNodeType.EndElement)
						{
							string name;
							if ((name = rr.Name) != null && !(name == "Script") && !(name == "Scripts"))
							{
								if (!(name == "MnuItem"))
								{
									if (!(name == "Mnu"))
									{
									}
								}
								else
								{
									CMnuItem item = new CMnuItem(pid, pName, pTitle, pPosX, pPosY, pWidth, pHeight, list2);
									list.Add(item);
								}
							}
						}
					}
					else if ((name2 = rr.Name) != null && !(name2 == "Mnu"))
					{
						if (!(name2 == "MnuItem"))
						{
							if (!(name2 == "Scripts"))
							{
								if (name2 == "Script")
								{
									string pid2 = "";
									string pscrptfile = "";
									string pmnuItemRef = "";
									string pstart = "0";
									if (rr.AttributeCount > 0)
									{
										while (rr.MoveToNextAttribute())
										{
											string name3;
											if ((name3 = rr.Name) != null)
											{
												if (!(name3 == "ID"))
												{
													if (!(name3 == "ScrptFile"))
													{
														if (!(name3 == "MnuItemRef"))
														{
															if (name3 == "Start")
															{
																pstart = rr.Value;
															}
														}
														else
														{
															pmnuItemRef = rr.Value;
														}
													}
													else
													{
														pscrptfile = rr.Value;
													}
												}
												else
												{
													pid2 = rr.Value;
												}
											}
										}
										CScriptDef item2 = new CScriptDef(pid2, pscrptfile, pmnuItemRef, pstart);
										list2.Add(item2);
									}
								}
							}
						}
						else
						{
							pid = "";
							pName = "";
							pTitle = "";
							pPosX = 0;
							pPosY = 0;
							pWidth = 40;
							pHeight = 20;
							list2 = new List<CScriptDef>();
							if (rr.AttributeCount > 0)
							{
								while (rr.MoveToNextAttribute())
								{
									string name4;
									switch (name4 = rr.Name)
									{
									case "ID":
										pid = rr.Value;
										break;
									case "Name":
										pName = rr.Value;
										break;
									case "Title":
										pTitle = rr.Value;
										break;
									case "PosX":
										pPosX = Convert.ToInt32(rr.Value);
										break;
									case "PosY":
										pPosY = Convert.ToInt32(rr.Value);
										break;
									case "Width":
										pWidth = Convert.ToInt32(rr.Value);
										break;
									case "Height":
										pHeight = Convert.ToInt32(rr.Value);
										break;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return list;
		}
		public static void WriteMenuItems(List<CMnuItem> items, string pFileName)
		{
			string text = "<Mnu>\r\n";
			foreach (CMnuItem current in items)
			{
				text += current.GetItemStr();
			}
			text += "</Mnu>";
			using (StreamWriter streamWriter = new StreamWriter(pFileName))
			{
				streamWriter.WriteLine(text);
				streamWriter.Close();
			}
		}
	}
}
