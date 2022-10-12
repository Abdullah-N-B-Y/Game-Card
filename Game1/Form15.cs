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
    public partial class Form15 : Form
    {
        #region Attributes
            Thread thread;
            static int Count = 0, Count1 = 0, Count2 = 0;
            public static string UserName;
        PictureBox pictureBox1, pictureBox2;
        #endregion
        public Form15()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            
        }
        private void Cnacle_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            Count1 = 0;
            Count2 = 0;
            Name1.Text = UserName;
        }

        private void Back_Button_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm8);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void Play_Button_Click_1(object sender, EventArgs e)
        {
            if (Count2 == 0)
            {
                Play_Button.Enabled = false;
                label2.Visible = false;
                foreach (PictureBox picture in Cards_Holder.Controls)
                {
                    picture.Location = Form7.Points_Play_Back[Count1];
                    Count1++;
                }

                Card1.Image = Properties.Resources.Neon_Question_Card;
                Card2.Image = Properties.Resources.Neon_Question_Card;
                Card3.Image = Properties.Resources.Neon_Question_Card;
                Card4.Image = Properties.Resources.Neon_Question_Card;
                Card5.Image = Properties.Resources.Neon_Question_Card;
                Card6.Image = Properties.Resources.Neon_Question_Card;
                Card7.Image = Properties.Resources.Neon_Question_Card;
                Card8.Image = Properties.Resources.Neon_Question_Card;
                Card9.Image = Properties.Resources.Neon_Question_Card;
                Card10.Image = Properties.Resources.Neon_Question_Card;
                Card11.Image = Properties.Resources.Neon_Question_Card;
                Card12.Image = Properties.Resources.Neon_Question_Card;
                Card13.Image = Properties.Resources.Neon_Question_Card;
                Card14.Image = Properties.Resources.Neon_Question_Card;
                Card15.Image = Properties.Resources.Neon_Question_Card;
                Card16.Image = Properties.Resources.Neon_Question_Card;
                Card17.Image = Properties.Resources.Neon_Question_Card;
                Card18.Image = Properties.Resources.Neon_Question_Card;
                Card19.Image = Properties.Resources.Neon_Question_Card;
                Card20.Image = Properties.Resources.Neon_Question_Card;
                Card21.Image = Properties.Resources.Neon_Question_Card;
                Card22.Image = Properties.Resources.Neon_Question_Card;
                Card23.Image = Properties.Resources.Neon_Question_Card;
                Card24.Image = Properties.Resources.Neon_Question_Card;
                Card25.Image = Properties.Resources.Neon_Question_Card;

                Count2++;
                Count = 0;
                Showing_Level1.Start();
            }
            else
            {
                label2.Visible = true;
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
        public void OpenNewForm8()
        {
            Application.Run(new Form8());
        }

        private void Showing_Level1_Tick(object sender, EventArgs e)
        {
            if (Form8.Count == 1)
            {
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 1 5X5 Level"))
                {
                    Card1.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1;
                    }
                    else
                    {
                        pictureBox2 = Card1;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 2 5X5 Level"))
                {
                    Card2.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2;
                    }
                    else
                    {
                        pictureBox2 = Card2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 3 5X5 Level"))
                {
                    Card3.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3;
                    }
                    else
                    {
                        pictureBox2 = Card3;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 4 5X5 Level"))
                {
                    Card4.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4;
                    }
                    else
                    {
                        pictureBox2 = Card4;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 5 5X5 Level"))
                {
                    Card5.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card5;
                    }
                    else
                    {
                        pictureBox2 = Card5;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 6 5X5 Level"))
                {
                    Card6.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card6;
                    }
                    else
                    {
                        pictureBox2 = Card6;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 7 5X5 Level"))
                {
                    Card7.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card7;
                    }
                    else
                    {
                        pictureBox2 = Card7;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 8 5X5 Level"))
                {
                    Card8.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card8;
                    }
                    else
                    {
                        pictureBox2 = Card8;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 9 5X5 Level"))
                {
                    Card9.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card9;
                    }
                    else
                    {
                        pictureBox2 = Card9;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 10 5X5 Level"))
                {
                    Card10.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card10;
                    }
                    else
                    {
                        pictureBox2 = Card10;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 11 5X5 Level"))
                {
                    Card11.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card11;
                    }
                    else
                    {
                        pictureBox2 = Card11;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 12 5X5 Level"))
                {
                    Card12.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card12;
                    }
                    else
                    {
                        pictureBox2 = Card12;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 13 5X5 Level"))
                {
                    Card13.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card13;
                    }
                    else
                    {
                        pictureBox2 = Card13;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 14 5X5 Level"))
                {
                    Card14.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card14;
                    }
                    else
                    {
                        pictureBox2 = Card14;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 15 5X5 Level"))
                {
                    Card15.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card15;
                    }
                    else
                    {
                        pictureBox2 = Card15;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 16 5X5 Level"))
                {
                    Card16.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card16;
                    }
                    else
                    {
                        pictureBox2 = Card16;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 17 5X5 Level"))
                {
                    Card17.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card17;
                    }
                    else
                    {
                        pictureBox2 = Card17;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 18 5X5 Level"))
                {
                    Card18.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card18;
                    }
                    else
                    {
                        pictureBox2 = Card18;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 19 5X5 Level"))
                {
                    Card19.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card19;
                    }
                    else
                    {
                        pictureBox2 = Card19;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 20 5X5 Level"))
                {
                    Card20.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card20;
                    }
                    else
                    {
                        pictureBox2 = Card20;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 21 5X5 Level"))
                {
                    Card21.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card21;
                    }
                    else
                    {
                        pictureBox2 = Card21;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 22 5X5 Level"))
                {
                    Card22.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card22;
                    }
                    else
                    {
                        pictureBox2 = Card22;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 23 5X5 Level"))
                {
                    Card23.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card23;
                    }
                    else
                    {
                        pictureBox2 = Card23;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 24 5X5 Level"))
                {
                    Card24.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card24;
                    }
                    else
                    {
                        pictureBox2 = Card24;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type[Count].Equals("Card 25 5X5 Level"))
                {
                    Card25.Image = Properties.Resources.X_Sign_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card25;
                    }
                    else
                    {
                        pictureBox2 = Card25;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[0].Cards_5X5_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card5.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card10.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card11.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card12.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card13.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card14.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card15.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card16.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card17.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card18.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card19.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card20.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card21.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card22.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card23.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card24.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card25.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
            if (Form8.Count == 2)
            {
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 1 5X5 Level"))
                {
                    Card1.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1;
                    }
                    else
                    {
                        pictureBox2 = Card1;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 2 5X5 Level"))
                {
                    Card2.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2;
                    }
                    else
                    {
                        pictureBox2 = Card2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 3 5X5 Level"))
                {
                    Card3.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3;
                    }
                    else
                    {
                        pictureBox2 = Card3;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 4 5X5 Level"))
                {
                    Card4.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4;
                    }
                    else
                    {
                        pictureBox2 = Card4;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 5 5X5 Level"))
                {
                    Card5.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card5;
                    }
                    else
                    {
                        pictureBox2 = Card5;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 6 5X5 Level"))
                {
                    Card6.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card6;
                    }
                    else
                    {
                        pictureBox2 = Card6;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 7 5X5 Level"))
                {
                    Card7.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card7;
                    }
                    else
                    {
                        pictureBox2 = Card7;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 8 5X5 Level"))
                {
                    Card8.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card8;
                    }
                    else
                    {
                        pictureBox2 = Card8;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 9 5X5 Level"))
                {
                    Card9.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card9;
                    }
                    else
                    {
                        pictureBox2 = Card9;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 10 5X5 Level"))
                {
                    Card10.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card10;
                    }
                    else
                    {
                        pictureBox2 = Card10;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 11 5X5 Level"))
                {
                    Card11.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card11;
                    }
                    else
                    {
                        pictureBox2 = Card11;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 12 5X5 Level"))
                {
                    Card12.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card12;
                    }
                    else
                    {
                        pictureBox2 = Card12;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 13 5X5 Level"))
                {
                    Card13.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card13;
                    }
                    else
                    {
                        pictureBox2 = Card13;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 14 5X5 Level"))
                {
                    Card14.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card14;
                    }
                    else
                    {
                        pictureBox2 = Card14;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 15 5X5 Level"))
                {
                    Card15.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card15;
                    }
                    else
                    {
                        pictureBox2 = Card15;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 16 5X5 Level"))
                {
                    Card16.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card16;
                    }
                    else
                    {
                        pictureBox2 = Card16;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 17 5X5 Level"))
                {
                    Card17.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card17;
                    }
                    else
                    {
                        pictureBox2 = Card17;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 18 5X5 Level"))
                {
                    Card18.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card18;
                    }
                    else
                    {
                        pictureBox2 = Card18;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 19 5X5 Level"))
                {
                    Card19.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card19;
                    }
                    else
                    {
                        pictureBox2 = Card19;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 20 5X5 Level"))
                {
                    Card20.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card20;
                    }
                    else
                    {
                        pictureBox2 = Card20;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 21 5X5 Level"))
                {
                    Card21.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card21;
                    }
                    else
                    {
                        pictureBox2 = Card21;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 22 5X5 Level"))
                {
                    Card22.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card22;
                    }
                    else
                    {
                        pictureBox2 = Card22;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 23 5X5 Level"))
                {
                    Card23.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card23;
                    }
                    else
                    {
                        pictureBox2 = Card23;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 24 5X5 Level"))
                {
                    Card24.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card24;
                    }
                    else
                    {
                        pictureBox2 = Card24;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type[Count].Equals("Card 25 5X5 Level"))
                {
                    Card25.Image = Properties.Resources.X_Sign_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card25;
                    }
                    else
                    {
                        pictureBox2 = Card25;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[1].Cards_5X5_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card5.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card10.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card11.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card12.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card13.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card14.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card15.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card16.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card17.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card18.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card19.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card20.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card21.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card22.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card23.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card24.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card25.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
            if (Form8.Count == 3)
            {
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 1 5X5 Level"))
                {
                    Card1.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1;
                    }
                    else
                    {
                        pictureBox2 = Card1;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 2 5X5 Level"))
                {
                    Card2.Image = Properties.Resources.Gambol_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2;
                    }
                    else
                    {
                        pictureBox2 = Card2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 3 5X5 Level"))
                {
                    Card3.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3;
                    }
                    else
                    {
                        pictureBox2 = Card3;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 4 5X5 Level"))
                {
                    Card4.Image = Properties.Resources.Darwen_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4;
                    }
                    else
                    {
                        pictureBox2 = Card4;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 5 5X5 Level"))
                {
                    Card5.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card5;
                    }
                    else
                    {
                        pictureBox2 = Card5;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 6 5X5 Level"))
                {
                    Card6.Image = Properties.Resources.Anayes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card6;
                    }
                    else
                    {
                        pictureBox2 = Card6;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 7 5X5 Level"))
                {
                    Card7.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card7;
                    }
                    else
                    {
                        pictureBox2 = Card7;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 8 5X5 Level"))
                {
                    Card8.Image = Properties.Resources.Retshard_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card8;
                    }
                    else
                    {
                        pictureBox2 = Card8;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 9 5X5 Level"))
                {
                    Card9.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card9;
                    }
                    else
                    {
                        pictureBox2 = Card9;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 10 5X5 Level"))
                {
                    Card10.Image = Properties.Resources.Necole_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card10;
                    }
                    else
                    {
                        pictureBox2 = Card10;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 11 5X5 Level"))
                {
                    Card11.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card11;
                    }
                    else
                    {
                        pictureBox2 = Card11;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 12 5X5 Level"))
                {
                    Card12.Image = Properties.Resources.panana_Jo_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card12;
                    }
                    else
                    {
                        pictureBox2 = Card12;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 13 5X5 Level"))
                {
                    Card13.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card13;
                    }
                    else
                    {
                        pictureBox2 = Card13;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 14 5X5 Level"))
                {
                    Card14.Image = Properties.Resources.Sarah_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card14;
                    }
                    else
                    {
                        pictureBox2 = Card14;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 15 5X5 Level"))
                {
                    Card15.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card15;
                    }
                    else
                    {
                        pictureBox2 = Card15;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 16 5X5 Level"))
                {
                    Card16.Image = Properties.Resources.Lezly_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card16;
                    }
                    else
                    {
                        pictureBox2 = Card16;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 17 5X5 Level"))
                {
                    Card17.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card17;
                    }
                    else
                    {
                        pictureBox2 = Card17;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 18 5X5 Level"))
                {
                    Card18.Image = Properties.Resources.Peny_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card18;
                    }
                    else
                    {
                        pictureBox2 = Card18;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 19 5X5 Level"))
                {
                    Card19.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card19;
                    }
                    else
                    {
                        pictureBox2 = Card19;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 20 5X5 Level"))
                {
                    Card20.Image = Properties.Resources.Kary_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card20;
                    }
                    else
                    {
                        pictureBox2 = Card20;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 21 5X5 Level"))
                {
                    Card21.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card21;
                    }
                    else
                    {
                        pictureBox2 = Card21;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 22 5X5 Level"))
                {
                    Card22.Image = Properties.Resources.Tobaes_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card22;
                    }
                    else
                    {
                        pictureBox2 = Card22;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 23 5X5 Level"))
                {
                    Card23.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card23;
                    }
                    else
                    {
                        pictureBox2 = Card23;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 24 5X5 Level"))
                {
                    Card24.Image = Properties.Resources.Small_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card24;
                    }
                    else
                    {
                        pictureBox2 = Card24;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type[Count].Equals("Card 25 5X5 Level"))
                {
                    Card25.Image = Properties.Resources.X_Sign_Neon_Card;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card25;
                    }
                    else
                    {
                        pictureBox2 = Card25;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[2].Cards_5X5_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card5.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card6.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card7.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card8.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card9.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card10.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card11.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card12.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card13.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card14.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card15.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card16.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card17.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card18.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card19.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card20.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card21.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card22.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card23.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card24.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card25.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
        }
    }
}
