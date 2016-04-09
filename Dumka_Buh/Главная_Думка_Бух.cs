using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.SqlServer.Dts.Runtime;

namespace Dumka_Buh
{
    public partial class Главная_Думка_Бух : Form
    {
        public int д_год = DateTime.Today.Year;
        public int д_мес = 1;  // DateTime.Today.Month - 1;;
        public string д_мес_имя = "январь";


        public int д_год_все = DateTime.Today.Year;

        public int д_мес_все = 1; // DateTime.Today.Month - 1;
        public string д_мес_все_имя = "январь";
        //  = месяц_имя(д_мес_все);

        public int ист_код = 0;
        public int алг_код_выд = 0;


        public int закладка_выд = 1;

        public int зат_выд_код = 0;

        public string зат_выд_имя = "";

        public int зат_рас_сумма = 0;
        public int зат_рас_кол = 0;

        public string показать_только_рас = "";
        public string показать_только_выд = "";


        /*
        public int стр_выд = 0;
        
        public Int32 итог_сум_выд = 0;
        public Int32 итог_сум_рас = 0;
        public Int32 итог_сум_разница = 0;

        public Int32 итог_сум_рас_площ = 0;
        public Int32 итог_сум_рас_спис = 0;

        public Int32 итог_рас_сум = 0;
        public Int32 итог_рас_кол = 0;
        public Int32 итог_рас_пл_общ = 0;
         
        public int итог_дом = 0;
        public int итог_дом_площ = 0;
        public int итог_дом_спис = 0;
        */

        public Главная_Думка_Бух()
        {
            InitializeComponent();
        }

        private void Главная_Думка_Бух_Load(object sender, EventArgs e)
        {

            ribbonNumericBox_период_год.Value = DateTime.Today.Year;
            ribbonNumericBox_период_мес.Value = 1;

            д_год = DateTime.Today.Year;
            д_мес = 01;

            заполнить_зат_выд_ВСЕ_таблицы();

            c1DockingTab_зат_рас_дом.SelectedIndex = 0;

            /*
              c1Ribbon_бух.Text = "Это текст";
             //c1Ribbon_бух.ti = "Это текст";

              Главная_Думка_Бух гф = new Главная_Думка_Бух();
              гф.Text = "Это текст формы";
             * 
             */

            /*// Версия сборки 
            // AssemblyName.GetAssemblyName(Assembly.Load("TableEditor").Location).Version
            // Application.ProductVersion - дает Application.ProductVersion = "1.0.0.0"

            //Assembly: Assembly m_MyAssembly = Assembly.GetExecutingAssembly();

            //   ribbonLabel_версия.Text = Application.ProductVersion;
            ribbonLabel_версия.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            */

            string Ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string ful = Assembly.GetExecutingAssembly().GetName().FullName.ToString();
            string na = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            string zz = typeof(String).Assembly.GetName().Version.ToString();


            // ribbonTextBox_версия.Text = Assembly.GetExecutingAssembly().GetName().FullName.ToString();

            string pp = System.Windows.Forms.Application.ProductVersion.ToString();
        }
        //
        // Таблица Выделение  Бух 
        //
        private void заполнить_зат_выд_пер()
        {
            int стр_выд = Convert.ToInt16(c1TrueDBGrid_зат_выд_пер.Row);

            string заголовок_выд = "Затраты за  " +
                Convert.ToString(д_мес_имя) + " " +
                Convert.ToString(д_год) + " года";


            switch (показать_только_выд)
            {
                case "спи":
                    {
                        this.вэ_зат_выд_пер_TableAdapter.FillBy_год_мес_список(this.dumka_DataSet.вэ_зат_выд_пер, д_год, д_мес);
                        заголовок_выд += " ( только СПИСОК )";
                    }
                    break;

                case "пло":
                    {
                        this.вэ_зат_выд_пер_TableAdapter.FillBy_год_мес_площадь(this.dumka_DataSet.вэ_зат_выд_пер, д_год, д_мес);
                        заголовок_выд += " ( только ПЛОЩАДЬ )";
                    }
                    break;

                default:
                    this.вэ_зат_выд_пер_TableAdapter.FillBy_год_мес(this.dumka_DataSet.вэ_зат_выд_пер, д_год, д_мес);
                    break;
            }

            this.c1TrueDBGrid_зат_выд_пер.ExpandGroupRow(-1, true);
            итоги_выд_пер();

            c1TrueDBGrid_зат_выд_пер.Row = стр_выд;

            this.c1TrueDBGrid_зат_выд_пер.Caption = заголовок_выд;

        }
        private void заполнить_зат_выд_все()
        {
            int стр_выд = Convert.ToInt16(c1TrueDBGrid_зат_выд_все.Row);

            string заголовок_выд = "Затраты за  " +
                                       Convert.ToString(д_год) + " год";


            switch (показать_только_выд)
            {
                case "спи":
                    {
                        this.вэ_зат_выд_ВСЕ_TableAdapter.FillBy_все_список(this.dumka_DataSet.вэ_зат_выд_ВСЕ);
                        заголовок_выд += " ( только СПИСОК )";
                    } break;

                case "пло":
                    {
                        this.вэ_зат_выд_ВСЕ_TableAdapter.FillBy_все_площадь(this.dumka_DataSet.вэ_зат_выд_ВСЕ);
                        заголовок_выд += " ( только ПЛОЩАДЬ )";
                    } break;

                default:

                    try
                    {
                        this.вэ_зат_выд_ВСЕ_TableAdapter.FillBy_все(this.dumka_DataSet.вэ_зат_выд_ВСЕ);
                    }
                    catch (Exception)
                    {
                        // throw;
                    }
                    break;
            }

            this.c1TrueDBGrid_зат_выд_все.ExpandGroupRow(-1, true);

            итоги_выд_все();
            c1TrueDBGrid_зат_выд_все.Row = стр_выд;

            this.c1TrueDBGrid_зат_выд_все.Caption = заголовок_выд;
        }

        private void заполнить_зат_выд_сравн()
        {
            int стр_выд = Convert.ToInt16(c1TrueDBGrid_зат_выд_сравн.Row);
            this.вэ_зат_выд_сравн_бухTableAdapter.FillBy_год_мес(this.dumka_DataSet.вэ_зат_выд_сравн_бух, д_год, д_мес);

            this.c1TrueDBGrid_зат_выд_сравн.ExpandGroupRow(-1, true);
            //итоги_выд_пер();

            c1TrueDBGrid_зат_выд_сравн.Row = стр_выд;

            string заголовок_выд = "Сравнение сумм с бух. учетом  за " +
                 Convert.ToString(д_мес_имя) + " " +
                 Convert.ToString(д_год) + " года";
            this.c1TrueDBGrid_зат_выд_сравн.Caption = заголовок_выд;

        }

        private void заполнить_зат_выд_извещение()
        {
            int стр_выд = Convert.ToInt16(c1TrueDBGrid_зат_выд_изв.Row);
            this.вэ_зат_выд_извещениеTableAdapter.Fill(this.dumka_DataSet.вэ_зат_выд_извещение, д_год, д_мес);

            this.c1TrueDBGrid_зат_выд_изв.ExpandGroupRow(-1, true);
            //итоги_выд_пер();

            c1TrueDBGrid_зат_выд_изв.Row = стр_выд;

            string заголовок_выд = "Проверка затрат по группам Извещения  за " +
                 Convert.ToString(д_мес_имя) + " " +
                 Convert.ToString(д_год) + " года";
            this.c1TrueDBGrid_зат_выд_сравн.Caption = заголовок_выд;

        }
        private void заполнить_зат_выд_ВСЕ_таблицы()
        {
            заполнить_зат_выд_пер();
            заполнить_зат_выд_все();
            заполнить_зат_выд_сравн();
            заполнить_зат_выд_извещение();
        }

