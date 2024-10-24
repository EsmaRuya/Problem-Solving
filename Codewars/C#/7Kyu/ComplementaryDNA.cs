/*
Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)
"ATTGC" --> "TAACG"
"GTAT" --> "CATA"
*/

// First solution:
public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            string str = "";
            for (int i = 0; i < dna.Length; i++)
              {
                  if (dna[i] == 'A')
                        str += 'T';
              
                  if (dna[i] == 'T')
                        str += 'A';
              
                  if (dna[i] == 'C')
                        str += 'G';
              
                  if (dna[i] == 'G')
                        str += 'C';
              }
          return str;
        }
    }

// Second solution:
using System;
public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
          // Use small letters to avoid confliction while replacing characters.
          // Use lowercase letters temporarily to avoid conflicts during the replacement process.
            return dna.Replace("A", "t")
                      .Replace("T", "a")
                      .Replace("G", "c")
                      .Replace("C", "g").ToUpper();
        }
  
    }