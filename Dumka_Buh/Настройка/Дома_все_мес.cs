using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dumka_Buh.Настройка
{
    public partial class Дома_все_мес : Form
    {

        // public int д_год_дома = 2012;
        public int д_год_дома = DateTime.Today.Year;
        
        public string д_мес_имя_дома;

        public Дома_все_мес()
        {
            InitializeComponent();
        }

        private void Дома_Load(object sender, EventArgs e)
        {
            заполнить_дома(д_год_дома);
        }

      

        private void заполнить_дома(int д_год)
        {

            this.домTableAdapter.FillBy_все_мес(this.dumkaDataSet.дом, д_год);
            
        }
        
        private void ribbonButton_Сохранить_Click(object sender, EventArgs e)
        {
            домBindingSource.EndEdit();
            домTableAdapter.Update(dumkaDataSet.дом);
        }

    }
}
