namespace ImageResize
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listImage = new MaterialSkin.Controls.MaterialListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbLoadImage = new MaterialSkin.Controls.MaterialProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFolerPath = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenFolder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPercent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtHeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtWidth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.optHeight = new MaterialSkin.Controls.MaterialRadioButton();
            this.optWidth = new MaterialSkin.Controls.MaterialRadioButton();
            this.optSize = new MaterialSkin.Controls.MaterialRadioButton();
            this.optPercent = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listResult = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSaveFolder = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveFolder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPer = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnRun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbRun = new MaterialSkin.Controls.MaterialProgressBar();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(729, 44);
            this.materialTabSelector1.TabIndex = 18;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 102);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(689, 437);
            this.materialTabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.listImage);
            this.tabPage1.Controls.Add(this.pbLoadImage);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Images";
            // 
            // listImage
            // 
            this.listImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listImage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Path,
            this.FileSize,
            this.Width,
            this.Height});
            this.listImage.Depth = 0;
            this.listImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listImage.FullRowSelect = true;
            this.listImage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listImage.Location = new System.Drawing.Point(3, 52);
            this.listImage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listImage.MouseState = MaterialSkin.MouseState.OUT;
            this.listImage.MultiSelect = false;
            this.listImage.Name = "listImage";
            this.listImage.OwnerDraw = true;
            this.listImage.Size = new System.Drawing.Size(675, 351);
            this.listImage.TabIndex = 22;
            this.listImage.UseCompatibleStateImageBehavior = false;
            this.listImage.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 200;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 100;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Size";
            this.FileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FileSize.Width = 120;
            // 
            // Width
            // 
            this.Width.Text = "Width";
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Width.Width = 100;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            this.Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Height.Width = 100;
            // 
            // pbLoadImage
            // 
            this.pbLoadImage.Depth = 0;
            this.pbLoadImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLoadImage.Location = new System.Drawing.Point(3, 403);
            this.pbLoadImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbLoadImage.Name = "pbLoadImage";
            this.pbLoadImage.Size = new System.Drawing.Size(675, 5);
            this.pbLoadImage.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoadImage.TabIndex = 24;
            this.pbLoadImage.Value = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenFolder);
            this.panel1.Controls.Add(this.txtFolerPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 49);
            this.panel1.TabIndex = 23;
            // 
            // txtFolerPath
            // 
            this.txtFolerPath.Depth = 0;
            this.txtFolerPath.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtFolerPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFolerPath.Location = new System.Drawing.Point(14, 12);
            this.txtFolerPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFolerPath.Name = "txtFolerPath";
            this.txtFolerPath.Size = new System.Drawing.Size(535, 27);
            this.txtFolerPath.TabIndex = 23;
            this.txtFolerPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.AutoSize = true;
            this.btnOpenFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFolder.Depth = 0;
            this.btnOpenFolder.Icon = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(561, 7);
            this.btnOpenFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Primary = true;
            this.btnOpenFolder.Size = new System.Drawing.Size(110, 36);
            this.btnOpenFolder.TabIndex = 22;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.txtPercent);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.txtHeight);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.txtWidth);
            this.tabPage2.Controls.Add(this.optHeight);
            this.tabPage2.Controls.Add(this.optWidth);
            this.tabPage2.Controls.Add(this.optSize);
            this.tabPage2.Controls.Add(this.optPercent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resize";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(241, 41);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Percentage (%)";
            // 
            // txtPercent
            // 
            this.txtPercent.BackColor = System.Drawing.Color.White;
            this.txtPercent.Depth = 0;
            this.txtPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPercent.Hint = "";
            this.txtPercent.Location = new System.Drawing.Point(245, 69);
            this.txtPercent.MaxLength = 32767;
            this.txtPercent.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.PasswordChar = '\0';
            this.txtPercent.SelectedText = "";
            this.txtPercent.SelectionLength = 0;
            this.txtPercent.SelectionStart = 0;
            this.txtPercent.Size = new System.Drawing.Size(162, 23);
            this.txtPercent.TabIndex = 1;
            this.txtPercent.TabStop = false;
            this.txtPercent.Text = "20";
            this.txtPercent.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(454, 117);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Height (Pixels)";
            // 
            // txtHeight
            // 
            this.txtHeight.Depth = 0;
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHeight.Hint = "";
            this.txtHeight.Location = new System.Drawing.Point(458, 145);
            this.txtHeight.MaxLength = 32767;
            this.txtHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.SelectedText = "";
            this.txtHeight.SelectionLength = 0;
            this.txtHeight.SelectionStart = 0;
            this.txtHeight.Size = new System.Drawing.Size(162, 23);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TabStop = false;
            this.txtHeight.Text = "100";
            this.txtHeight.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(454, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Width (Pixels)";
            // 
            // txtWidth
            // 
            this.txtWidth.Depth = 0;
            this.txtWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtWidth.Hint = "";
            this.txtWidth.Location = new System.Drawing.Point(458, 69);
            this.txtWidth.MaxLength = 32767;
            this.txtWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.SelectedText = "";
            this.txtWidth.SelectionLength = 0;
            this.txtWidth.SelectionStart = 0;
            this.txtWidth.Size = new System.Drawing.Size(162, 23);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.TabStop = false;
            this.txtWidth.Text = "100";
            this.txtWidth.UseSystemPasswordChar = false;
            // 
            // optHeight
            // 
            this.optHeight.AutoSize = true;
            this.optHeight.Depth = 0;
            this.optHeight.Font = new System.Drawing.Font("Roboto", 10F);
            this.optHeight.Location = new System.Drawing.Point(20, 140);
            this.optHeight.Margin = new System.Windows.Forms.Padding(0);
            this.optHeight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.optHeight.Name = "optHeight";
            this.optHeight.Ripple = true;
            this.optHeight.Size = new System.Drawing.Size(123, 30);
            this.optHeight.TabIndex = 0;
            this.optHeight.TabStop = true;
            this.optHeight.Tag = "4";
            this.optHeight.Text = "Scale to Height";
            this.optHeight.UseVisualStyleBackColor = true;
            this.optHeight.CheckedChanged += new System.EventHandler(this.optChanged);
            // 
            // optWidth
            // 
            this.optWidth.AutoSize = true;
            this.optWidth.Depth = 0;
            this.optWidth.Font = new System.Drawing.Font("Roboto", 10F);
            this.optWidth.Location = new System.Drawing.Point(20, 105);
            this.optWidth.Margin = new System.Windows.Forms.Padding(0);
            this.optWidth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.optWidth.Name = "optWidth";
            this.optWidth.Ripple = true;
            this.optWidth.Size = new System.Drawing.Size(117, 30);
            this.optWidth.TabIndex = 0;
            this.optWidth.TabStop = true;
            this.optWidth.Tag = "3";
            this.optWidth.Text = "Scale to Width";
            this.optWidth.UseVisualStyleBackColor = true;
            this.optWidth.CheckedChanged += new System.EventHandler(this.optChanged);
            // 
            // optSize
            // 
            this.optSize.AutoSize = true;
            this.optSize.Depth = 0;
            this.optSize.Font = new System.Drawing.Font("Roboto", 10F);
            this.optSize.Location = new System.Drawing.Point(20, 70);
            this.optSize.Margin = new System.Windows.Forms.Padding(0);
            this.optSize.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.optSize.Name = "optSize";
            this.optSize.Ripple = true;
            this.optSize.Size = new System.Drawing.Size(92, 30);
            this.optSize.TabIndex = 0;
            this.optSize.TabStop = true;
            this.optSize.Tag = "2";
            this.optSize.Text = "Fixed Size";
            this.optSize.UseVisualStyleBackColor = true;
            this.optSize.CheckedChanged += new System.EventHandler(this.optChanged);
            // 
            // optPercent
            // 
            this.optPercent.AutoSize = true;
            this.optPercent.Depth = 0;
            this.optPercent.Font = new System.Drawing.Font("Roboto", 10F);
            this.optPercent.Location = new System.Drawing.Point(20, 35);
            this.optPercent.Margin = new System.Windows.Forms.Padding(0);
            this.optPercent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optPercent.MouseState = MaterialSkin.MouseState.HOVER;
            this.optPercent.Name = "optPercent";
            this.optPercent.Ripple = true;
            this.optPercent.Size = new System.Drawing.Size(99, 30);
            this.optPercent.TabIndex = 0;
            this.optPercent.TabStop = true;
            this.optPercent.Tag = "1";
            this.optPercent.Text = "Percentage";
            this.optPercent.UseVisualStyleBackColor = true;
            this.optPercent.CheckedChanged += new System.EventHandler(this.optChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(681, 411);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Result";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.listResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 305);
            this.panel3.TabIndex = 26;
            // 
            // listResult
            // 
            this.listResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listResult.Depth = 0;
            this.listResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listResult.FullRowSelect = true;
            this.listResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listResult.Location = new System.Drawing.Point(0, 0);
            this.listResult.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listResult.MouseState = MaterialSkin.MouseState.OUT;
            this.listResult.MultiSelect = false;
            this.listResult.Name = "listResult";
            this.listResult.OwnerDraw = true;
            this.listResult.Size = new System.Drawing.Size(675, 305);
            this.listResult.TabIndex = 23;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Path";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Size";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Width";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Height";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader13.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveFolder);
            this.panel2.Controls.Add(this.txtSaveFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 49);
            this.panel2.TabIndex = 0;
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Depth = 0;
            this.txtSaveFolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtSaveFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSaveFolder.Location = new System.Drawing.Point(14, 12);
            this.txtSaveFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(535, 27);
            this.txtSaveFolder.TabIndex = 25;
            this.txtSaveFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFolder.AutoSize = true;
            this.btnSaveFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveFolder.Depth = 0;
            this.btnSaveFolder.Icon = null;
            this.btnSaveFolder.Location = new System.Drawing.Point(561, 7);
            this.btnSaveFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Primary = true;
            this.btnSaveFolder.Size = new System.Drawing.Size(108, 36);
            this.btnSaveFolder.TabIndex = 24;
            this.btnSaveFolder.Text = "Save Folder";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRun);
            this.panel4.Controls.Add(this.lblPer);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Controls.Add(this.pbRun);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 51);
            this.panel4.TabIndex = 27;
            // 
            // lblPer
            // 
            this.lblPer.BackColor = System.Drawing.Color.Transparent;
            this.lblPer.Depth = 0;
            this.lblPer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPer.Location = new System.Drawing.Point(494, 13);
            this.lblPer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(55, 23);
            this.lblPer.TabIndex = 25;
            this.lblPer.Text = "100%";
            this.lblPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(3, 13);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(485, 23);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoSize = true;
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Depth = 0;
            this.btnRun.Icon = null;
            this.btnRun.Location = new System.Drawing.Point(560, 8);
            this.btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRun.Name = "btnRun";
            this.btnRun.Primary = true;
            this.btnRun.Size = new System.Drawing.Size(100, 36);
            this.btnRun.TabIndex = 24;
            this.btnRun.Text = "▶ Process";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pbRun
            // 
            this.pbRun.Depth = 0;
            this.pbRun.Location = new System.Drawing.Point(3, 39);
            this.pbRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(549, 5);
            this.pbRun.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbRun.TabIndex = 25;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 551);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(729, 1);
            this.materialDivider1.TabIndex = 24;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dessert (100g serving)";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Calories";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fat (g)";
            this.columnHeader7.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Protein (g)";
            this.columnHeader8.Width = 154;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Depth = 0;
            this.lblCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(18, 566);
            this.lblCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 19);
            this.lblCount.TabIndex = 25;
            this.lblCount.Text = "0 Images";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 597);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SunjinSystem Image Resizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenFolder;
        private MaterialSkin.Controls.MaterialProgressBar pbLoadImage;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtWidth;
        private MaterialSkin.Controls.MaterialRadioButton optHeight;
        private MaterialSkin.Controls.MaterialRadioButton optWidth;
        private MaterialSkin.Controls.MaterialRadioButton optSize;
        private MaterialSkin.Controls.MaterialRadioButton optPercent;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPercent;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHeight;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialListView listImage;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Height;
        private MaterialSkin.Controls.MaterialLabel txtFolerPath;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialListView listResult;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private MaterialSkin.Controls.MaterialLabel txtSaveFolder;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveFolder;
        private MaterialSkin.Controls.MaterialProgressBar pbRun;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnRun;
        private MaterialSkin.Controls.MaterialLabel lblPer;
        private MaterialSkin.Controls.MaterialLabel lblCount;
    }
}

