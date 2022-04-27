using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Trigger for start type

        // These variables for timer settings
        public int repeatTimer;
        public bool infiniteTimer;
        public string textTimer;
        int currentQueue = 0;
        int textLength = 0;
        int currentRepeat = 0;

        private void triggerType(int speed, int repeat, int delay, bool infinite, string text)
        {
            timerType.Interval = speed;
            repeatTimer = repeat;
            infiniteTimer = infinite;
            textTimer = text;
            System.Threading.Thread.Sleep(delay);
            timerType.Start();
        }

        private void timerType_Tick(object sender, EventArgs e)
        {
            textLength = textTimer.Length;
            if (infiniteTimer == true)
            {
                if (textLength > currentQueue)
                {
                    SendKeys.Send(textTimer.Substring(currentQueue, 1));
                    currentQueue++;
                }
                else
                {
                    currentQueue = 0;
                }
            }
            else
            {
                if (repeatTimer > currentRepeat)
                {
                    if (textLength > currentQueue)
                    {
                        SendKeys.Send(textTimer.Substring(currentQueue, 1));
                        currentQueue++;
                    }
                    else
                    {
                        currentQueue = 0;
                        repeatTimer--;
                    }
                }
                else
                {
                    timerType.Stop();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Form load
        }

        // Close form and minimize form, label_CloseForm - label_Minimizeform

        private void label_CloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label_MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Form move with panel_Move, panel_Move

        int mov, movX, movY; // Integer variables for panel_Move

        private void panel_Move_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel_Move_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        // Only numbers for textboxs, textbox_Speed - textbox_Repeat - textbox_Delay

        private void textBox_Speed_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Speed.Text, "[^0-9]"))
            {
                textBox_Speed.Text = textBox_Speed.Text.Remove(textBox_Speed.Text.Length - 1);
            }
        }

        private void textBox_Repeat_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Repeat.Text, "[^0-9]"))
            {
                textBox_Repeat.Text = textBox_Repeat.Text.Remove(textBox_Repeat.Text.Length - 1);
            }
        }

        private void textBox_Delay_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Delay.Text, "[^0-9]"))
            {
                textBox_Delay.Text = textBox_Delay.Text.Remove(textBox_Delay.Text.Length - 1);
            }
        }

        // Infinite repeat, checkbox_Infinite

        bool infinite_repeat = false; // Bool variable for checkbox_Infinite

        private void checkBox_Infinite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Infinite.Checked)
            {
                textBox_Repeat.Enabled = false;
                infinite_repeat = true;
            }
            else
            {
                textBox_Repeat.Enabled = true;
                infinite_repeat = false;
            }
        }

        // Start type, button_Start

        // Textbox values in these variables
        int speed = 0;
        int repeat = 0;
        int delay = 0;

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerType.Stop();
        }

        string text;

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (infinite_repeat == true)
            {
                if (textBox_Delay.Text == "" || textBox_Speed.Text == "" || richTextBox_Text.Text == "")
                {
                    MessageBox.Show("Please enter values");
                }
                else
                {
                    speed = Convert.ToInt32(textBox_Speed.Text);
                    delay = Convert.ToInt32(textBox_Delay.Text);
                    text = richTextBox_Text.Text;
                    triggerType(speed, repeat, delay, true, text);
                }
            }
            else
            {
                if (textBox_Delay.Text == "" || textBox_Repeat.Text == "" || textBox_Speed.Text == "" || richTextBox_Text.Text == "")
                {
                    MessageBox.Show("Please enter values");
                }
                else
                {
                    speed = Convert.ToInt32(textBox_Speed.Text);
                    repeat = Convert.ToInt32(textBox_Repeat.Text);
                    delay = Convert.ToInt32(textBox_Delay.Text);
                    text = richTextBox_Text.Text;
                    triggerType(speed, repeat, delay, false, text);
                }
            }
        }
    }
}
