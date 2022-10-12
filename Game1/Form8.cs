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
    public partial class Form8 : Form
    {
        #region Attributes
        Thread thread;
        private static int x;
        private static bool Open1 = true;
        private static bool Open2 = true;
        private static bool Open3 = true;
        private List<string> Cards_Name = new List<string>();
        public static List<string> Level1_Play_Back = new List<string>();
        public static int Profile1_2X2_Level_Count = 0;
        public static int Count = 0;
        #endregion
        public Form8()
        {
            InitializeComponent();
        }

        #region Buttons
            private void Click_History_Page_Button_Click(object sender, EventArgs e)
            {
                if (Form3.Profile_Ahmad_Obj_List.Count != 0)
                {
                    Oops_Label.Visible = false;

                    DateTime date = DateTime.Now;
                    int Day = date.Day, Month = date.Month, Year = date.Year;

                    if (Table1.Visible == false && Form3.Profile_Ahmad_Obj_List.Count >= 1)
                    {
                        Table1.Visible = true;
                        Table1_V1.Text = Form3.Profile_Ahmad_Obj_List[0].Name;
                        Table1_V2.Text = Convert.ToString(Day + "/" + Month + "/" + Year);
                        Table1_V3.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[0].Deuration + " S");
                        Table1_V4.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[0].Score);
                        Table1_V5.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[0].Level);

                        if (Convert.ToInt32(Form3.Profile_Ahmad_Obj_List[0].Level) < 4)
                        {
                            He_Gave_Up_Label1.Visible = true;
                        }
                        listBox1.Items.Add($"               Step                                    Click");
                        listBox1.Items.Add("-------------------------------|--------------------------------------");

                        for (int i = 0; i < Form3.Profile_Ahmad_Obj_List[0].Names.Count; i++)
                        {
                            listBox1.Items.Add($"                 {i + 1}                   |          {Form3.Profile_Ahmad_Obj_List[0].Names[i]}");
                        }

                    }
                    if (Table2.Visible == false && Form3.Profile_Ahmad_Obj_List.Count >= 2)
                    {

                        Table2.Visible = true;
                        Table2_V1.Text = Form3.Profile_Ahmad_Obj_List[1].Name;
                        Table2_V2.Text = Convert.ToString(Day + "/" + Month + "/" + Year);
                        Table2_V3.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[1].Deuration + " S");
                        Table2_V4.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[1].Score);
                        Table2_V5.Text = Convert.ToString(Convert.ToInt32(Form3.Profile_Ahmad_Obj_List[1].Level));

                        if (Convert.ToInt32(Table2_V5.Text) < 4)
                        {
                            He_Gave_Up_Label2.Visible = true;
                        }

                        listBox2.Items.Add($"               Step                                    Click");
                        listBox2.Items.Add("-------------------------------|--------------------------------------");

                        for (int i = 0; i < Form3.Profile_Ahmad_Obj_List[1].Names.Count; i++)
                        {
                            listBox2.Items.Add($"                 {i + 1}                   |          {Form3.Profile_Ahmad_Obj_List[1].Names[i]}");
                        }

                    }
                    if (Table3.Visible == false && Form3.Profile_Ahmad_Obj_List.Count >= 3)
                    {

                        Table3.Visible = true;
                        Table3_V1.Text = Form3.Profile_Ahmad_Obj_List[2].Name;
                        Table3_V2.Text = Convert.ToString(Day + "/" + Month + "/" + Year);
                        Table3_V3.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[2].Deuration + " S");
                        Table3_V4.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[2].Score);
                        Table3_V5.Text = Convert.ToString(Form3.Profile_Ahmad_Obj_List[2].Level);

                        if (Convert.ToInt32(Table3_V5.Text) < 4)
                        {
                            He_Gave_Up_Label3.Visible = true;
                        }

                        listBox3.Items.Add($"               Step                                    Click");
                        listBox3.Items.Add("-------------------------------|--------------------------------------");

                        for (int i = 0; i < Form3.Profile_Ahmad_Obj_List[2].Names.Count; i++)
                        {
                            listBox3.Items.Add($"                 {i + 1}                   |          {Form3.Profile_Ahmad_Obj_List[2].Names[i]}");
                        }

                    }
                }
                else
                {
                    Oops_Label.Visible = true;
                }
                Form3.Cards_Name.Clear();
            }
            private void Cnacle_Button_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void Table1_V1_Click_1(object sender, EventArgs e)
            {
                x = 1;
                New_Game_List_Timer.Start();
            }
            private void Table2_V1_Click(object sender, EventArgs e)
            {
                x = 2;
                New_Game_List_Timer.Start();
            }
            private void Table3_V1_Click_1(object sender, EventArgs e)
            {
                x = 3;
                New_Game_List_Timer.Start();
            }
            private void Back_Button_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
            private void Play_Back_Button1_Click_1(object sender, EventArgs e)
            {
                Count = 1;
                Form13.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;
                Form14.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;
                Form11.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;

                thread = new Thread(OpenNewForm13);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            private void Play_Back_Button2_Click(object sender, EventArgs e)
            {
                Count = 2;
                Form13.UserName = Form3.Profile_Ahmad_Obj_List[1].Name;
                Form14.UserName = Form3.Profile_Ahmad_Obj_List[1].Name;
                Form11.UserName = Form3.Profile_Ahmad_Obj_List[1].Name;

                thread = new Thread(OpenNewForm13);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            private void Play_Back_Button3_Click(object sender, EventArgs e)
            {
                Count = 3;
                Form13.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;
                Form14.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;
                Form11.UserName = Form3.Profile_Ahmad_Obj_List[0].Name;

                thread = new Thread(OpenNewForm13);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
        #endregion
        #region Timers
        private void New_Game_List_Timer_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                if (Open1)
                {
                    Table1_V1.Image = Properties.Resources.Shm_Up;
                    panel1.Height += 10;
                    if (panel1.Size == panel1.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open1 = false;
                    }
                }
                else
                {
                    Table1_V1.Image = Properties.Resources.Shm_Down;
                    panel1.Height -= 10;
                    if (panel1.Size == panel1.MinimumSize)
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
                    Table2_V1.Image = Properties.Resources.Shm_Up;
                    panel2.Height += 10;
                    if (panel2.Size == panel2.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open2 = false;
                    }
                }
                else
                {
                    Table2_V1.Image = Properties.Resources.Shm_Down;
                    panel2.Height -= 10;
                    if (panel2.Size == panel2.MinimumSize)
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
                    Table3_V1.Image = Properties.Resources.Shm_Up;
                    panel3.Height += 10;
                    if (panel3.Size == panel3.MaximumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open3 = false;
                    }
                }
                else
                {
                    Table3_V1.Image = Properties.Resources.Shm_Down;
                    panel3.Height -= 10;
                    if (panel3.Size == panel3.MinimumSize)
                    {
                        New_Game_List_Timer.Stop();
                        Open3 = true;
                    }
                }
            }
        }
        #endregion
        #region Functions
            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
            public void OpenNewForm2()
            {
                Application.Run(new Form2());
            }
            public void OpenNewForm4()
            {
                Application.Run(new Form4());
            }
            public void OpenNewForm13()
            {
                Application.Run(new Form13());
            }
            private void Form8_Load(object sender, EventArgs e)
        {

        }
        #endregion
        
    }
}
