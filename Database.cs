using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
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
        private int next_counter = -1;
        private int max_db;

        public static List<String> Quest_number = new List<string>();
        public static List<String> Quests = new List<string>();        
        public static List<String> Answer1 = new List<string>();
        public static List<String> Answer2 = new List<string>();
        public static List<String> Answer3 = new List<string>();
        public static List<String> Answer4 = new List<string>();
        public static List<String> RightAnswer = new List<string>();
        
        

        public void ReadDatabase(string database_name)
        {            
            SQLiteConnection new_db_connection = new SQLiteConnection(@"URI=file:C:\Development\C#\lern-Quiz\Lern-Quiz\Quizdatabase.db");
            new_db_connection.Open();

            get_quest = String.Format("SELECT * FROM {0} ", database_name);
               
            SQLiteCommand give_the_quest = new SQLiteCommand(get_quest, new_db_connection);
                
            SQLiteDataReader rdr_quest = give_the_quest.ExecuteReader();
                
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

        public int Read_Count_Of_Db(string database_name)
        {   
                        
            SQLiteConnection new_db_connection = new SQLiteConnection(@"URI=file:C:\Development\C#\lern-Quiz\Lern-Quiz\Quizdatabase.db");
            new_db_connection.Open();

            
            get_count = String.Format("SELECT COUNT(Frage) FROM {0}", database_name);
            SQLiteCommand give_the_count = new SQLiteCommand(get_count, new_db_connection);
            Int32 rdr_count = Convert.ToInt32(give_the_count.ExecuteScalar());

            new_db_connection.Close();

            max_db = rdr_count;

            return rdr_count;
        }


        public Tuple<string, string, string, string, string, string, string> next_quest()
        {

            Console.WriteLine("this is in next : {0}",next_counter);

            if (next_counter + 1 != max_db)
            {
                next_counter += 1;
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

        public Tuple<string, string, string, string, string, string, string> last_quest()
        {

            Console.WriteLine("this is in last : {0}", next_counter);
                        
            if (next_counter - 1 >= 0)
            {
             next_counter -= 1;
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
           
    }
}
