using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TF : Question
    {


        public TF(string question, List<string> choice, List<int> key) : base(question, choice, key)
        {
           
        }

        public override bool CheckAnswer(List<int> guess)
        {
            return guess[0] == Canswer[0];
        }
    }
}
