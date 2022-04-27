
namespace AutoTyper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_Move = new System.Windows.Forms.Panel();
            this.label_MinimizeForm = new System.Windows.Forms.Label();
            this.label_CloseForm = new System.Windows.Forms.Label();
            this.label_Header = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label_Repeat = new System.Windows.Forms.Label();
            this.textBox_Repeat = new System.Windows.Forms.TextBox();
            this.label_Delay = new System.Windows.Forms.Label();
            this.textBox_Delay = new System.Windows.Forms.TextBox();
            this.checkBox_Infinite = new System.Windows.Forms.CheckBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Move
            // 
            this.panel_Move.Controls.Add(this.label_MinimizeForm);
            this.panel_Move.Controls.Add(this.label_CloseForm);
            this.panel_Move.Controls.Add(this.label_Header);
            this.panel_Move.Location = new System.Drawing.Point(0, 0);
            this.panel_Move.Name = "panel_Move";
            this.panel_Move.Size = new System.Drawing.Size(300, 25);
            this.panel_Move.TabIndex = 0;
            this.panel_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Move_MouseDown);
            this.panel_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Move_MouseMove);
            this.panel_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Move_MouseUp);
            // 
            // label_MinimizeForm
            // 
            this.label_MinimizeForm.AutoSize = true;
            this.label_MinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_MinimizeForm.Location = new System.Drawing.Point(269, 6);
            this.label_MinimizeForm.Name = "label_MinimizeForm";
            this.label_MinimizeForm.Size = new System.Drawing.Size(11, 13);
            this.label_MinimizeForm.TabIndex = 3;
            this.label_MinimizeForm.Text = "-";
            this.label_MinimizeForm.Click += new System.EventHandler(this.label_MinimizeForm_Click);
            // 
            // label_CloseForm
            // 
            this.label_CloseForm.AutoSize = true;
            this.label_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_CloseForm.Location = new System.Drawing.Point(283, 6);
            this.label_CloseForm.Name = "label_CloseForm";
            this.label_CloseForm.Size = new System.Drawing.Size(14, 13);
            this.label_CloseForm.TabIndex = 2;
            this.label_CloseForm.Text = "X";
            this.label_CloseForm.Click += new System.EventHandler(this.label_CloseForm_Click);
            // 
            // label_Header
            // 
            this.label_Header.AutoSize = true;
            this.label_Header.Location = new System.Drawing.Point(36, 6);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(62, 13);
            this.label_Header.TabIndex = 2;
            this.label_Header.Text = "AutoTyper";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.BackgroundImage")));
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(5, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(30, 25);
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.textBox_Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_Speed.Location = new System.Drawing.Point(100, 35);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(100, 22);
            this.textBox_Speed.TabIndex = 2;
            this.textBox_Speed.TextChanged += new System.EventHandler(this.textBox_Speed_TextChanged);
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(34, 38);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(62, 13);
            this.label_Speed.TabIndex = 3;
            this.label_Speed.Text = "Speed(ms)";
            // 
            // label_Repeat
            // 
            this.label_Repeat.AutoSize = true;
            this.label_Repeat.Location = new System.Drawing.Point(51, 66);
            this.label_Repeat.Name = "label_Repeat";
            this.label_Repeat.Size = new System.Drawing.Size(43, 13);
            this.label_Repeat.TabIndex = 5;
            this.label_Repeat.Text = "Repeat";
            // 
            // textBox_Repeat
            // 
            this.textBox_Repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.textBox_Repeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_Repeat.Location = new System.Drawing.Point(100, 63);
            this.textBox_Repeat.Name = "textBox_Repeat";
            this.textBox_Repeat.Size = new System.Drawing.Size(100, 22);
            this.textBox_Repeat.TabIndex = 4;
            this.textBox_Repeat.TextChanged += new System.EventHandler(this.textBox_Repeat_TextChanged);
            // 
            // label_Delay
            // 
            this.label_Delay.AutoSize = true;
            this.label_Delay.Location = new System.Drawing.Point(58, 93);
            this.label_Delay.Name = "label_Delay";
            this.label_Delay.Size = new System.Drawing.Size(36, 13);
            this.label_Delay.TabIndex = 7;
            this.label_Delay.Text = "Delay";
            // 
            // textBox_Delay
            // 
            this.textBox_Delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.textBox_Delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_Delay.Location = new System.Drawing.Point(100, 91);
            this.textBox_Delay.Name = "textBox_Delay";
            this.textBox_Delay.Size = new System.Drawing.Size(100, 22);
            this.textBox_Delay.TabIndex = 6;
            this.textBox_Delay.TextChanged += new System.EventHandler(this.textBox_Delay_TextChanged);
            // 
            // checkBox_Infinite
            // 
            this.checkBox_Infinite.AutoSize = true;
            this.checkBox_Infinite.Location = new System.Drawing.Point(207, 66);
            this.checkBox_Infinite.Name = "checkBox_Infinite";
            this.checkBox_Infinite.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Infinite.TabIndex = 8;
            this.checkBox_Infinite.Text = "Infinite";
            this.checkBox_Infinite.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.button_Start.FlatAppearance.BorderSize = 0;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Location = new System.Drawing.Point(110, 119);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 9;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.checkBox_Infinite);
            this.Controls.Add(this.label_Delay);
            this.Controls.Add(this.textBox_Delay);
            this.Controls.Add(this.label_Repeat);
            this.Controls.Add(this.textBox_Repeat);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.textBox_Speed);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.panel_Move);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "Main";
            this.Text = "AutoTyper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Move.ResumeLayout(false);
            this.panel_Move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Move;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_MinimizeForm;
        private System.Windows.Forms.Label label_CloseForm;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label_Repeat;
        private System.Windows.Forms.TextBox textBox_Repeat;
        private System.Windows.Forms.Label label_Delay;
        private System.Windows.Forms.TextBox textBox_Delay;
        private System.Windows.Forms.CheckBox checkBox_Infinite;
        private System.Windows.Forms.Button button_Start;
    }
}

