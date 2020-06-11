using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Check : Question
    {


        public Check(string question, List<string> choice, List<int> key) : base(question, choice, key)
        {
 
        }


        public override bool CheckAnswer(List<int> guess)
        {
            if (guess.Count != Canswer.Count)
            {
                return false;
            }
            else
            {
                foreach (int i in guess)
                {
                    if (!Canswer.Contains(i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }



    }
}
