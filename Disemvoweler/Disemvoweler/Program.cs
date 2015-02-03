using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        /// <summary>
        /// calling my function Disemvowler and inputing the assigned strings.  
        /// </summary>
        /// <param name="args">any string that you want to</param>
        static void Main(string[] args)
        {
            //assignint the strings as my input and calling the function
            Disemvoweler("Nickleback is my favorite band.  Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            
            // keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Program to take away any special char and identify the vowels and consonants.  Vowels and Consonants are entered into a string with no spaces etc. 
        /// </summary>
        /// <param name="input">any defined string</param>
        /// <returns>two strings, one with vowels, one with consonants
        /// </returns>
        public static string Disemvoweler(string input)
        {
           
           //defining the string in which the vaules of the origional string will be set
           //after it is evaulated.  

           string newStringOfVowels = "";
           string newStringOfConsonants = "";
           

            //loop to go through each letter in the input
           for (int i = 0; i < input.Length; i++)
           {
                         
               string oneCharacter = input[i].ToString().ToLower();

               //if statement to determin if a single character is a vowel.  
               if (oneCharacter == "a" || oneCharacter == "e" || oneCharacter == "i" || oneCharacter == "o" || oneCharacter == "u")
               {
                   //adds the character (determined to be a vowel) to a string  
                   newStringOfVowels += oneCharacter;
               }

               //if statement that identifys special characters.  if it is not one of them, it is a consonant. 
               else if (oneCharacter != "." && oneCharacter != "'" && oneCharacter != "," && oneCharacter != "?" && oneCharacter != "!" && oneCharacter != " ")

               {
                   //adds the consonant to the new string newStringOfConsonants    
                   newStringOfConsonants += oneCharacter;
               }

           }

            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + newStringOfConsonants);
            Console.WriteLine("Vowels Removed: " + newStringOfVowels); 
            // Return the Disemvoweled string as well for testing
            return newStringOfConsonants;
                
        }
    }
}
