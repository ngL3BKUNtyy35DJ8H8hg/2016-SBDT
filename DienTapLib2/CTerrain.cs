using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DienTapLib
{
	public class CTerrain : IDisposable
	{
		public Vector3 cameraPos;
		public Vector3 cameraTarget;
		public float CenterX = 0.5f;
		public float CenterY = 0.5f;
		private float angleZ;
		private float angleX;
		private float angleY;
		private Panel m_MapPanel;
		private List<CBillboardMesh> m_BillboardMeshs;
		public List<CBillboard> Billboards;
		private List<CModelMesh> m_ModelMeshs;
		public List<CModel> Models;
		private float DoCao;
		private Timer timer1 = new Timer();
		private CTerrainMesh myTerrain;
		private Matrix worldMatrix;
		private Matrix viewMatrix;
		private Matrix projectionMatrix;
		private Device device;
		private PresentParameters presentParams = new PresentParameters();
		private bool deviceLost;
		private int LastMouseX;
		private int LastMouseY;
		private int LastMouseX2;
		private int LastMouseY2;
		private Microsoft.DirectX.Direct3D.Font text;
		private bool _disposed;
		public List<CBillboardMesh> BillboardMeshs
		{
			get
			{
				return this.m_BillboardMeshs;
			}
		}
		public List<CModelMesh> ModelMeshs
		{
			get
			{
				return this.m_ModelMeshs;
			}
		}
		private void InitializeFont()
		{
			System.Drawing.Font font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular);
			this.text = new Microsoft.DirectX.Direct3D.Font(this.device, font);
		}
		public float GetAngleX()
		{
			return this.angleX;
		}
		public float GetAngleZ()
		{
			return this.angleZ;
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
		public CTerrain(Panel pMapPanel, float[,] pheightData, float pSCALE_FACTOR, char pDecSepa, char pGrpSepa)
		{
			this.m_MapPanel = pMapPanel;
			this.InitializeDevice();
			this.myTerrain = new CTerrainMesh(this.device, pheightData, pSCALE_FACTOR);
			this.m_BillboardMeshs = new List<CBillboardMesh>();
			this.Billboards = new List<CBillboard>();
			this.m_ModelMeshs = new List<CModelMesh>();
			this.Models = new List<CModel>();
		}
		~CTerrain()
		{
			this.Dispose(false);
		}
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed && disposing)
			{
				this.Clear();
				this.ClearBillboards();
				this.ClearModels();
				this.myTerrain.Dispose();
				this.device.Dispose();
			}
			this._disposed = true;
		}
		public void LoadMemStream(Bitmap pTexImage)
		{
			this.myTerrain.LoadMemStream(pTexImage);
		}
		public void InitTerrain(Bitmap pTexImage, Vector3 pcameraPos, Vector3 pcameraTarget, float pangleX, Vector3 plightDirection)
		{
			this.myTerrain.LoadMemStream(pTexImage);
			this.myTerrain.ResetTerrain();
			this.cameraPos = pcameraPos;
			this.cameraTarget = pcameraTarget;
			this.angleX = pangleX;
			this.myTerrain.lightDirection = plightDirection;
			this.InitializeFont();
			this.m_MapPanel.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
			this.m_MapPanel.MouseDoubleClick += new MouseEventHandler(this.Form1_MouseDoubleClick);
			this.m_MapPanel.Paint += new PaintEventHandler(this.Form1_Paint);
			this.m_MapPanel.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
			this.m_MapPanel.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.myTerrain.SetLights();
		}
		public void Clear()
		{
			this.m_MapPanel.MouseWheel -= new MouseEventHandler(this.Form1_MouseWheel);
			this.m_MapPanel.MouseDoubleClick -= new MouseEventHandler(this.Form1_MouseDoubleClick);
			this.m_MapPanel.Paint -= new PaintEventHandler(this.Form1_Paint);
			this.m_MapPanel.MouseDown -= new MouseEventHandler(this.Form1_MouseDown);
			this.m_MapPanel.MouseMove -= new MouseEventHandler(this.Form1_MouseMove);
			this.timer1.Tick -= new EventHandler(this.timer1_Tick);
			this.myTerrain.Dispose();
			this.device.Dispose();
		}
		private void InitializeDevice()
		{
			this.presentParams.Windowed = true;
			this.presentParams.SwapEffect = SwapEffect.Discard;
			this.presentParams.AutoDepthStencilFormat = DepthFormat.D16;
			this.presentParams.EnableAutoDepthStencil = true;
			this.device = new Device(0, DeviceType.Hardware, this.m_MapPanel, CreateFlags.SoftwareVertexProcessing, new PresentParameters[]
			{
				this.presentParams
			});
			this.device.DeviceReset += new EventHandler(this.OnDeviceReset);
			this.device.DeviceLost += new EventHandler(this.OnDeviceLost);
		}
		protected void OnDeviceLost(object sender, EventArgs e)
		{
		}
		private void OnDeviceReset(object sender, EventArgs e)
		{
			this.myTerrain.ResetTerrain();
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
		public Surface GetRenderSurface()
		{
			return this.myTerrain.GetRenderSurface();
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
			this.device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.LightBlue, 1f, 0);
			if (this.DoCao > 0f)
			{
				this.text.DrawText(null, this.DoCao.ToString("0.##"), new Point(this.LastMouseX2 + 4, this.LastMouseY2 - 12), Color.OrangeRed);
			}
			this.device.Transform.Projection = this.projectionMatrix;
			this.device.Transform.View = this.viewMatrix;
			this.device.Transform.World = this.worldMatrix;
			this.device.BeginScene();
			this.device.RenderState.Lighting = true;
			this.device.RenderState.AlphaBlendEnable = false;
			this.myTerrain.Render();
			this.RenderModels(this.worldMatrix);
			this.device.RenderState.Lighting = false;
			this.device.RenderState.AlphaBlendEnable = true;
			this.RenderBillboards(this.worldMatrix);
			this.device.EndScene();
			try
			{
				this.device.Present();
			}
			catch (DeviceLostException)
			{
				this.deviceLost = true;
			}
		}
		private void RenderModels(Matrix pTerrainMatrix)
		{
			foreach (CModel current in this.Models)
			{
				current.Render(pTerrainMatrix, this.angleZ);
			}
		}
		private void RenderBillboards(Matrix pTerrainMatrix)
		{
			foreach (CBillboard current in this.Billboards)
			{
				current.Render(pTerrainMatrix, this.angleZ);
			}
		}
		public static float DegreeToRadian(float pHeading)
		{
			return Geometry.DegreeToRadian(pHeading);
		}
		public void ClearModels()
		{
			this.Models.Clear();
		}
		public void ClearBillboards()
		{
			this.Billboards.Clear();
		}
		public void Load1Model(string pName, int pModelIndex, Vector3 pPos, float dHeading)
		{
			CModelMesh pCModelMesh = this.m_ModelMeshs[pModelIndex];
			CModel cModel = new CModel(pName, this.device, pCModelMesh, pPos, dHeading);
			cModel.Z = this.myTerrain.getZ(cModel.X, cModel.Y);
			this.Models.Add(cModel);
		}
		public int GetModelMeshIndex(string pDesc)
		{
			int result = -1;
			foreach (CModelMesh current in this.m_ModelMeshs)
			{
				if (pDesc.IndexOf(current.myName) > -1)
				{
					result = this.m_ModelMeshs.IndexOf(current);
					break;
				}
			}
			return result;
		}
		public void Load1ModelMesh(string mMeshFile, string mName, float mDegreeX, float mDegreeY, float mDegreeZ, float mScale, float mShiftX, float mShiftY, float mShiftZ, int mAutoTurn)
		{
			float valueX = Geometry.DegreeToRadian(mDegreeX);
			float valueY = Geometry.DegreeToRadian(mDegreeY);
			float valueZ = Geometry.DegreeToRadian(mDegreeZ);
			Vector3 pAngle = new Vector3(valueX, valueY, valueZ);
			CModelMesh item = new CModelMesh(this.device, mMeshFile, mName, pAngle, mScale, mShiftX, mShiftY, mShiftZ, mAutoTurn);
			this.m_ModelMeshs.Clear();
			this.m_ModelMeshs.Add(item);
		}
		public void LoadModelMeshs(string pModel3DsFile)
		{
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
						this.m_ModelMeshs.Add(item);
					}
				}
			}
		}
		public void LoadBillboardMeshs(string pBillboard3DsFile)
		{
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
		public void Load1Billboard(string pName, int pBillboardIndex, Vector3 pPos)
		{
			CBillboardMesh pBillboardMesh = this.m_BillboardMeshs[pBillboardIndex];
			CBillboard cBillboard = new CBillboard(this.myTerrain, pName, this.device, pBillboardMesh, pPos, 0f);
			cBillboard.Z = this.myTerrain.getZ(cBillboard.Position.X, cBillboard.Position.Y);
			this.Billboards.Add(cBillboard);
		}
		public void Load1Billboard(string pName, int pBillboardIndex, Vector3 pPos, float dHeading)
		{
			CBillboardMesh pBillboardMesh = this.m_BillboardMeshs[pBillboardIndex];
			CBillboard cBillboard = new CBillboard(this.myTerrain, pName, this.device, pBillboardMesh, pPos, dHeading);
			cBillboard.Z = this.myTerrain.getZ(cBillboard.Position.X, cBillboard.Position.Y);
			this.Billboards.Add(cBillboard);
		}
		public int GetBillboardMeshIndex(string pDesc)
		{
			int result = -1;
			foreach (CBillboardMesh current in this.m_BillboardMeshs)
			{
				if (pDesc.IndexOf(current.Name) > -1)
				{
					result = this.m_BillboardMeshs.IndexOf(current);
					break;
				}
			}
			return result;
		}
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			this.OnPaint();
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.LastMouseX = e.X;
			this.LastMouseY = e.Y;
		}
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			this.DoCao = 0f;
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
					this.OnPaint();
					return;
				}
			}
			else
			{
				if (this.LastMouseX2 != e.X || this.LastMouseY2 != e.Y)
				{
					this.LastMouseX2 = e.X;
					this.LastMouseY2 = e.Y;
					this.timer1.Enabled = true;
					this.timer1.Interval = 400;
					return;
				}
				this.timer1.Enabled = false;
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			Vector2 cursorpos = new Vector2((float)this.LastMouseX2, (float)this.LastMouseY2);
			Vector3 pickingPoint = CRay.GetPickingPoint(this.device, this.myTerrain.v3vertices, cursorpos, this.worldMatrix, this.viewMatrix, this.projectionMatrix);
			if (pickingPoint != Vector3.Empty)
			{
				this.DoCao = -pickingPoint.Z * this.myTerrain.SCALE_FACTOR;
				this.OnPaint();
			}
			else
			{
				this.DoCao = 0f;
				this.OnPaint();
			}
			this.DoCao = 0f;
			this.timer1.Enabled = false;
		}
		private void Form1_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				if (this.cameraPos.Y >= -300f)
				{
					this.cameraPos.Y = this.cameraPos.Y - 5f;
					this.cameraPos.Z = this.cameraPos.Y / 2f;
				}
			}
			else if (e.Delta < 0 && this.cameraPos.Y <= -10f)
			{
				this.cameraPos.Y = this.cameraPos.Y + 5f;
				this.cameraPos.Z = this.cameraPos.Y / 2f;
			}
			this.OnPaint();
			this.DoCao = 0f;
			this.timer1.Enabled = false;
		}
		private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Vector2 cursorpos = new Vector2((float)e.X, (float)e.Y);
			Vector3 pickingPoint = CRay.GetPickingPoint(this.device, this.myTerrain.v3vertices, cursorpos, this.worldMatrix, this.viewMatrix, this.projectionMatrix);
			if (pickingPoint != Vector3.Empty)
			{
				this.CenterX = pickingPoint.X / (float)this.myTerrain.WIDTH;
				this.CenterY = pickingPoint.Y / (float)this.myTerrain.HEIGHT;
				this.OnPaint();
			}
		}
		public void ChangeFocus(float X, float Y)
		{
			this.CenterX = X;
			this.CenterY = Y;
			this.OnPaint();
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
			this.OnPaint();
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
			this.OnPaint();
		}
		public void SaveToJPEG(string pFileName)
		{
			SurfaceLoader.Save(pFileName, ImageFileFormat.Jpg, this.device.GetBackBuffer(0, 0, BackBufferType.Mono));
		}
	}
}
