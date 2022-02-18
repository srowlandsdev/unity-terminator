using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Terminator.Export;

namespace Terminator.Logic
{
    public class TermNameLogger
    {
        TermData tData = new();

        public void TNameChecker(string path)
        {
            string[] files = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

            //Construct a new Dict for storing the terms
            Dictionary<string, int> terms = new();

            foreach(string s in files)
            {
                Debug.Log($"Checking file {s}");

                //Split the path of the file into elements
                string[] elements = s.Split('\\');

                foreach(string e in elements)
                {
                    Debug.Log($"File:{s} || Element: {e}");

                    if (!terms.ContainsKey(e))
                    {
                        Term newTerm = new()
                        {
                            term = e,
                            occurences = 0,
                            charLenth = e.Length
                        };

                        Debug.Log($"New term found in file {s}");
                        Debug.Log($"Add term {e} to Dictionary");
                        terms.Add(e, 0);
                    }

                    //For an existing term update the number of occurences in its json data


                    Debug.Log($"Encountered term match: {e}");
                    //Get key value from the Dict
                    int currentKeyValue = terms[e];

                    Debug.Log($"Incrementing count of element {e}");
                    //Update the value of a term key
                    terms[e] = currentKeyValue += 1;
                    Debug.Log($"Number of {e} occurrences = {currentKeyValue}");
                }
            }
        }
    }
}
