namespace usbServoGUI
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
            this.servo0Label = new System.Windows.Forms.Label();
            this.servo0Slider = new System.Windows.Forms.TrackBar();
            this.servo0Value = new System.Windows.Forms.TextBox();
            this.buttonCenterServos = new System.Windows.Forms.Button();
            this.servo1Label = new System.Windows.Forms.Label();
            this.servo1Slider = new System.Windows.Forms.TrackBar();
            this.servo1Value = new System.Windows.Forms.TextBox();
            this.servo2Label = new System.Windows.Forms.Label();
            this.servo2Slider = new System.Windows.Forms.TrackBar();
            this.servo2Value = new System.Windows.Forms.TextBox();
            this.servo3Label = new System.Windows.Forms.Label();
            this.servo3Slider = new System.Windows.Forms.TrackBar();
            this.servo3Value = new System.Windows.Forms.TextBox();
            this.servo4Label = new System.Windows.Forms.Label();
            this.servo4Slider = new System.Windows.Forms.TrackBar();
            this.servo4Value = new System.Windows.Forms.TextBox();
            this.servo5Label = new System.Windows.Forms.Label();
            this.servo5Slider = new System.Windows.Forms.TrackBar();
            this.servo5Value = new System.Windows.Forms.TextBox();
            this.servo6Label = new System.Windows.Forms.Label();
            this.servo6Slider = new System.Windows.Forms.TrackBar();
            this.servo6Value = new System.Windows.Forms.TextBox();
            this.servo7Label = new System.Windows.Forms.Label();
            this.servo7Slider = new System.Windows.Forms.TrackBar();
            this.servo7Value = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.switch0Checkbox = new System.Windows.Forms.CheckBox();
            this.switch1Checkbox = new System.Windows.Forms.CheckBox();
            this.switch3Checkbox = new System.Windows.Forms.CheckBox();
            this.switch2Checkbox = new System.Windows.Forms.CheckBox();
            this.switch7Checkbox = new System.Windows.Forms.CheckBox();
            this.switch6Checkbox = new System.Windows.Forms.CheckBox();
            this.switch5Checkbox = new System.Windows.Forms.CheckBox();
            this.switch4Checkbox = new System.Windows.Forms.CheckBox();
            this.allSwitchesOn = new System.Windows.Forms.Button();
            this.allSwitchesOff = new System.Windows.Forms.Button();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.servo0Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo5Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo6Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo7Slider)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // servo0Label
            // 
            this.servo0Label.AutoSize = true;
            this.servo0Label.Location = new System.Drawing.Point(0, 0);
            this.servo0Label.Name = "servo0Label";
            this.servo0Label.Size = new System.Drawing.Size(44, 13);
            this.servo0Label.TabIndex = 0;
            this.servo0Label.Text = "Servo 0";
            // 
            // servo0Slider
            // 
            this.servo0Slider.Location = new System.Drawing.Point(2, 16);
            this.servo0Slider.Maximum = 255;
            this.servo0Slider.Name = "servo0Slider";
            this.servo0Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo0Slider.Size = new System.Drawing.Size(42, 200);
            this.servo0Slider.TabIndex = 1;
            this.servo0Slider.TickFrequency = 16;
            this.servo0Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo0Slider.Scroll += new System.EventHandler(this.servo0Slider_Scroll);
            // 
            // servo0Value
            // 
            this.servo0Value.Location = new System.Drawing.Point(2, 222);
            this.servo0Value.Name = "servo0Value";
            this.servo0Value.ReadOnly = true;
            this.servo0Value.Size = new System.Drawing.Size(40, 20);
            this.servo0Value.TabIndex = 2;
            // 
            // buttonCenterServos
            // 
            this.buttonCenterServos.Location = new System.Drawing.Point(134, 258);
            this.buttonCenterServos.Name = "buttonCenterServos";
            this.buttonCenterServos.Size = new System.Drawing.Size(100, 23);
            this.buttonCenterServos.TabIndex = 3;
            this.buttonCenterServos.Text = "Center All Servos";
            this.buttonCenterServos.UseVisualStyleBackColor = true;
            this.buttonCenterServos.Click += new System.EventHandler(this.buttonCenterServos_Click);
            // 
            // servo1Label
            // 
            this.servo1Label.AutoSize = true;
            this.servo1Label.Location = new System.Drawing.Point(48, 0);
            this.servo1Label.Name = "servo1Label";
            this.servo1Label.Size = new System.Drawing.Size(44, 13);
            this.servo1Label.TabIndex = 4;
            this.servo1Label.Text = "Servo 1";
            // 
            // servo1Slider
            // 
            this.servo1Slider.Location = new System.Drawing.Point(50, 16);
            this.servo1Slider.Maximum = 255;
            this.servo1Slider.Name = "servo1Slider";
            this.servo1Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo1Slider.Size = new System.Drawing.Size(42, 200);
            this.servo1Slider.TabIndex = 5;
            this.servo1Slider.TickFrequency = 16;
            this.servo1Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo1Slider.Scroll += new System.EventHandler(this.servo1Slider_Scroll);
            // 
            // servo1Value
            // 
            this.servo1Value.Location = new System.Drawing.Point(50, 222);
            this.servo1Value.Name = "servo1Value";
            this.servo1Value.ReadOnly = true;
            this.servo1Value.Size = new System.Drawing.Size(40, 20);
            this.servo1Value.TabIndex = 6;
            // 
            // servo2Label
            // 
            this.servo2Label.AutoSize = true;
            this.servo2Label.Location = new System.Drawing.Point(96, 0);
            this.servo2Label.Name = "servo2Label";
            this.servo2Label.Size = new System.Drawing.Size(44, 13);
            this.servo2Label.TabIndex = 7;
            this.servo2Label.Text = "Servo 2";
            // 
            // servo2Slider
            // 
            this.servo2Slider.Location = new System.Drawing.Point(98, 16);
            this.servo2Slider.Maximum = 255;
            this.servo2Slider.Name = "servo2Slider";
            this.servo2Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo2Slider.Size = new System.Drawing.Size(42, 200);
            this.servo2Slider.TabIndex = 8;
            this.servo2Slider.TickFrequency = 16;
            this.servo2Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo2Slider.Scroll += new System.EventHandler(this.servo2Slider_Scroll);
            // 
            // servo2Value
            // 
            this.servo2Value.Location = new System.Drawing.Point(98, 222);
            this.servo2Value.Name = "servo2Value";
            this.servo2Value.ReadOnly = true;
            this.servo2Value.Size = new System.Drawing.Size(40, 20);
            this.servo2Value.TabIndex = 9;
            // 
            // servo3Label
            // 
            this.servo3Label.AutoSize = true;
            this.servo3Label.Location = new System.Drawing.Point(144, 0);
            this.servo3Label.Name = "servo3Label";
            this.servo3Label.Size = new System.Drawing.Size(44, 13);
            this.servo3Label.TabIndex = 10;
            this.servo3Label.Text = "Servo 3";
            // 
            // servo3Slider
            // 
            this.servo3Slider.Location = new System.Drawing.Point(146, 16);
            this.servo3Slider.Maximum = 255;
            this.servo3Slider.Name = "servo3Slider";
            this.servo3Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo3Slider.Size = new System.Drawing.Size(42, 200);
            this.servo3Slider.TabIndex = 11;
            this.servo3Slider.TickFrequency = 16;
            this.servo3Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo3Slider.Scroll += new System.EventHandler(this.servo3Slider_Scroll);
            // 
            // servo3Value
            // 
            this.servo3Value.Location = new System.Drawing.Point(146, 222);
            this.servo3Value.Name = "servo3Value";
            this.servo3Value.ReadOnly = true;
            this.servo3Value.Size = new System.Drawing.Size(40, 20);
            this.servo3Value.TabIndex = 12;
            // 
            // servo4Label
            // 
            this.servo4Label.AutoSize = true;
            this.servo4Label.Location = new System.Drawing.Point(192, 0);
            this.servo4Label.Name = "servo4Label";
            this.servo4Label.Size = new System.Drawing.Size(44, 13);
            this.servo4Label.TabIndex = 13;
            this.servo4Label.Text = "Servo 4";
            // 
            // servo4Slider
            // 
            this.servo4Slider.Location = new System.Drawing.Point(194, 16);
            this.servo4Slider.Maximum = 255;
            this.servo4Slider.Name = "servo4Slider";
            this.servo4Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo4Slider.Size = new System.Drawing.Size(42, 200);
            this.servo4Slider.TabIndex = 14;
            this.servo4Slider.TickFrequency = 16;
            this.servo4Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo4Slider.Scroll += new System.EventHandler(this.servo4Slider_Scroll);
            // 
            // servo4Value
            // 
            this.servo4Value.Location = new System.Drawing.Point(194, 222);
            this.servo4Value.Name = "servo4Value";
            this.servo4Value.ReadOnly = true;
            this.servo4Value.Size = new System.Drawing.Size(40, 20);
            this.servo4Value.TabIndex = 15;
            // 
            // servo5Label
            // 
            this.servo5Label.AutoSize = true;
            this.servo5Label.Location = new System.Drawing.Point(240, 0);
            this.servo5Label.Name = "servo5Label";
            this.servo5Label.Size = new System.Drawing.Size(44, 13);
            this.servo5Label.TabIndex = 16;
            this.servo5Label.Text = "Servo 5";
            // 
            // servo5Slider
            // 
            this.servo5Slider.Location = new System.Drawing.Point(242, 16);
            this.servo5Slider.Maximum = 255;
            this.servo5Slider.Name = "servo5Slider";
            this.servo5Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo5Slider.Size = new System.Drawing.Size(42, 200);
            this.servo5Slider.TabIndex = 17;
            this.servo5Slider.TickFrequency = 16;
            this.servo5Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo5Slider.Scroll += new System.EventHandler(this.servo5Slider_Scroll);
            // 
            // servo5Value
            // 
            this.servo5Value.Location = new System.Drawing.Point(242, 222);
            this.servo5Value.Name = "servo5Value";
            this.servo5Value.ReadOnly = true;
            this.servo5Value.Size = new System.Drawing.Size(40, 20);
            this.servo5Value.TabIndex = 18;
            // 
            // servo6Label
            // 
            this.servo6Label.AutoSize = true;
            this.servo6Label.Location = new System.Drawing.Point(288, 0);
            this.servo6Label.Name = "servo6Label";
            this.servo6Label.Size = new System.Drawing.Size(44, 13);
            this.servo6Label.TabIndex = 19;
            this.servo6Label.Text = "Servo 6";
            // 
            // servo6Slider
            // 
            this.servo6Slider.Location = new System.Drawing.Point(290, 16);
            this.servo6Slider.Maximum = 255;
            this.servo6Slider.Name = "servo6Slider";
            this.servo6Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo6Slider.Size = new System.Drawing.Size(42, 200);
            this.servo6Slider.TabIndex = 20;
            this.servo6Slider.TickFrequency = 16;
            this.servo6Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo6Slider.Scroll += new System.EventHandler(this.servo6Slider_Scroll);
            // 
            // servo6Value
            // 
            this.servo6Value.Location = new System.Drawing.Point(290, 222);
            this.servo6Value.Name = "servo6Value";
            this.servo6Value.ReadOnly = true;
            this.servo6Value.Size = new System.Drawing.Size(40, 20);
            this.servo6Value.TabIndex = 21;
            // 
            // servo7Label
            // 
            this.servo7Label.AutoSize = true;
            this.servo7Label.Location = new System.Drawing.Point(336, 0);
            this.servo7Label.Name = "servo7Label";
            this.servo7Label.Size = new System.Drawing.Size(44, 13);
            this.servo7Label.TabIndex = 22;
            this.servo7Label.Text = "Servo 7";
            // 
            // servo7Slider
            // 
            this.servo7Slider.Location = new System.Drawing.Point(338, 16);
            this.servo7Slider.Maximum = 255;
            this.servo7Slider.Name = "servo7Slider";
            this.servo7Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo7Slider.Size = new System.Drawing.Size(42, 200);
            this.servo7Slider.TabIndex = 23;
            this.servo7Slider.TickFrequency = 16;
            this.servo7Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo7Slider.Scroll += new System.EventHandler(this.servo7Slider_Scroll);
            // 
            // servo7Value
            // 
            this.servo7Value.Location = new System.Drawing.Point(338, 222);
            this.servo7Value.Name = "servo7Value";
            this.servo7Value.ReadOnly = true;
            this.servo7Value.Size = new System.Drawing.Size(40, 20);
            this.servo7Value.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.servo7Value);
            this.panel1.Controls.Add(this.servo7Slider);
            this.panel1.Controls.Add(this.servo7Label);
            this.panel1.Controls.Add(this.servo6Value);
            this.panel1.Controls.Add(this.servo6Slider);
            this.panel1.Controls.Add(this.servo6Label);
            this.panel1.Controls.Add(this.servo5Value);
            this.panel1.Controls.Add(this.servo5Slider);
            this.panel1.Controls.Add(this.servo5Label);
            this.panel1.Controls.Add(this.servo4Value);
            this.panel1.Controls.Add(this.servo4Slider);
            this.panel1.Controls.Add(this.servo4Label);
            this.panel1.Controls.Add(this.servo3Value);
            this.panel1.Controls.Add(this.servo3Slider);
            this.panel1.Controls.Add(this.servo3Label);
            this.panel1.Controls.Add(this.servo2Value);
            this.panel1.Controls.Add(this.servo2Slider);
            this.panel1.Controls.Add(this.servo2Label);
            this.panel1.Controls.Add(this.servo1Value);
            this.panel1.Controls.Add(this.servo1Slider);
            this.panel1.Controls.Add(this.servo1Label);
            this.panel1.Controls.Add(this.buttonCenterServos);
            this.panel1.Controls.Add(this.servo0Value);
            this.panel1.Controls.Add(this.servo0Slider);
            this.panel1.Controls.Add(this.servo0Label);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 284);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.allSwitchesOff);
            this.panel2.Controls.Add(this.allSwitchesOn);
            this.panel2.Controls.Add(this.switch7Checkbox);
            this.panel2.Controls.Add(this.switch6Checkbox);
            this.panel2.Controls.Add(this.switch5Checkbox);
            this.panel2.Controls.Add(this.switch4Checkbox);
            this.panel2.Controls.Add(this.switch3Checkbox);
            this.panel2.Controls.Add(this.switch2Checkbox);
            this.panel2.Controls.Add(this.switch1Checkbox);
            this.panel2.Controls.Add(this.switch0Checkbox);
            this.panel2.Location = new System.Drawing.Point(423, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 284);
            this.panel2.TabIndex = 2;
            // 
            // switch0Checkbox
            // 
            this.switch0Checkbox.AutoSize = true;
            this.switch0Checkbox.Location = new System.Drawing.Point(3, 3);
            this.switch0Checkbox.Name = "switch0Checkbox";
            this.switch0Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch0Checkbox.TabIndex = 0;
            this.switch0Checkbox.Text = "Switch 0";
            this.switch0Checkbox.UseVisualStyleBackColor = true;
            this.switch0Checkbox.CheckedChanged += new System.EventHandler(this.switch0Checkbox_CheckedChanged);
            // 
            // switch1Checkbox
            // 
            this.switch1Checkbox.AutoSize = true;
            this.switch1Checkbox.Location = new System.Drawing.Point(3, 26);
            this.switch1Checkbox.Name = "switch1Checkbox";
            this.switch1Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch1Checkbox.TabIndex = 1;
            this.switch1Checkbox.Text = "Switch 1";
            this.switch1Checkbox.UseVisualStyleBackColor = true;
            this.switch1Checkbox.CheckedChanged += new System.EventHandler(this.switch1Checkbox_CheckedChanged);
            // 
            // switch3Checkbox
            // 
            this.switch3Checkbox.AutoSize = true;
            this.switch3Checkbox.Location = new System.Drawing.Point(3, 72);
            this.switch3Checkbox.Name = "switch3Checkbox";
            this.switch3Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch3Checkbox.TabIndex = 3;
            this.switch3Checkbox.Text = "Switch 3";
            this.switch3Checkbox.UseVisualStyleBackColor = true;
            this.switch3Checkbox.CheckedChanged += new System.EventHandler(this.switch3Checkbox_CheckedChanged);
            // 
            // switch2Checkbox
            // 
            this.switch2Checkbox.AutoSize = true;
            this.switch2Checkbox.Location = new System.Drawing.Point(3, 49);
            this.switch2Checkbox.Name = "switch2Checkbox";
            this.switch2Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch2Checkbox.TabIndex = 2;
            this.switch2Checkbox.Text = "Switch 2";
            this.switch2Checkbox.UseVisualStyleBackColor = true;
            this.switch2Checkbox.CheckedChanged += new System.EventHandler(this.switch2Checkbox_CheckedChanged);
            // 
            // switch7Checkbox
            // 
            this.switch7Checkbox.AutoSize = true;
            this.switch7Checkbox.Location = new System.Drawing.Point(3, 164);
            this.switch7Checkbox.Name = "switch7Checkbox";
            this.switch7Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch7Checkbox.TabIndex = 7;
            this.switch7Checkbox.Text = "Switch 7";
            this.switch7Checkbox.UseVisualStyleBackColor = true;
            this.switch7Checkbox.CheckedChanged += new System.EventHandler(this.switch7Checkbox_CheckedChanged);
            // 
            // switch6Checkbox
            // 
            this.switch6Checkbox.AutoSize = true;
            this.switch6Checkbox.Location = new System.Drawing.Point(3, 141);
            this.switch6Checkbox.Name = "switch6Checkbox";
            this.switch6Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch6Checkbox.TabIndex = 6;
            this.switch6Checkbox.Text = "Switch 6";
            this.switch6Checkbox.UseVisualStyleBackColor = true;
            this.switch6Checkbox.CheckedChanged += new System.EventHandler(this.switch6Checkbox_CheckedChanged);
            // 
            // switch5Checkbox
            // 
            this.switch5Checkbox.AutoSize = true;
            this.switch5Checkbox.Location = new System.Drawing.Point(3, 118);
            this.switch5Checkbox.Name = "switch5Checkbox";
            this.switch5Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch5Checkbox.TabIndex = 5;
            this.switch5Checkbox.Text = "Switch 5";
            this.switch5Checkbox.UseVisualStyleBackColor = true;
            this.switch5Checkbox.CheckedChanged += new System.EventHandler(this.switch5Checkbox_CheckedChanged);
            // 
            // switch4Checkbox
            // 
            this.switch4Checkbox.AutoSize = true;
            this.switch4Checkbox.Location = new System.Drawing.Point(3, 95);
            this.switch4Checkbox.Name = "switch4Checkbox";
            this.switch4Checkbox.Size = new System.Drawing.Size(67, 17);
            this.switch4Checkbox.TabIndex = 4;
            this.switch4Checkbox.Text = "Switch 4";
            this.switch4Checkbox.UseVisualStyleBackColor = true;
            this.switch4Checkbox.CheckedChanged += new System.EventHandler(this.switch4Checkbox_CheckedChanged);
            // 
            // allSwitchesOn
            // 
            this.allSwitchesOn.Location = new System.Drawing.Point(3, 187);
            this.allSwitchesOn.Name = "allSwitchesOn";
            this.allSwitchesOn.Size = new System.Drawing.Size(75, 23);
            this.allSwitchesOn.TabIndex = 8;
            this.allSwitchesOn.Text = "All ON";
            this.allSwitchesOn.UseVisualStyleBackColor = true;
            this.allSwitchesOn.Click += new System.EventHandler(this.allSwitchesOn_Click);
            // 
            // allSwitchesOff
            // 
            this.allSwitchesOff.Location = new System.Drawing.Point(3, 216);
            this.allSwitchesOff.Name = "allSwitchesOff";
            this.allSwitchesOff.Size = new System.Drawing.Size(75, 23);
            this.allSwitchesOff.TabIndex = 9;
            this.allSwitchesOff.Text = "All OFF";
            this.allSwitchesOff.UseVisualStyleBackColor = true;
            this.allSwitchesOff.Click += new System.EventHandler(this.allSwitchesOff_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 323);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "usbServoGUI";
            ((System.ComponentModel.ISupportInitialize)(this.servo0Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo5Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo6Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo7Slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servo0Label;
        private System.Windows.Forms.TrackBar servo0Slider;
        private System.Windows.Forms.TextBox servo0Value;
        private System.Windows.Forms.Button buttonCenterServos;
        private System.Windows.Forms.Label servo1Label;
        private System.Windows.Forms.TrackBar servo1Slider;
        private System.Windows.Forms.TextBox servo1Value;
        private System.Windows.Forms.Label servo2Label;
        private System.Windows.Forms.TrackBar servo2Slider;
        private System.Windows.Forms.TextBox servo2Value;
        private System.Windows.Forms.Label servo3Label;
        private System.Windows.Forms.TrackBar servo3Slider;
        private System.Windows.Forms.TextBox servo3Value;
        private System.Windows.Forms.Label servo4Label;
        private System.Windows.Forms.TrackBar servo4Slider;
        private System.Windows.Forms.TextBox servo4Value;
        private System.Windows.Forms.Label servo5Label;
        private System.Windows.Forms.TrackBar servo5Slider;
        private System.Windows.Forms.TextBox servo5Value;
        private System.Windows.Forms.Label servo6Label;
        private System.Windows.Forms.TrackBar servo6Slider;
        private System.Windows.Forms.TextBox servo6Value;
        private System.Windows.Forms.Label servo7Label;
        private System.Windows.Forms.TrackBar servo7Slider;
        private System.Windows.Forms.TextBox servo7Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox switch0Checkbox;
        private System.Windows.Forms.CheckBox switch7Checkbox;
        private System.Windows.Forms.CheckBox switch6Checkbox;
        private System.Windows.Forms.CheckBox switch5Checkbox;
        private System.Windows.Forms.CheckBox switch4Checkbox;
        private System.Windows.Forms.CheckBox switch3Checkbox;
        private System.Windows.Forms.CheckBox switch2Checkbox;
        private System.Windows.Forms.CheckBox switch1Checkbox;
        private System.Windows.Forms.Button allSwitchesOn;
        private System.Windows.Forms.Button allSwitchesOff;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

    }
}

