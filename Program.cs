using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastPlanetsList = new List<string> () { "Uranus", "Neptune" };

            planetList.AddRange (lastPlanetsList);

            planetList.Insert (1, "Earth");
            planetList.Insert (1, "Venus");

            planetList.Add ("Pluto");

            List<string> rockyPlanets = planetList.GetRange (0, 4);

            planetList.Remove ("Pluto");

            // foreach (string planet in planetList) {
            //     Console.WriteLine (planet);
            // }
            // foreach (string planet in rockyPlanets) {
            //     Console.WriteLine ($"Rocky planets = {planet}");
            // }

            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            // for (int i = 0; i < numbers.Count; i++) {
            //     // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            //     if (numbers.Contains (i)) {
            //         Console.WriteLine ($"{i} is in the list of numbers.");
            //     } else {
            //         Console.WriteLine ($"{i} is not in the list of numbers.");
            //     }

            // }

            /*Create a dictionary with key value pairs to represent words (key) and its definition (value)*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();

            // Add several more words and their definitions
            wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("Cool", "The feeling of cold but not super cold");
            wordsAndDefinitions.Add ("Warm", "The feeling of hot but not super hot");
            wordsAndDefinitions.Add ("Frustration", "The feeling of students when they are learning React");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            // Console.WriteLine (wordsAndDefinitions["Awesome"]);
            // Console.WriteLine (wordsAndDefinitions["Cool"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
            //     Console.WriteLine ($"The definition of {word.Key} is {word.Value}.");
            // }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add ("word", "excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add (excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> sadWord = new Dictionary<string, string> ();
            sadWord.Add ("word", "sad");
            sadWord.Add ("definition", "feeling or showing sorrow; unhappy");
            sadWord.Add ("part of speech", "adjective");
            sadWord.Add ("example sentence", "I am sad to learn React!");

            dictionaryOfWords.Add (sadWord);

            // Iterate your list of dictionaries and output the data

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords) {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word) {
                    Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
                }
            }

        }
    }
}