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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.size1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.velocity1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.size1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocity1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSort1
            // 
            this.buttonSort1.Location = new System.Drawing.Point(723, 8);
            this.buttonSort1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(81, 28);
            this.buttonSort1.TabIndex = 1;
            this.buttonSort1.Text = "Sort";
            this.buttonSort1.UseVisualStyleBackColor = true;
            this.buttonSort1.Click += new System.EventHandler(this.buttonSort1_Click);
            // 
            // size1
            // 
            this.size1.Location = new System.Drawing.Point(724, 40);
            this.size1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.size1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.size1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(80, 20);
            this.size1.TabIndex = 2;
            this.size1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.size1.ValueChanged += new System.EventHandler(this.size1_ValueChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(8, 8);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart1.Size = new System.Drawing.Size(712, 439);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // velocity1
            // 
            this.velocity1.Location = new System.Drawing.Point(723, 91);
            this.velocity1.Margin = new System.Windows.Forms.Padding(2);
            this.velocity1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.velocity1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.velocity1.Name = "velocity1";
            this.velocity1.Size = new System.Drawing.Size(80, 20);
            this.velocity1.TabIndex = 3;
            this.velocity1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comparações:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.velocity1);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.buttonSort1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.size1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocity1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSort1;
        private System.Windows.Forms.NumericUpDown size1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown velocity1;
        private System.Windows.Forms.Label label1;
    }
}

