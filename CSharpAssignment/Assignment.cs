using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment;

namespace CSharpAssignment
{
    public class Assignment
    {
        static void Main()
        {

            #region Assigning Objects for Question Classes

            Question1 q1 = new Question1();

            Question2 q2 = new Question2();

            Question3 q3 = new Question3();

            Question4 q4 = new Question4();

            Question5 q5 = new Question5();

            Question6 q6 = new Question6();
            #endregion

            #region Calling Methods
            //Assignment Question 1
            q1.answer1();

            //Assignment Question 2
            q2.answer2();

            //Assignment Question 3
            q3.answer3();

            //Assignment Question 4
            q4.answer4();

            //Assignment Question 5
            q5.answer5();

            //Assignment Question 6
            q6.answer6(); 
            #endregion
            
            Console.Read();
        }
    }
}

