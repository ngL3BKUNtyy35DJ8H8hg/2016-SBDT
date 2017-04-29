using DBiGraphicObjs.DBiGraphicObjects;
using DienTapLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using XuLyKHLib;
using AxMapXLib;
using Microsoft.DirectX;
using MapXLib;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SaBan.Settings
{
    public class CDiaHinh : CTerrain
    {
        private float m_AngleZ;

        private float m_AngleX;

        private Bitmap m_TexImage;

        private double myPixelsPerGridX;

        private double myPixelsPerGridY;

        private float[,] heightData;

        private AxMap m_Map;

        //private frmMain m_ParentForm;

        private double m_LastMapCX;

        private double m_LastMapCY;

        private ArrayList m_Symbol3Objs;

        //public CDiaHinh(AxMap pMap, frmMain pForm, float[,] pheightData, char pDecSepa, char pGrpSepa)
        //    : base(pForm.Panel3D, pheightData, modSaBan.mySCALE_FACTOR, pDecSepa, pGrpSepa)
        public CDiaHinh(AxMap pMap, float[,] pheightData, char pDecSepa, char pGrpSepa)
            : base(pForm.Panel3D, pheightData, modSaBan.mySCALE_FACTOR, pDecSepa, pGrpSepa)
        {
            this.m_AngleZ = 0f;
            this.m_AngleX = 0f;
            this.m_LastMapCX = 0.0;
            this.m_LastMapCY = 0.0;
            //this.m_ParentForm = pForm;
            this.m_Map = pMap;
            this.heightData = pheightData;
        }

        public void InitDiaHinh(Vector3 pCamPos)
        {
            if (File.Exists(modSaBan.myTextureFile))
            {
                this.m_TexImage = new Bitmap(modSaBan.myTextureFile);
            }
            else
            {
                this.m_TexImage = new Bitmap(modSaBan.myGRID_WIDTH, modSaBan.myGRID_HEIGHT);
            }
            modSaBan.my3DSoPixelsPer1000m = this.GetSoPixelsPer1000m();
            checked
            {
                this.myPixelsPerGridX = (double)this.m_TexImage.Width / (double)(modSaBan.myGRID_WIDTH - 1);
                this.myPixelsPerGridY = (double)this.m_TexImage.Height / (double)(modSaBan.myGRID_HEIGHT - 1);
                modSaBan.mySurf2X = (double)this.m_TexImage.Width;
                modSaBan.mySurf2Y = (double)this.m_TexImage.Height;
                Bitmap arg_BF_1 = this.m_TexImage;
                Vector3 pcameraTarget = new Vector3(0f, 0f, 0f);
                base.InitTerrain(arg_BF_1, pCamPos, pcameraTarget, -0.448798954f, modSaBan.myLightDir);
                modSaBan.clrColor = CHelper.GetClrColor(this.m_TexImage);
                this.m_Symbol3Objs = new ArrayList();
                base.LoadModelMeshs(modSaBan.myD3DModelMeshFile);
                base.LoadBillboardMeshs(modSaBan.myBillboardMeshFile);
                this.m_AngleZ = base.GetAngleZ();
                this.m_AngleX = base.GetAngleX();
            }
        }

        private object GetSoPixelsPer1000m0()
        {
            double num = this.m_Map.Distance(modSaBan.myMap1X, modSaBan.myMap1Y, modSaBan.myMap2X, modSaBan.myMap1Y);
            int num2 = checked((int)Math.Round(unchecked((double)this.m_TexImage.Width * 1000.0) / num));
            return num2;
        }

        private double GetSoPixelsPer1000m()
        {
            double num = this.m_Map.Distance(modSaBan.myMap1X, modSaBan.myMap1Y, modSaBan.myMap2X, modSaBan.myMap1Y);
            return (double)this.m_TexImage.Width * 1000.0 / num;
        }

        public string GetSymbolType(CSymbol pSymbol)
        {
            string result = "TexObj";
            int num = base.GetModelMeshIndex(pSymbol.Description);
            if (num > -1)
            {
                result = "Model";
            }
            else
            {
                num = base.GetBillboardMeshIndex(pSymbol.Description);
                if (num > -1)
                {
                    result = "Billboard";
                }
            }
            return result;
        }

        private void LoadSymbols()
        {
            base.ClearModels();
            base.ClearBillboards();
            this.m_Symbol3Objs.Clear();
            double num;
            double num2;
            checked
            {
                num = Convert.ToDouble(decimal.Multiply(new decimal(this.m_TexImage.Width), new decimal(1000L))) / (double)(modSaBan.myGRID_WIDTH - 1) / 1000.0;
                num2 = Convert.ToDouble(decimal.Multiply(new decimal(this.m_TexImage.Height), new decimal(1000L))) / (double)(modSaBan.myGRID_HEIGHT - 1) / 1000.0;
                Graphics graphics = Graphics.FromImage(this.m_TexImage);
            }
            try
            {
                IEnumerator enumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CSymbol cSymbol = (CSymbol)enumerator.Current;
                    PointF surfPosition = modSaBan.GetSurfPosition(cSymbol.GocX, cSymbol.GocY);
                    float valueX = (float)((double)surfPosition.X / num);
                    float valueY = (float)((double)(checked(modSaBan.myGRID_HEIGHT - 1)) - (double)surfPosition.Y / num2);
                    float dHeading = -CTerrain.DegreeToRadian(cSymbol.Heading);
                    Vector3 pPos = new Vector3(valueX, valueY, -7f);
                    int num3 = base.GetModelMeshIndex(cSymbol.Description);
                    if (num3 > -1)
                    {
                        base.Load1Model(cSymbol.Description, num3, pPos, dHeading);
                    }
                    else
                    {
                        num3 = base.GetBillboardMeshIndex(cSymbol.Description);
                        if (num3 > -1)
                        {
                            base.Load1Billboard(cSymbol.Description, num3, pPos, dHeading);
                        }
                        else
                        {
                            double zoom = cSymbol.Zoom / (double)cSymbol.MWidth * (modSaBan.my3DSoPixelsPer1000m / 1000.0);
                            CGraphicObjs cGraphicObjs = new CGraphicObjs();
                            try
                            {
                                IEnumerator enumerator2 = cSymbol.GObjs.GetEnumerator();
                                while (enumerator2.MoveNext())
                                {
                                    GraphicObject graphicObject = (GraphicObject)enumerator2.Current;
                                    GraphicObject aGObj = graphicObject.Clone();
                                    cGraphicObjs.Add(aGObj);
                                }
                            }
                            finally
                            {
                                IEnumerator enumerator2;
                                if (enumerator2 is IDisposable)
                                {
                                    (enumerator2 as IDisposable).Dispose();
                                }
                            }
                            CSymbol3 cSymbol2 = new CSymbol3(cSymbol.Description, surfPosition, cGraphicObjs);
                            cSymbol2.Zoom = zoom;
                            cSymbol2.Heading = cSymbol.Heading;
                            this.m_Symbol3Objs.Add(cSymbol2);
                        }
                    }
                }
            }
            finally
            {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
        }

        private void Draw3(Graphics g, CSymbol3 pSymbol)
        {
            Graphics graphics = this.m_Map.CreateGraphics();
            GraphicsContainer container = g.BeginContainer();
            g.TranslateTransform((float)pSymbol.GocX, (float)pSymbol.GocY);
            g.RotateTransform(pSymbol.Heading);
            try
            {
                IEnumerator enumerator = pSymbol.GObjs.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GraphicObject graphicObject = (GraphicObject)enumerator.Current;
                    try
                    {
                        if (graphicObject.GetObjType() == OBJECTTYPE.Text)
                        {
                            SizeF sizeF = g.MeasureString(((TextGraphic)graphicObject).Text, ((TextGraphic)graphicObject).Font);
                            float num = graphics.MeasureString(((TextGraphic)graphicObject).Text, ((TextGraphic)graphicObject).Font).Width / sizeF.Width;
                            Font font = new Font(((TextGraphic)graphicObject).Font.Name, ((TextGraphic)graphicObject).Font.Size * num, ((TextGraphic)graphicObject).Font.Style, ((TextGraphic)graphicObject).Font.Unit);
                            ((TextGraphic)graphicObject).Font = font;
                        }
                    }
                    catch (Exception expr_104)
                    {
                        ProjectData.SetProjectError(expr_104);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            finally
            {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            pSymbol.GObjs.DrawObjects(g, (float)pSymbol.Zoom);
            g.EndContainer(container);
        }

        private void DrawSymbol3(Image pbmpImage)
        {
            Graphics g = Graphics.FromImage(pbmpImage);
            try
            {
                IEnumerator enumerator = this.m_Symbol3Objs.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CSymbol3 pSymbol = (CSymbol3)enumerator.Current;
                    this.Draw3(g, pSymbol);
                }
            }
            finally
            {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
        }

        private void ExportModels(string pFileName)
        {
            StreamWriter w = new StreamWriter(pFileName);
            XmlTextWriter xmlTextWriter = new XmlTextWriter(w);
            int num = 0;
            xmlTextWriter.WriteStartElement("Models");
            xmlTextWriter.WriteString("\r\n");
            checked
            {
                try
                {
                    List<CModel>.Enumerator enumerator = this.Models.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        CModel current = enumerator.Current;
                        num++;
                        string name = current.Name;
                        int num2 = base.ModelMeshs.IndexOf(current.ModelMesh);
                        xmlTextWriter.WriteStartElement("Model");
                        xmlTextWriter.WriteAttributeString("Name", name);
                        xmlTextWriter.WriteAttributeString("iMesh", num2.ToString());
                        xmlTextWriter.WriteAttributeString("X", current.X.ToString());
                        xmlTextWriter.WriteAttributeString("Y", current.Y.ToString());
                        xmlTextWriter.WriteAttributeString("Z", current.Z.ToString());
                        xmlTextWriter.WriteAttributeString("Heading", current.angleZ.ToString());
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteString("\r\n");
                    }
                }
                finally
                {
                    List<CModel>.Enumerator enumerator;
                    ((IDisposable)enumerator).Dispose();
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteString("\r\n");
                xmlTextWriter.Close();
            }
        }

        private void ExportBillboards(string pFileName)
        {
            StreamWriter w = new StreamWriter(pFileName);
            XmlTextWriter xmlTextWriter = new XmlTextWriter(w);
            int num = 0;
            xmlTextWriter.WriteStartElement("Billboards");
            xmlTextWriter.WriteString("\r\n");
            checked
            {
                try
                {
                    List<CBillboard>.Enumerator enumerator = this.Billboards.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        CBillboard current = enumerator.Current;
                        num++;
                        string name = current.Name;
                        int num2 = base.BillboardMeshs.IndexOf(current.BillboardMesh);
                        xmlTextWriter.WriteStartElement("Billboard");
                        xmlTextWriter.WriteAttributeString("Name", name);
                        xmlTextWriter.WriteAttributeString("iMesh", num2.ToString());
                        xmlTextWriter.WriteAttributeString("X", current.Position.X.ToString());
                        xmlTextWriter.WriteAttributeString("Y", current.Position.Y.ToString());
                        xmlTextWriter.WriteAttributeString("Z", current.Z.ToString());
                        xmlTextWriter.WriteAttributeString("Heading", current.angleZ.ToString());
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteString("\r\n");
                    }
                }
                finally
                {
                    List<CBillboard>.Enumerator enumerator;
                    ((IDisposable)enumerator).Dispose();
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteString("\r\n");
                xmlTextWriter.Close();
            }
        }

        private bool IsActiveSymbol(string pName, List<CActDef> pActions)
        {
            bool result = false;
            if (pName.Length > 0)
            {
                try
                {
                    List<CActDef>.Enumerator enumerator = pActions.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        CActDef current = enumerator.Current;
                        if (Operators.CompareString(current.ObjName, pName, false) == 0)
                        {
                            result = true;
                            break;
                        }
                    }
                }
                finally
                {
                    List<CActDef>.Enumerator enumerator;
                    ((IDisposable)enumerator).Dispose();
                }
            }
            return result;
        }

        private void ExportTexObjs(string pFileName, List<CActDef> pActions)
        {
            int num = 0;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Bitmap bitmap = new Bitmap(modSaBan.myTextureFile);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            checked
            {
                using (StreamWriter streamWriter = new StreamWriter(pFileName))
                {
                    streamWriter.WriteLine("<TexObjs>");
                    try
                    {
                        IEnumerator enumerator = this.m_Symbol3Objs.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            CSymbol3 cSymbol = (CSymbol3)enumerator.Current;
                            if (this.IsActiveSymbol(cSymbol.Name, pActions))
                            {
                                num++;
                                string mImageFile = modSaBan.mySaBanDir + "\\TexObj" + num.ToString("000") + ".xml";
                                streamWriter.WriteLine(this.GetTexObjStr(cSymbol, mImageFile));
                            }
                            else
                            {
                                this.Draw3(graphics, cSymbol);
                            }
                        }
                    }
                    finally
                    {
                        IEnumerator enumerator;
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    streamWriter.WriteLine("</TexObjs>");
                    streamWriter.Close();
                }
                bitmap.Save(modSaBan.mySaBanDir + "\\DienTapMap.jpg");
                bitmap.Dispose();
            }
        }

        private string GetTexObjStr(CSymbol3 aSymbol, string mImageFile)
        {
            string str = "<TexObj";
            RectangleF bounds = aSymbol.GetBounds();
            string name;
            int value;
            int value2;
            int value3;
            int value4;
            Rectangle rectangle;
            checked
            {
                int num = (int)Math.Round(unchecked(Math.Floor((double)bounds.X / this.myPixelsPerGridX) - 1.0));
                int num2 = (int)Math.Round(unchecked(Math.Floor((double)bounds.Y / this.myPixelsPerGridY) - 1.0));
                int num3 = (int)Math.Round(unchecked(Math.Ceiling((double)(bounds.X + bounds.Width) / this.myPixelsPerGridX) + 1.0));
                int num4 = (int)Math.Round(unchecked(Math.Ceiling((double)(bounds.Y + bounds.Height) / this.myPixelsPerGridY) + 1.0));
                name = aSymbol.Name;
                value = num3 - num;
                value2 = num4 - num2;
                value3 = num;
                value4 = modSaBan.myGRID_HEIGHT - 1 - num4;
                rectangle = new Rectangle((int)Math.Round(unchecked((double)num * this.myPixelsPerGridX)), (int)Math.Round(unchecked((double)num2 * this.myPixelsPerGridY)), (int)Math.Round(unchecked((double)(checked(num3 - num)) * this.myPixelsPerGridX)), (int)Math.Round(unchecked((double)(checked(num4 - num2)) * this.myPixelsPerGridY)));
            }
            aSymbol.GocX -= (double)rectangle.X;
            aSymbol.GocY -= (double)rectangle.Y;
            aSymbol.KH2File(mImageFile);
            str = str + " Name=\"" + name + "\"";
            str = str + " ImageFile=\"" + mImageFile + "\"";
            str = str + " Width=\"" + Conversions.ToString(value) + "\"";
            str = str + " Height=\"" + Conversions.ToString(value2) + "\"";
            str = str + " ShiftX=\"" + Conversions.ToString(value3) + "\"";
            str = str + " ShiftY=\"" + Conversions.ToString(value4) + "\"";
            str = str + " ImageWidth=\"" + Conversions.ToString(rectangle.Width) + "\"";
            str = str + " ImageHeight=\"" + Conversions.ToString(rectangle.Height) + "\"";
            return str + " />";
        }

        public void ExportCacDT(List<CActDef> pActions)
        {
            this.LoadSymbols();
            this.ExportModels(modSaBan.mySaBanDir + "\\D3DModels.xml");
            this.ExportBillboards(modSaBan.mySaBanDir + "\\D3DBillboards.xml");
            this.ExportTexObjs(modSaBan.mySaBanDir + "\\D3DTexObjs.xml", pActions);
        }

        public void ChangeDHFocus(double pLon, double pLat)
        {
            if ((this.m_Map.CenterX != this.m_LastMapCX | this.m_Map.CenterY != this.m_LastMapCY) && (pLon > modSaBan.myMap2X & pLon < modSaBan.myMap1X & (pLat > modSaBan.myMap2Y & pLat < modSaBan.myMap1Y)))
            {
                PointF surfPosition = modSaBan.GetSurfPosition(pLon, pLat);
                base.ChangeFocus(surfPosition.X / (float)this.m_TexImage.Width, ((float)this.m_TexImage.Height - surfPosition.Y) / (float)this.m_TexImage.Height);
                this.m_LastMapCX = pLon;
                this.m_LastMapCY = pLat;
            }
        }

        public void Hien3DSymbols()
        {
            this.LoadSymbols();
            this.m_TexImage = new Bitmap(modSaBan.myTextureFile);
            this.DrawSymbol3(this.m_TexImage);
            base.LoadMemStream(this.m_TexImage);
        }

        public void Xoa3DSymbols()
        {
            base.ClearModels();
            this.m_TexImage = new Bitmap(modSaBan.myTextureFile);
            base.LoadMemStream(this.m_TexImage);
        }

        public void ShowSaBan()
        {
            if (MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir))
            {
                string text = modSaBan.mySaBanDir + "\\" + modSaBan.MyMnuName;
                if (MyProject.Computer.FileSystem.FileExists(text))
                {
                    Dlg3DShow dlg3DShow = new Dlg3DShow();
                    Bitmap bitmap = new Bitmap(modSaBan.mySaBanDir + "\\DienTapMap.jpg");
                    Vector3 cameraPos = this.cameraPos;
                    Vector3 cameraTarget = this.cameraTarget;
                    float angleZ = base.GetAngleZ();
                    float angleX = base.GetAngleX();
                    dlg3DShow.ShowDialog(bitmap, this.heightData, cameraPos, cameraTarget, text, modSaBan.myLightDir, angleZ, angleX);
                    bitmap.Dispose();
                    dlg3DShow.Dispose();
                }
                else
                {
                    Interaction.MsgBox("Không thấy file: " + text, MsgBoxStyle.OkOnly, null);
                }
            }
            else
            {
                Interaction.MsgBox("Không thấy thư mục: " + modSaBan.mySaBanDir, MsgBoxStyle.OkOnly, null);
            }
        }

        public void ScriptsEdit()
		{
			if (MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir))
			{
				string text = modSaBan.mySaBanDir + "\\" + modSaBan.MyMnuName;
				if (MyProject.Computer.FileSystem.FileExists(text))
				{
					new dlgActions[]
					{
						TopMost = true
					}.Show(text, myModule.fMain);
				}
				else
				{
					Interaction.MsgBox("Không thấy file: " + text, MsgBoxStyle.OkOnly, null);
				}
			}
			else
			{
				Interaction.MsgBox("Không thấy thư mục: " + modSaBan.mySaBanDir, MsgBoxStyle.OkOnly, null);
			}
		}
    }
}
