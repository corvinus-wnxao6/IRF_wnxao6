
namespace MNBSoap
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.forDatePicker = new System.Windows.Forms.DateTimePicker();
            this.igDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxValuta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mehetbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRateData
            // 
            this.chartRateData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartRateData.Legends.Add(legend8);
            this.chartRateData.Location = new System.Drawing.Point(400, 77);
            this.chartRateData.Name = "chartRateData";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartRateData.Series.Add(series8);
            this.chartRateData.Size = new System.Drawing.Size(619, 423);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // forDatePicker
            // 
            this.forDatePicker.Location = new System.Drawing.Point(122, 12);
            this.forDatePicker.Name = "forDatePicker";
            this.forDatePicker.Size = new System.Drawing.Size(265, 22);
            this.forDatePicker.TabIndex = 2;
            this.forDatePicker.Value = new System.DateTime(2020, 1, 1, 10, 45, 0, 0);
            this.forDatePicker.ValueChanged += new System.EventHandler(this.filterChanged);
            // 
            // igDatePicker
            // 
            this.igDatePicker.Location = new System.Drawing.Point(122, 40);
            this.igDatePicker.Name = "igDatePicker";
            this.igDatePicker.Size = new System.Drawing.Size(265, 22);
            this.igDatePicker.TabIndex = 3;
            this.igDatePicker.Value = new System.DateTime(2020, 6, 30, 10, 45, 0, 0);
            this.igDatePicker.ValueChanged += new System.EventHandler(this.filterChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kezdődátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Záródátum";
            // 
            // comboBoxValuta
            // 
            this.comboBoxValuta.FormattingEnabled = true;
            this.comboBoxValuta.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.comboBoxValuta.Location = new System.Drawing.Point(545, 14);
            this.comboBoxValuta.Name = "comboBoxValuta";
            this.comboBoxValuta.Size = new System.Drawing.Size(131, 24);
            this.comboBoxValuta.TabIndex = 6;
            this.comboBoxValuta.Tag = "";
            this.comboBoxValuta.ValueMember = "EUR";
            this.comboBoxValuta.SelectedIndexChanged += new System.EventHandler(this.comboBoxValuta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valuta";
            // 
            // Mehetbtn
            // 
            this.Mehetbtn.Location = new System.Drawing.Point(887, 20);
            this.Mehetbtn.Name = "Mehetbtn";
            this.Mehetbtn.Size = new System.Drawing.Size(122, 38);
            this.Mehetbtn.TabIndex = 8;
            this.Mehetbtn.Text = "Mehet";
            this.Mehetbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 512);
            this.Controls.Add(this.Mehetbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.igDatePicker);
            this.Controls.Add(this.forDatePicker);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker forDatePicker;
        private System.Windows.Forms.DateTimePicker igDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxValuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Mehetbtn;
    }
}

