using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Reflection;
using System.Diagnostics;
using System.Drawing.Text;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Lern_Quiz
{
    internal class Database
    {
        
        public int Counter = 0;
        public int quest_counter = 0;
        public int answer_counter = 0;
        private string get_quest;        
        private string get_count;
        private int next_counter = 0;
        private int max_db;
        private string db_name;
        private int text_counter = 0;

        public static List<String> Quest_number = new List<string>();
        public static List<String> Quests = new List<string>();        
        public static List<String> Answer1 = new List<string>();
        public static List<String> Answer2 = new List<string>();
        public static List<String> Answer3 = new List<string>();
        public static List<String> Answer4 = new List<string>();
        public static List<String> RightAnswer = new List<string>();
        
        


       
        // Datenbank lesen
        public void ReadDatabase(string database_name)
        {            
            var new_db_connection = new SqliteConnection("Data Source=Quizdatabase.db");
            new_db_connection.Open();

            get_quest = String.Format("SELECT * FROM {0} ", database_name);
               
            SqliteCommand give_the_quest = new SqliteCommand(get_quest, new_db_connection);
                
            SqliteDataReader rdr_quest = give_the_quest.ExecuteReader();
                           
            while (rdr_quest.Read())
            {
                int number = rdr_quest.GetInt16(0);
                string quest = rdr_quest.GetString(1);
                string answer1 = rdr_quest.GetString(2);
                string answer2 = rdr_quest.GetString(3);
                string answer3 = rdr_quest.GetString(4);
                string answer4 = rdr_quest.GetString(5);
                string right_answer = rdr_quest.GetString(6);
                                          

                Quest_number.Add(number.ToString());
                Quests.Add(quest);
                Answer1.Add(answer1);
                Answer2.Add(answer2);
                Answer3.Add(answer3);
                Answer4.Add(answer4);
                RightAnswer.Add(right_answer);

                                
            }
            new_db_connection.Close();           
                        
        }

        // Datenbank counter lesen
        public int Read_Count_Of_Db(string database_name)
        {   
                        
            SqliteConnection new_db_connection = new SqliteConnection("Data Source=Quizdatabase.db");
            new_db_connection.Open();

            
            get_count = String.Format("SELECT COUNT(Frage) FROM {0}", database_name);
            SqliteCommand give_the_count = new SqliteCommand(get_count, new_db_connection);
            Int32 rdr_count = Convert.ToInt32(give_the_count.ExecuteScalar());

            new_db_connection.Close();

            db_name= database_name;
            max_db = rdr_count - 1;

            return rdr_count;
        }

        // Remove
        public void remove_quests()
        {
            Quest_number.Clear();
            Quests.Clear();
            Answer1.Clear();
            Answer2.Clear();
            Answer3.Clear();
            Answer4.Clear();
            RightAnswer.Clear();
        }

        // Vor
        public Tuple<string, string, string, string, string, string, string> next_quest()
        {
                        
            if (text_counter != 0)
            {
                if (next_counter < max_db )
                {
                    next_counter += 1;
                }
                else if (next_counter > max_db)
                {
                    next_counter = max_db;
                }
                else
                {
                    
                }
            }                     
                 
            string first_number = Quest_number[next_counter];
            string first_quest = Quests[next_counter];
            string first_answer = Answer1[next_counter];
            string second_answer = Answer2[next_counter];
            string third_answer = Answer3[next_counter];
            string four_answer = Answer4[next_counter];
            string right_answer = RightAnswer[next_counter];
       
            var all_answers = Tuple.Create<string, string, string, string, string, string, string>(first_number, first_quest, first_answer, second_answer, third_answer,
            four_answer, right_answer);

            text_counter += 1;

            return all_answers;   
        }

        // Zurück
        public Tuple<string, string, string, string, string, string, string> last_quest()
        {
            
            if (next_counter > 0)
            {
                next_counter -= 1;
            }
            else if (next_counter == 0 ^ next_counter < 0)
            {
                next_counter = 0;
            }
            else
            {

            }

            string first_number = Quest_number[next_counter];
            string first_quest = Quests[next_counter];
            string first_answer = Answer1[next_counter];
            string second_answer = Answer2[next_counter];
            string third_answer = Answer3[next_counter];
            string four_answer = Answer4[next_counter];
            string right_answer = RightAnswer[next_counter];

            var all_answers = Tuple.Create<string, string, string, string, string, string, string>(first_number, first_quest, first_answer, second_answer, third_answer,
            four_answer, right_answer);

            return all_answers;
        }             
        
        // Umbenennung
        public string give_db_name()
        {
            if (db_name == "it_sicherheit")
            {
                db_name = "IT Sicherheit";
            }
            else if (db_name == "it_systeme")
            {
                db_name = "IT Systeme";
            }
            else if (db_name == "programmieren")
            {
                db_name = "Programmieren";
            }
            else if (db_name == "datenbanken")
            {
                db_name = "Datenbanken";
            }
            else if (db_name == "cyberphysischesysteme")
            {
                db_name = "Cyberphysischesysteme";
            }
            else if (db_name == "ipv4")
            {
                db_name = "IPv4";
            }
            else if (db_name == "ipv6")
            {
                db_name = "IPv6";
            }
            else if (db_name == "firewall")
            {
                db_name = "Firewall";
            }
            else if (db_name == "tcpip")
            {
                db_name = "TCP/IP";
            }
            else if (db_name == "routing")
            {
                db_name = "Routing";
            }
            else if (db_name == "wiso")
            {
                db_name = "WISO";
            }
            else if (db_name == "arbeitsrecht")
            {
                db_name = "Arbeitsrecht";
            }
            else if (db_name == "kalkulationen")
            {
                db_name = "Kalkulationen";
            }
            else if (db_name == "marketing")
            {
                db_name = "Marketing";
            }
            else if (db_name == "organisationslehre")
            {
                db_name = "Organisationslehre";
            }
            else if (db_name == "projektmanagement")
            {
                db_name = "Projektmanagement";
            }
            else if (db_name == "rechtsformen")
            {
                db_name = "Rechtsformen";
            }
            return db_name;
        }
    }
}
