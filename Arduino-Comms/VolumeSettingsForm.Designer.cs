namespace CoreAudioSample
{
    partial class VolumeSettingsForm
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
            this.tbMaster = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pkMaster = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pkLeft = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pkRight = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbOnSet = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOffSet = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OnPeaktextBox1 = new System.Windows.Forms.TextBox();
            this.OffPeaktextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOnSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMaster
            // 
            this.tbMaster.LargeChange = 20;
            this.tbMaster.Location = new System.Drawing.Point(30, 12);
            this.tbMaster.Maximum = 100;
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbMaster.Size = new System.Drawing.Size(45, 88);
            this.tbMaster.SmallChange = 5;
            this.tbMaster.TabIndex = 0;
            this.tbMaster.TickFrequency = 10;
            this.tbMaster.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbMaster.Scroll += new System.EventHandler(this.tbMaster_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Volume";
            // 
            // pkMaster
            // 
            this.pkMaster.Location = new System.Drawing.Point(87, 161);
            this.pkMaster.Name = "pkMaster";
            this.pkMaster.Size = new System.Drawing.Size(202, 13);
            this.pkMaster.Step = 1;
            this.pkMaster.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Master Peak";
            // 
            // pkLeft
            // 
            this.pkLeft.Location = new System.Drawing.Point(87, 195);
            this.pkLeft.Name = "pkLeft";
            this.pkLeft.Size = new System.Drawing.Size(202, 13);
            this.pkLeft.Step = 1;
            this.pkLeft.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Left Peak";
            // 
            // pkRight
            // 
            this.pkRight.Location = new System.Drawing.Point(87, 230);
            this.pkRight.Name = "pkRight";
            this.pkRight.Size = new System.Drawing.Size(202, 13);
            this.pkRight.Step = 1;
            this.pkRight.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Right Peak";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbOnSet
            // 
            this.tbOnSet.LargeChange = 20;
            this.tbOnSet.Location = new System.Drawing.Point(130, 12);
            this.tbOnSet.Maximum = 150;
            this.tbOnSet.Name = "tbOnSet";
            this.tbOnSet.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbOnSet.Size = new System.Drawing.Size(45, 88);
            this.tbOnSet.SmallChange = 5;
            this.tbOnSet.TabIndex = 4;
            this.tbOnSet.TickFrequency = 10;
            this.tbOnSet.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbOnSet.Value = 100;
            this.tbOnSet.Scroll += new System.EventHandler(this.tbOnSet_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "On Peak Value";
            // 
            // tbOffSet
            // 
            this.tbOffSet.LargeChange = 20;
            this.tbOffSet.Location = new System.Drawing.Point(229, 12);
            this.tbOffSet.Maximum = 150;
            this.tbOffSet.Name = "tbOffSet";
            this.tbOffSet.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbOffSet.Size = new System.Drawing.Size(45, 88);
            this.tbOffSet.SmallChange = 5;
            this.tbOffSet.TabIndex = 6;
            this.tbOffSet.TickFrequency = 10;
            this.tbOffSet.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbOffSet.Scroll += new System.EventHandler(this.tbOffSet_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Off Peak Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OnPeaktextBox1
            // 
            this.OnPeaktextBox1.Location = new System.Drawing.Point(115, 120);
            this.OnPeaktextBox1.Name = "OnPeaktextBox1";
            this.OnPeaktextBox1.Size = new System.Drawing.Size(76, 20);
            this.OnPeaktextBox1.TabIndex = 9;
            // 
            // OffPeaktextBox2
            // 
            this.OffPeaktextBox2.Location = new System.Drawing.Point(214, 120);
            this.OffPeaktextBox2.Name = "OffPeaktextBox2";
            this.OffPeaktextBox2.Size = new System.Drawing.Size(76, 20);
            this.OffPeaktextBox2.TabIndex = 9;
            // 
            // VolumeSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 287);
            this.Controls.Add(this.OffPeaktextBox2);
            this.Controls.Add(this.OnPeaktextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOffSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOnSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pkRight);
            this.Controls.Add(this.pkLeft);
            this.Controls.Add(this.pkMaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumeSettingsForm";
            this.Text = "Core Audio Volume Tools";
            ((System.ComponentModel.ISupportInitialize)(this.tbMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOnSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pkMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pkLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pkRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbOnSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbOffSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OnPeaktextBox1;
        private System.Windows.Forms.TextBox OffPeaktextBox2;
    }
}