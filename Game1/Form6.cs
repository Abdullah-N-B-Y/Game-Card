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
    public partial class Form6 : Form
    {
        #region Attributes
            Thread thread;
            //private PictureBox picturebox_1;
            //private PictureBox pictureBox_2;
            private PictureBox pictureBox_3;
            private PictureBox pictureBox_4;
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
        public Form6()
        {
            InitializeComponent();
            sound1 = new SoundPlayer(@"C2.wav");
            sound2 = new SoundPlayer(@"TimerSound1.wav");
        }

        #region Cards 4X4
        private void Form6_Load(object sender, EventArgs e)
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
            private void Card1_4X4_Click(object sender, EventArgs e)
            {
                Card1_4X4.Image = Properties.Resources.Earth_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 1 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 1 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card1_4X4;
                    Card1_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card1_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card1_4X4.Image = Properties.Resources.Earth_Neon_Card;
                        Card1_4X4.Enabled = false;
                        Card2_4X4.Enabled = false;
                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card1_4X4.Enabled = true;
                        Card_4X4_1_2_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card2_4X4_Click(object sender, EventArgs e)
            {
                Card2_4X4.Image = Properties.Resources.Earth_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 2 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 2 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card2_4X4;
                    Card2_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card2_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card2_4X4.Image = Properties.Resources.Earth_Neon_Card;
                        Card2_4X4.Enabled = false;
                        Card1_4X4.Enabled = false;
                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card2_4X4.Enabled = true;
                        Card_4X4_1_2_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card3_4X4_Click(object sender, EventArgs e)
            {
                Card3_4X4.Image = Properties.Resources.Sun_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 3 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 3 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card3_4X4;
                    Card3_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card3_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card3_4X4.Image = Properties.Resources.Sun_Neon_Card;
                        Card3_4X4.Enabled = false;
                        Card4_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card3_4X4.Enabled = true;
                        Card_4X4_3_4_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card4_4X4_Click(object sender, EventArgs e)
            {
                Card4_4X4.Image = Properties.Resources.Sun_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 4 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 4 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card4_4X4;
                    Card4_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card4_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card4_4X4.Image = Properties.Resources.Sun_Neon_Card;
                        Card4_4X4.Enabled = false;
                        Card3_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card4_4X4.Enabled = true;
                        Card_4X4_3_4_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card5_4X4_Click(object sender, EventArgs e)

            {
                Card5_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 5 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 5 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card5_4X4;
                    Card5_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card5_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card5_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                        Card5_4X4.Enabled = false;
                        Card6_4X4.Enabled = false;
                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card5_4X4.Enabled = true;
                        Card_4X4_5_6_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card6_4X4_Click(object sender, EventArgs e)
            {
                Card6_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 6 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 6 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card6_4X4;
                    Card6_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card6_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card6_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                        Card6_4X4.Enabled = false;
                        Card5_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card6_4X4.Enabled = true;
                        Card_4X4_5_6_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card7_4X4_Click(object sender, EventArgs e)
            {
                Card7_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 7 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 7 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card7_4X4;
                    Card7_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card7_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card7_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                        Card7_4X4.Enabled = false;
                        Card8_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card7_4X4.Enabled = true;
                        Card_4X4_7_8_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card8_4X4_Click(object sender, EventArgs e)
            {
                Card8_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 8 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 8 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card8_4X4;
                    Card8_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card8_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card8_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                        Card8_4X4.Enabled = false;
                        Card7_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card8_4X4.Enabled = true;
                        Card_4X4_7_8_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card9_4X4_Click(object sender, EventArgs e)
            {
                Card9_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 9 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 9 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card9_4X4;
                    Card9_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card9_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card9_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                        Card9_4X4.Enabled = false;
                        Card10_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card9_4X4.Enabled = true;
                        Card_4X4_9_10_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card10_4X4_Click(object sender, EventArgs e)
            {
                Card10_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 10 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 10 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card10_4X4;
                    Card10_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card10_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card10_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                        Card10_4X4.Enabled = false;
                        Card9_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card10_4X4.Enabled = true;
                        Card_4X4_9_10_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card11_4X4_Click(object sender, EventArgs e)
            {
                Card11_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 11 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 11 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card11_4X4;
                    Card11_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card11_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card11_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                        Card11_4X4.Enabled = false;
                        Card12_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card11_4X4.Enabled = true;
                        Card_4X4_11_12_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card12_4X4_Click(object sender, EventArgs e)
            {
                Card12_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 12 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 12 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card12_4X4;
                    Card12_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card12_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card12_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                        Card12_4X4.Enabled = false;
                        Card11_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card12_4X4.Enabled = true;
                        Card_4X4_11_12_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card13_4X4_Click(object sender, EventArgs e)
            {
                Card13_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 13 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 13 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card13_4X4;
                    Card13_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card13_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card13_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                        Card13_4X4.Enabled = false;
                        Card14_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card13_4X4.Enabled = true;
                        Card_4X4_13_14_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card14_4X4_Click(object sender, EventArgs e)
            {
                Card14_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 14 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 14 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card14_4X4;
                    Card14_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card14_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card14_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                        Card14_4X4.Enabled = false;
                        Card13_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card14_4X4.Enabled = true;
                        Card_4X4_13_14_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card15_4X4_Click(object sender, EventArgs e)
            {
                Card15_4X4.Image = Properties.Resources.Plant5_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 15 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 15 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card15_4X4;
                    Card15_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card15_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card15_4X4.Image = Properties.Resources.Plant5_Neon_Card;
                        Card15_4X4.Enabled = false;
                        Card16_4X4.Enabled = false;

                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card15_4X4.Enabled = true;
                        Card_4X4_15_16_Fun();
                        Color_Label();
                    }
                }
            }
            private void Card16_4X4_Click(object sender, EventArgs e)
            {
                Card16_4X4.Image = Properties.Resources.Plant5_Neon_Card;
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Names.Add("Card 16 4X4 Level");
                Form3.Profile_Ahmad_Obj_List[Form3.ObjCount].Cards_4X4_Type.Add("Card 16 4X4 Level");
                if (pictureBox_3 == null)
                {
                    pictureBox_3 = Card16_4X4;
                    Card16_4X4.Enabled = false;
                }
                else if (pictureBox_3 != null && pictureBox_4 == null)
                {
                    pictureBox_4 = Card16_4X4;
                }
                if (pictureBox_3 != null && pictureBox_4 != null)
                {
                    if (pictureBox_3.Tag == pictureBox_4.Tag)
                    {
                        Succ_Click_Fun();

                        Color_Label();
                        Count++;

                        Card16_4X4.Image = Properties.Resources.Plant5_Neon_Card;
                        Card16_4X4.Enabled = false;
                        Card15_4X4.Enabled = false;
                    }
                    else
                    {
                        Wrong_Click_4X4_Level_Fun();
                        Card16_4X4.Enabled = true;
                        Card_4X4_15_16_Fun();
                        Color_Label();
                    }
                }
            }
        #endregion
        #region Timers
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
                    Give_Up_Button.Visible = true;

                    The_Counter_To_Start.Visible = false;//hide the timer to start a game.
                    Start_Word.Visible = true;//show start word.
                    foreach (PictureBox picture in Cards_Holder.Controls)
                    {
                        picture.Enabled = true;
                        picture.Cursor = Cursors.Hand;
                        picture.Image = Properties.Resources.Neon_Question_Card;
                    }
                    pictureBox_3 = null;
                    pictureBox_4 = null;
                    Start_Game_timer.Stop();
                    Duration.Start();
                }
            }
            private void Duration_Tick(object sender, EventArgs e)
            {
                Duration_By_Second++;
                Duration_Label_2.Text = Convert.ToString(Duration_By_Second);

                //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
                //wmp.URL = @"C:\Users\AMCT\Desktop\important\Project Code\Sounds\TimerSound1.Mp3";
                //wmp.controls.play();
                if (Count == 8)
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
            private void Time_To_Show_Succ_Plus_Tick(object sender, EventArgs e)
            {
                Plus_Succ_Click_Label.Visible = false;
                Score_Plus_Label.Visible = false;
                Wrong_Plus_Label.Visible = false;
                Mins_25_Label.Visible = false;
                Time_To_Show_Succ_Plus.Stop();
            }
            private void Wrong_Click_Timer_2_Tick(object sender, EventArgs e)
        {
            Wrong_Click_Timer_2.Stop();
            pictureBox_3.Image = Properties.Resources.Neon_Question_Card;
            pictureBox_4.Image = Properties.Resources.Neon_Question_Card;
            pictureBox_3 = null;
            pictureBox_4 = null;
        }
        #endregion
        #region Buttons
            private void Cnacle_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void Starting_Button_Click_1(object sender, EventArgs e)
            {
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

                Card1_4X4.Image = Properties.Resources.Earth_Neon_Card;
                Card2_4X4.Image = Properties.Resources.Earth_Neon_Card;
                Card3_4X4.Image = Properties.Resources.Sun_Neon_Card;
                Card4_4X4.Image = Properties.Resources.Sun_Neon_Card;
                Card5_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                Card6_4X4.Image = Properties.Resources.Plant10_Neon_Card;
                Card7_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                Card8_4X4.Image = Properties.Resources.Plant9_Neon_Card;
                Card9_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                Card10_4X4.Image = Properties.Resources.Plant8_Neon_Card;
                Card11_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                Card12_4X4.Image = Properties.Resources.Plant7_Neon_Card;
                Card13_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                Card14_4X4.Image = Properties.Resources.Plant6_Neon_Card;
                Card15_4X4.Image = Properties.Resources.Plant5_Neon_Card;
                Card16_4X4.Image = Properties.Resources.Plant5_Neon_Card;


                Good_Job_Label.Visible = false;

                Start_Word.Visible = false;
                Score_Num = 0;
                Num_Of_Succ_Clicks = 0;
                Num_Of_Wrong_Clicks = 0;
                Duration_By_Second = 0;

                New_Game_Button.Visible = false;
                Next_Button_Page_1.Visible = false;
                Starting_Button.Visible = false;
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
            private void Next_Button_Page_1_Click_1(object sender, EventArgs e)
            {
                Count1 = 0;
                thread = new Thread(OpenNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            private void New_Game_Button_Click_1(object sender, EventArgs e)
        {
            Count1 = 0;
            Count = 0;
            Good_Job_Label.Visible = false;

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
            Card1_4X4.Image = Properties.Resources.Earth_Neon_Card;
            Card2_4X4.Image = Properties.Resources.Earth_Neon_Card;
            Card3_4X4.Image = Properties.Resources.Sun_Neon_Card;
            Card4_4X4.Image = Properties.Resources.Sun_Neon_Card;
            Card5_4X4.Image = Properties.Resources.Plant10_Neon_Card;
            Card6_4X4.Image = Properties.Resources.Plant10_Neon_Card;
            Card7_4X4.Image = Properties.Resources.Plant9_Neon_Card;
            Card8_4X4.Image = Properties.Resources.Plant9_Neon_Card;
            Card9_4X4.Image = Properties.Resources.Plant8_Neon_Card;
            Card10_4X4.Image = Properties.Resources.Plant8_Neon_Card;
            Card11_4X4.Image = Properties.Resources.Plant7_Neon_Card;
            Card12_4X4.Image = Properties.Resources.Plant7_Neon_Card;
            Card13_4X4.Image = Properties.Resources.Plant6_Neon_Card;
            Card14_4X4.Image = Properties.Resources.Plant6_Neon_Card;
            Card15_4X4.Image = Properties.Resources.Plant5_Neon_Card;
            Card16_4X4.Image = Properties.Resources.Plant5_Neon_Card;
        }
        #endregion
        #region Functions
        public void Succ_Click_Fun()
            {
                sound1.Play();
                Plus_Succ_Click_Label.Visible = true;
                Score_Plus_Label.Visible = true;
                Time_To_Show_Succ_Plus.Start();
                Score_Num += 50;
                Num_Of_Succ_Clicks++;
                Scores_Counter_Label_2.Text = Convert.ToString(Score_Num);
                Num_Of_Successful_Clicks_2.Text = Convert.ToString(Num_Of_Succ_Clicks);
                Plus_Succ_Click_Label.Visible = false;

                pictureBox_3 = null;
                pictureBox_4 = null;
            }
            public void Wrong_Click_4X4_Level_Fun()
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
                Wrong_Click_Timer_2.Start();

            }
            public void OpenNewForm()
            {
                Application.Run(new Form7());
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
        #region Level 4X4 Fun
        public void Card_4X4_1_2_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_3_4_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_5_6_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_7_8_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_9_10_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_11_12_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_13_14_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 8)
            {
                if (Card15_4X4.Enabled == true || Card16_4X4.Enabled == true)
                {
                    Card15_4X4.Enabled = true;
                    Card16_4X4.Enabled = true;
                }
            }
        }
        public void Card_4X4_15_16_Fun()
        {
            if (Convert.ToInt32(pictureBox_3.Tag) == 1)
            {
                if (Card1_4X4.Enabled == true || Card2_4X4.Enabled == true)
                {
                    Card1_4X4.Enabled = true;
                    Card2_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            if (Convert.ToInt32(pictureBox_3.Tag) == 2)
            {
                if (Card3_4X4.Enabled == true || Card4_4X4.Enabled == true)
                {
                    Card3_4X4.Enabled = true;
                    Card4_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 3)
            {
                if (Card5_4X4.Enabled == true || Card6_4X4.Enabled == true)
                {
                    Card5_4X4.Enabled = true;
                    Card6_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 4)
            {
                if (Card7_4X4.Enabled == true || Card8_4X4.Enabled == true)
                {
                    Card7_4X4.Enabled = true;
                    Card8_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 5)
            {
                if (Card9_4X4.Enabled == true || Card10_4X4.Enabled == true)
                {
                    Card9_4X4.Enabled = true;
                    Card10_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 6)
            {
                if (Card11_4X4.Enabled == true || Card12_4X4.Enabled == true)
                {
                    Card11_4X4.Enabled = true;
                    Card12_4X4.Enabled = true;
                }
            }
            else if (Convert.ToInt32(pictureBox_3.Tag) == 7)
            {
                if (Card13_4X4.Enabled == true || Card14_4X4.Enabled == true)
                {
                    Card13_4X4.Enabled = true;
                    Card14_4X4.Enabled = true;
                }
            }

        }

        #endregion

        #endregion

        
    }
}
