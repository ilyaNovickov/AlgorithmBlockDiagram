using System.Windows.Forms;

namespace GraphAlgorithmFormApp
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zoomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.positionStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.sizeStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fillColorControl = new GraphAlgorithmFormApp.ColorChooseControl();
            this.contourColorControl = new GraphAlgorithmFormApp.ColorChooseControl();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thickUpDownButton = new System.Windows.Forms.DomainUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.centerButton = new System.Windows.Forms.Button();
            this.resetDrawSettingsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cursorRadioButton = new System.Windows.Forms.RadioButton();
            this.resizeRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.operationalRadioButton = new System.Windows.Forms.RadioButton();
            this.logicalRadioButton = new System.Windows.Forms.RadioButton();
            this.beginEndRadionButton = new System.Windows.Forms.RadioButton();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.arrowRadionButton = new System.Windows.Forms.RadioButton();
            this.commentRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zoomAndDragControl1 = new ZoomAndDragContolLib.ZoomAndDragControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.blockContexMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioGroup1 = new GraphAlgorithmFormApp.RadioGroup();
            this.lineContexMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPointButton = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТочкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.blockContexMenuStrip.SuspendLayout();
            this.lineContexMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomStatusLabel,
            this.positionStatusLable,
            this.sizeStatusLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(981, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zoomStatusLabel
            // 
            this.zoomStatusLabel.Name = "zoomStatusLabel";
            this.zoomStatusLabel.Size = new System.Drawing.Size(111, 20);
            this.zoomStatusLabel.Text = "Маштаь : 100%";
            // 
            // positionStatusLable
            // 
            this.positionStatusLable.Name = "positionStatusLable";
            this.positionStatusLable.Size = new System.Drawing.Size(122, 20);
            this.positionStatusLable.Text = "Положение : 0 0";
            // 
            // sizeStatusLable
            // 
            this.sizeStatusLable.Name = "sizeStatusLable";
            this.sizeStatusLable.Size = new System.Drawing.Size(102, 20);
            this.sizeStatusLable.Text = "Размеры : 0 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(981, 30);
            this.menuStrip1.TabIndex = 1;
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
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(291, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(263, 26);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(260, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(260, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator6,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator7,
            this.справкаToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 31);
            this.toolStrip1.TabIndex = 3;
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // вырезатьToolStripButton
            // 
            this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
            this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            this.вырезатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.вырезатьToolStripButton.Text = "В&ырезать";
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.копироватьToolStripButton.Text = "&Копировать";
            // 
            // вставкаToolStripButton
            // 
            this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
            this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton.Name = "вставкаToolStripButton";
            this.вставкаToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.вставкаToolStripButton.Text = "Вст&авка";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.справкаToolStripButton.Text = "Спр&авка";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 108);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel3.Controls.Add(this.fillColorControl);
            this.flowLayoutPanel3.Controls.Add(this.contourColorControl);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Controls.Add(this.deleteButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(494, 3);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(483, 102);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // fillColorControl
            // 
            this.fillColorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillColorControl.Color = System.Drawing.Color.White;
            this.fillColorControl.LabelText = "Цвет заливки";
            this.fillColorControl.Location = new System.Drawing.Point(4, 4);
            this.fillColorControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillColorControl.Name = "fillColorControl";
            this.fillColorControl.Size = new System.Drawing.Size(115, 95);
            this.fillColorControl.TabIndex = 0;
            // 
            // contourColorControl
            // 
            this.contourColorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourColorControl.Color = System.Drawing.Color.Black;
            this.contourColorControl.LabelText = "Цвет контура";
            this.contourColorControl.Location = new System.Drawing.Point(127, 4);
            this.contourColorControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contourColorControl.Name = "contourColorControl";
            this.contourColorControl.Size = new System.Drawing.Size(114, 95);
            this.contourColorControl.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.dashStyleComboBox);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Controls.Add(this.thickUpDownButton);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(248, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(133, 116);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип линии";
            // 
            // dashStyleComboBox
            // 
            this.dashStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dashStyleComboBox.FormattingEnabled = true;
            this.dashStyleComboBox.Items.AddRange(new object[] {
            "Сплошной",
            "Штрих",
            "Штрих-точка",
            "Штрих-точка-точка",
            "Точка"});
            this.dashStyleComboBox.Location = new System.Drawing.Point(3, 19);
            this.dashStyleComboBox.Name = "dashStyleComboBox";
            this.dashStyleComboBox.Size = new System.Drawing.Size(125, 24);
            this.dashStyleComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Толщина";
            // 
            // thickUpDownButton
            // 
            this.thickUpDownButton.Items.Add("16");
            this.thickUpDownButton.Items.Add("15");
            this.thickUpDownButton.Items.Add("14");
            this.thickUpDownButton.Items.Add("13");
            this.thickUpDownButton.Items.Add("12");
            this.thickUpDownButton.Items.Add("11");
            this.thickUpDownButton.Items.Add("10");
            this.thickUpDownButton.Items.Add("9");
            this.thickUpDownButton.Items.Add("8");
            this.thickUpDownButton.Items.Add("7");
            this.thickUpDownButton.Items.Add("6");
            this.thickUpDownButton.Items.Add("5");
            this.thickUpDownButton.Items.Add("4");
            this.thickUpDownButton.Items.Add("3");
            this.thickUpDownButton.Items.Add("2");
            this.thickUpDownButton.Items.Add("1");
            this.thickUpDownButton.Location = new System.Drawing.Point(3, 65);
            this.thickUpDownButton.Name = "thickUpDownButton";
            this.thickUpDownButton.ReadOnly = true;
            this.thickUpDownButton.Size = new System.Drawing.Size(125, 22);
            this.thickUpDownButton.TabIndex = 3;
            this.thickUpDownButton.Text = "2";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.centerButton);
            this.flowLayoutPanel6.Controls.Add(this.resetDrawSettingsButton);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 125);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(128, 95);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(3, 3);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(119, 41);
            this.centerButton.TabIndex = 3;
            this.centerButton.Text = "Центрировать";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // resetDrawSettingsButton
            // 
            this.resetDrawSettingsButton.Location = new System.Drawing.Point(3, 50);
            this.resetDrawSettingsButton.Name = "resetDrawSettingsButton";
            this.resetDrawSettingsButton.Size = new System.Drawing.Size(119, 41);
            this.resetDrawSettingsButton.TabIndex = 4;
            this.resetDrawSettingsButton.Text = "Сброс настроек\r\n";
            this.resetDrawSettingsButton.UseVisualStyleBackColor = true;
            this.resetDrawSettingsButton.Click += new System.EventHandler(this.resetDrawSettingsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(137, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 91);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить ";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel2.Controls.Add(this.cursorRadioButton);
            this.flowLayoutPanel2.Controls.Add(this.resizeRadioButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(238, 102);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // cursorRadioButton
            // 
            this.cursorRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cursorRadioButton.AutoCheck = false;
            this.cursorRadioButton.AutoSize = true;
            this.cursorRadioButton.Checked = true;
            this.cursorRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.cursorRadioButton, "1");
            this.cursorRadioButton.Location = new System.Drawing.Point(4, 4);
            this.cursorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cursorRadioButton.Name = "cursorRadioButton";
            this.cursorRadioButton.Size = new System.Drawing.Size(64, 26);
            this.cursorRadioButton.TabIndex = 0;
            this.cursorRadioButton.TabStop = true;
            this.cursorRadioButton.Text = "Курсор";
            this.cursorRadioButton.UseVisualStyleBackColor = true;
            this.cursorRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cursorRadioButton_KeyDown);
            // 
            // resizeRadioButton
            // 
            this.resizeRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.resizeRadioButton.AutoCheck = false;
            this.resizeRadioButton.AutoSize = true;
            this.resizeRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.resizeRadioButton, "1");
            this.resizeRadioButton.Location = new System.Drawing.Point(76, 4);
            this.resizeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.resizeRadioButton.Name = "resizeRadioButton";
            this.resizeRadioButton.Size = new System.Drawing.Size(117, 26);
            this.resizeRadioButton.TabIndex = 1;
            this.resizeRadioButton.TabStop = true;
            this.resizeRadioButton.Text = "Менять размер";
            this.resizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.operationalRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.logicalRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.beginEndRadionButton);
            this.flowLayoutPanel1.Controls.Add(this.lineRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.arrowRadionButton);
            this.flowLayoutPanel1.Controls.Add(this.commentRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(249, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 102);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // operationalRadioButton
            // 
            this.operationalRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.operationalRadioButton.AutoCheck = false;
            this.operationalRadioButton.AutoSize = true;
            this.operationalRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.operationalRadioButton, "1");
            this.operationalRadioButton.Location = new System.Drawing.Point(4, 4);
            this.operationalRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.operationalRadioButton.Name = "operationalRadioButton";
            this.operationalRadioButton.Size = new System.Drawing.Size(150, 26);
            this.operationalRadioButton.TabIndex = 1;
            this.operationalRadioButton.Text = "Операционный блок";
            this.operationalRadioButton.UseVisualStyleBackColor = true;
            // 
            // logicalRadioButton
            // 
            this.logicalRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.logicalRadioButton.AutoCheck = false;
            this.logicalRadioButton.AutoSize = true;
            this.logicalRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.logicalRadioButton, "1");
            this.logicalRadioButton.Location = new System.Drawing.Point(4, 38);
            this.logicalRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.logicalRadioButton.Name = "logicalRadioButton";
            this.logicalRadioButton.Size = new System.Drawing.Size(128, 26);
            this.logicalRadioButton.TabIndex = 2;
            this.logicalRadioButton.Text = "Логический блок";
            this.logicalRadioButton.UseVisualStyleBackColor = true;
            // 
            // beginEndRadionButton
            // 
            this.beginEndRadionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.beginEndRadionButton.AutoCheck = false;
            this.beginEndRadionButton.AutoSize = true;
            this.beginEndRadionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.beginEndRadionButton, "1");
            this.beginEndRadionButton.Location = new System.Drawing.Point(4, 72);
            this.beginEndRadionButton.Margin = new System.Windows.Forms.Padding(4);
            this.beginEndRadionButton.Name = "beginEndRadionButton";
            this.beginEndRadionButton.Size = new System.Drawing.Size(143, 26);
            this.beginEndRadionButton.TabIndex = 3;
            this.beginEndRadionButton.Text = "Блок начала-конца";
            this.beginEndRadionButton.UseVisualStyleBackColor = true;
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineRadioButton.AutoCheck = false;
            this.lineRadioButton.AutoSize = true;
            this.lineRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.lineRadioButton, "1");
            this.lineRadioButton.Location = new System.Drawing.Point(155, 72);
            this.lineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(57, 26);
            this.lineRadioButton.TabIndex = 4;
            this.lineRadioButton.Text = "Линия";
            this.lineRadioButton.UseVisualStyleBackColor = true;
            // 
            // arrowRadionButton
            // 
            this.arrowRadionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.arrowRadionButton.AutoCheck = false;
            this.arrowRadionButton.AutoSize = true;
            this.arrowRadionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.arrowRadionButton, "1");
            this.arrowRadionButton.Location = new System.Drawing.Point(4, 106);
            this.arrowRadionButton.Margin = new System.Windows.Forms.Padding(4);
            this.arrowRadionButton.Name = "arrowRadionButton";
            this.arrowRadionButton.Size = new System.Drawing.Size(72, 26);
            this.arrowRadionButton.TabIndex = 5;
            this.arrowRadionButton.Text = "Стрелка";
            this.arrowRadionButton.UseVisualStyleBackColor = true;
            // 
            // commentRadioButton
            // 
            this.commentRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.commentRadioButton.AutoCheck = false;
            this.commentRadioButton.AutoSize = true;
            this.commentRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGroup1.SetGroupName(this.commentRadioButton, "1");
            this.commentRadioButton.Location = new System.Drawing.Point(84, 106);
            this.commentRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.commentRadioButton.Name = "commentRadioButton";
            this.commentRadioButton.Size = new System.Drawing.Size(106, 26);
            this.commentRadioButton.TabIndex = 6;
            this.commentRadioButton.Text = "Комментарий";
            this.commentRadioButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 169);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zoomAndDragControl1);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(981, 558);
            this.splitContainer1.SplitterDistance = 807;
            this.splitContainer1.TabIndex = 4;
            // 
            // zoomAndDragControl1
            // 
            this.zoomAndDragControl1.BackColor = System.Drawing.Color.White;
            this.zoomAndDragControl1.BigGridColor = System.Drawing.Color.Black;
            this.zoomAndDragControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomAndDragControl1.DragMouseButtons = System.Windows.Forms.MouseButtons.Middle;
            this.zoomAndDragControl1.Location = new System.Drawing.Point(0, 0);
            this.zoomAndDragControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomAndDragControl1.MinZoom = 0.5F;
            this.zoomAndDragControl1.Name = "zoomAndDragControl1";
            this.zoomAndDragControl1.Size = new System.Drawing.Size(807, 558);
            this.zoomAndDragControl1.SmallGridColor = System.Drawing.Color.Gray;
            this.zoomAndDragControl1.TabIndex = 0;
            this.zoomAndDragControl1.Text = "zoomAndDragControl1";
            this.zoomAndDragControl1.MouseUp += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseUp);
            this.zoomAndDragControl1.MouseDown += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseDown);
            this.zoomAndDragControl1.MouseMove += new System.EventHandler<ZoomAndDragContolLib.TransformedMouseEventArgs>(this.zoomAndDragControl1_MouseMove);
            this.zoomAndDragControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.zoomAndDragControl1_Paint);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer2.Size = new System.Drawing.Size(170, 558);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(170, 400);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(170, 153);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // blockContexMenuStrip
            // 
            this.blockContexMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.blockContexMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.blockContexMenuStrip.Name = "contextMenuStrip1";
            this.blockContexMenuStrip.Size = new System.Drawing.Size(135, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItem1.Text = "Удалить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lineContexMenuStrip
            // 
            this.lineContexMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lineContexMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPointButton,
            this.удалитьТочкуToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.lineContexMenuStrip.Name = "contextMenuStrip2";
            this.lineContexMenuStrip.Size = new System.Drawing.Size(187, 76);
            // 
            // addPointButton
            // 
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(186, 24);
            this.addPointButton.Text = "Добавить точку";
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);
            // 
            // удалитьТочкуToolStripMenuItem
            // 
            this.удалитьТочкуToolStripMenuItem.Name = "удалитьТочкуToolStripMenuItem";
            this.удалитьТочкуToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.удалитьТочкуToolStripMenuItem.Text = "Удалить точку";
            this.удалитьТочкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТочкуToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(981, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(599, 598);
            this.Name = "MainFrom";
            this.Text = "Редактор граф-схем алгоритма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.blockContexMenuStrip.ResumeLayout(false);
            this.lineContexMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменадействияToolStripMenuItem;
        private ToolStripMenuItem отменадействияToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private ToolStripMenuItem сервисToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержаниеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton вырезатьToolStripButton;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripButton вставкаToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton справкаToolStripButton;
        private SplitContainer splitContainer1;
        private ZoomAndDragContolLib.ZoomAndDragControl zoomAndDragControl1;
        private RadioButton cursorRadioButton;
        private RadioGroup radioGroup1;
        private SplitContainer splitContainer2;
        private PropertyGrid propertyGrid1;
        private RadioButton operationalRadioButton;
        private FlowLayoutPanel flowLayoutPanel4;
        private ColorChooseControl fillColorControl;
        private ColorChooseControl contourColorControl;
        private ToolStripStatusLabel zoomStatusLabel;
        private FlowLayoutPanel flowLayoutPanel5;
        private ComboBox dashStyleComboBox;
        private DomainUpDown thickUpDownButton;
        private Label label1;
        private Label label2;
        private Button centerButton;
        private RadioButton logicalRadioButton;
        private RadioButton beginEndRadionButton;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button resetDrawSettingsButton;
        private ToolStripStatusLabel positionStatusLable;
        private RadioButton lineRadioButton;
        private RadioButton arrowRadionButton;
        private RadioButton commentRadioButton;
        private ToolStripStatusLabel sizeStatusLable;
        private ContextMenuStrip blockContexMenuStrip;
        private Button deleteButton;
        private ContextMenuStrip lineContexMenuStrip;
        private RadioButton resizeRadioButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addPointButton;
        private ToolStripMenuItem удалитьТочкуToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

