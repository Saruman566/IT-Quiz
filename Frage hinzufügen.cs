using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lern_Quiz
{
    public partial class Frage_hinzufügen : Form
    {
        Database QuizDatabase = new Database();
                
        private string give_quest;
        private string quest_text;
        private string answer1_text;
        private string answer2_text;
        private string answer3_text;
        private string answer4_text;
        private string right_answer_Text;

        public Frage_hinzufügen()
        {
            InitializeComponent();
            
        }


        private void to_database()
        {   
            this.SuspendLayout();
            quest_text = neueFrage.Text;
            answer1_text = antwort1.Text;
            answer2_text = antwort2.Text;
            answer3_text = antwort3.Text;
            answer4_text = antwort4.Text;
            right_answer_Text = richtigeAntwort.Text;

            SQLiteConnection new_db_connection = new SQLiteConnection(@"URI=file:C:\Development\C#\lern-Quiz\Lern-Quiz\Quizdatabase.db");
            new_db_connection.Open();

            give_quest = String.Format("INSERT INTO fragen (fragen,antwort1,antwort2,antwort3,antwort4,richtige_antwort)" +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", quest_text, answer1_text, answer2_text,answer3_text, answer4_text, right_answer_Text);

            string get_count = "SELECT COUNT(fragen) FROM Quiz";

            SQLiteCommand give_the_quest = new SQLiteCommand(give_quest, new_db_connection);
            SQLiteCommand give_the_count = new SQLiteCommand(get_count, new_db_connection);


            give_the_quest.ExecuteNonQuery();
            new_db_connection.Close();
            refresh_main();
            this.ResumeLayout();
        }


        public void button1_Click(object sender, EventArgs e)
        {               
            this.Close();            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hinzufuegen_Click(object sender, EventArgs e)
        {
            to_database();
        }

        public void refresh_main()
        {   
            ITSicherheit main = new ITSicherheit();
            bool okay = true;
            main.refresh_main(okay);
           
        }

        private void Frage_hinzufügen_Load(object sender, EventArgs e)
        {

        }
    }
}
