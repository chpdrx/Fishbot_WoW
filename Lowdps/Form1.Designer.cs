namespace Lowdps
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
            this.auto30 = new System.Windows.Forms.CheckBox();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChannelDetect = new System.Windows.Forms.Button();
            this.VolumeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // auto30
            // 
            this.auto30.AutoSize = true;
            this.auto30.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.auto30.Location = new System.Drawing.Point(12, 97);
            this.auto30.Name = "auto30";
            this.auto30.Size = new System.Drawing.Size(125, 23);
            this.auto30.TabIndex = 0;
            this.auto30.Text = "Автонаживка";
            this.auto30.UseVisualStyleBackColor = true;
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.Location = new System.Drawing.Point(0, 0);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(100, 23);
            this.textBoxChannel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // ChannelBox
            // 
            this.ChannelBox.Location = new System.Drawing.Point(12, 12);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(37, 23);
            this.ChannelBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(57, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер канала микшера (с 0)";
            // 
            // ChannelDetect
            // 
            this.ChannelDetect.Location = new System.Drawing.Point(257, 13);
            this.ChannelDetect.Name = "ChannelDetect";
            this.ChannelDetect.Size = new System.Drawing.Size(120, 23);
            this.ChannelDetect.TabIndex = 2;
            this.ChannelDetect.Text = "Определить канал";
            this.ChannelDetect.UseVisualStyleBackColor = true;
            this.ChannelDetect.Click += new System.EventHandler(this.ChannelDetect_Click);
            // 
            // VolumeBox
            // 
            this.VolumeBox.Location = new System.Drawing.Point(12, 41);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(37, 23);
            this.VolumeBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(57, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Уровень звука ловли (0.0-1.0)";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 164);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Закинуто";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.Location = new System.Drawing.Point(76, 79);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(43, 15);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "000000";
            this.CountLabel.Click += new System.EventHandler(this.CountLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(219, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "J - закинуть удочку\r\nH - кнопка взаимодействия\r\nO - использовать поплавок\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(93, 164);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(266, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Slavic edition v2";
            // 
            // Form1
            // 
            this.BackgroundImage = global::Lowdps.Properties.Resources.Screenshot_1130_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(389, 201);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolumeBox);
            this.Controls.Add(this.ChannelDetect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChannelBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 240);
            this.MinimumSize = new System.Drawing.Size(405, 240);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox auto30;
        private TextBox textBoxChannel;
        private Label label1;
        private TextBox ChannelBox;
        private Label label2;
        private Button ChannelDetect;
        private TextBox VolumeBox;
        private Label label3;
        private Button Start;
        private Label label4;
        private Label CountLabel;
        private Label label5;
        private Button StopButton;
        private Label label6;
    }
}