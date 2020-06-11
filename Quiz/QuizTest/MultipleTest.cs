using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using Quiz;

namespace QuizTest
{
    [TestClass]
    public class MultipleTest
    {

        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            List<string> choices = new List<string>();
            List<int> answer = new List<int>();

            choices.Add("kevin");
            choices.Add("moe");
            choices.Add("daryn");
            answer.Add(1);

            Question mult = new Multiple("What is my name?", choices, answer);



            Assert.AreEqual("What is my name?\n" + "kevin\n" + "moe\n" + "daryn\n", mult.ToString());
            Assert.AreEqual(true, mult.CheckAnswer(answer));
                       
        }




    }
}
