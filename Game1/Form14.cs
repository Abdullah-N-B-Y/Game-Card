using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form14 : Form
    {
        #region Attributes
            Thread thread;
            static int Count = 0, Count1 = 0,Count2 = 0;
        public static string UserName;
        PictureBox pictureBox1, pictureBox2;
        #endregion
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        #region Buttons
            private void Cnacle_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void Play_Button_Click(object sender, EventArgs e)
            {
                if (Count2 == 0)
                {
                    Play_Button.Enabled = false;
                    label2.Visible = false;
                    foreach (PictureBox picture in Cards_Holder.Controls)
                    {
                        picture.Location = Form5.Points_Play_Back[Count1];
                        Count1++;
                    }

                    Count2++;
                    Card1.Image = Properties.Resources.Neon_Question_Card;
                    Card2.Image = Properties.Resources.Neon_Question_Card;
                    Card3.Image = Properties.Resources.Neon_Question_Card;
                    Card4.Image = Properties.Resources.Neon_Question_Card;
                    Card5.Image = Properties.Resources.Neon_Question_Card;
                    Card6.Image = Properties.Resources.Neon_Question_Card;
                    Card7.Image = Properties.Resources.Neon_Question_Card;
                    Card8.Image = Properties.Resources.Neon_Question_Card;
                    Card9.Image = Properties.Resources.Neon_Question_Card;

                    Count = 0;
                    Showing_Level1.Start();
                }
                else
                {
                    label2.Visible = true;
                }
            }

            private void Next_Button_Click_1(object sender, EventArgs e)
            {
                thread = new Thread(OpenNewForm11);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }

            private void Back_Button_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm8);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        #endregion
        #region Timers
        private void Showing_Level1_Tick_1(object sender, EventArgs e)
            {
                if (Form8.Count == 1)
                {
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 1 3X3 Level"))
                    {
                        Card1.Image = Properties.Resources.Anqles_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card1;
                        }
                        else
                        {
                            pictureBox2 = Card1;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 2 3X3 Level"))
                    {
                        Card2.Image = Properties.Resources.Anqles_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card2;
                        }
                        else
                        {
                            pictureBox2 = Card2;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 3 3X3 Level"))
                    {
                        Card3.Image = Properties.Resources.Sadafah_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card3;
                        }
                        else
                        {
                            pictureBox2 = Card3;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 4 3X3 Level"))
                    {
                        Card4.Image = Properties.Resources.Sadafah_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card4;
                        }
                        else
                        {
                            pictureBox2 = Card4;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 5 3X3 Level"))
                    {
                        Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card5;
                        }
                        else
                        {
                            pictureBox2 = Card5;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 6 3X3 Level"))
                    {
                        Card6.Image = Properties.Resources.JellyFish_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card6;
                        }
                        else
                        {
                            pictureBox2 = Card6;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 7 3X3 Level"))
                    {
                        Card7.Image = Properties.Resources.JellyFish_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card7;
                        }
                        else
                        {
                            pictureBox2 = Card7;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 8 3X3 Level"))
                    {
                        Card8.Image = Properties.Resources.Fish_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card8;
                        }
                        else
                        {
                            pictureBox2 = Card8;
                        }
                    }
                    if (Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type[Count].Equals("Card 9 3X3 Level"))
                    {
                        Card9.Image = Properties.Resources.Fish_Neon_Card;
                        if (pictureBox1 == null)
                        {
                            pictureBox1 = Card9;
                        }
                        else
                        {
                            pictureBox2 = Card9;
                        }
                    }

                    Count++;
                    if (pictureBox1 != null && pictureBox2 != null)
                    {
                        if (pictureBox1.Tag == pictureBox2.Tag)
                        {
                            pictureBox1 = null;
                            pictureBox2 = null;
                        }
                        else
                        {
                            Wrong.Start();
                        }
                    }
                    if (Count == Form3.Profile_Ahmad_Obj_List[0].Cards_3X3_Type.Count)
                    {
                        pictureBox1 = null;
                        pictureBox2 = null;
                        Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                        Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                        Count = 0;
                        Showing_Level1.Stop();
                    }
                }
                else if (Form8.Count == 2)
            {
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 1 3X3 Level"))
                {
                    Card1.Image = Properties.Resources.Anqles_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1;
                    }
                    else
                    {
                        pictureBox2 = Card1;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 2 3X3 Level"))
                {
                    Card2.Image = Properties.Resources.Anqles_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2;
                    }
                    else
                    {
                        pictureBox2 = Card2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 3 3X3 Level"))
                {
                    Card3.Image = Properties.Resources.Sadafah_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3;
                    }
                    else
                    {
                        pictureBox2 = Card3;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 4 3X3 Level"))
                {
                    Card4.Image = Properties.Resources.Sadafah_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4;
                    }
                    else
                    {
                        pictureBox2 = Card4;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 5 3X3 Level"))
                {
                    Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card5;
                    }
                    else
                    {
                        pictureBox2 = Card5;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 6 3X3 Level"))
                {
                    Card6.Image = Properties.Resources.JellyFish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card6;
                    }
                    else
                    {
                        pictureBox2 = Card6;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 7 3X3 Level"))
                {
                    Card7.Image = Properties.Resources.JellyFish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card7;
                    }
                    else
                    {
                        pictureBox2 = Card7;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 8 3X3 Level"))
                {
                    Card8.Image = Properties.Resources.Fish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card8;
                    }
                    else
                    {
                        pictureBox2 = Card8;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type[Count].Equals("Card 9 3X3 Level"))
                {
                    Card9.Image = Properties.Resources.Fish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card9;
                    }
                    else
                    {
                        pictureBox2 = Card9;
                    }
                }

                Count++;
                if (pictureBox1 != null && pictureBox2 != null)
                {
                    if (pictureBox1.Tag == pictureBox2.Tag)
                    {
                        pictureBox1 = null;
                        pictureBox2 = null;
                    }
                    else
                    {
                        Wrong.Start();
                    }
                }
                if (Count == Form3.Profile_Ahmad_Obj_List[1].Cards_3X3_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                    Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
                else if (Form8.Count == 3)
            {
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 1 3X3 Level"))
                {
                    Card1.Image = Properties.Resources.Anqles_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1;
                    }
                    else
                    {
                        pictureBox2 = Card1;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 2 3X3 Level"))
                {
                    Card2.Image = Properties.Resources.Anqles_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2;
                    }
                    else
                    {
                        pictureBox2 = Card2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 3 3X3 Level"))
                {
                    Card3.Image = Properties.Resources.Sadafah_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3;
                    }
                    else
                    {
                        pictureBox2 = Card3;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 4 3X3 Level"))
                {
                    Card4.Image = Properties.Resources.Sadafah_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4;
                    }
                    else
                    {
                        pictureBox2 = Card4;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 5 3X3 Level"))
                {
                    Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card5;
                    }
                    else
                    {
                        pictureBox2 = Card5;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 6 3X3 Level"))
                {
                    Card6.Image = Properties.Resources.JellyFish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card6;
                    }
                    else
                    {
                        pictureBox2 = Card6;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 7 3X3 Level"))
                {
                    Card7.Image = Properties.Resources.JellyFish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card7;
                    }
                    else
                    {
                        pictureBox2 = Card7;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 8 3X3 Level"))
                {
                    Card8.Image = Properties.Resources.Fish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card8;
                    }
                    else
                    {
                        pictureBox2 = Card8;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type[Count].Equals("Card 9 3X3 Level"))
                {
                    Card9.Image = Properties.Resources.Fish_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card9;
                    }
                    else
                    {
                        pictureBox2 = Card9;
                    }
                }

                Count++;
                if (pictureBox1 != null && pictureBox2 != null)
                {
                    if (pictureBox1.Tag == pictureBox2.Tag)
                    {
                        pictureBox1 = null;
                        pictureBox2 = null;
                    }
                    else
                    {
                        Wrong.Start();
                    }
                }
                if (Count == Form3.Profile_Ahmad_Obj_List[2].Cards_3X3_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card5.Image = Properties.Resources.X_Sign_Neon_Card;
                    Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
            }

        private void Wrong_Tick(object sender, EventArgs e)
        {
            Wrong.Stop();
            pictureBox1.Image = Properties.Resources.Neon_Question_Card;
            pictureBox2.Image = Properties.Resources.Neon_Question_Card;
            pictureBox1 = null;
            pictureBox2 = null;
        }

        
        #endregion

        #region Functions
        public void OpenNewForm8()
            {
                Application.Run(new Form8());
            }
        #endregion

        private void Form14_Load_1(object sender, EventArgs e)
        {
            Count1 = 0;
            Count2 = 0;
            Name1.Text = UserName;
            if (Form6.Points_Play_Back.Count == 0)
            {
                Next_Button.Enabled = false;
            }
            else
            {
                Next_Button.Enabled = true;
            }
        }

        public void OpenNewForm11()
        {
            Application.Run(new Form11());
        }
    }
}
