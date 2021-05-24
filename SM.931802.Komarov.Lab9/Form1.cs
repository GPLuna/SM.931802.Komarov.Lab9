using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM._931802.Komarov.Lab9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Statistic_count SC = new Statistic_count();
       
        private void StartButton_Click(object sender, EventArgs e)
        {
            if ((prob1.Value + prob2.Value + prob3.Value + prob4.Value) > 1) state.Text = "Invalid probs";
            else
            {
                state.Text = "Success";
                SC.SetData((int)Number.Value, prob1.Value, prob2.Value, prob3.Value, prob4.Value);
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series[0].Points.Clear();
                decimal[] pointsXY = SC.GetData();
                for (int i = 0; i < pointsXY.Length; i++)
                {
                    
                    chart1.Series[0].Points.AddXY(i + 1, pointsXY[i]);
                }
                prob5.Text = Convert.ToString(1 - (prob1.Value + prob2.Value + prob3.Value + prob4.Value));
            }
            
        }
        public class Statistic_count
        {
            Random r = new Random();
            int N;
            int[] stat;
            decimal[] prob;
            public void SetData(int N, params decimal[] m)
            {
                prob = new decimal[m.Length + 1];
                this.N = N;
                stat = new int[m.Length + 1];
                stat[m.Length] = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    prob[i] = m[i];
                    stat[i] = 0;
                }
                prob[m.Length] = 1 - prob[0] - prob[1] - prob[2] - prob[3];
            }
            public decimal[] GetData()
            {
                decimal A;
                int k = -1;
                decimal[] freq = new decimal[stat.Length];
                for (int i = 0; i < N; i++)
                {
                    A = (decimal)r.NextDouble();
                    for (k = -1; A > 0; k++)
                    {
                        A -= prob[k + 1];
                    }
                    stat[k]++;
                }
                for (int i = 0; i < stat.Length; i++)
                {
                    freq[i] = (decimal)stat[i] / N;
                }
                return freq;
            }
        }
    }
}
