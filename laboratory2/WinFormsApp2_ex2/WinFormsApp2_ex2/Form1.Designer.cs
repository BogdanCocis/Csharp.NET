namespace WinFormsApp2_ex2
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            Copiaza = new Button();
            Sterge = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(129, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 529);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(981, 114);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(336, 529);
            listBox2.TabIndex = 1;
            // 
            // Copiaza
            // 
            Copiaza.Location = new Point(690, 219);
            Copiaza.Name = "Copiaza";
            Copiaza.Size = new Size(112, 34);
            Copiaza.TabIndex = 2;
            Copiaza.Text = "Copiaza";
            Copiaza.UseVisualStyleBackColor = true;
            Copiaza.Click += Copiaza_Click;
            // 
            // Sterge
            // 
            Sterge.Location = new Point(690, 441);
            Sterge.Name = "Sterge";
            Sterge.Size = new Size(112, 34);
            Sterge.TabIndex = 3;
            Sterge.Text = "Sterge";
            Sterge.UseVisualStyleBackColor = true;
            Sterge.Click += Sterge_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1231, 776);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 929);
            Controls.Add(Exit);
            Controls.Add(Sterge);
            Controls.Add(Copiaza);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button Copiaza;
        private Button Sterge;
        private Button Exit;
    }
}
