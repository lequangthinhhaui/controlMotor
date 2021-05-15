
namespace ControlMotor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleTime = new System.Windows.Forms.Label();
            this.tmScanTime = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.palMain = new System.Windows.Forms.Panel();
            this.lblMotorDirection = new System.Windows.Forms.Label();
            this.lblTitleMotorDirection = new System.Windows.Forms.Label();
            this.lblCurrentSpeedUnit = new System.Windows.Forms.Label();
            this.lblCurrentSpeedDisplay = new System.Windows.Forms.Label();
            this.lblTitleCurrentSpeed = new System.Windows.Forms.Label();
            this.lblTitleStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.palMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTime
            // 
            this.titleTime.AutoSize = true;
            this.titleTime.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.titleTime.Location = new System.Drawing.Point(53, 16);
            this.titleTime.Name = "titleTime";
            this.titleTime.Size = new System.Drawing.Size(188, 35);
            this.titleTime.TabIndex = 0;
            this.titleTime.Text = "Current Local Time";
            // 
            // tmScanTime
            // 
            this.tmScanTime.Tick += new System.EventHandler(this.tmScanTime_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.titleTime);
            this.panel1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(12, 655);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 96);
            this.panel1.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDay.Location = new System.Drawing.Point(120, 51);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(73, 31);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Monday";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDate.Location = new System.Drawing.Point(3, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 31);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "June 19 2000";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTime.Location = new System.Drawing.Point(199, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 31);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "22:22:22";
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.Red;
            this.mainTitle.Location = new System.Drawing.Point(101, 33);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(1098, 86);
            this.mainTitle.TabIndex = 2;
            this.mainTitle.Text = "CONTROLLING DC MOTOR SPEED";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainTitle.Click += new System.EventHandler(this.mainTitle_Click);
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.lblMotorDirection);
            this.palMain.Controls.Add(this.lblTitleMotorDirection);
            this.palMain.Controls.Add(this.lblCurrentSpeedUnit);
            this.palMain.Controls.Add(this.lblCurrentSpeedDisplay);
            this.palMain.Controls.Add(this.lblTitleCurrentSpeed);
            this.palMain.Location = new System.Drawing.Point(753, 325);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(537, 128);
            this.palMain.TabIndex = 3;
            // 
            // lblMotorDirection
            // 
            this.lblMotorDirection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorDirection.Location = new System.Drawing.Point(337, 64);
            this.lblMotorDirection.Name = "lblMotorDirection";
            this.lblMotorDirection.Size = new System.Drawing.Size(178, 41);
            this.lblMotorDirection.TabIndex = 4;
            this.lblMotorDirection.Text = "Forward";
            this.lblMotorDirection.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTitleMotorDirection
            // 
            this.lblTitleMotorDirection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMotorDirection.Location = new System.Drawing.Point(3, 64);
            this.lblTitleMotorDirection.Name = "lblTitleMotorDirection";
            this.lblTitleMotorDirection.Size = new System.Drawing.Size(328, 41);
            this.lblTitleMotorDirection.TabIndex = 3;
            this.lblTitleMotorDirection.Text = "Motor Direction:";
            // 
            // lblCurrentSpeedUnit
            // 
            this.lblCurrentSpeedUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSpeedUnit.Location = new System.Drawing.Point(436, 9);
            this.lblCurrentSpeedUnit.Name = "lblCurrentSpeedUnit";
            this.lblCurrentSpeedUnit.Size = new System.Drawing.Size(115, 41);
            this.lblCurrentSpeedUnit.TabIndex = 2;
            this.lblCurrentSpeedUnit.Text = "RPM";
            // 
            // lblCurrentSpeedDisplay
            // 
            this.lblCurrentSpeedDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSpeedDisplay.Location = new System.Drawing.Point(320, 9);
            this.lblCurrentSpeedDisplay.Name = "lblCurrentSpeedDisplay";
            this.lblCurrentSpeedDisplay.Size = new System.Drawing.Size(125, 41);
            this.lblCurrentSpeedDisplay.TabIndex = 1;
            this.lblCurrentSpeedDisplay.Text = "2000";
            // 
            // lblTitleCurrentSpeed
            // 
            this.lblTitleCurrentSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCurrentSpeed.Location = new System.Drawing.Point(3, 9);
            this.lblTitleCurrentSpeed.Name = "lblTitleCurrentSpeed";
            this.lblTitleCurrentSpeed.Size = new System.Drawing.Size(311, 41);
            this.lblTitleCurrentSpeed.TabIndex = 0;
            this.lblTitleCurrentSpeed.Text = "Current Speed:";
            // 
            // lblTitleStatus
            // 
            this.lblTitleStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleStatus.Location = new System.Drawing.Point(873, 169);
            this.lblTitleStatus.Name = "lblTitleStatus";
            this.lblTitleStatus.Size = new System.Drawing.Size(344, 41);
            this.lblTitleStatus.TabIndex = 5;
            this.lblTitleStatus.Text = "Status Of Motor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Controls.Add(this.cbDirection);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtSetSpeed);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(40, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 251);
            this.panel2.TabIndex = 4;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSet.Location = new System.Drawing.Point(12, 151);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(237, 87);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // cbDirection
            // 
            this.cbDirection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDirection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDirection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Items.AddRange(new object[] {
            "Foward",
            "Reverse"});
            this.cbDirection.Location = new System.Drawing.Point(288, 75);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(198, 46);
            this.cbDirection.TabIndex = 11;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            this.cbDirection.SelectedValueChanged += new System.EventHandler(this.cbDirection_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "RPM";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set Direction:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 87);
            this.button2.TabIndex = 8;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSetSpeed
            // 
            this.txtSetSpeed.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetSpeed.Location = new System.Drawing.Point(288, 3);
            this.txtSetSpeed.Name = "txtSetSpeed";
            this.txtSetSpeed.Size = new System.Drawing.Size(198, 47);
            this.txtSetSpeed.TabIndex = 7;
            this.txtSetSpeed.TextChanged += new System.EventHandler(this.txtSetSpeed_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Speed:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Control Panel";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(70, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 60);
            this.button3.TabIndex = 13;
            this.button3.Text = "Man";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(429, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 60);
            this.button4.TabIndex = 14;
            this.button4.Text = "Auto";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(30, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 493);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(734, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 493);
            this.panel4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 763);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTitleStatus);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Controlling DC Motor Speed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleTime;
        private System.Windows.Forms.Timer tmScanTime;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Label lblCurrentSpeedUnit;
        private System.Windows.Forms.Label lblCurrentSpeedDisplay;
        private System.Windows.Forms.Label lblMotorDirection;
        private System.Windows.Forms.Label lblTitleMotorDirection;
        private System.Windows.Forms.Label lblTitleStatus;
        private System.Windows.Forms.Label lblTitleCurrentSpeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