        private void c1TrueDBGrid_зат_выд_пер_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            string зат_выд = c1TrueDBGrid_зат_выд_пер.Columns["зат_выд_код"].Value.ToString();
            if (зат_выд.Length != 0)
            {
                зат_выд_код = Convert.ToInt32(зат_выд);
                зат_рас_сумма = Convert.ToInt32(c1TrueDBGrid_зат_выд_пер.Columns["сум_рас"].Value);
                зат_рас_кол = Convert.ToInt32(c1TrueDBGrid_зат_выд_пер.Columns["кол_рас"].Value);
                алг_код_выд = Convert.ToInt32(c1TrueDBGrid_зат_выд_пер.Columns["рас_алг_код"].Value);
                зат_выд_имя = Convert.ToString(c1TrueDBGrid_зат_выд_пер.Columns["зат_выд_имя"].Value);
                д_год_все = д_год;
                д_мес_все = д_мес;
                д_мес_все_имя = месяц_имя(д_мес);
            }

            else
            {
                зат_выд_код = 0;
                зат_рас_сумма = 0;
                зат_рас_кол = 0;
                алг_код_выд = 0;
                зат_выд_имя = "";
                д_год_все = д_год;
                д_мес_все = д_мес;
                д_мес_все_имя = месяц_имя(д_мес);
            }

            заполнить_зат_рас_дом();
            лента_рас_гасить();
            колонки_зат_рас_дом_прятать(1);
        }
        private void c1TrueDBGrid_зат_выд_все_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            string зат_выд = c1TrueDBGrid_зат_выд_все.Columns["зат_выд_код"].Value.ToString();
            if (зат_выд.Length != 0)
            {
                зат_выд_код = Convert.ToInt32(зат_выд);
                зат_рас_сумма = Convert.ToInt32(c1TrueDBGrid_зат_выд_все.Columns["сум_рас"].Value);
                зат_рас_кол = Convert.ToInt32(c1TrueDBGrid_зат_выд_все.Columns["кол_рас"].Value);
                алг_код_выд = Convert.ToInt32(c1TrueDBGrid_зат_выд_все.Columns["рас_алг_код"].Value);
                зат_выд_имя = Convert.ToString(c1TrueDBGrid_зат_выд_все.Columns["зат_выд_имя"].Value);
                д_год_все = Convert.ToInt32(c1TrueDBGrid_зат_выд_все.Columns["д_год"].Value);
                д_мес_все = Convert.ToInt32(c1TrueDBGrid_зат_выд_все.Columns["д_мес"].Value);
                д_мес_все_имя = месяц_имя(д_мес_все);
            }

            else
            {
                зат_выд_код = 0;
                зат_рас_сумма = 0;
                зат_рас_кол = 0;
                алг_код_выд = 0;
                зат_выд_имя = "";
                д_год_все = д_год;
                д_мес_все = д_мес;
                д_мес_все_имя = месяц_имя(д_мес_все);
            }

