using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;

using ICSharpCode.USBlib;

namespace usbServoGUI
{
    public partial class Form1 : Form
    {
        const int VENDOR_ID = 0x16C0;
        const int PRODUCT_ID = 0x05dc;

        const int SET_REQUESTTYPE = 0xC0;
        const int GET_REQUESTTYPE = 0xC0;

        const int USCMD_ECHO = 0;
        const int USCMD_SERVOSTATUS = 1;
        const int USCMD_SWITCHSTATUS = 2;
        const int USCMD_SETSERVO = 3;
        const int USCMD_SETSWITCH = 4;

        byte[] buffer = new byte[8];
        Device device = null;

        public Form1()
        {
            InitializeComponent();
            findDevice();

            update();
        }

        private void servo0Slider_Scroll(object sender, EventArgs e)
        {
            servo0Value.Text = servo0Slider.Value.ToString();
            setServoPosition(0, servo0Slider.Value);
        }

        private void servo1Slider_Scroll(object sender, EventArgs e)
        {
            servo1Value.Text = servo1Slider.Value.ToString();
            setServoPosition(1, servo1Slider.Value);
        }

        private void servo2Slider_Scroll(object sender, EventArgs e)
        {
            servo2Value.Text = servo2Slider.Value.ToString();
            setServoPosition(2, servo2Slider.Value);
        }

        private void servo3Slider_Scroll(object sender, EventArgs e)
        {
            servo3Value.Text = servo3Slider.Value.ToString();
            setServoPosition(3, servo3Slider.Value);
        }

        private void servo4Slider_Scroll(object sender, EventArgs e)
        {
            servo4Value.Text = servo4Slider.Value.ToString();
            setServoPosition(4, servo4Slider.Value);
        }

        private void servo5Slider_Scroll(object sender, EventArgs e)
        {
            servo5Value.Text = servo5Slider.Value.ToString();
            setServoPosition(5, servo5Slider.Value);
        }

        private void servo6Slider_Scroll(object sender, EventArgs e)
        {
            servo6Value.Text = servo6Slider.Value.ToString();
            setServoPosition(6, servo6Slider.Value);
        }

        private void servo7Slider_Scroll(object sender, EventArgs e)
        {
            servo7Value.Text = servo7Slider.Value.ToString();
            setServoPosition(7, servo7Slider.Value);
        }

        private void findDevice()
        {
            foreach (Bus bus in Bus.Busses)
            {
                foreach (Descriptor descriptor in bus.Descriptors)
                {
                    if (descriptor.VendorId == VENDOR_ID &&
                        descriptor.ProductId == PRODUCT_ID)
                    {
                        device = descriptor.OpenDevice();
                    }
                }
            }

            if (device == null)
            {
                System.Console.Out.WriteLine("Device not found");
                Environment.Exit(1);
            }
        }

        private byte[] getServoPositions()
        {
            device.SendControlMessage(GET_REQUESTTYPE,
                                          USCMD_SERVOSTATUS,
                                          0,
                                          0,
                                          buffer
                                         );
            return buffer;
        }

        private byte[] getSwitchPositions()
        {
            device.SendControlMessage(GET_REQUESTTYPE,
                                          USCMD_SWITCHSTATUS,
                                          0,
                                          0,
                                          buffer
                                         );
            return buffer;
        }

        private void setServoPosition(int s, int p)
        {
            device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSERVO,
                                          s,
                                          p,
                                          buffer
                                         );
        }

        private void setSwitchPosition(int sw, int oo)
        {
            device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSWITCH,
                                          sw,
                                          oo,
                                          buffer
                                         );
        }

        private void buttonCenterServos_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                setServoPosition(i, 127);
            }
            update();
        }

        private void update()
        {
            byte[] servoPositions = getServoPositions();

            servo0Slider.Value = servoPositions[0];
            servo0Value.Text = servoPositions[0].ToString();

            servo1Slider.Value = servoPositions[1];
            servo1Value.Text = servoPositions[1].ToString();

            servo2Slider.Value = servoPositions[2];
            servo2Value.Text = servoPositions[2].ToString();

            servo3Slider.Value = servoPositions[3];
            servo3Value.Text = servoPositions[3].ToString();

            servo4Slider.Value = servoPositions[4];
            servo4Value.Text = servoPositions[4].ToString();

            servo5Slider.Value = servoPositions[5];
            servo5Value.Text = servoPositions[5].ToString();

            servo6Slider.Value = servoPositions[6];
            servo6Value.Text = servoPositions[6].ToString();

            servo7Slider.Value = servoPositions[7];
            servo7Value.Text = servoPositions[7].ToString();

            byte[] switchPositions = getSwitchPositions();

            if (switchPositions[0] == 1)
            {
                switch0Checkbox.Checked = true;
            }
            else
            {
                switch0Checkbox.Checked = false;
            }

            if (switchPositions[1] == 1)
            {
                switch1Checkbox.Checked = true;
            }
            else
            {
                switch1Checkbox.Checked = false;
            }

            if (switchPositions[2] == 1)
            {
                switch2Checkbox.Checked = true;
            }
            else
            {
                switch2Checkbox.Checked = false;
            }

            if (switchPositions[3] == 1)
            {
                switch3Checkbox.Checked = true;
            }
            else
            {
                switch3Checkbox.Checked = false;
            }

            if (switchPositions[4] == 1)
            {
                switch4Checkbox.Checked = true;
            }
            else
            {
                switch4Checkbox.Checked = false;
            }

            if (switchPositions[5] == 1)
            {
                switch5Checkbox.Checked = true;
            }
            else
            {
                switch5Checkbox.Checked = false;
            }

            if (switchPositions[6] == 1)
            {
                switch6Checkbox.Checked = true;
            }
            else
            {
                switch6Checkbox.Checked = false;
            }

            if (switchPositions[7] == 1)
            {
                switch7Checkbox.Checked = true;
            }
            else
            {
                switch7Checkbox.Checked = false;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device.Close();
            Environment.Exit(0);
        }

        private void switch0Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch0Checkbox.Checked)
            {
                setSwitchPosition(0, 1);
            }
            else
            {
                setSwitchPosition(0, 0);
            }
        }

        private void switch1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch1Checkbox.Checked)
            {
                setSwitchPosition(1, 1);
            }
            else
            {
                setSwitchPosition(1, 0);
            }
        }

        private void switch2Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch2Checkbox.Checked)
            {
                setSwitchPosition(2, 1);
            }
            else
            {
                setSwitchPosition(2, 0);
            }
        }

        private void switch3Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch3Checkbox.Checked)
            {
                setSwitchPosition(3, 1);
            }
            else
            {
                setSwitchPosition(3, 0);
            }
        }

        private void switch4Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch4Checkbox.Checked)
            {
                setSwitchPosition(4, 1);
            }
            else
            {
                setSwitchPosition(4, 0);
            }
        }

        private void switch5Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch5Checkbox.Checked)
            {
                setSwitchPosition(5, 1);
            }
            else
            {
                setSwitchPosition(5, 0);
            }
        }

        private void switch6Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch6Checkbox.Checked)
            {
                setSwitchPosition(6, 1);
            }
            else
            {
                setSwitchPosition(6, 0);
            }
        }

        private void switch7Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (switch7Checkbox.Checked)
            {
                setSwitchPosition(7, 1);
            }
            else
            {
                setSwitchPosition(7, 0);
            }
        }

        private void allSwitchesOn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                setSwitchPosition(i, 1);
            }
            update();
        }

        private void allSwitchesOff_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                setSwitchPosition(i, 0);
            }
            update();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}