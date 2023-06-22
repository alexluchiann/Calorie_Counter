namespace Progres
{
    partial class Progres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progres));
            this.ChartProgres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProgres)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartProgres
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartProgres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartProgres.Legends.Add(legend1);
            this.ChartProgres.Location = new System.Drawing.Point(62, 46);
            this.ChartProgres.Name = "ChartProgres";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartProgres.Series.Add(series1);
            this.ChartProgres.Size = new System.Drawing.Size(669, 321);
            this.ChartProgres.TabIndex = 0;
            this.ChartProgres.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChartProgres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartProgres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProgres;
    }
}

