﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
		private int currentLevel;
		private int numberOfLevels;
		private bool doorIsOpen;

		public Elevator(int totalNumberOffloors)
		{
			numberOfLevels = totalNumberOffloors;
			currentLevel = 1;
		}
		public int CurrentLevel
		{
			get
			{
				return currentLevel;
			}
		}
		public int NumberOfLevels
		{
			get
			{
				return numberOfLevels;
			}
		}
		public bool DoorIsOpen
		{
			get
			{
				return doorIsOpen;
			}
		}
		public void OpenDoor()
		{
			doorIsOpen = true;
		}
		public void CloseDoor()
		{
			doorIsOpen = false; 
		}
		public void GoUp(int desiredFloor)
		{
			if (desiredFloor < numberOfLevels)
			{
				doorIsOpen = false;
				currentLevel = desiredFloor;
			}
		}
		public void GoDown(int desiredFloor)
		{
			if (desiredFloor >= 1)
			{
				doorIsOpen = false;
				currentLevel = desiredFloor;
			}
		}

	}

}




