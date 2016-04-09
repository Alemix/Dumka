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
    public partial class Списки_изм : Form
    {
        public Списки_изм()
        {
            InitializeComponent();
        }

        private void Списки_изм_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dumkaDataSet.с_список". При необходимости она может быть перемещена или удалена.
            this.с_списокTableAdapter.Fill(this.dumkaDataSet.с_список);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dumkaDataSet.дом". При необходимости она может быть перемещена или удалена.
            this.домTableAdapter.Fill(this.dumkaDataSet.дом,2012 , 1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dumkaDataSet.список_изм". При необходимости она может быть перемещена или удалена.
            this.список_измTableAdapter.Fill(this.dumkaDataSet.список_изм);
            
            this.дом_поискTableAdapter.Fill(this.dumkaDataSet.дом_поиск, "бре");
        }

        private void ribbonButton_Сохранить_Click(object sender, EventArgs e)
        {
            записать_список_изм();
            заполнить_список_изм();
        }


        private void заполнить_список_изм()
        {

            int строка_сохранить = Convert.ToInt16(c1TrueDBGrid_список_изм.Row);
            this.список_измTableAdapter.Fill(this.dumkaDataSet.список_изм);
            c1TrueDBGrid_список_изм.Row = строка_сохранить;
        
        }
        private void записать_список_изм()
        {

            список_изм_BindingSource.EndEdit();
            список_измTableAdapter.Update(dumkaDataSet.список_изм);

        }


        private void inputTextBox_лист_TextChanged(object sender, EventArgs e)
        {
            string адр;
            адр = inputTextBox_лист.Text.ToString();
 
           this.дом_поискTableAdapter.Fill(this.dumkaDataSet1.дом_поиск, адр);
       
        }

       

        private void c1TrueDBGrid_дом_поиск_FilterChange(object sender, EventArgs e)
        {
           /*
           StringBuilder sb = new StringBuilder();
         
             foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid_дом_поиск.Columns)
            {
                if (dc.FilterText.Length > 0)
                {
                    if (sb.Length > 0) sb.Append(" AND ");
                    sb.Append(dc.DataField + " like " + "'%" + dc.FilterText + "%'");
                }
            }
            // filter the data
            this.dumkaDataSet1.дом_поиск.DefaultView.RowFilter = sb.ToString();


            */

            /* это сделал я  
              StringBuilder sb = new StringBuilder();
             * 
             foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid_дом_поиск.Columns)
            {
                if (dc.FilterText.Length > 0)
                {
                    if (sb.Length > 0) sb.Append(" AND ");
                    sb.Append(dc.DataField + " like " + "'" + dc.FilterText + "*'");
                }
            }
            // filter the data
            this.dumkaDataSet1.дом_поиск.DefaultView.RowFilter = sb.ToString();
            
             * * * это образец
               // build our filter expression
            StringBuilder sb = new StringBuilder();		

            foreach(C1.Win.C1TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid1.Columns)
            {
                if( dc.FilterText.Length > 0 )
                {
                    if( sb.Length > 0 ) sb.Append(" AND ");
                    sb.Append(dc.DataField + " like " + "'" + dc.FilterText + "*'");
                }
            }
            // filter the data
            this.dataSet11.Tables[0].DefaultView.RowFilter = sb.ToString();
             * */
        }


    }
}
