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
    public partial class Form2 : Form
    {
        #region Attributes
            Thread thread;
            private bool Open1 = true;
            private bool Open2 = true;
            private bool Open3 = true;
            private int x;
        #endregion
        public Form2()
        {
            InitializeComponent();
        }

        #region Buttons
            private void Cnacle_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void Game_Button_List_Click(object sender, EventArgs e)
            {
                x = 1;
                New_Game_List_Timer.Start();
            }
            private void Profile_List_Button_Click(object sender, EventArgs e)
            {
                
            }
            private void Report_List_Page_2_Button_Click(object sender, EventArgs e)
            {
                
            }
            private void New_Profile_Page_2_Button_Click_1(object sender, EventArgs e)
            {
                
            }
            private void End_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void To_2X2_Level_Button_Click_1(object sender, EventArgs e)
            {
                
            }
            private void Current_Button_Click_1(object sender, EventArgs e)
            {
               
            }
            private void Statistics_Page_2_Button_Click_1(object sender, EventArgs e)
            {
               
            }
            private void History_Page_2_Button_Click_1(object sender, EventArgs e)
            {
                
            }

        #endregion
        #region Functions
            public void OpenNewForm()
            {
                Application.Run(new Form3());
            }
            public void OpenNewForm8()
            {
                Application.Run(new Form8());
            }
            public void OpenNewForm12()
            {
                Application.Run(new Form12());
            }
            public void OpenNewForm9()
            {
                Application.Run(new Form9());
            }
            public void OpenNewForm10()
        {
            Application.Run(new Form10());
        }
        #endregion
        #region Timers
        private void New_Game_List_Timer_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                if (Open1)
                {
                    Profile_List_Panel.Height += 15;
                    //Game_Button_List.Image = Properties.Resources.Shm_Up;
                    if (Profile_List_Panel.Size == Profile_List_Panel.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open1 = false;
                    }
                }
                else
                {
                    Profile_List_Panel.Height -= 15;
                    //Game_Button_List.Image = Properties.Resources.Shm_Down;
                    if (Profile_List_Panel.Size == Profile_List_Panel.MinimumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open1 = true;
                    }
                }
            }
            else if (x == 2)
            {
                if (Open2)
                {
                    Game_List_Panel.Height += 10;
                    if (Game_List_Panel.Size == Game_List_Panel.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open2 = false;
                    }
                }
                else
                {
                    Game_List_Panel.Height -= 10;
                    if (Game_List_Panel.Size == Game_List_Panel.MinimumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open2 = true;
                    }
                }
            }
            else if (x == 3)
            {
                if (Open3)
                {
                    Report_List_Panel.Height += 10;
                    if (Report_List_Panel.Size == Report_List_Panel.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open3 = false;
                    }
                }
                else
                {
                    Report_List_Panel.Height -= 10;
                    if (Report_List_Panel.Size == Report_List_Panel.MinimumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open3 = true;
                    }
                }
            }
        }


        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            x = 1;
            New_Game_List_Timer.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            x = 2;
            New_Game_List_Timer.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm9);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm10);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            x = 3;
            New_Game_List_Timer.Start();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm12);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm8);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
    }
}
