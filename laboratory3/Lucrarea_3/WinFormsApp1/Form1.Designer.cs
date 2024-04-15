namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            button_DeleteUniv = new Button();
            button_UpdateUniv = new Button();
            button_InsertUniv = new Button();
            textBox_CodUniv = new TextBox();
            textBox_City = new TextBox();
            textBox_NameUniv = new TextBox();
            textBox_IdUniv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBox_Fac = new ListBox();
            listBox_Univ = new ListBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dataGridView1.Location = new Point(1196, 148);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(687, 729);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NameFac";
            Column3.HeaderText = "NumeFac";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Code";
            Column2.HeaderText = "NumeUniv";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // button_DeleteUniv
            // 
            button_DeleteUniv.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_DeleteUniv.Location = new Point(1067, 924);
            button_DeleteUniv.Margin = new Padding(4, 4, 4, 4);
            button_DeleteUniv.Name = "button_DeleteUniv";
            button_DeleteUniv.Size = new Size(372, 86);
            button_DeleteUniv.TabIndex = 15;
            button_DeleteUniv.Text = "Stergere";
            button_DeleteUniv.UseVisualStyleBackColor = true;
            button_DeleteUniv.Click += button_DeleteUniv_Click;
            // 
            // button_UpdateUniv
            // 
            button_UpdateUniv.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_UpdateUniv.Location = new Point(602, 925);
            button_UpdateUniv.Margin = new Padding(4, 4, 4, 4);
            button_UpdateUniv.Name = "button_UpdateUniv";
            button_UpdateUniv.Size = new Size(381, 86);
            button_UpdateUniv.TabIndex = 14;
            button_UpdateUniv.Text = "Actualizare";
            button_UpdateUniv.UseVisualStyleBackColor = true;
            button_UpdateUniv.Click += button_UpdateUniv_Click;
            // 
            // button_InsertUniv
            // 
            button_InsertUniv.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_InsertUniv.Location = new Point(62, 925);
            button_InsertUniv.Margin = new Padding(4, 4, 4, 4);
            button_InsertUniv.Name = "button_InsertUniv";
            button_InsertUniv.Size = new Size(437, 86);
            button_InsertUniv.TabIndex = 13;
            button_InsertUniv.Text = "Introducere";
            button_InsertUniv.UseVisualStyleBackColor = true;
            button_InsertUniv.Click += button_InsertUniv_Click;
            // 
            // textBox_CodUniv
            // 
            textBox_CodUniv.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_CodUniv.Location = new Point(602, 832);
            textBox_CodUniv.Margin = new Padding(4, 4, 4, 4);
            textBox_CodUniv.Name = "textBox_CodUniv";
            textBox_CodUniv.ReadOnly = true;
            textBox_CodUniv.Size = new Size(532, 45);
            textBox_CodUniv.TabIndex = 11;
            // 
            // textBox_City
            // 
            textBox_City.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_City.Location = new Point(602, 693);
            textBox_City.Margin = new Padding(4, 4, 4, 4);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(532, 45);
            textBox_City.TabIndex = 10;
            // 
            // textBox_NameUniv
            // 
            textBox_NameUniv.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_NameUniv.Location = new Point(602, 541);
            textBox_NameUniv.Margin = new Padding(4, 4, 4, 4);
            textBox_NameUniv.Name = "textBox_NameUniv";
            textBox_NameUniv.Size = new Size(532, 45);
            textBox_NameUniv.TabIndex = 9;
            // 
            // textBox_IdUniv
            // 
            textBox_IdUniv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IdUniv.Location = new Point(602, 417);
            textBox_IdUniv.Margin = new Padding(4, 4, 4, 4);
            textBox_IdUniv.Name = "textBox_IdUniv";
            textBox_IdUniv.Size = new Size(532, 45);
            textBox_IdUniv.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(603, 774);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(183, 54);
            label6.TabIndex = 7;
            label6.Text = "CodUniv";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(602, 621);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 54);
            label5.TabIndex = 6;
            label5.Text = "Oras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(602, 483);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 54);
            label4.TabIndex = 5;
            label4.Text = "NumeUniv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(602, 359);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 54);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // listBox_Fac
            // 
            listBox_Fac.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_Fac.FormattingEnabled = true;
            listBox_Fac.ItemHeight = 45;
            listBox_Fac.Location = new Point(602, 148);
            listBox_Fac.Margin = new Padding(4, 4, 4, 4);
            listBox_Fac.Name = "listBox_Fac";
            listBox_Fac.Size = new Size(532, 184);
            listBox_Fac.TabIndex = 3;
            // 
            // listBox_Univ
            // 
            listBox_Univ.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_Univ.FormattingEnabled = true;
            listBox_Univ.ItemHeight = 45;
            listBox_Univ.Location = new Point(62, 148);
            listBox_Univ.Margin = new Padding(4, 4, 4, 4);
            listBox_Univ.Name = "listBox_Univ";
            listBox_Univ.Size = new Size(465, 724);
            listBox_Univ.TabIndex = 2;
            listBox_Univ.SelectedIndexChanged += listBox_Univ_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(602, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 54);
            label2.TabIndex = 1;
            label2.Text = "Facultati";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 54);
            label1.TabIndex = 0;
            label1.Text = "Universitati";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1541, 925);
            button1.Name = "button1";
            button1.Size = new Size(342, 86);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1963, 1084);
            Controls.Add(button1);
            Controls.Add(textBox_CodUniv);
            Controls.Add(button_UpdateUniv);
            Controls.Add(label6);
            Controls.Add(textBox_City);
            Controls.Add(button_DeleteUniv);
            Controls.Add(textBox_NameUniv);
            Controls.Add(label5);
            Controls.Add(button_InsertUniv);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listBox_Univ);
            Controls.Add(label2);
            Controls.Add(listBox_Fac);
            Controls.Add(textBox_IdUniv);
            Controls.Add(label3);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ListBox listBox_Fac;
        private ListBox listBox_Univ;
        private Label label2;
        private Label label1;
        private TextBox textBox_NameUniv;
        private TextBox textBox_IdUniv;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button_DeleteUniv;
        private Button button_UpdateUniv;
        private Button button_InsertUniv;
        private TextBox textBox_CodUniv;
        private TextBox textBox_City;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewComboBoxColumn Column2;
        private Button button1;
    }
}