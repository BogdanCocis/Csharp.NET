namespace Lucrarea_3_universitati
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
            listBoxUniversitati = new ListBox();
            textBoxCodUniv = new TextBox();
            textBoxOras = new TextBox();
            Oras = new Label();
            CodUniv = new Label();
            universitati = new Label();
            Facultati = new Label();
            listBoxFacultatii = new ListBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // listBoxUniversitati
            // 
            listBoxUniversitati.FormattingEnabled = true;
            listBoxUniversitati.ItemHeight = 25;
            listBoxUniversitati.Location = new Point(97, 151);
            listBoxUniversitati.Name = "listBoxUniversitati";
            listBoxUniversitati.Size = new Size(629, 904);
            listBoxUniversitati.TabIndex = 0;
            listBoxUniversitati.SelectedIndexChanged += listBoxUniversitati_SelectedIndexChanged;
            // 
            // textBoxCodUniv
            // 
            textBoxCodUniv.Location = new Point(1118, 1024);
            textBoxCodUniv.Name = "textBoxCodUniv";
            textBoxCodUniv.ReadOnly = true;
            textBoxCodUniv.Size = new Size(466, 31);
            textBoxCodUniv.TabIndex = 2;
            // 
            // textBoxOras
            // 
            textBoxOras.Location = new Point(1118, 785);
            textBoxOras.Name = "textBoxOras";
            textBoxOras.ReadOnly = true;
            textBoxOras.Size = new Size(466, 31);
            textBoxOras.TabIndex = 3;
            // 
            // Oras
            // 
            Oras.AutoSize = true;
            Oras.Location = new Point(1118, 726);
            Oras.Name = "Oras";
            Oras.Size = new Size(49, 25);
            Oras.TabIndex = 4;
            Oras.Text = "Oras";
            // 
            // CodUniv
            // 
            CodUniv.AutoSize = true;
            CodUniv.Location = new Point(1118, 968);
            CodUniv.Name = "CodUniv";
            CodUniv.Size = new Size(85, 25);
            CodUniv.TabIndex = 5;
            CodUniv.Text = "Cod Univ";
            // 
            // universitati
            // 
            universitati.AutoSize = true;
            universitati.Location = new Point(97, 87);
            universitati.Name = "universitati";
            universitati.Size = new Size(99, 25);
            universitati.TabIndex = 6;
            universitati.Text = "Universitati";
            // 
            // Facultati
            // 
            Facultati.AutoSize = true;
            Facultati.Location = new Point(1118, 97);
            Facultati.Name = "Facultati";
            Facultati.Size = new Size(80, 25);
            Facultati.TabIndex = 7;
            Facultati.Text = "Facultatii";
            // 
            // listBoxFacultatii
            // 
            listBoxFacultatii.FormattingEnabled = true;
            listBoxFacultatii.ItemHeight = 25;
            listBoxFacultatii.Location = new Point(1101, 151);
            listBoxFacultatii.Name = "listBoxFacultatii";
            listBoxFacultatii.Size = new Size(554, 529);
            listBoxFacultatii.TabIndex = 8;
            // 
            // Exit
            // 
            Exit.Location = new Point(1665, 1148);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 9;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 1252);
            Controls.Add(Exit);
            Controls.Add(listBoxFacultatii);
            Controls.Add(Facultati);
            Controls.Add(universitati);
            Controls.Add(CodUniv);
            Controls.Add(Oras);
            Controls.Add(textBoxOras);
            Controls.Add(textBoxCodUniv);
            Controls.Add(listBoxUniversitati);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUniversitati;
        private ListView listView1;
        private TextBox textBoxCodUniv;
        private TextBox textBoxOras;
        private Label Oras;
        private Label CodUniv;
        private Label universitati;
        private Label Facultati;
        private ListBox listBoxFacultatii;
        private Button Exit;
    }
}
