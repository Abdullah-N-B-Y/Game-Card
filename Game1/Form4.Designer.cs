namespace Game1
{
    partial class Form4
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
            this.The_Counter_To_Start = new System.Windows.Forms.Label();
            this.User_Name_Label_1 = new System.Windows.Forms.Label();
            this.Score_Plus_Label = new System.Windows.Forms.Label();
            this.Wrong_Plus_Label = new System.Windows.Forms.Label();
            this.Plus_Succ_Click_Label = new System.Windows.Forms.Label();
            this.Duration_Label_2 = new System.Windows.Forms.Label();
            this.Num_Of_Successful_Clicks_1 = new System.Windows.Forms.Label();
            this.Scores_Counter_Label_2 = new System.Windows.Forms.Label();
            this.Start_Word = new System.Windows.Forms.Label();
            this.Num_Of_Wrong_Clicks_2 = new System.Windows.Forms.Label();
            this.Num_Of_Successful_Clicks_2 = new System.Windows.Forms.Label();
            this.Num_Of_Wrong_Clicks_1 = new System.Windows.Forms.Label();
            this.Duration_Label_1 = new System.Windows.Forms.Label();
            this.Scores_Label_1 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Timer(this.components);
            this.Wrong_Solution_Timer = new System.Windows.Forms.Timer(this.components);
            this.Time_To_Show_Succ_Plus = new System.Windows.Forms.Timer(this.components);
            this.Start_Game_timer = new System.Windows.Forms.Timer(this.components);
            this.Mins_25_Label = new System.Windows.Forms.Label();
            this.Good_Job_Label = new System.Windows.Forms.Label();
            this.User_Name_Label_2 = new System.Windows.Forms.Label();
            this.Cards_Holder = new System.Windows.Forms.Panel();
            this.Card4_2X2 = new System.Windows.Forms.PictureBox();
            this.Card3_2X2 = new System.Windows.Forms.PictureBox();
            this.Card2_2X2 = new System.Windows.Forms.PictureBox();
            this.Card1_2X2 = new System.Windows.Forms.PictureBox();
            this.Showing_Cards_Correct_Timer = new System.Windows.Forms.Timer(this.components);
            this.Starting_Button = new System.Windows.Forms.PictureBox();
            this.Give_Up_Button = new System.Windows.Forms.PictureBox();
            this.Next_Button_Page_1 = new System.Windows.Forms.PictureBox();
            this.New_Game_Button = new System.Windows.Forms.PictureBox();
            this.Cnacle_Button = new System.Windows.Forms.Button();
            this.Cards_Holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card4_2X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3_2X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2_2X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1_2X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starting_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Give_Up_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Button_Page_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Game_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // The_Counter_To_Start
            // 
            this.The_Counter_To_Start.AutoSize = true;
            this.The_Counter_To_Start.BackColor = System.Drawing.Color.Transparent;
            this.The_Counter_To_Start.Cursor = System.Windows.Forms.Cursors.No;
            this.The_Counter_To_Start.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_Counter_To_Start.ForeColor = System.Drawing.Color.Red;
            this.The_Counter_To_Start.Location = new System.Drawing.Point(898, 92);
            this.The_Counter_To_Start.Name = "The_Counter_To_Start";
            this.The_Counter_To_Start.Size = new System.Drawing.Size(62, 77);
            this.The_Counter_To_Start.TabIndex = 123;
            this.The_Counter_To_Start.Text = "5";
            // 
            // User_Name_Label_1
            // 
            this.User_Name_Label_1.AutoSize = true;
            this.User_Name_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.User_Name_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.User_Name_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label_1.ForeColor = System.Drawing.Color.Black;
            this.User_Name_Label_1.Location = new System.Drawing.Point(600, 198);
            this.User_Name_Label_1.Name = "User_Name_Label_1";
            this.User_Name_Label_1.Size = new System.Drawing.Size(138, 25);
            this.User_Name_Label_1.TabIndex = 115;
            this.User_Name_Label_1.Text = "Username : ";
            // 
            // Score_Plus_Label
            // 
            this.Score_Plus_Label.AutoSize = true;
            this.Score_Plus_Label.BackColor = System.Drawing.Color.Transparent;
            this.Score_Plus_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Plus_Label.ForeColor = System.Drawing.Color.Aqua;
            this.Score_Plus_Label.Location = new System.Drawing.Point(1146, 254);
            this.Score_Plus_Label.Name = "Score_Plus_Label";
            this.Score_Plus_Label.Size = new System.Drawing.Size(66, 42);
            this.Score_Plus_Label.TabIndex = 118;
            this.Score_Plus_Label.Text = "+50";
            this.Score_Plus_Label.Visible = false;
            // 
            // Wrong_Plus_Label
            // 
            this.Wrong_Plus_Label.AutoSize = true;
            this.Wrong_Plus_Label.BackColor = System.Drawing.Color.Transparent;
            this.Wrong_Plus_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong_Plus_Label.ForeColor = System.Drawing.Color.Red;
            this.Wrong_Plus_Label.Location = new System.Drawing.Point(1146, 394);
            this.Wrong_Plus_Label.Name = "Wrong_Plus_Label";
            this.Wrong_Plus_Label.Size = new System.Drawing.Size(43, 42);
            this.Wrong_Plus_Label.TabIndex = 117;
            this.Wrong_Plus_Label.Text = "+1";
            this.Wrong_Plus_Label.Visible = false;
            // 
            // Plus_Succ_Click_Label
            // 
            this.Plus_Succ_Click_Label.AutoSize = true;
            this.Plus_Succ_Click_Label.BackColor = System.Drawing.Color.Transparent;
            this.Plus_Succ_Click_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Succ_Click_Label.ForeColor = System.Drawing.Color.Lime;
            this.Plus_Succ_Click_Label.Location = new System.Drawing.Point(1146, 329);
            this.Plus_Succ_Click_Label.Name = "Plus_Succ_Click_Label";
            this.Plus_Succ_Click_Label.Size = new System.Drawing.Size(43, 42);
            this.Plus_Succ_Click_Label.TabIndex = 116;
            this.Plus_Succ_Click_Label.Text = "+1";
            this.Plus_Succ_Click_Label.Visible = false;
            // 
            // Duration_Label_2
            // 
            this.Duration_Label_2.AutoSize = true;
            this.Duration_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Duration_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Duration_Label_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Label_2.ForeColor = System.Drawing.Color.Black;
            this.Duration_Label_2.Location = new System.Drawing.Point(1068, 453);
            this.Duration_Label_2.Name = "Duration_Label_2";
            this.Duration_Label_2.Size = new System.Drawing.Size(31, 39);
            this.Duration_Label_2.TabIndex = 114;
            this.Duration_Label_2.Text = "0";
            // 
            // Num_Of_Successful_Clicks_1
            // 
            this.Num_Of_Successful_Clicks_1.AutoSize = true;
            this.Num_Of_Successful_Clicks_1.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Successful_Clicks_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Successful_Clicks_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Successful_Clicks_1.ForeColor = System.Drawing.Color.Black;
            this.Num_Of_Successful_Clicks_1.Location = new System.Drawing.Point(600, 343);
            this.Num_Of_Successful_Clicks_1.Name = "Num_Of_Successful_Clicks_1";
            this.Num_Of_Successful_Clicks_1.Size = new System.Drawing.Size(255, 25);
            this.Num_Of_Successful_Clicks_1.TabIndex = 109;
            this.Num_Of_Successful_Clicks_1.Text = "# Of Successful Clicks :";
            // 
            // Scores_Counter_Label_2
            // 
            this.Scores_Counter_Label_2.AutoSize = true;
            this.Scores_Counter_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Scores_Counter_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Scores_Counter_Label_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Counter_Label_2.ForeColor = System.Drawing.Color.White;
            this.Scores_Counter_Label_2.Location = new System.Drawing.Point(1068, 260);
            this.Scores_Counter_Label_2.Name = "Scores_Counter_Label_2";
            this.Scores_Counter_Label_2.Size = new System.Drawing.Size(31, 39);
            this.Scores_Counter_Label_2.TabIndex = 108;
            this.Scores_Counter_Label_2.Text = "0";
            // 
            // Start_Word
            // 
            this.Start_Word.AutoSize = true;
            this.Start_Word.BackColor = System.Drawing.Color.Transparent;
            this.Start_Word.Cursor = System.Windows.Forms.Cursors.No;
            this.Start_Word.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Word.ForeColor = System.Drawing.Color.Red;
            this.Start_Word.Location = new System.Drawing.Point(691, 24);
            this.Start_Word.Name = "Start_Word";
            this.Start_Word.Size = new System.Drawing.Size(461, 58);
            this.Start_Word.TabIndex = 106;
            this.Start_Word.Text = "The Game Started";
            this.Start_Word.Visible = false;
            // 
            // Num_Of_Wrong_Clicks_2
            // 
            this.Num_Of_Wrong_Clicks_2.AutoSize = true;
            this.Num_Of_Wrong_Clicks_2.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Wrong_Clicks_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Wrong_Clicks_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Wrong_Clicks_2.ForeColor = System.Drawing.Color.Red;
            this.Num_Of_Wrong_Clicks_2.Location = new System.Drawing.Point(1068, 397);
            this.Num_Of_Wrong_Clicks_2.Name = "Num_Of_Wrong_Clicks_2";
            this.Num_Of_Wrong_Clicks_2.Size = new System.Drawing.Size(31, 39);
            this.Num_Of_Wrong_Clicks_2.TabIndex = 112;
            this.Num_Of_Wrong_Clicks_2.Text = "0";
            // 
            // Num_Of_Successful_Clicks_2
            // 
            this.Num_Of_Successful_Clicks_2.AutoSize = true;
            this.Num_Of_Successful_Clicks_2.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Successful_Clicks_2.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Successful_Clicks_2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Successful_Clicks_2.ForeColor = System.Drawing.Color.Lime;
            this.Num_Of_Successful_Clicks_2.Location = new System.Drawing.Point(1068, 332);
            this.Num_Of_Successful_Clicks_2.Name = "Num_Of_Successful_Clicks_2";
            this.Num_Of_Successful_Clicks_2.Size = new System.Drawing.Size(31, 39);
            this.Num_Of_Successful_Clicks_2.TabIndex = 110;
            this.Num_Of_Successful_Clicks_2.Text = "0";
            // 
            // Num_Of_Wrong_Clicks_1
            // 
            this.Num_Of_Wrong_Clicks_1.AutoSize = true;
            this.Num_Of_Wrong_Clicks_1.BackColor = System.Drawing.Color.Transparent;
            this.Num_Of_Wrong_Clicks_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Num_Of_Wrong_Clicks_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Wrong_Clicks_1.ForeColor = System.Drawing.Color.Black;
            this.Num_Of_Wrong_Clicks_1.Location = new System.Drawing.Point(600, 408);
            this.Num_Of_Wrong_Clicks_1.Name = "Num_Of_Wrong_Clicks_1";
            this.Num_Of_Wrong_Clicks_1.Size = new System.Drawing.Size(216, 25);
            this.Num_Of_Wrong_Clicks_1.TabIndex = 111;
            this.Num_Of_Wrong_Clicks_1.Text = "# Of Wrong Clicks :";
            // 
            // Duration_Label_1
            // 
            this.Duration_Label_1.AutoSize = true;
            this.Duration_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Duration_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Duration_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Label_1.ForeColor = System.Drawing.Color.Black;
            this.Duration_Label_1.Location = new System.Drawing.Point(600, 467);
            this.Duration_Label_1.Name = "Duration_Label_1";
            this.Duration_Label_1.Size = new System.Drawing.Size(143, 25);
            this.Duration_Label_1.TabIndex = 113;
            this.Duration_Label_1.Text = "Duration (S)";
            // 
            // Scores_Label_1
            // 
            this.Scores_Label_1.AutoSize = true;
            this.Scores_Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Scores_Label_1.Cursor = System.Windows.Forms.Cursors.No;
            this.Scores_Label_1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Label_1.ForeColor = System.Drawing.Color.Black;
            this.Scores_Label_1.Location = new System.Drawing.Point(600, 271);
            this.Scores_Label_1.Name = "Scores_Label_1";
            this.Scores_Label_1.Size = new System.Drawing.Size(101, 25);
            this.Scores_Label_1.TabIndex = 107;
            this.Scores_Label_1.Text = "Scores : ";
            // 
            // Duration
            // 
            this.Duration.Interval = 1000;
            this.Duration.Tick += new System.EventHandler(this.Duration_Tick);
            // 
            // Wrong_Solution_Timer
            // 
            this.Wrong_Solution_Timer.Interval = 300;
            this.Wrong_Solution_Timer.Tick += new System.EventHandler(this.Wrong_Solution_Timer_Tick);
            // 
            // Time_To_Show_Succ_Plus
            // 
            this.Time_To_Show_Succ_Plus.Interval = 1000;
            this.Time_To_Show_Succ_Plus.Tick += new System.EventHandler(this.Time_To_Show_Succ_Plus_Tick);
            // 
            // Start_Game_timer
            // 
            this.Start_Game_timer.Interval = 1000;
            this.Start_Game_timer.Tick += new System.EventHandler(this.Start_Game_timer_Tick);
            // 
            // Mins_25_Label
            // 
            this.Mins_25_Label.AutoSize = true;
            this.Mins_25_Label.BackColor = System.Drawing.Color.Transparent;
            this.Mins_25_Label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mins_25_Label.ForeColor = System.Drawing.Color.Red;
            this.Mins_25_Label.Location = new System.Drawing.Point(1152, 257);
            this.Mins_25_Label.Name = "Mins_25_Label";
            this.Mins_25_Label.Size = new System.Drawing.Size(60, 42);
            this.Mins_25_Label.TabIndex = 124;
            this.Mins_25_Label.Text = "-25";
            this.Mins_25_Label.Visible = false;
            // 
            // Good_Job_Label
            // 
            this.Good_Job_Label.AutoSize = true;
            this.Good_Job_Label.BackColor = System.Drawing.Color.Transparent;
            this.Good_Job_Label.Cursor = System.Windows.Forms.Cursors.No;
            this.Good_Job_Label.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Good_Job_Label.ForeColor = System.Drawing.Color.Lime;
            this.Good_Job_Label.Location = new System.Drawing.Point(814, 24);
            this.Good_Job_Label.Name = "Good_Job_Label";
            this.Good_Job_Label.Size = new System.Drawing.Size(249, 58);
            this.Good_Job_Label.TabIndex = 125;
            this.Good_Job_Label.Text = "Good Job";
            this.Good_Job_Label.Visible = false;
            // 
            // User_Name_Label_2
            // 
            this.User_Name_Label_2.AutoSize = true;
            this.User_Name_Label_2.BackColor = System.Drawing.Color.Transparent;
            this.User_Name_Label_2.Cursor = System.Windows.Forms.Cursors.No;
            this.User_Name_Label_2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label_2.ForeColor = System.Drawing.Color.Black;
            this.User_Name_Label_2.Location = new System.Drawing.Point(1070, 198);
            this.User_Name_Label_2.Name = "User_Name_Label_2";
            this.User_Name_Label_2.Size = new System.Drawing.Size(118, 25);
            this.User_Name_Label_2.TabIndex = 126;
            this.User_Name_Label_2.Text = "Username";
            // 
            // Cards_Holder
            // 
            this.Cards_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Cards_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cards_Holder.Controls.Add(this.Card4_2X2);
            this.Cards_Holder.Controls.Add(this.Card3_2X2);
            this.Cards_Holder.Controls.Add(this.Card2_2X2);
            this.Cards_Holder.Controls.Add(this.Card1_2X2);
            this.Cards_Holder.Location = new System.Drawing.Point(51, 78);
            this.Cards_Holder.Name = "Cards_Holder";
            this.Cards_Holder.Size = new System.Drawing.Size(405, 541);
            this.Cards_Holder.TabIndex = 105;
            // 
            // Card4_2X2
            // 
            this.Card4_2X2.BackColor = System.Drawing.Color.Transparent;
            this.Card4_2X2.Location = new System.Drawing.Point(225, 292);
            this.Card4_2X2.Name = "Card4_2X2";
            this.Card4_2X2.Size = new System.Drawing.Size(138, 188);
            this.Card4_2X2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4_2X2.TabIndex = 3;
            this.Card4_2X2.TabStop = false;
            this.Card4_2X2.Tag = "2";
            this.Card4_2X2.Click += new System.EventHandler(this.Card4_2X2_Click);
            // 
            // Card3_2X2
            // 
            this.Card3_2X2.BackColor = System.Drawing.Color.Transparent;
            this.Card3_2X2.Location = new System.Drawing.Point(37, 292);
            this.Card3_2X2.Name = "Card3_2X2";
            this.Card3_2X2.Size = new System.Drawing.Size(138, 188);
            this.Card3_2X2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3_2X2.TabIndex = 2;
            this.Card3_2X2.TabStop = false;
            this.Card3_2X2.Tag = "2";
            this.Card3_2X2.Click += new System.EventHandler(this.Card3_2X2_Click);
            // 
            // Card2_2X2
            // 
            this.Card2_2X2.BackColor = System.Drawing.Color.Transparent;
            this.Card2_2X2.Location = new System.Drawing.Point(225, 50);
            this.Card2_2X2.Name = "Card2_2X2";
            this.Card2_2X2.Size = new System.Drawing.Size(138, 188);
            this.Card2_2X2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2_2X2.TabIndex = 1;
            this.Card2_2X2.TabStop = false;
            this.Card2_2X2.Tag = "1";
            this.Card2_2X2.Click += new System.EventHandler(this.Card2_2X2_Click);
            // 
            // Card1_2X2
            // 
            this.Card1_2X2.BackColor = System.Drawing.Color.Transparent;
            this.Card1_2X2.Location = new System.Drawing.Point(37, 50);
            this.Card1_2X2.Name = "Card1_2X2";
            this.Card1_2X2.Size = new System.Drawing.Size(138, 188);
            this.Card1_2X2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1_2X2.TabIndex = 0;
            this.Card1_2X2.TabStop = false;
            this.Card1_2X2.Tag = "1";
            this.Card1_2X2.Click += new System.EventHandler(this.Card1_2X2_Click);
            // 
            // Showing_Cards_Correct_Timer
            // 
            this.Showing_Cards_Correct_Timer.Interval = 600;
            this.Showing_Cards_Correct_Timer.Tick += new System.EventHandler(this.Showing_Cards_Correct_Timer_Tick);
            // 
            // Starting_Button
            // 
            this.Starting_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Starting_Button.Image = global::Game1.Properties.Resources.Start_Button;
            this.Starting_Button.Location = new System.Drawing.Point(883, 85);
            this.Starting_Button.Name = "Starting_Button";
            this.Starting_Button.Size = new System.Drawing.Size(93, 90);
            this.Starting_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Starting_Button.TabIndex = 132;
            this.Starting_Button.TabStop = false;
            this.Starting_Button.Click += new System.EventHandler(this.Starting_Button_Click_1);
            // 
            // Give_Up_Button
            // 
            this.Give_Up_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Give_Up_Button.Image = global::Game1.Properties.Resources.Give_Up_Button;
            this.Give_Up_Button.Location = new System.Drawing.Point(666, 638);
            this.Give_Up_Button.Name = "Give_Up_Button";
            this.Give_Up_Button.Size = new System.Drawing.Size(77, 77);
            this.Give_Up_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Give_Up_Button.TabIndex = 131;
            this.Give_Up_Button.TabStop = false;
            this.Give_Up_Button.Visible = false;
            this.Give_Up_Button.Click += new System.EventHandler(this.Give_Up_Button_Click);
            // 
            // Next_Button_Page_1
            // 
            this.Next_Button_Page_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_Button_Page_1.Image = global::Game1.Properties.Resources.Next_Button;
            this.Next_Button_Page_1.Location = new System.Drawing.Point(1075, 638);
            this.Next_Button_Page_1.Name = "Next_Button_Page_1";
            this.Next_Button_Page_1.Size = new System.Drawing.Size(77, 77);
            this.Next_Button_Page_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next_Button_Page_1.TabIndex = 130;
            this.Next_Button_Page_1.TabStop = false;
            this.Next_Button_Page_1.Click += new System.EventHandler(this.Next_Button_Page_1_Click_1);
            // 
            // New_Game_Button
            // 
            this.New_Game_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_Game_Button.Image = global::Game1.Properties.Resources.reload_button;
            this.New_Game_Button.Location = new System.Drawing.Point(873, 638);
            this.New_Game_Button.Name = "New_Game_Button";
            this.New_Game_Button.Size = new System.Drawing.Size(77, 77);
            this.New_Game_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.New_Game_Button.TabIndex = 129;
            this.New_Game_Button.TabStop = false;
            this.New_Game_Button.Click += new System.EventHandler(this.New_Game_Button_Click_2);
            // 
            // Cnacle_Button
            // 
            this.Cnacle_Button.BackColor = System.Drawing.Color.Transparent;
            this.Cnacle_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cnacle_Button.FlatAppearance.BorderSize = 0;
            this.Cnacle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cnacle_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Cnacle_Button.Location = new System.Drawing.Point(1190, 24);
            this.Cnacle_Button.Name = "Cnacle_Button";
            this.Cnacle_Button.Size = new System.Drawing.Size(28, 28);
            this.Cnacle_Button.TabIndex = 122;
            this.Cnacle_Button.UseVisualStyleBackColor = false;
            this.Cnacle_Button.Click += new System.EventHandler(this.Cnacle_Button_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Starting_Button);
            this.Controls.Add(this.Give_Up_Button);
            this.Controls.Add(this.Next_Button_Page_1);
            this.Controls.Add(this.New_Game_Button);
            this.Controls.Add(this.User_Name_Label_2);
            this.Controls.Add(this.Good_Job_Label);
            this.Controls.Add(this.Mins_25_Label);
            this.Controls.Add(this.The_Counter_To_Start);
            this.Controls.Add(this.User_Name_Label_1);
            this.Controls.Add(this.Cnacle_Button);
            this.Controls.Add(this.Score_Plus_Label);
            this.Controls.Add(this.Wrong_Plus_Label);
            this.Controls.Add(this.Plus_Succ_Click_Label);
            this.Controls.Add(this.Duration_Label_2);
            this.Controls.Add(this.Num_Of_Successful_Clicks_1);
            this.Controls.Add(this.Cards_Holder);
            this.Controls.Add(this.Scores_Counter_Label_2);
            this.Controls.Add(this.Start_Word);
            this.Controls.Add(this.Num_Of_Wrong_Clicks_2);
            this.Controls.Add(this.Num_Of_Successful_Clicks_2);
            this.Controls.Add(this.Num_Of_Wrong_Clicks_1);
            this.Controls.Add(this.Duration_Label_1);
            this.Controls.Add(this.Scores_Label_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Cards_Holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Card4_2X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3_2X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2_2X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1_2X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starting_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Give_Up_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Button_Page_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Game_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label The_Counter_To_Start;
        private System.Windows.Forms.Label User_Name_Label_1;
        private System.Windows.Forms.Button Cnacle_Button;
        private System.Windows.Forms.Label Score_Plus_Label;
        private System.Windows.Forms.Label Wrong_Plus_Label;
        private System.Windows.Forms.Label Plus_Succ_Click_Label;
        private System.Windows.Forms.Label Duration_Label_2;
        private System.Windows.Forms.Label Num_Of_Successful_Clicks_1;
        private System.Windows.Forms.Panel Cards_Holder;
        private System.Windows.Forms.PictureBox Card4_2X2;
        private System.Windows.Forms.PictureBox Card3_2X2;
        private System.Windows.Forms.PictureBox Card2_2X2;
        private System.Windows.Forms.PictureBox Card1_2X2;
        private System.Windows.Forms.Label Scores_Counter_Label_2;
        private System.Windows.Forms.Label Start_Word;
        private System.Windows.Forms.Label Num_Of_Wrong_Clicks_2;
        private System.Windows.Forms.Label Num_Of_Successful_Clicks_2;
        private System.Windows.Forms.Label Num_Of_Wrong_Clicks_1;
        private System.Windows.Forms.Label Duration_Label_1;
        private System.Windows.Forms.Label Scores_Label_1;
        private System.Windows.Forms.Timer Duration;
        private System.Windows.Forms.Timer Wrong_Solution_Timer;
        private System.Windows.Forms.Timer Time_To_Show_Succ_Plus;
        private System.Windows.Forms.Timer Start_Game_timer;
        private System.Windows.Forms.Label Mins_25_Label;
        private System.Windows.Forms.Label Good_Job_Label;
        private System.Windows.Forms.Label User_Name_Label_2;
        private System.Windows.Forms.Timer Showing_Cards_Correct_Timer;
        private System.Windows.Forms.PictureBox New_Game_Button;
        private System.Windows.Forms.PictureBox Next_Button_Page_1;
        private System.Windows.Forms.PictureBox Give_Up_Button;
        private System.Windows.Forms.PictureBox Starting_Button;
    }
}