using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
    public class Quiz
    {
        public List<Question> questions;

        public Quiz( List<Question> q)
        {
            questions = q;
        }

        public Quiz()
        {
            this.GenerateQuestions();
        }


        public void GenerateQuestions()
        {
            questions = new List<Question>();
            List<string> choices = new List<string>();
            List<int> answer1 = new List<int>();
            List<int> answer2 = new List<int>();
            List<int> answer3 = new List<int>();
            List<int> answer4 = new List<int>();
            List<int> answer5 = new List<int>();
            List<int> answer6 = new List<int>();
            List<string> tf = new List<string>();
            tf.Add("True");
            tf.Add("False");
            choices.Add("kevin");
            choices.Add("moe");
            choices.Add("daryn");
            answer1.Add(1);
            answer2.Add(2);
            answer3.Add(2);
            answer4.Add(1);
            answer5.Add(1);
            answer5.Add(3);
            answer6.Add(2);
            answer6.Add(3);

            Question mult1 = new Multiple("What is my name?", choices, answer1);
            Question mult2 = new Multiple("Who is my TA?", choices, answer2);
            Question tf1 = new TF("the sky is green", tf, answer3);
            Question tf2 = new TF("you're a silly goose", tf, answer4);
            Question check1 = new Check("Who's a launch code student", choices, answer5);
            Question check2 = new Check("Who does not live in Bristow", choices, answer6);

            questions.Add(mult1);
            questions.Add(mult2);
            questions.Add(tf1);
            questions.Add(tf2);
            questions.Add(check1);
            questions.Add(check2);
        }

        public void run()
        {
            int correct = 0;
            int total = questions.Count;
            string s = "";
            List<int> response = new List<int>();

            foreach( Question q in questions)
            {
                Console.WriteLine(q.ToString());
                s = Console.ReadLine();
                
                for (int i = 0; i < s.Count(); i += 2)
                {
                    response.Add(int.Parse(s.Substring(i,1)));
                }
                
                if( q.CheckAnswer(response))
                {
                    correct++;
                }
                response.Clear();
                
            }

            Console.WriteLine("You got " + correct + " out of " + total + " questions correct!");

           
        }

    }


}
