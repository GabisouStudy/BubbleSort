using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        int[] values1;
        bool abort = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("BubbleSort");
            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));
            UpdateChart(chart1, values1, 0, 0, Color.Red);

            buttonAbort1.Enabled = false;
        }

        private int[] RandomArray(int size)
        {
            int[] array = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                array[i] = (r.Next(1, size));
            return array;
        }

        public void UpdateChart(Chart c, int[] a, int c1, int c2, Color cl) {
            Chart chart = c;
            int[] array = a;
            Color color = cl;
            chart.Series.Clear();
            Series series = chart.Series.Add("");
            chart.Series[0]["PointWidth"] = "0.5";
            for (int i = 0; i < array.Length; i++)
            {
                chart.Series[0].Points.Add(array[i]);
            }
            if (c1 != c2) {
                
                chart1.Series[0].Points[c1].Color = color;
                chart1.Series[0].Points[c2].Color = color;
            }
        }

        private async void buttonSort1_Click(object sender, EventArgs e)
        {
            buttonSort1.Enabled = false;
            size1.Enabled = false;

            buttonAbort1.Enabled = true;

            int comp1 = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < values1.Length - 1; i++)
            {
                for (int j = i + 1; j < values1.Length; j++)
                {
                    if (abort) {
                        break;
                    }
                    UpdateChart(chart1, values1, i, j, Color.Red);
                    chart1.Update();
                    await Task.Delay(int.Parse("" + velocity1.Value));
                    comp1++;
                    textBoxComp.Text = "" + comp1;
                    if (values1[i] > values1[j]) {
                        UpdateChart(chart1, values1, i, j, Color.GreenYellow);
                        chart1.Update();
                        await Task.Delay((int.Parse("" + velocity1.Value) / 4) * 3);
                        int temp = values1[i];
                        values1[i] = values1[j];
                        values1[j] = temp;
                    }

                    stopWatch.Stop();

                    long t = stopWatch.ElapsedMilliseconds;
                    textBoxTime.Text = "" + t;

                    stopWatch.Start();

                }
                UpdateChart(chart1, values1, 0, 0, Color.Yellow);
            }

            buttonSort1.Enabled = true;
            size1.Enabled = true;
            abort = false;
            buttonAbort1.Enabled = false;
            
            stopWatch.Stop();

            long time = stopWatch.ElapsedMilliseconds;
            textBoxTime.Text = "" + time;

        }

        private void size1_ValueChanged(object sender, EventArgs e)
        {
            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));

            UpdateChart(chart1, values1, 0, 0, Color.Red);
        }

        private void buttonAbort1_Click(object sender, EventArgs e)
        {
            abort = true;
        }
    }
}
