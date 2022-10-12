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
    public partial class Form3 : Form
    {
        #region Attibuts
            Thread thread;
            public static int count;
            public static Form9.Profile profile;
            public static List<Form9.Profile> Profile_Ahmad_Obj_List = new List<Form9.Profile>();
            public static int ObjCount = -1;
            public static int Num_Games = 0;
            public static string UserName;
            public static List<List<string>> Names = new List<List<string>>();
            public static List<string> Cards_Name = new List<string>();
        #endregion
        public Form3()
        {
            InitializeComponent();
        }

        #region Buttons
            
            private void Back_Button_Click(object sender, EventArgs e)
            {
                thread = new Thread(OpenNewForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
        #endregion
        #region Functions
        public void OpenNewForm()
            {
                Application.Run(new Form4());
            }
            public void OpenNewForm2()
            {
                Application.Run(new Form2());
            }
            private void Form3_Load(object sender, EventArgs e)
        {
            if (Form9.Profiles.Count != 0)
            {
                for (int i = 0; i < Form9.Profiles.Count; i++)
                {
                    List_Profile_CompoBox.Items.Add(Form9.Profiles.ElementAt(i).Value.Name);
                }
            }
        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }
        public void OpenNewForm9()
        {
            Application.Run(new Form9());
        }

        private void To_Page_2X2_Button_Click(object sender, EventArgs e)
        {
            if (Form9.Profiles.Count == 0)//There Is No Profile Yet
            {
                Yet_Label.Visible = true;
            }
            else//There Is Profile 
            {
                if ((List_Profile_CompoBox.Text == null || List_Profile_CompoBox.Text.Equals("")))//Does Not Insert Profile In The Box
                {
                    Empty_Label.Visible = true;
                }
                else
                {
                    for (int i = 0; i < Form9.Profiles.Count; i++)
                    {
                        if (List_Profile_CompoBox.Text.Equals(Form9.Profiles.ElementAt(i).Value.Name))//Checking the value of the compobox
                        {
                            if (Form9.Profiles.ElementAt(i).Value.Selected_Before_Count != 0)
                            {
                                Form9.Profiles.ElementAt(i).Value.Level = Convert.ToString(0);
                                Form9.Profiles.ElementAt(i).Value.Deuration = Convert.ToString(0);
                                Form9.Profiles.ElementAt(i).Value.Score = Convert.ToString(0);
                                Form9.Profiles.ElementAt(i).Value.Names.Clear();
                                Form9.Profiles.ElementAt(i).Value.Cards_2X2_Type.Clear();
                                Form9.Profiles.ElementAt(i).Value.Cards_3X3_Type.Clear();
                                Form9.Profiles.ElementAt(i).Value.Cards_4X4_Type.Clear();
                                Form9.Profiles.ElementAt(i).Value.Cards_5X5_Type.Clear();
                                Form9.Profiles.ElementAt(i).Value.Cards_Name.Clear();
                                To_Page_2X2_Button.Enabled = true;//Reenapling the button

                                profile = Form9.Profiles.ElementAt(i).Value;//To updating the value in the profile using profile obj by Ref way
                                //Profile_Ahmad_Obj_List.Add(profile);
                                //ObjCount++;//For the number of obj where will save what the user had been playing

                                UserName = Form9.Profiles.ElementAt(i).Value.Name;//To show the name of the user in the levels page

                                Num_Games++;//Number of games

                                thread = new Thread(OpenNewForm);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                                this.Close();
                                break;
                            }
                            else
                            {
                                Form9.Profiles.ElementAt(i).Value.Selected_Before_Count++;
                                To_Page_2X2_Button.Enabled = true;//Reenapling the button

                                profile = Form9.Profiles.ElementAt(i).Value;//To updating the value in the profile using profile obj by Ref way

                                Profile_Ahmad_Obj_List.Add(profile);
                                ObjCount++;//For the number of obj where will save what the user had been playing

                                UserName = Form9.Profiles.ElementAt(i).Value.Name;//To show the name of the user in the levels page

                                Num_Games++;//Number of games

                                thread = new Thread(OpenNewForm);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                                this.Close();
                                break;
                            }
                        }
                        else//If the value of the compobox does not exist in the profiles
                        {
                            Exist_Label.Visible = true;
                        }
                    }

                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm9);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
    }
}
