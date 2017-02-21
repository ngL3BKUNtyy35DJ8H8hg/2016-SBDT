using DienTapLib;
using Microsoft.DirectX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaBan
{
	[DesignerGenerated]
	public class dlgActFly : Form
	{
		private IContainer components;

		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("lblPath")]
		private Label _lblPath;

		[AccessedThroughProperty("txtActionName")]
		private TextBox _txtActionName;

		[AccessedThroughProperty("btnObjName")]
		private Button _btnObjName;

		[AccessedThroughProperty("txtObjName")]
		private TextBox _txtObjName;

		[AccessedThroughProperty("txtPath")]
		private TextBox _txtPath;

		[AccessedThroughProperty("lblDoCao")]
		private Label _lblDoCao;

		[AccessedThroughProperty("txtDoCao")]
		private TextBox _txtDoCao;

		[AccessedThroughProperty("btnGetPath")]
		private Button _btnGetPath;

		[AccessedThroughProperty("txtSoundName")]
		private TextBox _txtSoundName;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("chkLoop")]
		private CheckBox _chkLoop;

		[AccessedThroughProperty("txtStart")]
		private TextBox _txtStart;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("txtObjType")]
		private TextBox _txtObjType;

		[AccessedThroughProperty("txtDuration")]
		private TextBox _txtDuration;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("chkHide")]
		private CheckBox _chkHide;

		private dlgActions Parentf;

		private CMoveObjDef ActionDef;

		private string Mode;

		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get
			{
				return this._TableLayoutPanel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		internal virtual Button OK_Button
		{
			get
			{
				return this._OK_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Button_Click);
				if (this._OK_Button != null)
				{
					this._OK_Button.Click -= value2;
				}
				this._OK_Button = value;
				if (this._OK_Button != null)
				{
					this._OK_Button.Click += value2;
				}
			}
		}

		internal virtual Button Cancel_Button
		{
			get
			{
				return this._Cancel_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Button_Click);
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click -= value2;
				}
				this._Cancel_Button = value;
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click += value2;
				}
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label lblPath
		{
			get
			{
				return this._lblPath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblPath = value;
			}
		}

		internal virtual TextBox txtActionName
		{
			get
			{
				return this._txtActionName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtActionName = value;
			}
		}

		internal virtual Button btnObjName
		{
			get
			{
				return this._btnObjName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnObjName_Click);
				if (this._btnObjName != null)
				{
					this._btnObjName.Click -= value2;
				}
				this._btnObjName = value;
				if (this._btnObjName != null)
				{
					this._btnObjName.Click += value2;
				}
			}
		}

		internal virtual TextBox txtObjName
		{
			get
			{
				return this._txtObjName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtObjName = value;
			}
		}

		internal virtual TextBox txtPath
		{
			get
			{
				return this._txtPath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPath = value;
			}
		}

		internal virtual Label lblDoCao
		{
			get
			{
				return this._lblDoCao;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDoCao = value;
			}
		}

		internal virtual TextBox txtDoCao
		{
			get
			{
				return this._txtDoCao;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDoCao = value;
			}
		}

		internal virtual Button btnGetPath
		{
			get
			{
				return this._btnGetPath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnGetPath_Click);
				if (this._btnGetPath != null)
				{
					this._btnGetPath.Click -= value2;
				}
				this._btnGetPath = value;
				if (this._btnGetPath != null)
				{
					this._btnGetPath.Click += value2;
				}
			}
		}

		internal virtual TextBox txtSoundName
		{
			get
			{
				return this._txtSoundName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSoundName_DoubleClick);
				if (this._txtSoundName != null)
				{
					this._txtSoundName.DoubleClick -= value2;
				}
				this._txtSoundName = value;
				if (this._txtSoundName != null)
				{
					this._txtSoundName.DoubleClick += value2;
				}
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual CheckBox chkLoop
		{
			get
			{
				return this._chkLoop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkLoop = value;
			}
		}

		internal virtual TextBox txtStart
		{
			get
			{
				return this._txtStart;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStart = value;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual TextBox txtObjType
		{
			get
			{
				return this._txtObjType;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtObjType = value;
			}
		}

		internal virtual TextBox txtDuration
		{
			get
			{
				return this._txtDuration;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDuration = value;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual CheckBox chkHide
		{
			get
			{
				return this._chkHide;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkHide = value;
			}
		}

		public dlgActFly()
		{
			base.FormClosing += new FormClosingEventHandler(this.dlgFlyAction_FormClosing);
			base.Load += new EventHandler(this.dlgFlyAction_Load);
			this.Mode = "Update";
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
			this.TableLayoutPanel1 = new TableLayoutPanel();
			this.OK_Button = new Button();
			this.Cancel_Button = new Button();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.lblPath = new Label();
			this.txtActionName = new TextBox();
			this.btnObjName = new Button();
			this.txtObjName = new TextBox();
			this.txtPath = new TextBox();
			this.lblDoCao = new Label();
			this.txtDoCao = new TextBox();
			this.btnGetPath = new Button();
			this.txtSoundName = new TextBox();
			this.Label5 = new Label();
			this.chkLoop = new CheckBox();
			this.txtStart = new TextBox();
			this.Label6 = new Label();
			this.txtObjType = new TextBox();
			this.txtDuration = new TextBox();
			this.Label8 = new Label();
			this.chkHide = new CheckBox();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			Control arg_19C_0 = this.TableLayoutPanel1;
			Point location = new Point(241, 334);
			arg_19C_0.Location = location;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			Control arg_1EE_0 = this.TableLayoutPanel1;
			Size size = new Size(146, 29);
			arg_1EE_0.Size = size;
			this.TableLayoutPanel1.TabIndex = 8;
			this.OK_Button.Anchor = AnchorStyles.None;
			Control arg_21B_0 = this.OK_Button;
			location = new Point(3, 3);
			arg_21B_0.Location = location;
			this.OK_Button.Name = "OK_Button";
			Control arg_242_0 = this.OK_Button;
			size = new Size(67, 23);
			arg_242_0.Size = size;
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Anchor = AnchorStyles.None;
			this.Cancel_Button.DialogResult = DialogResult.Cancel;
			Control arg_28C_0 = this.Cancel_Button;
			location = new Point(76, 3);
			arg_28C_0.Location = location;
			this.Cancel_Button.Name = "Cancel_Button";
			Control arg_2B3_0 = this.Cancel_Button;
			size = new Size(67, 23);
			arg_2B3_0.Size = size;
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			this.Label1.AutoSize = true;
			Control arg_2F2_0 = this.Label1;
			location = new Point(12, 18);
			arg_2F2_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_319_0 = this.Label1;
			size = new Size(83, 13);
			arg_319_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Tên hành động:";
			this.Label2.AutoSize = true;
			Control arg_358_0 = this.Label2;
			location = new Point(12, 71);
			arg_358_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_37F_0 = this.Label2;
			size = new Size(78, 13);
			arg_37F_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Tên đối tượng:";
			this.lblPath.AutoSize = true;
			Control arg_3C1_0 = this.lblPath;
			location = new Point(12, 178);
			arg_3C1_0.Location = location;
			this.lblPath.Name = "lblPath";
			Control arg_3E8_0 = this.lblPath;
			size = new Size(65, 13);
			arg_3E8_0.Size = size;
			this.lblPath.TabIndex = 3;
			this.lblPath.Text = "Đường bay:";
			Control arg_41B_0 = this.txtActionName;
			location = new Point(121, 15);
			arg_41B_0.Location = location;
			this.txtActionName.Name = "txtActionName";
			Control arg_445_0 = this.txtActionName;
			size = new Size(157, 21);
			arg_445_0.Size = size;
			this.txtActionName.TabIndex = 0;
			Control arg_46B_0 = this.btnObjName;
			location = new Point(286, 66);
			arg_46B_0.Location = location;
			this.btnObjName.Name = "btnObjName";
			Control arg_492_0 = this.btnObjName;
			size = new Size(105, 23);
			arg_492_0.Size = size;
			this.btnObjName.TabIndex = 2;
			this.btnObjName.Text = "Lấy ĐT trên BĐ";
			this.btnObjName.UseVisualStyleBackColor = true;
			Control arg_4D1_0 = this.txtObjName;
			location = new Point(121, 68);
			arg_4D1_0.Location = location;
			this.txtObjName.Name = "txtObjName";
			this.txtObjName.ReadOnly = true;
			Control arg_507_0 = this.txtObjName;
			size = new Size(157, 21);
			arg_507_0.Size = size;
			this.txtObjName.TabIndex = 2;
			this.txtObjName.Text = "MayBay2";
			this.txtPath.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_54A_0 = this.txtPath;
			location = new Point(12, 194);
			arg_54A_0.Location = location;
			this.txtPath.Multiline = true;
			this.txtPath.Name = "txtPath";
			this.txtPath.ScrollBars = ScrollBars.Vertical;
			Control arg_58F_0 = this.txtPath;
			size = new Size(378, 134);
			arg_58F_0.Size = size;
			this.txtPath.TabIndex = 7;
			this.lblDoCao.AutoSize = true;
			Control arg_5C1_0 = this.lblDoCao;
			location = new Point(127, 176);
			arg_5C1_0.Location = location;
			this.lblDoCao.Name = "lblDoCao";
			Control arg_5E8_0 = this.lblDoCao;
			size = new Size(45, 13);
			arg_5E8_0.Size = size;
			this.lblDoCao.TabIndex = 9;
			this.lblDoCao.Text = "Độ cao:";
			Control arg_622_0 = this.txtDoCao;
			location = new Point(177, 168);
			arg_622_0.Location = location;
			this.txtDoCao.Name = "txtDoCao";
			Control arg_649_0 = this.txtDoCao;
			size = new Size(44, 21);
			arg_649_0.Size = size;
			this.txtDoCao.TabIndex = 7;
			this.txtDoCao.Text = "10";
			Control arg_682_0 = this.btnGetPath;
			location = new Point(248, 168);
			arg_682_0.Location = location;
			this.btnGetPath.Name = "btnGetPath";
			Control arg_6AC_0 = this.btnGetPath;
			size = new Size(143, 23);
			arg_6AC_0.Size = size;
			this.btnGetPath.TabIndex = 6;
			this.btnGetPath.Text = "Lấy Đường bay trên BĐ";
			this.btnGetPath.UseVisualStyleBackColor = true;
			Control arg_6EB_0 = this.txtSoundName;
			location = new Point(121, 122);
			arg_6EB_0.Location = location;
			this.txtSoundName.Name = "txtSoundName";
			Control arg_715_0 = this.txtSoundName;
			size = new Size(157, 21);
			arg_715_0.Size = size;
			this.txtSoundName.TabIndex = 4;
			this.txtSoundName.Text = "b17-01.wav";
			this.Label5.AutoSize = true;
			Control arg_754_0 = this.Label5;
			location = new Point(12, 125);
			arg_754_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_77B_0 = this.Label5;
			size = new Size(57, 13);
			arg_77B_0.Size = size;
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Âm thanh:";
			this.chkLoop.AutoSize = true;
			this.chkLoop.Checked = true;
			this.chkLoop.CheckState = CheckState.Checked;
			Control arg_7D6_0 = this.chkLoop;
			location = new Point(286, 126);
			arg_7D6_0.Location = location;
			this.chkLoop.Name = "chkLoop";
			Control arg_7FD_0 = this.chkLoop;
			size = new Size(43, 17);
			arg_7FD_0.Size = size;
			this.chkLoop.TabIndex = 5;
			this.chkLoop.Text = "Lặp";
			this.chkLoop.UseVisualStyleBackColor = true;
			Control arg_83C_0 = this.txtStart;
			location = new Point(121, 42);
			arg_83C_0.Location = location;
			this.txtStart.Name = "txtStart";
			Control arg_866_0 = this.txtStart;
			size = new Size(157, 21);
			arg_866_0.Size = size;
			this.txtStart.TabIndex = 1;
			this.txtStart.Text = "10";
			this.Label6.AutoSize = true;
			Control arg_8A5_0 = this.Label6;
			location = new Point(12, 45);
			arg_8A5_0.Location = location;
			this.Label6.Name = "Label6";
			Control arg_8CC_0 = this.Label6;
			size = new Size(96, 13);
			arg_8CC_0.Size = size;
			this.Label6.TabIndex = 13;
			this.Label6.Text = "Thời điểm Bắt đầu:";
			Control arg_903_0 = this.txtObjType;
			location = new Point(289, 15);
			arg_903_0.Location = location;
			this.txtObjType.Name = "txtObjType";
			Control arg_92A_0 = this.txtObjType;
			size = new Size(102, 21);
			arg_92A_0.Size = size;
			this.txtObjType.TabIndex = 16;
			this.txtObjType.Visible = false;
			Control arg_95A_0 = this.txtDuration;
			location = new Point(121, 95);
			arg_95A_0.Location = location;
			this.txtDuration.Name = "txtDuration";
			Control arg_984_0 = this.txtDuration;
			size = new Size(157, 21);
			arg_984_0.Size = size;
			this.txtDuration.TabIndex = 3;
			this.txtDuration.Text = "400";
			this.Label8.AutoSize = true;
			Control arg_9C3_0 = this.Label8;
			location = new Point(41, 98);
			arg_9C3_0.Location = location;
			this.Label8.Name = "Label8";
			Control arg_9EA_0 = this.Label8;
			size = new Size(54, 13);
			arg_9EA_0.Size = size;
			this.Label8.TabIndex = 27;
			this.Label8.Text = "Thời gian:";
			this.chkHide.AutoSize = true;
			this.chkHide.Checked = true;
			this.chkHide.CheckState = CheckState.Checked;
			Control arg_A45_0 = this.chkHide;
			location = new Point(286, 97);
			arg_A45_0.Location = location;
			this.chkHide.Name = "chkHide";
			Control arg_A6C_0 = this.chkHide;
			size = new Size(83, 17);
			arg_A6C_0.Size = size;
			this.chkHide.TabIndex = 28;
			this.chkHide.Text = "Ẩn khi dừng";
			this.chkHide.UseVisualStyleBackColor = true;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new Size(399, 375);
			this.ClientSize = size;
			this.Controls.Add(this.chkHide);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.txtObjType);
			this.Controls.Add(this.txtStart);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.chkLoop);
			this.Controls.Add(this.txtSoundName);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.btnGetPath);
			this.Controls.Add(this.lblDoCao);
			this.Controls.Add(this.txtDoCao);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.txtObjName);
			this.Controls.Add(this.btnObjName);
			this.Controls.Add(this.txtActionName);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "dlgActFly";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "dlgActFly";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private List<Vector3> GetSmoothPath(List<Vector3> pTargets)
		{
			double num = modSaBan.mySurf2X * 1000.0 / (double)(checked(modSaBan.myGRID_WIDTH - 1)) / 1000.0;
			double num2 = modSaBan.mySurf2Y * 1000.0 / (double)(checked(modSaBan.myGRID_HEIGHT - 1)) / 1000.0;
			object left = pTargets.Count;
			checked
			{
				List<Vector3> list;
				if (Operators.ConditionalCompareObjectGreater(left, 2, false))
				{
					PointF[] array = new PointF[Conversions.ToInteger(Operators.SubtractObject(left, 1)) + 1];
					int arg_8E_0 = 0;
					int upperBound = array.GetUpperBound(0);
					for (int i = arg_8E_0; i <= upperBound; i++)
					{
						unchecked
						{
							array[i].X = (float)((double)pTargets[i].X * num);
							array[i].Y = (float)((double)pTargets[i].Y * num2);
						}
					}
					GraphicsPath graphicsPath = new GraphicsPath();
					graphicsPath.AddCurve(array);
					graphicsPath.Flatten(new System.Drawing.Drawing2D.Matrix(), 0.25f);
					PointF[] pathPoints = graphicsPath.PathPoints;
					object value = pathPoints.GetUpperBound(0);
					list = new List<Vector3>();
					int arg_12D_0 = 0;
					int num3 = Conversions.ToInteger(value);
					for (int j = arg_12D_0; j <= num3; j++)
					{
						List<Vector3> arg_16F_0 = list;
						Vector3 item = new Vector3((float)((double)pathPoints[j].X / num), (float)((double)pathPoints[j].Y / num2), pTargets[0].Z);
						arg_16F_0.Add(item);
					}
				}
				else
				{
					list = pTargets;
				}
				return list;
			}
		}

		private void UpdateAction()
		{
			this.ActionDef.Name = this.txtActionName.Text;
			this.ActionDef.ObjName = this.txtObjName.Text;
			this.ActionDef.SoundLoop = this.chkLoop.Checked;
			this.ActionDef.SoundName = this.txtSoundName.Text;
			this.ActionDef.duration = this.txtDuration.Text;
			this.ActionDef.stophide = this.chkHide.Checked;
			this.ActionDef.start = this.txtStart.Text;
			List<Vector3> list = CActDefs.ReadTargets(this.txtPath.Text);
			if (list.Count > 0)
			{
				this.ActionDef.targets.Clear();
				try
				{
					List<Vector3>.Enumerator enumerator = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Vector3 current = enumerator.Current;
						this.ActionDef.targets.Add(current);
					}
				}
				finally
				{
					List<Vector3>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (Operators.CompareString(this.Mode, "Add", false) == 0)
			{
				this.Parentf.AddAction(this.ActionDef);
			}
			else
			{
				this.Parentf.UpdateAction();
			}
		}

		private bool isOK()
		{
			bool result = false;
			List<Vector3> list = CActDefs.ReadTargets(this.txtPath.Text);
			if (Operators.CompareString(this.ActionDef.ActionType, "Fly", false) == 0)
			{
				if (list.Count > 1)
				{
					if (Operators.CompareString(this.txtObjType.Text, "Model", false) == 0)
					{
						result = true;
					}
					else if (this.txtObjType.Text.Length == 0)
					{
						result = true;
					}
					else
					{
						Interaction.MsgBox("Không đúng đối tượng.", MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					Interaction.MsgBox("Chưa có đường bay.", MsgBoxStyle.OkOnly, null);
				}
			}
			else if (list.Count > 1)
			{
				if (Operators.CompareString(this.txtObjType.Text, "Model", false) == 0)
				{
					this.ActionDef.ActionType = "Move";
					result = true;
				}
				else if (Operators.CompareString(this.txtObjType.Text, "Billboard", false) == 0)
				{
					this.ActionDef.ActionType = "Move";
					result = true;
				}
				else if (Operators.CompareString(this.txtObjType.Text, "TexObj", false) == 0)
				{
					this.ActionDef.ActionType = "Move";
					result = true;
				}
				else if (this.txtObjType.Text.Length == 0)
				{
					result = true;
				}
				else
				{
					Interaction.MsgBox("Không đúng đối tượng.", MsgBoxStyle.OkOnly, null);
				}
			}
			else
			{
				Interaction.MsgBox("Chưa có đường chạy.", MsgBoxStyle.OkOnly, null);
			}
			return result;
		}

		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (this.isOK())
			{
				if (this.Parentf.IsNameOK(this.txtObjName.Text))
				{
					this.UpdateAction();
					modSaBan.fActions.bDirty = true;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Interaction.MsgBox("Tên đối tượng không duy nhất.", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public void Show(dlgActions pform, CActDef pAction, string pMode)
		{
			this.Parentf = pform;
			this.ActionDef = (CMoveObjDef)pAction;
			this.Mode = pMode;
			this.Show(this.Parentf);
		}

		private void btnGetPath_Click(object sender, EventArgs e)
		{
			this.txtPath.Text = "";
			float pDoCao = 0f;
			try
			{
				pDoCao = -Conversions.ToSingle(this.txtDoCao.Text);
			}
			catch (Exception expr_2A)
			{
				ProjectData.SetProjectError(expr_2A);
				ProjectData.ClearProjectError();
			}
			myModule.fMain.myVeActs.OnGetTarget(this.txtPath, pDoCao);
		}

		private void btnObjName_Click(object sender, EventArgs e)
		{
			this.txtObjName.Text = "";
			myModule.fMain.myVeActs.OnGetObjName(this.txtObjName, this.txtObjType);
		}

		private void dlgFlyAction_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Parentf.bView = true;
		}

		private void dlgFlyAction_Load(object sender, EventArgs e)
		{
			this.Parentf.bView = false;
			this.OK_Button.Text = this.Mode;
			if (Operators.CompareString(this.ActionDef.ActionType, "Fly", false) == 0)
			{
				this.Text = "Bay";
				this.lblPath.Text = "Đường bay";
				this.btnGetPath.Text = "Lấy Đường bay trên BĐ";
				this.txtDoCao.Text = "10";
				this.txtDoCao.Visible = true;
				this.lblDoCao.Visible = true;
			}
			else
			{
				this.Text = "Chạy";
				this.lblPath.Text = "Đường chạy";
				this.btnGetPath.Text = "Lấy Đường chạy trên BĐ";
				this.txtDoCao.Text = "0";
				this.txtDoCao.Visible = false;
				this.lblDoCao.Visible = false;
			}
			this.txtActionName.Text = this.ActionDef.Name;
			this.txtObjName.Text = this.ActionDef.ObjName;
			this.chkLoop.Checked = this.ActionDef.SoundLoop;
			this.txtSoundName.Text = this.ActionDef.SoundName;
			this.txtDuration.Text = this.ActionDef.duration;
			this.chkHide.Checked = this.ActionDef.stophide;
			this.txtStart.Text = this.ActionDef.start;
			if (this.ActionDef.targets.Count > 0)
			{
				try
				{
					List<Vector3>.Enumerator enumerator = this.ActionDef.targets.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Vector3 current = enumerator.Current;
						TextBox txtPath = this.txtPath;
						txtPath.Text = string.Concat(new string[]
						{
							txtPath.Text,
							"<Target X=\"",
							current.X.ToString(),
							"\" Y=\"",
							current.Y.ToString(),
							"\" Z=\"",
							current.Z.ToString(),
							"\"></Target>\r\n"
						});
					}
				}
				finally
				{
					List<Vector3>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		private void txtSoundName_DoubleClick(object sender, EventArgs e)
		{
			dlgGetName dlgGetName = new dlgGetName();
			dlgGetName.txtNameType.Text = "Sound";
			if (dlgGetName.ShowDialog(this) == DialogResult.OK)
			{
				this.txtSoundName.Text = dlgGetName.txtName.Text;
			}
		}
	}
}
