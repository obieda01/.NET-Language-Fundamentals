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
        
        // properties 

        public string TypeOfFruit
        {
            get { return typeOfFruit; }
        }
        public int PiecesOfFruitLeft
        {
            get { return piecesOfFruitLeft; }
        }

        // constructors 
        public FruitTree()
        {

        }
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
            this.piecesOfFruitLeft = startingPiecesOfFruit;
        }

        // Methods 
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (numberOfPiecesToRemove <= PiecesOfFruitLeft)
            {
                this.piecesOfFruitLeft-= numberOfPiecesToRemove;
                return true;
            }
            else return false;
        }
    }
}