            заполнить_зат_рас_дом();
            лента_рас_гасить();
        }
        private void c1TrueDBGrid_зат_выд_сравн_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            string зат_выд = c1TrueDBGrid_зат_выд_сравн.Columns["зат_выд_код"].Value.ToString();
            if (зат_выд.Length != 0)
            {
                зат_выд_код = Convert.ToInt32(зат_выд);
                // зат_рас_сумма = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["сум_рас"].Value);
                // зат_рас_кол = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["кол_рас"].Value);
                // алг_код_выд = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["рас_алг_код"].Value);
                зат_выд_имя = Convert.ToString(c1TrueDBGrid_зат_выд_сравн.Columns["зат_выд_имя"].Value);
                // д_год_все = д_год;
                // д_мес_все = д_мес;
                // д_мес_все_имя = месяц_имя(д_мес);
            }

            else
            {
                зат_выд_код = 0;
                зат_рас_сумма = 0;
                зат_рас_кол = 0;
                алг_код_выд = 0;
                зат_выд_имя = "";
                д_год_все = д_год;
                д_мес_все = д_мес;
                д_мес_все_имя = месяц_имя(д_мес);
            }

            заполнить_зат_рас_дом();
            //  лента_рас_гасить();
            //  колонки_зат_рас_дом_прятать(1);
        }
        private void c1TrueDBGrid_зат_выд_изв_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            string зат_выд = c1TrueDBGrid_зат_выд_изв.Columns["зат_выд_код"].Value.ToString();
            if (зат_выд.Length != 0)
            {
                зат_выд_код = Convert.ToInt32(зат_выд);
                // зат_рас_сумма = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["сум_рас"].Value);
                // зат_рас_кол = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["кол_рас"].Value);
                // алг_код_выд = Convert.ToInt32(c1TrueDBGrid_зат_выд_сравн.Columns["рас_алг_код"].Value);
                зат_выд_имя = Convert.ToString(c1TrueDBGrid_зат_выд_изв.Columns["зат_выд_имя"].Value);
                // д_год_все = д_год;
                // д_мес_все = д_мес;
                // д_мес_все_имя = месяц_имя(д_мес);
            }

            else
            {
                зат_выд_код = 0;
                зат_рас_сумма = 0;
                зат_рас_кол = 0;
                алг_код_выд = 0;
                зат_выд_имя = "";
                д_год_все = д_год;
                д_мес_все = д_мес;
                д_мес_все_имя = месяц_имя(д_мес);
            }

            заполнить_зат_рас_дом();
        }

        private void лента_рас_гасить()
        {
            /*
        алг_код	алг_имя
         1	    Площ.Общ.
         2	    Список
         3	    ТМЦ
         4	    Осн.Ср-ва
         5	    Ручной
             */
            /*
                        if (зат_рас_кол == 0)  // Нет распредел
                        {
                            ribbonButton_рас_по_общ_пл.Enabled = true;
                            ribbonButton_рас_принять_ТМЦ.Enabled = true;

                            лента_рас_гасить_список();

                        }
                        else
                        {
                            ribbonButton_рас_по_общ_пл.Enabled = false;
                            ribbonButton_рас_принять_ТМЦ.Enabled = false;
                            лента_рас_гасить_список();
                        }
              */

        }
        private void лента_рас_гасить_список()
        {
            if (алг_код_выд == 2)  //  2 = Список
            {
                ribbonButton_рас_список_создать.Enabled = true;
                // ribbonButton_рас_список_ост.Enabled = true;

                ribbonButton_рас_список_сохранить.Enabled = true;
                ribbonButton_рас_список_восстановить.Enabled = true;
            }
            else
            {
                ribbonButton_рас_список_создать.Enabled = false;
                //ribbonButton_рас_список_ост.Enabled = false;

                ribbonButton_рас_список_сохранить.Enabled = false;
                ribbonButton_рас_список_восстановить.Enabled = false;
            }
        }

        private void итоги_выд_пер()
        {
            int строка = 0;
            int итог_сум_выд = 0;
            int итог_сум_рас = 0;
            int итог_сум_разница = 0;

            int итог_сум_рас_площ = 0;
            int итог_сум_рас_спис = 0;

            int итог_дом = 0;
            int итог_дом_площ = 0;
            int итог_дом_спис = 0;
            int итог_кол_зап = 0;

            for (строка = 0; строка <= this.c1TrueDBGrid_зат_выд_пер.Splits[0].Rows.Count - 1; строка++)
            {
                if (this.c1TrueDBGrid_зат_выд_пер.Columns["зат_выд_код"].CellValue(строка).ToString() != "")
                {
                    итог_сум_выд += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["сум_сумма"].CellValue(строка));
                    итог_сум_рас += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас"].CellValue(строка));
                    итог_сум_разница += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["сум_разница"].CellValue(строка));

                    итог_сум_рас_площ += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас_площ"].CellValue(строка));
                    итог_сум_рас_спис += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас_спис"].CellValue(строка));

                    итог_дом += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас"].CellValue(строка));
                    итог_дом_площ += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас_площ"].CellValue(строка));
                    итог_дом_спис += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас_спис"].CellValue(строка));
                    итог_кол_зап += 1;
                }

            }

            this.c1TrueDBGrid_зат_выд_пер.Columns["сум_сумма"].FooterText = итог_сум_выд.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас"].FooterText = итог_сум_рас.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["сум_разница"].FooterText = итог_сум_разница.ToString("N0");

            this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас_площ"].FooterText = итог_сум_рас_площ.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["сум_рас_спис"].FooterText = итог_сум_рас_спис.ToString("N0");

            this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас"].FooterText = итог_дом.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас_площ"].FooterText = итог_дом_площ.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["кол_рас_спис"].FooterText = итог_дом_спис.ToString("N0");


            this.c1TrueDBGrid_зат_выд_пер.Columns["сч_к"].FooterText = итог_кол_зап.ToString("N0");
            this.c1TrueDBGrid_зат_выд_пер.Columns["сч_к_имя"].FooterText = "Итого";

        }
        private void итоги_выд_все()
        {
            int строка = 0;
            int итог_сум_выд = 0;
            int итог_сум_рас = 0;
            int итог_сум_разница = 0;

            int итог_сум_рас_площ = 0;
            int итог_сум_рас_спис = 0;

            int итог_дом = 0;
            int итог_дом_площ = 0;
            int итог_дом_спис = 0;
            int итог_кол_зап = 0;

            for (строка = 0; строка <= this.c1TrueDBGrid_зат_выд_все.Splits[0].Rows.Count - 1; строка++)
            {
                if (this.c1TrueDBGrid_зат_выд_все.Columns["зат_выд_код"].CellValue(строка).ToString() != "")
                {
                    итог_сум_выд += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["сум_сумма"].CellValue(строка));
                    итог_сум_рас += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас"].CellValue(строка));
                    итог_сум_разница += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["сум_разница"].CellValue(строка));

                    итог_сум_рас_площ += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас_площ"].CellValue(строка));
                    итог_сум_рас_спис += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас_спис"].CellValue(строка));

                    итог_дом += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас"].CellValue(строка));
                    итог_дом_площ += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас_площ"].CellValue(строка));
                    итог_дом_спис += Convert.ToInt32(this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас_спис"].CellValue(строка));
                    итог_кол_зап += 1;
                }

            }

            this.c1TrueDBGrid_зат_выд_все.Columns["сум_сумма"].FooterText = итог_сум_выд.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас"].FooterText = итог_сум_рас.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["сум_разница"].FooterText = итог_сум_разница.ToString("N0");

            this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас_площ"].FooterText = итог_сум_рас_площ.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["сум_рас_спис"].FooterText = итог_сум_рас_спис.ToString("N0");

            this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас"].FooterText = итог_дом.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас_площ"].FooterText = итог_дом_площ.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["кол_рас_спис"].FooterText = итог_дом_спис.ToString("N0");


            this.c1TrueDBGrid_зат_выд_все.Columns["сч_к"].FooterText = итог_кол_зап.ToString("N0");
            this.c1TrueDBGrid_зат_выд_все.Columns["сч_к_имя"].FooterText = "Итого";

        }

        private void ribbonButton_итог_выд_Click(object sender, EventArgs e)
        {
            итоги_выд_пер();
            итоги_выд_все();
        }
        private void ribbonButton_обновить_выд_Click(object sender, EventArgs e)
        {
            заполнить_зат_выд_ВСЕ_таблицы();
        }

        private void ribbonButton_выд_груп_нет_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_выд_пер.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_зат_выд_все.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_зат_выд_изв.ExpandGroupRow(-1, true);
        }
        private void ribbonButton_выд_груп_да_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_выд_пер.CollapseGroupRow(-1);
            this.c1TrueDBGrid_зат_выд_все.CollapseGroupRow(-1);
            this.c1TrueDBGrid_зат_выд_изв.CollapseGroupRow(-1);
        }
        //
        // Таблица Распределение
        //
        private void заполнить_зат_рас_дом()
        {
            try
            {
                switch (показать_только_рас)
                {
                    case "спи":
                        this.вэ_зат_рас_домTableAdapter.FillBy_список(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                        break;

                    case "пло":
                        this.вэ_зат_рас_домTableAdapter.FillBy_площадь(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                        break;

                    case "лиф":
                        this.вэ_зат_рас_домTableAdapter.FillBy_лифт(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                        break;

                    case "общ":
                        this.вэ_зат_рас_домTableAdapter.FillBy_общежит(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                        break;

                    /* case "пус":
                         this.вэ_зат_рас_домTableAdapter.FillBy_список(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                         break; */

                    default:
                        this.вэ_зат_рас_домTableAdapter.FillBy_зат_выд_код(this.dumka_DataSet.вэ_зат_рас_дом, зат_выд_код);
                        break;
                }

                итоги_рас();
                /*
                string заголовок_выд = "Затраты за  " +
                              Convert.ToString(д_мес_имя) + " " +
                              Convert.ToString(д_год) + " года";
                */

                this.c1TrueDBGrid_зат_рас_ули_итог.Caption =
                this.c1TrueDBGrid_зат_рас_дом_итог.Caption =
                this.c1TrueDBGrid_зат_рас_дом.Caption =
                зат_выд_имя + " ( за " + д_мес_все_имя.ToString() + " " + д_год_все.ToString() + " )";
            }
            catch (Exception ош_зм)
            {
            }
        }

        private void колонки_зат_рас_дом_прятать(int кол_вид) // 
        {
            // 1 - первоначально
            C1.Win.C1TrueDBGrid.C1DisplayColumn мат_имя;
            мат_имя = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["мат_имя"];

            C1.Win.C1TrueDBGrid.C1DisplayColumn с_кол;
            с_кол = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["с_кол"];

            C1.Win.C1TrueDBGrid.C1DisplayColumn док_ном;
            док_ном = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["док_ном"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn док_дат;
            док_дат = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["док_дат"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn пл_общ;
            пл_общ = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["пл_общ"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn с_про;
            с_про = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["с_про"];
            // код
            C1.Win.C1TrueDBGrid.C1DisplayColumn зат_выд_код;
            зат_выд_код = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["зат_выд_код"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn зат_рас_код;
            зат_рас_код = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["зат_рас_код"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn дом_код;
            дом_код = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["дом_код"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn алг_код;
            алг_код = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["алг_код"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn алг_имя;
            алг_имя = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["алг_имя"];


            C1.Win.C1TrueDBGrid.C1DisplayColumn адр_ули;
            адр_ули = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["адр_ули"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn адр_дом;
            адр_дом = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["адр_дом"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn адрес;
            адрес = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["адрес"];


            C1.Win.C1TrueDBGrid.C1DisplayColumn этажей;
            этажей = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["этажей"];


            C1.Win.C1TrueDBGrid.C1DisplayColumn гр_0;
            гр_0 = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["гр_0"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn жэс_код;
            жэс_код = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["жэс_код"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn квартир;
            квартир = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["квартир"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn пл_жил;
            пл_жил = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["пл_жил"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn пл_аренды;
            пл_аренды = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["пл_аренды"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn материал;
            материал = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["материал"];
            C1.Win.C1TrueDBGrid.C1DisplayColumn вид;
            вид = this.c1TrueDBGrid_зат_рас_дом.Splits[0].DisplayColumns["вид"];


            // гашу лишние колонки
            зат_выд_код.Visible = false;
            зат_рас_код.Visible = false;
            дом_код.Visible = true;

            алг_код.Visible = false;
            алг_имя.Visible = true;
            адр_ули.Visible = false;
            адр_дом.Visible = false;
            адрес.Visible = false;
            этажей.Visible = false;

            гр_0.Visible = false;
            жэс_код.Visible = false;
            квартир.Visible = false;
            пл_жил.Visible = false;
            пл_аренды.Visible = false;
            материал.Visible = false;
            вид.Visible = false;


            if (алг_код_выд == 3) // это материалы
            {
                мат_имя.Visible = true;
                с_кол.Visible = true;
                док_ном.Visible = true;
                док_дат.Visible = true;

                пл_общ.Visible = false;
                с_про.Visible = false;

            }
            else
            {
                мат_имя.Visible = false;
                с_кол.Visible = true;
                док_ном.Visible = false;
                док_дат.Visible = false;

                пл_общ.Visible = false;
                с_про.Visible = true;
            }


        }
        private void ribbonButton_записать_рас_Click(object sender, EventArgs e)
        {
            записать_зат_рас_дом();
            заполнить_зат_рас_дом();
        }

        private void записать_зат_рас_дом()
        {
            вэ_зат_рас_дом_BindingSource.EndEdit();
            вэ_зат_рас_домTableAdapter.Update(dumka_DataSet.вэ_зат_рас_дом);

            DumkaDataSetTableAdapters.QueriesTableAdapter сс;
            сс = new DumkaDataSetTableAdapters.QueriesTableAdapter();


            try
            {
                сс.зат_рас_список_сохранить(зат_выд_код);
            }
            catch (Exception e)
            {
                MessageBox.Show("Список распределения \n\n НЕ Сохранен!  \n\n" + e, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //throw;
            }


            заполнить_зат_рас_дом();
            // обновить списки выделения
            заполнить_зат_выд_ВСЕ_таблицы();

            MessageBox.Show("Список распределения \n\nСохранен! ", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void c1TrueDBGrid_зат_рас_дом_AfterColEdit(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {
            int строка = 0;
            //строка =  c1TrueDBGrid_зат_рас_дом.Row;


            if (c1TrueDBGrid_зат_рас_дом.Columns["алг_код"].ToString() != "")
            {
                строка = Convert.ToInt32(c1TrueDBGrid_зат_рас_дом.Columns["алг_код"].Value);
                c1TrueDBGrid_зат_рас_дом.Columns["алг_код"].Value = 2;
            }
        }
        private void c1TrueDBGrid_зат_рас_дом_FetchCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs ec)
        {
            // выделение по условию
            int алг = 0;

            if (ec.Column.Name == "сумма")
            {

                //  if (this.c1TrueDBGrid_зат_рас_дом[Columns(ec.Col).CellText(this.c1TrueDBGrid_зат_рас_дом.RowBookmark(ec.Row)) == 
                if (c1TrueDBGrid_зат_рас_дом[ec.Row, "алг_код"].ToString() == "")
                    алг = 0;
                else
                    алг = Convert.ToUInt16(c1TrueDBGrid_зат_рас_дом[ec.Row, "алг_код"]);

                if (алг == 1)
                {
                    ec.CellStyle.ForeColor = System.Drawing.Color.Green;
                    // Font f_A;
                    // f_A = new Font(e.CellStyle.Font, FontStyle.Bold);
                    // e.CellStyle.Font = f_A;
                }
                if (алг == 2)
                {
                    ec.CellStyle.ForeColor = System.Drawing.Color.Blue;

                }
                if (алг == 0)
                {
                    ec.CellStyle.ForeColor = System.Drawing.Color.Red;

                }
            }

        }
        private void c1TrueDBGrid_зат_рас_дом_FetchGroupCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs eg)
        {
            //  MessageBox.Show("Test");
            eg.CellStyle.ForeColor = System.Drawing.Color.RosyBrown;
        }
        private void c1TrueDBGrid_площ_FetchGroupCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs e)
        {
            // деллало сумму dsl - серым цветом  e.CellStyle.BackColor = System.Drawing.Color.LightGray;
        }

        private void итоги_рас()
        {
            int строка = 0;
            int итог_кол_зап = 0;
            int итог_рас_сум = 0;
            int итог_рас_кол = 0;
            //  decimal итог_рас_пл_общ = 0;


            // string пл_общ_строка;

            for (строка = 0; строка <= this.c1TrueDBGrid_зат_рас_дом.Splits[0].Rows.Count - 1; строка++)
            {
                if (this.c1TrueDBGrid_зат_рас_дом.Columns["зат_рас_код"].CellValue(строка).ToString() != "")
                {
                    итог_рас_сум += Convert.ToInt32(this.c1TrueDBGrid_зат_рас_дом.Columns["с_сумма"].CellValue(строка));
                    итог_рас_кол += Convert.ToInt32(this.c1TrueDBGrid_зат_рас_дом.Columns["с_кол"].CellValue(строка));

                    /* пл_общ - это с_кол
                          // итог_рас_пл_общ += Convert.ToDecimal(this.c1TrueDBGrid_зат_рас_дом.Columns["Пл. Общ."].CellValue(строка));
                          // пл_общ_строка = this.c1TrueDBGrid_зат_рас_дом.Columns["Пл. Общ."].CellValue(строка).ToString();
                         // пл_общ_строка = this.c1TrueDBGrid_зат_рас_дом.Columns["пл_общ"].CellValue(строка).ToString();
                                        пл_общ_строка = this.c1TrueDBGrid_зат_рас_дом.Columns["Пл. Общ."].CellValue(строка).ToString();
                                         // пл_общ_строка = пл_общ_строка.ToString("N0");
                                          if (пл_общ_строка !="")
                                              итог_рас_пл_общ += Convert.ToInt32(пл_общ_строка);
                      */
                    итог_кол_зап += 1;
                }
            }
            this.c1TrueDBGrid_зат_рас_дом.Columns["с_сумма"].FooterText = итог_рас_сум.ToString("N0");
            this.c1TrueDBGrid_зат_рас_дом.Columns["с_кол"].FooterText = итог_рас_кол.ToString("N2");

            this.c1TrueDBGrid_зат_рас_дом.Columns["Адрес"].FooterText = итог_кол_зап.ToString("N0");

            this.c1TrueDBGrid_зат_рас_ули_итог.Columns["с_сумма"].FooterText = итог_рас_сум.ToString("N0");
            this.c1TrueDBGrid_зат_рас_ули_итог.Columns["с_кол"].FooterText = итог_рас_кол.ToString("N2");

            this.c1TrueDBGrid_зат_рас_ули_итог.Columns["мат_имя"].FooterText = итог_кол_зап.ToString("N0");


        }

        private void ribbonButton_итог_рас_Click(object sender, EventArgs e)
        {
            итоги_рас();
        }

        private void ribbonButton_рас_груп_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_рас_дом_итог.CollapseGroupRow(-1);
            this.c1TrueDBGrid_зат_рас_ули_итог.CollapseGroupRow(-1);
        }
        private void ribbonButton_рас_груп_нет_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_рас_дом_итог.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_зат_рас_ули_итог.ExpandGroupRow(-1, true);
        }
        private void ribbonButton_записать_рас_Click_1(object sender, EventArgs e)
        {
            записать_зат_рас_дом();
        }

        private void ribbonButton_печатать_рас_Click(object sender, EventArgs e)
        {
            c1TrueDBGrid_зат_рас_дом.PrintInfo.PrintPreview();
        }

        // Лента --  период 
        //
        private void ribbonButton_период_Click(object sender, EventArgs e)
        {
            д_год = (int)ribbonNumericBox_период_год.Value;
            д_мес = (int)ribbonNumericBox_период_мес.Value;
            /* было - сделал VS
            DumkaDataSetTableAdapters.QueriesTableAdapter ми;
            ми = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            д_мес_имя = ми.фс_месяц_имя(д_мес);
            */

            д_мес_имя = месяц_имя(д_мес);

            ribbonLabel_период.Text =
                Convert.ToString(д_мес_имя) + " " +
                Convert.ToString(д_год) + " г.";

            заполнить_зат_выд_ВСЕ_таблицы();

            // это период - ненадо
        }

        // Лента --  Выделение затрат
        //
        private void ribbonButton_выд_добавить_период_Click(object sender, EventArgs e)
        {
            //если ЗАВИСАЕТ   ->  св-ва сервера время ожидания = 0 !!!
            if (MessageBox.Show("Вы действительно хотите добавить новые затраты \n\nза текущий период?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter зд;
                зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                зд.зат_выд_доб_зап_бух_период(д_год, д_мес);

                заполнить_зат_выд_ВСЕ_таблицы();

                MessageBox.Show("Добавление новых затрат за текущий период \n\nЗавершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ribbonButton_выд_добавить_ВСЕ_Click(object sender, EventArgs e)
        {
            // ЗАВИСАЕТ   ->  св-ва сервера время ожидания = 0 !!!
            if (MessageBox.Show("Вы действительно хотите добавить новые затраты \n\nза за ВСЕ периоды выбранного года?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter зд;
                зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                зд.зат_выд_доб_зап_бух_все(д_год);

                заполнить_зат_выд_ВСЕ_таблицы();

                MessageBox.Show("Добавление новых затрат за за ВСЕ периоды выбранного года \n\nЗавершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ribbonButton_выд_удалить_тек_Click(object sender, EventArgs e)
        {
            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            if (MessageBox.Show("Вы действительно хотите удалить затрату? \n \n" + зат_выд_имя_диалог, "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter зд;
                зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                зд.Зат_рас_удал_код(зат_выд_код);
                зд.Зат_выд_удал_код(зат_выд_код);

                заполнить_зат_выд_ВСЕ_таблицы();

                MessageBox.Show("Затрата удалена! \n \n" + зат_выд_имя_диалог, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void ribbonButton_выд_удалить_все_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить ВСЕ затраты? \n\nза текущий период?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter зд;
                зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();

                зд.Зат_выд_удал_год_мес(д_год, д_мес);

                заполнить_зат_выд_ВСЕ_таблицы();

                MessageBox.Show("ВСЕ Затраты за текущий период удалены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ribbonButton_выд_обновить_Click(object sender, EventArgs e)
        {

            DumkaDataSetTableAdapters.QueriesTableAdapter зд;
            зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();

            зд.зат_выд_обновить_затрату(зат_выд_код);

            заполнить_зат_выд_ВСЕ_таблицы();

            MessageBox.Show("Сумма затраты из данных бух. учета \n\nОбновленна!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ribbonButton_выд_Обновить_итоги_Click(object sender, EventArgs e)
        {
            заполнить_зат_выд_ВСЕ_таблицы();


        }
        private void ribbonButton_выд_группы_свернуть_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_выд_пер.CollapseGroupRow(-1);
            this.c1TrueDBGrid_зат_выд_все.CollapseGroupRow(-1);
        }
        private void ribbonButton_выд_группы_развернуть_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_выд_пер.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_зат_выд_все.ExpandGroupRow(-1, true);
        }
        private void ribbonToggleButton_выд_показать_список_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_выд_показать_список.Pressed == true)
            {

                if (MessageBox.Show("Вы действительно хотите выбрать записи \n\nтолько с алгоритом СПИСОК ?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ribbonToggleButton_выд_показать_пл_общ.Pressed = false;

                    показать_только_выд = "спи";
                    заполнить_зат_выд_ВСЕ_таблицы();

                }
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите ОТМЕНИТЬ выбор записей \n\nтолько с алгоритом СПИСОК ?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    показать_только_выд = "";
                    заполнить_зат_выд_все();
                    заполнить_зат_выд_пер();
                }
            }
        }
        private void ribbonToggleButton_выд_показать_пл_общ_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_выд_показать_пл_общ.Pressed == true)
            {
                if (MessageBox.Show("Вы действительно хотите выбрать записи \n\nтолько с алгоритом по Площади общей ?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ribbonToggleButton_выд_показать_список.Pressed = false;

                    показать_только_выд = "пло";
                    заполнить_зат_выд_ВСЕ_таблицы();

                }

            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите ОТМЕНИТЬ выбор записей \n\nтолько с алгоритом по Площади общей ?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    показать_только_выд = "";
                    заполнить_зат_выд_ВСЕ_таблицы();

                }
                else
                    ribbonToggleButton_выд_показать_пл_общ.Pressed = true;
            }
        }

        // Лента --  Распределение
        // 



        private void распределить_затрату(string алг, string стр_1, string стр_2)
        { // общая для всех процедур распределения

            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            int зат_выд_код_сохранить = зат_выд_код;

            DumkaDataSetTableAdapters.QueriesTableAdapter зв;
            зв = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            // зв.Зат_дом_ген(зат_выд_код);

            switch (алг)
            {
                case "пло":
                    зв.зат_Выд_зат_Рас(зат_выд_код);
                    break;

                case "пло_все":
                    зв.зат_выд_зат_рас_ВСЕ_только_площадь_за_мес(д_год, д_мес);
                    break;

                case "авто":
                    зв.зат_выд_зат_рас_ВСЕ_АВТО_за_мес(д_год, д_мес);
                    break;

                case "изв":
                    зв.зат_Выд_зат_Рас_2_площади_изв(зат_выд_код);
                    break;


                case "спи":
                    зв.зат_Выд_зат_Рас_пусто(зат_выд_код);
                    break;

                case "тмц":
                    зв.зат_выд_зат_рас_ТМЦ_зат_выд_код(зат_выд_код);
                    // было  зв.зат_рас_доб_зап_мат(д_год, д_мес);

                    break;
                case "ост_сущ":
                    зв.зат_Выд_зат_Рас_остаток_на_сущ_записи(зат_выд_код);
                    break;
                case "уда_рас_все":
                    зв.Зат_рас_удал_код(зат_выд_код);
                    break;
                case "уда_рас_пло":
                    зв.Зат_рас_удал_код_только_площадь(зат_выд_код);
                    break;

                case "пло_общежитий":
                    зв.зат_Выд_зат_Рас_дом_общежития(зат_выд_код);
                    break;

                case "пло_лифты":
                    зв.зат_Выд_зат_Рас_дом_Лифты(зат_выд_код);
                    break;

                case "пло_мат":
                    зв.зат_Выд_зат_Рас_дом_тмц_были_мат(зат_выд_код);
                    break;
 
           
                case "спи_восстановить":
                    зв.Зат_рас_список_восстановить(зат_выд_код);
                    break;

                default:
                    MessageBox.Show("Ошибка в  передаче параметра процедуре РАСПРЕДЕЛИТЬ_ЗАТРАТУ", "Ошибка МАГ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            заполнить_зат_выд_ВСЕ_таблицы();

            зат_выд_код = зат_выд_код_сохранить;
            заполнить_зат_рас_дом();

            MessageBox.Show(стр_1 + "\n" + стр_2 + "\nВыполненно!\n\n" + зат_выд_имя_диалог, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ribbonButton_рас_по_общ_пл_Click(object sender, EventArgs e)
        {
            распределить_затрату("пло", "Распределение затраты по Общей Площади ВСЕХ домов", "");
        }

        private void ribbonButton_ribbonButton_рас_извещение_Click(object sender, EventArgs e)
        {
            распределить_затрату("изв", "Распределение затраты пропорцианально придомовой и внутри домовой площади ВСЕХ домов", "");
        }
        private void ribbonButton_Пересчет_Распределения_Click(object sender, EventArgs e)
        {
            распределить_затрату("пло_все", "Пересчет Распределения затраты пропорцианально общей площади домов", "в случае изменения площади домов.");
        }
        private void ribbonButton_Авто_весь_месяц_Click(object sender, EventArgs e)
        {

            распределить_затрату("авто", "Атоматическое распределене затрат за выбранный период по алгоритмам из настроечной таблицы.", "Выполненно!");
        }
        private void ribbonButton_рас_список_создать_Click(object sender, EventArgs e)
        {
            распределить_затрату("спи", "Список домов для распределения затраты", "");
        }
        private void ribbonButton_рас_принять_ТМЦ_Click(object sender, EventArgs e)
        {
            распределить_затрату("тмц", "Распределение затраты по данным из учета ТМЦ", "");
        }
        private void ribbonButton_рас_список_ост_Click(object sender, EventArgs e)
        {
            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            DumkaDataSetTableAdapters.QueriesTableAdapter сс;
            сс = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            сс.зат_Выд_зат_Рас_остаток(зат_выд_код);
            заполнить_зат_рас_дом();

            MessageBox.Show("Остаток распределен! \n\n" + зат_выд_имя_диалог, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ribbonButton_рас_список_сохранить_Click(object sender, EventArgs e)
        {
            записать_зат_рас_дом();
        }
        private void ribbonButton_рас_список_восстановить_Click(object sender, EventArgs e)
        {
            распределить_затрату("спи_восстановить", "Список распределения ", "Восстановленн!");
        }

        private void ribbonButton_рас_по_общ_пл_Общежития_Click(object sender, EventArgs e)
        {
            распределить_затрату("пло_общежитий", "Распределение затраты по Общей Площади", "только ОБЩЕЖИТИЙ");

        }

        private void ribbonButton_рас_по_общ_пл_Лифты_Click(object sender, EventArgs e)
        {
            распределить_затрату("пло_лифты", "Распределение остатка затраты по Общей Площади", "только по домам где есть Лифты");
        }
        private void ribbonButton_рас_Дублиров_периода_Click(object sender, EventArgs e)
        {
            //  int д_год_дуб, д_мес_дуб;

            /*  пока без формы берем 01 2012 (предыдущий   
             * //Запуск формы           
               запрос_периода зп = new запрос_периода();
               зп.Visible = true;
               зп.Activate();
            */

            распределить_затрату("дубль_пер", "Дублирование распределения затраты по данным из прошлого периода", "( январь 2012 ) ");
        }
        private void ribbonButton_рас_по_общ_пл_Материалы_Click(object sender, EventArgs e)
        {
            распределить_затрату("пло_мат", "Распределение затраты по Общей Площади", "но только по тем домам где был расход материалов. ");
        }
              
        private void ribbonButton_рас_остаток_список_по_записям_списка_Click(object sender, EventArgs e)
        {
            распределить_затрату("ост_сущ", "Распределение остатка затраты (от суммы по списку)", "по Общей Площади домов входящих в список распределения");
        }
        private void ribbonButton_Удалить_распределение_Click(object sender, EventArgs e)
        {
            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            if (MessageBox.Show("Вы действительно хотите удалить распределение по всей затрате всех алгоритмов распределения? \n \n" + зат_выд_имя_диалог, "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                распределить_затрату("уда_рас_все", "Удаление записей распределения ", "по всей затрате всех алгоритмов распределения");
            }
        }
        private void ribbonButton_удалить_только_рас_пл_общ_Click(object sender, EventArgs e)
        {
            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            if (MessageBox.Show("Вы действительно хотите удалить распределение по алгоритуму по Общей Площади домов? \n \n" + зат_выд_имя_диалог, "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                распределить_затрату("уда_рас_пло", "Удаление записей распределения по алгоритуму", "по Общей Площади домов");
            }
        }
        private void ribbonButton_рас_печатать_Click_1(object sender, EventArgs e)
        {
            c1TrueDBGrid_зат_рас_дом.PrintInfo.PrintPreview();
        }
        private void ribbonButton__рас_Excell_Click(object sender, EventArgs e)
        {
            // create export filter
            string имя_файла = System.Windows.Forms.Application.StartupPath + @"\Распред_.xls";

            c1TrueDBGrid_зат_рас_дом.ExportToExcel(имя_файла);

            System.Diagnostics.Process.Start(имя_файла);
        }
        private void ribbonToggleButton_рас_показать_список_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_рас_показать_список.Pressed == true)
            {
                //ribbonToggleButton_рас_показать_список.Pressed = false;
                ribbonToggleButton_рас_показать_пл_общ.Pressed = false;
                ribbonToggleButton_рас_показать_пусто.Pressed = false;
                ribbonToggleButton_рас_показать_общежития.Pressed = false;
                ribbonToggleButton_рас_показать_лифты.Pressed = false;

                показать_только_рас = "спи";
                заполнить_зат_рас_дом();
            }
            else
            {
                показать_только_рас = "";
                заполнить_зат_рас_дом();
            }
        }
        private void ribbonToggleButton_рас_показать_пл_общ_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_рас_показать_пл_общ.Pressed == true)
            {

                ribbonToggleButton_рас_показать_список.Pressed = false;
                //ribbonToggleButton_рас_показать_пл_общ.Pressed = false;
                ribbonToggleButton_рас_показать_пусто.Pressed = false;
                ribbonToggleButton_рас_показать_общежития.Pressed = false;
                ribbonToggleButton_рас_показать_лифты.Pressed = false;

                показать_только_рас = "пло";
                заполнить_зат_рас_дом();
            }
            else
            {
                показать_только_рас = "";
                заполнить_зат_рас_дом();
            }
        }
        private void ribbonToggleButton_рас_показать_пусто_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_рас_показать_пусто.Pressed == true)
            {
                ribbonToggleButton_рас_показать_список.Pressed = false;
                ribbonToggleButton_рас_показать_пл_общ.Pressed = false;
                //ribbonToggleButton_рас_показать_пусто.Pressed = false;
                ribbonToggleButton_рас_показать_общежития.Pressed = false;
                ribbonToggleButton_рас_показать_лифты.Pressed = false;

                показать_только_рас = "пус";
                заполнить_зат_рас_дом();
            }
            else
            {
                показать_только_рас = "";
                заполнить_зат_рас_дом();
            }
        }
        private void ribbonToggleButton_рас_показать_общежития_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_рас_показать_общежития.Pressed == true)
            {
                ribbonToggleButton_рас_показать_список.Pressed = false;
                ribbonToggleButton_рас_показать_пл_общ.Pressed = false;
                ribbonToggleButton_рас_показать_пусто.Pressed = false;
                //ribbonToggleButton_рас_показать_общежития.Pressed = false;
                ribbonToggleButton_рас_показать_лифты.Pressed = false;

                показать_только_рас = "общ";
                заполнить_зат_рас_дом();
            }
            else
            {
                показать_только_рас = "";
                заполнить_зат_рас_дом();
            }
        }
        private void ribbonToggleButton_рас_показать_лифты_Click(object sender, EventArgs e)
        {
            if (ribbonToggleButton_рас_показать_лифты.Pressed == true)
            {
                ribbonToggleButton_рас_показать_список.Pressed = false;
                ribbonToggleButton_рас_показать_пл_общ.Pressed = false;
                ribbonToggleButton_рас_показать_пусто.Pressed = false;
                ribbonToggleButton_рас_показать_общежития.Pressed = false;
                //ribbonToggleButton_рас_показать_лифты.Pressed = false;

                показать_только_рас = "лиф";
                заполнить_зат_рас_дом();
            }
            else
            {
                показать_только_рас = "";
                заполнить_зат_рас_дом();
            }
        }

        private void ribbonButton1_рас_группы_свернуть_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_рас_дом_итог.CollapseGroupRow(-1);
            this.c1TrueDBGrid_зат_рас_ули_итог.CollapseGroupRow(-1);
        }
        private void ribbonButton1_рас_группы_развернуть_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid_зат_рас_дом_итог.ExpandGroupRow(-1, true);
            this.c1TrueDBGrid_зат_рас_ули_итог.ExpandGroupRow(-1, true);
        }

        /* private void ribbonButton_записать_рас_дом_Click(object sender, EventArgs e)
        {
            string зат_выд_имя_диалог = "( " + зат_выд_имя + " )";
            записать_зат_рас_дом();
            MessageBox.Show("Сохранены изменения! \n\n" + зат_выд_имя_диалог, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
          */
        private void ribbonButton_Копирование_Базы_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Выполнить копирование Базы Данных ?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            // {
            DumkaDataSetTableAdapters.QueriesTableAdapter сс;
            сс = new DumkaDataSetTableAdapters.QueriesTableAdapter();
            сс.обсл_копия_с_датой_Dumka();
            MessageBox.Show("Копирование Базы Данных \n\nЗавершено!!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
        }
        private void ribbonButton_Дом_месяц_затраты_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Отчеты.Дом_зат од = new Отчеты.Дом_зат();
            од.Visible = true;
            од.Activate();
        }

        private void c1DockingTab_зат_выд_SelectedIndexChanged(object sender, EventArgs e)
        {
            закладка_выд = Convert.ToInt16(this.c1DockingTab_зат_выд.SelectedIndex);
        }

        private void ribbonButton_рас_печатать_Click(object sender, EventArgs e)
        {
            c1TrueDBGrid_зат_рас_дом.PrintInfo.PrintPreview();
        }


        // Запуск форм 
        private void ribbonButton_дом_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.Дома нд = new Настройка.Дома();
            нд.Visible = true;
            нд.Activate();
        }
        private void ribbonButton_Дома_для_Экономистов_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.Дома_для_Экономистов нд = new Настройка.Дома_для_Экономистов();
            нд.Visible = true;
            нд.Activate();
        }

        private void ribbonButton_Дома_все_мес_Click(object sender, EventArgs e)
        {
            Настройка.Дома_все_мес дм = new Настройка.Дома_все_мес();
            дм.Visible = true;
            дм.Activate();
        }

        private void ribbonButton_списки_изм_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.Списки_изм си = new Настройка.Списки_изм();
            си.Visible = true;
            си.Activate();
        }
        private void ribbonButton_изм_ан_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.Извещения иа = new Настройка.Извещения();
            иа.Visible = true;
            иа.Activate();
        }
        private void ribbonButton_изм_сч_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.изм_сч ис = new Настройка.изм_сч();
            ис.Visible = true;
            ис.Activate();
        }
        private void ribbonApplicationMenu1_DoubleClick(object sender, EventArgs e)
        {
            //Запуск формы           
            О_программе оп = new О_программе();
            оп.Visible = true;
            оп.Activate();
        }
        private void ribbonButton_печатать_Click(object sender, EventArgs e)
        {
            c1TrueDBGrid_зат_выд_пер.PrintInfo.PrintPreview();
        }
        private void ribbonButton_excel_Click(object sender, EventArgs e)
        {
            // create export filter
            string имя_файла = System.Windows.Forms.Application.StartupPath + @"\Затраты_.xls";

            c1TrueDBGrid_зат_выд_пер.ExportToExcel(имя_файла);

            System.Diagnostics.Process.Start(имя_файла);
        }
        private void ribbonButton_Обновить_Мат_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выполнить обновление данных из Учет ТМЦ ?", "Подтверждение. ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DumkaDataSetTableAdapters.QueriesTableAdapter зм;
                    зм = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                    зм.Запуск_DTS_Мат();

                    MessageBox.Show("Обновление данных из Учет ТМЦ \n\nЗавершено !!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ош_зм)
                {

                    MessageBox.Show("Обновление данных из Учет ТМЦ \n\nЗавершено с ошибкой !! \n\n " + ош_зм, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void ribbonButton_Обновить_бух_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выполнить обновление данных из Сводного учета ?", "Подтверждение. ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DumkaDataSetTableAdapters.QueriesTableAdapter зб;
                    зб = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                    зб.Запуск_DTS_Бух();

                    MessageBox.Show("Обновление данных из Сводного учета  \n\nЗавершено !!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ош_зм)
                {

                    MessageBox.Show("Обновление данных из  Сводного учета  \n\nЗавершено с ошибкой !! \n\n " + ош_зм, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void ribbonButton_Отчеты_Click(object sender, EventArgs e)
        {

            //Запуск формы           
            Отчеты.Дом_зат од = new Отчеты.Дом_зат();
            од.Visible = true;
            од.Activate();
        }
        private void ribbonButton_добавить_счета_аналитики_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выполнить обновление Счетов и Аналитик из Сводного учета и Учет ТМЦ ?", "Подтверждение. ",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DumkaDataSetTableAdapters.QueriesTableAdapter зм;
                    зм = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                    зм.изм_ан_сч_доб_зап_все();

                    MessageBox.Show("Обновление Счетов и Аналитик из Сводного учета и Учет ТМЦ \n\nЗавершено !!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ош_зм)
                {

                    MessageBox.Show("Обновление Счетов и Аналитик из Сводного учета и Учет ТМЦ \n\nЗавершено с ошибкой !! \n\n " + ош_зм, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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

        

        private void ribbonButton_Выгрузка_Комплат_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выгрузить данные для Извещений в файл обмена с КОМПЛАТ \n\nза текущий период?", "Подтверждение. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter зд;
                зд = new DumkaDataSetTableAdapters.QueriesTableAdapter();
               //  зд.зат_рас_Извещение_Комплат(д_год, д_мес);
                   зд.зат_рас_Извещение_2014_Комплат(д_год, д_мес);

            //    System.IO.File.Copy(@"D:\Dumka\dtsx\ACT_COST_zap.DBF", @"D:\Dumka\Komplat\ACT_COST.DBF", true);
            //    System.IO.File.Copy(@"d:\Dumka\Komplat\ACT_COST\ACT_COST.DBF", @"D:\Dumka\Komplat\ACT_COST.DBF", true);

            //    Запуск_Пакета(@"D:\Dumka\dtsx\Сло_КомПлат_ACT_COST_выгрузка.dtsx");
                  Запуск_Пакета(@"D:\Dumka\dtsx\Сло_КомПлат_выгрузка_2016_полная.dtsx");
                
                // TOddmmyyyy.txt (ddmmyyyy – операционная дата).
                
                string дата_файла = DateTime.Today.Date.ToString();
                дата_файла = дата_файла.Substring(0,10);
                дата_файла = дата_файла.Replace(".", "");
                
                string имя_файла = @"TO" + дата_файла + ".txt";
             
               System.IO.File.Copy(@"d:\Dumka\Komplat\TOddmmyyyy.txt", @"d:\Dumka\Komplat\"+ имя_файла, true);
                                
                MessageBox.Show("Файл обмена для КОМПЛАТ за текущий период \n\nСформирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void копирование_файлов_директорий()
        {
            string директорий = @"D:\Dumka\Komplat\";
            string мес_00;

            if (д_мес < 10)
                мес_00 = "0" + д_мес.ToString();
            else
                мес_00 = д_мес.ToString();

            string период = д_год.ToString() + мес_00;

            string директорий_исходный = директорий + период;
            string директорий_целевой = директорий + "000000";

            if (!System.IO.Directory.Exists(директорий_целевой))
            {
                System.IO.Directory.CreateDirectory(директорий_целевой);
            }
            string файл_исходный;
            string файл_целевой;

            string[] файлы = { "LS.DBF", "DOM.DBF", "LS_USL.DBF" };

            int строка = 0;
            for (строка = 0; строка <= 2; строка++)
            {
                файл_исходный = System.IO.Path.Combine(директорий_исходный, файлы[строка]);
                файл_целевой = System.IO.Path.Combine(директорий_целевой, файлы[строка]);

                try
                {
                    System.IO.File.Copy(файл_исходный, файл_целевой, true);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Нет файла " + файл_исходный + " в директории " + файл_целевой + "\n\n" + ee, "Ошибка при копировании", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // throw;
                }
            }
        }
        private void Запуск_Пакета(string пакет_имя)
        {
            //Сло_КомПлат_3_табл.dtsx
            string пакет_директорий = @"D:\Dumka\dtsx\";

            string пакет_дир_файл;
            Package pkg;
            Microsoft.SqlServer.Dts.Runtime.Application app;

            DTSExecResult pkgResults;

            MyEventListener eventListener = new MyEventListener();

            пакет_дир_файл = System.IO.Path.Combine(пакет_директорий, пакет_имя);

            app = new Microsoft.SqlServer.Dts.Runtime.Application();
            //pkg = app.LoadPackage(pkgLocation, null);
            pkg = app.LoadPackage(пакет_дир_файл, eventListener);
            pkgResults = pkg.Execute(null, null, eventListener, null, null);
            
        }
        private void дом_мес_добавить_период()
        {
            try
            {
                DumkaDataSetTableAdapters.QueriesTableAdapter дг;
                дг = new DumkaDataSetTableAdapters.QueriesTableAdapter();
                дг.дом_мес_добавить_период_(д_год, д_мес);

            }
            catch (Exception ош_зм)
            {
                MessageBox.Show("Выполнение  ДОМ_МЕС_ДОБАВИТЬ_ПЕРИОД  \n\n за " + Convert.ToString(д_год) + " год ? \n\nЗавершено с ошибкой !! \n\n " + ош_зм, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
 
        class MyEventListener : DefaultEvents
        {
            public override bool OnError(DtsObject source, int errorCode, string subComponent,
              string description, string helpFile, int helpContext, string idofInterfaceWithError)
            {
                // Add application-specific diagnostics here.
                //   Console.WriteLine("Error in {0}/{1} : {2}", source, subComponent, description);

                MessageBox.Show("Ошибка в :" + source + "\n\n" + subComponent + "\n\n" + description, "Ошибка при выполнении загрузки данных из Комплат");
                return false;
            }
        }

        private void ribbonGroup3_DialogLauncherClick(object sender, EventArgs e)
        {

        }

        private void ribbonButton_Площади_Комплат_Click(object sender, EventArgs e)
        {
            копирование_файлов_директорий();
            try
            {
               
                Запуск_Пакета(@"D:\Dumka\dtsx\Сло_КомПлат_3_табл.dtsx");
                MessageBox.Show("Загрузка домов из Комплат  \n\n за текущий " + Convert.ToString(д_год) + " год " + 
                    Convert.ToString(д_мес) + " мес \n\n" + " завершена! ", "Загрузка домов",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                дом_мес_добавить_период();
            }
            catch (Exception)
            {
                MessageBox.Show("Загрузка домов из Комплат  \n\n за текущий " + Convert.ToString(д_год) + " год " +
                         Convert.ToString(д_мес) + " мес \n\nэ" + "завершена с ошибкой ", "Загрузка домов",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
           
     
                //throw;
            }
        }

        private void ribbonButton_Извещения_Click(object sender, EventArgs e)
        {
            //Запуск формы           
            Настройка.Извещения из = new Настройка.Извещения();
            из.Visible = true;
            из.Activate();
        }

        private void ribbonButton_Извещения_Выд_Click(object sender, EventArgs e)
        {
            //Копия  ribbonButton_Извещения_Click     
            //Запуск формы           
            Настройка.Извещения из = new Настройка.Извещения();
            из.Visible = true;
            из.Activate();
        }

     



        //---- Последняя строка -------------------------

        /*
          // Версия сборки 
            // AssemblyName.GetAssemblyName(Assembly.Load("TableEditor").Location).Version
            // Application.ProductVersion - дает Application.ProductVersion = "1.0.0.0"

            //Assembly: Assembly m_MyAssembly = Assembly.GetExecutingAssembly();

            //   ribbonLabel_версия.Text = Application.ProductVersion;
            ribbonLabel_версия.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
         */




    }
}

