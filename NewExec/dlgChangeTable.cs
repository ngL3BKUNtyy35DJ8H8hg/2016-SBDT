using DBiGraphicObjs.DBiGraphicObjects;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaBan
{
	[DesignerGenerated]
	public class dlgChangeTable : Form
	{
		private enum myTableTools
		{
			CellChange,
			WChange,
			HChange
		}

		private IContainer components;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("btnChange")]
		private Button _btnChange;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("txtBrushColor")]
		private TextBox _txtBrushColor;

		[AccessedThroughProperty("txtColor2")]
		private TextBox _txtColor2;

		[AccessedThroughProperty("txtColor")]
		private TextBox _txtColor;

		[AccessedThroughProperty("nudAlpha")]
		private NumericUpDown _nudAlpha;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("nudPenWidth2")]
		private NumericUpDown _nudPenWidth2;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("nudPenWidth")]
		private NumericUpDown _nudPenWidth;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Splitter1")]
		private Splitter _Splitter1;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		[AccessedThroughProperty("HScrollBar1")]
		private HScrollBar _HScrollBar1;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("ContextMenu1")]
		private ContextMenu _ContextMenu1;

		[AccessedThroughProperty("mnuInsertCol")]
		private MenuItem _mnuInsertCol;

		[AccessedThroughProperty("mnuInsertRow")]
		private MenuItem _mnuInsertRow;

		[AccessedThroughProperty("MenuItem5")]
		private MenuItem _MenuItem5;

		[AccessedThroughProperty("mnuDeleteCol")]
		private MenuItem _mnuDeleteCol;

		[AccessedThroughProperty("mnuDeleteRow")]
		private MenuItem _mnuDeleteRow;

		[AccessedThroughProperty("MenuItem1")]
		private MenuItem _MenuItem1;

		[AccessedThroughProperty("mnuLinkRight")]
		private MenuItem _mnuLinkRight;

		[AccessedThroughProperty("MenuItem2")]
		private MenuItem _MenuItem2;

		[AccessedThroughProperty("mnuLinkDown")]
		private MenuItem _mnuLinkDown;

		[AccessedThroughProperty("MenuItem3")]
		private MenuItem _MenuItem3;

		[AccessedThroughProperty("mnuTextFont")]
		private MenuItem _mnuTextFont;

		private TableGraphic m_myObj;

		private Point pointTL;

		public int myScale;

		public int myWidth;

		public int myHeight;

		private dlgChangeTable.myTableTools myTool;

		private Point myPrevPt;

		private Point myPrevPt0;

		private TableGraphic myTable;

		private int curCol;

		private int curRow;

		private int icurCell;

		private CCell SeleCell;

		private float savRotation;

		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual Button btnChange
		{
			get
			{
				return this._btnChange;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnChange_Click);
				if (this._btnChange != null)
				{
					this._btnChange.Click -= value2;
				}
				this._btnChange = value;
				if (this._btnChange != null)
				{
					this._btnChange.Click += value2;
				}
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual TextBox txtBrushColor
		{
			get
			{
				return this._txtBrushColor;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBrushColor_DoubleClick);
				if (this._txtBrushColor != null)
				{
					this._txtBrushColor.DoubleClick -= value2;
				}
				this._txtBrushColor = value;
				if (this._txtBrushColor != null)
				{
					this._txtBrushColor.DoubleClick += value2;
				}
			}
		}

		internal virtual TextBox txtColor2
		{
			get
			{
				return this._txtColor2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtColor2_DoubleClick);
				if (this._txtColor2 != null)
				{
					this._txtColor2.DoubleClick -= value2;
				}
				this._txtColor2 = value;
				if (this._txtColor2 != null)
				{
					this._txtColor2.DoubleClick += value2;
				}
			}
		}

		internal virtual TextBox txtColor
		{
			get
			{
				return this._txtColor;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtColor_DoubleClick);
				if (this._txtColor != null)
				{
					this._txtColor.DoubleClick -= value2;
				}
				this._txtColor = value;
				if (this._txtColor != null)
				{
					this._txtColor.DoubleClick += value2;
				}
			}
		}

		internal virtual NumericUpDown nudAlpha
		{
			get
			{
				return this._nudAlpha;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nudAlpha_ValueChanged);
				if (this._nudAlpha != null)
				{
					this._nudAlpha.ValueChanged -= value2;
				}
				this._nudAlpha = value;
				if (this._nudAlpha != null)
				{
					this._nudAlpha.ValueChanged += value2;
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

		internal virtual NumericUpDown nudPenWidth2
		{
			get
			{
				return this._nudPenWidth2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nudPenWidth2_ValueChanged);
				if (this._nudPenWidth2 != null)
				{
					this._nudPenWidth2.ValueChanged -= value2;
				}
				this._nudPenWidth2 = value;
				if (this._nudPenWidth2 != null)
				{
					this._nudPenWidth2.ValueChanged += value2;
				}
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

		internal virtual NumericUpDown nudPenWidth
		{
			get
			{
				return this._nudPenWidth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nudPenWidth_ValueChanged);
				if (this._nudPenWidth != null)
				{
					this._nudPenWidth.ValueChanged -= value2;
				}
				this._nudPenWidth = value;
				if (this._nudPenWidth != null)
				{
					this._nudPenWidth.ValueChanged += value2;
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

		internal virtual Splitter Splitter1
		{
			get
			{
				return this._Splitter1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter1 = value;
			}
		}

		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Panel2_Resize);
				if (this._Panel2 != null)
				{
					this._Panel2.Resize -= value2;
				}
				this._Panel2 = value;
				if (this._Panel2 != null)
				{
					this._Panel2.Resize += value2;
				}
			}
		}

		internal virtual VScrollBar VScrollBar1
		{
			get
			{
				return this._VScrollBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VScrollBar1_ValueChanged);
				if (this._VScrollBar1 != null)
				{
					this._VScrollBar1.ValueChanged -= value2;
				}
				this._VScrollBar1 = value;
				if (this._VScrollBar1 != null)
				{
					this._VScrollBar1.ValueChanged += value2;
				}
			}
		}

		internal virtual HScrollBar HScrollBar1
		{
			get
			{
				return this._HScrollBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HScrollBar1_ValueChanged);
				if (this._HScrollBar1 != null)
				{
					this._HScrollBar1.ValueChanged -= value2;
				}
				this._HScrollBar1 = value;
				if (this._HScrollBar1 != null)
				{
					this._HScrollBar1.ValueChanged += value2;
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged -= value2;
				}
				this._TextBox1 = value;
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PictureBox1_MouseUp);
				MouseEventHandler value3 = new MouseEventHandler(this.PictureBox1_MouseDown);
				MouseEventHandler value4 = new MouseEventHandler(this.PictureBox1_MouseMove);
				PaintEventHandler value5 = new PaintEventHandler(this.PictureBox1_Paint1);
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.MouseUp -= value2;
					this._PictureBox1.MouseDown -= value3;
					this._PictureBox1.MouseMove -= value4;
					this._PictureBox1.Paint -= value5;
				}
				this._PictureBox1 = value;
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.MouseUp += value2;
					this._PictureBox1.MouseDown += value3;
					this._PictureBox1.MouseMove += value4;
					this._PictureBox1.Paint += value5;
				}
			}
		}

		internal virtual ContextMenu ContextMenu1
		{
			get
			{
				return this._ContextMenu1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenu1 = value;
			}
		}

		internal virtual MenuItem mnuInsertCol
		{
			get
			{
				return this._mnuInsertCol;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuInsertCol_Click);
				if (this._mnuInsertCol != null)
				{
					this._mnuInsertCol.Click -= value2;
				}
				this._mnuInsertCol = value;
				if (this._mnuInsertCol != null)
				{
					this._mnuInsertCol.Click += value2;
				}
			}
		}

		internal virtual MenuItem mnuInsertRow
		{
			get
			{
				return this._mnuInsertRow;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuInsertRow_Click);
				if (this._mnuInsertRow != null)
				{
					this._mnuInsertRow.Click -= value2;
				}
				this._mnuInsertRow = value;
				if (this._mnuInsertRow != null)
				{
					this._mnuInsertRow.Click += value2;
				}
			}
		}

		internal virtual MenuItem MenuItem5
		{
			get
			{
				return this._MenuItem5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem5 = value;
			}
		}

		internal virtual MenuItem mnuDeleteCol
		{
			get
			{
				return this._mnuDeleteCol;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuDeleteCol_Click);
				if (this._mnuDeleteCol != null)
				{
					this._mnuDeleteCol.Click -= value2;
				}
				this._mnuDeleteCol = value;
				if (this._mnuDeleteCol != null)
				{
					this._mnuDeleteCol.Click += value2;
				}
			}
		}

		internal virtual MenuItem mnuDeleteRow
		{
			get
			{
				return this._mnuDeleteRow;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuDeleteRow_Click);
				if (this._mnuDeleteRow != null)
				{
					this._mnuDeleteRow.Click -= value2;
				}
				this._mnuDeleteRow = value;
				if (this._mnuDeleteRow != null)
				{
					this._mnuDeleteRow.Click += value2;
				}
			}
		}

		internal virtual MenuItem MenuItem1
		{
			get
			{
				return this._MenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem1 = value;
			}
		}

		internal virtual MenuItem mnuLinkRight
		{
			get
			{
				return this._mnuLinkRight;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuLinkRight_Click);
				if (this._mnuLinkRight != null)
				{
					this._mnuLinkRight.Click -= value2;
				}
				this._mnuLinkRight = value;
				if (this._mnuLinkRight != null)
				{
					this._mnuLinkRight.Click += value2;
				}
			}
		}

		internal virtual MenuItem MenuItem2
		{
			get
			{
				return this._MenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem2 = value;
			}
		}

		internal virtual MenuItem mnuLinkDown
		{
			get
			{
				return this._mnuLinkDown;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuLinkDown_Click);
				if (this._mnuLinkDown != null)
				{
					this._mnuLinkDown.Click -= value2;
				}
				this._mnuLinkDown = value;
				if (this._mnuLinkDown != null)
				{
					this._mnuLinkDown.Click += value2;
				}
			}
		}

		internal virtual MenuItem MenuItem3
		{
			get
			{
				return this._MenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem3 = value;
			}
		}

		internal virtual MenuItem mnuTextFont
		{
			get
			{
				return this._mnuTextFont;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnuTextFont_Click);
				if (this._mnuTextFont != null)
				{
					this._mnuTextFont.Click -= value2;
				}
				this._mnuTextFont = value;
				if (this._mnuTextFont != null)
				{
					this._mnuTextFont.Click += value2;
				}
			}
		}

		public TableGraphic myObj
		{
			set
			{
				this.m_myObj = value;
			}
		}

		public dlgChangeTable()
		{
			base.Load += new EventHandler(this.dlgChangeTable_Load);
			this.myScale = 4;
			this.myWidth = 100;
			this.myHeight = 80;
			this.myTool = dlgChangeTable.myTableTools.CellChange;
			this.myPrevPt = default(Point);
			this.myPrevPt0 = default(Point);
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
			this.Panel1 = new Panel();
			this.btnChange = new Button();
			this.Label4 = new Label();
			this.txtBrushColor = new TextBox();
			this.txtColor2 = new TextBox();
			this.txtColor = new TextBox();
			this.nudAlpha = new NumericUpDown();
			this.Label1 = new Label();
			this.nudPenWidth2 = new NumericUpDown();
			this.Label8 = new Label();
			this.nudPenWidth = new NumericUpDown();
			this.Label5 = new Label();
			this.Splitter1 = new Splitter();
			this.Panel2 = new Panel();
			this.VScrollBar1 = new VScrollBar();
			this.HScrollBar1 = new HScrollBar();
			this.TextBox1 = new TextBox();
			this.PictureBox1 = new PictureBox();
			this.ContextMenu1 = new ContextMenu();
			this.mnuInsertCol = new MenuItem();
			this.mnuInsertRow = new MenuItem();
			this.MenuItem5 = new MenuItem();
			this.mnuDeleteCol = new MenuItem();
			this.mnuDeleteRow = new MenuItem();
			this.MenuItem1 = new MenuItem();
			this.mnuLinkRight = new MenuItem();
			this.MenuItem2 = new MenuItem();
			this.mnuLinkDown = new MenuItem();
			this.MenuItem3 = new MenuItem();
			this.mnuTextFont = new MenuItem();
			this.Panel1.SuspendLayout();
			((ISupportInitialize)this.nudAlpha).BeginInit();
			((ISupportInitialize)this.nudPenWidth2).BeginInit();
			((ISupportInitialize)this.nudPenWidth).BeginInit();
			this.Panel2.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Panel1.BorderStyle = BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.btnChange);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.txtBrushColor);
			this.Panel1.Controls.Add(this.txtColor2);
			this.Panel1.Controls.Add(this.txtColor);
			this.Panel1.Controls.Add(this.nudAlpha);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.nudPenWidth2);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.nudPenWidth);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Dock = DockStyle.Left;
			Control arg_2AC_0 = this.Panel1;
			Point location = new Point(0, 0);
			arg_2AC_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_2D9_0 = this.Panel1;
			Size size = new Size(152, 278);
			arg_2D9_0.Size = size;
			this.Panel1.TabIndex = 1;
			this.btnChange.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_30C_0 = this.btnChange;
			location = new Point(68, 244);
			arg_30C_0.Location = location;
			this.btnChange.Name = "btnChange";
			Control arg_333_0 = this.btnChange;
			size = new Size(72, 24);
			arg_333_0.Size = size;
			this.btnChange.TabIndex = 72;
			this.btnChange.Text = "Thay đổi";
			Control arg_366_0 = this.Label4;
			location = new Point(8, 72);
			arg_366_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_38D_0 = this.Label4;
			size = new Size(80, 16);
			arg_38D_0.Size = size;
			this.Label4.TabIndex = 71;
			this.Label4.Text = "Mầu tô:";
			this.txtBrushColor.BackColor = Color.Red;
			this.txtBrushColor.ForeColor = SystemColors.HighlightText;
			Control arg_3E1_0 = this.txtBrushColor;
			location = new Point(88, 72);
			arg_3E1_0.Location = location;
			this.txtBrushColor.Name = "txtBrushColor";
			Control arg_408_0 = this.txtBrushColor;
			size = new Size(24, 21);
			arg_408_0.Size = size;
			this.txtBrushColor.TabIndex = 66;
			this.txtColor2.BackColor = SystemColors.Highlight;
			this.txtColor2.ForeColor = SystemColors.HighlightText;
			Control arg_44C_0 = this.txtColor2;
			location = new Point(88, 40);
			arg_44C_0.Location = location;
			this.txtColor2.Name = "txtColor2";
			Control arg_473_0 = this.txtColor2;
			size = new Size(24, 21);
			arg_473_0.Size = size;
			this.txtColor2.TabIndex = 64;
			this.txtColor.BackColor = Color.Red;
			this.txtColor.ForeColor = SystemColors.HighlightText;
			Control arg_4B7_0 = this.txtColor;
			location = new Point(88, 16);
			arg_4B7_0.Location = location;
			this.txtColor.Name = "txtColor";
			Control arg_4DE_0 = this.txtColor;
			size = new Size(24, 21);
			arg_4DE_0.Size = size;
			this.txtColor.TabIndex = 61;
			Control arg_502_0 = this.nudAlpha;
			location = new Point(88, 96);
			arg_502_0.Location = location;
			NumericUpDown arg_538_0 = this.nudAlpha;
			decimal num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			arg_538_0.Maximum = num;
			this.nudAlpha.Name = "nudAlpha";
			Control arg_55F_0 = this.nudAlpha;
			size = new Size(48, 21);
			arg_55F_0.Size = size;
			this.nudAlpha.TabIndex = 69;
			NumericUpDown arg_5A2_0 = this.nudAlpha;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			arg_5A2_0.Value = num;
			Control arg_5B9_0 = this.Label1;
			location = new Point(40, 96);
			arg_5B9_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_5E0_0 = this.Label1;
			size = new Size(48, 16);
			arg_5E0_0.Size = size;
			this.Label1.TabIndex = 68;
			this.Label1.Text = "Độ mờ:";
			Control arg_614_0 = this.nudPenWidth2;
			location = new Point(112, 40);
			arg_614_0.Location = location;
			NumericUpDown arg_647_0 = this.nudPenWidth2;
			num = new decimal(new int[]
			{
				72,
				0,
				0,
				0
			});
			arg_647_0.Maximum = num;
			this.nudPenWidth2.Name = "nudPenWidth2";
			Control arg_66E_0 = this.nudPenWidth2;
			size = new Size(32, 21);
			arg_66E_0.Size = size;
			this.nudPenWidth2.TabIndex = 65;
			NumericUpDown arg_6AD_0 = this.nudPenWidth2;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_6AD_0.Value = num;
			Control arg_6C3_0 = this.Label8;
			location = new Point(8, 40);
			arg_6C3_0.Location = location;
			this.Label8.Name = "Label8";
			Control arg_6EA_0 = this.Label8;
			size = new Size(72, 16);
			arg_6EA_0.Size = size;
			this.Label8.TabIndex = 63;
			this.Label8.Text = "Đường kẻ:";
			Control arg_71E_0 = this.nudPenWidth;
			location = new Point(112, 16);
			arg_71E_0.Location = location;
			NumericUpDown arg_751_0 = this.nudPenWidth;
			num = new decimal(new int[]
			{
				72,
				0,
				0,
				0
			});
			arg_751_0.Maximum = num;
			this.nudPenWidth.Name = "nudPenWidth";
			Control arg_778_0 = this.nudPenWidth;
			size = new Size(32, 21);
			arg_778_0.Size = size;
			this.nudPenWidth.TabIndex = 62;
			NumericUpDown arg_7B7_0 = this.nudPenWidth;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_7B7_0.Value = num;
			Control arg_7CD_0 = this.Label5;
			location = new Point(8, 16);
			arg_7CD_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_7F4_0 = this.Label5;
			size = new Size(72, 16);
			arg_7F4_0.Size = size;
			this.Label5.TabIndex = 60;
			this.Label5.Text = "Viền ngoài:";
			Control arg_82A_0 = this.Splitter1;
			location = new Point(152, 0);
			arg_82A_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_853_0 = this.Splitter1;
			size = new Size(3, 278);
			arg_853_0.Size = size;
			this.Splitter1.TabIndex = 2;
			this.Splitter1.TabStop = false;
			this.Panel2.BorderStyle = BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.VScrollBar1);
			this.Panel2.Controls.Add(this.HScrollBar1);
			this.Panel2.Controls.Add(this.TextBox1);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Dock = DockStyle.Fill;
			Control arg_8F4_0 = this.Panel2;
			location = new Point(155, 0);
			arg_8F4_0.Location = location;
			this.Panel2.Name = "Panel2";
			Control arg_921_0 = this.Panel2;
			size = new Size(413, 278);
			arg_921_0.Size = size;
			this.Panel2.TabIndex = 3;
			this.VScrollBar1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_953_0 = this.VScrollBar1;
			location = new Point(394, 0);
			arg_953_0.Location = location;
			this.VScrollBar1.Name = "VScrollBar1";
			Control arg_97D_0 = this.VScrollBar1;
			size = new Size(16, 271);
			arg_97D_0.Size = size;
			this.VScrollBar1.TabIndex = 84;
			this.HScrollBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_9AF_0 = this.HScrollBar1;
			location = new Point(0, 259);
			arg_9AF_0.Location = location;
			this.HScrollBar1.Name = "HScrollBar1";
			Control arg_9D9_0 = this.HScrollBar1;
			size = new Size(344, 16);
			arg_9D9_0.Size = size;
			this.HScrollBar1.TabIndex = 83;
			Control arg_A00_0 = this.TextBox1;
			location = new Point(130, 111);
			arg_A00_0.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			Control arg_A36_0 = this.TextBox1;
			size = new Size(152, 56);
			arg_A36_0.Size = size;
			this.TextBox1.TabIndex = 86;
			this.TextBox1.Text = "TextBox1";
			this.PictureBox1.BackColor = SystemColors.HighlightText;
			Control arg_A7A_0 = this.PictureBox1;
			location = new Point(40, 16);
			arg_A7A_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			Control arg_AA7_0 = this.PictureBox1;
			size = new Size(336, 240);
			arg_AA7_0.Size = size;
			this.PictureBox1.TabIndex = 71;
			this.PictureBox1.TabStop = false;
			this.ContextMenu1.MenuItems.AddRange(new MenuItem[]
			{
				this.mnuInsertCol,
				this.mnuInsertRow,
				this.MenuItem5,
				this.mnuDeleteCol,
				this.mnuDeleteRow,
				this.MenuItem1,
				this.mnuLinkRight,
				this.MenuItem2,
				this.mnuLinkDown,
				this.MenuItem3,
				this.mnuTextFont
			});
			this.mnuInsertCol.Index = 0;
			this.mnuInsertCol.Text = "Thêm cột";
			this.mnuInsertRow.Index = 1;
			this.mnuInsertRow.Text = "Thêm dòng";
			this.MenuItem5.Index = 2;
			this.MenuItem5.Text = "-";
			this.mnuDeleteCol.Index = 3;
			this.mnuDeleteCol.Text = "Xóa cột";
			this.mnuDeleteRow.Index = 4;
			this.mnuDeleteRow.Text = "Xóa dòng";
			this.MenuItem1.Index = 5;
			this.MenuItem1.Text = "-";
			this.mnuLinkRight.Index = 6;
			this.mnuLinkRight.Text = "Nối với ô phải";
			this.MenuItem2.Index = 7;
			this.MenuItem2.Text = "-";
			this.mnuLinkDown.Index = 8;
			this.mnuLinkDown.Text = "Nối với ô dưới";
			this.MenuItem3.Index = 9;
			this.MenuItem3.Text = "-";
			this.mnuTextFont.Index = 10;
			this.mnuTextFont.Text = "Font, mầu chữ";
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(568, 278);
			this.ClientSize = size;
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Splitter1);
			this.Controls.Add(this.Panel1);
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "dlgChangeTable";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Cập nhật Bảng";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((ISupportInitialize)this.nudAlpha).EndInit();
			((ISupportInitialize)this.nudPenWidth2).EndInit();
			((ISupportInitialize)this.nudPenWidth).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
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

		private void dlgChangeTable_Load(object sender, EventArgs e)
		{
			this.savRotation = this.m_myObj.Rotation;
			this.myTable = (TableGraphic)this.m_myObj.Clone();
			this.myTable.Rotation = 0f;
			checked
			{
				this.myWidth = (int)Math.Round((double)(unchecked(this.myTable.Width + 4f)));
				this.myHeight = (int)Math.Round((double)(unchecked(this.myTable.Height + 4f)));
				this.myScale = 1;
				this.pointTL = new Point(0, 0);
				this.DisplayScrollBars();
				this.txtColor.BackColor = this.myTable.BorderColor;
				this.txtColor2.BackColor = this.myTable.LineColor;
				this.nudPenWidth.Value = new decimal(this.myTable.BorderWidth);
				this.nudPenWidth2.Value = new decimal(this.myTable.LineWidth);
				this.txtBrushColor.BackColor = Color.FromArgb(255, (int)this.myTable.FiColor.R, (int)this.myTable.FiColor.G, (int)this.myTable.FiColor.B);
				this.nudAlpha.Value = new decimal((int)this.myTable.FiColor.A);
				this.curCol = 0;
				this.curRow = 0;
				this.SeleCell = this.myTable.Cells[0];
				this.PopulateCellInfo();
				this.PictureBox1.Cursor = Cursors.Arrow;
				this.TextBox1.ContextMenu = this.ContextMenu1;
			}
		}

		private void txtBrushColor_DoubleClick(object sender, EventArgs e)
		{
			this.txtBrushColor.BackColor = modBdTC.GetMau(this.txtBrushColor.BackColor);
			this.myTable.FiColor = Color.FromArgb(Convert.ToInt32(this.nudAlpha.Value), this.txtBrushColor.BackColor);
			this.PictureBox1.Invalidate();
		}

		private void txtColor2_DoubleClick(object sender, EventArgs e)
		{
			this.txtColor2.BackColor = modBdTC.GetMau(this.txtColor2.BackColor);
			this.myTable.LineColor = this.txtColor2.BackColor;
			this.PictureBox1.Invalidate();
		}

		private void txtColor_DoubleClick(object sender, EventArgs e)
		{
			this.txtColor.BackColor = modBdTC.GetMau(this.txtColor.BackColor);
			this.myTable.BorderColor = this.txtColor.BackColor;
			this.PictureBox1.Invalidate();
		}

		private void PictureBox1_Paint1(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			float dx = -this.myTable.X;
			float dy = -this.myTable.Y;
			GraphicsContainer container = graphics.BeginContainer();
			graphics.TranslateTransform(dx, dy);
			this.myTable.Draw(graphics);
			graphics.EndContainer(container);
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SeleCell.Text = this.TextBox1.Text;
				this.PictureBox1.Invalidate();
			}
			catch (Exception expr_23)
			{
				ProjectData.SetProjectError(expr_23);
				ProjectData.ClearProjectError();
			}
		}

		private void PopulateCellInfo()
		{
			checked
			{
				if (!Information.IsNothing(this.SeleCell))
				{
					Rectangle cellBounds = this.GetCellBounds(this.SeleCell);
					this.TextBox1.Left = cellBounds.X + this.pointTL.X;
					this.TextBox1.Top = cellBounds.Y + this.pointTL.Y;
					this.TextBox1.Width = cellBounds.Width + 2;
					this.TextBox1.Height = cellBounds.Height + 2;
					this.TextBox1.Font = this.SeleCell.Font;
					this.TextBox1.ForeColor = this.SeleCell.Color;
					this.TextBox1.Text = this.SeleCell.Text;
					this.curCol = this.SeleCell.iCol + this.SeleCell.ColsNo - 1;
					this.curRow = this.SeleCell.iRow + this.SeleCell.RowsNo - 1;
				}
				this.PictureBox1.Invalidate();
				this.UpdateScrollBars();
			}
		}

		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.myTool == dlgChangeTable.myTableTools.CellChange)
				{
					if (e.X == this.TextBox1.Left + this.TextBox1.Width - this.pointTL.X)
					{
						this.PictureBox1.Cursor = Cursors.SizeWE;
					}
					else if (e.Y == this.TextBox1.Top + this.TextBox1.Height - this.pointTL.Y)
					{
						this.PictureBox1.Cursor = Cursors.SizeNS;
					}
					else
					{
						this.PictureBox1.Cursor = Cursors.Arrow;
					}
				}
				else if (this.myTool == dlgChangeTable.myTableTools.HChange)
				{
					int num = e.Y - this.myPrevPt.Y;
					if (unchecked(this.myTable.AHeight[this.curRow] + (float)num) > 0f)
					{
						try
						{
							TableGraphic tableGraphic = this.myTable;
							unchecked
							{
								tableGraphic.Height += (float)num;
								float[] array = this.myTable.AHeight;
								float[] arg_113_0 = array;
								int num2 = this.curRow;
								arg_113_0[num2] = array[num2] + (float)num;
							}
							this.myHeight = (int)Math.Round((double)(unchecked(this.myTable.Height + 4f)));
							this.PictureBox1.Invalidate();
							this.TextBox1.Height = (int)Math.Round((double)this.myTable.AHeight[this.curRow]);
						}
						catch (Exception expr_164)
						{
							ProjectData.SetProjectError(expr_164);
							ProjectData.ClearProjectError();
						}
					}
					this.myPrevPt.Y = e.Y;
				}
				else if (this.myTool == dlgChangeTable.myTableTools.WChange)
				{
					int num3 = e.X - this.myPrevPt.X;
					if (unchecked(this.myTable.AWidth[this.curCol] + (float)num3) > 0f)
					{
						try
						{
							TableGraphic tableGraphic = this.myTable;
							unchecked
							{
								tableGraphic.Width += (float)num3;
								float[] array = this.myTable.AWidth;
								float[] arg_200_0 = array;
								int num2 = this.curCol;
								arg_200_0[num2] = array[num2] + (float)num3;
							}
							this.myWidth = (int)Math.Round((double)(unchecked(this.myTable.Width + 4f)));
							this.PictureBox1.Invalidate();
							this.TextBox1.Width = (int)Math.Round((double)this.myTable.AWidth[this.curCol]);
						}
						catch (Exception expr_251)
						{
							ProjectData.SetProjectError(expr_251);
							ProjectData.ClearProjectError();
						}
					}
					this.myPrevPt.X = e.X;
				}
			}
		}

		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.PictureBox1.Cursor == Cursors.SizeWE)
			{
				this.myTool = dlgChangeTable.myTableTools.WChange;
				this.myPrevPt0.X = e.X;
				this.myPrevPt.X = e.X;
				this.PictureBox1.Cursor = Cursors.SizeWE;
				this.TextBox1.Visible = false;
			}
			else if (this.PictureBox1.Cursor == Cursors.SizeNS)
			{
				this.myTool = dlgChangeTable.myTableTools.HChange;
				this.myPrevPt0.Y = e.Y;
				this.myPrevPt.Y = e.Y;
				this.PictureBox1.Cursor = Cursors.SizeNS;
				this.TextBox1.Visible = false;
			}
		}

		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.myTool == dlgChangeTable.myTableTools.WChange)
			{
				this.UpdateScrollBars();
				this.TextBox1.Visible = true;
				this.myTool = dlgChangeTable.myTableTools.CellChange;
				this.PictureBox1.Cursor = Cursors.Arrow;
				if (!Information.IsNothing(this.SeleCell))
				{
					this.PopulateCellInfo();
				}
			}
			else if (this.myTool == dlgChangeTable.myTableTools.HChange)
			{
				this.UpdateScrollBars();
				this.TextBox1.Visible = true;
				this.myTool = dlgChangeTable.myTableTools.CellChange;
				this.PictureBox1.Cursor = Cursors.Arrow;
				if (!Information.IsNothing(this.SeleCell))
				{
					this.PopulateCellInfo();
				}
			}
			else
			{
				PointF pt = new PointF((float)e.X, (float)e.Y);
				this.SeleCell = this.FindCellAtPoint(pt);
				if (!Information.IsNothing(this.SeleCell))
				{
					this.PopulateCellInfo();
				}
			}
		}

		private void mnuInsertRow_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.SeleCell))
			{
				this.myTable.InsertRow(this.SeleCell);
				this.myHeight = checked((int)Math.Round((double)(unchecked(this.myTable.Height + 4f))));
				this.UpdateScrollBars();
				this.PictureBox1.Invalidate();
			}
		}

		private void mnuDeleteRow_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.myTable.RowsNo > 1)
				{
					if (this.SeleCell.RowsNo == 1)
					{
						this.myTable.DeleteRow(this.curRow);
						if (this.curRow > this.myTable.RowsNo - 1)
						{
							this.curRow = this.myTable.RowsNo - 1;
						}
						else
						{
							this.curRow = 0;
						}
						this.SeleCell = this.myTable.GetCell(this.curRow, this.curCol);
						this.PopulateCellInfo();
					}
					else
					{
						Interaction.MsgBox("Chi xoa khi O nay co 1 dong.", MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		private void mnuInsertCol_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.SeleCell))
			{
				this.myTable.InsertCol(this.SeleCell);
				this.myWidth = checked((int)Math.Round((double)(unchecked(this.myTable.Width + 4f))));
				this.UpdateScrollBars();
				this.PictureBox1.Invalidate();
			}
		}

		private void mnuDeleteCol_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.myTable.ColsNo > 1)
				{
					if (this.SeleCell.ColsNo == 1)
					{
						this.myTable.DeleteCol(this.curCol);
						if (this.curCol > this.myTable.ColsNo - 1)
						{
							this.curCol = this.myTable.ColsNo - 1;
						}
						else
						{
							this.curCol = 0;
						}
						this.SeleCell = this.myTable.GetCell(this.curRow, this.curCol);
						this.PopulateCellInfo();
					}
					else
					{
						Interaction.MsgBox("Chi xoa khi O nay co 1 cot.", MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		private void nudAlpha_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.myTable.FiColor = Color.FromArgb(Convert.ToInt32(this.nudAlpha.Value), this.txtBrushColor.BackColor);
				this.PictureBox1.Invalidate();
			}
			catch (Exception expr_38)
			{
				ProjectData.SetProjectError(expr_38);
				ProjectData.ClearProjectError();
			}
		}

		private void nudPenWidth_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.myTable.BorderWidth = Convert.ToInt32(this.nudPenWidth.Value);
				this.PictureBox1.Invalidate();
			}
			catch (Exception expr_28)
			{
				ProjectData.SetProjectError(expr_28);
				ProjectData.ClearProjectError();
			}
		}

		private void nudPenWidth2_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.myTable.LineWidth = Convert.ToInt32(this.nudPenWidth2.Value);
				this.PictureBox1.Invalidate();
			}
			catch (Exception expr_28)
			{
				ProjectData.SetProjectError(expr_28);
				ProjectData.ClearProjectError();
			}
		}

		private CCell FindCellAtPoint(PointF pt)
		{
			CCell result;
			try
			{
				IEnumerator enumerator = this.myTable.Cells.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CCell cCell = (CCell)enumerator.Current;
					if (this.HitTest(cCell, pt))
					{
						result = cCell;
						return result;
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
			result = null;
			return result;
		}

		private bool HitTest(CCell mCell, PointF pt)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Rectangle cellBounds = this.GetCellBounds(mCell);
			graphicsPath.AddRectangle(cellBounds);
			return graphicsPath.IsVisible(pt);
		}

		private Rectangle GetCellBounds(CCell pCell)
		{
			float num = 0f;
			checked
			{
				if (pCell.iCol > 0)
				{
					int arg_1A_0 = 0;
					int num2 = pCell.iCol - 1;
					for (int i = arg_1A_0; i <= num2; i++)
					{
						unchecked
						{
							num += this.myTable.AWidth[i] * (float)this.myScale;
						}
					}
				}
				float num3 = 0f;
				int arg_54_0 = 0;
				int num4 = pCell.ColsNo - 1;
				for (int j = arg_54_0; j <= num4; j++)
				{
					unchecked
					{
						num3 += this.myTable.AWidth[checked(pCell.iCol + j)] * (float)this.myScale;
					}
				}
				float num5 = 0f;
				if (pCell.iRow > 0)
				{
					int arg_9F_0 = 0;
					int num6 = pCell.iRow - 1;
					for (int k = arg_9F_0; k <= num6; k++)
					{
						unchecked
						{
							num5 += this.myTable.AHeight[k] * (float)this.myScale;
						}
					}
				}
				float num7 = 0f;
				int arg_DB_0 = 0;
				int num8 = pCell.RowsNo - 1;
				for (int l = arg_DB_0; l <= num8; l++)
				{
					unchecked
					{
						num7 += this.myTable.AHeight[checked(pCell.iRow + l)] * (float)this.myScale;
					}
				}
				Rectangle result = new Rectangle((int)Math.Round((double)num), (int)Math.Round((double)num5), (int)Math.Round((double)num3), (int)Math.Round((double)num7));
				return result;
			}
		}

		private void mnuLinkRight_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.SeleCell))
			{
				this.myTable.LinkCellRight(this.SeleCell);
				this.PopulateCellInfo();
			}
		}

		private void mnuLinkDown_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.SeleCell))
			{
				this.myTable.LinkCellDown(this.SeleCell);
				this.PopulateCellInfo();
			}
		}

		private void mnuTextFont_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.SeleCell))
			{
				FontDialog fontDialog = new FontDialog();
				fontDialog.Font = this.SeleCell.Font;
				fontDialog.Color = this.SeleCell.Color;
				fontDialog.ShowColor = true;
				if (fontDialog.ShowDialog() != DialogResult.Cancel)
				{
					this.SeleCell.Font = fontDialog.Font;
					this.SeleCell.Color = fontDialog.Color;
					this.PopulateCellInfo();
				}
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			TableGraphic myObj = this.m_myObj;
			myObj.AHeight = this.myTable.AHeight;
			myObj.AWidth = this.myTable.AWidth;
			myObj.BorderColor = this.myTable.BorderColor;
			myObj.BorderWidth = this.myTable.BorderWidth;
			myObj.Cells = this.myTable.Cells;
			myObj.ColsNo = this.myTable.ColsNo;
			myObj.FiColor = this.myTable.FiColor;
			myObj.Height = this.myTable.Height;
			myObj.LineColor = this.myTable.LineColor;
			myObj.LineWidth = this.myTable.LineWidth;
			myObj.RowsNo = this.myTable.RowsNo;
			myObj.Width = this.myTable.Width;
			myObj.Rotation = this.savRotation;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		public void SetScrollBarValues(Size pImageSize)
		{
			this.VScrollBar1.Minimum = 0;
			this.HScrollBar1.Minimum = 0;
			this.VScrollBar1.Maximum = 0;
			this.HScrollBar1.Maximum = 0;
			checked
			{
				if (pImageSize.Width - this.Panel2.ClientSize.Width > 0)
				{
					this.HScrollBar1.Maximum = pImageSize.Width - this.Panel2.ClientSize.Width;
				}
				HScrollBar hScrollBar;
				if (this.VScrollBar1.Visible)
				{
					hScrollBar = this.HScrollBar1;
					hScrollBar.Maximum += this.VScrollBar1.Width;
				}
				this.HScrollBar1.LargeChange = (int)Math.Round((double)(this.HScrollBar1.Maximum * this.Panel2.ClientSize.Width) / (double)pImageSize.Width);
				this.HScrollBar1.SmallChange = (int)Math.Round((double)this.HScrollBar1.Maximum / 20.0);
				hScrollBar = this.HScrollBar1;
				hScrollBar.Maximum += this.HScrollBar1.LargeChange;
				if (pImageSize.Height - this.Panel2.ClientSize.Height > 0)
				{
					this.VScrollBar1.Maximum = pImageSize.Height - this.Panel2.ClientSize.Height;
				}
				VScrollBar vScrollBar;
				if (this.HScrollBar1.Visible)
				{
					vScrollBar = this.VScrollBar1;
					vScrollBar.Maximum += this.HScrollBar1.Height;
				}
				this.VScrollBar1.LargeChange = (int)Math.Round((double)(this.VScrollBar1.Maximum * this.Panel2.ClientSize.Height) / (double)pImageSize.Height);
				this.VScrollBar1.SmallChange = (int)Math.Round((double)this.VScrollBar1.Maximum / 20.0);
				vScrollBar = this.VScrollBar1;
				vScrollBar.Maximum += this.VScrollBar1.LargeChange;
			}
		}

		public void DisplayScrollBars()
		{
			this.HScrollBar1.Value = 0;
			this.VScrollBar1.Value = 0;
			this.pointTL.X = 0;
			this.pointTL.Y = 0;
			checked
			{
				Size clientSize;
				if (this.PictureBox1.Visible)
				{
					this.PictureBox1.Location = this.pointTL;
					Control arg_79_0 = this.PictureBox1;
					clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
					arg_79_0.Size = clientSize;
					if (this.Panel2.Width > this.PictureBox1.Width)
					{
						this.HScrollBar1.Visible = false;
					}
					else
					{
						this.HScrollBar1.Visible = true;
					}
					if (this.Panel2.Height > this.PictureBox1.Height)
					{
						this.VScrollBar1.Visible = false;
					}
					else
					{
						this.VScrollBar1.Visible = true;
					}
					if (this.VScrollBar1.Visible)
					{
						Control arg_114_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_114_0.Width = clientSize.Width - this.VScrollBar1.Width;
					}
					else
					{
						Control arg_134_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_134_0.Width = clientSize.Width;
					}
					if (this.HScrollBar1.Visible)
					{
						Control arg_16B_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_16B_0.Height = clientSize.Height - this.HScrollBar1.Height;
					}
					else
					{
						Control arg_18B_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_18B_0.Height = clientSize.Height;
					}
				}
				clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
				this.SetScrollBarValues(clientSize);
			}
		}

		public void UpdateScrollBars()
		{
			checked
			{
				Size clientSize;
				if (this.PictureBox1.Visible)
				{
					this.PictureBox1.Location = this.pointTL;
					Control arg_49_0 = this.PictureBox1;
					clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
					arg_49_0.Size = clientSize;
					if (this.Panel2.Width > this.PictureBox1.Width)
					{
						this.HScrollBar1.Visible = false;
					}
					else
					{
						this.HScrollBar1.Visible = true;
					}
					if (this.Panel2.Height > this.PictureBox1.Height)
					{
						this.VScrollBar1.Visible = false;
					}
					else
					{
						this.VScrollBar1.Visible = true;
					}
					if (this.VScrollBar1.Visible)
					{
						Control arg_E4_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_E4_0.Width = clientSize.Width - this.VScrollBar1.Width;
					}
					else
					{
						Control arg_104_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_104_0.Width = clientSize.Width;
					}
					if (this.HScrollBar1.Visible)
					{
						Control arg_13B_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_13B_0.Height = clientSize.Height - this.HScrollBar1.Height;
					}
					else
					{
						Control arg_15B_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_15B_0.Height = clientSize.Height;
					}
				}
				clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
				this.SetScrollBarValues(clientSize);
			}
		}

		private void HScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			this.pointTL.X = checked(0 - this.HScrollBar1.Value);
			this.PictureBox1.Location = this.pointTL;
			this.PopulateCellInfo();
		}

		private void VScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			this.pointTL.Y = checked(0 - this.VScrollBar1.Value);
			this.PictureBox1.Location = this.pointTL;
			this.PopulateCellInfo();
		}

		private void Panel2_Resize(object sender, EventArgs e)
		{
			this.UpdateScrollBars();
		}
	}
}
