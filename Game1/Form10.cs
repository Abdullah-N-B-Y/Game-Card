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
    public partial class Form10 : Form
    {
        #region Attributes
            Thread thread;
            public static int Count = 0;
        #endregion

        public Form10()
        {
            InitializeComponent();
        }

        #region Functions
            private void Form10_Load(object sender, EventArgs e)
            {
                for (int i = 0; i < Form9.Profiles.Count; i++)
                {

                    Profile_List_CompoBox.Items.Add(Form9.Profiles.ElementAt(i).Value.Name);
                }
            }
            public void OpenNewForm2()
        {
            Application.Run(new Form2());
        }
        #endregion
        #region Buttons
            
            private void Cancel_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Name_Box.Text.Length != 0)
            {
                if (Age_Box.Text.Length != 0)
                {
                    Form9.Profiles.ElementAt(Count).Value.Name = Name_Box.Text;
                    Form9.Profiles.ElementAt(Count).Value.Age = Convert.ToInt32(Age_Box.Text);
                    if (Male_Button.Checked)
                    {
                        Form9.Profiles.ElementAt(Count).Value.Gender = "Male";
                    }
                    else
                    {
                        Form9.Profiles.ElementAt(Count).Value.Gender = "Female";
                    }
                    if (Blue_Button.Checked)
                    {
                        Form9.Profiles.ElementAt(Count).Value.BackgroundColor = "Blue";
                    }
                    else if (Red_Button.Checked)
                    {
                        Form9.Profiles.ElementAt(Count).Value.BackgroundColor = "Red";
                    }
                    else if (Yellow_Button.Checked)
                    {
                        Form9.Profiles.ElementAt(Count).Value.BackgroundColor = "Yellow";
                    }
                    MessageBox.Show("Updated Successfully");
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
        private void Select_Button_Click_1(object sender, EventArgs e)
        {
            if (Profile_List_CompoBox.Text.Length == 0)
            {
                label2.Visible = true;


            }
            else
            {
                for (int i = 0; i < Form9.Profiles.Count; i++)
                {
                    if (Profile_List_CompoBox.Text.Equals(Form9.Profiles.ElementAt(i).Key))
                    {
                        label2.Visible = false;

                        Profile_List_CompoBox.Visible = false;
                        Select_Button.Visible = false;
                        label1.Visible = false;
                        Save_Button.Visible = true;
                        Nme_Lable.Visible = true;
                        Name_Box.Visible = true;
                        groupBox2_curr.Visible = true;
                        Male_Button.Visible = true;
                        Female_Button.Visible = true;
                        label3.Visible = true;
                        Age_Box.Visible = true;
                        groupBox1.Visible = true;
                        Blue_Button.Visible = true;
                        Red_Button.Visible = true;
                        Yellow_Button.Visible = true;

                        Count = i;
                        Name_Box.Text = Form9.Profiles.ElementAt(i).Value.Name;
                        Age_Box.Text = Convert.ToString(Form9.Profiles.ElementAt(i).Value.Age);
                        if (Form9.Profiles.ElementAt(i).Value.Gender == "Male")
                        {
                            Male_Button.Checked = true;
                        }
                        else
                        {
                            Female_Button.Checked = true;
                        }
                        if (Form9.Profiles.ElementAt(i).Value.BackgroundColor == "Blue")
                        {
                            Blue_Button.Checked = true;
                        }
                        else if (Form9.Profiles.ElementAt(i).Value.BackgroundColor == "Red")
                        {
                            Red_Button.Checked = true;
                        }
                        else if (Form9.Profiles.ElementAt(i).Value.BackgroundColor == "Yellow")
                        {
                            Yellow_Button.Checked = true;
                        }
                    }
                    else
                    {
                        label2.Visible = false;

                        label1.Visible = true;
                    }


                }
            }
        }

        private void Cancel_Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
