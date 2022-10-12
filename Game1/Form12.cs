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
    public partial class Form12 : Form
    {
        #region Attributs
            Thread thread;
            private static int Max_Score;
            private static int Min_Score;
            private static int Max_Duration;
            private static int Min_Duration;
            private static int Sum_Duration = 0;
            private SoundPlayer sound1,sound2;
        #endregion
        public Form12()
        {
            InitializeComponent();
        }

        #region Buttons
            private void Show_The_Result_Click(object sender, EventArgs e)
            {
                if (Form3.Num_Games != 0)
                {
                    Did_Not_Play_Label.Visible = false;
                    Oops_Label.Visible = false;

                    var linq = from item in Form9.Profiles//LINQ 
                               select item;

                    Max_Score = Convert.ToInt32(linq.ElementAt(0).Value.Score);
                    Min_Score = Convert.ToInt32(linq.ElementAt(0).Value.Score);
                    Max_Duration = Convert.ToInt32(linq.ElementAt(0).Value.Deuration);
                    Min_Duration = Convert.ToInt32(linq.ElementAt(0).Value.Deuration);

                    Oops_Label.Visible = false;

                    //Max_Score = Convert.ToInt32(Form9.Profiles.ElementAt(0).Value.Score);
                    //Min_Score = Convert.ToInt32(Form9.Profiles.ElementAt(0).Value.Score);
                    //Max_Duration = Convert.ToInt32(Form9.Profiles.ElementAt(0).Value.Deuration);
                    //Min_Duration = Convert.ToInt32(Form9.Profiles.ElementAt(0).Value.Deuration);

                    //Maximum Score
                    for (int i = 0; i < linq.Count(); i++)
                    {
                        if (Convert.ToInt32(linq.ElementAt(i).Value.Score) > Max_Score)
                        {
                            Max_Score = Convert.ToInt32(linq.ElementAt(i).Value.Score);
                        }
                    }

                    //Lowest Score
                    for (int i = 0; i < linq.Count(); i++)
                    {
                        if (Convert.ToInt32(linq.ElementAt(i).Value.Score) < Min_Score)
                        {
                            Min_Score = Convert.ToInt32(linq.ElementAt(i).Value.Score);
                        }
                    }

                    //Maximum Duration
                    for (int i = 0; i < linq.Count(); i++)
                    {
                        if (Convert.ToInt32(linq.ElementAt(i).Value.Deuration) > Max_Duration)
                        {
                            Max_Duration = Convert.ToInt32(linq.ElementAt(i).Value.Deuration);
                        }
                    }

                    //Minimum Duration
                    for (int i = 0; i < linq.Count(); i++)
                    {
                        if (Convert.ToInt32(linq.ElementAt(i).Value.Deuration) < Min_Duration)
                        {
                            Min_Duration = Convert.ToInt32(linq.ElementAt(i).Value.Deuration);
                        }
                    }

                    //Total Duration
                    for (int i = 0; i < linq.Count(); i++)
                    {
                        Sum_Duration += Convert.ToInt32(linq.ElementAt(i).Value.Deuration);
                    }

                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;

                    label10.Text = Convert.ToString(Form3.Num_Games);
                    label11.Text = Convert.ToString(Form9.Count1);
                    label12.Text = Convert.ToString(Max_Score);
                    label13.Text = Convert.ToString(Min_Score);
                    label14.Text = Convert.ToString(Min_Duration);
                    label15.Text = Convert.ToString(Max_Duration);
                    label16.Text = Convert.ToString(Sum_Duration);
                    Sum_Duration = 0;

                }
                else if (Form9.Profiles.Count != 0)
                {
                    Oops_Label.Visible = false;
                    Did_Not_Play_Label.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;

                    label10.Text = Convert.ToString(0);
                    label11.Text = Convert.ToString(Form9.Count1);
                    label12.Text = Convert.ToString(0);
                    label13.Text = Convert.ToString(0);
                    label14.Text = Convert.ToString(0);
                    label15.Text = Convert.ToString(0);
                    label16.Text = Convert.ToString(0);
                }
                else
                {
                    Oops_Label.Visible = true;
                    Did_Not_Play_Label.Visible = false;
                }
            }
            private void Cancel_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void Back_button_Click(object sender, EventArgs e)
            {
                thread = new Thread(OpenNewForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
        #endregion
        #region Functions
            private void Form12_Load(object sender, EventArgs e)
            {
            sound1 = new SoundPlayer(@"C:\Users\AMCT\Desktop\Game\Game1\bin\Debug\Shhh.wav");
            sound2 = new SoundPlayer(@"C:\Users\AMCT\Desktop\Game\Game1\bin\Debug\Whats.wav");
            }
            public void OpenNewForm2()
            {
                Application.Run(new Form2());
            }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //sound2.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sound1.Play();
        }

        
    }
}
