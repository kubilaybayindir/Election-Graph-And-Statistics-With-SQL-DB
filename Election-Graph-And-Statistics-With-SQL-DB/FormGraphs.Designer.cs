namespace Election_Graph_And_Statistics_With_SQL_DB
{
    partial class FormGraphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartElection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblSocietyB = new System.Windows.Forms.Label();
            this.LblSocietyD = new System.Windows.Forms.Label();
            this.LblSocietyC = new System.Windows.Forms.Label();
            this.LblSocietyE = new System.Windows.Forms.Label();
            this.LblSocietyA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PbSocietyE = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.PbSocietyD = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PbSocietyC = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PbSocietyB = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbSocietyA = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartElection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChartElection);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(754, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Result";
            // 
            // ChartElection
            // 
            chartArea5.Name = "ChartArea1";
            this.ChartElection.ChartAreas.Add(chartArea5);
            this.ChartElection.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.ChartElection.Legends.Add(legend5);
            this.ChartElection.Location = new System.Drawing.Point(4, 22);
            this.ChartElection.Margin = new System.Windows.Forms.Padding(4);
            this.ChartElection.Name = "ChartElection";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Society";
            this.ChartElection.Series.Add(series5);
            this.ChartElection.Size = new System.Drawing.Size(746, 299);
            this.ChartElection.TabIndex = 0;
            this.ChartElection.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblSocietyB);
            this.groupBox2.Controls.Add(this.LblSocietyD);
            this.groupBox2.Controls.Add(this.LblSocietyC);
            this.groupBox2.Controls.Add(this.LblSocietyE);
            this.groupBox2.Controls.Add(this.LblSocietyA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PbSocietyE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PbSocietyD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PbSocietyC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PbSocietyB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CbxCity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PbSocietyA);
            this.groupBox2.Location = new System.Drawing.Point(16, 351);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(754, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "City Results";
            // 
            // LblSocietyB
            // 
            this.LblSocietyB.AutoSize = true;
            this.LblSocietyB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSocietyB.Location = new System.Drawing.Point(190, 122);
            this.LblSocietyB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSocietyB.Name = "LblSocietyB";
            this.LblSocietyB.Size = new System.Drawing.Size(19, 21);
            this.LblSocietyB.TabIndex = 16;
            this.LblSocietyB.Text = "0";
            // 
            // LblSocietyD
            // 
            this.LblSocietyD.AutoSize = true;
            this.LblSocietyD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSocietyD.Location = new System.Drawing.Point(190, 198);
            this.LblSocietyD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSocietyD.Name = "LblSocietyD";
            this.LblSocietyD.Size = new System.Drawing.Size(19, 21);
            this.LblSocietyD.TabIndex = 15;
            this.LblSocietyD.Text = "0";
            // 
            // LblSocietyC
            // 
            this.LblSocietyC.AutoSize = true;
            this.LblSocietyC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSocietyC.Location = new System.Drawing.Point(190, 160);
            this.LblSocietyC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSocietyC.Name = "LblSocietyC";
            this.LblSocietyC.Size = new System.Drawing.Size(19, 21);
            this.LblSocietyC.TabIndex = 14;
            this.LblSocietyC.Text = "0";
            // 
            // LblSocietyE
            // 
            this.LblSocietyE.AutoSize = true;
            this.LblSocietyE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSocietyE.Location = new System.Drawing.Point(190, 236);
            this.LblSocietyE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSocietyE.Name = "LblSocietyE";
            this.LblSocietyE.Size = new System.Drawing.Size(19, 21);
            this.LblSocietyE.TabIndex = 13;
            this.LblSocietyE.Text = "0";
            // 
            // LblSocietyA
            // 
            this.LblSocietyA.AutoSize = true;
            this.LblSocietyA.BackColor = System.Drawing.Color.Transparent;
            this.LblSocietyA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSocietyA.Location = new System.Drawing.Point(190, 84);
            this.LblSocietyA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSocietyA.Name = "LblSocietyA";
            this.LblSocietyA.Size = new System.Drawing.Size(19, 21);
            this.LblSocietyA.TabIndex = 12;
            this.LblSocietyA.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(100, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Society E:";
            // 
            // PbSocietyE
            // 
            this.PbSocietyE.Location = new System.Drawing.Point(229, 231);
            this.PbSocietyE.Margin = new System.Windows.Forms.Padding(4);
            this.PbSocietyE.Maximum = 200;
            this.PbSocietyE.Name = "PbSocietyE";
            this.PbSocietyE.Size = new System.Drawing.Size(472, 30);
            this.PbSocietyE.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(100, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Society D:";
            // 
            // PbSocietyD
            // 
            this.PbSocietyD.Location = new System.Drawing.Point(229, 193);
            this.PbSocietyD.Margin = new System.Windows.Forms.Padding(4);
            this.PbSocietyD.Maximum = 200;
            this.PbSocietyD.Name = "PbSocietyD";
            this.PbSocietyD.Size = new System.Drawing.Size(472, 30);
            this.PbSocietyD.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Society C:";
            // 
            // PbSocietyC
            // 
            this.PbSocietyC.Location = new System.Drawing.Point(229, 155);
            this.PbSocietyC.Margin = new System.Windows.Forms.Padding(4);
            this.PbSocietyC.Maximum = 200;
            this.PbSocietyC.Name = "PbSocietyC";
            this.PbSocietyC.Size = new System.Drawing.Size(472, 30);
            this.PbSocietyC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Society B:";
            // 
            // PbSocietyB
            // 
            this.PbSocietyB.Location = new System.Drawing.Point(229, 117);
            this.PbSocietyB.Margin = new System.Windows.Forms.Padding(4);
            this.PbSocietyB.Maximum = 200;
            this.PbSocietyB.Name = "PbSocietyB";
            this.PbSocietyB.Size = new System.Drawing.Size(472, 30);
            this.PbSocietyB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Society A:";
            // 
            // CbxCity
            // 
            this.CbxCity.FormattingEnabled = true;
            this.CbxCity.Location = new System.Drawing.Point(229, 36);
            this.CbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.CbxCity.Name = "CbxCity";
            this.CbxCity.Size = new System.Drawing.Size(160, 25);
            this.CbxCity.TabIndex = 2;
            this.CbxCity.SelectedIndexChanged += new System.EventHandler(this.CbxCity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // PbSocietyA
            // 
            this.PbSocietyA.Location = new System.Drawing.Point(229, 79);
            this.PbSocietyA.Margin = new System.Windows.Forms.Padding(4);
            this.PbSocietyA.Maximum = 200;
            this.PbSocietyA.Name = "PbSocietyA";
            this.PbSocietyA.Size = new System.Drawing.Size(472, 30);
            this.PbSocietyA.TabIndex = 0;
            // 
            // FormGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGraphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.FormGraphs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartElection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartElection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PbSocietyA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PbSocietyE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar PbSocietyD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PbSocietyC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PbSocietyB;
        private System.Windows.Forms.Label LblSocietyB;
        private System.Windows.Forms.Label LblSocietyD;
        private System.Windows.Forms.Label LblSocietyC;
        private System.Windows.Forms.Label LblSocietyE;
        private System.Windows.Forms.Label LblSocietyA;
    }
}