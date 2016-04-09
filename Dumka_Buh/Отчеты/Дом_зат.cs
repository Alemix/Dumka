using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dumka_Buh.Отчеты
{
    public partial class Дом_зат : Form
    {
        private int дом_код;
        private string адрес;

        public int д_год_с = DateTime.Today.Year;
        public int д_мес_с = DateTime.Today.Month ;

        public int д_год_по = DateTime.Today.Year;
        public int д_мес_по = DateTime.Today.Month;


        public Дом_зат()
        {
            InitializeComponent();
        }


        private void Отч_дом_Load(object sender, EventArgs e)
        {
           
            this.вэ_дом_периодTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_период, д_год_с, д_мес_с, д_год_по, д_мес_по);

            итоги_дом();

            ribbonNumericBox_период_год_с.Value = д_год_с;
            ribbonNumericBox_период_мес_с.Value = д_мес_с;
            ribbonNumericBox_период_год_по.Value = д_год_по;
            ribbonNumericBox_период_мес_по.Value = д_мес_по;


            ribbonLabel_Начало.Text = период_имя(д_год_с, д_мес_с, "Начало");
            ribbonLabel_Конец.Text = период_имя(д_год_по, д_мес_по, "Конец");

            c1DockingTab_отч_низ.SelectedIndex = 0;

          //  ribbonNumericBox_Отм_зап.Value = колво_отм_зап();
        }

        private void c1TrueDBGrid_отч_дом_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            string дом = c1TrueDBGrid_дом.Columns["дом_код"].Value.ToString();

            if (дом.Length != 0)
            {
                дом_код = Convert.ToInt32(дом);
                адрес = c1TrueDBGrid_дом.Columns["адрес"].Value.ToString();
            }

            else
            {
                дом_код = 0;
                адрес = "";
            }

            заполнить_зат_рас_все();
        }

        private void заполнить_зат_рас_все()
        {
            //   this.вэ_зат_рас_матTableAdapter.Fill(this.dumkaDataSet.вэ_зат_рас_мат, дом_код);
            //    this.c1TrueDBGrid_мат.ExpandGroupRow(-1, true);

            this.вэ_зат_рас_бухTableAdapter.Fill(this.dumkaDataSet.вэ_зат_рас_бух, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);
            this.вэ_зат_рас_бух_2TableAdapter.Fill(this.dumkaDataSet.вэ_зат_рас_бух_2, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);
            this.вэ_зат_рас_матTableAdapter.Fill(this.dumkaDataSet.вэ_зат_рас_мат, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);

            this.вэ_зат_рас_извещениеTableAdapter.Fill(this.dumkaDataSet.вэ_зат_рас_извещение, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);

            this.вэ_дом_график_месTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_график_мес, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);
            this.вэ_дом_график_мес_зат_все_сч_дTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_график_мес_зат_все_сч_д, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);
            this.вэ_дом_график_мес_зат_МАТ_сч_дTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_график_мес_зат_МАТ_сч_д, дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);

            //  this.c1TrueDBGrid_бух_мес.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_бух_мес_2.ExpandGroupRow(-1, true);

            this.c1TrueDBGrid_бух_зат.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_мат_мес.ExpandGroupRow(-1, true);

            this.c1TrueDBGrid_гр_все.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_гр_ком_зат.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_гр_мат.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_отч_прав.ExpandGroupRow(-1, true);


            try
            {
                //  this.c1TrueDBGrid_бух_мес.Caption = адрес;
                this.c1TrueDBGrid_бух_мес_2.Caption = адрес;
                this.c1TrueDBGrid_бух_зат.Caption = адрес;
                this.c1TrueDBGrid_мат_мес.Caption = адрес;

                this.c1TrueDBGrid_изв.Caption = адрес;

                this.c1TrueDBGrid_гр_все.Caption = адрес;
                this.c1TrueDBGrid_гр_ком_зат.Caption = адрес;
                this.c1TrueDBGrid_гр_мат.Caption = адрес;
                // пока суммы по месяцам   this.c1TrueDBGrid_отч_прав.Caption = адрес;


            }
            catch (Exception)
            {


            }

        }

        private void итоги_дом()
        {
            int строка = 0;
            int итог_сто_пл_общ = 0;
            int итог_сум_все = 0;
            int итог_сум_мат = 0;
            int итог_пл_общ = 0;
            int итог_кол_зап = 0;


            for (строка = 0; строка <= this.c1TrueDBGrid_дом.Splits[0].Rows.Count - 1; строка++)
            {
                if (this.c1TrueDBGrid_дом.Columns["дом_код"].CellValue(строка).ToString() != "")
                {
                    //ош  итог_сто_пл_общ += Convert.ToInt32(this.c1TrueDBGrid_дом.Columns["сто_пл_общ"].CellValue(строка));
                    //  итог_сум_все += Convert.ToInt32(this.c1TrueDBGrid_дом.Columns["сум_все"].CellValue(строка));
                    // ош   итог_сум_мат += Convert.ToInt32(this.c1TrueDBGrid_дом.Columns["сум_мат"].CellValue(строка));

                    // итог_пл_общ += Convert.ToInt32(this.c1TrueDBGrid_дом.Columns["пл_общ"].CellValue(строка));

                    итог_кол_зап += 1;
                }
            }
            /*
            this.c1TrueDBGrid_дом.Columns["сто_пл_общ"].FooterText = итог_сто_пл_общ.ToString("N0");
            this.c1TrueDBGrid_дом.Columns["сум_все"].FooterText = итог_сум_все.ToString("N0");
            this.c1TrueDBGrid_дом.Columns["сум_мат"].FooterText = итог_сум_мат.ToString("N0");

            this.c1TrueDBGrid_дом.Columns["пл_общ"].FooterText = итог_пл_общ.ToString("N0");
            this.c1TrueDBGrid_дом.Columns["адрес"].FooterText = итог_кол_зап.ToString("N0");
             * 
             */
        }

        private void ribbonButton_Групп_Click(object sender, EventArgs e)
        {
            //  this.c1TrueDBGrid_бух_мес.CollapseGroupRow(-1);
            this.c1TrueDBGrid_бух_мес_2.CollapseGroupRow(-1);
            this.c1TrueDBGrid_бух_зат.CollapseGroupRow(-1);
            this.c1TrueDBGrid_мат_мес.CollapseGroupRow(-1);
            this.c1TrueDBGrid_изв.CollapseGroupRow(-1);
        }

        private void ribbonButton_Нет_групп_Click(object sender, EventArgs e)
        {
            // this.c1TrueDBGrid_бух_мес.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_бух_мес_2.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_бух_зат.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_мат_мес.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_изв.ExpandGroupRow(-1, true);
        }


        private void отч_зат_рас_все_базы()
        {
            DumkaDataSetTableAdapters.QueriesTableAdapter ов;
            ов = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            ов.отч_зат_рас_все(дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);
        }
        // отчеты
        private void ribbonButton_отч_бух_мес_Click(object sender, EventArgs e)
        //Все затраты по месяцам
        {
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_бух_мес об = new Отчеты.отч_бух_мес();
            об.Visible = true;
            об.Activate();
        }

        private void ribbonButton_отч_бух_зат_Click(object sender, EventArgs e)
        // Все затраты по видам
        {
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_бух_зат об = new Отчеты.отч_бух_зат();
            об.Visible = true;
            об.Activate();
        }

        private void ribbonButton_отч_бух_мес_2_Click(object sender, EventArgs e)
        // Все затраты 2 колонки
        {
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_бух_мес_2 об = new Отчеты.отч_бух_мес_2();
            об.Visible = true;
            об.Activate();
        }

        private void ribbonButton_отч_мат_мес_Click(object sender, EventArgs e)
        {
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_мат_мес об = new Отчеты.отч_мат_мес();
            об.Visible = true;
            об.Activate();
        }

        private void ribbonButton_отч_бух_мес_2_свод_Click(object sender, EventArgs e)
        { // Отчет с материалами с Разбивкой по мес
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_бух_мес_2_свод об = new Отчеты.отч_бух_мес_2_свод();
            об.Visible = true;
            об.Activate();
        }

              private void ribbonButton_отч_бух_пер_2_Экономисты_Click(object sender, EventArgs e)
        {
            DumkaDataSetTableAdapters.QueriesTableAdapter ов;
            ов = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            ов.отч_зат_рас_бух_2_Экономисты(дом_код, д_год_с, д_мес_с, д_год_по, д_мес_по);

            //Запуск формы           
            Отчеты.отч_бух_мес_2_свод_Экономисты об = new Отчеты.отч_бух_мес_2_свод_Экономисты();
            об.Visible = true;
            об.Activate();
        }

        
        
        private void ribbonButton_отч_бух_пер_2_свод_Click(object sender, EventArgs e)
        {  // Отчет с материалами ЗА Период
            отч_зат_рас_все_базы();

            //Запуск формы           
            Отчеты.отч_бух_пер_2_свод об = new Отчеты.отч_бух_пер_2_свод();
            об.Visible = true;
            об.Activate();
        }
        private void ribbonButton_отч_бух_пер_2_свод_без_мат_Click(object sender, EventArgs e)
        {
            DumkaDataSetTableAdapters.QueriesTableAdapter ов;
            ов = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            ов.отч_зат_рас_бух_2_период_без_мат(д_год_с, д_мес_с, д_год_по, д_мес_по);

            //Запуск формы           
            Отчеты.отч_бух_пер_2_свод_без_Мат обм = new Отчеты.отч_бух_пер_2_свод_без_Мат();
            обм.Visible = true;
            обм.Activate();
        }

        // отчеты закончились 

        public string период_имя(int д_год, int д_мес, string НачКон)
        {
            return НачКон + " " +
                   месяц_имя(д_мес) + " " +
                   Convert.ToString(д_год) + " г.";
        }
        private void ribbonNumericBox_период_год_с_ValueChanged(object sender, EventArgs e)
        {
            д_год_с = (int)ribbonNumericBox_период_год_с.Value;
            ribbonLabel_Начало.Text = период_имя(д_год_с, д_мес_с, "Начало");
        }

        private void ribbonNumericBox_период_мес_с_ValueChanged(object sender, EventArgs e)
        {
            д_мес_с = (int)ribbonNumericBox_период_мес_с.Value;
            ribbonLabel_Начало.Text = период_имя(д_год_с, д_мес_с, "Начало");
        }

        private void ribbonNumericBox_период_год_по_ValueChanged(object sender, EventArgs e)
        {
            д_год_по = (int)ribbonNumericBox_период_год_по.Value;
            ribbonLabel_Конец.Text = период_имя(д_год_по, д_мес_по, "Конец");
        }

        private void ribbonNumericBox_период_мес_по_ValueChanged(object sender, EventArgs e)
        {
            д_мес_по = (int)ribbonNumericBox_период_мес_по.Value;
            ribbonLabel_Конец.Text = период_имя(д_год_по, д_мес_по, "Конец");
        }

        private void ribbonButton_Установить_период_Click(object sender, EventArgs e)
        {
            this.вэ_дом_периодTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_период, д_год_с, д_мес_с, д_год_по, д_мес_по);

            заполнить_зат_рас_все();
        }

        public string месяц_имя(int мес)
        {
            switch (мес)
            {
                case 1:
                    return "январь";
                case 2:
                    return "февраль";
                case 3:
                    return "март";
                case 4:
                    return "апрель";
                case 5:
                    return "май";
                case 6:
                    return "июнь";
                case 7:
                    return "июль";
                case 8:
                    return "август";
                case 9:
                    return "сентябрь";
                case 10:
                    return "октябрь";
                case 11:
                    return "ноябрь";
                case 12:
                    return "декабрь";
                default:
                    return "нет";
            }
        }

        private void ribbonButton_Сохранить_Click(object sender, EventArgs e)
        {
            сохранить();
        }

        private void c1TrueDBGrid_дом_AfterColEdit(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {
            сохранить();
           // ribbonNumericBox_Отм_зап.Value = колво_отм_зап();
        }

        private void сохранить()
        {
            вэ_дом_период_BindingSource.EndEdit();
            вэ_дом_периодTableAdapter.Update(dumkaDataSet.Вэ_дом_период);
        }
        private void ribbonButton_Отметить_все_Click(object sender, EventArgs e)
        {
            DumkaDataSetTableAdapters.QueriesTableAdapter ов;
            ов = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            ов.дом_период_отм_Все();

            this.вэ_дом_периодTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_период, д_год_с, д_мес_с, д_год_по, д_мес_по);

            /* int строка  = 0;
            for (строка = 0; строка <= this.c1TrueDBGrid_дом.Splits[0].Rows.Count - 1; строка++)
            {
                c1TrueDBGrid_дом.Columns["отм"].Value = 1;
            }*/
        }

        private void ribbonButton_Разотметить_все_Click(object sender, EventArgs e)
        {
            DumkaDataSetTableAdapters.QueriesTableAdapter ов;
            ов = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            ов.дом_период_отм_Все_разотметить();

            this.вэ_дом_периодTableAdapter.Fill(this.dumkaDataSet.Вэ_дом_период, д_год_с, д_мес_с, д_год_по, д_мес_по);
        }

        private int колво_отм_зап()
        {
            int зап = 0;
            int строка;
            string ст; 
            for (строка = 0; строка <= this.c1TrueDBGrid_дом.Splits[0].Rows.Count - 1; строка++)
            {

                if (Convert.ToBoolean(c1TrueDBGrid_дом.Columns["отм"].Value) == true)
                        зап = зап + 1;
    }
            return зап;
        }

        private void ribbonButton_Выгрузить_Excell_Click(object sender, EventArgs e)
        {
            // create export filter
            string имя_файла = System.Windows.Forms.Application.StartupPath + @"\Итоговый_Отчет_.xls";

            c1TrueDBGrid_дом.ExportToExcel(имя_файла);

            System.Diagnostics.Process.Start(имя_файла);
        }

      
       

    }
}
/* ст = c1TrueDBGrid_дом.Columns["отм"].Value.ToString();
                if (ст.Length != 0)
                {
                    if ( Convert.ToBoolean(ст) == true)
                        зап = зап + 1;
                }*/