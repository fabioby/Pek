using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static List<Pekaru> list_pekaru = new List<Pekaru>();
        private static List<Pekseg> list_pekseg = new List<Pekseg>();

        private void button_pekaru_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text.Length == 0 || textBox_price.Text.Length == 0)
            {
                MessageBox.Show("Tölts ki mindne mezőt!");
            } else
            {
                if(checkBox1.Checked == true)
                {
                    var pekaru = new Pekaru(textBox_name.Text, Convert.ToInt32(textBox_price.Text), true);
                    list_pekaru.Add(pekaru);
                    listBox_pekaru.Items.Add(pekaru);
                }
                else
                {
                    listBox_pekaru.Items.Add(new Pekaru(textBox_name.Text, Convert.ToInt32(textBox_price.Text), false));
                }
            }
        }
        private void button_pekseg_Click(object sender, EventArgs e)
        {
            if (textBox_pekseg.Text.Length == 0)
            {
                MessageBox.Show("Tölts ki mindne mezőt!");
            } else
            {
                var pekseg = new Pekseg(textBox_pekseg.Text);
                listBox_pekseg.Items.Add(pekseg);
                listBox_statistic.Items.Add(pekseg);
                list_pekseg.Add(pekseg);

            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (listBox_pekaru.Items.Count + listBox_pekseg.Items.Count > 1)
            {
                var pekaru = listBox_pekaru.SelectedItem as Pekaru;
                var pekseg = listBox_pekseg.SelectedItem as Pekseg;

                listBox_termekek.Items.Add(pekaru);
                pekseg.Termekek.Add(pekaru);
            }
        }

        private void listBox_pekseg_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox_termekek.Items.Clear();
            var pekseg = listBox_pekseg.SelectedItem as Pekseg;

            if (pekseg.Termekek.Count > 0)
            {
                foreach (var item in pekseg.Termekek)
                {
                    listBox_termekek.Items.Add(item);
                }
            }
        }

        private void listBox_statistic_SelectedValueChanged(object sender, EventArgs e)
        {
            var pekseg = listBox_statistic.SelectedItem as Pekseg;

            label_name.Text = pekseg.Nev;
            label_date.Text = ""+pekseg.Alapitva;
            label_count.Text = "Pékáruk: " + pekseg.Termekek.Count + " db";
            label_avg.Text = "Átlagos ár:";
            label_min.Text = "Legolcsóbb termék:";
            label_max.Text = "Legdrágább termék:";
            label_bool.Text = "Laktózmentes termékek:";

            if (pekseg.Termekek.Count > 0)
            {
                int avg = 0;
                int laktozmentes = 0;
                Pekaru min = pekseg.Termekek[0];
                Pekaru max = pekseg.Termekek[0];

                foreach (var item in pekseg.Termekek)
                {
                    if (item.Ar < min.Ar)
                    {
                        min = item;
                    }
                    if (item.Ar > max.Ar)
                    {
                        max = item;
                    }

                    if(item.Laktozmentese == true)
                    {
                        laktozmentes++;
                    }

                    avg += item.Ar;
                }

                label_avg.Text = String.Format("Átlagos ár: {0} Ft", avg / pekseg.Termekek.Count);
                label_min.Text = String.Format("Legolcsóbb termék: {0} ({1} Ft / db)", min, min.Ar);
                label_max.Text = String.Format("Legdrágább termék: {0} ({1} Ft / db)", max, max.Ar);
                label_bool.Text = String.Format("Laktózmentes termékek: {0} db, {1}%", laktozmentes, laktozmentes / pekseg.Termekek.Count * 100);
            }
        }
    }
}
