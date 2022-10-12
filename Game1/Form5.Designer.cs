namespace Game1
{
    partial class Form5
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
            this.Time_To_Show_Succ_Plus = new System.Windows.Forms.Timer(this.components);
            this.Duration = new System.Windows.Forms.Timer(this.components);
            this.Start_Game_timer = new System.Windows.Forms.Timer(this.components);
            this.Wrong_Plus_Label = new System.Windows.Forms.Label();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Num_Of_Successful_Clicks_2 = new System.Windows.Forms.Label();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Wrong_Solution_Timer = new System.Windows.Forms.Timer(this.components);
            this.Cnacle_Button = new System.Windows.Forms.Button();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.User_Name_Label_1 = new System.Windows.Forms.Label();
            this.The_Counter_To_Start = new System.Windows.Forms.Label();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Score_Plus_Label = new System.Windows.Forms.Label();
            this.Duration_Label_2 = new System.Windows.Forms.Label();
            this.Num_Of_Successful_Clicks_1 = new System.Windows.Forms.Label();
            this.Start_Word = new System.Windows.Forms.Label();
            this.Num_Of_Wrong_Clicks_2 = new System.Windows.Forms.Label();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Plus_Succ_Click_Label = new System.Windows.Forms.Label();
            this.Cards_Holder = new System.Windows.Forms.Panel();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Scores_Counter_Label_2 = new System.Windows.Forms.Label();
            this.Scores_Label_1 = new System.Windows.Forms.Label();
            this.Duration_Label_1 = new System.Windows.Forms.Label();
            this.Num_Of_Wrong_Clicks_1 = new System.Windows.Forms.Label();
            this.Good_Job_Label = new System.Windows.Forms.Label();
            this.Mins_25_Label = new System.Windows.Forms.Label();
            this.User_Name_Label_2 = new System.Windows.Forms.Label();
            this.Starting_Button = new System.Windows.Forms.PictureBox();
            this.Give_Up_Button = new System.Windows.Forms.PictureBox();
            this.Next_Button_Page_1 = new System.Windows.Forms.PictureBox();
            this.New_Game_Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            this.Cards_Holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starting_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Give_Up_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Button_Page_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Game_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_To_Show_Succ_Plus
            // 
            this.Time_To_Show_Succ_Plus.Interval = 1000;
            this.Time_To_Show_Succ_Plus.Tick += new System.EventHandler(this.Time_To_Show_Succ_Plus_Tick_1);
            // 
            // Duration
            // 
            this.Duration.Interval = 1000;
            this.Duration.Tick += new System.EventHandler(this.Duration_Tick_1);
            // 
            // Start_Game_timer
            // 
            this.Start_Game_timer.Interval = 1000;
            this.Start_Game_timer.Tick += new System.EventHandler(this.Start_Game_timer_Tick_1);
            // 
            // Wrong_Plus_Label
            // 
            this.Wrong_Plus_Label.AutoSize = true;
            this.Wrong_Plus_Label.BackColor = System.Drawing.Color.Transparent;
            this.Wrong_Plus_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong_Plus_Label.ForeColor = System.Drawing.Color.Red;
            this.Wrong_Plus_Label.Location = new System.Drawing.Point(1103, 389);
            this.Wrong_Plus_Label.Name = "Wrong_Plus_Label";
            this.Wrong_Plus_Label.Size = new System.Drawing.Size(43, 42);
            this.Wrong_Plus_Label.TabIndex = 98;
            this.Wrong_Plus_Label.Text = "+1";
            this.Wrong_Plus_Label.Visible = false;
            // 
            // Card9
            // 
            this.Card9.BackColor = System.Drawing.Color.Transparent;
            this.Card9.Location = new System.Drawing.Point(274, 363);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(104, 155);
            this.Card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card9.TabIndex = 8;
            this.Card9.TabStop = false;
            this.Card9.Tag = "4";
            this.Card9.Click += new System.EventHandler(this.Card9_Click);
            // 
            // Card8
            // 
            this.Card8.BackColor = System.Drawing.Color.Transparent;
            this.Card8.Location = new System.Drawing.Point(146, 363);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(104, 155);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 7;
            this.Card8.TabStop = false;
            this.Card8.Tag = "4";
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // Num_Of_Successful_Clicks_2
            // 
            this.Num_Of_Successful_Clicks_2.AutoSize = true;
            this.Num_Of_Successful_Clicks_2.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Successful_Clicks_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Successful_Clicks_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Successful_Clicks_2.ForeColor = System.Drawing.Color.Lime;
            this.Num_Of_Successful_Clicks_2.Location = new System.Drawing.Point(1048, 327);
            this.Num_Of_Successful_Clicks_2.Name = "Num_Of_Successful_Clicks_2";
            this.Num_Of_Successful_Clicks_2.Size = new System.Drawing.Size(31, 39);
            this.Num_Of_Successful_Clicks_2.TabIndex = 91;
            this.Num_Of_Successful_Clicks_2.Text = "0";
            // 
            // Card7
            // 
            this.Card7.BackColor = System.Drawing.Color.Transparent;
            this.Card7.Location = new System.Drawing.Point(14, 363);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(104, 155);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 6;
            this.Card7.TabStop = false;
            this.Card7.Tag = "3";
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // Card6
            // 
            this.Card6.BackColor = System.Drawing.Color.Transparent;
            this.Card6.Location = new System.Drawing.Point(274, 188);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(104, 155);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 5;
            this.Card6.TabStop = false;
            this.Card6.Tag = "3";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // Wrong_Solution_Timer
            // 
            this.Wrong_Solution_Timer.Interval = 300;
            this.Wrong_Solution_Timer.Tick += new System.EventHandler(this.Wrong_Solution_Timer_Tick_1);
            // 
            // Cnacle_Button
            // 
            this.Cnacle_Button.BackColor = System.Drawing.Color.Transparent;
            this.Cnacle_Button.BackgroundImage = global::Game1.Properties.Resources.rsz_1rsz_1rsz_x_sign;
            this.Cnacle_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cnacle_Button.FlatAppearance.BorderSize = 0;
            this.Cnacle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cnacle_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Cnacle_Button.Location = new System.Drawing.Point(1222, 24);
            this.Cnacle_Button.Name = "Cnacle_Button";
            this.Cnacle_Button.Size = new System.Drawing.Size(28, 28);
            this.Cnacle_Button.TabIndex = 103;
            this.Cnacle_Button.UseVisualStyleBackColor = false;
            this.Cnacle_Button.Click += new System.EventHandler(this.Cnacle_Button_Click_1);
            // 
            // Card5
            // 
            this.Card5.BackColor = System.Drawing.Color.Transparent;
            this.Card5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Card5.Location = new System.Drawing.Point(146, 188);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(104, 155);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 4;
            this.Card5.TabStop = false;
            this.Card5.Tag = "0";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // User_Name_Label_1
            // 
            this.User_Name_Label_1.AutoSize = true;
            this.User_Name_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.User_Name_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.User_Name_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label_1.ForeColor = System.Drawing.Color.Black;
            this.User_Name_Label_1.Location = new System.Drawing.Point(556, 193);
            this.User_Name_Label_1.Name = "User_Name_Label_1";
            this.User_Name_Label_1.Size = new System.Drawing.Size(138, 25);
            this.User_Name_Label_1.TabIndex = 96;
            this.User_Name_Label_1.Text = "Username : ";
            // 
            // The_Counter_To_Start
            // 
            this.The_Counter_To_Start.AutoSize = true;
            this.The_Counter_To_Start.BackColor = System.Drawing.Color.Transparent;
            this.The_Counter_To_Start.Cursor = System.Windows.Forms.Cursors.No;
            this.The_Counter_To_Start.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_Counter_To_Start.ForeColor = System.Drawing.Color.Red;
            this.The_Counter_To_Start.Location = new System.Drawing.Point(912, 96);
            this.The_Counter_To_Start.Name = "The_Counter_To_Start";
            this.The_Counter_To_Start.Size = new System.Drawing.Size(62, 77);
            this.The_Counter_To_Start.TabIndex = 104;
            this.The_Counter_To_Start.Text = "5";
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.Color.Transparent;
            this.Card3.Location = new System.Drawing.Point(274, 7);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(104, 155);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 2;
            this.Card3.TabStop = false;
            this.Card3.Tag = "2";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.Color.Transparent;
            this.Card2.Location = new System.Drawing.Point(146, 7);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(104, 155);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 1;
            this.Card2.TabStop = false;
            this.Card2.Tag = "1";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Score_Plus_Label
            // 
            this.Score_Plus_Label.AutoSize = true;
            this.Score_Plus_Label.BackColor = System.Drawing.Color.Transparent;
            this.Score_Plus_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Plus_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Score_Plus_Label.Location = new System.Drawing.Point(1103, 249);
            this.Score_Plus_Label.Name = "Score_Plus_Label";
            this.Score_Plus_Label.Size = new System.Drawing.Size(66, 42);
            this.Score_Plus_Label.TabIndex = 99;
            this.Score_Plus_Label.Text = "+50";
            this.Score_Plus_Label.Visible = false;
            // 
            // Duration_Label_2
            // 
            this.Duration_Label_2.AutoSize = true;
            this.Duration_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Duration_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Duration_Label_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Label_2.ForeColor = System.Drawing.Color.Black;
            this.Duration_Label_2.Location = new System.Drawing.Point(1048, 448);
            this.Duration_Label_2.Name = "Duration_Label_2";
            this.Duration_Label_2.Size = new System.Drawing.Size(31, 39);
            this.Duration_Label_2.TabIndex = 95;
            this.Duration_Label_2.Text = "0";
            // 
            // Num_Of_Successful_Clicks_1
            // 
            this.Num_Of_Successful_Clicks_1.AutoSize = true;
            this.Num_Of_Successful_Clicks_1.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Successful_Clicks_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Successful_Clicks_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Successful_Clicks_1.ForeColor = System.Drawing.Color.Black;
            this.Num_Of_Successful_Clicks_1.Location = new System.Drawing.Point(556, 338);
            this.Num_Of_Successful_Clicks_1.Name = "Num_Of_Successful_Clicks_1";
            this.Num_Of_Successful_Clicks_1.Size = new System.Drawing.Size(255, 25);
            this.Num_Of_Successful_Clicks_1.TabIndex = 90;
            this.Num_Of_Successful_Clicks_1.Text = "# Of Successful Clicks :";
            // 
            // Start_Word
            // 
            this.Start_Word.AutoSize = true;
            this.Start_Word.BackColor = System.Drawing.Color.Transparent;
            this.Start_Word.Cursor = System.Windows.Forms.Cursors.No;
            this.Start_Word.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Word.ForeColor = System.Drawing.Color.Red;
            this.Start_Word.Location = new System.Drawing.Point(692, 24);
            this.Start_Word.Name = "Start_Word";
            this.Start_Word.Size = new System.Drawing.Size(461, 58);
            this.Start_Word.TabIndex = 87;
            this.Start_Word.Text = "The Game Started";
            // 
            // Num_Of_Wrong_Clicks_2
            // 
            this.Num_Of_Wrong_Clicks_2.AutoSize = true;
            this.Num_Of_Wrong_Clicks_2.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Wrong_Clicks_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Wrong_Clicks_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Wrong_Clicks_2.ForeColor = System.Drawing.Color.Red;
            this.Num_Of_Wrong_Clicks_2.Location = new System.Drawing.Point(1048, 392);
            this.Num_Of_Wrong_Clicks_2.Name = "Num_Of_Wrong_Clicks_2";
            this.Num_Of_Wrong_Clicks_2.Size = new System.Drawing.Size(31, 39);
            this.Num_Of_Wrong_Clicks_2.TabIndex = 93;
            this.Num_Of_Wrong_Clicks_2.Text = "0";
            // 
            // Card4
            // 
            this.Card4.BackColor = System.Drawing.Color.Transparent;
            this.Card4.Location = new System.Drawing.Point(14, 188);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(104, 155);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 3;
            this.Card4.TabStop = false;
            this.Card4.Tag = "2";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // Plus_Succ_Click_Label
            // 
            this.Plus_Succ_Click_Label.AutoSize = true;
            this.Plus_Succ_Click_Label.BackColor = System.Drawing.Color.Transparent;
            this.Plus_Succ_Click_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Succ_Click_Label.ForeColor = System.Drawing.Color.Lime;
            this.Plus_Succ_Click_Label.Location = new System.Drawing.Point(1103, 324);
            this.Plus_Succ_Click_Label.Name = "Plus_Succ_Click_Label";
            this.Plus_Succ_Click_Label.Size = new System.Drawing.Size(43, 42);
            this.Plus_Succ_Click_Label.TabIndex = 97;
            this.Plus_Succ_Click_Label.Text = "+1";
            this.Plus_Succ_Click_Label.Visible = false;
            // 
            // Cards_Holder
            // 
            this.Cards_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Cards_Holder.Controls.Add(this.Card9);
            this.Cards_Holder.Controls.Add(this.Card8);
            this.Cards_Holder.Controls.Add(this.Card7);
            this.Cards_Holder.Controls.Add(this.Card6);
            this.Cards_Holder.Controls.Add(this.Card5);
            this.Cards_Holder.Controls.Add(this.Card4);
            this.Cards_Holder.Controls.Add(this.Card3);
            this.Cards_Holder.Controls.Add(this.Card2);
            this.Cards_Holder.Controls.Add(this.Card1);
            this.Cards_Holder.Location = new System.Drawing.Point(40, 123);
            this.Cards_Holder.Name = "Cards_Holder";
            this.Cards_Holder.Size = new System.Drawing.Size(402, 527);
            this.Cards_Holder.TabIndex = 86;
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.Color.Transparent;
            this.Card1.Location = new System.Drawing.Point(14, 7);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(104, 155);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // Scores_Counter_Label_2
            // 
            this.Scores_Counter_Label_2.AutoSize = true;
            this.Scores_Counter_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Scores_Counter_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Scores_Counter_Label_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Counter_Label_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Scores_Counter_Label_2.Location = new System.Drawing.Point(1048, 255);
            this.Scores_Counter_Label_2.Name = "Scores_Counter_Label_2";
            this.Scores_Counter_Label_2.Size = new System.Drawing.Size(31, 39);
            this.Scores_Counter_Label_2.TabIndex = 89;
            this.Scores_Counter_Label_2.Text = "0";
            // 
            // Scores_Label_1
            // 
            this.Scores_Label_1.AutoSize = true;
            this.Scores_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Scores_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Scores_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Label_1.ForeColor = System.Drawing.Color.Black;
            this.Scores_Label_1.Location = new System.Drawing.Point(556, 266);
            this.Scores_Label_1.Name = "Scores_Label_1";
            this.Scores_Label_1.Size = new System.Drawing.Size(101, 25);
            this.Scores_Label_1.TabIndex = 88;
            this.Scores_Label_1.Text = "Scores : ";
            // 
            // Duration_Label_1
            // 
            this.Duration_Label_1.AutoSize = true;
            this.Duration_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Duration_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Duration_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Label_1.ForeColor = System.Drawing.Color.Black;
            this.Duration_Label_1.Location = new System.Drawing.Point(556, 462);
            this.Duration_Label_1.Name = "Duration_Label_1";
            this.Duration_Label_1.Size = new System.Drawing.Size(288, 25);
            this.Duration_Label_1.TabIndex = 94;
            this.Duration_Label_1.Text = "Duration Time By Second :";
            // 
            // Num_Of_Wrong_Clicks_1
            // 
            this.Num_Of_Wrong_Clicks_1.AutoSize = true;
            this.Num_Of_Wrong_Clicks_1.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Wrong_Clicks_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Wrong_Clicks_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Wrong_Clicks_1.ForeColor = System.Drawing.Color.Black;
            this.Num_Of_Wrong_Clicks_1.Location = new System.Drawing.Point(556, 403);
            this.Num_Of_Wrong_Clicks_1.Name = "Num_Of_Wrong_Clicks_1";
            this.Num_Of_Wrong_Clicks_1.Size = new System.Drawing.Size(216, 25);
            this.Num_Of_Wrong_Clicks_1.TabIndex = 92;
            this.Num_Of_Wrong_Clicks_1.Text = "# Of Wrong Clicks :";
            // 
            // Good_Job_Label
            // 
            this.Good_Job_Label.AutoSize = true;
            this.Good_Job_Label.BackColor = System.Drawing.Color.Transparent;
            this.Good_Job_Label.Cursor = System.Windows.Forms.Cursors.No;
            this.Good_Job_Label.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Good_Job_Label.ForeColor = System.Drawing.Color.Lime;
            this.Good_Job_Label.Location = new System.Drawing.Point(819, 24);
            this.Good_Job_Label.Name = "Good_Job_Label";
            this.Good_Job_Label.Size = new System.Drawing.Size(249, 58);
            this.Good_Job_Label.TabIndex = 126;
            this.Good_Job_Label.Text = "Good Job";
            this.Good_Job_Label.Visible = false;
            // 
            // Mins_25_Label
            // 
            this.Mins_25_Label.AutoSize = true;
            this.Mins_25_Label.BackColor = System.Drawing.Color.Transparent;
            this.Mins_25_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mins_25_Label.ForeColor = System.Drawing.Color.Red;
            this.Mins_25_Label.Location = new System.Drawing.Point(1109, 255);
            this.Mins_25_Label.Name = "Mins_25_Label";
            this.Mins_25_Label.Size = new System.Drawing.Size(60, 42);
            this.Mins_25_Label.TabIndex = 127;
            this.Mins_25_Label.Text = "-25";
            this.Mins_25_Label.Visible = false;
            // 
            // User_Name_Label_2
            // 
            this.User_Name_Label_2.AutoSize = true;
            this.User_Name_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.User_Name_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.User_Name_Label_2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label_2.ForeColor = System.Drawing.Color.Black;
            this.User_Name_Label_2.Location = new System.Drawing.Point(1050, 193);
            this.User_Name_Label_2.Name = "User_Name_Label_2";
            this.User_Name_Label_2.Size = new System.Drawing.Size(118, 25);
            this.User_Name_Label_2.TabIndex = 128;
            this.User_Name_Label_2.Text = "Username";
            // 
            // Starting_Button
            // 
            this.Starting_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Starting_Button.Image = global::Game1.Properties.Resources.Start_Button;
            this.Starting_Button.Location = new System.Drawing.Point(899, 83);
            this.Starting_Button.Name = "Starting_Button";
            this.Starting_Button.Size = new System.Drawing.Size(93, 90);
            this.Starting_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Starting_Button.TabIndex = 133;
            this.Starting_Button.TabStop = false;
            this.Starting_Button.Click += new System.EventHandler(this.Starting_Button_Click_1);
            // 
            // Give_Up_Button
            // 
            this.Give_Up_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Give_Up_Button.Image = global::Game1.Properties.Resources.Give_Up_Button;
            this.Give_Up_Button.Location = new System.Drawing.Point(622, 634);
            this.Give_Up_Button.Name = "Give_Up_Button";
            this.Give_Up_Button.Size = new System.Drawing.Size(77, 77);
            this.Give_Up_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Give_Up_Button.TabIndex = 136;
            this.Give_Up_Button.TabStop = false;
            this.Give_Up_Button.Visible = false;
            this.Give_Up_Button.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Next_Button_Page_1
            // 
            this.Next_Button_Page_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_Button_Page_1.Image = global::Game1.Properties.Resources.Next_Button;
            this.Next_Button_Page_1.Location = new System.Drawing.Point(1031, 634);
            this.Next_Button_Page_1.Name = "Next_Button_Page_1";
            this.Next_Button_Page_1.Size = new System.Drawing.Size(77, 77);
            this.Next_Button_Page_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next_Button_Page_1.TabIndex = 135;
            this.Next_Button_Page_1.TabStop = false;
            this.Next_Button_Page_1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // New_Game_Button
            // 
            this.New_Game_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_Game_Button.Image = global::Game1.Properties.Resources.reload_button;
            this.New_Game_Button.Location = new System.Drawing.Point(829, 634);
            this.New_Game_Button.Name = "New_Game_Button";
            this.New_Game_Button.Size = new System.Drawing.Size(77, 77);
            this.New_Game_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.New_Game_Button.TabIndex = 134;
            this.New_Game_Button.TabStop = false;
            this.New_Game_Button.Click += new System.EventHandler(this.New_Game_Button_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Give_Up_Button);
            this.Controls.Add(this.Next_Button_Page_1);
            this.Controls.Add(this.New_Game_Button);
            this.Controls.Add(this.Starting_Button);
            this.Controls.Add(this.User_Name_Label_2);
            this.Controls.Add(this.Mins_25_Label);
            this.Controls.Add(this.Good_Job_Label);
            this.Controls.Add(this.Wrong_Plus_Label);
            this.Controls.Add(this.Num_Of_Successful_Clicks_2);
            this.Controls.Add(this.Cnacle_Button);
            this.Controls.Add(this.User_Name_Label_1);
            this.Controls.Add(this.The_Counter_To_Start);
            this.Controls.Add(this.Score_Plus_Label);
            this.Controls.Add(this.Duration_Label_2);
            this.Controls.Add(this.Num_Of_Successful_Clicks_1);
            this.Controls.Add(this.Start_Word);
            this.Controls.Add(this.Num_Of_Wrong_Clicks_2);
            this.Controls.Add(this.Plus_Succ_Click_Label);
            this.Controls.Add(this.Cards_Holder);
            this.Controls.Add(this.Scores_Counter_Label_2);
            this.Controls.Add(this.Scores_Label_1);
            this.Controls.Add(this.Duration_Label_1);
            this.Controls.Add(this.Num_Of_Wrong_Clicks_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            this.Cards_Holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starting_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Give_Up_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Button_Page_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Game_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Time_To_Show_Succ_Plus;
        private System.Windows.Forms.Timer Duration;
        private System.Windows.Forms.Timer Start_Game_timer;
        private System.Windows.Forms.Label Wrong_Plus_Label;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.Label Num_Of_Successful_Clicks_2;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.Timer Wrong_Solution_Timer;
        private System.Windows.Forms.Button Cnacle_Button;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.Label User_Name_Label_1;
        private System.Windows.Forms.Label The_Counter_To_Start;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.Label Score_Plus_Label;
        private System.Windows.Forms.Label Duration_Label_2;
        private System.Windows.Forms.Label Num_Of_Successful_Clicks_1;
        private System.Windows.Forms.Label Start_Word;
        private System.Windows.Forms.Label Num_Of_Wrong_Clicks_2;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.Label Plus_Succ_Click_Label;
        private System.Windows.Forms.Panel Cards_Holder;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Label Scores_Counter_Label_2;
        private System.Windows.Forms.Label Scores_Label_1;
        private System.Windows.Forms.Label Duration_Label_1;
        private System.Windows.Forms.Label Num_Of_Wrong_Clicks_1;
        private System.Windows.Forms.Label Good_Job_Label;
        private System.Windows.Forms.Label Mins_25_Label;
        private System.Windows.Forms.Label User_Name_Label_2;
        private System.Windows.Forms.PictureBox Starting_Button;
        private System.Windows.Forms.PictureBox Give_Up_Button;
        private System.Windows.Forms.PictureBox Next_Button_Page_1;
        private System.Windows.Forms.PictureBox New_Game_Button;
    }
}