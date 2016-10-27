using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnCallendar
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private List<CheckBox> listcomboBoxs = new List<CheckBox>();
        private List<CheckBox> listTime = new List<CheckBox>();
        private List<CheckBox> parnopar = new List<CheckBox>();

        private void button2_Click(object sender, EventArgs e)
        {
            listcomboBoxs.Clear();
            parnopar.Clear();
            listTime.Clear();

            listcomboBoxs.Add(checkBox1);
            listcomboBoxs.Add(checkBox2);
            listcomboBoxs.Add(checkBox3);
            listcomboBoxs.Add(checkBox4);
            listcomboBoxs.Add(checkBox5);
            listcomboBoxs.Add(checkBox6);
            listcomboBoxs.Add(checkBox7);

            parnopar.Add(checkBox8);
            parnopar.Add(checkBox9);

            listTime.Add(checkBox10);
            listTime.Add(checkBox11);
            listTime.Add(checkBox12);
            listTime.Add(checkBox13);
            listTime.Add(checkBox14);
            listTime.Add(checkBox15);
            listTime.Add(checkBox16);
            listTime.Add(checkBox17);

            string end ="";
            List<string> toFile = new List<string>();
          
            //Понеділок,Парний,8:00-9:20|блаблбла
                //end = textBox2.Text + "/" + textBox1.Text + ",";
                foreach (var checkBox in listcomboBoxs) //week day
                {
                    if (checkBox.Checked == true)
                    {
                        end += checkBox.Text+",";
                       // foreach (CheckBox box in parnopar) //par or not
                        {
                            if (checkBox8.Checked == true)
                            {
                              //  end +=  box.Text + ",";
                                foreach (CheckBox box1 in listTime) //PAR time
                                {
                                    if (box1.Checked == true)
                                    {
                                       // end += box1.Text + ".";
                                        toFile.Add(string.Format("{0},{1},{2}|{3}", checkBox.Text, "Парний", box1.Text, textBox2.Text + "/ " + textBox1.Text));
                                    }

                                }
                            }
                            if (checkBox9.Checked == true)
                            {
                               // end += "," + box.Text + ",.";
                                foreach (var box1 in listTime) //NOT PAR time
                                {
                                    if (box1.Checked == true)
                                    {
                                       // end += box1.Text + ".";
                                        toFile.Add(string.Format("{0},{1},{2}|{3}", checkBox.Text, "Непарний", box1.Text, textBox2.Text + "/ " + textBox1.Text));
                                    }
                                }
                            }
                        }
                        end += "|";
                    }
                }
                
                string path = Application.StartupPath + "\\always.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (var line in toFile)
                    {
                        sw.WriteLine(line);
                    }
                }

                end = "";
        
        }
    }
}
