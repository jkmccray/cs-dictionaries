using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========== Practice: Dictionary of Words ==========

            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("No-J", "someone who didn't do it, but is being pronounced guilty anyway. He is the opposite of OJ, who did it, but got off scott free.");
            wordsAndDefinitions.Add("Sunday scaries", "The feeling of dread knowing that Monday is going to be rough.");
            wordsAndDefinitions.Add("Kraft Dinner", "What they call Macaroni & Cheese in Canada. The box actually says 'Kraft Dinner' where it would normally say 'Macaroni & Cheese'. In Canada they accept this as perfectly normal.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            // Console.WriteLine($"Sunday Scaries: {wordsAndDefinitions["Sunday scaries"]}");
            // Console.WriteLine("-------------------");
            // Console.WriteLine($"Kraft Dinner: {wordsAndDefinitions["Kraft Dinner"]}");

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            //     Console.WriteLine("-------------------");
            // }


            // ========== Practice: List of Dictionaries about Words ==========

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "Awesome");
            excitedWord.Add("definition", "The feeling of students when they are learning C#");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "Maybe C# will be awesome soon.");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> NoJ = new Dictionary<string, string>();

            NoJ.Add("word", "No-J");
            NoJ.Add("definition", "someone who didn't do it, but is being pronounced guilty anyway. He is the opposite of OJ, who did it, but got off scott free");
            NoJ.Add("part of speech", "noun");
            NoJ.Add("example sentence", "That No-J was convicted of killing his family. But I think someone just snuck in and killed them while he slept. If you just killed your family, could you just go back to sleep?");

            dictionaryOfWords.Add(NoJ);

            Dictionary<string, string> SundayScaries = new Dictionary<string, string>();
            SundayScaries.Add("word", "Sunday Scaries");
            SundayScaries.Add("definition", "The feeling of dread knowing that Monday is going to be rough");
            SundayScaries.Add("part of speech", "noun");
            SundayScaries.Add("example sentence", "Wow I haven't seen Chad all day! He must have a bad case of the Sunday Scaries");

            dictionaryOfWords.Add(SundayScaries);

            Dictionary<string, string> KraftDinner = new Dictionary<string, string>();
            KraftDinner.Add("word", "Kraft Dinner");
            KraftDinner.Add("definition", "What they call Macaroni & Cheese in Canada. The box actually says 'Kraft Dinner' where it would normally say 'Macaroni & Cheese'. In Canada they accept this as perfectly normal");
            KraftDinner.Add("part of speech", "noun");
            KraftDinner.Add("example sentence", "Even though Macaroni & Cheese is the all-American convenience food product, Canada consumes, per capita, more Kraft Dinner than the United States!");

            dictionaryOfWords.Add(KraftDinner);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
