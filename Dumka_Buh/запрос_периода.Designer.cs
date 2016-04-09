namespace Dumka_Buh
{
    partial class запрос_периода
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
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputNumericBox_Год = new C1.Win.C1InputPanel.InputNumericBox();
            this.inputNumericBox_мес = new C1.Win.C1InputPanel.InputNumericBox();
            this.inputButton_установить = new C1.Win.C1InputPanel.InputButton();
            this.inputLabel_год = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel_мес = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel_текст = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel_отступ_1 = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel3 = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel4 = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.inputLabel_отступ_1);
            this.c1InputPanel1.Items.Add(this.inputLabel_текст);
            this.c1InputPanel1.Items.Add(this.inputLabel3);
            this.c1InputPanel1.Items.Add(this.inputLabel_год);
            this.c1InputPanel1.Items.Add(this.inputNumericBox_Год);
            this.c1InputPanel1.Items.Add(this.inputLabel4);
            this.c1InputPanel1.Items.Add(this.inputLabel_мес);
            this.c1InputPanel1.Items.Add(this.inputNumericBox_мес);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.inputButton_установить);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(310, 156);
            this.c1InputPanel1.TabIndex = 0;
            this.c1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue;
            // 
            // inputNumericBox_Год
            // 
            this.inputNumericBox_Год.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumericBox_Год.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.inputNumericBox_Год.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.inputNumericBox_Год.Name = "inputNumericBox_Год";
            this.inputNumericBox_Год.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.inputNumericBox_Год.Width = 60;
            // 
            // inputNumericBox_мес
            // 
            this.inputNumericBox_мес.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumericBox_мес.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.inputNumericBox_мес.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumericBox_мес.Name = "inputNumericBox_мес";
            this.inputNumericBox_мес.Width = 60;
            // 
            // inputButton_установить
            // 
            this.inputButton_установить.Height = 33;
            this.inputButton_установить.Name = "inputButton_установить";
            this.inputButton_установить.Text = "Выбрать период";
            this.inputButton_установить.Width = 221;
            // 
            // inputLabel_год
            // 
            this.inputLabel_год.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel_год.ForeColor = System.Drawing.Color.Black;
            this.inputLabel_год.Name = "inputLabel_год";
            this.inputLabel_год.Text = "Год";
            this.inputLabel_год.Width = 90;
            // 
            // inputLabel_мес
            // 
            this.inputLabel_мес.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel_мес.ForeColor = System.Drawing.Color.Black;
            this.inputLabel_мес.Name = "inputLabel_мес";
            this.inputLabel_мес.Text = "Месяц";
            this.inputLabel_мес.Width = 90;
            // 
            // inputLabel_текст
            // 
            this.inputLabel_текст.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.inputLabel_текст.Height = 40;
            this.inputLabel_текст.Name = "inputLabel_текст";
            this.inputLabel_текст.Text = "Выберите период дублирования затраты";
            this.inputLabel_текст.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            this.inputLabel_текст.Width = 237;
            // 
            // inputLabel_отступ_1
            // 
            this.inputLabel_отступ_1.Name = "inputLabel_отступ_1";
            this.inputLabel_отступ_1.Width = 40;
            // 
            // inputLabel3
            // 
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Text = " ";
            this.inputLabel3.Width = 40;
            // 
            // inputLabel4
            // 
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = " ";
            this.inputLabel4.Width = 40;
            // 
            // inputLabel2
            // 
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Width = 40;
            // 
            // запрос_периода
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 156);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "запрос_периода";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор периода";
            this.Load += new System.EventHandler(this.запрос_периода_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputNumericBox inputNumericBox_Год;
        private C1.Win.C1InputPanel.InputNumericBox inputNumericBox_мес;
        private C1.Win.C1InputPanel.InputButton inputButton_установить;
        private C1.Win.C1InputPanel.InputLabel inputLabel_год;
        private C1.Win.C1InputPanel.InputLabel inputLabel_мес;
        private C1.Win.C1InputPanel.InputLabel inputLabel_отступ_1;
        private C1.Win.C1InputPanel.InputLabel inputLabel_текст;
        private C1.Win.C1InputPanel.InputLabel inputLabel3;
        private C1.Win.C1InputPanel.InputLabel inputLabel4;
        private C1.Win.C1InputPanel.InputLabel inputLabel2;

    }
}