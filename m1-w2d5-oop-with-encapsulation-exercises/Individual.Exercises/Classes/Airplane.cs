using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private int bookedFirstClassSeats;
       
        private int totalFirstClassSeats;
        private int bookedCoachSeats;  
        private int totalCoachSeats;
        private string planeNumber;

        // Properties 
        
        public int BookedFirstClassSeats
        {
            get { return bookedFirstClassSeats; }
        }
        public int AvailableFirstClassSeats
        {
            get { return TotalFirstClassSeats - BookedFirstClassSeats; }
        }

        public int TotalFirstClassSeats
        {
            get { return totalFirstClassSeats; }
        }


        public int BookedCoachSeats
        {
            get { return bookedCoachSeats; }
        }
        public int AvailableCoachSeats
        {
            get { return TotalCoachSeats - BookedCoachSeats; }
        }
        public int TotalCoachSeats
        {
            get { return totalCoachSeats; }
        }
        public string PlaneNumber
        {
            get { return planeNumber; }
        }



        //Constructors

        public Airplane() { } 
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalNumberOfSeats <= AvailableFirstClassSeats)
                {
                    this.bookedFirstClassSeats+= totalNumberOfSeats;
                    
                    return true;
                }
                else return false;
            }
            else
            {
                if (totalNumberOfSeats <= AvailableCoachSeats)
                {
                    this.bookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                else return false;
            }
        }



    }
}
