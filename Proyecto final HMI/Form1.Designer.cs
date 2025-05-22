namespace Proyecto_final_HMI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            labelClockRealTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBoxCloseBtn = new PictureBox();
            pictureBoxMinimizeBtn = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            labelCommunicationPort = new Label();
            labelBaudRate = new Label();
            comboBoxCommunicationPort = new ComboBox();
            comboBoxBaudRate = new ComboBox();
            buttonConnect = new Button();
            buttonRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizeBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1129, 617);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Clock";
            // 
            // labelClockRealTime
            // 
            labelClockRealTime.AutoSize = true;
            labelClockRealTime.BackColor = SystemColors.GrayText;
            labelClockRealTime.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelClockRealTime.ForeColor = Color.BlueViolet;
            labelClockRealTime.Location = new Point(1090, 645);
            labelClockRealTime.Name = "labelClockRealTime";
            labelClockRealTime.Size = new Size(120, 46);
            labelClockRealTime.TabIndex = 1;
            labelClockRealTime.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBoxCloseBtn);
            panel1.Controls.Add(pictureBoxMinimizeBtn);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(302, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 81);
            panel1.TabIndex = 2;
            // 
            // pictureBoxCloseBtn
            // 
            pictureBoxCloseBtn.Image = Properties.Resources._54972;
            pictureBoxCloseBtn.Location = new Point(850, 23);
            pictureBoxCloseBtn.Name = "pictureBoxCloseBtn";
            pictureBoxCloseBtn.Size = new Size(36, 37);
            pictureBoxCloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseBtn.TabIndex = 2;
            pictureBoxCloseBtn.TabStop = false;
            pictureBoxCloseBtn.Click += pictureBoxCloseBtn_Click;
            // 
            // pictureBoxMinimizeBtn
            // 
            pictureBoxMinimizeBtn.Image = Properties.Resources._1250668;
            pictureBoxMinimizeBtn.Location = new Point(809, 23);
            pictureBoxMinimizeBtn.Name = "pictureBoxMinimizeBtn";
            pictureBoxMinimizeBtn.Size = new Size(35, 37);
            pictureBoxMinimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimizeBtn.TabIndex = 1;
            pictureBoxMinimizeBtn.TabStop = false;
            pictureBoxMinimizeBtn.Click += pictureBoxMinimizeBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 22);
            label2.Name = "label2";
            label2.Size = new Size(277, 38);
            label2.TabIndex = 0;
            label2.Text = "Project Control Panel";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 333);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_2409;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IMG_14851;
            pictureBox2.Location = new Point(12, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG_2403;
            pictureBox3.Location = new Point(12, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IMG_1101;
            pictureBox4.Location = new Point(12, 253);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 29);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 4;
            label3.Text = "Juan Pablo Bermudez";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 49);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 5;
            label4.Text = "Desarrollador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 130);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 7;
            label5.Text = "Desarrollador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 110);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 6;
            label6.Text = "Rolando Rojas Lobato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 204);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 9;
            label7.Text = "Desarrollador";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(81, 184);
            label8.Name = "label8";
            label8.Size = new Size(190, 20);
            label8.TabIndex = 8;
            label8.Text = "David Alejandro Gonzalez ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 282);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 11;
            label9.Text = "Desarrollador";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(81, 262);
            label10.Name = "label10";
            label10.Size = new Size(157, 20);
            label10.TabIndex = 10;
            label10.Text = "Evan Hernandez Toris";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.WindowFrame;
            panel3.Controls.Add(buttonRefresh);
            panel3.Controls.Add(buttonConnect);
            panel3.Controls.Add(comboBoxBaudRate);
            panel3.Controls.Add(comboBoxCommunicationPort);
            panel3.Controls.Add(labelBaudRate);
            panel3.Controls.Add(labelCommunicationPort);
            panel3.Location = new Point(12, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 352);
            panel3.TabIndex = 4;
            // 
            // labelCommunicationPort
            // 
            labelCommunicationPort.AutoSize = true;
            labelCommunicationPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCommunicationPort.Location = new Point(12, 28);
            labelCommunicationPort.Name = "labelCommunicationPort";
            labelCommunicationPort.Size = new Size(172, 23);
            labelCommunicationPort.TabIndex = 0;
            labelCommunicationPort.Text = "Communication Port:";
            // 
            // labelBaudRate
            // 
            labelBaudRate.AutoSize = true;
            labelBaudRate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBaudRate.Location = new Point(12, 124);
            labelBaudRate.Name = "labelBaudRate";
            labelBaudRate.Size = new Size(93, 23);
            labelBaudRate.TabIndex = 1;
            labelBaudRate.Text = "Baud Rate:";
            // 
            // comboBoxCommunicationPort
            // 
            comboBoxCommunicationPort.FormattingEnabled = true;
            comboBoxCommunicationPort.Location = new Point(12, 64);
            comboBoxCommunicationPort.Name = "comboBoxCommunicationPort";
            comboBoxCommunicationPort.Size = new Size(254, 28);
            comboBoxCommunicationPort.TabIndex = 2;
            // 
            // comboBoxBaudRate
            // 
            comboBoxBaudRate.FormattingEnabled = true;
            comboBoxBaudRate.Location = new Point(12, 160);
            comboBoxBaudRate.Name = "comboBoxBaudRate";
            comboBoxBaudRate.Size = new Size(254, 28);
            comboBoxBaudRate.TabIndex = 3;
            // 
            // buttonConnect
            // 
            buttonConnect.BackColor = SystemColors.HotTrack;
            buttonConnect.FlatStyle = FlatStyle.System;
            buttonConnect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonConnect.Location = new Point(26, 220);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(221, 42);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = false;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatStyle = FlatStyle.System;
            buttonRefresh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonRefresh.Location = new Point(26, 284);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(221, 42);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh Ports";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1256, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelClockRealTime);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizeBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelClockRealTime;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBoxMinimizeBtn;
        private Label label2;
        private PictureBox pictureBoxCloseBtn;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label labelCommunicationPort;
        private Button buttonRefresh;


        private ComboBox comboBoxCommunicationPort;
        private Label labelBaudRate;
    }
}
