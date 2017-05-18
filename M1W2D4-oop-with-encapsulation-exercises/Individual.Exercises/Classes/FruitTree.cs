using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
		private string typeOfFruit;
		private int piecesOfFruitLeft;

		public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
		{
			this.typeOfFruit = typeOfFruit;
			piecesOfFruitLeft = startingPiecesOfFruit;
		}
		public string TypeOfFruit
		{
			get
			{
				return typeOfFruit;
			}
		}
		public int PiecesOfFruitLeft
		{
			get
			{
				return piecesOfFruitLeft;
			}
		}
		public bool PickFruit(int numberOfPiecesToRemove)
		{
			if (piecesOfFruitLeft >= numberOfPiecesToRemove)
			{
				piecesOfFruitLeft = piecesOfFruitLeft - numberOfPiecesToRemove;
				return true;
			}
			else
			{
				return false;
			}
		}



	}
}
