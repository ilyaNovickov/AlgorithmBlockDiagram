namespace GSAApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cursorRadioButton = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.resizeRadioButton = new System.Windows.Forms.RadioButton();
            this.operationalRadioButton = new System.Windows.Forms.RadioButton();
            this.logicalRadioButton = new System.Windows.Forms.RadioButton();
            this.beginEndRadionButton = new System.Windows.Forms.RadioButton();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.arrowRadionButton = new System.Windows.Forms.RadioButton();
            this.commentRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.fillColorPanel = new System.Windows.Forms.Panel();
            this.contourColorPanel = new System.Windows.Forms.Panel();
            this.dashStyleComboBox = new System.Windows.Forms.ComboBox();
            this.thickUpDownButton = new System.Windows.Forms.NumericUpDown();
            this.centerButton = new System.Windows.Forms.Button();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zoomAndDragControl1 = new ZoomAndDragContolLib.ZoomAndDragControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.blockContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наПереднийПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЗаднийПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТочкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТочкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наПереднийПланToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.наЗаднийПланToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickUpDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.blockContexMenu.SuspendLayout();
            this.lineContexMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(213, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator2,
            this.zoomStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.создатьToolStripButton.Text = "&Создать";
            this.создатьToolStripButton.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // zoomStripLabel
            // 
            this.zoomStripLabel.Name = "zoomStripLabel";
            this.zoomStripLabel.Size = new System.Drawing.Size(112, 28);
            this.zoomStripLabel.Text = "Маштаб : 100%";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.cursorRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.resizeRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.operationalRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.logicalRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.beginEndRadionButton);
            this.flowLayoutPanel1.Controls.Add(this.lineRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.arrowRadionButton);
            this.flowLayoutPanel1.Controls.Add(this.commentRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 116);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cursorRadioButton
            // 
            this.cursorRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cursorRadioButton.AutoSize = true;
            this.cursorRadioButton.Checked = true;
            this.cursorRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cursorRadioButton.ImageKey = "curs.png";
            this.cursorRadioButton.ImageList = this.imageList1;
            this.cursorRadioButton.Location = new System.Drawing.Point(3, 3);
            this.cursorRadioButton.Name = "cursorRadioButton";
            this.cursorRadioButton.Size = new System.Drawing.Size(70, 70);
            this.cursorRadioButton.TabIndex = 0;
            this.cursorRadioButton.TabStop = true;
            this.cursorRadioButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arr.png");
            this.imageList1.Images.SetKeyName(1, "be.png");
            this.imageList1.Images.SetKeyName(2, "comm.png");
            this.imageList1.Images.SetKeyName(3, "curs.png");
            this.imageList1.Images.SetKeyName(4, "lin.png");
            this.imageList1.Images.SetKeyName(5, "log.png");
            this.imageList1.Images.SetKeyName(6, "op.png");
            this.imageList1.Images.SetKeyName(7, "resize.png");
            // 
            // resizeRadioButton
            // 
            this.resizeRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.resizeRadioButton.AutoSize = true;
            this.resizeRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizeRadioButton.ImageIndex = 7;
            this.resizeRadioButton.ImageList = this.imageList1;
            this.resizeRadioButton.Location = new System.Drawing.Point(79, 3);
            this.resizeRadioButton.Name = "resizeRadioButton";
            this.resizeRadioButton.Size = new System.Drawing.Size(70, 70);
            this.resizeRadioButton.TabIndex = 1;
            this.resizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // operationalRadioButton
            // 
            this.operationalRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.operationalRadioButton.AutoSize = true;
            this.operationalRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.operationalRadioButton.ImageIndex = 6;
            this.operationalRadioButton.ImageList = this.imageList1;
            this.operationalRadioButton.Location = new System.Drawing.Point(155, 3);
            this.operationalRadioButton.Name = "operationalRadioButton";
            this.operationalRadioButton.Size = new System.Drawing.Size(70, 70);
            this.operationalRadioButton.TabIndex = 2;
            this.operationalRadioButton.UseVisualStyleBackColor = true;
            // 
            // logicalRadioButton
            // 
            this.logicalRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.logicalRadioButton.AutoSize = true;
            this.logicalRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logicalRadioButton.ImageIndex = 5;
            this.logicalRadioButton.ImageList = this.imageList1;
            this.logicalRadioButton.Location = new System.Drawing.Point(231, 3);
            this.logicalRadioButton.Name = "logicalRadioButton";
            this.logicalRadioButton.Size = new System.Drawing.Size(70, 70);
            this.logicalRadioButton.TabIndex = 3;
            this.logicalRadioButton.UseVisualStyleBackColor = true;
            // 
            // beginEndRadionButton
            // 
            this.beginEndRadionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.beginEndRadionButton.AutoSize = true;
            this.beginEndRadionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginEndRadionButton.ImageIndex = 1;
            this.beginEndRadionButton.ImageList = this.imageList1;
            this.beginEndRadionButton.Location = new System.Drawing.Point(307, 3);
            this.beginEndRadionButton.Name = "beginEndRadionButton";
            this.beginEndRadionButton.Size = new System.Drawing.Size(70, 70);
            this.beginEndRadionButton.TabIndex = 4;
            this.beginEndRadionButton.UseVisualStyleBackColor = true;
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineRadioButton.AutoSize = true;
            this.lineRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineRadioButton.ImageIndex = 4;
            this.lineRadioButton.ImageList = this.imageList1;
            this.lineRadioButton.Location = new System.Drawing.Point(3, 79);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(70, 70);
            this.lineRadioButton.TabIndex = 5;
            this.lineRadioButton.UseVisualStyleBackColor = true;
            // 
            // arrowRadionButton
            // 
            this.arrowRadionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.arrowRadionButton.AutoSize = true;
            this.arrowRadionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowRadionButton.ImageIndex = 0;
            this.arrowRadionButton.ImageList = this.imageList1;
            this.arrowRadionButton.Location = new System.Drawing.Point(79, 79);
            this.arrowRadionButton.Name = "arrowRadionButton";
            this.arrowRadionButton.Size = new System.Drawing.Size(70, 70);
            this.arrowRadionButton.TabIndex = 6;
            this.arrowRadionButton.UseVisualStyleBackColor = true;
            // 
            // commentRadioButton
            // 
            this.commentRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.commentRadioButton.AutoSize = true;
            this.commentRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentRadioButton.ImageIndex = 2;
            this.commentRadioButton.ImageList = this.imageList1;
            this.commentRadioButton.Location = new System.Drawing.Point(155, 79);
            this.commentRadioButton.Name = "commentRadioButton";
            this.commentRadioButton.Size = new System.Drawing.Size(70, 70);
            this.commentRadioButton.TabIndex = 7;
            this.commentRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 126);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.fillColorPanel);
            this.flowLayoutPanel2.Controls.Add(this.contourColorPanel);
            this.flowLayoutPanel2.Controls.Add(this.dashStyleComboBox);
            this.flowLayoutPanel2.Controls.Add(this.thickUpDownButton);
            this.flowLayoutPanel2.Controls.Add(this.centerButton);
            this.flowLayoutPanel2.Controls.Add(this.zoomTrackBar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(435, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(422, 116);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // fillColorPanel
            // 
            this.fillColorPanel.BackColor = System.Drawing.Color.White;
            this.fillColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fillColorPanel.Location = new System.Drawing.Point(3, 3);
            this.fillColorPanel.Name = "fillColorPanel";
            this.fillColorPanel.Size = new System.Drawing.Size(81, 63);
            this.fillColorPanel.TabIndex = 4;
            this.fillColorPanel.Click += new System.EventHandler(this.fillColorPanel_Click);
            // 
            // contourColorPanel
            // 
            this.contourColorPanel.BackColor = System.Drawing.Color.Black;
            this.contourColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contourColorPanel.Location = new System.Drawing.Point(90, 3);
            this.contourColorPanel.Name = "contourColorPanel";
            this.contourColorPanel.Size = new System.Drawing.Size(81, 63);
            this.contourColorPanel.TabIndex = 3;
            this.contourColorPanel.Click += new System.EventHandler(this.fillColorPanel_Click);
            // 
            // dashStyleComboBox
            // 
            this.dashStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dashStyleComboBox.FormattingEnabled = true;
            this.dashStyleComboBox.Items.AddRange(new object[] {
            "Сплошной",
            "Пунктирный",
            "Пунктир-точка",
            "Пунктир-точка-точка",
            "Точечный"});
            this.dashStyleComboBox.Location = new System.Drawing.Point(177, 3);
            this.dashStyleComboBox.Name = "dashStyleComboBox";
            this.dashStyleComboBox.Size = new System.Drawing.Size(131, 24);
            this.dashStyleComboBox.TabIndex = 8;
            // 
            // thickUpDownButton
            // 
            this.thickUpDownButton.Location = new System.Drawing.Point(314, 3);
            this.thickUpDownButton.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.thickUpDownButton.Name = "thickUpDownButton";
            this.thickUpDownButton.Size = new System.Drawing.Size(79, 22);
            this.thickUpDownButton.TabIndex = 9;
            this.thickUpDownButton.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // centerButton
            // 
            this.centerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centerButton.Location = new System.Drawing.Point(3, 72);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(79, 63);
            this.centerButton.TabIndex = 5;
            this.centerButton.Text = "Центрировать";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(88, 72);
            this.zoomTrackBar.Maximum = 1000;
            this.zoomTrackBar.Minimum = 50;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(217, 56);
            this.zoomTrackBar.SmallChange = 0;
            this.zoomTrackBar.TabIndex = 10;
            this.zoomTrackBar.Value = 100;
            this.zoomTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 306);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.zoomAndDragControl1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(862, 306);
            this.splitContainer1.SplitterDistance = 745;
            this.splitContainer1.TabIndex = 4;
            // 
            // zoomAndDragControl1
            // 
            this.zoomAndDragControl1.BackColor = System.Drawing.Color.White;
            this.zoomAndDragControl1.BigGridColor = System.Drawing.Color.Black;
            this.zoomAndDragControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomAndDragControl1.DragMouseButtons = System.Windows.Forms.MouseButtons.Middle;
            this.zoomAndDragControl1.Location = new System.Drawing.Point(0, 0);
            this.zoomAndDragControl1.MinZoom = 0.5F;
            this.zoomAndDragControl1.Name = "zoomAndDragControl1";
            this.zoomAndDragControl1.Size = new System.Drawing.Size(745, 306);
            this.zoomAndDragControl1.SmallGridColor = System.Drawing.Color.DimGray;
            this.zoomAndDragControl1.TabIndex = 0;
            this.zoomAndDragControl1.Text = "zoomAndDragControl1";
            this.zoomAndDragControl1.MouseUp += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseUp);
            this.zoomAndDragControl1.MouseDown += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseDown);
            this.zoomAndDragControl1.MouseMove += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseMove);
            this.zoomAndDragControl1.ZoomChanged += new System.EventHandler(this.zoomAndDragControl1_ZoomChanged);
            this.zoomAndDragControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.zoomAndDragControl1_Paint);
            this.zoomAndDragControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zoomAndDragControl_KeyPress);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(113, 306);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged_1);
            // 
            // blockContexMenu
            // 
            this.blockContexMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.blockContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.наПереднийПланToolStripMenuItem,
            this.наЗаднийПланToolStripMenuItem});
            this.blockContexMenu.Name = "blockContexMenu";
            this.blockContexMenu.Size = new System.Drawing.Size(209, 76);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // наПереднийПланToolStripMenuItem
            // 
            this.наПереднийПланToolStripMenuItem.Name = "наПереднийПланToolStripMenuItem";
            this.наПереднийПланToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.наПереднийПланToolStripMenuItem.Text = "На передний план";
            this.наПереднийПланToolStripMenuItem.Click += new System.EventHandler(this.toForegroundButton_Click);
            // 
            // наЗаднийПланToolStripMenuItem
            // 
            this.наЗаднийПланToolStripMenuItem.Name = "наЗаднийПланToolStripMenuItem";
            this.наЗаднийПланToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.наЗаднийПланToolStripMenuItem.Text = "На задний план";
            this.наЗаднийПланToolStripMenuItem.Click += new System.EventHandler(this.toBackgroundButton_Click);
            // 
            // lineContexMenu
            // 
            this.lineContexMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lineContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1,
            this.добавитьТочкуToolStripMenuItem,
            this.удалитьТочкуToolStripMenuItem,
            this.наПереднийПланToolStripMenuItem1,
            this.наЗаднийПланToolStripMenuItem1});
            this.lineContexMenu.Name = "contextMenuStrip1";
            this.lineContexMenu.Size = new System.Drawing.Size(209, 124);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // добавитьТочкуToolStripMenuItem
            // 
            this.добавитьТочкуToolStripMenuItem.Name = "добавитьТочкуToolStripMenuItem";
            this.добавитьТочкуToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.добавитьТочкуToolStripMenuItem.Text = "Добавить точку";
            this.добавитьТочкуToolStripMenuItem.Click += new System.EventHandler(this.addPointButton_Click);
            // 
            // удалитьТочкуToolStripMenuItem
            // 
            this.удалитьТочкуToolStripMenuItem.Name = "удалитьТочкуToolStripMenuItem";
            this.удалитьТочкуToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.удалитьТочкуToolStripMenuItem.Text = "Удалить точку";
            this.удалитьТочкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТочкуToolStripMenuItem_Click);
            // 
            // наПереднийПланToolStripMenuItem1
            // 
            this.наПереднийПланToolStripMenuItem1.Name = "наПереднийПланToolStripMenuItem1";
            this.наПереднийПланToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.наПереднийПланToolStripMenuItem1.Text = "На передний план";
            this.наПереднийПланToolStripMenuItem1.Click += new System.EventHandler(this.toForegroundButton_Click);
            // 
            // наЗаднийПланToolStripMenuItem1
            // 
            this.наЗаднийПланToolStripMenuItem1.Name = "наЗаднийПланToolStripMenuItem1";
            this.наЗаднийПланToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.наЗаднийПланToolStripMenuItem1.Text = "На задний план";
            this.наЗаднийПланToolStripMenuItem1.Click += new System.EventHandler(this.toBackgroundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Редактор граф-схем алгоритмов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickUpDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.blockContexMenu.ResumeLayout(false);
            this.lineContexMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton cursorRadioButton;
        private System.Windows.Forms.RadioButton resizeRadioButton;
        private System.Windows.Forms.RadioButton operationalRadioButton;
        private System.Windows.Forms.RadioButton logicalRadioButton;
        private System.Windows.Forms.RadioButton beginEndRadionButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private System.Windows.Forms.RadioButton arrowRadionButton;
        private System.Windows.Forms.RadioButton commentRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel fillColorPanel;
        private System.Windows.Forms.Panel contourColorPanel;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private ZoomAndDragContolLib.ZoomAndDragControl zoomAndDragControl1;
        private System.Windows.Forms.ComboBox dashStyleComboBox;
        private System.Windows.Forms.NumericUpDown thickUpDownButton;
        private System.Windows.Forms.ContextMenuStrip blockContexMenu;
        private System.Windows.Forms.ContextMenuStrip lineContexMenu;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТочкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТочкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel zoomStripLabel;
        private System.Windows.Forms.ToolStripMenuItem наПереднийПланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЗаднийПланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наПереднийПланToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem наЗаднийПланToolStripMenuItem1;
    }
}

