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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        BindingList<string> _lines = new BindingList<string>();
        string path = Application.StartupPath + "\\always.txt";
        private void Admin_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = _lines;
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    _lines.Add(sr.ReadLine());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0) { MessageBox.Show("Оберіть спочатку лінію для видалення", "Попередження"); }
            else
            {

                int selectedIndex = listBox1.SelectedIndex;
                _lines.RemoveAt(selectedIndex);
                //  ignoreSelectedIndexChanged = true;
                listBox1.DataSource = _lines;
                listBox1.SelectedIndex = -1;
                // ignoreSelectedIndexChanged = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sPath = path;
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.Close();
            MessageBox.Show("Збережено");
        }
    }
}
