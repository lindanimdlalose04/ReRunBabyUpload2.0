namespace ReRunBabyUpload
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage_CSV = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_csv_path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Close_csv = new System.Windows.Forms.Button();
            this.dataGridViewCSV = new System.Windows.Forms.DataGridView();
            this.tabPageEXCEL = new System.Windows.Forms.TabPage();
            this.lbl_process_btn = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_excel_path = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_close_excel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.tabPage_HOME = new System.Windows.Forms.TabPage();
            this.panelShadowBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_source_columns = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_close_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lbl_naming_columns_hint = new System.Windows.Forms.Label();
            this.tabPage_CSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).BeginInit();
            this.tabPageEXCEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.tabPage_HOME.SuspendLayout();
            this.panelShadowBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage_CSV
            // 
            this.tabPage_CSV.Controls.Add(this.btn_save);
            this.tabPage_CSV.Controls.Add(this.label8);
            this.tabPage_CSV.Controls.Add(this.txt_csv_path);
            this.tabPage_CSV.Controls.Add(this.label6);
            this.tabPage_CSV.Controls.Add(this.btn_Close_csv);
            this.tabPage_CSV.Controls.Add(this.dataGridViewCSV);
            this.tabPage_CSV.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CSV.Name = "tabPage_CSV";
            this.tabPage_CSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CSV.Size = new System.Drawing.Size(1256, 684);
            this.tabPage_CSV.TabIndex = 2;
            this.tabPage_CSV.Text = "View Csv Sheet";
            this.tabPage_CSV.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Location = new System.Drawing.Point(1069, 564);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 52);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 37);
            this.label8.TabIndex = 4;
            this.label8.Text = "Converted File ";
            // 
            // txt_csv_path
            // 
            this.txt_csv_path.Location = new System.Drawing.Point(238, 600);
            this.txt_csv_path.Name = "txt_csv_path";
            this.txt_csv_path.Size = new System.Drawing.Size(401, 26);
            this.txt_csv_path.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = " File Destination";
            // 
            // btn_Close_csv
            // 
            this.btn_Close_csv.BackColor = System.Drawing.Color.Plum;
            this.btn_Close_csv.Location = new System.Drawing.Point(1069, 615);
            this.btn_Close_csv.Name = "btn_Close_csv";
            this.btn_Close_csv.Size = new System.Drawing.Size(126, 52);
            this.btn_Close_csv.TabIndex = 1;
            this.btn_Close_csv.Text = "Close";
            this.btn_Close_csv.UseVisualStyleBackColor = false;
            this.btn_Close_csv.Click += new System.EventHandler(this.btn_Close_csv_Click);
            // 
            // dataGridViewCSV
            // 
            this.dataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSV.Location = new System.Drawing.Point(229, 49);
            this.dataGridViewCSV.Name = "dataGridViewCSV";
            this.dataGridViewCSV.RowHeadersWidth = 62;
            this.dataGridViewCSV.RowTemplate.Height = 28;
            this.dataGridViewCSV.Size = new System.Drawing.Size(959, 509);
            this.dataGridViewCSV.TabIndex = 0;
            // 
            // tabPageEXCEL
            // 
            this.tabPageEXCEL.Controls.Add(this.lbl_naming_columns_hint);
            this.tabPageEXCEL.Controls.Add(this.lbl_process_btn);
            this.tabPageEXCEL.Controls.Add(this.txt_output);
            this.tabPageEXCEL.Controls.Add(this.txt_excel_path);
            this.tabPageEXCEL.Controls.Add(this.label11);
            this.tabPageEXCEL.Controls.Add(this.label9);
            this.tabPageEXCEL.Controls.Add(this.btn_process);
            this.tabPageEXCEL.Controls.Add(this.label7);
            this.tabPageEXCEL.Controls.Add(this.comboBox1);
            this.tabPageEXCEL.Controls.Add(this.btn_close_excel);
            this.tabPageEXCEL.Controls.Add(this.label5);
            this.tabPageEXCEL.Controls.Add(this.dataGridViewExcel);
            this.tabPageEXCEL.Location = new System.Drawing.Point(4, 29);
            this.tabPageEXCEL.Name = "tabPageEXCEL";
            this.tabPageEXCEL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEXCEL.Size = new System.Drawing.Size(1256, 684);
            this.tabPageEXCEL.TabIndex = 1;
            this.tabPageEXCEL.Text = "View Excel Sheet ";
            this.tabPageEXCEL.UseVisualStyleBackColor = true;
            // 
            // lbl_process_btn
            // 
            this.lbl_process_btn.AutoSize = true;
            this.lbl_process_btn.Location = new System.Drawing.Point(6, 550);
            this.lbl_process_btn.Name = "lbl_process_btn";
            this.lbl_process_btn.Size = new System.Drawing.Size(341, 20);
            this.lbl_process_btn.TabIndex = 21;
            this.lbl_process_btn.Text = "Click the button to process above to a CSV File";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(11, 319);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(249, 65);
            this.txt_output.TabIndex = 20;
            this.txt_output.TextChanged += new System.EventHandler(this.txt_output_TextChanged);
            // 
            // txt_excel_path
            // 
            this.txt_excel_path.Location = new System.Drawing.Point(11, 197);
            this.txt_excel_path.Name = "txt_excel_path";
            this.txt_excel_path.Size = new System.Drawing.Size(470, 26);
            this.txt_excel_path.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Enter the Output columns";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = "Original Excel Sheet";
            // 
            // btn_process
            // 
            this.btn_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_process.Location = new System.Drawing.Point(11, 587);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(151, 70);
            this.btn_process.TabIndex = 6;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = false;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select your file here:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_close_excel
            // 
            this.btn_close_excel.BackColor = System.Drawing.Color.Plum;
            this.btn_close_excel.Location = new System.Drawing.Point(1085, 587);
            this.btn_close_excel.Name = "btn_close_excel";
            this.btn_close_excel.Size = new System.Drawing.Size(150, 70);
            this.btn_close_excel.TabIndex = 3;
            this.btn_close_excel.Text = "Close";
            this.btn_close_excel.UseVisualStyleBackColor = false;
            this.btn_close_excel.Click += new System.EventHandler(this.btn_close_excel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "File Path";
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(487, 55);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.RowHeadersWidth = 62;
            this.dataGridViewExcel.RowTemplate.Height = 28;
            this.dataGridViewExcel.Size = new System.Drawing.Size(742, 515);
            this.dataGridViewExcel.TabIndex = 0;
            // 
            // tabPage_HOME
            // 
            this.tabPage_HOME.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_HOME.Controls.Add(this.panelShadowBox);
            this.tabPage_HOME.Controls.Add(this.label4);
            this.tabPage_HOME.Controls.Add(this.btn_close_1);
            this.tabPage_HOME.Controls.Add(this.label1);
            this.tabPage_HOME.Location = new System.Drawing.Point(4, 29);
            this.tabPage_HOME.Name = "tabPage_HOME";
            this.tabPage_HOME.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HOME.Size = new System.Drawing.Size(1256, 684);
            this.tabPage_HOME.TabIndex = 0;
            this.tabPage_HOME.Text = "User Input";
            this.tabPage_HOME.UseVisualStyleBackColor = true;
            this.tabPage_HOME.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panelShadowBox
            // 
            this.panelShadowBox.BackColor = System.Drawing.Color.Silver;
            this.panelShadowBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShadowBox.Controls.Add(this.label2);
            this.panelShadowBox.Controls.Add(this.btn_view);
            this.panelShadowBox.Controls.Add(this.label10);
            this.panelShadowBox.Controls.Add(this.label3);
            this.panelShadowBox.Controls.Add(this.txt_source_columns);
            this.panelShadowBox.Controls.Add(this.btn_upload);
            this.panelShadowBox.Location = new System.Drawing.Point(361, 174);
            this.panelShadowBox.Name = "panelShadowBox";
            this.panelShadowBox.Size = new System.Drawing.Size(482, 418);
            this.panelShadowBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Click this button to View uploaded file";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.LightGreen;
            this.btn_view.Location = new System.Drawing.Point(117, 314);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(241, 74);
            this.btn_view.TabIndex = 17;
            this.btn_view.Text = "View Excel File";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Click this button to Upload your Excel File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "All the Source columns will apear here: ";
            // 
            // txt_source_columns
            // 
            this.txt_source_columns.Location = new System.Drawing.Point(116, 197);
            this.txt_source_columns.Multiline = true;
            this.txt_source_columns.Name = "txt_source_columns";
            this.txt_source_columns.Size = new System.Drawing.Size(241, 58);
            this.txt_source_columns.TabIndex = 12;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Location = new System.Drawing.Point(116, 61);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(241, 70);
            this.btn_upload.TabIndex = 11;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(256, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Converting your Excel Sheets to CSV Sheets";
            // 
            // btn_close_1
            // 
            this.btn_close_1.BackColor = System.Drawing.Color.Plum;
            this.btn_close_1.Location = new System.Drawing.Point(1117, 610);
            this.btn_close_1.Name = "btn_close_1";
            this.btn_close_1.Size = new System.Drawing.Size(129, 64);
            this.btn_close_1.TabIndex = 8;
            this.btn_close_1.Text = "Close";
            this.btn_close_1.UseVisualStyleBackColor = false;
            this.btn_close_1.Click += new System.EventHandler(this.btn_close_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(135, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baby Upload File Converter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_HOME);
            this.tabControl1.Controls.Add(this.tabPageEXCEL);
            this.tabControl1.Controls.Add(this.tabPage_CSV);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 717);
            this.tabControl1.TabIndex = 2;
            // 
            // lbl_naming_columns_hint
            // 
            this.lbl_naming_columns_hint.AutoSize = true;
            this.lbl_naming_columns_hint.ForeColor = System.Drawing.Color.Red;
            this.lbl_naming_columns_hint.Location = new System.Drawing.Point(7, 402);
            this.lbl_naming_columns_hint.Name = "lbl_naming_columns_hint";
            this.lbl_naming_columns_hint.Size = new System.Drawing.Size(360, 20);
            this.lbl_naming_columns_hint.TabIndex = 22;
            this.lbl_naming_columns_hint.Text = "use a comma(,) to separate the different columns ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 732);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Baby Upload Converter";
            this.tabPage_CSV.ResumeLayout(false);
            this.tabPage_CSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).EndInit();
            this.tabPageEXCEL.ResumeLayout(false);
            this.tabPageEXCEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.tabPage_HOME.ResumeLayout(false);
            this.tabPage_HOME.PerformLayout();
            this.panelShadowBox.ResumeLayout(false);
            this.panelShadowBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage_CSV;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_csv_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close_csv;
        private System.Windows.Forms.DataGridView dataGridViewCSV;
        private System.Windows.Forms.TabPage tabPageEXCEL;
        private System.Windows.Forms.Label lbl_process_btn;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_excel_path;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_close_excel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.TabPage tabPage_HOME;
        private System.Windows.Forms.Panel panelShadowBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_source_columns;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_close_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_naming_columns_hint;
    }
}

