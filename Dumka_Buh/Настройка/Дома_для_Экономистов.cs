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
    public partial class Дома_для_Экономистов : Form
    {

        public int д_год_дома = DateTime.Today.Year;

        public int д_мес_дома = 01;
        public string д_мес_имя_дома  ;

        public Дома_для_Экономистов()
        {
            InitializeComponent();
        }

        private void Дома_Load(object sender, EventArgs e)
        {
            // получение параметров
              Главная_Думка_Бух гф = (Главная_Думка_Бух)this.Owner;
           /* не работает !!!
             д_год_дома = гф.д_год;
             д_мес_дома = гф.д_мес;

            ribbonNumericBox_д_год_дома.Value =  д_год_дома;
            ribbonNumericBox_д_мес_дома.Value = д_мес_дома;
            */

              д_год_дома = 2014;
              д_мес_дома = 01;

              ribbonNumericBox_д_год_дома.Value = д_год_дома;
              ribbonNumericBox_д_мес_дома.Value = д_мес_дома;

            заполнить_дома(д_год_дома, д_мес_дома);
        }

        private void итоги_домам()
        {
            int строка = 0;
            double итог_площ_общ = 0;
            double итог_сум_кап_рем = 0;

            double итог_кап_рем_нач = 0;
            double итог_кап_рем_опл = 0;
            double итог_кап_рем_ост_вх = 0;
            
            double итог_пл_территории = 0;
            double итог_пл_помещений = 0;

            int итог_общ = 0;
            int итог_лифт = 0;
            int итог_расчет = 0;

            int итог_кол_зап = 0;

            for (строка = 0; строка <= this.c1TrueDBGrid_Дома_для_Экономистов.Splits[0].Rows.Count - 1; строка++)
            {
                if (this.c1TrueDBGrid_Дома_для_Экономистов.Columns["дом_код"].CellValue(строка).ToString() != "")
                {
                    итог_площ_общ += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_общ"].CellValue(строка));
                    итог_сум_кап_рем += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["сум_кап_рем"].CellValue(строка));

                      итог_пл_территории += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_территории"].CellValue(строка));
                      итог_пл_помещений += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_помещений"].CellValue(строка));

                   
                    итог_кап_рем_нач += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["кап_рем_нач"].CellValue(строка));
                    итог_кап_рем_опл += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["кап_рем_опл"].CellValue(строка));
                    итог_кап_рем_ост_вх += Convert.ToDouble(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["кап_рем_ост_вх"].CellValue(строка));


                    if (Convert.ToInt32(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_общежит"].CellValue(строка)) != 0)
                        итог_общ += 1;

                    if (Convert.ToInt32(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_лифт"].CellValue(строка)) != 0)
                        итог_лифт += 1;

                    if (Convert.ToInt32(this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_0"].CellValue(строка)) != 0)
                        итог_расчет += 1;

                    итог_кол_зап += 1;
                
                
                }

            }
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_общ"].FooterText = итог_площ_общ.ToString("N0");

            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_общ"].FooterText = итог_площ_общ.ToString("N2");
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["сум_кап_рем"].FooterText = итог_сум_кап_рем.ToString("N0");

            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_территории"].FooterText = итог_пл_территории.ToString("N0");
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["пл_помещений"].FooterText = итог_пл_помещений.ToString("N0");
           
            
       

            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_общежит"].FooterText = итог_общ.ToString("N0");
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_лифт"].FooterText = итог_лифт.ToString("N0");
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["гр_0"].FooterText = итог_расчет.ToString("N0");
            this.c1TrueDBGrid_Дома_для_Экономистов.Columns["адрес_ул"].FooterText = итог_кол_зап.ToString("N0");

        }

        private void заполнить_дома(int д_год, int д_мес)
        {

            this.домTableAdapter.FillBy_для_Экономистов(this.dumkaDataSet.дом, д_год, д_мес);
            this.c1TrueDBGrid_Дома_для_Экономистов.ColumnFooters = true;

            /* не работает
            Главная_Думка_Бух гф = (Главная_Думка_Бух)this.Owner;
            д_мес_имя_дома = гф.месяц_имя(д_мес);
            */

            Главная_Думка_Бух гф = new Главная_Думка_Бух();
            д_мес_имя_дома = гф.месяц_имя(д_мес);


            string заголовок_таблицы = " Выбранный период " +
                Convert.ToString(д_мес_имя_дома) + " " +
                Convert.ToString(д_год) + " года";

            this.c1TrueDBGrid_Дома_для_Экономистов.Caption = заголовок_таблицы;
  
            итоги_домам();
        }
        
        private void ribbonButton_Сохранить_Click(object sender, EventArgs e)
        {
            домBindingSource.EndEdit();
            домTableAdapter.Update(dumkaDataSet.дом);
        }

                      

        private void ribbonButton_итог_Click(object sender, EventArgs e)
        {
            итоги_домам();
        }

        private void ribbonButton_Установить_период_Click(object sender, EventArgs e)
        {

            д_год_дома = (int) ribbonNumericBox_д_год_дома.Value;
            д_мес_дома = (int) ribbonNumericBox_д_мес_дома.Value;
            /*
            Главная_Думка_Бух гф = (Главная_Думка_Бух)this.Owner;
            д_мес_имя_дома = гф.месяц_имя(д_мес_дома);
            */
            заполнить_дома(д_год_дома,д_мес_дома);
        }
    }
}
