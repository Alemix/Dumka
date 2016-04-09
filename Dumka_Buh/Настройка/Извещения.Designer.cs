namespace Dumka_Buh.Настройка
{
    partial class Извещения
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Извещения));
            this.c1StatusBar_изм_ан = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonButton_Записать = new C1.Win.C1Ribbon.RibbonButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1TrueDBGrid_Извещения = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dumkaDataSet = new Dumka_Buh.DumkaDataSet();
            this.с_изв_2014_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.с_изв_2014_TableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.с_изв_2014TableAdapter();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.hdrс_изв_2014 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.lblизв_код_2014 = new C1.Win.C1InputPanel.InputLabel();
            this.numизв_код_2014 = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblПор_ном = new C1.Win.C1InputPanel.InputLabel();
            this.txtПор_ном = new C1.Win.C1InputPanel.InputTextBox();
            this.lblизв_имя_2014 = new C1.Win.C1InputPanel.InputLabel();
            this.txtизв_имя_2014 = new C1.Win.C1InputPanel.InputTextBox();
            this.lblинфо = new C1.Win.C1InputPanel.InputLabel();
            this.txtинфо = new C1.Win.C1InputPanel.InputTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_ан)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Извещения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.с_изв_2014_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar_изм_ан
            // 
            this.c1StatusBar_изм_ан.Location = new System.Drawing.Point(0, 616);
            this.c1StatusBar_изм_ан.Name = "c1StatusBar_изм_ан";
            this.c1StatusBar_изм_ан.RightPaneItems.Add(this.ribbonButton_Записать);
            this.c1StatusBar_изм_ан.Size = new System.Drawing.Size(925, 22);
            // 
            // ribbonButton_Записать
            // 
            this.ribbonButton_Записать.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Записать.LargeImage")));
            this.ribbonButton_Записать.Name = "ribbonButton_Записать";
            this.ribbonButton_Записать.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_Записать.SmallImage")));
            this.ribbonButton_Записать.Text = "Записать";
            this.ribbonButton_Записать.ToolTip = "Записать";
            this.ribbonButton_Записать.Click += new System.EventHandler(this.ribbonButton_Записать_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1TrueDBGrid_Извещения);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1InputPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(925, 616);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 1;
            // 
            // c1TrueDBGrid_Извещения
            // 
            this.c1TrueDBGrid_Извещения.DataSource = this.с_изв_2014_BindingSource;
            this.c1TrueDBGrid_Извещения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_Извещения.FilterBar = true;
            this.c1TrueDBGrid_Извещения.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_Извещения.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_Извещения.Images"))));
            this.c1TrueDBGrid_Извещения.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Извещения.Name = "c1TrueDBGrid_Извещения";
            this.c1TrueDBGrid_Извещения.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_Извещения.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_Извещения.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_Извещения.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_изм_ан.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_Извещения.Size = new System.Drawing.Size(925, 462);
            this.c1TrueDBGrid_Извещения.TabIndex = 0;
            this.c1TrueDBGrid_Извещения.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid_Извещения.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
            this.c1TrueDBGrid_Извещения.PropBag = resources.GetString("c1TrueDBGrid_Извещения.PropBag");
            // 
            // dumkaDataSet
            // 
            this.dumkaDataSet.DataSetName = "DumkaDataSet";
            this.dumkaDataSet.EnforceConstraints = false;
            this.dumkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // с_изв_2014_BindingSource
            // 
            this.с_изв_2014_BindingSource.DataMember = "с_изв_2014";
            this.с_изв_2014_BindingSource.DataSource = this.dumkaDataSet;
            // 
            // с_изв_2014_TableAdapter
            // 
            this.с_изв_2014_TableAdapter.ClearBeforeFill = true;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.DataSource = this.с_изв_2014_BindingSource;
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.hdrс_изв_2014);
            this.c1InputPanel1.Items.Add(this.lblизв_код_2014);
            this.c1InputPanel1.Items.Add(this.numизв_код_2014);
            this.c1InputPanel1.Items.Add(this.lblПор_ном);
            this.c1InputPanel1.Items.Add(this.txtПор_ном);
            this.c1InputPanel1.Items.Add(this.lblизв_имя_2014);
            this.c1InputPanel1.Items.Add(this.txtизв_имя_2014);
            this.c1InputPanel1.Items.Add(this.lblинфо);
            this.c1InputPanel1.Items.Add(this.txtинфо);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(925, 150);
            this.c1InputPanel1.TabIndex = 0;
            this.c1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2007Silver;
            // 
            // hdrс_изв_2014
            // 
            this.hdrс_изв_2014.Name = "hdrс_изв_2014";
            this.hdrс_изв_2014.Text = "&с_изв_2014";
            // 
            // lblизв_код_2014
            // 
            this.lblизв_код_2014.Name = "lblизв_код_2014";
            this.lblизв_код_2014.Text = "&изв код 2014:";
            this.lblизв_код_2014.Width = 78;
            // 
            // numизв_код_2014
            // 
            this.numизв_код_2014.Break = C1.Win.C1InputPanel.BreakType.None;
            this.numизв_код_2014.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.с_изв_2014_BindingSource, "изв_код_2014", true));
            this.numизв_код_2014.Format = "0";
            this.numизв_код_2014.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numизв_код_2014.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numизв_код_2014.Name = "numизв_код_2014";
            this.numизв_код_2014.ReadOnly = true;
            this.numизв_код_2014.Width = 50;
            // 
            // lblПор_ном
            // 
            this.lblПор_ном.Name = "lblПор_ном";
            this.lblПор_ном.Text = "&Пор ном:";
            this.lblПор_ном.Width = 78;
            // 
            // txtПор_ном
            // 
            this.txtПор_ном.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.с_изв_2014_BindingSource, "Пор_ном", true));
            this.txtПор_ном.Name = "txtПор_ном";
            this.txtПор_ном.Width = 114;
            // 
            // lblизв_имя_2014
            // 
            this.lblизв_имя_2014.Name = "lblизв_имя_2014";
            this.lblизв_имя_2014.Text = "изв имя";
            this.lblизв_имя_2014.Width = 78;
            // 
            // txtизв_имя_2014
            // 
            this.txtизв_имя_2014.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.с_изв_2014_BindingSource, "изв_имя_2014", true));
            this.txtизв_имя_2014.Height = 46;
            this.txtизв_имя_2014.Multiline = true;
            this.txtизв_имя_2014.Name = "txtизв_имя_2014";
            this.txtизв_имя_2014.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread;
            this.txtизв_имя_2014.Width = 825;
            // 
            // lblинфо
            // 
            this.lblинфо.Name = "lblинфо";
            this.lblинфо.Text = "и&нформация:";
            this.lblинфо.Width = 78;
            // 
            // txtинфо
            // 
            this.txtинфо.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.с_изв_2014_BindingSource, "инфо", true));
            this.txtинфо.Height = 45;
            this.txtинфо.Multiline = true;
            this.txtинфо.Name = "txtинфо";
            this.txtинфо.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread;
            this.txtинфо.Width = 825;
            // 
            // Извещения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 638);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1StatusBar_изм_ан);
            this.Name = "Извещения";
            this.Text = "Думка - Извещения";
            this.Load += new System.EventHandler(this.изм_ан_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_ан)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_Извещения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.с_изв_2014_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar_изм_ан;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_Извещения;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Записать;
        private DumkaDataSet dumkaDataSet;
        private System.Windows.Forms.BindingSource с_изв_2014_BindingSource;
        private DumkaDataSetTableAdapters.с_изв_2014TableAdapter с_изв_2014_TableAdapter;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader hdrс_изв_2014;
        private C1.Win.C1InputPanel.InputLabel lblизв_код_2014;
        private C1.Win.C1InputPanel.InputNumericBox numизв_код_2014;
        private C1.Win.C1InputPanel.InputLabel lblПор_ном;
        private C1.Win.C1InputPanel.InputTextBox txtПор_ном;
        private C1.Win.C1InputPanel.InputLabel lblизв_имя_2014;
        private C1.Win.C1InputPanel.InputTextBox txtизв_имя_2014;
        private C1.Win.C1InputPanel.InputLabel lblинфо;
        private C1.Win.C1InputPanel.InputTextBox txtинфо;
    }
}