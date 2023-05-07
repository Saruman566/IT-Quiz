using Lern_Quiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Quiz_Updater;

namespace ITQuiz
{
    public partial class FirstSide : Form


    {
        public FirstSide()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            quizdater new_up = new quizdater();
            new_up.Show();
            
        }

        private void Quiz_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        

    }
}
