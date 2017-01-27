using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        private int currentLevel=1;
        private int numberOfLevels;
        private bool doorIsOpen;

        public int CurrentLevel
        {
            get { return currentLevel; }
        }
        public int NumberOfLevels
        {
            get { return numberOfLevels; }
        }

        public bool DoorIsOpen
        {
            get { return doorIsOpen; }
        }

        public Elevator() { }
        public Elevator(int totalNumberOffloors)
        {
            this.numberOfLevels = totalNumberOffloors;
        }

        public void OpenDoor() {
            doorIsOpen = true;

        }
        public void CloseDoor()
        {
            doorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (!doorIsOpen&&desiredFloor<= numberOfLevels&&desiredFloor>currentLevel)
            {
                currentLevel = desiredFloor;

            }

          }
        public void GoDown(int desiredFloor)
        {
            if (!doorIsOpen && desiredFloor >= 1&&desiredFloor<currentLevel)
            {
                currentLevel = desiredFloor;

            }
        }


    }

}
