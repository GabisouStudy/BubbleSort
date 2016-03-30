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
        
        List<int> values1 = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("BubbleSort");

            for (int i = 1; i < size1.Value; i++)
            {
                values1.Add(i);
            }

            chart1.Series.Clear();
            Series series = chart1.Series.Add("Entrada Teste ");
            chart1.Series[0]["PointWidth"] = "0.5";
            for (int i = 1; i <= size1.Value; i++)
            {
                series.Points.Add(i);
            }
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + values1.Count);
            values1.BubbleSort();

            chart1.Series.Clear();
            Series series = chart1.Series.Add("Entrada Teste ");
            chart1.Series[0]["PointWidth"] = "0.5";

            for (int i = 0; i < size1.Value; i++)
            {
                series.Points.Add(values1[i]);
            }
        }

        private void size1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < size1.Value + 1; i++)
            {
                values1.Add(i);
            }

            chart1.Series.Clear();
            Series series = chart1.Series.Add("Entrada Teste ");
            chart1.Series[0]["PointWidth"] = "0.5";

            for (int i = 1; i <= size1.Value; i++){
                series.Points.Add(i);
            }
        }

        private void buttonRandom1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < size1.Value+1; i++)
            {
                values1.Add(i);
            }

            values1.Shuffle();

            chart1.Series.Clear();
            Series series = chart1.Series.Add("Entrada Teste ");
            chart1.Series[0]["PointWidth"] = "0.5";

            for (int i = 0; i < size1.Value; i++)
            {
                series.Points.Add(values1[i]);
            }
        }
    }

    static class MyExtensions{
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<int> BubbleSort(this List<int> vetor)
        {
            int tamanho = vetor.Count;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }
    }

}
