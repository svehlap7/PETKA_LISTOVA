using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list;
        public void Vypis(List<int> list, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int x in list)
            {
                listBox.Items.Add(x);
            }
        }

        private void Pridej(List<int> list, int x)
        {
            int dife = 0;

            if (list.Count() >= 2)
            {
                int last = list.Last();
                dife = list[1] - list[0];
                last += dife;

                for (int i = 0; i < x; i++)
                {
                    list.Add(last);
                    last += dife;
                }
            }
            else
            {
                MessageBox.Show("NELZE");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list = new List<int>();
            int n = Convert.ToInt32(textBox1.Text);
            int a1 = Convert.ToInt32(textBox2.Text);
            int d = Convert.ToInt32(textBox3.Text);

            for (int i = 0; i < n; i++)
            {
                list.Add(a1);
                a1 += d;
            }
            Vypis(list, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox4.Text);
            Pridej(list, n);
            Vypis(list, listBox1);
        }
    }
}
