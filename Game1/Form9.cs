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
    public partial class Form9 : Form
    {
        #region Attributes
            private Thread thread;
            public static Dictionary<string, Profile> Profiles = new Dictionary<string, Profile>();
            Profile profile;
            public static int Count1 = 0;
        #endregion
        public Form9()
        {
            InitializeComponent();
        }

        #region Class
            public class Profile
        {
            public List<string> Cards_Name = new List<string>();//

            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string BackgroundColor { get; set; }
            public string Deuration { get; set; }
            public string Score { get; set; }
            public string Level { get; set; }

            public int count2;

            public List<string> Names = new List<string>();

            public List<string> Cards_2X2_Type = new List<string>();
            public List<string> Cards_3X3_Type = new List<string>();
            public List<string> Cards_4X4_Type = new List<string>();
            public List<string> Cards_5X5_Type = new List<string>();

            public int Selected_Before_Count;
            public Profile()
            {
                Selected_Before_Count = 0;
            }
            public override string ToString()
            {
                return Name + Gender + Age + BackgroundColor;
            }
            public Profile Copy()
            {
                return this.MemberwiseClone() as Profile;
            }


        }
        #endregion
        #region Buttons
            private void button1_Click(object sender, EventArgs e)
            {
                profile = new Profile();
                string G = "", C = "";
                int Count = 0;
                if (Name_Box.Text.Length != 0)
                {
                    if (Age_Box.Text.Length != 0)
                    {
                        if (Male_Button.Checked || Female_Button.Checked)
                        {
                            if (Male_Button.Checked)
                            {
                                G = "Male";
                            }
                            else if (Female_Button.Checked)
                            {
                                G = "Female";
                            }
                            if (Blue_Button.Checked || Red_Button.Checked || Yellow_Button.Checked)
                            {
                                if (Blue_Button.Checked)
                                {
                                    C = "Blue";
                                }
                                else if (Red_Button.Checked)
                                {
                                    C = "Red";
                                }
                                else if (Yellow_Button.Checked)
                                {
                                    C = "Yellow";
                                }
                                profile.Name = Name_Box.Text;
                                profile.Age = Convert.ToInt32(Age_Box.Text);

                                profile.Gender = G;
                                profile.BackgroundColor = C;
                                for (int i = 0; i < Profiles.Count; i++)
                                {
                                    if (Name_Box.Text == Profiles.ElementAt(i).Key)
                                    {
                                        Count++;
                                    }
                                }
                                if (Count == 0)
                                {
                                    Count1++;
                                    Profiles.Add(profile.Name, profile);
                                    
                                    profile = null;
                                thread = new Thread(OpenNewForm3);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                                this.Close();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, Can't Insert The Same Profile Name");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Color");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter The Gender");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter The Age");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter The Name");
                }
            }
            private void Cancel_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        public void OpenNewForm3()
        {
            Application.Run(new Form3());
        }
        #endregion
        #region Functions
            private void Age_Box_KeyPress_1(object sender, KeyPressEventArgs e)
            {
                char c = e.KeyChar;
                if (!Char.IsDigit(c) && c != 8)
                {
                    MessageBox.Show("Can Insert Just Charecter");
                }
            }
            public void OpenNewForm2()
        {
            Application.Run(new Form2());
        }
        #endregion

        private void Save_Button_Click(object sender, EventArgs e)
        {

            {
                profile = new Profile();
                string G = "", C = "";
                int Count = 0;
                if (Name_Box.Text.Length != 0)
                {
                    if (Age_Box.Text.Length != 0)
                    {
                        if (Male_Button.Checked || Female_Button.Checked)
                        {
                            if (Male_Button.Checked)
                            {
                                G = "Male";
                            }
                            else if (Female_Button.Checked)
                            {
                                G = "Female";
                            }
                            if (Blue_Button.Checked || Red_Button.Checked || Yellow_Button.Checked)
                            {
                                if (Blue_Button.Checked)
                                {
                                    C = "Blue";
                                }
                                else if (Red_Button.Checked)
                                {
                                    C = "Red";
                                }
                                else if (Yellow_Button.Checked)
                                {
                                    C = "Yellow";
                                }
                                profile.Name = Name_Box.Text;
                                profile.Age = Convert.ToInt32(Age_Box.Text);

                                profile.Gender = G;
                                profile.BackgroundColor = C;
                                for (int i = 0; i < Profiles.Count; i++)
                                {
                                    if (Name_Box.Text == Profiles.ElementAt(i).Key)
                                    {
                                        Count++;
                                    }
                                }
                                if (Count == 0)
                                {
                                    Count1++;
                                    Profiles.Add(profile.Name, profile);

                                    profile = null;
                                    thread = new Thread(OpenNewForm3);
                                    thread.SetApartmentState(ApartmentState.STA);
                                    thread.Start();
                                    this.Close();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, Can't Insert The Same Profile Name");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Color");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter The Gender");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter The Age");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter The Name");
                }
            }
        }

        private void Back_Button_Click_1(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
    }
}
