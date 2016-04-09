namespace Dumka_Buh.Настройка
{
    partial class изм_ан
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
            this.c1TrueDBGrid_изм_ан = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.изм_ан_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dumka_DataSet = new Dumka_Buh.DumkaDataSet();
            this.c1InputPanel_изм_ан = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblист_имя = new C1.Win.C1InputPanel.InputLabel();
            this.txtист_имя = new C1.Win.C1InputPanel.InputTextBox();
            this.numист_код = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblан_код = new C1.Win.C1InputPanel.InputLabel();
            this.txtан_код = new C1.Win.C1InputPanel.InputTextBox();
            this.lblан_имя_до = new C1.Win.C1InputPanel.InputLabel();
            this.txtан_имя_до = new C1.Win.C1InputPanel.InputTextBox();
            this.lblан_имя_по = new C1.Win.C1InputPanel.InputLabel();
            this.txtан_имя_по = new C1.Win.C1InputPanel.InputTextBox();
            this.lblан_имя = new C1.Win.C1InputPanel.InputLabel();
            this.txtан_имя = new C1.Win.C1InputPanel.InputTextBox();
            this.изм_анTableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.изм_анTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_ан)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_изм_ан)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изм_ан_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumka_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel_изм_ан)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar_изм_ан
            // 
            this.c1StatusBar_изм_ан.Location = new System.Drawing.Point(0, 609);
            this.c1StatusBar_изм_ан.Name = "c1StatusBar_изм_ан";
            this.c1StatusBar_изм_ан.RightPaneItems.Add(this.ribbonButton_Записать);
            this.c1StatusBar_изм_ан.Size = new System.Drawing.Size(909, 23);
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
            this.splitContainer1.Panel1.Controls.Add(this.c1TrueDBGrid_изм_ан);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1InputPanel_изм_ан);
            this.splitContainer1.Size = new System.Drawing.Size(909, 609);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 1;
            // 
            // c1TrueDBGrid_изм_ан
            // 
            this.c1TrueDBGrid_изм_ан.AllowDelete = true;
            this.c1TrueDBGrid_изм_ан.DataSource = this.изм_ан_BindingSource;
            this.c1TrueDBGrid_изм_ан.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_изм_ан.FilterBar = true;
            this.c1TrueDBGrid_изм_ан.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_изм_ан.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_изм_ан.Images"))));
            this.c1TrueDBGrid_изм_ан.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_изм_ан.Name = "c1TrueDBGrid_изм_ан";
            this.c1TrueDBGrid_изм_ан.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_изм_ан.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_изм_ан.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_изм_ан.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_изм_ан.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_изм_ан.Size = new System.Drawing.Size(909, 458);
            this.c1TrueDBGrid_изм_ан.TabIndex = 0;
            this.c1TrueDBGrid_изм_ан.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid_изм_ан.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid_изм_ан.PropBag = resources.GetString("c1TrueDBGrid_изм_ан.PropBag");
            // 
            // изм_ан_BindingSource
            // 
            this.изм_ан_BindingSource.DataMember = "изм_ан";
            this.изм_ан_BindingSource.DataSource = this.dumka_DataSet;
            // 
            // dumka_DataSet
            // 
            this.dumka_DataSet.DataSetName = "DumkaDataSet";
            this.dumka_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1InputPanel_изм_ан
            // 
            this.c1InputPanel_изм_ан.DataSource = this.изм_ан_BindingSource;
            this.c1InputPanel_изм_ан.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel_изм_ан.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1InputPanel_изм_ан.Items.Add(this.lblист_имя);
            this.c1InputPanel_изм_ан.Items.Add(this.txtист_имя);
            this.c1InputPanel_изм_ан.Items.Add(this.numист_код);
            this.c1InputPanel_изм_ан.Items.Add(this.lblан_код);
            this.c1InputPanel_изм_ан.Items.Add(this.txtан_код);
            this.c1InputPanel_изм_ан.Items.Add(this.lblан_имя_до);
            this.c1InputPanel_изм_ан.Items.Add(this.txtан_имя_до);
            this.c1InputPanel_изм_ан.Items.Add(this.lblан_имя_по);
            this.c1InputPanel_изм_ан.Items.Add(this.txtан_имя_по);
            this.c1InputPanel_изм_ан.Items.Add(this.lblан_имя);
            this.c1InputPanel_изм_ан.Items.Add(this.txtан_имя);
            this.c1InputPanel_изм_ан.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel_изм_ан.Name = "c1InputPanel_изм_ан";
            this.c1InputPanel_изм_ан.Size = new System.Drawing.Size(909, 147);
            this.c1InputPanel_изм_ан.TabIndex = 0;
            this.c1InputPanel_изм_ан.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2007Blue;
            // 
            // lblист_имя
            // 
            this.lblист_имя.Name = "lblист_имя";
            this.lblист_имя.Text = "и&ст имя:";
            this.lblист_имя.Width = 60;
            // 
            // txtист_имя
            // 
            this.txtист_имя.Break = C1.Win.C1InputPanel.BreakType.None;
            this.txtист_имя.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ист_имя", true));
            this.txtист_имя.Name = "txtист_имя";
            this.txtист_имя.ReadOnly = true;
            this.txtист_имя.TabStop = false;
            this.txtист_имя.Width = 127;
            // 
            // numист_код
            // 
            this.numист_код.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ист_код", true));
            this.numист_код.Format = "0";
            this.numист_код.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numист_код.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numист_код.Name = "numист_код";
            this.numист_код.ReadOnly = true;
            this.numист_код.TabStop = false;
            this.numист_код.Width = 37;
            // 
            // lblан_код
            // 
            this.lblан_код.Name = "lblан_код";
            this.lblан_код.Text = "&ан код:";
            this.lblан_код.Width = 60;
            // 
            // txtан_код
            // 
            this.txtан_код.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ан_код", true));
            this.txtан_код.Name = "txtан_код";
            this.txtан_код.ReadOnly = true;
            this.txtан_код.TabStop = false;
            this.txtан_код.Width = 79;
            // 
            // lblан_имя_до
            // 
            this.lblан_имя_до.Name = "lblан_имя_до";
            this.lblан_имя_до.Text = "ан имя &до:";
            this.lblан_имя_до.Width = 60;
            // 
            // txtан_имя_до
            // 
            this.txtан_имя_до.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ан_имя_до", true));
            this.txtан_имя_до.Name = "txtан_имя_до";
            this.txtан_имя_до.ReadOnly = true;
            this.txtан_имя_до.TabStop = false;
            this.txtан_имя_до.Width = 400;
            // 
            // lblан_имя_по
            // 
            this.lblан_имя_по.Name = "lblан_имя_по";
            this.lblан_имя_по.Text = "ан имя &по:";
            this.lblан_имя_по.Width = 60;
            // 
            // txtан_имя_по
            // 
            this.txtан_имя_по.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ан_имя_по", true));
            this.txtан_имя_по.Name = "txtан_имя_по";
            this.txtан_имя_по.Width = 400;
            // 
            // lblан_имя
            // 
            this.lblан_имя.Name = "lblан_имя";
            this.lblан_имя.Text = "а&н имя:";
            this.lblан_имя.Width = 60;
            // 
            // txtан_имя
            // 
            this.txtан_имя.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_ан_BindingSource, "ан_имя", true));
            this.txtан_имя.Name = "txtан_имя";
            this.txtан_имя.ReadOnly = true;
            this.txtан_имя.TabStop = false;
            this.txtан_имя.Width = 400;
            // 
            // изм_анTableAdapter
            // 
            this.изм_анTableAdapter.ClearBeforeFill = true;
            // 
            // изм_ан
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1StatusBar_изм_ан);
            this.Name = "изм_ан";
            this.Text = "изм_ан";
            this.Load += new System.EventHandler(this.изм_ан_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_ан)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_изм_ан)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изм_ан_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumka_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel_изм_ан)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar_изм_ан;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_изм_ан;
        private DumkaDataSet dumka_DataSet;
        private System.Windows.Forms.BindingSource изм_ан_BindingSource;
        private DumkaDataSetTableAdapters.изм_анTableAdapter изм_анTableAdapter;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel_изм_ан;
        private C1.Win.C1InputPanel.InputNumericBox numист_код;
        private C1.Win.C1InputPanel.InputLabel lblан_код;
        private C1.Win.C1InputPanel.InputTextBox txtан_код;
        private C1.Win.C1InputPanel.InputLabel lblан_имя_до;
        private C1.Win.C1InputPanel.InputTextBox txtан_имя_до;
        private C1.Win.C1InputPanel.InputLabel lblан_имя_по;
        private C1.Win.C1InputPanel.InputTextBox txtан_имя_по;
        private C1.Win.C1InputPanel.InputLabel lblан_имя;
        private C1.Win.C1InputPanel.InputTextBox txtан_имя;
        private C1.Win.C1InputPanel.InputLabel lblист_имя;
        private C1.Win.C1InputPanel.InputTextBox txtист_имя;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Записать;
    }
}