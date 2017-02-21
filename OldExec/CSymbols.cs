using AxMapXLib;
using DBiGraphicObjs.DBiGraphicObjects;
using MapXLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace BdTC
{
	public class CSymbols : CollectionBase
	{
		public int IndexOf
		{
			get
			{
				return this.List.IndexOf(aSymbol);
			}
		}

		public int ListCount
		{
			get
			{
				return this.List.Count;
			}
		}

		public CSymbol this[int index]
		{
			get
			{
				return (CSymbol)this.List[index];
			}
		}

		[DebuggerNonUserCode]
		public CSymbols()
		{
		}

		public void Add(CSymbol aSymbol)
		{
			this.List.Add(aSymbol);
		}

		public void InsertAt(int index, CSymbol aSymbol)
		{
			bool flag = index > this.Count | index < 0;
			if (flag)
			{
				MessageBox.Show("Index not valid!");
			}
			else
			{
				flag = (index == this.Count);
				if (flag)
				{
					this.List.Add(aSymbol);
				}
				else
				{
					this.List.Insert(index, aSymbol);
				}
			}
		}

		public void Remove(int index)
		{
			bool flag = index > checked(this.Count - 1) | index < 0;
			if (flag)
			{
				MessageBox.Show("Index not valid!");
			}
			else
			{
				this.List.RemoveAt(index);
			}
		}

		public void Remove(CSymbol aSymbol)
		{
			this.List.Remove(aSymbol);
		}

		public bool Contains(CSymbol value)
		{
			return this.List.Contains(value);
		}

		public CSymbol FindSymbolAtPoint(AxMap pMap, PointF pt)
		{
			bool flag = this.List != null && this.List.Count > 0;
			checked
			{
				CSymbol FindSymbolAtPoint;
				if (flag)
				{
					int i = this.List.Count - 1;
					CSymbol drawSymbol;
					while (true)
					{
						int arg_64_0 = i;
						int num = 0;
						if (arg_64_0 < num)
						{
							goto IL_66;
						}
						drawSymbol = (CSymbol)this.List[i];
						flag = drawSymbol.HitTest(pMap, pt);
						if (flag)
						{
							break;
						}
						i += -1;
					}
					FindSymbolAtPoint = drawSymbol;
					return FindSymbolAtPoint;
				}
				IL_66:
				FindSymbolAtPoint = null;
				return FindSymbolAtPoint;
			}
		}

		public CFOUNDOBJECT FindObjectAtPoint(AxMap pMap, PointF pt)
		{
			CFOUNDOBJECT foundObj = new CFOUNDOBJECT();
			bool flag = this.List != null && this.List.Count > 0;
			checked
			{
				CFOUNDOBJECT FindObjectAtPoint;
				if (flag)
				{
					int i = this.List.Count - 1;
					CSymbol drawSymbol;
					GraphicObject drawObj;
					while (true)
					{
						int arg_87_0 = i;
						int num = 0;
						if (arg_87_0 < num)
						{
							goto IL_89;
						}
						drawSymbol = (CSymbol)this.List[i];
						drawObj = drawSymbol.FindObjectAtPoint(pMap, pt);
						flag = (drawObj != null);
						if (flag)
						{
							break;
						}
						i += -1;
					}
					foundObj.FoundObject = drawObj;
					foundObj.FoundSymbol = drawSymbol;
					FindObjectAtPoint = foundObj;
					return FindObjectAtPoint;
				}
				IL_89:
				FindObjectAtPoint = null;
				return FindObjectAtPoint;
			}
		}

		public void DrawSymbols(AxMap pMap, Graphics g)
		{
			bool flag = this.InnerList != null && this.InnerList.Count > 0;
			checked
			{
				if (flag)
				{
					int arg_2E_0 = 0;
					int num = this.InnerList.Count - 1;
					int i = arg_2E_0;
					while (true)
					{
						int arg_57_0 = i;
						int num2 = num;
						if (arg_57_0 > num2)
						{
							break;
						}
						CSymbol drawSymbol = (CSymbol)this.InnerList[i];
						drawSymbol.Draw(pMap, g);
						i++;
					}
				}
			}
		}

		public void DrawSelectedSymbol(AxMap pMap, Graphics g, CSymbol selectedSymbol, float Scale)
		{
			GraphicObject selectedObject = selectedSymbol.GObjs[0];
			System.Drawing.Point ltPt = default(System.Drawing.Point);
			float num = (float)ltPt.X;
			float num2 = (float)ltPt.Y;
			GraphicObject graphicObject = selectedObject;
			double num3 = (double)graphicObject.X;
			GraphicObject graphicObject2 = selectedObject;
			double num4 = (double)graphicObject2.Y;
			pMap.ConvertCoord(ref num, ref num2, ref num3, ref num4, ConversionConstants.miMapToScreen);
			graphicObject2.Y = (float)num4;
			graphicObject.X = (float)num3;
			checked
			{
				ltPt.Y = (int)Math.Round((double)num2);
				ltPt.X = (int)Math.Round((double)num);
				GraphicsContainer gCon = g.BeginContainer();
				g.ScaleTransform(Scale, Scale, MatrixOrder.Append);
				GraphicsContainer gCon2 = g.BeginContainer();
				g.PageUnit = GraphicsUnit.Pixel;
				bool flag = selectedObject != null;
				if (flag)
				{
					Pen selectionPen = new Pen(Color.FromKnownColor(KnownColor.HotTrack));
					selectionPen.DashStyle = DashStyle.Dot;
					selectionPen.Width = 1f;
					flag = (selectedObject.Rotation != 0f);
					if (flag)
					{
						Matrix myMatrix = g.Transform;
						Matrix arg_123_0 = myMatrix;
						float arg_123_1 = selectedObject.Rotation;
						PointF point = new PointF((float)ltPt.X, (float)ltPt.Y);
						arg_123_0.RotateAt(arg_123_1, point, MatrixOrder.Append);
						g.Transform = myMatrix;
					}
					PointF[] mPtfs = new PointF[3];
					mPtfs[0].X = selectedObject.X;
					mPtfs[0].Y = selectedObject.Y;
					int mPtsCount;
					unchecked
					{
						mPtfs[1].X = selectedObject.X + selectedObject.Width;
						mPtfs[1].Y = selectedObject.Y + selectedObject.Height;
						mPtsCount = mPtfs.GetUpperBound(0);
					}
					System.Drawing.Point[] mPts = new System.Drawing.Point[mPtsCount + 1];
					int arg_1B3_0 = 0;
					int num5 = mPtsCount;
					int i = arg_1B3_0;
					while (true)
					{
						int arg_281_0 = i;
						int num6 = num5;
						if (arg_281_0 > num6)
						{
							break;
						}
						System.Drawing.Point[] arg_1C3_0 = mPts;
						int num7 = i;
						num2 = (float)arg_1C3_0[num7].X;
						System.Drawing.Point[] arg_1DA_0 = mPts;
						int num8 = i;
						num = (float)arg_1DA_0[num8].Y;
						PointF[] arg_1F1_0 = mPtfs;
						int num9 = i;
						num4 = (double)arg_1F1_0[num9].X;
						PointF[] arg_208_0 = mPtfs;
						int num10 = i;
						num3 = (double)arg_208_0[num10].Y;
						pMap.ConvertCoord(ref num2, ref num, ref num4, ref num3, ConversionConstants.miMapToScreen);
						mPtfs[num10].Y = (float)num3;
						mPtfs[num9].X = (float)num4;
						mPts[num8].Y = (int)Math.Round((double)num);
						mPts[num7].X = (int)Math.Round((double)num2);
						i++;
					}
					float mW = (float)Math.Abs(mPts[1].X - mPts[0].X);
					float mH = (float)Math.Abs(mPts[1].Y - mPts[0].Y);
					float mPtX = (float)Math.Min(mPts[0].X, mPts[1].X);
					float mPtY = (float)Math.Min(mPts[0].Y, mPts[1].Y);
					System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)Math.Round((double)mPtX), (int)Math.Round((double)mPtY), (int)Math.Round((double)mW), (int)Math.Round((double)mH));
					g.DrawRectangle(selectionPen, rect);
				}
				g.EndContainer(gCon2);
				g.EndContainer(gCon);
			}
		}

		public void SendBack(CSymbol aKH)
		{
			this.List.Remove(aKH);
			this.List.Insert(0, aKH);
		}

		public void SendFront(CSymbol aKH)
		{
			this.List.Remove(aKH);
			this.List.Add(aKH);
		}

		public string KH2String(AxMap pMap)
		{
			StringWriter sw = new StringWriter();
			XmlTextWriter wr = new XmlTextWriter(sw);
			this.khs2xml(pMap, ref wr);
			wr.Close();
			return sw.ToString();
		}

		public void KH2File(AxMap pMap, string pFileName)
		{
			StreamWriter sw = new StreamWriter(pFileName);
			XmlTextWriter wr = new XmlTextWriter(sw);
			this.khs2xml(pMap, ref wr);
			wr.Close();
		}

		private void khs2xml(AxMap pMap, ref XmlTextWriter wr)
		{
			wr.WriteStartElement("KyHieus");
			wr.WriteAttributeString("CX", pMap.CenterX.ToString("#.0000"));
			wr.WriteAttributeString("CY", pMap.CenterY.ToString("#.0000"));
			wr.WriteAttributeString("Zoom", pMap.Zoom.ToString());
			checked
			{
				try
				{
					IEnumerator enumerator = this.List.GetEnumerator();
					while (enumerator.MoveNext())
					{
						CSymbol mKH = (CSymbol)enumerator.Current;
						wr.WriteStartElement("KyHieu");
						bool flag = mKH.Description.Length > 0;
						if (flag)
						{
							wr.WriteAttributeString("Desc", mKH.Description);
						}
						flag = mKH.Blinking;
						if (flag)
						{
							wr.WriteAttributeString("Blink", mKH.Blinking.ToString());
						}
						wr.WriteAttributeString("Zoom", mKH.Zoom.ToString());
						wr.WriteAttributeString("MWi", mKH.MWidth.ToString());
						wr.WriteAttributeString("GocX", mKH.GocX.ToString("#.0000"));
						wr.WriteAttributeString("GocY", mKH.GocY.ToString("#.0000"));
						try
						{
							IEnumerator enumerator2 = mKH.GObjs.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GraphicObject mPart = (GraphicObject)enumerator2.Current;
								wr.WriteStartElement("Part");
								OBJECTTYPE mType = mPart.GetObjType();
								wr.WriteAttributeString("Type", mType.ToString());
								flag = (mType == OBJECTTYPE.Text);
								if (flag)
								{
									TextGraphic mTextObj = (TextGraphic)mPart;
									wr.WriteAttributeString("Text", mTextObj.Text);
									wr.WriteAttributeString("FName", mTextObj.Font.Name);
									wr.WriteAttributeString("FSize", mTextObj.Font.Size.ToString());
									wr.WriteAttributeString("FStyle", mTextObj.Font.Style.ToString());
									wr.WriteAttributeString("FColor", Conversions.ToString(mTextObj.Color.ToArgb()));
									wr.WriteStartElement("Pos");
									wr.WriteAttributeString("X", mTextObj.X.ToString());
									wr.WriteAttributeString("Y", mTextObj.Y.ToString());
									wr.WriteAttributeString("A", mTextObj.Rotation.ToString());
									wr.WriteEndElement();
								}
								else
								{
									flag = (mType == OBJECTTYPE.Table);
									if (flag)
									{
										TableGraphic mTableObj = (TableGraphic)mPart;
										wr.WriteStartElement("TBL");
										wr.WriteAttributeString("X", mTableObj.X.ToString());
										wr.WriteAttributeString("Y", mTableObj.Y.ToString());
										wr.WriteAttributeString("W", mTableObj.Width.ToString());
										wr.WriteAttributeString("H", mTableObj.Height.ToString());
										wr.WriteAttributeString("A", mTableObj.Rotation.ToString());
										wr.WriteAttributeString("Cols", mTableObj.ColsNo.ToString());
										wr.WriteAttributeString("Rows", mTableObj.RowsNo.ToString());
										wr.WriteAttributeString("BColor", Conversions.ToString(mTableObj.BorderColor.ToArgb()));
										wr.WriteAttributeString("BWidth", mTableObj.BorderWidth.ToString());
										wr.WriteAttributeString("LColor", Conversions.ToString(mTableObj.LineColor.ToArgb()));
										wr.WriteAttributeString("LWidth", mTableObj.LineWidth.ToString());
										wr.WriteAttributeString("FiColor", Conversions.ToString(mTableObj.FiColor.ToArgb()));
										string str = Conversions.ToString(mTableObj.AWidth[0]);
										int arg_47A_0 = 1;
										int num = mTableObj.ColsNo - 1;
										int i = arg_47A_0;
										while (true)
										{
											int arg_4A4_0 = i;
											int num2 = num;
											if (arg_4A4_0 > num2)
											{
												break;
											}
											str = str + "|" + Conversions.ToString(mTableObj.AWidth[i]);
											i++;
										}
										wr.WriteAttributeString("AWS", str);
										str = Conversions.ToString(mTableObj.AHeight[0]);
										int arg_4CF_0 = 1;
										int num3 = mTableObj.RowsNo - 1;
										i = arg_4CF_0;
										while (true)
										{
											int arg_4F9_0 = i;
											int num2 = num3;
											if (arg_4F9_0 > num2)
											{
												break;
											}
											str = str + "|" + Conversions.ToString(mTableObj.AHeight[i]);
											i++;
										}
										wr.WriteAttributeString("AHS", str);
										i = 0;
										try
										{
											IEnumerator enumerator3 = mTableObj.Cells.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												CCell mCell = (CCell)enumerator3.Current;
												i++;
												wr.WriteStartElement("Cell");
												wr.WriteAttributeString("iR", mCell.iRow.ToString());
												wr.WriteAttributeString("iC", mCell.iCol.ToString());
												wr.WriteAttributeString("RNo", mCell.RowsNo.ToString());
												wr.WriteAttributeString("CNo", mCell.ColsNo.ToString());
												wr.WriteAttributeString("Text", mCell.Text);
												wr.WriteAttributeString("FName", mCell.Font.Name);
												wr.WriteAttributeString("FSize", mCell.Font.Size.ToString());
												wr.WriteAttributeString("FStyle", mCell.Font.Style.ToString());
												wr.WriteAttributeString("Color", Conversions.ToString(mCell.Color.ToArgb()));
												wr.WriteElementString("i", i.ToString());
												wr.WriteEndElement();
											}
										}
										finally
										{
											IEnumerator enumerator3;
											flag = (enumerator3 is IDisposable);
											if (flag)
											{
												(enumerator3 as IDisposable).Dispose();
											}
										}
										wr.WriteEndElement();
									}
									else
									{
										flag = (mType == OBJECTTYPE.EmbeddedImage);
										if (flag)
										{
											EmbeddedImageGraphic mImageObj = (EmbeddedImageGraphic)mPart;
											wr.WriteAttributeString("ITYPE", mImageObj.ImageType);
											wr.WriteAttributeString("IMAGEW", mImageObj.Width.ToString());
											wr.WriteAttributeString("IMAGEH", mImageObj.Height.ToString());
											string strImage = "";
											string imageType = mImageObj.ImageType;
											if (Operators.CompareString(imageType, "wmf", false) == 0 || Operators.CompareString(imageType, "emf", false) == 0)
											{
												goto IL_74D;
											}
											if (Operators.CompareString(imageType, "kro", false) == 0)
											{
												goto IL_74D;
											}
											bool arg_74E_0 = false;
											IL_74E:
											flag = arg_74E_0;
											if (flag)
											{
												try
												{
													object mFileName = "tmp2.kro";
													Image mMetaFile = mImageObj.Image;
													mMetaFile.Save(Conversions.ToString(mFileName));
													byte[] arrImageByte = this.GetarrImage(Conversions.ToString(mFileName));
													strImage = Convert.ToBase64String(arrImageByte);
												}
												catch (Exception expr_78D)
												{
													ProjectData.SetProjectError(expr_78D);
													Exception ex = expr_78D;
													Interaction.MsgBox("kro sai: " + ex.Message, MsgBoxStyle.OkOnly, null);
													ProjectData.ClearProjectError();
												}
											}
											else
											{
												MemoryStream memStream = new MemoryStream();
												mImageObj.Image.Save(memStream, ImageFormat.Bmp);
												strImage = Convert.ToBase64String(memStream.ToArray());
											}
											wr.WriteAttributeString("IMAGE", strImage);
											wr.WriteStartElement("Pos");
											wr.WriteAttributeString("X", mImageObj.X.ToString());
											wr.WriteAttributeString("Y", mImageObj.Y.ToString());
											wr.WriteAttributeString("A", mImageObj.Rotation.ToString());
											wr.WriteEndElement();
											goto IL_CDF;
											IL_74D:
											arg_74E_0 = true;
											goto IL_74E;
										}
										ShapeGraphic mShapeObj = (ShapeGraphic)mPart;
										wr.WriteAttributeString("Color", Conversions.ToString(mShapeObj.LineColor.ToArgb()));
										wr.WriteAttributeString("Width", mShapeObj.LineWidth.ToString());
										flag = (mShapeObj.LineStyle > 0);
										if (flag)
										{
											wr.WriteAttributeString("Style", mShapeObj.LineStyle.ToString());
											wr.WriteAttributeString("SWidth", mShapeObj.StyleWidth.ToString());
										}
										flag = (mShapeObj.Line2Width > 0f);
										if (flag)
										{
											wr.WriteAttributeString("Color2", Conversions.ToString(mShapeObj.Line2Color.ToArgb()));
											wr.WriteAttributeString("Width2", mShapeObj.Line2Width.ToString());
										}
										flag = (mShapeObj.DValues.Length > 6);
										if (flag)
										{
											wr.WriteAttributeString("DV", mShapeObj.DValues);
										}
										flag = mShapeObj.Fill;
										if (flag)
										{
											wr.WriteAttributeString("Fill", mShapeObj.Fill.ToString());
											wr.WriteAttributeString("FColor", Conversions.ToString(mShapeObj.FillColor.ToArgb()));
											wr.WriteAttributeString("HColor", Conversions.ToString(mShapeObj.HatchColor.ToArgb()));
											wr.WriteAttributeString("HStyle", mShapeObj.HatchStyle.ToString());
										}
										flag = (mType == OBJECTTYPE.Ellipse);
										if (flag)
										{
											EllipseGraphic mEllipseObj = (EllipseGraphic)mShapeObj;
											wr.WriteStartElement("Rect");
											wr.WriteAttributeString("X", mEllipseObj.X.ToString());
											wr.WriteAttributeString("Y", mEllipseObj.Y.ToString());
											wr.WriteAttributeString("W", mEllipseObj.Width.ToString());
											wr.WriteAttributeString("H", mEllipseObj.Height.ToString());
											wr.WriteAttributeString("A", mEllipseObj.Rotation.ToString());
											wr.WriteEndElement();
										}
										else
										{
											flag = (mType == OBJECTTYPE.Pie);
											if (flag)
											{
												PieGraphic mPieObj = (PieGraphic)mShapeObj;
												wr.WriteStartElement("Pie");
												wr.WriteAttributeString("X", mPieObj.X.ToString());
												wr.WriteAttributeString("Y", mPieObj.Y.ToString());
												wr.WriteAttributeString("W", mPieObj.Width.ToString());
												wr.WriteAttributeString("H", mPieObj.Height.ToString());
												wr.WriteAttributeString("ST", mPieObj.StartAngle.ToString());
												wr.WriteAttributeString("SW", mPieObj.SweepAngle.ToString());
												flag = mPieObj.IsArc;
												if (flag)
												{
													wr.WriteAttributeString("ARC", mPieObj.IsArc.ToString());
												}
												wr.WriteAttributeString("A", mPieObj.Rotation.ToString());
												wr.WriteEndElement();
											}
											else
											{
												int i = 0;
												NodesShapeGraphic mNodesShapeObj = (NodesShapeGraphic)mShapeObj;
												try
												{
													IEnumerator enumerator4 = mNodesShapeObj.Nodes.GetEnumerator();
													while (enumerator4.MoveNext())
													{
														CNODE mNode = (CNODE)enumerator4.Current;
														i++;
														wr.WriteStartElement("Node");
														wr.WriteAttributeString("X", mNode.Pt.X.ToString());
														wr.WriteAttributeString("Y", mNode.Pt.Y.ToString());
														flag = mNode.IsControl;
														if (flag)
														{
															wr.WriteAttributeString("Type", mNode.IsControl.ToString());
														}
														wr.WriteElementString("i", i.ToString());
														wr.WriteEndElement();
													}
												}
												finally
												{
													IEnumerator enumerator4;
													flag = (enumerator4 is IDisposable);
													if (flag)
													{
														(enumerator4 as IDisposable).Dispose();
													}
												}
											}
										}
									}
								}
								IL_CDF:
								wr.WriteEndElement();
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						wr.WriteEndElement();
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag = enumerator is IDisposable;
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				wr.WriteEndElement();
			}
		}

		private byte[] GetarrImage(string mFileName)
		{
			byte[] arrByte = null;
			bool flag = mFileName.Length > 0;
			if (flag)
			{
				FileStream fs = new FileStream(mFileName, FileMode.Open);
				BinaryReader r = new BinaryReader(fs);
				int fsCount = checked((int)fs.Length);
				arrByte = r.ReadBytes(fsCount);
				fs.Close();
			}
			return arrByte;
		}
	}
}
