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

        /*public static Task Delay(double milliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (obj, args) =>
            {
                tcs.TrySetResult(true);
            };
            timer.Interval = milliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }*/

        private int[] RandomArray(int size)
        {
            int[] array = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                array[i] = (r.Next(0, 200));
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

        int[] values1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("BubbleSort");

            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));

            UpdateChart(chart1, values1, 0, 0, Color.Red);

            //Series series = chart.Series.Add("");
        }

        public async Task BubbleSort()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < values1.Length - 1; i++)
                {
                    for (int j = i + 1; j < values1.Length; j++)
                    {
                        UpdateChart(chart1, values1, i, j, Color.Red);
                        chart1.Update();
                        //System.Threading.Thread.Sleep(1);
                        //Delay(int.Parse("" + velocity1.Value));
                        if (values1[i] > values1[j])
                        {
                            UpdateChart(chart1, values1, i, j, Color.Yellow);
                            chart1.Update();
                            //Delay(500000000);
                            //System.Threading.Thread.Sleep(300);
                            Task.Delay(50000);
                            int temp = values1[i];
                            values1[i] = values1[j];
                            values1[j] = temp;

                            //await PutTaskDelay();
                            //System.Threading.Thread.Sleep(100);
                        }
                    }
                    UpdateChart(chart1, values1, 0, 0, Color.Yellow);
                }
            });
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            //BubbleSort();
            for (int i = 0; i < values1.Length - 1; i++)
            {
                for (int j = i + 1; j < values1.Length; j++)
                {
                    UpdateChart(chart1, values1, i, j, Color.Red);
                    chart1.Update();
                    //System.Threading.Thread.Sleep(1);
                    //Delay(int.Parse("" + velocity1.Value));
                    if (values1[i] > values1[j])
                    {
                        UpdateChart(chart1, values1, i, j, Color.Yellow);
                        chart1.Update();
                        Task.Delay(500);
                        //System.Threading.Thread.Sleep(300);
                        Task.Delay(50000);
                        int temp = values1[i];
                        values1[i] = values1[j];
                        values1[j] = temp;

                        //await PutTaskDelay();
                        //System.Threading.Thread.Sleep(100);
                    }
                }
                UpdateChart(chart1, values1, 0, 0, Color.Yellow);
            }

        }

        private void size1_ValueChanged(object sender, EventArgs e)
        {
            values1 = RandomArray(int.Parse("" + (size1.Value + 1)));

            UpdateChart(chart1, values1, 0, 0, Color.Red);
        }

        private void buttonRandom1_Click(object sender, EventArgs e)
        {

        }
    }
}
