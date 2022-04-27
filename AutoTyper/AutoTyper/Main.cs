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
    }
}
