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
    public partial class изм_ан : Form
    {
        public изм_ан()
        {
            InitializeComponent();
        }

        private void изм_ан_Load(object sender, EventArgs e)
        {
              this.изм_анTableAdapter.Fill(this.dumka_DataSet.изм_ан);

        }

        private void ribbonButton_Записать_Click(object sender, EventArgs e)
        {
            изм_ан_BindingSource.EndEdit();
            изм_анTableAdapter.Update(dumka_DataSet.изм_ан);
        }
    }
}
