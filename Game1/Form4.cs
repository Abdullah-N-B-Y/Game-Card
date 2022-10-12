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
    public partial class Form4 : Form
    {
        #region Attributes
            Thread thread;
            private PictureBox picturebox_1;
            private PictureBox pictureBox_2;
            private int Score_Num = 0;
            private int Num_Of_Succ_Clicks;
            private int Num_Of_Wrong_Clicks;
            private int Duration_By_Second;
            private Random location = new Random();
            private List<Point> Points = new List<Point>();
            public static List<Point> Points_Play_Back = new List<Point>();
            public static int Duration_Sum = 0;
            public static int Score_Sum = 0;
            public static int Level_Sum = 0;
            private static int Count = 0;
            public static string Name1 = "";
            SoundPlayer sound1,sound2;
            int Count1 = 0;
        #endregion
        public Form4()
        {
            InitializeComponent();
            sound1 = new SoundPlayer(@"C2.wav");
            sound2 = new SoundPlayer(@"TimerSound1.wav");

        }

        #region Buttons       
            private void Cnacle_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void New_Game_Button_Click_2(object sender, EventArgs e)
            {
                Count = 0;
                Good_Job_Label.Visible = false;
                The_Counter_To_Start.Visible = true;//hide the timer to start a game.
                The_Counter_To_Start.Text = Convert.ToString(5);
                //Start_Word.Visible = false;
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
                Card1_2X2.Image = Properties.Resources.card11;
                Card2_2X2.Image = Properties.Resources.card11;
                Card3_2X2.Image = Properties.Resources.card22;
                Card4_2X2.Image = Properties.Resources.card22;
            }
            private void Next_Button_Page_1_Click_1(object sender, EventArgs e)
            {
                Count1 = 0;
                thread = new Thread(OpenNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            private void Give_Up_Button_Click(object sender, EventArgs e)
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
        #endregion
        #region Card2X2
            private void Form4_Load(object sender, EventArgs e)
            {
                if (Form3.profile.BackgroundColor.Equals("Blue"))
                {
                    this.BackColor = Color.Blue;
                    //this.Cards_Holder.BackgroundImage = Properties.Resources.color1;
                    //this.Scores_Label_1.BackColor = Color.Black;
                    //this.Card1_2X2.BackgroundImage = Properties.Resources.color2;
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
            private void Card1_2X2_Click(object sender, EventArgs e)
            {
                Card1_2X2.Image = Properties.Resources.card11;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 1 2X2 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_2X2_Type.Add("Card 1 2X2 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card1_2X2;
                    Card1_2X2.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card1_2X2;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        Card1_2X2.Image = Properties.Resources.card11;
                        Card1_2X2.Enabled = false;
                        
                    }
                    else
                    {

                        Wrong_Click_Fun();
                        Color_Label();
                        Card1_2X2.Enabled = true;
                        Card_2X2_1_2_Fun();
                    }
                }
            }
            private void Card2_2X2_Click(object sender, EventArgs e)
            {
                Card2_2X2.Image = Properties.Resources.card11;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 2 2X2 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_2X2_Type.Add("Card 2 2X2 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card2_2X2;
                    Card2_2X2.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card2_2X2;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label();
                        //picturebox_1 = null;
                        //pictureBox_2 = null;
                        Card2_2X2.Image = Properties.Resources.card11;
                        Card2_2X2.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card2_2X2.Enabled = true;
                        Card_2X2_1_2_Fun();
                    }
                }
            }
            private void Card3_2X2_Click(object sender, EventArgs e)
            {
                Card3_2X2.Image = Properties.Resources.card22;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 3 2X2 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_2X2_Type.Add("Card 3 2X2 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card3_2X2;
                    Card3_2X2.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card3_2X2;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
                {
                    if (picturebox_1.Tag == pictureBox_2.Tag)
                    {
                        Count++;
                        Succ_Click_Fun();
                        Color_Label(); 
                        //Card3_2X2.Image = Properties.Resources.JellyFish_Neon_Card;
                        Card3_2X2.Enabled = false;
                    }

                    else
                    {
                        Wrong_Click_Fun();
                        Color_Label();
                        Card3_2X2.Enabled = true;
                        Card_2X2_3_4_Fun();
                    }


                }
            }
            private void Card4_2X2_Click(object sender, EventArgs e)
            {
                Card4_2X2.Image = Properties.Resources.card22;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 4 2X2 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_2X2_Type.Add("Card 4 2X2 Level");
                if (picturebox_1 == null)
                {
                    picturebox_1 = Card4_2X2;
                    Card4_2X2.Enabled = false;
                }
                else if (picturebox_1 != null && pictureBox_2 == null)
                {
                    pictureBox_2 = Card4_2X2;
                }
                if (picturebox_1 != null && pictureBox_2 != null)
            {
                if (picturebox_1.Tag == pictureBox_2.Tag)
                {
                    Count++;
                    Succ_Click_Fun();
                    Color_Label();
                   
                    //Card4_2X2.Image = Properties.Resources.JellyFish_Neon_Card;
                    Card4_2X2.Enabled = false;

                }
                else
                {
                    Wrong_Click_Fun();
                    Color_Label();
                    Card4_2X2.Enabled = true;
                    Card_2X2_3_4_Fun();
                }

            }
            }
        #endregion
        #region Function 
            private void Succ_Click_Fun()
            {
                //Showing_Cards_Correct_Timer.Start();
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
                Mins_25_Label.Visible = true;
                Wrong_Plus_Label.Visible = true;
                Time_To_Show_Succ_Plus.Start();
                Num_Of_Wrong_Clicks++;
                Scores_Counter_Label_2.Text = Convert.ToString(Score_Num);
                Num_Of_Wrong_Clicks_2.Text = Convert.ToString(Num_Of_Wrong_Clicks);
                Wrong_Solution_Timer.Start();
            }
            private void Card_2X2_1_2_Fun()
            {

                if (Convert.ToInt32(picturebox_1.Tag) == 2)
                {
                    if (Card3_2X2.Enabled == true || Card4_2X2.Enabled == true)
                    {
                        Card3_2X2.Enabled = true;
                        Card4_2X2.Enabled = true;
                    }
                }

            }
            private void Card_2X2_3_4_Fun()
            {

                if (Convert.ToInt32(picturebox_1.Tag) == 1)
                {
                    if (Card1_2X2.Enabled == true || Card2_2X2.Enabled == true)
                    {
                        Card1_2X2.Enabled = true;
                        Card2_2X2.Enabled = true;
                    }
                }


            }
            public void OpenNewForm()
            {
                Application.Run(new Form5());
            }
            public void OpenNewForm2()
        {
            Application.Run(new Form2());
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
        #endregion
        #region Timers
            private void Duration_Tick(object sender, EventArgs e)
            {
                Duration_By_Second++;
                Duration_Label_2.Text = Convert.ToString(Duration_By_Second);

                //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
                //wmp.URL = @"C:\Users\AMCT\Desktop\important\Project Code\Sounds\TimerSound1.Mp3";
                //wmp.controls.play();
                if (Count == 2)
                {
                foreach (PictureBox picture in Cards_Holder.Controls)
                {
                    picture.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                }
                    Count1++;
                    Count = 0;
                    Start_Word.Visible = false;
                    Good_Job_Label.Visible = true;

                    Duration_Sum += Duration_By_Second;
                    Score_Sum += Score_Num;
                    Level_Sum++;

                    Form3.profile.Deuration = Convert.ToString(Duration_Sum);
                    Form3.profile.Score = Convert.ToString(Score_Sum);
                    Form3.profile.Level = Convert.ToString(Level_Sum);


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
            private void Start_Game_timer_Tick(object sender, EventArgs e)
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
                sound2.Stop();
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
            private void Wrong_Solution_Timer_Tick(object sender, EventArgs e)
            {
                Wrong_Solution_Timer.Stop();
                picturebox_1.Image = Properties.Resources.Neon_Question_Card;
                pictureBox_2.Image = Properties.Resources.Neon_Question_Card;
                picturebox_1 = null;
                pictureBox_2 = null;
            }
            private void Time_To_Show_Succ_Plus_Tick(object sender, EventArgs e)
            {
                Plus_Succ_Click_Label.Visible = false;
                Score_Plus_Label.Visible = false;
                Wrong_Plus_Label.Visible = false;
                Mins_25_Label.Visible = false;
                Time_To_Show_Succ_Plus.Stop();
            }
        #endregion

        private void Showing_Cards_Correct_Timer_Tick(object sender, EventArgs e)
        {
            picturebox_1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
            pictureBox_2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
            Showing_Cards_Correct_Timer.Stop();
            picturebox_1 = null;
            pictureBox_2 = null;
        }

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
            }

            Start_Game_timer.Start();

            Card1_2X2.Image = Properties.Resources.card11;
            Card2_2X2.Image = Properties.Resources.card11;
            Card3_2X2.Image = Properties.Resources.card22;
            Card4_2X2.Image = Properties.Resources.card22;


            Start_Word.Visible = false;
            Good_Job_Label.Visible = false;
            Score_Num = 0;
            Num_Of_Succ_Clicks = 0;
            Num_Of_Wrong_Clicks = 0;
            Duration_By_Second = 0;

            New_Game_Button.Visible = false;
            Next_Button_Page_1.Visible = false;
            Starting_Button.Visible = false;
        }
    }
}
