using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
		private bool isOn;
		private int currentChannel;
		private int currentVolume;


		public Television()
		{
			isOn = false;
			currentVolume = 2;
			currentChannel = 3;
		}
		public bool IsOn
		{
			get
			{
				return isOn;
			}
		}
		public int CurrentChannel
		{
			get
			{
				return currentChannel;
			}
		}
		public int CurrentVolume
		{
			get
			{
				return currentVolume;
			}
		}
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
			if (isOn && newChannel >= 3 && newChannel <= 18)
			{
				currentChannel = newChannel;
			}
		}
		public void ChannelUp()
		{
			if (isOn && currentChannel < 18)
			{
				currentChannel++;
			}
			else if(isOn && currentChannel == 18)
			{
				currentChannel = 3;
			}
		}
		public void ChannelDown()
		{
			if (isOn && currentChannel > 3)
			{
				currentChannel--;
			}
			else if (isOn && currentChannel == 3)
			{
				currentChannel = 18;
			}
		}
	
		public void RaiseVolume()
		{
			if (isOn && currentVolume < 10)
			{
				currentVolume++;
			}
		}
		public void LowerVolume()
		{
			if (isOn && currentVolume > 0)
			{
				currentVolume--;
			}
		}
	}
}


