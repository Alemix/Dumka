namespace Dumka_Buh.Настройка
{
    partial class изм_сч
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(изм_сч));
            this.c1StatusBar_изм_сч = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonButton_Записать = new C1.Win.C1Ribbon.RibbonButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1TrueDBGrid_изм_сч = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.изм_сч_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dumka_DataSet = new Dumka_Buh.DumkaDataSet();
            this.c1InputPanel_изм_сч = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblист_имя = new C1.Win.C1InputPanel.InputLabel();
            this.txtист_имя = new C1.Win.C1InputPanel.InputTextBox();
            this.numист_код = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblсч_код = new C1.Win.C1InputPanel.InputLabel();
            this.txtсч_код = new C1.Win.C1InputPanel.InputTextBox();
            this.lblсч_имя_до = new C1.Win.C1InputPanel.InputLabel();
            this.txtсч_имя_до = new C1.Win.C1InputPanel.InputTextBox();
            this.lblсч_имя_по = new C1.Win.C1InputPanel.InputLabel();
            this.txtсч_имя_по = new C1.Win.C1InputPanel.InputTextBox();
            this.lblсч_имя = new C1.Win.C1InputPanel.InputLabel();
            this.txtсч_имя = new C1.Win.C1InputPanel.InputTextBox();
            this.изм_счTableAdapter = new Dumka_Buh.DumkaDataSetTableAdapters.изм_счTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_сч)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_изм_сч)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изм_сч_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumka_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel_изм_сч)).BeginInit();
            this.SuspendLayout();
            // 
            // c1StatusBar_изм_сч
            // 
            this.c1StatusBar_изм_сч.Location = new System.Drawing.Point(0, 610);
            this.c1StatusBar_изм_сч.Name = "c1StatusBar_изм_сч";
            this.c1StatusBar_изм_сч.RightPaneItems.Add(this.ribbonButton_Записать);
            this.c1StatusBar_изм_сч.Size = new System.Drawing.Size(909, 22);
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
            this.splitContainer1.Panel1.Controls.Add(this.c1TrueDBGrid_изм_сч);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1InputPanel_изм_сч);
            this.splitContainer1.Size = new System.Drawing.Size(909, 610);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 1;
            // 
            // c1TrueDBGrid_изм_сч
            // 
            this.c1TrueDBGrid_изм_сч.AllowDelete = true;
            this.c1TrueDBGrid_изм_сч.DataSource = this.изм_сч_BindingSource;
            this.c1TrueDBGrid_изм_сч.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid_изм_сч.FilterBar = true;
            this.c1TrueDBGrid_изм_сч.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid_изм_сч.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid_изм_сч.Images"))));
            this.c1TrueDBGrid_изм_сч.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_изм_сч.Name = "c1TrueDBGrid_изм_сч";
            this.c1TrueDBGrid_изм_сч.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid_изм_сч.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid_изм_сч.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid_изм_сч.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid_изм_сч.PrintInfo.PageSettings")));
            this.c1TrueDBGrid_изм_сч.Size = new System.Drawing.Size(909, 458);
            this.c1TrueDBGrid_изм_сч.TabIndex = 0;
            this.c1TrueDBGrid_изм_сч.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid_изм_сч.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid_изм_сч.PropBag = resources.GetString("c1TrueDBGrid_изм_сч.PropBag");
            // 
            // изм_сч_BindingSource
            // 
            this.изм_сч_BindingSource.DataMember = "изм_сч";
            this.изм_сч_BindingSource.DataSource = this.dumka_DataSet;
            // 
            // dumka_DataSet
            // 
            this.dumka_DataSet.DataSetName = "DumkaDataSet";
            this.dumka_DataSet.EnforceConstraints = false;
            this.dumka_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1InputPanel_изм_сч
            // 
            this.c1InputPanel_изм_сч.DataSource = this.изм_сч_BindingSource;
            this.c1InputPanel_изм_сч.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel_изм_сч.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1InputPanel_изм_сч.Items.Add(this.lblист_имя);
            this.c1InputPanel_изм_сч.Items.Add(this.txtист_имя);
            this.c1InputPanel_изм_сч.Items.Add(this.numист_код);
            this.c1InputPanel_изм_сч.Items.Add(this.lblсч_код);
            this.c1InputPanel_изм_сч.Items.Add(this.txtсч_код);
            this.c1InputPanel_изм_сч.Items.Add(this.lblсч_имя_до);
            this.c1InputPanel_изм_сч.Items.Add(this.txtсч_имя_до);
            this.c1InputPanel_изм_сч.Items.Add(this.lblсч_имя_по);
            this.c1InputPanel_изм_сч.Items.Add(this.txtсч_имя_по);
            this.c1InputPanel_изм_сч.Items.Add(this.lblсч_имя);
            this.c1InputPanel_изм_сч.Items.Add(this.txtсч_имя);
            this.c1InputPanel_изм_сч.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel_изм_сч.Name = "c1InputPanel_изм_сч";
            this.c1InputPanel_изм_сч.Size = new System.Drawing.Size(909, 148);
            this.c1InputPanel_изм_сч.TabIndex = 0;
            this.c1InputPanel_изм_сч.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2007Blue;
            // 
            // lblист_имя
            // 
            this.lblист_имя.Name = "lblист_имя";
            this.lblист_имя.Text = "ис&т имя:";
            this.lblист_имя.Width = 57;
            // 
            // txtист_имя
            // 
            this.txtист_имя.Break = C1.Win.C1InputPanel.BreakType.None;
            this.txtист_имя.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "ист_имя", true));
            this.txtист_имя.Name = "txtист_имя";
            this.txtист_имя.Width = 200;
            // 
            // numист_код
            // 
            this.numист_код.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "ист_код", true));
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
            this.numист_код.Width = 36;
            // 
            // lblсч_код
            // 
            this.lblсч_код.Name = "lblсч_код";
            this.lblсч_код.Text = "&сч код:";
            this.lblсч_код.Width = 57;
            // 
            // txtсч_код
            // 
            this.txtсч_код.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "сч_код", true));
            this.txtсч_код.Name = "txtсч_код";
            this.txtсч_код.Width = 48;
            // 
            // lblсч_имя_до
            // 
            this.lblсч_имя_до.Name = "lblсч_имя_до";
            this.lblсч_имя_до.Text = "сч имя &до:";
            this.lblсч_имя_до.Width = 60;
            // 
            // txtсч_имя_до
            // 
            this.txtсч_имя_до.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "сч_имя_до", true));
            this.txtсч_имя_до.Name = "txtсч_имя_до";
            this.txtсч_имя_до.Width = 300;
            // 
            // lblсч_имя_по
            // 
            this.lblсч_имя_по.Name = "lblсч_имя_по";
            this.lblсч_имя_по.Text = "сч имя &по:";
            this.lblсч_имя_по.Width = 60;
            // 
            // txtсч_имя_по
            // 
            this.txtсч_имя_по.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "сч_имя_по", true));
            this.txtсч_имя_по.Name = "txtсч_имя_по";
            this.txtсч_имя_по.Width = 300;
            // 
            // lblсч_имя
            // 
            this.lblсч_имя.Name = "lblсч_имя";
            this.lblсч_имя.Text = "с&ч имя:";
            this.lblсч_имя.Width = 60;
            // 
            // txtсч_имя
            // 
            this.txtсч_имя.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.изм_сч_BindingSource, "сч_имя", true));
            this.txtсч_имя.Name = "txtсч_имя";
            this.txtсч_имя.ReadOnly = true;
            this.txtсч_имя.Width = 300;
            // 
            // изм_счTableAdapter
            // 
            this.изм_счTableAdapter.ClearBeforeFill = true;
            // 
            // изм_сч
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.c1StatusBar_изм_сч);
            this.Name = "изм_сч";
            this.Text = "изм_ан";
            this.Load += new System.EventHandler(this.изм_ан_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar_изм_сч)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid_изм_сч)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изм_сч_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dumka_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel_изм_сч)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar_изм_сч;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid_изм_сч;
        private DumkaDataSet dumka_DataSet;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel_изм_сч;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton_Записать;
        private System.Windows.Forms.BindingSource изм_сч_BindingSource;
        private DumkaDataSetTableAdapters.изм_счTableAdapter изм_счTableAdapter;
        private C1.Win.C1InputPanel.InputNumericBox numист_код;
        private C1.Win.C1InputPanel.InputLabel lblсч_код;
        private C1.Win.C1InputPanel.InputTextBox txtсч_код;
        private C1.Win.C1InputPanel.InputLabel lblсч_имя_до;
        private C1.Win.C1InputPanel.InputTextBox txtсч_имя_до;
        private C1.Win.C1InputPanel.InputLabel lblсч_имя_по;
        private C1.Win.C1InputPanel.InputTextBox txtсч_имя_по;
        private C1.Win.C1InputPanel.InputLabel lblсч_имя;
        private C1.Win.C1InputPanel.InputTextBox txtсч_имя;
        private C1.Win.C1InputPanel.InputLabel lblист_имя;
        private C1.Win.C1InputPanel.InputTextBox txtист_имя;
    }
}