using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnCallendar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        BindingList<string> _lines = new BindingList<string>();
        string path = Application.StartupPath + "\\always.txt";
        private void updateTable(string[] name)
        {
            string temp = name[1];
            string temp2 = name[2];
            string[] split = name[3].Split(new char[] { '.' });
            switch (temp)
            {
                case "Понеділок":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "Вівторок":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "Середа":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "Четверг":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "П'ятниця":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "Субота":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;
                case "Неділя":
                    {
                        if (temp2 == "Парний")
                        {

                        }
                        if (temp2 == "Непарний")
                        {

                        }
                    } break;

            }
        }



        private void Main_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ci =
    new System.Globalization.CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            dataGridView1.ColumnCount = 9;

           // dataGridView1.AutoSize = true;
            dataGridView1.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            for (int i = 0; i < 13; i++)
            {
                this.dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Height = 200;
            }

            dataGridView1.Columns[0].Name = "День/Година";

            dataGridView1.Columns[1].Name = "8:00-9:20";
            dataGridView1.Columns[2].Name = "9:35-10:55";
            dataGridView1.Columns[3].Name = "11:10-12:30";
            dataGridView1.Columns[4].Name = "12:50-14:10";
            dataGridView1.Columns[5].Name = "14:25-15:45";
            dataGridView1.Columns[6].Name = "16:00-17:20";
            dataGridView1.Columns[7].Name = "17:35-18:55";
            dataGridView1.Columns[8].Name = "19:10-20:30";

           
         
            /*  this.dataGridView1.Rows[0].Cells[0].Value = "1";
              this.dataGridView1.Rows[0].Cells[2].Value = "Baqar";*/

         


            updatetable();


            // string[] row = new string[] { "Понедельник парний", "Name1 Name2" };
            // dataGridView1.Rows.Add(row);

            /* row = new string[] { "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "" };
             dataGridView1.Rows.Add(row);

             row = new string[] { "08.00-9.20", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "9.35-10.55", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "11.10-12.30", "Група 23", "", "Секція ПЗС-42" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "12.50-14.10", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "14.25-15.45", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "16.00-17.20", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "17.35-18.55", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);
             row = new string[] { "19.10-20.30", "Секція ПЗС-42", "", "Група 23", "" };
             dataGridView1.Rows.Add(row);*/

          //  dataGridView1.AutoSize = true;


        }

        private void updatetable()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
            _lines.Clear();
            dataGridView1.Update();
           // dataGridView1.Rows[1].Cells[1].Value = "";

            this.dataGridView1.Rows[1 - 1].Cells[0].Value = "Понеділок парний";
            this.dataGridView1.Rows[2 - 1].Cells[0].Value = "Понеділок непарний";
            this.dataGridView1.Rows[3 - 1].Cells[0].Value = "Вівторок парний";
            this.dataGridView1.Rows[4 - 1].Cells[0].Value = "Вівторок непарний";
            this.dataGridView1.Rows[5 - 1].Cells[0].Value = "Середа парний";
            this.dataGridView1.Rows[6 - 1].Cells[0].Value = "Середа непарний";
            this.dataGridView1.Rows[7 - 1].Cells[0].Value = "Четверг парний";
            this.dataGridView1.Rows[8 - 1].Cells[0].Value = "Четверг непарний";
            this.dataGridView1.Rows[9 - 1].Cells[0].Value = "П'ятниця парний";
            this.dataGridView1.Rows[10 - 1].Cells[0].Value = "П'ятниця непарний";
            this.dataGridView1.Rows[11 - 1].Cells[0].Value = "Субота парний";
            this.dataGridView1.Rows[12 - 1].Cells[0].Value = "Субота непарний";
            this.dataGridView1.Rows[13 - 1].Cells[0].Value = "Неділя парний";
            this.dataGridView1.Rows[14 - 1].Cells[0].Value = "Неділя непарний";
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    _lines.Add(sr.ReadLine());
                }
            }

            Parse(_lines.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form addForm = new Add();
            addForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            try
            {
                Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
                dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
                e.Graphics.DrawImage(bmp, 0, 0);
            }
            catch (Exception)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin newAdmin = new Admin();
            newAdmin.Show();
        }

        private void Parse(string[] lines)
        {
            var tmp = new List<Cell>();
            foreach (var line in lines)
            {
                tmp.Add(ParseString(line));
            }

            foreach (var cell in tmp)
            {
                if (string.IsNullOrEmpty(dataGridView1.Rows[cell.Row].Cells[cell.Column].Value.ToString()))
                {
                    this.dataGridView1.Rows[cell.Row].Cells[cell.Column].Value = cell.Name;
                }
                else
                {
                    MessageBox.Show("Помилка при обробці данних у стрічці " + cell.Row + " колонці " + cell.Column +
                                    " вже є подія, звертніться до адміністратора для корегуваня графіку");
                }
             
            }
        }

        private Cell ParseString(string line)
        {
            //Понеділок,Парний,8:00-9:20|блаблбла
            var items = line.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            var name = items[1];
            var desc = items[0].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            var item = new Cell();
            item.Name = name;
            switch (desc[2])
            {
                case "8:00-9:20":
                    item.Column = 1;
                    break;
                case "9:35-10:55":
                    item.Column = 2;
                    break;
                case "11:10-12:30":
                    item.Column = 3;
                    break;
                case "12:50-14:10":
                    item.Column = 4;
                    break;
                case "14:25-15:45":
                    item.Column = 5;
                    break;
                case "16:00-17:20":
                    item.Column = 6;
                    break;
                case "17:35-18:55":
                    item.Column = 7;
                    break;
                case "19:10-20:30":
                    item.Column = 8;
                    break;
            }
            switch (desc[0])
            {
                case "Понеділок": item.Row = (!desc[1].Contains("е")) ? 1 : 2;
                    break;
                case "Вівторок": item.Row = (!desc[1].Contains("е")) ? 3 : 4;
                    break;
                case "Середа": item.Row = (!desc[1].Contains("е")) ? 5 : 6;
                    break;
                case "Четверг": item.Row = (!desc[1].Contains("е")) ? 7 : 8;
                    break;
                case "П'ятниця": item.Row = (!desc[1].Contains("е")) ? 9 : 10;
                    break;
                case "Субота": item.Row = (!desc[1].Contains("е")) ? 11 : 12;
                    break;
                case "Неділя": item.Row = (!desc[1].Contains('е')) ? 13 : 14;
                    break;

            }

            item.Row -= 1;
            return item;
        }

        public class Cell
        {
            public int Row;
            public int Column;
            public string Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            updatetable();
        }
    }
}
