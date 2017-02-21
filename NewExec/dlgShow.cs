using AxMapXLib;
using MapXLib;
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PowerPoint;
using SaBan.My.Resources;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaBan
{
	[DesignerGenerated]
	public class dlgShow : Form
	{
		private IContainer components;

		[AccessedThroughProperty("AxMap1")]
		private AxMap _AxMap1;

		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		[AccessedThroughProperty("ZoomInToolStripButton")]
		private ToolStripButton _ZoomInToolStripButton;

		[AccessedThroughProperty("ZoomOutToolStripButton")]
		private ToolStripButton _ZoomOutToolStripButton;

		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[AccessedThroughProperty("ToPPTToolStripButton")]
		private ToolStripButton _ToPPTToolStripButton;

		[AccessedThroughProperty("PrevToolStripButton")]
		private ToolStripButton _PrevToolStripButton;

		[AccessedThroughProperty("NextToolStripButton")]
		private ToolStripButton _NextToolStripButton;

		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		[AccessedThroughProperty("ExitToolStripButton")]
		private ToolStripButton _ExitToolStripButton;

		private CPages myPages;

		private CSymbols m_DrawingSymbols;

		private int PageCount;

		public int iCurrPage;

		private float ZoomDelta;

		internal virtual AxMap AxMap1
		{
			get
			{
				return this._AxMap1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AxMapXLib.CMapXEvents_MouseMoveEventHandler value2 = new AxMapXLib.CMapXEvents_MouseMoveEventHandler(this.AxMap1_MouseMoveEvent);
				AxMapXLib.CMapXEvents_DrawUserLayerEventHandler value3 = new AxMapXLib.CMapXEvents_DrawUserLayerEventHandler(this.AxMap1_DrawUserLayer);
				if (this._AxMap1 != null)
				{
					this._AxMap1.MouseMoveEvent -= value2;
					this._AxMap1.DrawUserLayer -= value3;
				}
				this._AxMap1 = value;
				if (this._AxMap1 != null)
				{
					this._AxMap1.MouseMoveEvent += value2;
					this._AxMap1.DrawUserLayer += value3;
				}
			}
		}

		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		internal virtual ToolStripButton ZoomInToolStripButton
		{
			get
			{
				return this._ZoomInToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ZoomInToolStripButton_Click);
				if (this._ZoomInToolStripButton != null)
				{
					this._ZoomInToolStripButton.Click -= value2;
				}
				this._ZoomInToolStripButton = value;
				if (this._ZoomInToolStripButton != null)
				{
					this._ZoomInToolStripButton.Click += value2;
				}
			}
		}

		internal virtual ToolStripButton ZoomOutToolStripButton
		{
			get
			{
				return this._ZoomOutToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ZoomOutToolStripButton_Click);
				if (this._ZoomOutToolStripButton != null)
				{
					this._ZoomOutToolStripButton.Click -= value2;
				}
				this._ZoomOutToolStripButton = value;
				if (this._ZoomOutToolStripButton != null)
				{
					this._ZoomOutToolStripButton.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		internal virtual ToolStripButton ToPPTToolStripButton
		{
			get
			{
				return this._ToPPTToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToPPTToolStripButton_Click);
				if (this._ToPPTToolStripButton != null)
				{
					this._ToPPTToolStripButton.Click -= value2;
				}
				this._ToPPTToolStripButton = value;
				if (this._ToPPTToolStripButton != null)
				{
					this._ToPPTToolStripButton.Click += value2;
				}
			}
		}

		internal virtual ToolStripButton PrevToolStripButton
		{
			get
			{
				return this._PrevToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PrevToolStripButton_Click);
				if (this._PrevToolStripButton != null)
				{
					this._PrevToolStripButton.Click -= value2;
				}
				this._PrevToolStripButton = value;
				if (this._PrevToolStripButton != null)
				{
					this._PrevToolStripButton.Click += value2;
				}
			}
		}

		internal virtual ToolStripButton NextToolStripButton
		{
			get
			{
				return this._NextToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NextToolStripButton_Click);
				if (this._NextToolStripButton != null)
				{
					this._NextToolStripButton.Click -= value2;
				}
				this._NextToolStripButton = value;
				if (this._NextToolStripButton != null)
				{
					this._NextToolStripButton.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		internal virtual ToolStripButton ExitToolStripButton
		{
			get
			{
				return this._ExitToolStripButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitToolStripButton_Click);
				if (this._ExitToolStripButton != null)
				{
					this._ExitToolStripButton.Click -= value2;
				}
				this._ExitToolStripButton = value;
				if (this._ExitToolStripButton != null)
				{
					this._ExitToolStripButton.Click += value2;
				}
			}
		}

		public dlgShow()
		{
			base.FormClosing += new FormClosingEventHandler(this.dlgShow_FormClosing);
			base.Load += new EventHandler(this.dlgShow_Load);
			this.m_DrawingSymbols = new CSymbols();
			this.iCurrPage = 0;
			this.ZoomDelta = 0.05f;
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dlgShow));
			this.ToolStrip1 = new ToolStrip();
			this.ExitToolStripButton = new ToolStripButton();
			this.ToolStripSeparator1 = new ToolStripSeparator();
			this.PrevToolStripButton = new ToolStripButton();
			this.NextToolStripButton = new ToolStripButton();
			this.ToolStripSeparator2 = new ToolStripSeparator();
			this.ZoomInToolStripButton = new ToolStripButton();
			this.ZoomOutToolStripButton = new ToolStripButton();
			this.ToolStripSeparator3 = new ToolStripSeparator();
			this.ToPPTToolStripButton = new ToolStripButton();
			this.AxMap1 = new AxMap();
			this.ToolStrip1.SuspendLayout();
			((ISupportInitialize)this.AxMap1).BeginInit();
			this.SuspendLayout();
			this.ToolStrip1.Dock = DockStyle.None;
			this.ToolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.ExitToolStripButton,
				this.ToolStripSeparator1,
				this.PrevToolStripButton,
				this.NextToolStripButton,
				this.ToolStripSeparator2,
				this.ZoomInToolStripButton,
				this.ZoomOutToolStripButton,
				this.ToolStripSeparator3,
				this.ToPPTToolStripButton
			});
			Control arg_12B_0 = this.ToolStrip1;
			System.Drawing.Point location = new System.Drawing.Point(0, 0);
			arg_12B_0.Location = location;
			this.ToolStrip1.Name = "ToolStrip1";
			Control arg_156_0 = this.ToolStrip1;
			Size size = new Size(226, 25);
			arg_156_0.Size = size;
			this.ToolStrip1.TabIndex = 3;
			this.ToolStrip1.Text = "ToolStrip1";
			this.ExitToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.ExitToolStripButton.Image = (Image)componentResourceManager.GetObject("ExitToolStripButton.Image");
			this.ExitToolStripButton.ImageTransparentColor = Color.Magenta;
			this.ExitToolStripButton.Name = "ExitToolStripButton";
			ToolStripItem arg_1D1_0 = this.ExitToolStripButton;
			size = new Size(29, 22);
			arg_1D1_0.Size = size;
			this.ExitToolStripButton.Text = "Exit";
			this.ExitToolStripButton.ToolTipText = "Thoát";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripItem arg_218_0 = this.ToolStripSeparator1;
			size = new Size(6, 25);
			arg_218_0.Size = size;
			this.PrevToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.PrevToolStripButton.Image = Resources.GoToPrevious;
			this.PrevToolStripButton.ImageTransparentColor = Color.Magenta;
			this.PrevToolStripButton.Name = "PrevToolStripButton";
			ToolStripItem arg_26C_0 = this.PrevToolStripButton;
			size = new Size(23, 22);
			arg_26C_0.Size = size;
			this.PrevToolStripButton.Text = "Trang trước";
			this.PrevToolStripButton.ToolTipText = "Trang trước";
			this.NextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.NextToolStripButton.Image = Resources.GoToNext;
			this.NextToolStripButton.ImageTransparentColor = Color.Magenta;
			this.NextToolStripButton.Name = "NextToolStripButton";
			ToolStripItem arg_2E0_0 = this.NextToolStripButton;
			size = new Size(23, 22);
			arg_2E0_0.Size = size;
			this.NextToolStripButton.Text = "Trang sau";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripItem arg_317_0 = this.ToolStripSeparator2;
			size = new Size(6, 25);
			arg_317_0.Size = size;
			this.ZoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ZoomInToolStripButton.Image = Resources.zoomin;
			this.ZoomInToolStripButton.ImageTransparentColor = Color.Magenta;
			this.ZoomInToolStripButton.Name = "ZoomInToolStripButton";
			ToolStripItem arg_36B_0 = this.ZoomInToolStripButton;
			size = new Size(23, 22);
			arg_36B_0.Size = size;
			this.ZoomInToolStripButton.Text = "Phóng to";
			this.ZoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ZoomOutToolStripButton.Image = Resources.zoomout;
			this.ZoomOutToolStripButton.ImageTransparentColor = Color.Magenta;
			this.ZoomOutToolStripButton.Name = "ZoomOutToolStripButton";
			ToolStripItem arg_3CF_0 = this.ZoomOutToolStripButton;
			size = new Size(23, 22);
			arg_3CF_0.Size = size;
			this.ZoomOutToolStripButton.Text = "Thu nhỏ";
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			ToolStripItem arg_406_0 = this.ToolStripSeparator3;
			size = new Size(6, 25);
			arg_406_0.Size = size;
			this.ToPPTToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.ToPPTToolStripButton.Image = (Image)componentResourceManager.GetObject("ToPPTToolStripButton.Image");
			this.ToPPTToolStripButton.ImageTransparentColor = Color.Magenta;
			this.ToPPTToolStripButton.Name = "ToPPTToolStripButton";
			ToolStripItem arg_465_0 = this.ToPPTToolStripButton;
			size = new Size(44, 22);
			arg_465_0.Size = size;
			this.ToPPTToolStripButton.Text = "To PPT";
			this.ToPPTToolStripButton.ToolTipText = "Xuất ra PowerPoint";
			this.AxMap1.Dock = DockStyle.Fill;
			this.AxMap1.Enabled = true;
			Control arg_4B2_0 = this.AxMap1;
			location = new System.Drawing.Point(0, 0);
			arg_4B2_0.Location = location;
			this.AxMap1.Name = "AxMap1";
			this.AxMap1.OcxState = (AxHost.State)componentResourceManager.GetObject("AxMap1.OcxState");
			Control arg_4FB_0 = this.AxMap1;
			size = new Size(435, 315);
			arg_4FB_0.Size = size;
			this.AxMap1.TabIndex = 2;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(435, 315);
			this.ClientSize = size;
			this.Controls.Add(this.ToolStrip1);
			this.Controls.Add(this.AxMap1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FormBorderStyle = FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "dlgShow";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "dlgShow";
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			((ISupportInitialize)this.AxMap1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dlgShow_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void dlgShow_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			try
			{
				myModule.fMain.initBanDo(this.AxMap1);
				this.myPages = new CPages();
				try
				{
					IEnumerator enumerator = myModule.fMain.myPages.GetEnumerator();
					while (enumerator.MoveNext())
					{
						CPage cPage = (CPage)enumerator.Current;
						this.myPages.AddNewPage(cPage.Symbols);
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
				this.PageCount = this.myPages.Count;
			}
			catch (Exception expr_84)
			{
				ProjectData.SetProjectError(expr_84);
				Exception ex = expr_84;
				MessageBox.Show("SaiRoi: " + ex.Message);
				this.Dispose();
				ProjectData.ClearProjectError();
			}
			this.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, myModule.fMain.AxMap1.CenterX, myModule.fMain.AxMap1.CenterY);
			this.ShowPage(this.iCurrPage);
		}

		private void ShowPage(int pPageIndex)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				CPage cPage = this.myPages[pPageIndex];
				if (!Information.IsNothing(cPage))
				{
					this.m_DrawingSymbols = CSymbols.String2KHs(cPage.Symbols);
				}
				this.AxMap1.Refresh();
			}
			catch (Exception expr_40)
			{
				ProjectData.SetProjectError(expr_40);
				Exception ex = expr_40;
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Show Error");
				ProjectData.ClearProjectError();
			}
			this.Cursor = Cursors.Default;
			this.iCurrPage = pPageIndex;
			this.AxMap1.Select();
			this.AxMap1.CurrentTool = ToolConstants.miPanTool;
		}

		private void Exp2PPT(string pFileSpec)
		{
			PowerPoint.Application application = new ApplicationClass();
			application.Visible = MsoTriState.msoTrue;
			application.WindowState = PpWindowState.ppWindowMinimized;
			Presentation presentation = application.Presentations.Add(MsoTriState.msoTrue);
			float slideWidth = application.ActivePresentation.PageSetup.SlideWidth;
			float slideHeight = application.ActivePresentation.PageSetup.SlideHeight;
			string text = System.Windows.Forms.Application.StartupPath + "\\\\temp.emf";
			this.m_DrawingSymbols.Clear();
			this.ExpBanDo2EMF(text);
			int arg_75_0 = 1;
			int count = this.myPages.Count;
			checked
			{
				for (int i = arg_75_0; i <= count; i++)
				{
					Slide slide = presentation.Slides.Add(i, PpSlideLayout.ppLayoutBlank);
					PowerPoint.Shape shape = slide.Shapes.AddPicture(text, MsoTriState.msoFalse, MsoTriState.msoCTrue, 0f, 0f, slideWidth, slideHeight);
					float num = slideWidth / this.AxMap1.MapScreenWidth;
					float num2 = slideHeight / this.AxMap1.MapScreenHeight;
					this.ShowPage(i - 1);
					RectangleF rect = unchecked(new RectangleF(-20f, -20f, this.AxMap1.MapScreenWidth + 40f, this.AxMap1.MapScreenHeight + 40f));
					int num3 = 0;
					try
					{
						IEnumerator enumerator = this.m_DrawingSymbols.GetEnumerator();
						while (enumerator.MoveNext())
						{
							CSymbol cSymbol = (CSymbol)enumerator.Current;
							if (cSymbol.HitTest(this.AxMap1, rect))
							{
								string[] array = text.Split(new char[]
								{
									'.'
								});
								num3++;
								string text2 = string.Concat(new string[]
								{
									array[0],
									i.ToString("00"),
									num3.ToString("000"),
									".",
									array[1]
								});
								Graphics graphics = this.AxMap1.CreateGraphics();
								IntPtr hdc = graphics.GetHdc();
								Metafile metafile = new Metafile(text2, hdc);
								Graphics graphics2 = Graphics.FromImage(metafile);
								cSymbol.Draw(this.AxMap1, graphics2);
								graphics2.Dispose();
								metafile.Dispose();
								Metafile metafile2 = new Metafile(text2);
								Image arg_202_0 = metafile2;
								GraphicsUnit graphicsUnit = GraphicsUnit.Pixel;
								RectangleF bounds = arg_202_0.GetBounds(ref graphicsUnit);
								metafile2.Dispose();
								unchecked
								{
									float increment = bounds.Left * num;
									float increment2 = bounds.Top * num2;
									float width = bounds.Width * num;
									float height = bounds.Height * num2;
									PowerPoint.Shape shape2 = slide.Shapes.AddPicture(text2, MsoTriState.msoFalse, MsoTriState.msoCTrue, 0f, 0f, width, height);
									PowerPoint.Shape shape3 = shape2;
									shape3.IncrementLeft(increment);
									shape3.IncrementTop(increment2);
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
				presentation.SaveAs(pFileSpec, PpSaveAsFileType.ppSaveAsPresentation, MsoTriState.msoTriStateMixed);
				presentation.Saved = MsoTriState.msoTrue;
				presentation.Close();
				presentation = null;
				application.Quit();
				application = null;
				GC.Collect();
				Interaction.MsgBox("Xuat ra PPT xong.", MsgBoxStyle.OkOnly, null);
			}
		}

		private void ExpBanDo2EMF(string pFileSpec)
		{
			string text = "MapTemp.wmf";
			this.AxMap1.ExportMap(text, ExportFormatConstants.miFormatWMF);
			Metafile image = new Metafile(text);
			Graphics graphics = this.AxMap1.CreateGraphics();
			IntPtr hdc = graphics.GetHdc();
			Metafile metafile = new Metafile(pFileSpec, hdc);
			Graphics graphics2 = Graphics.FromImage(metafile);
			graphics2.DrawImage(image, 0, 0);
			metafile.Dispose();
		}

		private void ToPPTToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PowerPoint files (*.ppt)|*.ppt|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				if (fileName.Length > 0)
				{
					this.Exp2PPT(fileName);
				}
			}
		}

		private void CheckNextPrev()
		{
			if (this.iCurrPage > 0)
			{
				this.PrevToolStripButton.Enabled = true;
			}
			else
			{
				this.PrevToolStripButton.Enabled = false;
			}
			if (this.iCurrPage < checked(this.PageCount - 1))
			{
				this.NextToolStripButton.Enabled = true;
			}
			else
			{
				this.NextToolStripButton.Enabled = false;
			}
		}

		private void AxMap1_DrawUserLayer(object sender, CMapXEvents_DrawUserLayerEvent e)
		{
			IntPtr hdc = new IntPtr(e.hOutputDC);
			Graphics g = Graphics.FromHdc(hdc);
			try
			{
				this.m_DrawingSymbols.DrawSymbols(this.AxMap1, g);
			}
			catch (Exception expr_28)
			{
				ProjectData.SetProjectError(expr_28);
				Exception innerException = expr_28;
				throw new ApplicationException("Error Drawing Graphics Surface", innerException);
			}
			finally
			{
			}
		}

		private void AxMap1_MouseMoveEvent(object sender, CMapXEvents_MouseMoveEvent e)
		{
			if (e.y < 40f & e.x < 300f)
			{
				this.CheckNextPrev();
				this.ToolStrip1.Visible = true;
			}
			else
			{
				this.ToolStrip1.Visible = false;
			}
		}

		private void PrevToolStripButton_Click(object sender, EventArgs e)
		{
			if (this.iCurrPage > 0)
			{
				this.ShowPage(checked(this.iCurrPage - 1));
			}
			this.CheckNextPrev();
		}

		private void NextToolStripButton_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.iCurrPage < this.PageCount - 1)
				{
					this.ShowPage(this.iCurrPage + 1);
				}
				this.CheckNextPrev();
			}
		}

		private void ExitToolStripButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ZoomInToolStripButton_Click(object sender, EventArgs e)
		{
			this.AxMap1.ZoomTo(this.AxMap1.Zoom * (1.0 - (double)this.ZoomDelta), this.AxMap1.CenterX, this.AxMap1.CenterY);
		}

		private void ZoomOutToolStripButton_Click(object sender, EventArgs e)
		{
			this.AxMap1.ZoomTo(this.AxMap1.Zoom * (1.0 + (double)this.ZoomDelta), this.AxMap1.CenterX, this.AxMap1.CenterY);
		}
	}
}
