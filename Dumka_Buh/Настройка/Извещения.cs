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
    public partial class Извещения : Form
    {
        public Извещения()
        {
            InitializeComponent();
        }

        private void изм_ан_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dumkaDataSet.с_изв_2014". При необходимости она может быть перемещена или удалена.
            this.с_изв_2014_TableAdapter.Fill(this.dumkaDataSet.с_изв_2014);
           

        }

        private void ribbonButton_Записать_Click(object sender, EventArgs e)
        {
            с_изв_2014_BindingSource.EndEdit();
            с_изв_2014_TableAdapter.Update(dumkaDataSet.с_изв_2014);
        }
    }
}
