namespace FinchControl_Ayew
{
    partial class Form_FinchControl
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
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Backward = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.label_Move = new System.Windows.Forms.Label();
            this.txtBox_LightLevel = new System.Windows.Forms.TextBox();
            this.label_LightLevel = new System.Windows.Forms.Label();
            this.txtBox_Celsius = new System.Windows.Forms.TextBox();
            this.txtBox_Fahrenheit = new System.Windows.Forms.TextBox();
            this.label_Celsius = new System.Windows.Forms.Label();
            this.label_Fahrenheit = new System.Windows.Forms.Label();
            this.checkBox_Red = new System.Windows.Forms.CheckBox();
            this.checkBox_Blue = new System.Windows.Forms.CheckBox();
            this.checkBox_Green = new System.Windows.Forms.CheckBox();
            this.checkBox_White = new System.Windows.Forms.CheckBox();
            this.label_Leds = new System.Windows.Forms.Label();
            this.checkBox_BrotherJohn = new System.Windows.Forms.CheckBox();
            this.checkBox_Falling = new System.Windows.Forms.CheckBox();
            this.checkBox_GameOfThrones = new System.Windows.Forms.CheckBox();
            this.checkBox_Birthday = new System.Windows.Forms.CheckBox();
            this.label_song = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_temperaturelight = new System.Windows.Forms.Label();
            this.label_songlight = new System.Windows.Forms.Label();
            this.label_moveinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(319, 302);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(140, 109);
            this.btn_Stop.TabIndex = 0;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Location = new System.Drawing.Point(319, 185);
            this.btn_Forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(140, 109);
            this.btn_Forward.TabIndex = 1;
            this.btn_Forward.Text = "Forward";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click_1);
            // 
            // btn_Backward
            // 
            this.btn_Backward.Location = new System.Drawing.Point(319, 419);
            this.btn_Backward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Backward.Name = "btn_Backward";
            this.btn_Backward.Size = new System.Drawing.Size(140, 109);
            this.btn_Backward.TabIndex = 2;
            this.btn_Backward.Text = "Backward";
            this.btn_Backward.UseVisualStyleBackColor = true;
            this.btn_Backward.Click += new System.EventHandler(this.btn_Backward_Click_1);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(465, 302);
            this.btn_Right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(140, 109);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click_1);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(173, 302);
            this.btn_Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(140, 109);
            this.btn_Left.TabIndex = 4;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click_1);
            // 
            // label_Move
            // 
            this.label_Move.AutoSize = true;
            this.label_Move.ForeColor = System.Drawing.Color.Purple;
            this.label_Move.Location = new System.Drawing.Point(323, 157);
            this.label_Move.Name = "label_Move";
            this.label_Move.Size = new System.Drawing.Size(136, 24);
            this.label_Move.TabIndex = 5;
            this.label_Move.Text = "Move Finch Robot";
            // 
            // txtBox_LightLevel
            // 
            this.txtBox_LightLevel.Location = new System.Drawing.Point(110, 256);
            this.txtBox_LightLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_LightLevel.Name = "txtBox_LightLevel";
            this.txtBox_LightLevel.Size = new System.Drawing.Size(100, 30);
            this.txtBox_LightLevel.TabIndex = 6;
            // 
            // label_LightLevel
            // 
            this.label_LightLevel.AutoSize = true;
            this.label_LightLevel.Location = new System.Drawing.Point(16, 259);
            this.label_LightLevel.Name = "label_LightLevel";
            this.label_LightLevel.Size = new System.Drawing.Size(88, 24);
            this.label_LightLevel.TabIndex = 7;
            this.label_LightLevel.Text = "Light Level";
            // 
            // txtBox_Celsius
            // 
            this.txtBox_Celsius.Location = new System.Drawing.Point(714, 208);
            this.txtBox_Celsius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Celsius.Name = "txtBox_Celsius";
            this.txtBox_Celsius.Size = new System.Drawing.Size(100, 30);
            this.txtBox_Celsius.TabIndex = 8;
            // 
            // txtBox_Fahrenheit
            // 
            this.txtBox_Fahrenheit.Location = new System.Drawing.Point(714, 259);
            this.txtBox_Fahrenheit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Fahrenheit.Name = "txtBox_Fahrenheit";
            this.txtBox_Fahrenheit.Size = new System.Drawing.Size(100, 30);
            this.txtBox_Fahrenheit.TabIndex = 9;
            // 
            // label_Celsius
            // 
            this.label_Celsius.AutoSize = true;
            this.label_Celsius.Location = new System.Drawing.Point(524, 208);
            this.label_Celsius.Name = "label_Celsius";
            this.label_Celsius.Size = new System.Drawing.Size(172, 24);
            this.label_Celsius.TabIndex = 10;
            this.label_Celsius.Text = "Temperature in Celsius";
            // 
            // label_Fahrenheit
            // 
            this.label_Fahrenheit.AutoSize = true;
            this.label_Fahrenheit.Location = new System.Drawing.Point(495, 256);
            this.label_Fahrenheit.Name = "label_Fahrenheit";
            this.label_Fahrenheit.Size = new System.Drawing.Size(201, 24);
            this.label_Fahrenheit.TabIndex = 11;
            this.label_Fahrenheit.Text = "Temperature in Fahrenheit";
            // 
            // checkBox_Red
            // 
            this.checkBox_Red.AutoSize = true;
            this.checkBox_Red.ForeColor = System.Drawing.Color.Red;
            this.checkBox_Red.Location = new System.Drawing.Point(32, 460);
            this.checkBox_Red.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Red.Name = "checkBox_Red";
            this.checkBox_Red.Size = new System.Drawing.Size(58, 28);
            this.checkBox_Red.TabIndex = 12;
            this.checkBox_Red.Text = "Red";
            this.checkBox_Red.UseVisualStyleBackColor = true;
            this.checkBox_Red.CheckedChanged += new System.EventHandler(this.checkBox_Red_CheckedChanged_1);
            // 
            // checkBox_Blue
            // 
            this.checkBox_Blue.AutoSize = true;
            this.checkBox_Blue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_Blue.Location = new System.Drawing.Point(32, 500);
            this.checkBox_Blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Blue.Name = "checkBox_Blue";
            this.checkBox_Blue.Size = new System.Drawing.Size(62, 28);
            this.checkBox_Blue.TabIndex = 13;
            this.checkBox_Blue.Text = "Blue";
            this.checkBox_Blue.UseVisualStyleBackColor = true;
            this.checkBox_Blue.CheckedChanged += new System.EventHandler(this.checkBox_Blue_CheckedChanged_1);
            // 
            // checkBox_Green
            // 
            this.checkBox_Green.AutoSize = true;
            this.checkBox_Green.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBox_Green.Location = new System.Drawing.Point(32, 540);
            this.checkBox_Green.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Green.Name = "checkBox_Green";
            this.checkBox_Green.Size = new System.Drawing.Size(73, 28);
            this.checkBox_Green.TabIndex = 14;
            this.checkBox_Green.Text = "Green";
            this.checkBox_Green.UseVisualStyleBackColor = true;
            this.checkBox_Green.CheckedChanged += new System.EventHandler(this.checkBox_Green_CheckedChanged_1);
            // 
            // checkBox_White
            // 
            this.checkBox_White.AutoSize = true;
            this.checkBox_White.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBox_White.Location = new System.Drawing.Point(32, 581);
            this.checkBox_White.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_White.Name = "checkBox_White";
            this.checkBox_White.Size = new System.Drawing.Size(73, 28);
            this.checkBox_White.TabIndex = 15;
            this.checkBox_White.Text = "White";
            this.checkBox_White.UseVisualStyleBackColor = true;
            this.checkBox_White.CheckedChanged += new System.EventHandler(this.checkBox_White_CheckedChanged_1);
            // 
            // label_Leds
            // 
            this.label_Leds.AutoSize = true;
            this.label_Leds.ForeColor = System.Drawing.Color.Purple;
            this.label_Leds.Location = new System.Drawing.Point(32, 427);
            this.label_Leds.Name = "label_Leds";
            this.label_Leds.Size = new System.Drawing.Size(163, 24);
            this.label_Leds.TabIndex = 16;
            this.label_Leds.Text = "Light Up Finch Robot";
            // 
            // checkBox_BrotherJohn
            // 
            this.checkBox_BrotherJohn.AutoSize = true;
            this.checkBox_BrotherJohn.Location = new System.Drawing.Point(551, 461);
            this.checkBox_BrotherJohn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_BrotherJohn.Name = "checkBox_BrotherJohn";
            this.checkBox_BrotherJohn.Size = new System.Drawing.Size(127, 28);
            this.checkBox_BrotherJohn.TabIndex = 17;
            this.checkBox_BrotherJohn.Text = "Brother John";
            this.checkBox_BrotherJohn.UseVisualStyleBackColor = true;
            this.checkBox_BrotherJohn.CheckedChanged += new System.EventHandler(this.checkBox_BrotherJohn_CheckedChanged_1);
            // 
            // checkBox_Falling
            // 
            this.checkBox_Falling.AutoSize = true;
            this.checkBox_Falling.Location = new System.Drawing.Point(551, 500);
            this.checkBox_Falling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Falling.Name = "checkBox_Falling";
            this.checkBox_Falling.Size = new System.Drawing.Size(214, 28);
            this.checkBox_Falling.TabIndex = 18;
            this.checkBox_Falling.Text = "Can\'t Help Falling In Love";
            this.checkBox_Falling.UseVisualStyleBackColor = true;
            this.checkBox_Falling.CheckedChanged += new System.EventHandler(this.checkBox_Falling_CheckedChanged_1);
            // 
            // checkBox_GameOfThrones
            // 
            this.checkBox_GameOfThrones.AutoSize = true;
            this.checkBox_GameOfThrones.Location = new System.Drawing.Point(551, 540);
            this.checkBox_GameOfThrones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_GameOfThrones.Name = "checkBox_GameOfThrones";
            this.checkBox_GameOfThrones.Size = new System.Drawing.Size(152, 28);
            this.checkBox_GameOfThrones.TabIndex = 19;
            this.checkBox_GameOfThrones.Text = "Game of Thrones";
            this.checkBox_GameOfThrones.UseVisualStyleBackColor = true;
            this.checkBox_GameOfThrones.CheckedChanged += new System.EventHandler(this.checkBox_GameOfThrones_CheckedChanged_1);
            // 
            // checkBox_Birthday
            // 
            this.checkBox_Birthday.AutoSize = true;
            this.checkBox_Birthday.Location = new System.Drawing.Point(551, 581);
            this.checkBox_Birthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Birthday.Name = "checkBox_Birthday";
            this.checkBox_Birthday.Size = new System.Drawing.Size(145, 28);
            this.checkBox_Birthday.TabIndex = 20;
            this.checkBox_Birthday.Text = "Happy Birthday";
            this.checkBox_Birthday.UseVisualStyleBackColor = true;
            this.checkBox_Birthday.CheckedChanged += new System.EventHandler(this.checkBox_Birthday_CheckedChanged);
            // 
            // label_song
            // 
            this.label_song.AutoSize = true;
            this.label_song.ForeColor = System.Drawing.Color.Purple;
            this.label_song.Location = new System.Drawing.Point(548, 427);
            this.label_song.Name = "label_song";
            this.label_song.Size = new System.Drawing.Size(213, 24);
            this.label_song.TabIndex = 21;
            this.label_song.Text = "Play A Song On Finch Robot";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(24, 50);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 24);
            this.label_info.TabIndex = 22;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(12, 26);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(780, 24);
            this.label_welcome.TabIndex = 24;
            this.label_welcome.Text = "Welcome to the Finch Robot Control Menu.  This app can be used to control your Fi" +
    "nch Robot called Ayew. ";
            // 
            // label_temperaturelight
            // 
            this.label_temperaturelight.AutoSize = true;
            this.label_temperaturelight.Location = new System.Drawing.Point(16, 54);
            this.label_temperaturelight.Name = "label_temperaturelight";
            this.label_temperaturelight.Size = new System.Drawing.Size(682, 24);
            this.label_temperaturelight.TabIndex = 26;
            this.label_temperaturelight.Text = "The robot will measure the temperature and light levels for you as long as the ap" +
    "p is opened. ";
            // 
            // label_songlight
            // 
            this.label_songlight.AutoSize = true;
            this.label_songlight.Location = new System.Drawing.Point(20, 82);
            this.label_songlight.Name = "label_songlight";
            this.label_songlight.Size = new System.Drawing.Size(712, 24);
            this.label_songlight.TabIndex = 27;
            this.label_songlight.Text = "Use the checkboxes to make the robot play a song of your choice or light up in th" +
    "e color you like. ";
            // 
            // label_moveinfo
            // 
            this.label_moveinfo.AutoSize = true;
            this.label_moveinfo.Location = new System.Drawing.Point(24, 110);
            this.label_moveinfo.Name = "label_moveinfo";
            this.label_moveinfo.Size = new System.Drawing.Size(590, 24);
            this.label_moveinfo.TabIndex = 28;
            this.label_moveinfo.Text = "Use the buttons to make the robot move. The STOP button will stop the motors.";
            // 
            // Form_FinchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 642);
            this.Controls.Add(this.label_moveinfo);
            this.Controls.Add(this.label_songlight);
            this.Controls.Add(this.label_temperaturelight);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_song);
            this.Controls.Add(this.checkBox_Birthday);
            this.Controls.Add(this.checkBox_GameOfThrones);
            this.Controls.Add(this.checkBox_Falling);
            this.Controls.Add(this.checkBox_BrotherJohn);
            this.Controls.Add(this.label_Leds);
            this.Controls.Add(this.checkBox_White);
            this.Controls.Add(this.checkBox_Green);
            this.Controls.Add(this.checkBox_Blue);
            this.Controls.Add(this.checkBox_Red);
            this.Controls.Add(this.label_Fahrenheit);
            this.Controls.Add(this.label_Celsius);
            this.Controls.Add(this.txtBox_Fahrenheit);
            this.Controls.Add(this.txtBox_Celsius);
            this.Controls.Add(this.label_LightLevel);
            this.Controls.Add(this.txtBox_LightLevel);
            this.Controls.Add(this.label_Move);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Backward);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.btn_Stop);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_FinchControl";
            this.Text = "Finch Control_Ayew_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Backward;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Label label_Move;
        private System.Windows.Forms.TextBox txtBox_LightLevel;
        private System.Windows.Forms.Label label_LightLevel;
        private System.Windows.Forms.TextBox txtBox_Celsius;
        private System.Windows.Forms.TextBox txtBox_Fahrenheit;
        private System.Windows.Forms.Label label_Celsius;
        private System.Windows.Forms.Label label_Fahrenheit;
        private System.Windows.Forms.CheckBox checkBox_Red;
        private System.Windows.Forms.CheckBox checkBox_Blue;
        private System.Windows.Forms.CheckBox checkBox_Green;
        private System.Windows.Forms.CheckBox checkBox_White;
        private System.Windows.Forms.Label label_Leds;
        private System.Windows.Forms.CheckBox checkBox_BrotherJohn;
        private System.Windows.Forms.CheckBox checkBox_Falling;
        private System.Windows.Forms.CheckBox checkBox_GameOfThrones;
        private System.Windows.Forms.CheckBox checkBox_Birthday;
        private System.Windows.Forms.Label label_song;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_temperaturelight;
        private System.Windows.Forms.Label label_songlight;
        private System.Windows.Forms.Label label_moveinfo;
    }
}

