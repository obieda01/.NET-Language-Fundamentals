using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {

        //properties 

        private bool isOn;
        private int currentChannel=3;
        private int currentVolume=2;

        public Television() { }
        public bool IsOn
        {
            get { return isOn; }
        }
        public int CurrentChannel
        {
            get { return currentChannel; }
        }
        public int CurrentVolume
        {
            get { return currentVolume; }
        }
        //methods 



        public void TurnOff()
        {
            isOn = false;
        }
        public void TurnOn()
        {
            isOn = true;
            currentChannel = 3;
            currentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if (isOn)
            {
                if (newChannel >= 3 && newChannel <= 18) currentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (isOn)
            {
                int temp = currentChannel + 1;
                if (temp > 18)
                {
                    currentChannel = 3;
                }
                             else { ++currentChannel; }
            }
        }
        public void ChannelDown()
        {
            if (isOn)
            {
                int temp = currentChannel - 1;
                if (temp < 3)
                {
                    currentChannel = 18;
                }
                else { --currentChannel; }
            }
        }
        public void RaiseVolume()
        {
            if (isOn)
            {
                int temp = currentVolume + 1;
                if (temp > 10)
                {
                    currentVolume = 10;
                }
                else { ++currentVolume; }
            }
        }
        public void LowerVolume()
        {
            if (isOn)
            {
                int temp = currentVolume - 1;
                if (temp <0)
                {
                    currentVolume = 0;
                }
                        else { --currentVolume; }
            }
        }
    }
}
