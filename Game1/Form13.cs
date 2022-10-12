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
    public partial class Form13 : Form
    {
        #region Attributes
            Thread thread;
            static int Count = 0, Count1 = 0,Count2 = 0;
            public static string UserName;
            PictureBox pictureBox1, pictureBox2;
        #endregion
        public Form13()
        {
            InitializeComponent();
        }

        #region Buttons

        private void Cnacle_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm8);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void Next_Button_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm14);
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
                    picture.Location = Form4.Points_Play_Back[Count1];
                    Count1++;
                }

                Card1_2X2.Image = Properties.Resources.Neon_Question_Card;
                Card2_2X2.Image = Properties.Resources.Neon_Question_Card;
                Card3_2X2.Image = Properties.Resources.Neon_Question_Card;
                Card4_2X2.Image = Properties.Resources.Neon_Question_Card;

                Count2++;
                Count = 0;
                Showing_Level1.Start();
            }
            else
            {
                label2.Visible = true;
            }
        }
        #endregion
        #region Timers
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
        private void Showing_Level1_Tick(object sender, EventArgs e)
        {
            if (Form8.Count == 1)
            {
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_2X2_Type[Count].Equals("Card 1 2X2 Level"))
                {
                    Card1_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card1_2X2;
                    }         
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_2X2_Type[Count].Equals("Card 2 2X2 Level"))
                {
                    Card2_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card2_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_2X2_Type[Count].Equals("Card 3 2X2 Level"))
                {
                    Card3_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card3_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[0].Cards_2X2_Type[Count].Equals("Card 4 2X2 Level"))
                {
                    Card4_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card4_2X2;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[0].Cards_2X2_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
            else if (Form8.Count == 2)
            {
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_2X2_Type[Count].Equals("Card 1 2X2 Level"))
                {
                    Card1_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card1_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_2X2_Type[Count].Equals("Card 2 2X2 Level"))
                {
                    Card2_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card2_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_2X2_Type[Count].Equals("Card 3 2X2 Level"))
                {
                    Card3_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card3_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[1].Cards_2X2_Type[Count].Equals("Card 4 2X2 Level"))
                {
                    Card4_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card4_2X2;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[1].Cards_2X2_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
            else if (Form8.Count == 3)
            {
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_2X2_Type[Count].Equals("Card 1 2X2 Level"))
                {
                    Card1_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card1_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card1_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_2X2_Type[Count].Equals("Card 2 2X2 Level"))
                {
                    Card2_2X2.Image = Properties.Resources.card11;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card2_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card2_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_2X2_Type[Count].Equals("Card 3 2X2 Level"))
                {
                    Card3_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card3_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card3_2X2;
                    }
                }
                if (Form3.Profile_Ahmad_Obj_List[2].Cards_2X2_Type[Count].Equals("Card 4 2X2 Level"))
                {
                    Card4_2X2.Image = Properties.Resources.card22;
                    if (pictureBox1 == null)
                    {
                        pictureBox1 = Card4_2X2;
                    }
                    else
                    {
                        pictureBox2 = Card4_2X2;
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
                if (Count == Form3.Profile_Ahmad_Obj_List[2].Cards_2X2_Type.Count)
                {
                    pictureBox1 = null;
                    pictureBox2 = null;
                    Card1_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card2_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card3_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Card4_2X2.Image = Properties.Resources.Correct_Sign_Neon_Card1;
                    Count = 0;
                    Showing_Level1.Stop();
                }
            }
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            Count1 = 0;
            Count2 = 0;
            Name1.Text = UserName;
            if (Form5.Points_Play_Back.Count == 0)
            {
                Next_Button.Enabled = false;
            }
            else
            {
                Next_Button.Enabled = true;
            }
            if (Form4.Points_Play_Back.Count == 0)
            {
                Play_Button.Enabled = false;
            }
            else
            {
                Play_Button.Enabled = true;
            }

        }
        public void OpenNewForm14()
        {
            Application.Run(new Form14());
        }

        #endregion
    }
}
