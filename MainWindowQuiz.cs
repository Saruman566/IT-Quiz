using ITQuiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lern_Quiz
{
    public partial class ITSicherheit : Form    {
                
        Database QuizDatabase = new Database();        
        public int quest_numb = 1;        
        private dynamic q_text;
        private string right_answer;
        private string quest_n;
        private int next_count = 0;
        //private string path_to_file;


        public ITSicherheit() 
        {
            Main_menu(); 
            Loading_db();
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        // Background
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            BackgroundImageLayout = ImageLayout.Center;
            this.ResumeLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomelabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }      
         
        // Antwort checks
        private void answer1_Click(object sender, EventArgs e)
        {
            check_answer(1);
        }        

        private void answer2_Click(object sender, EventArgs e)
        {
            check_answer(2);
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            check_answer(3);
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            check_answer(4);
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        // Vor & Zurück
        private void Next_Click(object sender, EventArgs e)
        {            
           next_q();
        }
        private void next_q()
        {   
            
            this.SuspendLayout();
            string db_name = QuizDatabase.give_db_name();
           
            if (next_count == 0)
            {
                DialogResult Notheme = MessageBox.Show("Sorry, bitte zuerst ein Thema wählen!", "Kein Thema gewählt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Notheme == DialogResult.Yes)
                {

                }
                
            }
            else
            {
                q_text = QuizDatabase.next_quest();                
                quest_n = q_text.Item1;
                questt.Text = q_text.Item2;
                answer1.Text = q_text.Item3;
                answer2.Text = q_text.Item4;
                answer3.Text = q_text.Item5;
                answer4.Text = q_text.Item6;
                right_answer = q_text.Item7;

                them_label.Text = string.Format("{0}", db_name);
                questcount.Text = string.Format("Frage: {0}", (quest_n).ToString());

                answer1.BackColor = Color.SkyBlue;
                answer2.BackColor = Color.SkyBlue;
                answer3.BackColor = Color.SkyBlue;
                answer4.BackColor = Color.SkyBlue;

                this.ResumeLayout(); 

            }          
   
        }
        private void last_q()
        {
            this.SuspendLayout();
            string db_name = QuizDatabase.give_db_name();

            if (next_count == 0)
            {
                DialogResult Notheme = MessageBox.Show("Sorry, bitte zuerst ein Thema wählen!", "Kein Thema gewählt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Notheme == DialogResult.Yes)
                {

                }

            }
            else
            {
                q_text = QuizDatabase.last_quest();
                quest_n = q_text.Item1;
                questt.Text = q_text.Item2;
                answer1.Text = q_text.Item3;
                answer2.Text = q_text.Item4;
                answer3.Text = q_text.Item5;
                answer4.Text = q_text.Item6;
                right_answer = q_text.Item7;

                them_label.Text = string.Format("{0}", db_name);
                questcount.Text = string.Format("Frage: {0}", (quest_n).ToString());

                answer1.BackColor = Color.SkyBlue;
                answer2.BackColor = Color.SkyBlue;
                answer3.BackColor = Color.SkyBlue;
                answer4.BackColor = Color.SkyBlue;


                this.ResumeLayout();
            }
        }
        private void Last_Click(object sender, EventArgs e)
        {
            last_q();
        }

        
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void questt_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void questcount_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void check_answer(int num_answer)
        {
            this.SuspendLayout();
            if (num_answer == 1)
            {
                if (right_answer == answer1.Text)
                {
                    answer1.BackColor = Color.Lime;                    
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.SkyBlue;
                }
                else
                {
                    answer1.BackColor = Color.Red;                    
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.SkyBlue;
                }
            }
            else if (num_answer == 2)
            {
                if (right_answer == answer2.Text)
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.Lime;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.SkyBlue;
                }
                else
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.Red;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.SkyBlue;
                }
            }
            else if (num_answer == 3)
            {
                if (right_answer == answer3.Text)
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.Lime;
                    answer4.BackColor = Color.SkyBlue;
                }
                else
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.Red;
                    answer4.BackColor = Color.SkyBlue;
                }
            }
            else
            {
                if (right_answer == answer4.Text)
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.Lime;
                }
                else
                {                    
                    answer1.BackColor = Color.SkyBlue;
                    answer2.BackColor = Color.SkyBlue;
                    answer3.BackColor = Color.SkyBlue;
                    answer4.BackColor = Color.Red;
                }
            }
            this.ResumeLayout();
        }

   
        public void refresh_main(bool okay)
        {
            
            if (okay is true)
            {
                this.SuspendLayout();                
                Application.Restart();
                this.ResumeLayout();                
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            Frage_hinzufügen neue_frage = new Frage_hinzufügen(); 
            this.SuspendLayout();
            neue_frage.Show();
            this.ResumeLayout();            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        // IT-Sicherheit

        public void iTSicherheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult Questresult = MessageBox.Show("Thema zu IT-Sicherheit wechseln?","Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "it_sicherheit";
                Reload_db(database_name);
            }
            
            
        }

        public void iTSystemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu IT-Systeme wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "it_systeme";
                Reload_db(database_name);
            }         
        }

        public void programmierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Programmieren wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "programmieren";
                Reload_db(database_name);
            }                 
        }

        public void datenbankenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Datenbanken wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "datenbanken";
                Reload_db(database_name);
            }
        }

        public void linuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Linux wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "linux";
                Reload_db(database_name);
            }
        }

        private void cyberphysischesystemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Cyberphysichesysteme wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "cyberphysischesysteme";
                Reload_db(database_name);
            }
        }

        // Netzwerke
        public void netzwerkToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.BackColor = Color.MidnightBlue;
        }       

        private void iPv4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu IPv4 wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "ipv4";            
                Reload_db(database_name);
            }
        }

        private void iPv6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu IPv6 wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "ipv6";
                Reload_db(database_name);
            }
        }

        private void firewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Firewall wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "firewall";
                Reload_db(database_name);
            }
        }

        private void tCPIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu TCP/IP wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "tcpip";
                Reload_db(database_name);
            }
        }

        private void routingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Routing wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "routing";
                Reload_db(database_name);
            }
        }

        // WISO
        public void wISOToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            this.BackColor = Color.MidnightBlue;
        }       

        private void arbeitsrechtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Arbeitsrecht wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "arbeitsrecht";
                Reload_db(database_name);
            }
        }

        private void kalkulationenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Kalkulationen wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "kalkulationen";
                Reload_db(database_name);
            }
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Marketing wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "marketing";
                Reload_db(database_name);
            }
        }

        private void organisationslehreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Organisationslehre wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "organisationslehre";
                Reload_db(database_name);
            }
        }

        private void projektmanagemenbtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Projektmanagement wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "projektmanagement";
                Reload_db(database_name);
            }
        }

        private void rechtsformenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Rechtsformen wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                string database_name = "rechtsformen";
                Reload_db(database_name);
            }
        }
        
        private void Reload_db(string database_name)
        {
            next_count++;
            QuizDatabase.remove_quests();
            this.Update();
            QuizDatabase.ReadDatabase(database_name);
            QuizDatabase.Read_Count_Of_Db(database_name);
            next_q();
            last_q();
        }

        private void them_label_Click(object sender, EventArgs e)
        {

        }
              
        
        private void Loading_db()
        {
            lo_db Lo_form = new lo_db();            
            Lo_form.ShowDialog();

        }

        private void Main_menu()
        {
            FirstSide newmenu = new FirstSide();
            newmenu.ShowDialog();
            
        }

    }
}
