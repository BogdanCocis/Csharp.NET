namespace WinFormsApp1_ex1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            labelMedia = new Label();
            studentListBox = new ListBox();
            mediaTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            mediaPonderataLabel = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(779, 604);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMedia
            // 
            labelMedia.BackColor = Color.FromArgb(64, 64, 64);
            labelMedia.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMedia.ForeColor = SystemColors.ButtonFace;
            labelMedia.Location = new Point(714, 323);
            labelMedia.Name = "labelMedia";
            labelMedia.Size = new Size(296, 44);
            labelMedia.TabIndex = 1;
            labelMedia.Text = "Media";
            labelMedia.Click += label1_Click;
            // 
            // studentListBox
            // 
            studentListBox.BackColor = Color.FromArgb(64, 64, 64);
            studentListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentListBox.ForeColor = SystemColors.HighlightText;
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 32;
            studentListBox.Location = new Point(219, 91);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(437, 516);
            studentListBox.TabIndex = 2;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // mediaTextBox
            // 
            mediaTextBox.BackColor = Color.White;
            mediaTextBox.Location = new Point(714, 385);
            mediaTextBox.Name = "mediaTextBox";
            mediaTextBox.ReadOnly = true;
            mediaTextBox.Size = new Size(296, 31);
            mediaTextBox.TabIndex = 3;
            mediaTextBox.TextChanged += mediaTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(779, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 217);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hELPToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1258, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(68, 29);
            hELPToolStripMenuItem.Text = "HELP";
            hELPToolStripMenuItem.Click += hELPToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(96, 29);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // mediaPonderataLabel
            // 
            mediaPonderataLabel.BackColor = Color.FromArgb(64, 64, 64);
            mediaPonderataLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediaPonderataLabel.ForeColor = SystemColors.ControlLightLight;
            mediaPonderataLabel.Location = new Point(714, 443);
            mediaPonderataLabel.Name = "mediaPonderataLabel";
            mediaPonderataLabel.Size = new Size(296, 44);
            mediaPonderataLabel.TabIndex = 6;
            mediaPonderataLabel.Text = "Media Ponderata";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(714, 504);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(296, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1258, 664);
            Controls.Add(textBox2);
            Controls.Add(mediaPonderataLabel);
            Controls.Add(pictureBox1);
            Controls.Add(mediaTextBox);
            Controls.Add(studentListBox);
            Controls.Add(labelMedia);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelMedia;
        private ListBox studentListBox;
        private TextBox mediaTextBox;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private Label mediaPonderataLabel;
        private TextBox textBox2;
    }
}