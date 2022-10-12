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
using System.Media;

namespace Game1
{
    public partial class Form1 : Form
    {
        #region Attributs
        Thread thread;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons
        private void Start_Button_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Functions
        public void OpenNewForm()
        {
            Application.Run(new Form2());
        }
        #endregion

        private void Page1_Sound_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
