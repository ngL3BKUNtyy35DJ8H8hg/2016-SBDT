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

namespace BdTC
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

		private static ArrayList __ENCList = new ArrayList();

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

		private Point pointTL;

		public int myScale;

		public int myWidth;

		public int myHeight;

		private dlgChangeTable.myTableTools myTool;

		private Point myPrevPt;

		private Point myPrevPt0;

		private CBanDo myBanDo;

		private TableGraphic myTable;

		private int curCol;

		private int curRow;

		private int icurCell;

		private CCell SeleCell;

		private float savRotation;

		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual Button btnChange
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnChange;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._btnChange != null;
				if (flag)
				{
					this._btnChange.Click -= new EventHandler(this.btnChange_Click);
				}
				this._btnChange = value;
				flag = (this._btnChange != null);
				if (flag)
				{
					this._btnChange.Click += new EventHandler(this.btnChange_Click);
				}
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual TextBox txtBrushColor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBrushColor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._txtBrushColor != null;
				if (flag)
				{
					this._txtBrushColor.DoubleClick -= new EventHandler(this.txtBrushColor_DoubleClick);
				}
				this._txtBrushColor = value;
				flag = (this._txtBrushColor != null);
				if (flag)
				{
					this._txtBrushColor.DoubleClick += new EventHandler(this.txtBrushColor_DoubleClick);
				}
			}
		}

		internal virtual TextBox txtColor2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtColor2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._txtColor2 != null;
				if (flag)
				{
					this._txtColor2.DoubleClick -= new EventHandler(this.txtColor2_DoubleClick);
				}
				this._txtColor2 = value;
				flag = (this._txtColor2 != null);
				if (flag)
				{
					this._txtColor2.DoubleClick += new EventHandler(this.txtColor2_DoubleClick);
				}
			}
		}

		internal virtual TextBox txtColor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtColor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._txtColor != null;
				if (flag)
				{
					this._txtColor.DoubleClick -= new EventHandler(this.txtColor_DoubleClick);
				}
				this._txtColor = value;
				flag = (this._txtColor != null);
				if (flag)
				{
					this._txtColor.DoubleClick += new EventHandler(this.txtColor_DoubleClick);
				}
			}
		}

		internal virtual NumericUpDown nudAlpha
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nudAlpha;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._nudAlpha != null;
				if (flag)
				{
					this._nudAlpha.ValueChanged -= new EventHandler(this.nudAlpha_ValueChanged);
				}
				this._nudAlpha = value;
				flag = (this._nudAlpha != null);
				if (flag)
				{
					this._nudAlpha.ValueChanged += new EventHandler(this.nudAlpha_ValueChanged);
				}
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual NumericUpDown nudPenWidth2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nudPenWidth2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._nudPenWidth2 != null;
				if (flag)
				{
					this._nudPenWidth2.ValueChanged -= new EventHandler(this.nudPenWidth2_ValueChanged);
				}
				this._nudPenWidth2 = value;
				flag = (this._nudPenWidth2 != null);
				if (flag)
				{
					this._nudPenWidth2.ValueChanged += new EventHandler(this.nudPenWidth2_ValueChanged);
				}
			}
		}

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual NumericUpDown nudPenWidth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nudPenWidth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._nudPenWidth != null;
				if (flag)
				{
					this._nudPenWidth.ValueChanged -= new EventHandler(this.nudPenWidth_ValueChanged);
				}
				this._nudPenWidth = value;
				flag = (this._nudPenWidth != null);
				if (flag)
				{
					this._nudPenWidth.ValueChanged += new EventHandler(this.nudPenWidth_ValueChanged);
				}
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Splitter Splitter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Splitter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Splitter1 = value;
			}
		}

		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Panel2 != null;
				if (flag)
				{
					this._Panel2.Resize -= new EventHandler(this.Panel2_Resize);
				}
				this._Panel2 = value;
				flag = (this._Panel2 != null);
				if (flag)
				{
					this._Panel2.Resize += new EventHandler(this.Panel2_Resize);
				}
			}
		}

		internal virtual VScrollBar VScrollBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._VScrollBar1 != null;
				if (flag)
				{
					this._VScrollBar1.ValueChanged -= new EventHandler(this.VScrollBar1_ValueChanged);
				}
				this._VScrollBar1 = value;
				flag = (this._VScrollBar1 != null);
				if (flag)
				{
					this._VScrollBar1.ValueChanged += new EventHandler(this.VScrollBar1_ValueChanged);
				}
			}
		}

		internal virtual HScrollBar HScrollBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HScrollBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._HScrollBar1 != null;
				if (flag)
				{
					this._HScrollBar1.ValueChanged -= new EventHandler(this.HScrollBar1_ValueChanged);
				}
				this._HScrollBar1 = value;
				flag = (this._HScrollBar1 != null);
				if (flag)
				{
					this._HScrollBar1.ValueChanged += new EventHandler(this.HScrollBar1_ValueChanged);
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged -= new EventHandler(this.TextBox1_TextChanged);
				}
				this._TextBox1 = value;
				flag = (this._TextBox1 != null);
				if (flag)
				{
					this._TextBox1.TextChanged += new EventHandler(this.TextBox1_TextChanged);
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._PictureBox1 != null;
				if (flag)
				{
					this._PictureBox1.MouseUp -= new MouseEventHandler(this.PictureBox1_MouseUp);
					this._PictureBox1.MouseDown -= new MouseEventHandler(this.PictureBox1_MouseDown);
					this._PictureBox1.MouseMove -= new MouseEventHandler(this.PictureBox1_MouseMove);
					this._PictureBox1.Paint -= new PaintEventHandler(this.PictureBox1_Paint1);
				}
				this._PictureBox1 = value;
				flag = (this._PictureBox1 != null);
				if (flag)
				{
					this._PictureBox1.MouseUp += new MouseEventHandler(this.PictureBox1_MouseUp);
					this._PictureBox1.MouseDown += new MouseEventHandler(this.PictureBox1_MouseDown);
					this._PictureBox1.MouseMove += new MouseEventHandler(this.PictureBox1_MouseMove);
					this._PictureBox1.Paint += new PaintEventHandler(this.PictureBox1_Paint1);
				}
			}
		}

		internal virtual ContextMenu ContextMenu1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenu1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenu1 = value;
			}
		}

		internal virtual MenuItem mnuInsertCol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuInsertCol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuInsertCol != null;
				if (flag)
				{
					this._mnuInsertCol.Click -= new EventHandler(this.mnuInsertCol_Click);
				}
				this._mnuInsertCol = value;
				flag = (this._mnuInsertCol != null);
				if (flag)
				{
					this._mnuInsertCol.Click += new EventHandler(this.mnuInsertCol_Click);
				}
			}
		}

		internal virtual MenuItem mnuInsertRow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuInsertRow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuInsertRow != null;
				if (flag)
				{
					this._mnuInsertRow.Click -= new EventHandler(this.mnuInsertRow_Click);
				}
				this._mnuInsertRow = value;
				flag = (this._mnuInsertRow != null);
				if (flag)
				{
					this._mnuInsertRow.Click += new EventHandler(this.mnuInsertRow_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem5 = value;
			}
		}

		internal virtual MenuItem mnuDeleteCol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuDeleteCol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuDeleteCol != null;
				if (flag)
				{
					this._mnuDeleteCol.Click -= new EventHandler(this.mnuDeleteCol_Click);
				}
				this._mnuDeleteCol = value;
				flag = (this._mnuDeleteCol != null);
				if (flag)
				{
					this._mnuDeleteCol.Click += new EventHandler(this.mnuDeleteCol_Click);
				}
			}
		}

		internal virtual MenuItem mnuDeleteRow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuDeleteRow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuDeleteRow != null;
				if (flag)
				{
					this._mnuDeleteRow.Click -= new EventHandler(this.mnuDeleteRow_Click);
				}
				this._mnuDeleteRow = value;
				flag = (this._mnuDeleteRow != null);
				if (flag)
				{
					this._mnuDeleteRow.Click += new EventHandler(this.mnuDeleteRow_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem1 = value;
			}
		}

		internal virtual MenuItem mnuLinkRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuLinkRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuLinkRight != null;
				if (flag)
				{
					this._mnuLinkRight.Click -= new EventHandler(this.mnuLinkRight_Click);
				}
				this._mnuLinkRight = value;
				flag = (this._mnuLinkRight != null);
				if (flag)
				{
					this._mnuLinkRight.Click += new EventHandler(this.mnuLinkRight_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem2 = value;
			}
		}

		internal virtual MenuItem mnuLinkDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuLinkDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuLinkDown != null;
				if (flag)
				{
					this._mnuLinkDown.Click -= new EventHandler(this.mnuLinkDown_Click);
				}
				this._mnuLinkDown = value;
				flag = (this._mnuLinkDown != null);
				if (flag)
				{
					this._mnuLinkDown.Click += new EventHandler(this.mnuLinkDown_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuItem3 = value;
			}
		}

		internal virtual MenuItem mnuTextFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mnuTextFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._mnuTextFont != null;
				if (flag)
				{
					this._mnuTextFont.Click -= new EventHandler(this.mnuTextFont_Click);
				}
				this._mnuTextFont = value;
				flag = (this._mnuTextFont != null);
				if (flag)
				{
					this._mnuTextFont.Click += new EventHandler(this.mnuTextFont_Click);
				}
			}
		}

		public dlgChangeTable()
		{
			base.Load += new EventHandler(this.dlgChangeTable_Load);
			dlgChangeTable.__ENCList.Add(new WeakReference(this));
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
				bool flag = disposing && this.components != null;
				if (flag)
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
			Control arg_2E0_0 = this.Panel1;
			Point location = new Point(0, 0);
			arg_2E0_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_310_0 = this.Panel1;
			Size size = new Size(152, 278);
			arg_310_0.Size = size;
			this.Panel1.TabIndex = 1;
			this.btnChange.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_347_0 = this.btnChange;
			location = new Point(68, 244);
			arg_347_0.Location = location;
			this.btnChange.Name = "btnChange";
			Control arg_371_0 = this.btnChange;
			size = new Size(72, 24);
			arg_371_0.Size = size;
			this.btnChange.TabIndex = 72;
			this.btnChange.Text = "Thay đổi";
			Control arg_3A8_0 = this.Label4;
			location = new Point(8, 72);
			arg_3A8_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_3D2_0 = this.Label4;
			size = new Size(80, 16);
			arg_3D2_0.Size = size;
			this.Label4.TabIndex = 71;
			this.Label4.Text = "Mầu tô:";
			this.txtBrushColor.BackColor = Color.Red;
			this.txtBrushColor.ForeColor = SystemColors.HighlightText;
			Control arg_42C_0 = this.txtBrushColor;
			location = new Point(88, 72);
			arg_42C_0.Location = location;
			this.txtBrushColor.Name = "txtBrushColor";
			Control arg_456_0 = this.txtBrushColor;
			size = new Size(24, 21);
			arg_456_0.Size = size;
			this.txtBrushColor.TabIndex = 66;
			this.txtColor2.BackColor = SystemColors.Highlight;
			this.txtColor2.ForeColor = SystemColors.HighlightText;
			Control arg_49F_0 = this.txtColor2;
			location = new Point(88, 40);
			arg_49F_0.Location = location;
			this.txtColor2.Name = "txtColor2";
			Control arg_4C9_0 = this.txtColor2;
			size = new Size(24, 21);
			arg_4C9_0.Size = size;
			this.txtColor2.TabIndex = 64;
			this.txtColor.BackColor = Color.Red;
			this.txtColor.ForeColor = SystemColors.HighlightText;
			Control arg_512_0 = this.txtColor;
			location = new Point(88, 16);
			arg_512_0.Location = location;
			this.txtColor.Name = "txtColor";
			Control arg_53C_0 = this.txtColor;
			size = new Size(24, 21);
			arg_53C_0.Size = size;
			this.txtColor.TabIndex = 61;
			Control arg_563_0 = this.nudAlpha;
			location = new Point(88, 96);
			arg_563_0.Location = location;
			NumericUpDown arg_594_0 = this.nudAlpha;
			decimal num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			arg_594_0.Maximum = num;
			this.nudAlpha.Name = "nudAlpha";
			Control arg_5BE_0 = this.nudAlpha;
			size = new Size(48, 21);
			arg_5BE_0.Size = size;
			this.nudAlpha.TabIndex = 69;
			NumericUpDown arg_5FD_0 = this.nudAlpha;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			arg_5FD_0.Value = num;
			Control arg_616_0 = this.Label1;
			location = new Point(40, 96);
			arg_616_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_640_0 = this.Label1;
			size = new Size(48, 16);
			arg_640_0.Size = size;
			this.Label1.TabIndex = 68;
			this.Label1.Text = "Độ mờ:";
			Control arg_678_0 = this.nudPenWidth2;
			location = new Point(112, 40);
			arg_678_0.Location = location;
			NumericUpDown arg_6A6_0 = this.nudPenWidth2;
			num = new decimal(new int[]
			{
				72,
				0,
				0,
				0
			});
			arg_6A6_0.Maximum = num;
			this.nudPenWidth2.Name = "nudPenWidth2";
			Control arg_6D0_0 = this.nudPenWidth2;
			size = new Size(32, 21);
			arg_6D0_0.Size = size;
			this.nudPenWidth2.TabIndex = 65;
			NumericUpDown arg_70B_0 = this.nudPenWidth2;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_70B_0.Value = num;
			Control arg_723_0 = this.Label8;
			location = new Point(8, 40);
			arg_723_0.Location = location;
			this.Label8.Name = "Label8";
			Control arg_74D_0 = this.Label8;
			size = new Size(72, 16);
			arg_74D_0.Size = size;
			this.Label8.TabIndex = 63;
			this.Label8.Text = "Đường kẻ:";
			Control arg_785_0 = this.nudPenWidth;
			location = new Point(112, 16);
			arg_785_0.Location = location;
			NumericUpDown arg_7B3_0 = this.nudPenWidth;
			num = new decimal(new int[]
			{
				72,
				0,
				0,
				0
			});
			arg_7B3_0.Maximum = num;
			this.nudPenWidth.Name = "nudPenWidth";
			Control arg_7DD_0 = this.nudPenWidth;
			size = new Size(32, 21);
			arg_7DD_0.Size = size;
			this.nudPenWidth.TabIndex = 62;
			NumericUpDown arg_818_0 = this.nudPenWidth;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_818_0.Value = num;
			Control arg_830_0 = this.Label5;
			location = new Point(8, 16);
			arg_830_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_85A_0 = this.Label5;
			size = new Size(72, 16);
			arg_85A_0.Size = size;
			this.Label5.TabIndex = 60;
			this.Label5.Text = "Viền ngoài:";
			Control arg_894_0 = this.Splitter1;
			location = new Point(152, 0);
			arg_894_0.Location = location;
			this.Splitter1.Name = "Splitter1";
			Control arg_8C0_0 = this.Splitter1;
			size = new Size(3, 278);
			arg_8C0_0.Size = size;
			this.Splitter1.TabIndex = 2;
			this.Splitter1.TabStop = false;
			this.Panel2.BorderStyle = BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.VScrollBar1);
			this.Panel2.Controls.Add(this.HScrollBar1);
			this.Panel2.Controls.Add(this.TextBox1);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Dock = DockStyle.Fill;
			Control arg_96B_0 = this.Panel2;
			location = new Point(155, 0);
			arg_96B_0.Location = location;
			this.Panel2.Name = "Panel2";
			Control arg_99B_0 = this.Panel2;
			size = new Size(413, 278);
			arg_99B_0.Size = size;
			this.Panel2.TabIndex = 3;
			this.VScrollBar1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_9D1_0 = this.VScrollBar1;
			location = new Point(394, 0);
			arg_9D1_0.Location = location;
			this.VScrollBar1.Name = "VScrollBar1";
			Control arg_9FE_0 = this.VScrollBar1;
			size = new Size(16, 271);
			arg_9FE_0.Size = size;
			this.VScrollBar1.TabIndex = 84;
			this.HScrollBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			Control arg_A34_0 = this.HScrollBar1;
			location = new Point(0, 259);
			arg_A34_0.Location = location;
			this.HScrollBar1.Name = "HScrollBar1";
			Control arg_A61_0 = this.HScrollBar1;
			size = new Size(344, 16);
			arg_A61_0.Size = size;
			this.HScrollBar1.TabIndex = 83;
			Control arg_A8B_0 = this.TextBox1;
			location = new Point(130, 111);
			arg_A8B_0.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			Control arg_AC5_0 = this.TextBox1;
			size = new Size(152, 56);
			arg_AC5_0.Size = size;
			this.TextBox1.TabIndex = 86;
			this.TextBox1.Text = "TextBox1";
			this.PictureBox1.BackColor = SystemColors.HighlightText;
			Control arg_B0E_0 = this.PictureBox1;
			location = new Point(40, 16);
			arg_B0E_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			Control arg_B3E_0 = this.PictureBox1;
			size = new Size(336, 240);
			arg_B3E_0.Size = size;
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
			bool flag = myModule.fCallForm == myModule.fMain;
			if (flag)
			{
				this.myBanDo = myModule.fMain.myBando;
			}
			flag = (myModule.fCallForm == modBanDo.fCacKyHieu);
			TableGraphic myObj;
			if (flag)
			{
				myObj = (TableGraphic)modBanDo.fCacKyHieu.SelectedObject;
			}
			else
			{
				myObj = (TableGraphic)this.myBanDo.SelectedObject;
			}
			this.savRotation = myObj.Rotation;
			this.myTable = (TableGraphic)myObj.Clone();
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
			this.txtBrushColor.BackColor = modBanDo.GetMau(this.txtBrushColor.BackColor);
			this.myTable.FiColor = Color.FromArgb(Convert.ToInt32(this.nudAlpha.Value), this.txtBrushColor.BackColor);
			this.PictureBox1.Invalidate();
		}

		private void txtColor2_DoubleClick(object sender, EventArgs e)
		{
			this.txtColor2.BackColor = modBanDo.GetMau(this.txtColor2.BackColor);
			this.myTable.LineColor = this.txtColor2.BackColor;
			this.PictureBox1.Invalidate();
		}

		private void txtColor_DoubleClick(object sender, EventArgs e)
		{
			this.txtColor.BackColor = modBanDo.GetMau(this.txtColor.BackColor);
			this.myTable.BorderColor = this.txtColor.BackColor;
			this.PictureBox1.Invalidate();
		}

		private void PictureBox1_Paint1(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			float mX = -this.myTable.X;
			float mY = -this.myTable.Y;
			GraphicsContainer gCon = g.BeginContainer();
			g.TranslateTransform(mX, mY);
			this.myTable.Draw(g);
			g.EndContainer(gCon);
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SeleCell.Text = this.TextBox1.Text;
				this.PictureBox1.Invalidate();
			}
			catch (Exception expr_27)
			{
				ProjectData.SetProjectError(expr_27);
				ProjectData.ClearProjectError();
			}
		}

		private void PopulateCellInfo()
		{
			bool flag = !Information.IsNothing(this.SeleCell);
			checked
			{
				if (flag)
				{
					Rectangle rect = this.GetCellBounds(this.SeleCell);
					this.TextBox1.Left = rect.X + this.pointTL.X;
					this.TextBox1.Top = rect.Y + this.pointTL.Y;
					this.TextBox1.Width = rect.Width + 2;
					this.TextBox1.Height = rect.Height + 2;
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
			bool flag = this.myTool == dlgChangeTable.myTableTools.CellChange;
			checked
			{
				if (flag)
				{
					bool flag2 = e.X == this.TextBox1.Left + this.TextBox1.Width - this.pointTL.X;
					if (flag2)
					{
						this.PictureBox1.Cursor = Cursors.SizeWE;
					}
					else
					{
						flag2 = (e.Y == this.TextBox1.Top + this.TextBox1.Height - this.pointTL.Y);
						if (flag2)
						{
							this.PictureBox1.Cursor = Cursors.SizeNS;
						}
						else
						{
							this.PictureBox1.Cursor = Cursors.Arrow;
						}
					}
				}
				else
				{
					bool flag2 = this.myTool == dlgChangeTable.myTableTools.HChange;
					if (flag2)
					{
						int mDy = e.Y - this.myPrevPt.Y;
						flag2 = (unchecked(this.myTable.AHeight[this.curRow] + (float)mDy) > 0f);
						if (flag2)
						{
							try
							{
								TableGraphic tableGraphic = this.myTable;
								unchecked
								{
									tableGraphic.Height += (float)mDy;
									float[] array = this.myTable.AHeight;
									float[] arg_139_0 = array;
									int num = this.curRow;
									arg_139_0[num] = array[num] + (float)mDy;
								}
								this.myHeight = (int)Math.Round((double)(unchecked(this.myTable.Height + 4f)));
								this.PictureBox1.Invalidate();
								this.TextBox1.Height = (int)Math.Round((double)this.myTable.AHeight[this.curRow]);
							}
							catch (Exception expr_18C)
							{
								ProjectData.SetProjectError(expr_18C);
								ProjectData.ClearProjectError();
							}
						}
						this.myPrevPt.Y = e.Y;
					}
					else
					{
						flag2 = (this.myTool == dlgChangeTable.myTableTools.WChange);
						if (flag2)
						{
							int mDx = e.X - this.myPrevPt.X;
							flag2 = (unchecked(this.myTable.AWidth[this.curCol] + (float)mDx) > 0f);
							if (flag2)
							{
								try
								{
									TableGraphic tableGraphic = this.myTable;
									unchecked
									{
										tableGraphic.Width += (float)mDx;
										float[] array = this.myTable.AWidth;
										float[] arg_23A_0 = array;
										int num = this.curCol;
										arg_23A_0[num] = array[num] + (float)mDx;
									}
									this.myWidth = (int)Math.Round((double)(unchecked(this.myTable.Width + 4f)));
									this.PictureBox1.Invalidate();
									this.TextBox1.Width = (int)Math.Round((double)this.myTable.AWidth[this.curCol]);
								}
								catch (Exception expr_28D)
								{
									ProjectData.SetProjectError(expr_28D);
									ProjectData.ClearProjectError();
								}
							}
							this.myPrevPt.X = e.X;
						}
					}
				}
			}
		}

		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.PictureBox1.Cursor == Cursors.SizeWE;
			if (flag)
			{
				this.myTool = dlgChangeTable.myTableTools.WChange;
				this.myPrevPt0.X = e.X;
				this.myPrevPt.X = e.X;
				this.PictureBox1.Cursor = Cursors.SizeWE;
				this.TextBox1.Visible = false;
			}
			else
			{
				flag = (this.PictureBox1.Cursor == Cursors.SizeNS);
				if (flag)
				{
					this.myTool = dlgChangeTable.myTableTools.HChange;
					this.myPrevPt0.Y = e.Y;
					this.myPrevPt.Y = e.Y;
					this.PictureBox1.Cursor = Cursors.SizeNS;
					this.TextBox1.Visible = false;
				}
			}
		}

		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.myTool == dlgChangeTable.myTableTools.WChange;
			if (flag)
			{
				this.UpdateScrollBars();
				this.TextBox1.Visible = true;
				this.myTool = dlgChangeTable.myTableTools.CellChange;
				this.PictureBox1.Cursor = Cursors.Arrow;
				flag = !Information.IsNothing(this.SeleCell);
				if (flag)
				{
					this.PopulateCellInfo();
				}
			}
			else
			{
				flag = (this.myTool == dlgChangeTable.myTableTools.HChange);
				if (flag)
				{
					this.UpdateScrollBars();
					this.TextBox1.Visible = true;
					this.myTool = dlgChangeTable.myTableTools.CellChange;
					this.PictureBox1.Cursor = Cursors.Arrow;
					flag = !Information.IsNothing(this.SeleCell);
					if (flag)
					{
						this.PopulateCellInfo();
					}
				}
				else
				{
					PointF pt = new PointF((float)e.X, (float)e.Y);
					this.SeleCell = this.FindCellAtPoint(pt);
					flag = !Information.IsNothing(this.SeleCell);
					if (flag)
					{
						this.PopulateCellInfo();
					}
				}
			}
		}

		private void mnuInsertRow_Click(object sender, EventArgs e)
		{
			bool flag = !Information.IsNothing(this.SeleCell);
			if (flag)
			{
				this.myTable.InsertRow(this.SeleCell);
				this.myHeight = checked((int)Math.Round((double)(unchecked(this.myTable.Height + 4f))));
				this.UpdateScrollBars();
				this.PictureBox1.Invalidate();
			}
		}

		private void mnuDeleteRow_Click(object sender, EventArgs e)
		{
			bool flag = this.myTable.RowsNo > 1;
			checked
			{
				if (flag)
				{
					bool flag2 = this.SeleCell.RowsNo == 1;
					if (flag2)
					{
						this.myTable.DeleteRow(this.curRow);
						flag2 = (this.curRow > this.myTable.RowsNo - 1);
						if (flag2)
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
			bool flag = !Information.IsNothing(this.SeleCell);
			if (flag)
			{
				this.myTable.InsertCol(this.SeleCell);
				this.myWidth = checked((int)Math.Round((double)(unchecked(this.myTable.Width + 4f))));
				this.UpdateScrollBars();
				this.PictureBox1.Invalidate();
			}
		}

		private void mnuDeleteCol_Click(object sender, EventArgs e)
		{
			bool flag = this.myTable.ColsNo > 1;
			checked
			{
				if (flag)
				{
					bool flag2 = this.SeleCell.ColsNo == 1;
					if (flag2)
					{
						this.myTable.DeleteCol(this.curCol);
						flag2 = (this.curCol > this.myTable.ColsNo - 1);
						if (flag2)
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
			catch (Exception expr_3C)
			{
				ProjectData.SetProjectError(expr_3C);
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
			catch (Exception expr_2C)
			{
				ProjectData.SetProjectError(expr_2C);
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
			catch (Exception expr_2C)
			{
				ProjectData.SetProjectError(expr_2C);
				ProjectData.ClearProjectError();
			}
		}

		private CCell FindCellAtPoint(PointF pt)
		{
			CCell FindCellAtPoint;
			try
			{
				IEnumerator enumerator = this.myTable.Cells.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CCell mCell = (CCell)enumerator.Current;
					bool flag = this.HitTest(mCell, pt);
					if (flag)
					{
						FindCellAtPoint = mCell;
						return FindCellAtPoint;
					}
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
			FindCellAtPoint = null;
			return FindCellAtPoint;
		}

		private bool HitTest(CCell mCell, PointF pt)
		{
			GraphicsPath gp = new GraphicsPath();
			Rectangle rect = this.GetCellBounds(mCell);
			gp.AddRectangle(rect);
			return gp.IsVisible(pt);
		}

		private Rectangle GetCellBounds(CCell pCell)
		{
			float mX = 0f;
			bool flag = pCell.iCol > 0;
			checked
			{
				if (flag)
				{
					int arg_21_0 = 0;
					int num = pCell.iCol - 1;
					int i = arg_21_0;
					while (true)
					{
						int arg_4D_0 = i;
						int num2 = num;
						if (arg_4D_0 > num2)
						{
							break;
						}
						unchecked
						{
							mX += this.myTable.AWidth[i] * (float)this.myScale;
						}
						i++;
					}
				}
				float mW = 0f;
				int arg_61_0 = 0;
				int num3 = pCell.ColsNo - 1;
				int j = arg_61_0;
				while (true)
				{
					int arg_94_0 = j;
					int num2 = num3;
					if (arg_94_0 > num2)
					{
						break;
					}
					unchecked
					{
						mW += this.myTable.AWidth[checked(pCell.iCol + j)] * (float)this.myScale;
					}
					j++;
				}
				float mY = 0f;
				flag = (pCell.iRow > 0);
				if (flag)
				{
					int arg_B7_0 = 0;
					int num4 = pCell.iRow - 1;
					int k = arg_B7_0;
					while (true)
					{
						int arg_E5_0 = k;
						int num2 = num4;
						if (arg_E5_0 > num2)
						{
							break;
						}
						unchecked
						{
							mY += this.myTable.AHeight[k] * (float)this.myScale;
						}
						k++;
					}
				}
				float mH = 0f;
				int arg_F9_0 = 0;
				int num5 = pCell.RowsNo - 1;
				int l = arg_F9_0;
				while (true)
				{
					int arg_12C_0 = l;
					int num2 = num5;
					if (arg_12C_0 > num2)
					{
						break;
					}
					unchecked
					{
						mH += this.myTable.AHeight[checked(pCell.iRow + l)] * (float)this.myScale;
					}
					l++;
				}
				Rectangle result = new Rectangle((int)Math.Round((double)mX), (int)Math.Round((double)mY), (int)Math.Round((double)mW), (int)Math.Round((double)mH));
				return result;
			}
		}

		private void mnuLinkRight_Click(object sender, EventArgs e)
		{
			bool flag = !Information.IsNothing(this.SeleCell);
			if (flag)
			{
				this.myTable.LinkCellRight(this.SeleCell);
				this.PopulateCellInfo();
			}
		}

		private void mnuLinkDown_Click(object sender, EventArgs e)
		{
			bool flag = !Information.IsNothing(this.SeleCell);
			if (flag)
			{
				this.myTable.LinkCellDown(this.SeleCell);
				this.PopulateCellInfo();
			}
		}

		private void mnuTextFont_Click(object sender, EventArgs e)
		{
			bool flag = !Information.IsNothing(this.SeleCell);
			if (flag)
			{
				FontDialog fontDialog = new FontDialog();
				fontDialog.Font = this.SeleCell.Font;
				fontDialog.Color = this.SeleCell.Color;
				fontDialog.ShowColor = true;
				flag = (fontDialog.ShowDialog() != DialogResult.Cancel);
				if (flag)
				{
					this.SeleCell.Font = fontDialog.Font;
					this.SeleCell.Color = fontDialog.Color;
					this.PopulateCellInfo();
				}
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			bool flag = !Information.IsNothing(this.myBanDo);
			if (flag)
			{
				this.myBanDo.PopUndo();
			}
			flag = (myModule.fCallForm == modBanDo.fCacKyHieu);
			TableGraphic myObj;
			if (flag)
			{
				myObj = (TableGraphic)modBanDo.fCacKyHieu.SelectedObject;
			}
			else
			{
				myObj = (TableGraphic)this.myBanDo.SelectedObject;
			}
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
				bool flag = pImageSize.Width - this.Panel2.ClientSize.Width > 0;
				if (flag)
				{
					this.HScrollBar1.Maximum = pImageSize.Width - this.Panel2.ClientSize.Width;
				}
				flag = this.VScrollBar1.Visible;
				HScrollBar hScrollBar;
				if (flag)
				{
					hScrollBar = this.HScrollBar1;
					hScrollBar.Maximum += this.VScrollBar1.Width;
				}
				this.HScrollBar1.LargeChange = (int)Math.Round((double)(this.HScrollBar1.Maximum * this.Panel2.ClientSize.Width) / (double)pImageSize.Width);
				this.HScrollBar1.SmallChange = (int)Math.Round((double)this.HScrollBar1.Maximum / 20.0);
				hScrollBar = this.HScrollBar1;
				hScrollBar.Maximum += this.HScrollBar1.LargeChange;
				flag = (pImageSize.Height - this.Panel2.ClientSize.Height > 0);
				if (flag)
				{
					this.VScrollBar1.Maximum = pImageSize.Height - this.Panel2.ClientSize.Height;
				}
				flag = this.HScrollBar1.Visible;
				VScrollBar vScrollBar;
				if (flag)
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
			bool flag = this.PictureBox1.Visible;
			checked
			{
				Size clientSize;
				if (flag)
				{
					this.PictureBox1.Location = this.pointTL;
					Control arg_82_0 = this.PictureBox1;
					clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
					arg_82_0.Size = clientSize;
					flag = (this.Panel2.Width > this.PictureBox1.Width);
					if (flag)
					{
						this.HScrollBar1.Visible = false;
					}
					else
					{
						this.HScrollBar1.Visible = true;
					}
					flag = (this.Panel2.Height > this.PictureBox1.Height);
					if (flag)
					{
						this.VScrollBar1.Visible = false;
					}
					else
					{
						this.VScrollBar1.Visible = true;
					}
					flag = this.VScrollBar1.Visible;
					if (flag)
					{
						Control arg_130_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_130_0.Width = clientSize.Width - this.VScrollBar1.Width;
					}
					else
					{
						Control arg_152_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_152_0.Width = clientSize.Width;
					}
					flag = this.HScrollBar1.Visible;
					if (flag)
					{
						Control arg_18D_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_18D_0.Height = clientSize.Height - this.HScrollBar1.Height;
					}
					else
					{
						Control arg_1AF_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_1AF_0.Height = clientSize.Height;
					}
				}
				clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
				this.SetScrollBarValues(clientSize);
			}
		}

		public void UpdateScrollBars()
		{
			bool flag = this.PictureBox1.Visible;
			checked
			{
				Size clientSize;
				if (flag)
				{
					this.PictureBox1.Location = this.pointTL;
					Control arg_4E_0 = this.PictureBox1;
					clientSize = new Size(this.myWidth * this.myScale, this.myHeight * this.myScale);
					arg_4E_0.Size = clientSize;
					flag = (this.Panel2.Width > this.PictureBox1.Width);
					if (flag)
					{
						this.HScrollBar1.Visible = false;
					}
					else
					{
						this.HScrollBar1.Visible = true;
					}
					flag = (this.Panel2.Height > this.PictureBox1.Height);
					if (flag)
					{
						this.VScrollBar1.Visible = false;
					}
					else
					{
						this.VScrollBar1.Visible = true;
					}
					flag = this.VScrollBar1.Visible;
					if (flag)
					{
						Control arg_FC_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_FC_0.Width = clientSize.Width - this.VScrollBar1.Width;
					}
					else
					{
						Control arg_11E_0 = this.HScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_11E_0.Width = clientSize.Width;
					}
					flag = this.HScrollBar1.Visible;
					if (flag)
					{
						Control arg_159_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_159_0.Height = clientSize.Height - this.HScrollBar1.Height;
					}
					else
					{
						Control arg_17B_0 = this.VScrollBar1;
						clientSize = this.Panel2.ClientSize;
						arg_17B_0.Height = clientSize.Height;
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
