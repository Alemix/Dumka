namespace Dumka_Buh.Настройка
{
    partial class Дома_для_Экономистов
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Дома_для_Экономистов));
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonNumericBox_д_год_дома = new C1.Win.C1Ribbon.RibbonNumericBox();
            this.ribbonNumericBox_д_мес_дома = new C1.Win.C1Ribbon.RibbonNumericBox();
            this.ribbonButton_Установить_период = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton_итог = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton_Сохранить = new C1.Win.C1Ribbon.RibbonButton();
            this.c1TrueDBGrid_Дома_для_Экономистов = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.домBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dumkaDataSet = new Dumka_Buh.DumkaDataSet();
            this.домTableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.домTableAdapter();
            this.ribbonToggleButton1 = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Дома_для_Экономистов)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonNumericBox_д_год_дома);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonNumericBox_д_мес_дома);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonButton_Установить_период);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonToggleButton1);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 559);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton_итог);
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton_Сохранить);
            this.c1StatusBar1.Size = new System.Drawing.Size(950, 23);
            // 
            // ribbonNumericBox_д_год_дома
            // 
            this.ribbonNumericBox_д_год_дома.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonNumericBox_д_год_дома.Label = "Год";
            this.ribbonNumericBox_д_год_дома.LabelWidth = 30;
            this.ribbonNumericBox_д_год_дома.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.ribbonNumericBox_д_год_дома.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.ribbonNumericBox_д_год_дома.Name = "ribbonNumericBox_д_год_дома";
            this.ribbonNumericBox_д_год_дома.TextAreaWidth = 35;
            // 
            // ribbonNumericBox_д_мес_дома
            // 
            this.ribbonNumericBox_д_мес_дома.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonNumericBox_д_мес_дома.Label = "мес.";
            this.ribbonNumericBox_д_мес_дома.LabelWidth = 30;
            this.ribbonNumericBox_д_мес_дома.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ribbonNumericBox_д_мес_дома.Name = "ribbonNumericBox_д_мес_дома";
            this.ribbonNumericBox_д_мес_дома.TextAreaWidth = 25;
            // 
            // ribbonButton_Установить_период
            // 
            this.ribbonButton_Установить_период.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Установить_период.LargeImage")));
            this.ribbonButton_Установить_период.Name = "ribbonButton_Установить_период";
            this.ribbonButton_Установить_период.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Установить_период.SmallImage")));
            this.ribbonButton_Установить_период.Text = "Установить период";
            this.ribbonButton_Установить_период.Click += new System.EventHandler(this.ribbonButton_Установить_период_Click);
            // 
            // ribbonButton_итог
            // 
            this.ribbonButton_итог.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_итог.LargeImage")));
            this.ribbonButton_итог.Name = "ribbonButton_итог";
            this.ribbonButton_итог.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_итог.SmallImage")));
            this.ribbonButton_итог.Text = "Итог";
            this.ribbonButton_итог.ToolTip = "Пересчитать итоги (после фильтра).";
            this.ribbonButton_итог.Click += new System.EventHandler(this.ribbonButton_итог_Click);
            // 
            // ribbonButton_Сохранить
            // 
            this.ribbonButton_Сохранить.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Сохранить.LargeImage")));
            this.ribbonButton_Сохранить.Name = "ribbonButton_Сохранить";
            this.ribbonButton_Сохранить.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Сохранить.SmallImage")));
            this.ribbonButton_Сохранить.Text = "Сохранить";
            this.ribbonButton_Сохранить.Click += new System.EventHandler(this.ribbonButton_Сохранить_Click);
            // 
            // c1TrueDBGrid_Дома_для_Экономистов
            // 
            this.c1TrueDBGrid_Дома_для_Экономистов.Caption = "Заголовок таблицы";
            this.c1TrueDBGrid_Дома_для_Экономистов.CaptionHeight = 25;
            this.c1TrueDBGrid_Дома_для_Экономистов.ColumnFooters = true;
            this.c1TrueDBGrid_Дома_для_Экономистов.DataSource = this.домBindingSource;
            this.c1TrueDBGrid_Дома_для_Экономистов.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_Дома_для_Экономистов.EmptyRows = true;
            this.c1TrueDBGrid_Дома_для_Экономистов.FilterBar = true;
            this.c1TrueDBGrid_Дома_для_Экономистов.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_Дома_для_Экономистов.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_Дома_для_Экономистов.Images"))));
            this.c1TrueDBGrid_Дома_для_Экономистов.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Дома_для_Экономистов.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid_Дома_для_Экономистов.Name = "c1TrueDBGrid_Дома_для_Экономистов";
            this.c1TrueDBGrid_Дома_для_Экономистов.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Дома_для_Экономистов.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_Дома_для_Экономистов.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_Дома_для_Экономистов.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_Дома_для_Экономистов.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_Дома_для_Экономистов.Size = new System.Drawing.Size(666, 538);
            this.c1TrueDBGrid_Дома_для_Экономистов.TabIndex = 4;
            this.c1TrueDBGrid_Дома_для_Экономистов.Text = "Настройка Дома";
            this.c1TrueDBGrid_Дома_для_Экономистов.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid_Дома_для_Экономистов.PropBag = resources.GetString("c1TrueDBGrid_Дома_для_Экономистов.PropBag");
            // 
            // домBindingSource
            // 
            this.домBindingSource.DataMember = "дом";
            this.домBindingSource.DataSource = this.dumkaDataSet;
            // 
            // dumkaDataSet
            // 
            this.dumkaDataSet.DataSetName = "DumkaDataSet";
            this.dumkaDataSet.EnforceConstraints = false;
            this.dumkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // домTableAdapter
            // 
            this.домTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonToggleButton1
            // 
            this.ribbonToggleButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonToggleButton1.LargeImage")));
            this.ribbonToggleButton1.Name = "ribbonToggleButton1";
            this.ribbonToggleButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonToggleButton1.SmallImage")));
            this.ribbonToggleButton1.Text = "Только Дома для Экономистов";
            this.ribbonToggleButton1.ToggleGroupName = "111";
            this.ribbonToggleButton1.ToolTip = "Показывать  Дома отмеченные только для Экономистов";
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(950, 559);
            this.c1SplitContainer1.TabIndex = 5;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Collapsible = true;
            this.c1SplitterPanel1.Controls.Add(this.c1TrueDBGrid_Дома_для_Экономистов);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(666, 538);
            this.c1SplitterPanel1.SizeRatio = 71.142D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "Panel 1";
            this.c1SplitterPanel1.Width = 673;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Right;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(677, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(273, 538);
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Text = "Panel 2";
            this.c1SplitterPanel2.Width = 200;
            // 
            // Дома_для_Экономистов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 582);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.c1StatusBar1);
            this.Name = "Дома_для_Экономистов";
            this.Text = "Дома";
            this.Load += new System.EventHandler(this.Дома_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Дома_для_Экономистов)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Сохранить;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_итог;
        private C1.Win.C1Ribbon.RibbonNumericBox ribbonNumericBox_д_год_дома;
        private C1.Win.C1Ribbon.RibbonNumericBox ribbonNumericBox_д_мес_дома;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Установить_период;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_Дома_для_Экономистов;
        private System.Windows.Forms.BindingSource домBindingSource;
        private DumkaDataSet dumkaDataSet;
        private DumkaDataSetTableAdapters.домTableAdapter домTableAdapter;
        private C1.Win.C1Ribbon.RibbonToggleButton ribbonToggleButton1;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
    }
}