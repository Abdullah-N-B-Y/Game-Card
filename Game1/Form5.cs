using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form5 : Form
    {
        #region Attributes
            Thread thread;
            private PictureBox picturebox_1;
            private PictureBox pictureBox_2;
            private int Score_Num;
            private int Num_Of_Succ_Clicks;
            private int Num_Of_Wrong_Clicks;
            private int Duration_By_Second;
            private Random location = new Random();
            private List<Point> Points = new List<Point>();
            public static List<Point> Points_Play_Back = new List<Point>();
            private static int Count = 0;
            public static string Name1 = "";
            SoundPlayer sound1,sound2;
            int Count1 = 0;
        #endregion
        public Form5()
        {
            InitializeComponent();
            sound2 = new SoundPlayer(@"TimerSound1.wav");
            sound1 = new SoundPlayer(@"C2.wav");

        }

        #region Cards 3X3
        private void Form5_Load(object sender, EventArgs e)
            {
                if (Form3.profile.BackgroundColor.Equals("Blue"))
                {
                    this.BackColor = Color.Blue;
                }
                else if (Form3.profile.BackgroundColor.Equals("Red"))
                {
                    this.BackColor = Color.DarkRed;
                }
                else if (Form3.profile.BackgroundColor.Equals("Yellow"))
                {
                    this.BackColor = Color.Yellow;
                }
                User_Name_Label_2.Text = Form3.UserName;
                foreach (PictureBox picture in Cards_Holder.Controls)
                {
                    picture.Image = Properties.Resources.Neon_Question_Card;
                    picture.Enabled = false;
                }
                New_Game_Button.Visible = false;
                Next_Button_Page_1.Visible = false;
                Start_Word.Visible = false;
            }
            private void Card1_Click(object sender, EventArgs e)
            {
                Card1.Image = Properties.Resources.Anqles_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 1 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 1 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card1;
                    Card1.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card1;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card1.Image = Properties.Resources.Anqles_Neon_Card;
                        Card1.Enabled = false;
                        //Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card2.Enabled = false;
                        //Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;

                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card1.Enabled = true;
                        Card_3X3_1_2_Fun();
                    }
                }
            }
            private void Card2_Click(object sender, EventArgs e)
            {
                Card2.Image = Properties.Resources.Anqles_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 2 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 2 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card2;
                    Card2.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card2;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        picturebox_1 = null;
                        pictureBox_2 = null;
                        Card2.Image = Properties.Resources.Anqles_Neon_Card;
                        Card2.Enabled = false;
                        //Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card1.Enabled = false;
                        //Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card2.Enabled = true;
                        Card_3X3_1_2_Fun();
                    }

                }
            }
            private void Card3_Click(object sender, EventArgs e)
            {
                Card3.Image = Properties.Resources.Sadafah_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 3 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 3 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card3;
                    Card3.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card3;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card3.Image = Properties.Resources.Sadafah_Neon_Card;
                        Card3.Enabled = false;
                        //Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card4.Enabled = false;
                        //Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card3.Enabled = true;
                        Card_3X3_3_4_Fun();
                    }
                }
            }
            private void Card4_Click(object sender, EventArgs e)
            {
                Card4.Image = Properties.Resources.Sadafah_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 4 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 4 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card4;
                    Card4.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card4;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card4.Image = Properties.Resources.Sadafah_Neon_Card;
                        Card4.Enabled = false;
                        //Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card3.Enabled = false;
                        //Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card4.Enabled = true;
                        Card_3X3_3_4_Fun();
                    }
                }
            }
            private void Card5_Click(object sender, EventArgs e)
            {
                Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 5 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 5 3X3 Level");
                Card5.Enabled = false;
            }
            private void Card6_Click(object sender, EventArgs e)
            {
                Card6.Image = Properties.Resources.JellyFish_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 6 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 6 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card6;
                    Card6.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card6;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card6.Image = Properties.Resources.JellyFish_Neon_Card;
                        Card6.Enabled = false;
                        //Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card7.Enabled = false;
                        //Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card6.Enabled = true;
                        Card_3X3_6_7_Fun();
                    }
                }
            }
            private void Card7_Click(object sender, EventArgs e)
            {
                Card7.Image = Properties.Resources.JellyFish_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 7 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 7 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card7;
                    Card7.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card7;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card7.Image = Properties.Resources.JellyFish_Neon_Card;
                        Card7.Enabled = false;
                        //Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card6.Enabled = false;
                        //Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card7.Enabled = true;
                        Card_3X3_6_7_Fun();
                    }
                }
            }
            private void Card8_Click(object sender, EventArgs e)
            {
                Card8.Image = Properties.Resources.Fish_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 8 3X3 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 8 3X3 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card8;
                    Card8.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card8;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card8.Image = Properties.Resources.Fish_Neon_Card;
                        Card8.Enabled = false;
                        //Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card9.Enabled = false;
                        //Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card8.Enabled = true;
                        Card_3X3_8_9_Fun();
                    }
                }
            }
            private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Fish_Neon_Card;
            Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 9 3X3 Level");
            Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_3X3_Type.Add("Card 9 3X3 Level");
            if (picturebox_1 == null)
            {
                picturebox_1 = Card9;
                Card9.Enabled = false;
            }
            else if (picturebox_1 != null && pictureBox_2 == null)
            {
                pictureBox_2 = Card9;
            }
            if (picturebox_1 != null && pictureBox_2 != null)
            {
                if (picturebox_1.Tag == pictureBox_2.Tag)
                {
                    Count++;
                    Succ_Click_Fun();
                    Color_Label();
                    Card9.Image = Properties.Resources.Fish_Neon_Card;
                    Card9.Enabled = false;
                    //Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Enabled = false;
                    //Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                }
                else
                {
                    Wrong_Click_Fun();
                    Color_Label();
                    Card9.Enabled = true;
                    Card_3X3_8_9_Fun();
                }
            }
        }
        #endregion
        #region Functions
            private void Succ_Click_Fun()
            {
                sound1.Play();
                Plus_Succ_Click_Label.Visible = true;
                Score_Plus_Label.Visible = true;
                Time_To_Show_Succ_Plus.Start();
                Score_Num += 50;
                Num_Of_Succ_Clicks++;
                Scores_Counter_Label_2.Text = Convert.ToString(Score_Num);
                Num_Of_Successful_Clicks_2.Text = Convert.ToString(Num_Of_Succ_Clicks);
                //Time_To_Show_Succ_Plus.Stop();
                //Plus_Succ_Click_Label.Visible = false;
                picturebox_1 = null;
                pictureBox_2 = null;
            }
            private void Wrong_Click_Fun()
            {
                //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
                //wmp.URL = @"C:\Users\AMCT\Desktop\important\Project Code\Sounds\WrongClick.Mp3";
                //wmp.controls.play();
                Score_Num -= 25;
                Wrong_Plus_Label.Visible = true;
                Mins_25_Label.Visible = true;
                Time_To_Show_Succ_Plus.Start();
                Num_Of_Wrong_Clicks++;
                Scores_Counter_Label_2.Text = Convert.ToString(Score_Num);
                Num_Of_Wrong_Clicks_2.Text = Convert.ToString(Num_Of_Wrong_Clicks);
                Wrong_Solution_Timer.Start();
            }
            public void OpenNewForm()
        {
            Application.Run(new Form6());
        }
            public void OpenNewForm2()
            {
                Application.Run(new Form2()); ;
            }
            public void Color_Label()
        {
            if (Score_Num < 0)
            {
                Scores_Counter_Label_2.ForeColor = Color.Red;
            }
            else if (Score_Num > 0)
            {
                Scores_Counter_Label_2.ForeColor = Color.Aqua;
            }
            else if (Score_Num == 0)
            {
                Scores_Counter_Label_2.ForeColor = Color.White;
            }
        }
        #region Level 3X3 Fun
        private void Card_3X3_1_2_Fun()
            {
                if (Convert.ToInt32(picturebox_1.Tag) == 2)
                {
                    if (Card3.Enabled == true || Card4.Enabled == true)
                    {
                        Card3.Enabled = true;
                        Card4.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 3)
                {
                    if (Card6.Enabled == true || Card7.Enabled == true)
                    {
                        Card6.Enabled = true;
                        Card7.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 4)
                {
                    if (Card8.Enabled == true || Card9.Enabled == true)
                    {
                        Card8.Enabled = true;
                        Card9.Enabled = true;
                    }
                }
            }
            private void Card_3X3_3_4_Fun()
            {
                if (Convert.ToInt32(picturebox_1.Tag) == 1)
                {
                    if (Card1.Enabled == true || Card2.Enabled == true)
                    {
                        Card1.Enabled = true;
                        Card2.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 3)
                {
                    if (Card6.Enabled == true || Card7.Enabled == true)
                    {
                        Card6.Enabled = true;
                        Card7.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 4)
                {
                    if (Card8.Enabled == true || Card9.Enabled == true)
                    {
                        Card8.Enabled = true;
                        Card9.Enabled = true;
                    }
                }
            }
            private void Card_3X3_6_7_Fun()
            {
                if (Convert.ToInt32(picturebox_1.Tag) == 1)
                {
                    if (Card1.Enabled == true || Card2.Enabled == true)
                    {
                        Card1.Enabled = true;
                        Card2.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 2)
                {
                    if (Card3.Enabled == true || Card4.Enabled == true)
                    {
                        Card3.Enabled = true;
                        Card4.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(picturebox_1.Tag) == 4)
                {
                    if (Card8.Enabled == true || Card9.Enabled == true)
                    {
                        Card8.Enabled = true;
                        Card9.Enabled = true;
                    }
                }
            }
            private void Card_3X3_8_9_Fun()
        {
            if (Convert.ToInt32(picturebox_1.Tag) == 1)
            {
                if (Card1.Enabled == true || Card2.Enabled == true)
                {
                    Card1.Enabled = true;
                    Card2.Enabled = true;
                }
            }
            else if (Convert.ToInt32(picturebox_1.Tag) == 2)
            {
                if (Card3.Enabled == true || Card4.Enabled == true)
                {
                    Card3.Enabled = true;
                    Card4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(picturebox_1.Tag) == 3)
            {
                if (Card6.Enabled == true || Card7.Enabled == true)
                {
                    Card6.Enabled = true;
                    Card7.Enabled = true;
                }
            }
        }
        #endregion
        #endregion
        #region Timers
            private void Start_Game_timer_Tick_1(object sender, EventArgs e)
            {
                int timer = Convert.ToInt32(The_Counter_To_Start.Text); //{
                timer = timer - 1;                              //incresing the timer or counting it.
                The_Counter_To_Start.Text = Convert.ToString(timer);    //}
            if (timer != 0)
            {
                sound2.Play();
            }
                if (timer == 0)
                {
                    Give_Up_Button.Visible = true;
                    The_Counter_To_Start.Visible = false;//hide the timer to start a game.
                    Start_Word.Visible = true;//show start word.
                    foreach (PictureBox picture in Cards_Holder.Controls)
                    {
                        picture.Enabled = true;
                        picture.Cursor = Cursors.Hand;
                        picture.Image = Properties.Resources.Neon_Question_Card;
                    }
                    picturebox_1 = null;
                    pictureBox_2 = null;
                    Start_Game_timer.Stop();
                    Duration.Start();
                }
            }
            private void Wrong_Solution_Timer_Tick_1(object sender, EventArgs e)
            {
                Wrong_Solution_Timer.Stop();
                picturebox_1.Image = Properties.Resources.Neon_Question_Card;
                pictureBox_2.Image = Properties.Resources.Neon_Question_Card;
                picturebox_1 = null;
                pictureBox_2 = null;
            }
            private void Time_To_Show_Succ_Plus_Tick_1(object sender, EventArgs e)
            {
                Plus_Succ_Click_Label.Visible = false;
                Score_Plus_Label.Visible = false;
                Wrong_Plus_Label.Visible = false;
                Mins_25_Label.Visible = false;
                Time_To_Show_Succ_Plus.Stop();
            }
            private void Duration_Tick_1(object sender, EventArgs e)
            {
            Duration_By_Second++;
            Duration_Label_2.Text = Convert.ToString(Duration_By_Second);

            //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
            //wmp.URL = @"C:\Users\AMCT\Desktop\important\Project Code\Sounds\TimerSound1.Mp3";
            //wmp.controls.play();
            if (Count == 4)
            {
                foreach (PictureBox picture in Cards_Holder.Controls)
                {
                    picture.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                }
                Count1++;
                Count = 0;
                Start_Word.Visible = false;
                Good_Job_Label.Visible = true;


                Form4.Duration_Sum += Duration_By_Second;
                Form4.Score_Sum += Score_Num;
                Form4.Level_Sum++;


                Form3.profile.Deuration = Convert.ToString(Form4.Duration_Sum);
                Form3.profile.Score = Convert.ToString(Form4.Score_Sum);
                Form3.profile.Level = Convert.ToString(Form4.Level_Sum);


                Points.Clear();
                Duration.Stop();
                //foreach (PictureBox picture in Cards_Holder.Controls)
                //{
                //    picture.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                //}
                New_Game_Button.Visible = true;
                Next_Button_Page_1.Visible = true;
            }
        }
        #endregion
        #region Buttons
            private void Cnacle_Button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
            private void Back_Button_Click(object sender, EventArgs e)
            {
                thread = new Thread(OpenNewForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
       
        #endregion

        private void Starting_Button_Click_1(object sender, EventArgs e)
        {
            Count1 = 0;
            foreach (PictureBox picture in Cards_Holder.Controls)
            {
                picture.Enabled = false;
                Points.Add(picture.Location);
            }

            foreach (PictureBox picture in Cards_Holder.Controls)
            {
                int next = location.Next(Points.Count);
                Point p = Points[next];
                picture.Location = p;
                Points_Play_Back.Add(p);
                Points.Remove(p);
            } //Location
              //timer1.Start();
            Start_Game_timer.Start();

            Card1.Image = Properties.Resources.Anqles_Neon_Card;
            Card2.Image = Properties.Resources.Anqles_Neon_Card;
            Card3.Image = Properties.Resources.Sadafah_Neon_Card;
            Card4.Image = Properties.Resources.Sadafah_Neon_Card;
            Card5.Image = Properties.Resources.X_Sign_Neon_Card;
            Card6.Image = Properties.Resources.JellyFish_Neon_Card;
            Card7.Image = Properties.Resources.JellyFish_Neon_Card;
            Card8.Image = Properties.Resources.Fish_Neon_Card;
            Card9.Image = Properties.Resources.Fish_Neon_Card;

            Start_Word.Visible = false;
            Score_Num = 0;
            Num_Of_Succ_Clicks = 0;
            Num_Of_Wrong_Clicks = 0;
            Duration_By_Second = 0;

            New_Game_Button.Visible = false;
            Next_Button_Page_1.Visible = false;
            Starting_Button.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Count = 0;
            if (Count1 == 0)
            {
                Form4.Duration_Sum += Duration_By_Second;
                Form4.Score_Sum += Score_Num;
                Form4.Level_Sum++;
            }

            Form3.profile.Deuration = Convert.ToString(Form4.Duration_Sum);
            Form3.profile.Score = Convert.ToString(Form4.Score_Sum);
            Form3.profile.Level = Convert.ToString(Form4.Level_Sum);

            Form4.Duration_Sum = 0;
            Form4.Score_Sum = 0;
            Form4.Level_Sum = 0;

            thread = new Thread(OpenNewForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Count1 = 0;
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void New_Game_Button_Click(object sender, EventArgs e)
        {
            Count1 = 0;
            The_Counter_To_Start.Visible = true;//hide the timer to start a game.
            The_Counter_To_Start.Text = Convert.ToString(5);
            Start_Word.Visible = false;
            Score_Num = 0;
            Num_Of_Succ_Clicks = 0;
            Num_Of_Wrong_Clicks = 0;
            Duration_By_Second = 0;
            Scores_Counter_Label_2.Text = Convert.ToString(Score_Num);
            Num_Of_Wrong_Clicks_2.Text = Convert.ToString(Num_Of_Wrong_Clicks);
            Num_Of_Successful_Clicks_2.Text = Convert.ToString(Num_Of_Succ_Clicks);
            Duration_Label_2.Text = Convert.ToString(Duration_By_Second);
            Start_Game_timer.Start();
            Duration.Stop();
            New_Game_Button.Visible = false;
            Next_Button_Page_1.Visible = false;

            foreach (PictureBox picture in Cards_Holder.Controls)
            {
                picture.Enabled = false;
                Points.Add(picture.Location);
            }

            foreach (PictureBox picture in Cards_Holder.Controls)
            {
                int next = location.Next(Points.Count);
                Point p = Points[next];
                picture.Location = p;
                Points.Remove(p);
            }
            Card1.Image = Properties.Resources.Anqles_Neon_Card;
            Card2.Image = Properties.Resources.Anqles_Neon_Card;
            Card3.Image = Properties.Resources.Sadafah_Neon_Card;
            Card4.Image = Properties.Resources.Sadafah_Neon_Card;
            Card5.Image = Properties.Resources.X_Sign_Neon_Card;
            Card6.Image = Properties.Resources.JellyFish_Neon_Card;
            Card7.Image = Properties.Resources.JellyFish_Neon_Card;
            Card8.Image = Properties.Resources.Fish_Neon_Card;
            Card9.Image = Properties.Resources.Fish_Neon_Card;
        }
    }
}
