namespace final_project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbAmazing = new System.Windows.Forms.RadioButton();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbBad = new System.Windows.Forms.RadioButton();
            this.rbTerrible = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chartMoods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoods)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAmazing
            // 
            this.rbAmazing.AutoSize = true;
            this.rbAmazing.Location = new System.Drawing.Point(53, 38);
            this.rbAmazing.Name = "rbAmazing";
            this.rbAmazing.Size = new System.Drawing.Size(80, 17);
            this.rbAmazing.TabIndex = 0;
            this.rbAmazing.TabStop = true;
            this.rbAmazing.Text = "Amazing 🙂";
            this.rbAmazing.UseVisualStyleBackColor = true;
            // 
            // rbGood
            // 
            this.rbGood.AutoSize = true;
            this.rbGood.Location = new System.Drawing.Point(53, 61);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(66, 17);
            this.rbGood.TabIndex = 1;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "Good 🙂";
            this.rbGood.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(53, 84);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(73, 17);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal 😶";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbBad
            // 
            this.rbBad.AutoSize = true;
            this.rbBad.Location = new System.Drawing.Point(53, 107);
            this.rbBad.Name = "rbBad";
            this.rbBad.Size = new System.Drawing.Size(59, 17);
            this.rbBad.TabIndex = 3;
            this.rbBad.TabStop = true;
            this.rbBad.Text = "Bad 😟";
            this.rbBad.UseVisualStyleBackColor = true;
            // 
            // rbTerrible
            // 
            this.rbTerrible.AutoSize = true;
            this.rbTerrible.Location = new System.Drawing.Point(53, 130);
            this.rbTerrible.Name = "rbTerrible";
            this.rbTerrible.Size = new System.Drawing.Size(75, 17);
            this.rbTerrible.TabIndex = 4;
            this.rbTerrible.TabStop = true;
            this.rbTerrible.Text = "Terrible 😖";
            this.rbTerrible.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "How do you feel today?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbTerrible);
            this.groupBox1.Controls.Add(this.rbBad);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbGood);
            this.groupBox1.Controls.Add(this.rbAmazing);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View statistics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartMoods
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMoods.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMoods.Legends.Add(legend1);
            this.chartMoods.Location = new System.Drawing.Point(288, 12);
            this.chartMoods.Name = "chartMoods";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMoods.Series.Add(series1);
            this.chartMoods.Size = new System.Drawing.Size(472, 283);
            this.chartMoods.TabIndex = 2;
            this.chartMoods.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.chartMoods);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mood Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAmazing;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbBad;
        private System.Windows.Forms.RadioButton rbTerrible;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoods;
    }
}

