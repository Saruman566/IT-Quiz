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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lern_Quiz
{
    public partial class ITSicherheit : Form    {

        Database QuizDatabase = new Database();
        Frage_hinzufügen neue_frage = new Frage_hinzufügen();
        public int quest_numb = 1;        
        private dynamic q_text;
        private string right_answer;
        private string quest_n;
        private int next_count = 0;
                


        public ITSicherheit() {

            InitializeComponent();           
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

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

        private void Last_Click(object sender, EventArgs e)
        {
            last_q();
        }

        private void last_q()
        {
            this.SuspendLayout();

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

                questcount.Text = string.Format("Frage: {0}", (quest_n).ToString());

                answer1.BackColor = Color.SkyBlue;
                answer2.BackColor = Color.SkyBlue;
                answer3.BackColor = Color.SkyBlue;
                answer4.BackColor = Color.SkyBlue;


                this.ResumeLayout();
            }
        }


        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void next_q()
        {   
            
            this.SuspendLayout();            

            //Console.WriteLine(database_count);

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
                
                questcount.Text = string.Format("Frage: {0}", (quest_n).ToString());
                
                answer1.BackColor = Color.SkyBlue;
                answer2.BackColor = Color.SkyBlue;
                answer3.BackColor = Color.SkyBlue;
                answer4.BackColor = Color.SkyBlue;

                this.ResumeLayout(); 

            }          
   
        }
       

        private void Next_Click(object sender, EventArgs e)
        {
           next_q();
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
                Application.Restart();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frage_hinzufügen neue_frage = new Frage_hinzufügen();
            neue_frage.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        public void iTSicherheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu IT-Sicherheit wechseln?","Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {   
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("it_sicherheit");
                QuizDatabase.Read_Count_Of_Db("it_sicherheit");
                next_q();
                
            }
            
            
        }

        public void iTSystemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu IT-Systeme wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("it_systeme");
                QuizDatabase.Read_Count_Of_Db("it_systeme");
                next_q();
                
            }
            
            
            
        }

        public void programmierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Programmieren wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("programmieren");
                QuizDatabase.Read_Count_Of_Db("programmieren");
                next_q();
                
            }                     

        }

        public void datenbankenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Datenbanken wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("datenbanken");
                QuizDatabase.Read_Count_Of_Db("datenbanken");
                next_q();

            }
            
        }

        public void linuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Linux wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("linux");
                QuizDatabase.Read_Count_Of_Db("linux");
                next_q();

            }
           
        }

        private void cyberphysischesystemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Questresult = MessageBox.Show("Thema zu Cyberphysichesysteme wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Questresult == DialogResult.Yes)
            {
                next_count++;
                this.Update();
                QuizDatabase.ReadDatabase("cyberphysischesysteme");
                QuizDatabase.Read_Count_Of_Db("cyberphysischesysteme");
                next_q();

            }
            
        }

        public void netzwerkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DialogResult Questresult = MessageBox.Show("Thema zu Netwerk wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo);
            if (Questresult == DialogResult.Yes)
            {
                QuizDatabase.ReadDatabase("netzwerk");
                next_q(1);

            }*/
            this.BackColor = Color.MidnightBlue;
        }

        public void wISOToolStripMenuItem_Click(object sender, EventArgs e)
        {   /*
            DialogResult Questresult = MessageBox.Show("Thema zu WISO wechseln?", "Sind sie sicher?", MessageBoxButtons.YesNo);
            if (Questresult == DialogResult.Yes)
            {
                QuizDatabase.ReadDatabase("wiso");
                next_q(1);

            }*/
            this.BackColor = Color.MidnightBlue;
        }
    }
}
