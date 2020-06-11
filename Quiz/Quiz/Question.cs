using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public string Quest; 
        public List<string> Choices;
        public List<int> Canswer;

        public Question (string question , List<string> choice, List<int> key)
        {
            Quest = question;
            Choices = choice;
            Canswer = key;
        }

        public Question()
        {
            Quest = "What is the meaning of life?";
        }

        public abstract bool CheckAnswer(List<int> guess);

        public override string ToString()
        {
            string output = Quest + "\n";
            int count = 1;

            foreach( string i in Choices)
            {
                output += count.ToString()+ ".  " + i+"\n";
                count++;
            }

            return output;
        }
    }
}
