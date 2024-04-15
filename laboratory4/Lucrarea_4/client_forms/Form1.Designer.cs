namespace client_forms
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
            this.lista = new System.Windows.Forms.ListBox();
            this.adaugareListaButton = new System.Windows.Forms.Button();
            this.FToCbutton = new System.Windows.Forms.Button();
            this.CToFButton = new System.Windows.Forms.Button();
            this.temperaturaCTextBox = new System.Windows.Forms.TextBox();
            this.tempFTextBox = new System.Windows.Forms.TextBox();
            this.rezultatConversieTextBox = new System.Windows.Forms.TextBox();
            this.SumaEuroTextBox = new System.Windows.Forms.TextBox();
            this.sumaRonTextBox = new System.Windows.Forms.TextBox();
            this.euroToRonButton = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.Ora = new System.Windows.Forms.Label();
            this.TempC = new System.Windows.Forms.Label();
            this.TempF = new System.Windows.Forms.Label();
            this.rezConv = new System.Windows.Forms.Label();
            this.EuroToRonLabel = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.oraTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 46;
            this.lista.Location = new System.Drawing.Point(54, 86);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(606, 464);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // adaugareListaButton
            // 
            this.adaugareListaButton.Location = new System.Drawing.Point(54, 587);
            this.adaugareListaButton.Name = "adaugareListaButton";
            this.adaugareListaButton.Size = new System.Drawing.Size(606, 62);
            this.adaugareListaButton.TabIndex = 1;
            this.adaugareListaButton.Text = "View List";
            this.adaugareListaButton.UseVisualStyleBackColor = true;
            this.adaugareListaButton.Click += new System.EventHandler(this.adaugareListaButton_Click);
            // 
            // FToCbutton
            // 
            this.FToCbutton.Location = new System.Drawing.Point(1106, 385);
            this.FToCbutton.Name = "FToCbutton";
            this.FToCbutton.Size = new System.Drawing.Size(352, 62);
            this.FToCbutton.TabIndex = 2;
            this.FToCbutton.Text = "F to C";
            this.FToCbutton.UseVisualStyleBackColor = true;
            this.FToCbutton.Click += new System.EventHandler(this.FToCbutton_Click);
            // 
            // CToFButton
            // 
            this.CToFButton.Location = new System.Drawing.Point(1106, 508);
            this.CToFButton.Name = "CToFButton";
            this.CToFButton.Size = new System.Drawing.Size(352, 62);
            this.CToFButton.TabIndex = 3;
            this.CToFButton.Text = "C to F";
            this.CToFButton.UseVisualStyleBackColor = true;
            this.CToFButton.Click += new System.EventHandler(this.CToFButton_Click);
            // 
            // temperaturaCTextBox
            // 
            this.temperaturaCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturaCTextBox.Location = new System.Drawing.Point(1106, 86);
            this.temperaturaCTextBox.Name = "temperaturaCTextBox";
            this.temperaturaCTextBox.Size = new System.Drawing.Size(352, 44);
            this.temperaturaCTextBox.TabIndex = 4;
            this.temperaturaCTextBox.TextChanged += new System.EventHandler(this.temperaturaCTextBox_TextChanged);
            // 
            // tempFTextBox
            // 
            this.tempFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFTextBox.Location = new System.Drawing.Point(1106, 180);
            this.tempFTextBox.Name = "tempFTextBox";
            this.tempFTextBox.Size = new System.Drawing.Size(352, 44);
            this.tempFTextBox.TabIndex = 5;
            this.tempFTextBox.TextChanged += new System.EventHandler(this.tempFTextBox_TextChanged);
            // 
            // rezultatConversieTextBox
            // 
            this.rezultatConversieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatConversieTextBox.Location = new System.Drawing.Point(1106, 280);
            this.rezultatConversieTextBox.Name = "rezultatConversieTextBox";
            this.rezultatConversieTextBox.ReadOnly = true;
            this.rezultatConversieTextBox.Size = new System.Drawing.Size(352, 44);
            this.rezultatConversieTextBox.TabIndex = 6;
            this.rezultatConversieTextBox.TextChanged += new System.EventHandler(this.rezultatConversieTextBox_TextChanged);
            // 
            // SumaEuroTextBox
            // 
            this.SumaEuroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumaEuroTextBox.Location = new System.Drawing.Point(1106, 645);
            this.SumaEuroTextBox.Name = "SumaEuroTextBox";
            this.SumaEuroTextBox.Size = new System.Drawing.Size(352, 44);
            this.SumaEuroTextBox.TabIndex = 7;
            this.SumaEuroTextBox.TextChanged += new System.EventHandler(this.SumaEuroTextBox_TextChanged);
            // 
            // sumaRonTextBox
            // 
            this.sumaRonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaRonTextBox.Location = new System.Drawing.Point(1106, 711);
            this.sumaRonTextBox.Name = "sumaRonTextBox";
            this.sumaRonTextBox.ReadOnly = true;
            this.sumaRonTextBox.Size = new System.Drawing.Size(352, 44);
            this.sumaRonTextBox.TabIndex = 8;
            this.sumaRonTextBox.TextChanged += new System.EventHandler(this.sumaRonTextBox_TextChanged);
            // 
            // euroToRonButton
            // 
            this.euroToRonButton.Location = new System.Drawing.Point(1106, 804);
            this.euroToRonButton.Name = "euroToRonButton";
            this.euroToRonButton.Size = new System.Drawing.Size(352, 62);
            this.euroToRonButton.TabIndex = 9;
            this.euroToRonButton.Text = "Convert Ron To Euro";
            this.euroToRonButton.UseVisualStyleBackColor = true;
            this.euroToRonButton.Click += new System.EventHandler(this.euroToRonButton_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(58, 711);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(89, 37);
            this.Data.TabIndex = 10;
            this.Data.Text = "Data";
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Ora
            // 
            this.Ora.AutoSize = true;
            this.Ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ora.Location = new System.Drawing.Point(58, 812);
            this.Ora.Name = "Ora";
            this.Ora.Size = new System.Drawing.Size(74, 37);
            this.Ora.TabIndex = 11;
            this.Ora.Text = "Ora";
            this.Ora.Click += new System.EventHandler(this.Ora_Click);
            // 
            // TempC
            // 
            this.TempC.AutoSize = true;
            this.TempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempC.Location = new System.Drawing.Point(779, 93);
            this.TempC.Name = "TempC";
            this.TempC.Size = new System.Drawing.Size(246, 37);
            this.TempC.TabIndex = 12;
            this.TempC.Text = "Temperatura C";
            this.TempC.Click += new System.EventHandler(this.TempC_Click);
            // 
            // TempF
            // 
            this.TempF.AutoSize = true;
            this.TempF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempF.Location = new System.Drawing.Point(779, 183);
            this.TempF.Name = "TempF";
            this.TempF.Size = new System.Drawing.Size(243, 37);
            this.TempF.TabIndex = 13;
            this.TempF.Text = "Temperatura F";
            this.TempF.Click += new System.EventHandler(this.TempF_Click);
            // 
            // rezConv
            // 
            this.rezConv.AutoSize = true;
            this.rezConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezConv.Location = new System.Drawing.Point(779, 280);
            this.rezConv.Name = "rezConv";
            this.rezConv.Size = new System.Drawing.Size(295, 37);
            this.rezConv.TabIndex = 14;
            this.rezConv.Text = "Rezultat conversie";
            this.rezConv.Click += new System.EventHandler(this.rezConv_Click);
            // 
            // EuroToRonLabel
            // 
            this.EuroToRonLabel.AutoSize = true;
            this.EuroToRonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroToRonLabel.Location = new System.Drawing.Point(779, 645);
            this.EuroToRonLabel.Name = "EuroToRonLabel";
            this.EuroToRonLabel.Size = new System.Drawing.Size(199, 37);
            this.EuroToRonLabel.TabIndex = 15;
            this.EuroToRonLabel.Text = "Ron to Euro";
            this.EuroToRonLabel.Click += new System.EventHandler(this.EuroToRonLabel_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(308, 704);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(352, 44);
            this.dataTextBox.TabIndex = 16;
            this.dataTextBox.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            // 
            // oraTextBox
            // 
            this.oraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oraTextBox.Location = new System.Drawing.Point(308, 804);
            this.oraTextBox.Name = "oraTextBox";
            this.oraTextBox.Size = new System.Drawing.Size(352, 44);
            this.oraTextBox.TabIndex = 17;
            this.oraTextBox.TextChanged += new System.EventHandler(this.oraTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 899);
            this.Controls.Add(this.oraTextBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.EuroToRonLabel);
            this.Controls.Add(this.rezConv);
            this.Controls.Add(this.TempF);
            this.Controls.Add(this.TempC);
            this.Controls.Add(this.Ora);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.euroToRonButton);
            this.Controls.Add(this.sumaRonTextBox);
            this.Controls.Add(this.SumaEuroTextBox);
            this.Controls.Add(this.rezultatConversieTextBox);
            this.Controls.Add(this.tempFTextBox);
            this.Controls.Add(this.temperaturaCTextBox);
            this.Controls.Add(this.CToFButton);
            this.Controls.Add(this.FToCbutton);
            this.Controls.Add(this.adaugareListaButton);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button adaugareListaButton;
        private System.Windows.Forms.Button FToCbutton;
        private System.Windows.Forms.Button CToFButton;
        private System.Windows.Forms.TextBox temperaturaCTextBox;
        private System.Windows.Forms.TextBox tempFTextBox;
        private System.Windows.Forms.TextBox rezultatConversieTextBox;
        private System.Windows.Forms.TextBox SumaEuroTextBox;
        private System.Windows.Forms.TextBox sumaRonTextBox;
        private System.Windows.Forms.Button euroToRonButton;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Ora;
        private System.Windows.Forms.Label TempC;
        private System.Windows.Forms.Label TempF;
        private System.Windows.Forms.Label rezConv;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox oraTextBox;
        private System.Windows.Forms.Label EuroToRonLabel;
    }
}

