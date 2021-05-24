
namespace SM._931802.Komarov.Lab9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Nlabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.state = new System.Windows.Forms.Label();
            this.prob5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(73, 31);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(50, 17);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Prob 1";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(73, 59);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(50, 17);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "Prob 2";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Location = new System.Drawing.Point(73, 88);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(50, 17);
            this.Text3.TabIndex = 2;
            this.Text3.Text = "Prob 3";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.Location = new System.Drawing.Point(73, 117);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(50, 17);
            this.Text4.TabIndex = 3;
            this.Text4.Text = "Prob 4";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.Location = new System.Drawing.Point(73, 144);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(50, 17);
            this.Text5.TabIndex = 4;
            this.Text5.Text = "Prob 5";
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Location = new System.Drawing.Point(370, 34);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(18, 17);
            this.Nlabel.TabIndex = 11;
            this.Nlabel.Text = "N";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(420, 70);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(84, 35);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 188);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(816, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 1;
            this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob1.Location = new System.Drawing.Point(147, 29);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(120, 22);
            this.prob1.TabIndex = 14;
            this.prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 1;
            this.prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob2.Location = new System.Drawing.Point(147, 57);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(120, 22);
            this.prob2.TabIndex = 15;
            this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 1;
            this.prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob3.Location = new System.Drawing.Point(147, 86);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(120, 22);
            this.prob3.TabIndex = 16;
            this.prob3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 1;
            this.prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob4.Location = new System.Drawing.Point(147, 115);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(120, 22);
            this.prob4.TabIndex = 17;
            this.prob4.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(404, 32);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(129, 22);
            this.Number.TabIndex = 19;
            this.Number.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(417, 144);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(41, 17);
            this.state.TabIndex = 20;
            this.state.Text = "State";
            // 
            // prob5
            // 
            this.prob5.Location = new System.Drawing.Point(147, 144);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(100, 22);
            this.prob5.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 524);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.state);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox prob5;
    }
}

