using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DienTapLib
{
    public class CThucHanh
    {
        private bool bKetThuc;
        public Vector3 cameraPos;
        public Vector3 cameraTarget;
        public float CenterX = 0.5f;
        public float CenterY = 0.5f;
        public float angleZ;
        public float angleX;
        private float angleY;
        private int CurrAct = -1;
        private bool bAutoRun;
        private CMnu myMenu;
        private bool bMenuHidden;
        public Color BGrColor = Color.LightBlue;
        public bool TerrainVisible = true;
        public Color ActColor = Color.Red;
        public Color NoActColor = Color.Blue;
        public string MenuFontName = "Arial";
        public float MenuFontSize = 12f;
        public FontStyle MenuFontStyle;
        private int CounterPos = 30;
        public string MenuTitleText = "";
        public Color DescColor = Color.Yellow;
        public string DescFontName = "Times New Roman";
        public float DescFontSize = 14f;
        public FontStyle DescFontStyle;
        public string DescText = "";
        public int DescPointX;
        public int DescPointY;
        public Color DescGiuaColor = Color.Black;
        public string DescGiuaFontName = "Times New Roman";
        public float DescGiuaFontSize = 18f;
        public FontStyle DescGiuaFontStyle;
        public string DescGiuaText = "";
        public int DescGiuaPointX;
        public int DescGiuaPointY;
        public Color DescTrenColor = Color.Red;
        public string DescTrenFontName = "Times New Roman";
        public float DescTrenFontSize = 20f;
        public FontStyle DescTrenFontStyle;
        public string DescTrenText = "";
        public int DescTrenPointX;
        public int DescTrenPointY;
        private bool DescVisible = true;
        public int TrenPointY = 30;
        public Color TitleColor = Color.Black;
        public string TitleFontName = "Times New Roman";
        public float TitleFontSize = 14f;
        public FontStyle TitleFontStyle;
        public string TitleText = "";
        public int TitlePointX = 400;
        public int TitlePointY = 4;
        private Form m_MapPanel;
        private float tyleMH = 1f;
        public CSounds mySound;
        private List<string> m_SoundNames;
        private List<CBillboardMesh> m_BillboardMeshs;
        private List<CBillboard> Billboards;
        private List<CModelMesh> ModelMeshs;
        private List<CModel> Models;
        private List<CSpriteTex> SpriteTexs;
        private List<CSpriteObj> SpriteObjs;
        private List<CTexObj> texObjs;
        private CRunActs runactions;
        private MyTimeSpan TotalTimeSpan;
        private bool bPlaying;
        private int mainStart;
        private int currTickCount;
        private int pauseTickCount;
        private int LastTickCount = 1;
        private int Frames;
        private float LastFrameRate;
        private Matrix worldMatrix;
        private Matrix viewMatrix;
        private Matrix projectionMatrix;
        private Device device;
        private PresentParameters presentParams = new PresentParameters();
        private bool deviceLost;
        private int LastMouseX;
        private int LastMouseY;
        public CTerrainMesh myTerrain;
        public bool TerrainLighting = true;
        private Microsoft.DirectX.Direct3D.Font text;
        public Microsoft.DirectX.Direct3D.Font textDesc;
        public Microsoft.DirectX.Direct3D.Font textDescGiua;
        public Microsoft.DirectX.Direct3D.Font textDescTren;
        public Microsoft.DirectX.Direct3D.Font textTitle;
        public event EventHandler OnESC;
        private void InitializeFont(string pFontName, float pSize, FontStyle pFontStyle)
        {
            this.text = new Microsoft.DirectX.Direct3D.Font(this.device, new System.Drawing.Font(pFontName, pSize, pFontStyle));
            this.CounterPos = (int)this.MenuFontSize + 18;
        }
        public void InitializeDescFont(string pFontName, float pSize, FontStyle pFontStyle, Color pDescColor)
        {
            this.textDesc = new Microsoft.DirectX.Direct3D.Font(this.device, new System.Drawing.Font(pFontName, pSize, pFontStyle));
            this.DescColor = pDescColor;
        }
        public void InitializeDescGiuaFont(string pFontName, float pSize, FontStyle pFontStyle, Color pDescColor)
        {
            this.textDescGiua = new Microsoft.DirectX.Direct3D.Font(this.device, new System.Drawing.Font(pFontName, pSize, pFontStyle));
            this.DescGiuaColor = pDescColor;
        }
        public void InitializeDescTrenFont(string pFontName, float pSize, FontStyle pFontStyle, Color pDescColor)
        {
            this.textDescTren = new Microsoft.DirectX.Direct3D.Font(this.device, new System.Drawing.Font(pFontName, pSize, pFontStyle));
            this.DescTrenColor = pDescColor;
        }
        public void DescMeasure(string pDescText)
        {
            this.DescText = pDescText;
            Rectangle rectangle = this.textDesc.MeasureString(null, pDescText, DrawTextFormat.Center, this.DescColor);
            Size desktopSize = CHelper.GetDesktopSize();
            this.DescPointX = (desktopSize.Width - rectangle.Width) / 2;
            this.DescPointY = desktopSize.Height - rectangle.Height - 40;
        }
        public void DescMeasureTren(string pDescText)
        {
            this.DescTrenText = pDescText;
            this.textDescTren.MeasureString(null, pDescText, DrawTextFormat.Center, this.DescTrenColor);
            CHelper.GetDesktopSize();
            this.DescTrenPointX = this.TitlePointX;
            this.DescTrenPointY = this.TitlePointY;
        }
        public void DescMeasureGiua(string pDescText)
        {
            this.DescGiuaText = pDescText;
            Rectangle rectangle = this.textDescGiua.MeasureString(null, pDescText, DrawTextFormat.Center, this.DescGiuaColor);
            Size desktopSize = CHelper.GetDesktopSize();
            this.DescGiuaPointX = (desktopSize.Width - rectangle.Width) / 2;
            this.DescGiuaPointY = (desktopSize.Height - rectangle.Height) / 2;
        }
        private void InitializeTitleFont(string pFontName, float pSize, FontStyle pFontStyle)
        {
            this.textTitle = new Microsoft.DirectX.Direct3D.Font(this.device, new System.Drawing.Font(pFontName, pSize, pFontStyle));
        }
        public void setTyleMH(float ptyle)
        {
            this.tyleMH = ptyle;
        }
        public void tangX()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.X = expr_0B_cp_0.lightDirection.X + 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public void giamX()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.X = expr_0B_cp_0.lightDirection.X - 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public void tangY()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.Y = expr_0B_cp_0.lightDirection.Y + 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public void giamY()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.Y = expr_0B_cp_0.lightDirection.Y - 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public void tangZ()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.Z = expr_0B_cp_0.lightDirection.Z + 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public void giamZ()
        {
            CTerrainMesh expr_0B_cp_0 = this.myTerrain;
            expr_0B_cp_0.lightDirection.Z = expr_0B_cp_0.lightDirection.Z - 1f;
            this.device.Lights[0].Direction = this.myTerrain.lightDirection;
            this.device.Lights[0].Update();
        }
        public CThucHanh(Form pMapPanel, float[,] pheightData, float pSCALE_FACTOR, char pDecSepa, char pGrpSepa)
        {
            try
            {
                
                this.m_MapPanel = pMapPanel;
                this.InitializeDevice(pMapPanel);
                this.myTerrain = new CTerrainMesh(this.device, pheightData, pSCALE_FACTOR);
                this.mySound = new CSounds(pMapPanel);
                this.m_SoundNames = new List<string>();
                this.m_BillboardMeshs = new List<CBillboardMesh>();
                this.Billboards = new List<CBillboard>();
                this.ModelMeshs = new List<CModelMesh>();
                this.Models = new List<CModel>();
                this.SpriteTexs = new List<CSpriteTex>();
                this.SpriteObjs = new List<CSpriteObj>();
                this.texObjs = new List<CTexObj>();
                this.runactions = new CRunActs();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        ~CThucHanh()
        {
        }
        public void ClearTerrain()
        {
            this.m_MapPanel.MouseWheel -= new MouseEventHandler(this.Form1_MouseWheel);
            this.m_MapPanel.MouseDoubleClick -= new MouseEventHandler(this.Form1_MouseDoubleClick);
            this.m_MapPanel.Paint -= new PaintEventHandler(this.Form1_Paint);
            this.m_MapPanel.MouseDown -= new MouseEventHandler(this.Form1_MouseDown);
            this.m_MapPanel.MouseMove -= new MouseEventHandler(this.Form1_MouseMove);
            this.mySound.ClearSounds();
            this.m_SoundNames.Clear();
            this.m_BillboardMeshs.Clear();
            this.Billboards.Clear();
            this.ModelMeshs.Clear();
            this.Models.Clear();
            this.SpriteTexs.Clear();
            this.SpriteObjs.Clear();
            if (this.texObjs.Count > 0)
            {
                for (int i = this.texObjs.Count - 1; i > -1; i--)
                {
                    CTexObj cTexObj = this.texObjs[i];
                    cTexObj.Dispose();
                    this.texObjs.RemoveAt(i);
                }
            }
            this.runactions.actions.Clear();
            this.runactions = null;
            this.myTerrain.Dispose();
            this.device.Dispose();
        }
        public void ClearTerrain0()
        {
            this.StopAction();
            this.m_MapPanel.MouseWheel -= new MouseEventHandler(this.Form1_MouseWheel);
            this.m_MapPanel.MouseDoubleClick -= new MouseEventHandler(this.Form1_MouseDoubleClick);
            this.m_MapPanel.Paint -= new PaintEventHandler(this.Form1_Paint);
            this.m_MapPanel.MouseDown -= new MouseEventHandler(this.Form1_MouseDown);
            this.m_MapPanel.MouseMove -= new MouseEventHandler(this.Form1_MouseMove);
            if (this.bMenuHidden)
            {
                this.bMenuHidden = false;
            }
        }
        public void InitTerrain(Bitmap pTexImage, Vector3 pcameraPos, Vector3 pcameraTarget, float pangleZ, float pangleX, Vector3 plightDirection)
        {
            try
            {
                this.myTerrain.LoadMemStream(pTexImage);
                this.myTerrain.ResetTerrain();
                this.cameraPos = pcameraPos;
                this.cameraTarget = pcameraTarget;
                this.angleZ = pangleZ;
                this.angleX = pangleX;
                this.myTerrain.lightDirection = plightDirection;
                this.InitializeFont(this.MenuFontName, this.MenuFontSize, this.MenuFontStyle);
                this.InitializeDescFont(this.DescFontName, this.DescFontSize, this.DescFontStyle, this.DescColor);
                this.InitializeDescTrenFont(this.DescTrenFontName, this.DescTrenFontSize, this.DescTrenFontStyle, this.DescTrenColor);
                this.InitializeDescGiuaFont(this.DescGiuaFontName, this.DescGiuaFontSize, this.DescGiuaFontStyle, this.DescGiuaColor);
                this.InitializeTitleFont(this.TitleFontName, this.TitleFontSize, this.TitleFontStyle);
                this.m_MapPanel.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
                this.m_MapPanel.MouseDoubleClick += new MouseEventHandler(this.Form1_MouseDoubleClick);
                this.m_MapPanel.Paint += new PaintEventHandler(this.Form1_Paint);
                this.m_MapPanel.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
                this.m_MapPanel.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
                this.myTerrain.SetLights();
                this.ResetAllScript();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ResetAllScript()
        {
            for (int i = this.myMenu.scripts.Count - 1; i >= 0; i--)
            {
                CScript cScript = this.myMenu.scripts[i];
                for (int j = cScript.acts.Count - 1; j >= 0; j--)
                {
                    CAct cAct = cScript.acts[j];
                    cAct.Reset();
                }
            }
        }
        private void InitializeDevice(Form pForm)
        {
            this.presentParams.Windowed = true;
            this.presentParams.SwapEffect = SwapEffect.Discard;
            this.presentParams.AutoDepthStencilFormat = DepthFormat.D16;
            this.presentParams.EnableAutoDepthStencil = true;
            try
            {
                this.device = new Device(0, DeviceType.Hardware, pForm, CreateFlags.HardwareVertexProcessing, new PresentParameters[]
				{
					this.presentParams
				});
            }
            catch
            {
                this.device = new Device(0, DeviceType.Hardware, pForm, CreateFlags.SoftwareVertexProcessing, new PresentParameters[]
				{
					this.presentParams
				});
            }
            this.device.DeviceReset += new EventHandler(this.OnDeviceReset);
            this.device.DeviceLost += new EventHandler(this.OnDeviceLost);
        }
        protected void OnDeviceLost(object sender, EventArgs e)
        {
        }
        private void OnDeviceReset(object sender, EventArgs e)
        {
            this.myTerrain.SetLights();
        }
        protected void AttemptRecovery()
        {
            try
            {
                this.device.TestCooperativeLevel();
            }
            catch (DeviceLostException)
            {
            }
            catch (DeviceNotResetException)
            {
                try
                {
                    this.device.Reset(new PresentParameters[]
					{
						this.presentParams
					});
                    this.deviceLost = false;
                }
                catch (DeviceLostException)
                {
                }
            }
        }
        private void OnPaint()
        {
            if (this.deviceLost)
            {
                this.AttemptRecovery();
            }
            if (this.deviceLost)
            {
                return;
            }
            this.projectionMatrix = Matrix.PerspectiveFovLH(0.7853982f, (float)this.m_MapPanel.Width / (float)this.m_MapPanel.Height, 1f, 500f);
            this.viewMatrix = Matrix.LookAtLH(this.cameraPos, this.cameraTarget, new Vector3(0f, 1f, 0f));
            this.worldMatrix = Matrix.Translation((float)(-(float)this.myTerrain.WIDTH) * this.CenterX, (float)(-(float)this.myTerrain.HEIGHT) * this.CenterY, 0f) * Matrix.RotationZ(this.angleZ) * Matrix.RotationX(this.angleX) * Matrix.RotationY(this.angleY);
            this.device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, this.BGrColor, 1f, 0);
            this.device.Transform.Projection = this.projectionMatrix;
            this.device.Transform.View = this.viewMatrix;
            this.device.Transform.World = this.worldMatrix;
            if (this.bPlaying)
            {
                foreach (CAct current in this.runactions.actions)
                {
                    if (!current.done)
                    {
                        current.Update(this.mainStart);
                    }
                }
                this.mySound.SoundAffairs();
            }
            this.device.BeginScene();
            if (this.TerrainVisible)
            {
                this.device.RenderState.Lighting = this.TerrainLighting;
                this.myTerrain.Render();
                this.device.RenderState.AlphaBlendEnable = true;
                foreach (CTexObj current2 in this.texObjs)
                {
                    if (current2.visible)
                    {
                        current2.Render(this.worldMatrix);
                    }
                }
                this.device.RenderState.AlphaBlendEnable = false;
                this.device.RenderState.Lighting = true;
                foreach (CModel current3 in this.Models)
                {
                    if (current3.visible)
                    {
                        current3.Render(this.worldMatrix, this.angleZ);
                    }
                }
                this.device.RenderState.AlphaBlendEnable = true;
                this.device.RenderState.Lighting = false;
                foreach (CBillboard current4 in this.Billboards)
                {
                    if (current4.visible)
                    {
                        current4.Render(this, this.worldMatrix, this.angleZ);
                    }
                }
                foreach (CSpriteObj current5 in this.SpriteObjs)
                {
                    if (current5.visible)
                    {
                        current5.Render(this.worldMatrix, this.angleZ);
                    }
                }
            }
            if (this.DescVisible)
            {
                if (this.DescText.Length > 0)
                {
                    this.textDesc.DrawText(null, this.DescText, new Point(this.DescPointX, this.DescPointY), this.DescColor);
                }
                if (this.DescTrenText.Length > 0)
                {
                    this.textDescTren.DrawText(null, this.DescTrenText, new Point(this.DescTrenPointX, this.DescTrenPointY), this.DescTrenColor);
                }
                if (this.DescGiuaText.Length > 0)
                {
                    this.textDescGiua.DrawText(null, this.DescGiuaText, new Point(this.DescGiuaPointX, this.DescGiuaPointY), this.DescGiuaColor);
                }
            }
            if (this.bPlaying)
            {
                this.currTickCount = Environment.TickCount - this.mainStart;
            }
            if (this.currTickCount > this.runactions.StopTickCount)
            {
                if (this.bAutoRun)
                {
                    this.bKetThuc = true;
                }
                else
                {
                    if (this.bPlaying)
                    {
                        this.StopAction();
                    }
                    this.CurrAct = -1;
                    this.bMenuHidden = false;
                }
            }
            if (!this.bMenuHidden)
            {
                this.text.DrawText(null, "Chọn kịch bản...", new Point(10, this.CounterPos), Color.Black);
                this.myMenu.Draw(this.text, this.CurrAct);
                if (this.TitleText.Length > 0)
                {
                    this.textTitle.DrawText(null, this.TitleText, new Point(this.TitlePointX, this.TitlePointY), this.TitleColor);
                }
            }
            else
            {
                MyTimeSpan timeSpan = CHelper.GetTimeSpan(this.currTickCount);
                this.text.DrawText(null, string.Format("{0:0}:{1:0}.{2:0} / {3:0}:{4:0}", new object[]
				{
					timeSpan.Minutes,
					timeSpan.Seconds,
					timeSpan.Milliseconds,
					this.TotalTimeSpan.Minutes,
					this.TotalTimeSpan.Seconds
				}), new Point(10, this.CounterPos), Color.Red);
                if (this.MenuTitleText.Length > 0)
                {
                    this.text.DrawText(null, this.MenuTitleText, new Point(10, this.CounterPos + (int)this.MenuFontSize + 4), Color.Red);
                }
            }
            this.device.EndScene();
            try
            {
                this.device.Present();
            }
            catch (DeviceLostException)
            {
                this.deviceLost = true;
            }
            if (this.bKetThuc)
            {
                this.bKetThuc = false;
                this.RiseESC();
            }
        }
        private void UpdateFramerate()
        {
            this.Frames++;
            if (Math.Abs(Environment.TickCount - this.LastTickCount) > 1000)
            {
                this.LastFrameRate = (float)this.Frames * 1000f / (float)Math.Abs(Environment.TickCount - this.LastTickCount);
                this.LastTickCount = Environment.TickCount;
                this.Frames = 0;
            }
            this.text.DrawText(null, string.Format("{0:0.00} fps", this.LastFrameRate), new Point(10, 10), Color.Red);
        }
        private void StopAction()
        {
            for (int i = 0; i < this.runactions.actions.Count; i++)
            {
                if (!this.runactions.actions[i].done)
                {
                    this.runactions.actions[i].Stop();
                }
            }
            this.runactions.actions.Clear();
            this.runactions.StartTickCount = 0;
            this.runactions.StopTickCount = 0;
            this.DescText = "";
            this.DescTrenText = "";
            this.DescGiuaText = "";
            this.mySound.ClearSounds();
            this.pauseTickCount = 0;
            this.bPlaying = false;
        }
        public void PauseAction()
        {
            if (this.bPlaying)
            {
                this.pauseTickCount = this.currTickCount;
                this.bPlaying = false;
                this.mySound.SoundAffairs();
                this.mySound.StopSounds();
                return;
            }
            this.ResumeAction();
        }
        private void ResumeAction()
        {
            this.mySound.ResumeSounds();
            this.mainStart = Environment.TickCount - this.pauseTickCount;
            this.pauseTickCount = 0;
            this.bPlaying = true;
        }
        private void StartActions()
        {
            this.pauseTickCount = 0;
            this.mainStart = Environment.TickCount;
            this.bPlaying = true;
        }
        private void ResetAction()
        {
            this.bPlaying = false;
            foreach (CSpriteObj current in this.SpriteObjs)
            {
                current.visible = false;
            }
            for (int i = this.runactions.actions.Count - 1; i >= 0; i--)
            {
                this.runactions.actions[i].Reset();
            }
        }
        private void RiseESC()
        {
            this.bPlaying = false;
            this.ClearTerrain0();
            if (this.OnESC != null)
            {
                this.OnESC(this, null);
            }
        }
        public void SwitchDescVisible()
        {
            this.DescVisible = !this.DescVisible;
        }
        public void LoadModels(string pFile)
        {
            try
            {
                this.Models.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pFile);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string pName = (string)dataRow[0];
                        int index = Convert.ToInt32(dataRow[1]);
                        float valueX = CHelper.myToSingle((string)dataRow[2]);
                        float valueY = CHelper.myToSingle((string)dataRow[3]);
                        float num = CHelper.myToSingle((string)dataRow[4]);
                        float pAngleZ = CHelper.myToSingle((string)dataRow[5]);
                        CModelMesh pCModelMesh = this.ModelMeshs[index];
                        Vector3 position = new Vector3(valueX, valueY, num);
                        CModel cModel = new CModel(pName, this.device, pCModelMesh, position, pAngleZ);
                        if (num == 0f)
                        {
                            cModel.Z = this.myTerrain.getZ(cModel.X, cModel.Y);
                        }
                        this.Models.Add(cModel);
                    }
                }
            }
            catch
            {
            }
        }
        public void LoadBillboards(string pFile)
        {
            try
            {
                this.Billboards.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pFile);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string pName = (string)dataRow[0];
                        int index = Convert.ToInt32(dataRow[1]);
                        float valueX = CHelper.myToSingle((string)dataRow[2]);
                        float valueY = CHelper.myToSingle((string)dataRow[3]);
                        float num = CHelper.myToSingle((string)dataRow[4]);
                        float pAngleZ = CHelper.myToSingle((string)dataRow[5]);
                        CBillboardMesh pBillboardMesh = this.m_BillboardMeshs[index];
                        Vector3 position = new Vector3(valueX, valueY, num);
                        CBillboard cBillboard = new CBillboard(this.myTerrain, pName, this.device, pBillboardMesh, position, pAngleZ);
                        if (num == 0f)
                        {
                            cBillboard.Z = this.myTerrain.getZ(cBillboard.Position.X, cBillboard.Position.Y);
                        }
                        this.Billboards.Add(cBillboard);
                    }
                }
            }
            catch
            {
            }
        }
        public int GetModelMeshIndex(string pDesc)
        {
            int result = -1;
            foreach (CModelMesh current in this.ModelMeshs)
            {
                if (pDesc.IndexOf(current.myName) > -1)
                {
                    result = this.ModelMeshs.IndexOf(current);
                    break;
                }
            }
            return result;
        }
        public void LoadModelMeshs(string pModel3DsFile)
        {
            try
            {
                this.ModelMeshs.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pModel3DsFile);
                DataTable dataTable = dataSet.Tables[0];
                string pName = "";
                string text = "";
                float valueX = 0f;
                float valueY = 0f;
                float valueZ = 0f;
                float pScale = 1f;
                float pShiftX = 0f;
                float pShiftY = 0f;
                float pShiftZ = 0f;
                int pAutoTurn = 0;
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if (dataRow.ItemArray.GetUpperBound(0) == 9)
                        {
                            pName = (string)dataRow[0];
                            text = (string)dataRow[1];
                            valueX = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[2]));
                            valueY = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[3]));
                            valueZ = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[4]));
                            pScale = CHelper.myToSingle((string)dataRow[5]);
                            pShiftX = CHelper.myToSingle((string)dataRow[6]);
                            pShiftY = CHelper.myToSingle((string)dataRow[7]);
                            pShiftZ = CHelper.myToSingle((string)dataRow[8]);
                            pAutoTurn = Convert.ToInt32(dataRow[9]);
                        }
                        else if (dataRow.ItemArray.GetUpperBound(0) == 7)
                        {
                            pName = (string)dataRow[0];
                            text = (string)dataRow[1];
                            valueX = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[2]));
                            valueY = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[3]));
                            valueZ = Geometry.DegreeToRadian(CHelper.myToSingle((string)dataRow[4]));
                            pScale = CHelper.myToSingle((string)dataRow[5]);
                            pShiftX = 0f;
                            pShiftY = 0f;
                            pShiftZ = CHelper.myToSingle((string)dataRow[6]);
                            pAutoTurn = Convert.ToInt32(dataRow[7]);
                        }
                        Vector3 pAngle = new Vector3(valueX, valueY, valueZ);
                        if (File.Exists(text))
                        {
                            CModelMesh item = new CModelMesh(this.device, text, pName, pAngle, pScale, pShiftX, pShiftY, pShiftZ, pAutoTurn);
                            this.ModelMeshs.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadSounds(string pFile)
        {
            try
            {
                this.m_SoundNames.Clear();
                this.mySound.ClearSounds();
                this.mySound = new CSounds(this.m_MapPanel);
                this.m_SoundNames = new List<string>();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pFile);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string text = (string)dataRow[0];
                        this.mySound.LoadSound(text);
                        string soundName = CHelper.GetSoundName(text);
                        this.m_SoundNames.Add(soundName);
                    }
                }
            }
            catch
            {
            }
        }
        public int GetSoundIndex(string name)
        {
            int result = -1;
            if (this.m_SoundNames.Count > 0)
            {
                for (int i = 0; i < this.m_SoundNames.Count; i++)
                {
                    if (this.m_SoundNames[i].Length == name.Length && this.m_SoundNames[i].ToUpper() == name.ToUpper())
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }
        public void LoadBillboardMeshs(string pBillboard3DsFile)
        {
            this.m_BillboardMeshs.Clear();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(pBillboard3DsFile);
            DataTable dataTable = dataSet.Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    string pName = (string)dataRow[0];
                    string text = (string)dataRow[1];
                    int pcols = Convert.ToInt32(dataRow[2]);
                    int prows = Convert.ToInt32(dataRow[3]);
                    int pdelay = Convert.ToInt32(dataRow[4]);
                    float pWidth = CHelper.myToSingle((string)dataRow[5]);
                    float pHeight = CHelper.myToSingle((string)dataRow[6]);
                    float pShiftZ = CHelper.myToSingle((string)dataRow[7]);
                    if (File.Exists(text))
                    {
                        CBillboardMesh item = new CBillboardMesh(pName, this.device, text, pcols, prows, pdelay, pWidth, pHeight, pShiftZ);
                        this.m_BillboardMeshs.Add(item);
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.OnPaint();
            this.m_MapPanel.Invalidate();
        }
        private bool CounterHit(int pPosX, int pPosY, float tyleMH)
        {
            int num = 10;
            int counterPos = this.CounterPos;
            int num2 = 100;
            int num3 = this.CounterPos - 10;
            bool result = false;
            if ((float)pPosX > (float)num * tyleMH && (float)pPosX < (float)(num + num2) * tyleMH && (float)pPosY > (float)counterPos * tyleMH && (float)pPosY < (float)(counterPos + num3) * tyleMH)
            {
                result = true;
            }
            return result;
        }
        private string GetMenuTitleText(int i)
        {
            string text = this.myMenu.mnuItems[i].Title;
            if (text.Length == 0)
            {
                if (i == 0)
                {
                    text = this.myMenu.mnuItems[i].Name;
                }
                else
                {
                    text = this.GetMenuTitleText(i - 1);
                }
            }
            return text;
        }
        public void RunTongHop(string TongHopID)
        {
            int tongHopItemIndex = this.myMenu.GetTongHopItemIndex(TongHopID);
            if (tongHopItemIndex > -1)
            {
                this.bAutoRun = true;
                this.StartItem(tongHopItemIndex);
                return;
            }
            this.bAutoRun = false;
        }
        private void StartItem(int i)
        {
            this.runactions = this.myMenu.GetActs(i);
            this.TotalTimeSpan = CHelper.GetTimeSpan(this.runactions.StopTickCount);
            this.CurrAct = i;
            this.ResetAction();
            this.StartActions();
            this.MenuTitleText = this.GetMenuTitleText(this.CurrAct);
            this.bMenuHidden = true;
            this.TerrainVisible = true;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.LastMouseX = e.X;
            this.LastMouseY = e.Y;
            if (!this.bMenuHidden)
            {
                int itemIndex = this.myMenu.GetItemIndex(e.X, e.Y, this.tyleMH);
                if (itemIndex >= 0)
                {
                    this.StopAction();
                    if (itemIndex != this.CurrAct)
                    {
                        this.StartItem(itemIndex);
                        return;
                    }
                    this.CurrAct = -1;
                    this.bMenuHidden = false;
                    this.MenuTitleText = "";
                    return;
                }
            }
            else if (this.CounterHit(e.X, e.Y, this.tyleMH))
            {
                if (this.bAutoRun)
                {
                    this.RiseESC();
                    return;
                }
                this.StopAction();
                this.CurrAct = -1;
                this.bMenuHidden = false;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int num = e.X - this.LastMouseX;
                int num2 = e.Y - this.LastMouseY;
                this.LastMouseX = e.X;
                this.LastMouseY = e.Y;
                if (num != 0 || num2 != 0)
                {
                    this.angleX -= (float)num2 / 200f;
                    this.angleZ += (float)num / 100f;
                    if (this.angleZ > 3.14159274f)
                    {
                        this.angleZ -= 6.28318548f;
                    }
                    if (this.angleZ < -3.14159274f)
                    {
                        this.angleZ += 6.28318548f;
                    }
                }
            }
        }
        public void TangAngleZ(float delta)
        {
            this.angleZ += delta;
            if (this.angleZ > 3.14159274f)
            {
                this.angleZ -= 6.28318548f;
            }
            if (this.angleZ < -3.14159274f)
            {
                this.angleZ += 6.28318548f;
            }
        }
        public void TangAngleX(float delta)
        {
            this.angleX += delta;
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (this.cameraPos.Y >= -300f)
                {
                    this.cameraPos.Y = this.cameraPos.Y - 5f;
                    this.cameraPos.Z = this.cameraPos.Y / 2f;
                    return;
                }
            }
            else if (e.Delta < 0 && this.cameraPos.Y <= -10f)
            {
                this.cameraPos.Y = this.cameraPos.Y + 5f;
                this.cameraPos.Z = this.cameraPos.Y / 2f;
            }
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vector2 cursorpos = new Vector2((float)e.X, (float)e.Y);
            Vector3 pickingPoint = CRay.GetPickingPoint(this.device, this.myTerrain.v3vertices, cursorpos, this.worldMatrix, this.viewMatrix, this.projectionMatrix);
            if (pickingPoint != Vector3.Empty)
            {
                this.CenterX = pickingPoint.X / (float)this.myTerrain.WIDTH;
                this.CenterY = pickingPoint.Y / (float)this.myTerrain.HEIGHT;
            }
        }
        public void ChangeFocus(float X, float Y)
        {
            this.CenterX = X;
            this.CenterY = Y;
        }
        public void ChangeFocus(float X, float Y, Vector3 pcameraPos, float pangleZ, float pangleX)
        {
            this.cameraPos.X = pcameraPos.X;
            this.cameraPos.Y = pcameraPos.Y;
            this.cameraPos.Z = pcameraPos.Z;
            this.angleZ = pangleZ;
            this.angleX = pangleX;
            this.CenterX = X;
            this.CenterY = Y;
        }
        public void SwitchFillMode()
        {
            if (this.myTerrain.myFillMode == FillMode.Solid)
            {
                this.myTerrain.myFillMode = FillMode.WireFrame;
            }
            else
            {
                this.myTerrain.myFillMode = FillMode.Solid;
            }
            this.device.RenderState.FillMode = this.myTerrain.myFillMode;
        }
        public float getAngleZ()
        {
            return this.angleZ;
        }
        public float getAngleX()
        {
            return this.angleX;
        }
        public CSpriteObj Add1SpriteObj(string texfile, float pwidth, float pheight, int pVertical, Vector3 pPos, float pshiftZ)
        {
            CSpriteObj cSpriteObj = null;
            try
            {
                cSpriteObj = new CSpriteObj(this, pwidth, pheight, pVertical, texfile, pPos, pshiftZ);
                this.SpriteObjs.Add(cSpriteObj);
            }
            catch
            {
            }
            return cSpriteObj;
        }
        public void RemoveSpriteObj(CSpriteObj pObj)
        {
            this.SpriteObjs.Remove(pObj);
        }
        public List<Texture> GetTexs(string name)
        {
            List<Texture> list = null;
            for (int i = 0; i < this.SpriteTexs.Count; i++)
            {
                if (this.SpriteTexs[i].Name.IndexOf(name) > -1)
                {
                    list = this.SpriteTexs[i].texs;
                }
            }
            if (list == null)
            {
                list = new List<Texture>();
                list.Add(this.getBlankTexture());
            }
            return list;
        }
        public Texture getBlankTexture()
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Position = 0L;
            return TextureLoader.FromStream(this.device, memoryStream, (int)memoryStream.Length, bitmap.Width, bitmap.Height, 1, Usage.None, Format.Unknown, Pool.Managed, Filter.None, Filter.None, Color.White.ToArgb());
        }
        public void LoadSpriteTexs(string pFile)
        {
            try
            {
                this.SpriteTexs.Clear();
                int pColorKey = Color.Black.ToArgb();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pFile);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string text = (string)dataRow[0];
                        int ptexCount = Convert.ToInt32(dataRow[1]);
                        int pWidth = Convert.ToInt32(dataRow[2]);
                        int pHeight = Convert.ToInt32(dataRow[3]);
                        if (File.Exists(text))
                        {
                            CSpriteTex item = new CSpriteTex(this.device, text, pColorKey, ptexCount, pWidth, pHeight);
                            this.SpriteTexs.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadTexObjs(string pFile)
        {
            try
            {
                this.texObjs.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(pFile);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string pName = (string)dataRow[0];
                        string pTexFile = (string)dataRow[1];
                        int pWIDTH = Convert.ToInt32(dataRow[2]);
                        int pHEIGHT = Convert.ToInt32(dataRow[3]);
                        int pShiftX = Convert.ToInt32(dataRow[4]);
                        int pShiftY = Convert.ToInt32(dataRow[5]);
                        int pImageWidth = Convert.ToInt32(dataRow[6]);
                        int pImageHeight = Convert.ToInt32(dataRow[7]);
                        CTexObj item = new CTexObj(pName, this.device, pTexFile, this.myTerrain.heightData, pWIDTH, pHEIGHT, this.myTerrain.SCALE_FACTOR, pShiftX, pShiftY, pImageWidth, pImageHeight);
                        this.texObjs.Add(item);
                    }
                }
                dataSet.Dispose();
            }
            catch
            {
            }
        }
        public void Create1TexObj(string pName, string pImageFile, int pWidth, int pHeight, int pShiftX, int pShiftY, int pImageWidth, int pImageHeight)
        {
            CTexObj item = new CTexObj(pName, this.device, pImageFile, this.myTerrain.heightData, pWidth, pHeight, this.myTerrain.SCALE_FACTOR, pShiftX, pShiftY, pImageWidth, pImageHeight);
            this.texObjs.Add(item);
        }
        public CActObj GetActObjByName(string name)
        {
            CActObj cActObj = null;
            if (this.Models.Count > 0)
            {
                for (int i = 0; i < this.Models.Count; i++)
                {
                    if (this.Models[i].Name.Length == name.Length && this.Models[i].Name.ToUpper() == name.ToUpper())
                    {
                        cActObj = this.Models[i];
                        cActObj.ObjType = "Model";
                        break;
                    }
                }
            }
            if (cActObj == null && this.texObjs.Count > 0)
            {
                for (int j = 0; j < this.texObjs.Count; j++)
                {
                    if (this.texObjs[j].Name.Length == name.Length && this.texObjs[j].Name.ToUpper() == name.ToUpper())
                    {
                        cActObj = this.texObjs[j];
                        cActObj.ObjType = "TexObj";
                        break;
                    }
                }
            }
            if (cActObj == null && this.Billboards.Count > 0)
            {
                for (int k = 0; k < this.Billboards.Count; k++)
                {
                    if (this.Billboards[k].Name.Length == name.Length && this.Billboards[k].Name.ToUpper() == name.ToUpper())
                    {
                        cActObj = this.Billboards[k];
                        cActObj.ObjType = "Billboard";
                        break;
                    }
                }
            }
            return cActObj;
        }
        public CTexObj GetTexObjByName(string name)
        {
            CTexObj result = null;
            if (this.texObjs.Count > 0)
            {
                for (int i = 0; i < this.texObjs.Count; i++)
                {
                    if (this.texObjs[i].Name.Length == name.Length && this.texObjs[i].Name.ToUpper() == name.ToUpper())
                    {
                        result = this.texObjs[i];
                        break;
                    }
                }
            }
            return result;
        }
        public CModel GetModelByName(string name)
        {
            CModel result = null;
            if (this.Models.Count > 0)
            {
                for (int i = 0; i < this.Models.Count; i++)
                {
                    if (this.Models[i].Name.Length == name.Length && this.Models[i].Name.ToUpper() == name.ToUpper())
                    {
                        result = this.Models[i];
                        break;
                    }
                }
            }
            return result;
        }
        public CBillboard GetBillboardByName(string name)
        {
            CBillboard result = null;
            if (this.Billboards.Count > 0)
            {
                for (int i = 0; i < this.Billboards.Count; i++)
                {
                    if (this.Billboards[i].Name.Length == name.Length && this.Billboards[i].Name.ToUpper() == name.ToUpper())
                    {
                        result = this.Billboards[i];
                        break;
                    }
                }
            }
            return result;
        }
        public void LoadMenu(string pFileName)
        {
            this.myMenu = new CMnu(this);
            this.myMenu.LoadScripts(pFileName);
        }
    }
}
