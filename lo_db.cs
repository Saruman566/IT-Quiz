using Lern_Quiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITQuiz
{
    public partial class lo_db : Form
    {
        public lo_db()
        {               
            InitializeComponent();
            progressbar_load();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        public void progressbar_load()
        {               
            timer1.Start();
            
        }

        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(3);

            if(progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();                
                this.Close();               
            }
            
        }
    }
}
