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
                      
        private string give_quest;
        private string quest_text;
        private string answer1_text;
        private string answer2_text;
        private string answer3_text;
        private string answer4_text;
        private string right_answer_Text;        
        private string items = "";

        public Frage_hinzufügen()
        {
            InitializeComponent();
            
        }

        // Frage zur Datenbank
        private void to_database()
        {
            
            this.SuspendLayout();
            quest_text = neueFrage.Text;
            answer1_text = antwort1.Text;
            answer2_text = antwort2.Text;
            answer3_text = antwort3.Text;
            answer4_text = antwort4.Text;
            right_answer_Text = richtigeAntwort.Text;

            SQLiteConnection new_db_connection = new SQLiteConnection(@"URI=file:Quizdatabase.db");
            new_db_connection.Open();

            give_quest = String.Format("INSERT INTO {0} (FRAGE, ANTWORT_EINS, ANTWORT_ZWEI, ANTWORT_DREI, ANTWORT_VIER, RICHTIGE_ANTWORT)" +
                "VALUES ('{1}','{2}','{3}','{4}','{5}','{6}')", items, quest_text, answer1_text, answer2_text,answer3_text, answer4_text, right_answer_Text);

            SQLiteCommand give_the_quest = new SQLiteCommand(give_quest, new_db_connection);                     

            give_the_quest.ExecuteNonQuery();
            new_db_connection.Close();
            refresh_main();
            this.ResumeLayout();
        }

        // Zurück Button
        public void button1_Click(object sender, EventArgs e)
        {               
            this.Close();            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Hinzufügen Button
        private void hinzufuegen_Click(object sender, EventArgs e)
        {

            Console.WriteLine(give_db_name_back());
            if (items != "")
            {
                to_database();
            }
            else
            {

            }
        }

        // Refresh
        public void refresh_main()
        {   
            ITSicherheit main = new ITSicherheit();
            bool okay = true;
            main.refresh_main(okay);
           
        }



        private void Frage_hinzufügen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void welcomelabel_Click(object sender, EventArgs e)
        {

        }

        private void antwort2_TextChanged(object sender, EventArgs e)
        {

        }

        // Dropdown
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            items = comboBox1.Text;                       
        }

        // Umbenennung
        public string give_db_name_back()
        {
            if (items == "IT Sicherheit")
            {
                items = "it_sicherheit";
            }
            else if (items == "IT Systeme")
            {
                items = "it_systeme";
            }
            else if (items == "Programmieren")
            {
                items = "programmieren";
            }
            else if (items == "Datenbanken")
            {
                items = "datenbanken";
            }
            else if (items == "Cyberphysischesysteme")
            {
                items = "cyberphysischesysteme";
            }
            else if (items == "Netzwerk")
            {   
                items = "netzwerk";
            }   
            else if (items == "WISO")
            {
                items = "wiso";
            }

            return items;
        }
    }
}
