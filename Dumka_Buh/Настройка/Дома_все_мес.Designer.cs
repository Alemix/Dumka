namespace Dumka_Buh.Настройка
{
    partial class Дома_все_мес
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Дома_все_мес));
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonButton_Сохранить = new C1.Win.C1Ribbon.RibbonButton();
            this.домBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dumkaDataSet = new Dumka_Buh.DumkaDataSet();
            this.домTableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.домTableAdapter();
            this.c1DockingTab_дома = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage_Дома_все_месяцы = new C1.Win.C1Command.C1DockingTabPage();
            this.c1TrueDBGrid_Кап_рем_все_мес = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_дома)).BeginInit();
            this.c1DockingTab_дома.SuspendLayout();
            this.c1DockingTabPage_Дома_все_месяцы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Кап_рем_все_мес)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 559);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton_Сохранить);
            this.c1StatusBar1.Size = new System.Drawing.Size(779, 23);
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
            this.c1DockingTab_дома.Controls.Add(this.c1DockingTabPage_Дома_все_месяцы);
            this.c1DockingTab_дома.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab_дома.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab_дома.Name = "c1DockingTab_дома";
            this.c1DockingTab_дома.SelectedIndex = 3;
            this.c1DockingTab_дома.Size = new System.Drawing.Size(779, 559);
            this.c1DockingTab_дома.TabIndex = 3;
            this.c1DockingTab_дома.TabsSpacing = 5;
            this.c1DockingTab_дома.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.c1DockingTab_дома.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.c1DockingTab_дома.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // c1DockingTabPage_Дома_все_месяцы
            // 
            this.c1DockingTabPage_Дома_все_месяцы.Controls.Add(this.c1TrueDBGrid_Кап_рем_все_мес);
            this.c1DockingTabPage_Дома_все_месяцы.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage_Дома_все_месяцы.Name = "c1DockingTabPage_Дома_все_месяцы";
            this.c1DockingTabPage_Дома_все_месяцы.Size = new System.Drawing.Size(777, 534);
            this.c1DockingTabPage_Дома_все_месяцы.TabIndex = 3;
            this.c1DockingTabPage_Дома_все_месяцы.Text = "Дома все месяцы";
            // 
            // c1TrueDBGrid_Кап_рем_все_мес
            // 
            this.c1TrueDBGrid_Кап_рем_все_мес.AllowAddNew = true;
            this.c1TrueDBGrid_Кап_рем_все_мес.CaptionHeight = 25;
            this.c1TrueDBGrid_Кап_рем_все_мес.ColumnFooters = true;
            this.c1TrueDBGrid_Кап_рем_все_мес.DataSource = this.домBindingSource;
            this.c1TrueDBGrid_Кап_рем_все_мес.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.c1TrueDBGrid_Кап_рем_все_мес.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_Кап_рем_все_мес.EmptyRows = true;
            this.c1TrueDBGrid_Кап_рем_все_мес.FilterBar = true;
            this.c1TrueDBGrid_Кап_рем_все_мес.GroupByAreaVisible = false;
            this.c1TrueDBGrid_Кап_рем_все_мес.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_Кап_рем_все_мес.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_Кап_рем_все_мес.Images"))));
            this.c1TrueDBGrid_Кап_рем_все_мес.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Кап_рем_все_мес.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid_Кап_рем_все_мес.Name = "c1TrueDBGrid_Кап_рем_все_мес";
            this.c1TrueDBGrid_Кап_рем_все_мес.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Кап_рем_все_мес.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_Кап_рем_все_мес.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_Кап_рем_все_мес.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_Кап_рем_все_мес.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_Кап_рем_все_мес.Size = new System.Drawing.Size(777, 534);
            this.c1TrueDBGrid_Кап_рем_все_мес.TabIndex = 4;
            this.c1TrueDBGrid_Кап_рем_все_мес.Text = "Настройка Дома";
            this.c1TrueDBGrid_Кап_рем_все_мес.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
            this.c1TrueDBGrid_Кап_рем_все_мес.PropBag = resources.GetString("c1TrueDBGrid_Кап_рем_все_мес.PropBag");
            // 
            // Дома_все_мес
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 582);
            this.Controls.Add(this.c1DockingTab_дома);
            this.Controls.Add(this.c1StatusBar1);
            this.Name = "Дома_все_мес";
            this.Text = "Дома все месяцы";
            this.Load += new System.EventHandler(this.Дома_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.домBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_дома)).EndInit();
            this.c1DockingTab_дома.ResumeLayout(false);
            this.c1DockingTabPage_Дома_все_месяцы.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Кап_рем_все_мес)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private DumkaDataSet dumkaDataSet;
        private System.Windows.Forms.BindingSource домBindingSource;
        private DumkaDataSetTableAdapters.домTableAdapter домTableAdapter;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Сохранить;
        private C1.Win.C1Command.C1DockingTab c1DockingTab_дома;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_Дома_все_месяцы;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_Кап_рем_все_мес;
    }
}