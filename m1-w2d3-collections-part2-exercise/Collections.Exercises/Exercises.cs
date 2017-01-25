﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ExerciseProblems
{
    public class Exercises
    {
        /*
	    * Dictionary/Dictionary Exercises
	    */

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
        Dictionary<string, string> animalDictionary = new Dictionary<string, string>()
         {
             {  "Rhino" , "Crash" },
             { "Giraffe","Tower" },
             { "Elephant", "Herd" },
             { "Lion","Pride" },
             { "Crow","Murder" },
             { "Pigeon", "Kit" },
             {"Flamingo", "Pat" },
             { "Deer", "Herd" },
             { "Dog", "Pack" },
             { "Crocodile", "Float"}
         };

 


        public string AnimalGroupName(string animalName)
        {

            if(animalName.Length<2) return "unknown";
            string animalNameManipulated = animalName.Substring(0, 1).ToUpper() + animalName.Substring(1).ToLower();
            if (!animalDictionary.ContainsKey(animalNameManipulated)) return "unknown";
            else return animalDictionary[animalNameManipulated];
            
        }

        /*
         * Given an string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         * 
         * If the item number is empty or null, return 0.00.
         * 
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         * 
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *  
         * isItOnSale("kitchen4001") → 0.20
         * isItOnSale("") → 0.00
         * isItOnSale("GARAGE1070") → 0.15
         * isItOnSale("dungeon9999") → 0.00 
         * 
         */



        Dictionary<string, double> discountPercentage = new Dictionary<string, double>()
         {
             { "KITCHEN4001" , 0.20 },
             { "GARAGE1070", 0.15 },
             { "LIVINGROOM",  0.10 },
             { "KITCHEN6073",0.40 },
             { "BEDROOM3434", 0.60 },
             { "BATH0073", 0.15 }

         };

        public double IsItOnSale(string itemNumber)
        {
            if(itemNumber.Length<1) return 0.00;
            itemNumber = itemNumber.ToUpper();
            
            if (!discountPercentage.ContainsKey(itemNumber)) return 0.00;

            return discountPercentage[itemNumber];
        }

        /*
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         * 
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         * 
         * robPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * robPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         * 
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            if (peterPaul == null) return null;
            Dictionary<string, int> resultDictonary = peterPaul;
            if (resultDictonary["Peter"] > 0 && resultDictonary["Paul"] < 1000)
            {
                resultDictonary["Paul"] += resultDictonary["Peter"] / 2;
                resultDictonary["Peter"] /= 2;
            }
            return resultDictonary;
        }

        /*
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         * 
         * peterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * peterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         * 
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            if (peterPaul == null) return null;

            if (peterPaul["Peter"] >= 5000 && peterPaul["Paul"] >= 10000)
            {
                peterPaul.Add("PeterPaulPartnership", ((int)((peterPaul["Peter"] + peterPaul["Paul"]) * 0.25)));
                peterPaul["Peter"] = (int)(peterPaul["Peter"] * 0.75);
                peterPaul["Paul"] = (int)(peterPaul["Paul"] * 0.75);

            }
            return peterPaul;
        }

        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array, 
         * there is a key of its first character with the value of its last character.
         *
         * beginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * beginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * beginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            if (words.Length == 0) return null;

            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();

            foreach (string word in words)
            {
                if (!resultDictionary.ContainsKey(word[0].ToString()))
                {

                    resultDictionary.Add(word[0].ToString(), word[word.Length - 1].ToString());
                }
                else
                {
                    resultDictionary[word[0].ToString()] = word[word.Length - 1].ToString();
                }
            }
            return resultDictionary;
        }

        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * wordCount([]) → {}
         * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            if (words == null || words.Length == 0) return new Dictionary<string, int>();
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!resultDictionary.ContainsKey(word))
                {
                    resultDictionary.Add(word, 1);

                }
                else ++resultDictionary[word];
            }
            return resultDictionary;
        }

        /*
         * Given an array of int values, return a Dictionary<int, int> with a key for each int, with the value the 
         * number of times that int appears in the array.
         * 
         * ** The lesser known cousin of the the classic wordCount **
         * 
         * intCount([1, 99, 63, 1, 55, 77, 63, 99, 63, 44]) → {1: 2, 44: 1, 55: 1, 63: 3, 77: 1, 99:2}
         * intCount([107, 33, 107, 33, 33, 33, 106, 107]) → {33: 4, 106: 1, 107: 3}
         * intCount([]) → {}
         * 
         */
        public Dictionary<int, int> IntCount(int[] ints)
        {
            if (ints == null || ints.Length == 0) return new Dictionary<int, int>();
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

            foreach (int intNum in ints)
            {
                if (!resultDictionary.ContainsKey(intNum))
                {
                    resultDictionary.Add(intNum, 1);

                }
                else ++resultDictionary[intNum];
            }
            return resultDictionary;
        }

        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            if (words == null || words.Length == 0) return new Dictionary<string, bool>();
            Dictionary<string, bool> resultDictionary = new Dictionary<string, bool>();

            foreach (string word in words)
            {
                if (!resultDictionary.ContainsKey(word))
                {
                    resultDictionary.Add(word, false);
                }
                else
                {
                    resultDictionary[word] = true;
                }
            }
            return resultDictionary;
        }

        /*
         * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2, 
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         * 
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *  
         * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         * 
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse, 
            Dictionary<string, int> remoteWarehouse)
        {
            if (mainWarehouse == null) return remoteWarehouse;
            if (remoteWarehouse == null) return mainWarehouse;
            Dictionary<string, int> consolidateDictionary  = mainWarehouse;
            foreach (KeyValuePair<string,int> keyValue in remoteWarehouse)
            {
                if (!consolidateDictionary.ContainsKey(keyValue.Key))
                {
                    consolidateDictionary.Add(keyValue.Key, keyValue.Value);
                }
                else
                {
                    consolidateDictionary[keyValue.Key] = consolidateDictionary[keyValue.Key] + keyValue.Value;
                }
            }
            return consolidateDictionary;
        }

        /*
         * Just when you thought it was safe to get back in the water --- last2Revisited!!!!
         * 
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears 
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1. 
         * 
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.  
         * 
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *  
         * last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         * 
         */
        public Dictionary<string, int> Last2Revisted(string[] words)
        {
            if (words == null || words.Length == 0) return new Dictionary<string, int>();
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!resultDictionary.ContainsKey(word)) resultDictionary.Add(word, countDoublicate(word));
                else
                {
                    resultDictionary[word] = countDoublicate(word);
                }
            }
            return resultDictionary;
        }

        public int countDoublicate(string word)
        {
            if (word.Length < 4) return 0;
            int count = 0;
            string last2Char = word.Substring(word.Length - 2, 2);
            for (int i = 0; i < word.Length-2; i++)
            {
                if (word[i] == last2Char[0] && word[i + 1] == last2Char[1]) count++;
            }
            return count;
        }
    }
}
