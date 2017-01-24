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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            if (listOne == null && listTwo == null) return null;
            if (listOne.Count == 0) return listTwo;
            if (listTwo.Count == 0) return listOne;
            List<int> resultList = new List<int>();

            if (listOne.Count == listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    resultList.Add(listOne[i]);
                    resultList.Add(listTwo[i]);

                }
            }
            else
            {
                int shortList = listOne.Count < listTwo.Count ? listOne.Count : listTwo.Count;
                for (int i = 0; i < shortList; i++)
                {
                    resultList.Add(listOne[i]);
                    resultList.Add(listTwo[i]);
                }
                if (listOne.Count < listTwo.Count)
                {
                    for (int i = shortList; i < listTwo.Count; i++)
                    {
                        resultList.Add(listTwo[i]);

                    }

                }
                else
                {
                    for(int i = shortList; i < listOne.Count; i++)
                    {
                        resultList.Add(listOne[i]);

                    }
                }
            }
            return resultList;
        }
    }
}
