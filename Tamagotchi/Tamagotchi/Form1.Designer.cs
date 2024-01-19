namespace Tamagotchi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartWelzijn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.chartEten = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDrinken = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMedkit = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEten = new System.Windows.Forms.Button();
            this.buttonDrinken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartWelzijn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWelzijn
            // 
            this.chartWelzijn.BackColor = System.Drawing.Color.Transparent;
            this.chartWelzijn.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartWelzijn.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartWelzijn.ChartAreas.Add(chartArea1);
            this.chartWelzijn.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWelzijn.Legends.Add(legend1);
            this.chartWelzijn.Location = new System.Drawing.Point(12, 164);
            this.chartWelzijn.Name = "chartWelzijn";
            this.chartWelzijn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartWelzijn.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Transparent};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieStartAngle=270";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Lime;
            dataPoint2.Color = System.Drawing.Color.Transparent;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartWelzijn.Series.Add(series1);
            this.chartWelzijn.Size = new System.Drawing.Size(222, 254);
            this.chartWelzijn.TabIndex = 0;
            this.chartWelzijn.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Algemeen Welzijn";
            this.chartWelzijn.Titles.Add(title1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // chartEten
            // 
            this.chartEten.BackColor = System.Drawing.Color.Transparent;
            this.chartEten.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartEten.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.Area3DStyle.Inclination = 20;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartEten.ChartAreas.Add(chartArea2);
            this.chartEten.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartEten.Legends.Add(legend2);
            this.chartEten.Location = new System.Drawing.Point(226, 164);
            this.chartEten.Name = "chartEten";
            this.chartEten.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartEten.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Transparent};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieStartAngle=270";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint3.Color = System.Drawing.Color.Lime;
            dataPoint3.MarkerSize = 5;
            dataPoint4.Color = System.Drawing.Color.Transparent;
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.YValuesPerPoint = 4;
            this.chartEten.Series.Add(series2);
            this.chartEten.Size = new System.Drawing.Size(222, 254);
            this.chartEten.TabIndex = 1;
            this.chartEten.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Eten";
            this.chartEten.Titles.Add(title2);
            // 
            // chartDrinken
            // 
            this.chartDrinken.BackColor = System.Drawing.Color.Transparent;
            this.chartDrinken.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartDrinken.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.Area3DStyle.Inclination = 20;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.Area3DStyle.Rotation = 0;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartDrinken.ChartAreas.Add(chartArea3);
            this.chartDrinken.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartDrinken.Legends.Add(legend3);
            this.chartDrinken.Location = new System.Drawing.Point(440, 164);
            this.chartDrinken.Name = "chartDrinken";
            this.chartDrinken.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDrinken.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Transparent};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.CustomProperties = "PieStartAngle=270";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            dataPoint5.Color = System.Drawing.Color.Lime;
            dataPoint6.Color = System.Drawing.Color.Transparent;
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.chartDrinken.Series.Add(series3);
            this.chartDrinken.Size = new System.Drawing.Size(222, 254);
            this.chartDrinken.TabIndex = 2;
            this.chartDrinken.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Drinken";
            this.chartDrinken.Titles.Add(title3);
            // 
            // buttonMedkit
            // 
            this.buttonMedkit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonMedkit.BackgroundImage = global::Tamagotchi.Properties.Resources.medkit;
            this.buttonMedkit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMedkit.FlatAppearance.BorderSize = 0;
            this.buttonMedkit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedkit.Location = new System.Drawing.Point(260, 11);
            this.buttonMedkit.Name = "buttonMedkit";
            this.buttonMedkit.Size = new System.Drawing.Size(130, 130);
            this.buttonMedkit.TabIndex = 9;
            this.buttonMedkit.UseVisualStyleBackColor = false;
            this.buttonMedkit.Click += new System.EventHandler(this.buttonMedkit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Tamagotchi.Properties.Resources.a;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(61, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 130);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Tamagotchi.Properties.Resources.drinken;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(488, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Tamagotchi.Properties.Resources.eten;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(267, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tamagotchi.Properties.Resources.welzijn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(48, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEten
            // 
            this.buttonEten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonEten.BackgroundImage = global::Tamagotchi.Properties.Resources.eten;
            this.buttonEten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEten.FlatAppearance.BorderSize = 0;
            this.buttonEten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEten.Location = new System.Drawing.Point(396, 11);
            this.buttonEten.Name = "buttonEten";
            this.buttonEten.Size = new System.Drawing.Size(130, 130);
            this.buttonEten.TabIndex = 4;
            this.buttonEten.UseVisualStyleBackColor = false;
            this.buttonEten.Click += new System.EventHandler(this.buttonEten_Click);
            // 
            // buttonDrinken
            // 
            this.buttonDrinken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.buttonDrinken.BackgroundImage = global::Tamagotchi.Properties.Resources.drinken;
            this.buttonDrinken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDrinken.FlatAppearance.BorderSize = 0;
            this.buttonDrinken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrinken.Location = new System.Drawing.Point(532, 12);
            this.buttonDrinken.Name = "buttonDrinken";
            this.buttonDrinken.Size = new System.Drawing.Size(130, 130);
            this.buttonDrinken.TabIndex = 3;
            this.buttonDrinken.UseVisualStyleBackColor = false;
            this.buttonDrinken.Click += new System.EventHandler(this.buttonDrinken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 413);
            this.Controls.Add(this.buttonMedkit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEten);
            this.Controls.Add(this.buttonDrinken);
            this.Controls.Add(this.chartDrinken);
            this.Controls.Add(this.chartEten);
            this.Controls.Add(this.chartWelzijn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tamagotchi - Jason";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWelzijn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrinken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWelzijn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEten;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrinken;
        private System.Windows.Forms.Button buttonDrinken;
        private System.Windows.Forms.Button buttonEten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonMedkit;
    }
}

