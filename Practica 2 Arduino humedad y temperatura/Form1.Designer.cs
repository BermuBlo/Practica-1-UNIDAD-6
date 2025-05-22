namespace Practica_2_Arduino_humedad_y_temperatura
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button1_Click_1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.temperature_illustration_on_a_transparent_background_premium_quality_symbols_line_flat_color_icon_for_concept_and_graphic_design_vector;
            pictureBox1.Location = new Point(92, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._669f605ebb34fcfef457baa854ae8e1f;
            pictureBox2.Location = new Point(92, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 161);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 2;
            label1.Text = "TemperaturaLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 354);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 3;
            label2.Text = "HumedadLabel";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(92, 425);
            button1.Name = "button1";
            button1.Size = new Size(182, 41);
            button1.TabIndex = 4;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button1_Click_1
            // 
            button1_Click_1.BackColor = Color.FromArgb(255, 128, 255);
            button1_Click_1.Location = new Point(644, 433);
            button1_Click_1.Name = "button1_Click_1";
            button1_Click_1.Size = new Size(94, 29);
            button1_Click_1.TabIndex = 5;
            button1_Click_1.Text = "Salir";
            button1_Click_1.UseVisualStyleBackColor = false;
            button1_Click_1.Click += button1_Click_1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(362, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 324);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(800, 489);
            Controls.Add(listBox1);
            Controls.Add(button1_Click_1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Temperatura y Humedad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button1_Click_1;
        private ListBox listBox1;
    }
}
