using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private int totalMarks;
        private int possibleMarks;
                       private string submitterName;
        private string letterGrade;

        public HomeworkAssignment()
        {

        }
        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;


        }
        public int TotalMarks
        {
            get { return totalMarks; }
            set { totalMarks = value;
                calculateLetterGrade(value);
            }
        }

        public int PossibleMarks
        {
            get { return possibleMarks; }
           
        }

        public string SubmitterName
        {
            get { return submitterName; }
            set { submitterName = value; }
        }
        public string LetterGrade
        {
            get { return letterGrade; }
          
         
        }

        public void calculateLetterGrade(int value)
        {
           
            if (TotalMarks > 100 || TotalMarks < 0) letterGrade = "wrong marks";
            if (TotalMarks >= 90) letterGrade = "A";
            else if (TotalMarks >= 80 && TotalMarks <= 89) letterGrade = "B";
            else if (TotalMarks >= 70 && TotalMarks <= 79) letterGrade = "C";
            else if (TotalMarks >= 60 && TotalMarks <= 69) letterGrade = "D";
            else letterGrade = "F";




        }

    }
}
