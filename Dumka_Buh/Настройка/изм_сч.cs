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
    public partial class изм_сч : Form
    {
        public изм_сч()
        {
            InitializeComponent();
        }

        private void изм_ан_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dumka_DataSet.изм_сч". При необходимости она может быть перемещена или удалена.
            this.изм_счTableAdapter.Fill(this.dumka_DataSet.изм_сч);
          
        }

        private void ribbonButton_Записать_Click(object sender, EventArgs e)
        {
            изм_сч_BindingSource.EndEdit();
            изм_счTableAdapter.Update(dumka_DataSet.изм_сч);
        }
    }
}
