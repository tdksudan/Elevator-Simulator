namespace Windows_Elevator
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            downbutton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox8 = new PictureBox();
            elevatortopdisplay2 = new PictureBox();
            pictureBox7 = new PictureBox();
            upbutton = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            elevatortopdisplay1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            elevatorleftdoor1 = new PictureBox();
            elevatorrightdoor1 = new PictureBox();
            elevatorrightdoor2 = new PictureBox();
            elevatorleftdoor2 = new PictureBox();
            groupBox2 = new GroupBox();
            groundfloorbutton = new Button();
            closedoor = new Button();
            opendoor = new Button();
            firstfloorbutton = new Button();
            displaypanel = new PictureBox();
            elevator = new PictureBox();
            groupBox3 = new GroupBox();
            ViewLog = new Button();
            Clear_log = new Button();
            displaytable = new DataGridView();
            openElevatorTimer = new System.Windows.Forms.Timer(components);
            closeElevatorTimer = new System.Windows.Forms.Timer(components);
            moveElevatorTimer = new System.Windows.Forms.Timer(components);
            automatic_door = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatortopdisplay2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatortopdisplay1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorleftdoor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorrightdoor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorrightdoor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorleftdoor2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaypanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevator).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaytable).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.BurlyWood;
            groupBox1.Controls.Add(downbutton);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(elevatortopdisplay2);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(upbutton);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(elevatortopdisplay1);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(elevatorleftdoor1);
            groupBox1.Controls.Add(elevatorrightdoor1);
            groupBox1.Controls.Add(elevatorrightdoor2);
            groupBox1.Controls.Add(elevatorleftdoor2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(elevator);
            groupBox1.Location = new Point(11, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 976);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // downbutton
            // 
            downbutton.BackColor = SystemColors.AppWorkspace;
            downbutton.BackgroundImage = Properties.Resources.Down_Button;
            downbutton.BackgroundImageLayout = ImageLayout.Zoom;
            downbutton.Location = new Point(463, 207);
            downbutton.Name = "downbutton";
            downbutton.Size = new Size(41, 45);
            downbutton.TabIndex = 2;
            downbutton.UseVisualStyleBackColor = false;
            downbutton.Click += downbutton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Elevatoroutsiderightside1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(387, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 476);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.Elevatordownside;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(165, 915);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(223, 36);
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // elevatortopdisplay2
            // 
            elevatortopdisplay2.BackgroundImage = Properties.Resources.DisplayPanel;
            elevatortopdisplay2.Location = new Point(231, 481);
            elevatortopdisplay2.Name = "elevatortopdisplay2";
            elevatortopdisplay2.Size = new Size(77, 27);
            elevatortopdisplay2.SizeMode = PictureBoxSizeMode.Zoom;
            elevatortopdisplay2.TabIndex = 10;
            elevatortopdisplay2.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.top;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(163, 481);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(225, 80);
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // upbutton
            // 
            upbutton.BackColor = SystemColors.AppWorkspace;
            upbutton.BackgroundImage = Properties.Resources.Up_Button;
            upbutton.BackgroundImageLayout = ImageLayout.Zoom;
            upbutton.Location = new Point(463, 668);
            upbutton.Name = "upbutton";
            upbutton.Size = new Size(41, 47);
            upbutton.TabIndex = 3;
            upbutton.UseVisualStyleBackColor = false;
            upbutton.Click += upbutton_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.Elevatoroutsiderightside1;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(387, 475);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(141, 476);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.Elevatoroutsideleftside;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(43, 475);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 476);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // elevatortopdisplay1
            // 
            elevatortopdisplay1.BackgroundImage = Properties.Resources.DisplayPanel;
            elevatortopdisplay1.Location = new Point(231, 11);
            elevatortopdisplay1.Name = "elevatortopdisplay1";
            elevatortopdisplay1.Size = new Size(77, 27);
            elevatortopdisplay1.SizeMode = PictureBoxSizeMode.Zoom;
            elevatortopdisplay1.TabIndex = 9;
            elevatortopdisplay1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.top;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(163, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(225, 92);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Elevatordownside;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(165, 452);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 35);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Elevatoroutsideleftside;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(43, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 476);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // elevatorleftdoor1
            // 
            elevatorleftdoor1.Image = Properties.Resources.elevatordoor;
            elevatorleftdoor1.Location = new Point(163, 100);
            elevatorleftdoor1.Name = "elevatorleftdoor1";
            elevatorleftdoor1.Size = new Size(111, 355);
            elevatorleftdoor1.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorleftdoor1.TabIndex = 8;
            elevatorleftdoor1.TabStop = false;
            // 
            // elevatorrightdoor1
            // 
            elevatorrightdoor1.Image = Properties.Resources.rightdoor;
            elevatorrightdoor1.Location = new Point(265, 100);
            elevatorrightdoor1.Name = "elevatorrightdoor1";
            elevatorrightdoor1.Size = new Size(123, 355);
            elevatorrightdoor1.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorrightdoor1.TabIndex = 7;
            elevatorrightdoor1.TabStop = false;
            // 
            // elevatorrightdoor2
            // 
            elevatorrightdoor2.Image = Properties.Resources.rightdoor;
            elevatorrightdoor2.Location = new Point(269, 560);
            elevatorrightdoor2.Name = "elevatorrightdoor2";
            elevatorrightdoor2.Size = new Size(123, 355);
            elevatorrightdoor2.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorrightdoor2.TabIndex = 6;
            elevatorrightdoor2.TabStop = false;
            elevatorrightdoor2.Click += pictureBox4_Click;
            // 
            // elevatorleftdoor2
            // 
            elevatorleftdoor2.Image = Properties.Resources.elevatordoor;
            elevatorleftdoor2.Location = new Point(165, 560);
            elevatorleftdoor2.Name = "elevatorleftdoor2";
            elevatorleftdoor2.Size = new Size(111, 355);
            elevatorleftdoor2.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorleftdoor2.TabIndex = 5;
            elevatorleftdoor2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.Control_Panel_background;
            groupBox2.Controls.Add(groundfloorbutton);
            groupBox2.Controls.Add(closedoor);
            groupBox2.Controls.Add(opendoor);
            groupBox2.Controls.Add(firstfloorbutton);
            groupBox2.Controls.Add(displaypanel);
            groupBox2.Location = new Point(533, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 471);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // groundfloorbutton
            // 
            groundfloorbutton.BackColor = SystemColors.AppWorkspace;
            groundfloorbutton.BackgroundImage = Properties.Resources.Groundfloorbutton1;
            groundfloorbutton.BackgroundImageLayout = ImageLayout.Zoom;
            groundfloorbutton.Location = new Point(62, 320);
            groundfloorbutton.Name = "groundfloorbutton";
            groundfloorbutton.Size = new Size(65, 64);
            groundfloorbutton.TabIndex = 4;
            groundfloorbutton.UseVisualStyleBackColor = false;
            groundfloorbutton.Click += groundfloorbutton_Click;
            // 
            // closedoor
            // 
            closedoor.BackColor = SystemColors.AppWorkspace;
            closedoor.BackgroundImage = Properties.Resources.closedoorsbutton;
            closedoor.BackgroundImageLayout = ImageLayout.Zoom;
            closedoor.Location = new Point(101, 389);
            closedoor.Name = "closedoor";
            closedoor.Size = new Size(65, 63);
            closedoor.TabIndex = 3;
            closedoor.UseVisualStyleBackColor = false;
            closedoor.Click += closedoor_Click;
            // 
            // opendoor
            // 
            opendoor.BackColor = SystemColors.AppWorkspace;
            opendoor.BackgroundImage = Properties.Resources.opendoorbutton;
            opendoor.BackgroundImageLayout = ImageLayout.Zoom;
            opendoor.Location = new Point(19, 389);
            opendoor.Name = "opendoor";
            opendoor.Size = new Size(65, 63);
            opendoor.TabIndex = 2;
            opendoor.UseVisualStyleBackColor = false;
            opendoor.Click += opendoor_Click;
            // 
            // firstfloorbutton
            // 
            firstfloorbutton.BackColor = SystemColors.AppWorkspace;
            firstfloorbutton.BackgroundImage = Properties.Resources.firstfloorbutton;
            firstfloorbutton.BackgroundImageLayout = ImageLayout.Zoom;
            firstfloorbutton.Location = new Point(62, 243);
            firstfloorbutton.Name = "firstfloorbutton";
            firstfloorbutton.Size = new Size(65, 63);
            firstfloorbutton.TabIndex = 1;
            firstfloorbutton.UseVisualStyleBackColor = false;
            firstfloorbutton.Click += firstfloorbutton_Click;
            // 
            // displaypanel
            // 
            displaypanel.BackgroundImage = Properties.Resources.DisplayPanel;
            displaypanel.BackgroundImageLayout = ImageLayout.Stretch;
            displaypanel.Location = new Point(31, 27);
            displaypanel.Name = "displaypanel";
            displaypanel.Size = new Size(135, 211);
            displaypanel.SizeMode = PictureBoxSizeMode.Zoom;
            displaypanel.TabIndex = 0;
            displaypanel.TabStop = false;
            // 
            // elevator
            // 
            elevator.Image = Properties.Resources.Elevator;
            elevator.Location = new Point(163, 100);
            elevator.Name = "elevator";
            elevator.Size = new Size(229, 355);
            elevator.SizeMode = PictureBoxSizeMode.StretchImage;
            elevator.TabIndex = 1;
            elevator.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(ViewLog);
            groupBox3.Controls.Add(Clear_log);
            groupBox3.Controls.Add(displaytable);
            groupBox3.Location = new Point(743, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(666, 976);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // ViewLog
            // 
            ViewLog.BackColor = Color.AntiqueWhite;
            ViewLog.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewLog.Location = new Point(133, 32);
            ViewLog.Name = "ViewLog";
            ViewLog.Size = new Size(94, 29);
            ViewLog.TabIndex = 2;
            ViewLog.Text = "Veiw log";
            ViewLog.UseVisualStyleBackColor = false;
            ViewLog.Click += ViewLog_Click;
            // 
            // Clear_log
            // 
            Clear_log.BackColor = Color.AntiqueWhite;
            Clear_log.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Clear_log.Location = new Point(23, 31);
            Clear_log.Name = "Clear_log";
            Clear_log.Size = new Size(94, 29);
            Clear_log.TabIndex = 1;
            Clear_log.Text = "CLEAR";
            Clear_log.UseVisualStyleBackColor = false;
            Clear_log.Click += button1_Click;
            // 
            // displaytable
            // 
            displaytable.BorderStyle = BorderStyle.Fixed3D;
            displaytable.CausesValidation = false;
            displaytable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            displaytable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displaytable.Enabled = false;
            displaytable.Location = new Point(21, 67);
            displaytable.MultiSelect = false;
            displaytable.Name = "displaytable";
            displaytable.RowHeadersWidth = 51;
            displaytable.RowTemplate.Height = 29;
            displaytable.Size = new Size(639, 883);
            displaytable.TabIndex = 0;
            // 
            // openElevatorTimer
            // 
            openElevatorTimer.Interval = 20;
            openElevatorTimer.Tick += timer1_Tick;
            // 
            // closeElevatorTimer
            // 
            closeElevatorTimer.Interval = 20;
            closeElevatorTimer.Tick += timer2_Tick;
            // 
            // moveElevatorTimer
            // 
            moveElevatorTimer.Interval = 60;
            moveElevatorTimer.Tick += timer3_Tick;
            // 
            // automatic_door
            // 
            automatic_door.Tick += automatic_door_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 980);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatortopdisplay2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatortopdisplay1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorleftdoor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorrightdoor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorrightdoor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorleftdoor2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displaypanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevator).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displaytable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button downbutton;
        private PictureBox elevator;
        private Button upbutton;
        private GroupBox groupBox2;
        private PictureBox displaypanel;
        private Button groundfloorbutton;
        private Button closedoor;
        private Button opendoor;
        private Button firstfloorbutton;
        private GroupBox groupBox3;
        private Button Clear_log;
        private DataGridView displaytable;
        private PictureBox elevatorleftdoor2;
        private PictureBox elevatorrightdoor2;
        private PictureBox elevatorleftdoor1;
        private PictureBox elevatorrightdoor1;
        private PictureBox elevatortopdisplay2;
        private PictureBox elevatortopdisplay1;
        private System.Windows.Forms.Timer openElevatorTimer;
        private System.Windows.Forms.Timer closeElevatorTimer;
        private System.Windows.Forms.Timer moveElevatorTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer automatic_door;
        private Button ViewLog;
    }
}