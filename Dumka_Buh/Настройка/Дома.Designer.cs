namespace Dumka_Buh.Настройка
{
    partial class Дома
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Дома));
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonNumericBox_д_год_дома = new C1.Win.C1Ribbon.RibbonNumericBox();
            this.ribbonNumericBox_д_мес_дома = new C1.Win.C1Ribbon.RibbonNumericBox();
            this.ribbonButton_Установить_период = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton_итог = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton_Сохранить = new C1.Win.C1Ribbon.RibbonButton();
            this.домBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dumkaDataSet = new Dumka_Buh.DumkaDataSet();
            this.домTableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.домTableAdapter();
            this.c1DockingTab_дома = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage_Настройка = new C1.Win.C1Command.C1DockingTabPage();
            this.c1TrueDBGrid_Настройка = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1DockingTabPage_Капитальный_ремонт = new C1.Win.C1Command.C1DockingTabPage();
            this.c1TrueDBGrid_Кап_рем_мес = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ = new C1.Win.C1Command.C1DockingTabPage();
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_дома)).BeginInit();
            this.c1DockingTab_дома.SuspendLayout();
            this.c1DockingTabPage_Настройка.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Настройка)).BeginInit();
            this.c1DockingTabPage_Капитальный_ремонт.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Кап_рем_мес)).BeginInit();
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_расчеты_из_КОМПЛАТ)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonNumericBox_д_год_дома);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonNumericBox_д_мес_дома);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonButton_Установить_период);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 560);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton_итог);
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton_Сохранить);
            this.c1StatusBar1.Size = new System.Drawing.Size(950, 22);
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
            // c1DockingTab_дома
            // 
            this.c1DockingTab_дома.Controls.Add(this.c1DockingTabPage_Настройка);
            this.c1DockingTab_дома.Controls.Add(this.c1DockingTabPage_Капитальный_ремонт);
            this.c1DockingTab_дома.Controls.Add(this.c1DockingTabPage_расчеты_из_КОМПЛАТ);
            this.c1DockingTab_дома.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab_дома.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab_дома.Name = "c1DockingTab_дома";
            this.c1DockingTab_дома.SelectedIndex = 3;
            this.c1DockingTab_дома.Size = new System.Drawing.Size(950, 560);
            this.c1DockingTab_дома.TabIndex = 3;
            this.c1DockingTab_дома.TabsSpacing = 5;
            this.c1DockingTab_дома.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.c1DockingTab_дома.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.c1DockingTab_дома.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // c1DockingTabPage_Настройка
            // 
            this.c1DockingTabPage_Настройка.Controls.Add(this.c1TrueDBGrid_Настройка);
            this.c1DockingTabPage_Настройка.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage_Настройка.Name = "c1DockingTabPage_Настройка";
            this.c1DockingTabPage_Настройка.Size = new System.Drawing.Size(948, 535);
            this.c1DockingTabPage_Настройка.TabIndex = 0;
            this.c1DockingTabPage_Настройка.Text = "Настройка, Тех. характеристики";
            // 
            // c1TrueDBGrid_Настройка
            // 
            this.c1TrueDBGrid_Настройка.AllowAddNew = true;
            this.c1TrueDBGrid_Настройка.Caption = "Заголовок таблицы";
            this.c1TrueDBGrid_Настройка.CaptionHeight = 25;
            this.c1TrueDBGrid_Настройка.ColumnFooters = true;
            this.c1TrueDBGrid_Настройка.DataSource = this.домBindingSource;
            this.c1TrueDBGrid_Настройка.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_Настройка.EmptyRows = true;
            this.c1TrueDBGrid_Настройка.FilterBar = true;
            this.c1TrueDBGrid_Настройка.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_Настройка.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_Настройка.Images"))));
            this.c1TrueDBGrid_Настройка.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Настройка.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid_Настройка.Name = "c1TrueDBGrid_Настройка";
            this.c1TrueDBGrid_Настройка.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Настройка.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_Настройка.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_Настройка.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_Настройка.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_Настройка.Size = new System.Drawing.Size(948, 535);
            this.c1TrueDBGrid_Настройка.TabIndex = 4;
            this.c1TrueDBGrid_Настройка.Text = "Настройка Дома";
            this.c1TrueDBGrid_Настройка.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid_Настройка.PropBag = resources.GetString("c1TrueDBGrid_Настройка.PropBag");
            // 
            // c1DockingTabPage_Капитальный_ремонт
            // 
            this.c1DockingTabPage_Капитальный_ремонт.Controls.Add(this.c1TrueDBGrid_Кап_рем_мес);
            this.c1DockingTabPage_Капитальный_ремонт.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage_Капитальный_ремонт.Name = "c1DockingTabPage_Капитальный_ремонт";
            this.c1DockingTabPage_Капитальный_ремонт.Size = new System.Drawing.Size(948, 535);
            this.c1DockingTabPage_Капитальный_ремонт.TabIndex = 1;
            this.c1DockingTabPage_Капитальный_ремонт.Text = "Капитальный ремонт";
            // 
            // c1TrueDBGrid_Кап_рем_мес
            // 
            this.c1TrueDBGrid_Кап_рем_мес.AllowAddNew = true;
            this.c1TrueDBGrid_Кап_рем_мес.Caption = "Заголовок таблицы";
            this.c1TrueDBGrid_Кап_рем_мес.CaptionHeight = 25;
            this.c1TrueDBGrid_Кап_рем_мес.ColumnFooters = true;
            this.c1TrueDBGrid_Кап_рем_мес.DataSource = this.домBindingSource;
            this.c1TrueDBGrid_Кап_рем_мес.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_Кап_рем_мес.EmptyRows = true;
            this.c1TrueDBGrid_Кап_рем_мес.FilterBar = true;
            this.c1TrueDBGrid_Кап_рем_мес.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_Кап_рем_мес.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_Кап_рем_мес.Images"))));
            this.c1TrueDBGrid_Кап_рем_мес.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Кап_рем_мес.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid_Кап_рем_мес.Name = "c1TrueDBGrid_Кап_рем_мес";
            this.c1TrueDBGrid_Кап_рем_мес.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Кап_рем_мес.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_Кап_рем_мес.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_Кап_рем_мес.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_Кап_рем_мес.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_Кап_рем_мес.Size = new System.Drawing.Size(948, 535);
            this.c1TrueDBGrid_Кап_рем_мес.TabIndex = 3;
            this.c1TrueDBGrid_Кап_рем_мес.Text = "Настройка Дома";
            this.c1TrueDBGrid_Кап_рем_мес.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
            this.c1TrueDBGrid_Кап_рем_мес.PropBag = resources.GetString("c1TrueDBGrid_Кап_рем_мес.PropBag");
            // 
            // c1DockingTabPage_расчеты_из_КОМПЛАТ
            // 
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.Controls.Add(this.c1TrueDBGrid_расчеты_из_КОМПЛАТ);
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.Name = "c1DockingTabPage_расчеты_из_КОМПЛАТ";
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.Size = new System.Drawing.Size(948, 535);
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.TabIndex = 2;
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.Text = "Расчеты из КОМПЛАТ";
            // 
            // c1TrueDBGrid_расчеты_из_КОМПЛАТ
            // 
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.AllowAddNew = true;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Caption = "Заголовок таблицы";
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.CaptionHeight = 25;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.ColumnFooters = true;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.DataSource = this.домBindingSource;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.EmptyRows = true;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.FilterBar = true;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_расчеты_из_КОМПЛАТ.Images"))));
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Name = "c1TrueDBGrid_расчеты_из_КОМПЛАТ";
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_расчеты_из_КОМПЛАТ.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Size = new System.Drawing.Size(948, 535);
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.TabIndex = 2;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.Text = "Настройка Дома";
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.c1TrueDBGrid_расчеты_из_КОМПЛАТ.PropBag = resources.GetString("c1TrueDBGrid_расчеты_из_КОМПЛАТ.PropBag");
            // 
            // Дома
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 582);
            this.Controls.Add(this.c1DockingTab_дома);
            this.Controls.Add(this.c1StatusBar1);
            this.Name = "Дома";
            this.Text = "Думка - Дома";
            this.Load += new System.EventHandler(this.Дома_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_дома)).EndInit();
            this.c1DockingTab_дома.ResumeLayout(false);
            this.c1DockingTabPage_Настройка.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Настройка)).EndInit();
            this.c1DockingTabPage_Капитальный_ремонт.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Кап_рем_мес)).EndInit();
            this.c1DockingTabPage_расчеты_из_КОМПЛАТ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_расчеты_из_КОМПЛАТ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private DumkaDataSet dumkaDataSet;
        private System.Windows.Forms.BindingSource домBindingSource;
        private DumkaDataSetTableAdapters.домTableAdapter домTableAdapter;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Сохранить;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_итог;
        private C1.Win.C1Ribbon.RibbonNumericBox ribbonNumericBox_д_год_дома;
        private C1.Win.C1Ribbon.RibbonNumericBox ribbonNumericBox_д_мес_дома;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Установить_период;
        private C1.Win.C1Command.C1DockingTab c1DockingTab_дома;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_Настройка;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_Капитальный_ремонт;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_расчеты_из_КОМПЛАТ;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_расчеты_из_КОМПЛАТ;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_Кап_рем_мес;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_Настройка;
    }
}