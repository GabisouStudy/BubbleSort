namespace BubbleSort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.size1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRandom1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart1.Size = new System.Drawing.Size(1068, 675);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonSort1
            // 
            this.buttonSort1.Location = new System.Drawing.Point(1084, 12);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(122, 43);
            this.buttonSort1.TabIndex = 1;
            this.buttonSort1.Text = "Sort";
            this.buttonSort1.UseVisualStyleBackColor = true;
            this.buttonSort1.Click += new System.EventHandler(this.buttonSort1_Click);
            // 
            // size1
            // 
            this.size1.Location = new System.Drawing.Point(1086, 114);
            this.size1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.size1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(120, 26);
            this.size1.TabIndex = 2;
            this.size1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size1.ValueChanged += new System.EventHandler(this.size1_ValueChanged);
            // 
            // buttonRandom1
            // 
            this.buttonRandom1.Location = new System.Drawing.Point(1084, 61);
            this.buttonRandom1.Name = "buttonRandom1";
            this.buttonRandom1.Size = new System.Drawing.Size(122, 43);
            this.buttonRandom1.TabIndex = 3;
            this.buttonRandom1.Text = "Random";
            this.buttonRandom1.UseVisualStyleBackColor = true;
            this.buttonRandom1.Click += new System.EventHandler(this.buttonRandom1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 949);
            this.Controls.Add(this.buttonRandom1);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.buttonSort1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonSort1;
        private System.Windows.Forms.NumericUpDown size1;
        private System.Windows.Forms.Button buttonRandom1;
    }
}

