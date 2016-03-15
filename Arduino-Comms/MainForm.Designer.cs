namespace Arduino_Comms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.PortSettingsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartSendButton = new System.Windows.Forms.Button();
            this.ReadVolumeLevelTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ReceivingDataLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.COMConnectedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReceivingDataTimer = new System.Windows.Forms.Timer(this.components);
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StopSendButton = new System.Windows.Forms.Button();
            this.OnRadioButton = new System.Windows.Forms.RadioButton();
            this.OffRadioButton = new System.Windows.Forms.RadioButton();
            this.DimRadioButton = new System.Windows.Forms.RadioButton();
            this.SoundRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DimTrackBar = new System.Windows.Forms.TrackBar();
            this.rgbColorDialog = new System.Windows.Forms.ColorDialog();
            this.RGBGroupBox = new System.Windows.Forms.GroupBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.ChooseColorButton = new System.Windows.Forms.Button();
            this.SelectedColorRadioButton = new System.Windows.Forms.RadioButton();
            this.AutoChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimTrackBar)).BeginInit();
            this.RGBGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PortSettingsButton
            // 
            this.PortSettingsButton.Location = new System.Drawing.Point(496, 23);
            this.PortSettingsButton.Name = "PortSettingsButton";
            this.PortSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.PortSettingsButton.TabIndex = 1;
            this.PortSettingsButton.Text = "Port Settings";
            this.PortSettingsButton.UseVisualStyleBackColor = true;
            this.PortSettingsButton.Click += new System.EventHandler(this.PortSettingsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 376);
            this.textBox1.TabIndex = 2;
            // 
            // StartSendButton
            // 
            this.StartSendButton.Location = new System.Drawing.Point(21, 47);
            this.StartSendButton.Name = "StartSendButton";
            this.StartSendButton.Size = new System.Drawing.Size(87, 23);
            this.StartSendButton.TabIndex = 3;
            this.StartSendButton.Text = "Start send";
            this.StartSendButton.UseVisualStyleBackColor = true;
            this.StartSendButton.Click += new System.EventHandler(this.StartSendData_Click);
            // 
            // ReadVolumeLevelTimer
            // 
            this.ReadVolumeLevelTimer.Tick += new System.EventHandler(this.ReadVolumeLevelTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReceivingDataLabel,
            this.COMConnectedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(637, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ReceivingDataLabel
            // 
            this.ReceivingDataLabel.ForeColor = System.Drawing.Color.Red;
            this.ReceivingDataLabel.Name = "ReceivingDataLabel";
            this.ReceivingDataLabel.Size = new System.Drawing.Size(85, 17);
            this.ReceivingDataLabel.Text = "Receiving Data";
            // 
            // COMConnectedLabel
            // 
            this.COMConnectedLabel.Name = "COMConnectedLabel";
            this.COMConnectedLabel.Size = new System.Drawing.Size(96, 17);
            this.COMConnectedLabel.Text = "COM Connected";
            // 
            // ReceivingDataTimer
            // 
            this.ReceivingDataTimer.Tick += new System.EventHandler(this.ReceivingDataTimer_Tick);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(114, 18);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(89, 23);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "AudioSettingsButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StopSendButton
            // 
            this.StopSendButton.Location = new System.Drawing.Point(114, 47);
            this.StopSendButton.Name = "StopSendButton";
            this.StopSendButton.Size = new System.Drawing.Size(89, 23);
            this.StopSendButton.TabIndex = 7;
            this.StopSendButton.Text = "Stop send";
            this.StopSendButton.UseVisualStyleBackColor = true;
            this.StopSendButton.Click += new System.EventHandler(this.StopSendButton_Click);
            // 
            // OnRadioButton
            // 
            this.OnRadioButton.AutoSize = true;
            this.OnRadioButton.Checked = true;
            this.OnRadioButton.Location = new System.Drawing.Point(11, 19);
            this.OnRadioButton.Name = "OnRadioButton";
            this.OnRadioButton.Size = new System.Drawing.Size(41, 17);
            this.OnRadioButton.TabIndex = 8;
            this.OnRadioButton.TabStop = true;
            this.OnRadioButton.Text = "ON";
            this.OnRadioButton.UseVisualStyleBackColor = true;
            // 
            // OffRadioButton
            // 
            this.OffRadioButton.AutoSize = true;
            this.OffRadioButton.Location = new System.Drawing.Point(11, 43);
            this.OffRadioButton.Name = "OffRadioButton";
            this.OffRadioButton.Size = new System.Drawing.Size(45, 17);
            this.OffRadioButton.TabIndex = 9;
            this.OffRadioButton.Text = "OFF";
            this.OffRadioButton.UseVisualStyleBackColor = true;
            // 
            // DimRadioButton
            // 
            this.DimRadioButton.AutoSize = true;
            this.DimRadioButton.Location = new System.Drawing.Point(11, 89);
            this.DimRadioButton.Name = "DimRadioButton";
            this.DimRadioButton.Size = new System.Drawing.Size(45, 17);
            this.DimRadioButton.TabIndex = 10;
            this.DimRadioButton.Text = "DIM";
            this.DimRadioButton.UseVisualStyleBackColor = true;
            // 
            // SoundRadioButton
            // 
            this.SoundRadioButton.AutoSize = true;
            this.SoundRadioButton.Location = new System.Drawing.Point(11, 66);
            this.SoundRadioButton.Name = "SoundRadioButton";
            this.SoundRadioButton.Size = new System.Drawing.Size(64, 17);
            this.SoundRadioButton.TabIndex = 11;
            this.SoundRadioButton.Text = "SOUND";
            this.SoundRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DimTrackBar);
            this.groupBox1.Controls.Add(this.DimRadioButton);
            this.groupBox1.Controls.Add(this.SoundRadioButton);
            this.groupBox1.Controls.Add(this.OnRadioButton);
            this.groupBox1.Controls.Add(this.OffRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 157);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // DimTrackBar
            // 
            this.DimTrackBar.Location = new System.Drawing.Point(0, 118);
            this.DimTrackBar.Maximum = 150;
            this.DimTrackBar.Name = "DimTrackBar";
            this.DimTrackBar.Size = new System.Drawing.Size(176, 45);
            this.DimTrackBar.TabIndex = 13;
            this.DimTrackBar.Value = 150;
            this.DimTrackBar.Scroll += new System.EventHandler(this.DimTrackBar_Scroll);
            // 
            // RGBGroupBox
            // 
            this.RGBGroupBox.Controls.Add(this.SetColorButton);
            this.RGBGroupBox.Controls.Add(this.ChooseColorButton);
            this.RGBGroupBox.Controls.Add(this.SelectedColorRadioButton);
            this.RGBGroupBox.Controls.Add(this.AutoChangeRadioButton);
            this.RGBGroupBox.Location = new System.Drawing.Point(12, 268);
            this.RGBGroupBox.Name = "RGBGroupBox";
            this.RGBGroupBox.Size = new System.Drawing.Size(201, 131);
            this.RGBGroupBox.TabIndex = 13;
            this.RGBGroupBox.TabStop = false;
            this.RGBGroupBox.Text = "RGB led Strip";
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(116, 102);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(75, 23);
            this.SetColorButton.TabIndex = 3;
            this.SetColorButton.Text = "Set Color";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // ChooseColorButton
            // 
            this.ChooseColorButton.Location = new System.Drawing.Point(108, 40);
            this.ChooseColorButton.Name = "ChooseColorButton";
            this.ChooseColorButton.Size = new System.Drawing.Size(83, 23);
            this.ChooseColorButton.TabIndex = 2;
            this.ChooseColorButton.Text = "Choose Color";
            this.ChooseColorButton.UseVisualStyleBackColor = true;
            this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // SelectedColorRadioButton
            // 
            this.SelectedColorRadioButton.AutoSize = true;
            this.SelectedColorRadioButton.Location = new System.Drawing.Point(9, 43);
            this.SelectedColorRadioButton.Name = "SelectedColorRadioButton";
            this.SelectedColorRadioButton.Size = new System.Drawing.Size(94, 17);
            this.SelectedColorRadioButton.TabIndex = 1;
            this.SelectedColorRadioButton.Text = "Selected Color";
            this.SelectedColorRadioButton.UseVisualStyleBackColor = true;
            // 
            // AutoChangeRadioButton
            // 
            this.AutoChangeRadioButton.AutoSize = true;
            this.AutoChangeRadioButton.Checked = true;
            this.AutoChangeRadioButton.Location = new System.Drawing.Point(9, 19);
            this.AutoChangeRadioButton.Name = "AutoChangeRadioButton";
            this.AutoChangeRadioButton.Size = new System.Drawing.Size(87, 17);
            this.AutoChangeRadioButton.TabIndex = 0;
            this.AutoChangeRadioButton.TabStop = true;
            this.AutoChangeRadioButton.Text = "Auto Change";
            this.AutoChangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.StartSendButton);
            this.groupBox3.Controls.Add(this.StopSendButton);
            this.groupBox3.Controls.Add(this.DisconnectButton);
            this.groupBox3.Location = new System.Drawing.Point(0, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 239);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dimmer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RGBGroupBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PortSettingsButton);
            this.Name = "MainForm";
            this.Text = "Arduino-Comms";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimTrackBar)).EndInit();
            this.RGBGroupBox.ResumeLayout(false);
            this.RGBGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PortSettingsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartSendButton;
        private System.Windows.Forms.Timer ReadVolumeLevelTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ReceivingDataLabel;
        private System.Windows.Forms.Timer ReceivingDataTimer;
        private System.Windows.Forms.ToolStripStatusLabel COMConnectedLabel;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button StopSendButton;
        private System.Windows.Forms.RadioButton OnRadioButton;
        private System.Windows.Forms.RadioButton OffRadioButton;
        private System.Windows.Forms.RadioButton DimRadioButton;
        private System.Windows.Forms.RadioButton SoundRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar DimTrackBar;
        private System.Windows.Forms.ColorDialog rgbColorDialog;
        private System.Windows.Forms.GroupBox RGBGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ChooseColorButton;
        private System.Windows.Forms.RadioButton SelectedColorRadioButton;
        private System.Windows.Forms.RadioButton AutoChangeRadioButton;
        private System.Windows.Forms.Button SetColorButton;
    }
}

