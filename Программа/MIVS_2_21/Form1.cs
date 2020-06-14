using System;
using System.Windows.Forms;
namespace MIVS_2_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox_X.Items.Clear();
            listBox_P.Items.Clear();
            int zz = -1;
            if (int.TryParse(textBox_N.Text, out int n) == false)
            {
                MessageBox.Show("Проверьте правильность ввода числа N");
                zz = 1;
            }
            if (double.TryParse(textBox_Q.Text, out double q) == false)
            {
                MessageBox.Show("Проверьте правильность ввода числа Q");
                zz = 1;
            }
            if (double.TryParse(textBox_P1.Text, out double p1) == false)
            {
                MessageBox.Show("Проверьте правильность ввода числа P1");
                zz = 1;
            }
            if (double.TryParse(textBox_Del.Text, out double delta) == false)
            {
                MessageBox.Show("Проверьте правильность ввода числа Del");
                zz = 1;
            }
            if (zz == -1)
            {
                int l = 5;

                double sum = 0;
                for (int i = 0; i < l; i++) sum += i;
                double pp = (p1 * l - 1) / sum;

                double[] mas_sv = new double[n];
                double[] ends = new double[l + 1];
                double[] x = new double[l];
                double[] p = new double[l];

                for (int k = 0; k < l; k++)
                {
                    p[k] = p1 - (k) * pp;
                    p[k] = Math.Round(p[k], 2);
                    listBox_P.Items.Add(p[k]);
                }
                ends[0] = 0;
                for (int k = 1; k < l + 1; k++)
                {
                    ends[k] = ends[k - 1] + p[k - 1];
                }
                for (int k = 0; k < l; k++)
                {
                    x[k] = q + (k) * delta;
                    listBox_X.Items.Add(x[k]);
                }
                int s = 0;
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    mas_sv[i] = r.NextDouble();
                    for (int j = 0; j < l; j++)
                    {
                        if (mas_sv[i] >= ends[j] && ends[j + 1] > mas_sv[i])
                        {
                            mas_sv[i] = x[j];
                            s++;
                            break;
                        }
                    }
                }
                double avg = 0;

                for (int i = 0; i < n; i++)
                {
                    avg += mas_sv[i];
                }
                avg = Math.Round(avg / n, 2);
                label_avg.Text = "Среднее t: " + (avg).ToString();

                listBox_V.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    listBox_V.Items.Add(i + 1 + ") " + mas_sv[i]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_N.Text = "1000";
            textBox_Q.Text = "7,5";
            textBox_P1.Text = "0,22";
            textBox_Del.Text = "11";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_N.Text = "1000";
            textBox_P1.Text = "0,26";
            textBox_Del.Text = "8";
            textBox_Q.Text = "5";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox_N.Text = "1000";
            textBox_P1.Text = "0,30";
            textBox_Del.Text = "5";
            textBox_Q.Text = "3,8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_N.Text = "1000";
            textBox_P1.Text = "0,34";
            textBox_Del.Text = "7";
            textBox_Q.Text = "5";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox_N.Text = "1000";
            textBox_P1.Text = "0,38";
            textBox_Del.Text = "2,5";
            textBox_Q.Text = "1,5";
        }
    }
}
