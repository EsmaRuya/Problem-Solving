#include <iostream>
#include <string>
using namespace std;
/*
Write a program to print all words from AAA to ZZZ
AAA
AAB
AAC
...
ZZZ
*/

void printWordsFromAAAtoZZZ()
{
    string word = "";
    
       for (int i = 65; i <= 90; i++)
       {
           for (int j = 65; j <= 90; j++)
           {
               for (int k = 65; k <= 90; k++)
               {
                   word = word + char (i);
                   word = word + char (j);
                   word = word + char (k);
                   
                   cout << word << endl;
                   
                   word = "";
               }
           }
       }
}

int main()
{
    printWordsFromAAAtoZZZ();
    return 0;
}