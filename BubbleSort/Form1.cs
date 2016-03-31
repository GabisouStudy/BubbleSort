using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BubbleSort
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        private int[] RandomArray(int size)
        {
            int[] array = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                array[i] = (r.Next(0, 200));
            return array;
        }

        private void UpdateChart(Chart c, int[] a, int c1, int c2) {
            Chart chart = c;
            int[] array = a;
            chart.Series.Clear();
            Series series = chart.Series.Add("");
            chart.Series[0]["PointWidth"] = "0.5";
            for (int i = 0; i < array.Length; i++)
            {
                chart.Series[0].Points.Add(array[i]);
            }
            if (c1 != c2) {

                chart1.Series[0].Points[c1].Color = Color.Red;
                chart1.Series[0].Points[c2].Color = Color.Red;
            }
        }

        int[] values1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("BubbleSort");

            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));

            UpdateChart(chart1, values1, 0, 0);

            //Series series = chart.Series.Add("");
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < values1.Length - 1; i++)
            {
                for (int j = i + 1; j < values1.Length; j++)
                {
                    if (values1[i] > values1[j])
                    {
                        int temp = values1[i];
                        values1[i] = values1[j];
                        values1[j] = temp;
                        chart1.Update();

                        //await PutTaskDelay();
                        //System.Threading.Thread.Sleep(100);
                    }
                    UpdateChart(chart1, values1, i, j);
                    System.Threading.Thread.Sleep(500);
                }
            }

        }

        private void size1_ValueChanged(object sender, EventArgs e)
        {
            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));

            UpdateChart(chart1, values1, 0, 0);
        }

        private void buttonRandom1_Click(object sender, EventArgs e)
        {

        }
    }
}
