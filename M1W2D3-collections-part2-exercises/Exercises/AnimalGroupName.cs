using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
	public partial class Exercises
	{
		/*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
		public string AnimalGroupName(string animalName)
		{
			string result = "";
			string animalNameLower = animalName.ToLower();
			Dictionary<string, string> animalDictionary = new Dictionary<string, string>();
			animalDictionary.Add("rhino", "Crash");
			animalDictionary.Add("giraffe", "Tower");
			animalDictionary.Add("elephant", "Herd");
			animalDictionary.Add("lion", "Pride");
			animalDictionary.Add("crow", "Murder");
			animalDictionary.Add("pigeon", "Kit");
			animalDictionary.Add("flamingo", "Pat");
			animalDictionary.Add("deer", "Herd");
			animalDictionary.Add("dog", "Pack");
			if (animalDictionary.ContainsKey(animalNameLower))
			{
				result = animalDictionary[animalNameLower];
			}
			else
			{
				result = "unknown";
			}
			return result;
		}
	}
}
