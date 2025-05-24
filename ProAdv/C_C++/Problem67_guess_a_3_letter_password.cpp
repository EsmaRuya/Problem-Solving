#include <iostream>
#include <string>
using namespace std;
/*
Write a program to guess a 3-Letter Password (all capital)
*/

string ReadPassword()
{
    string password = "";
    cout << "Enter your password: ";
    cin >> password;
    return password;
}

bool geussPassword(string password)
{
    string word = "";
    int counter = 0;
    
       for (int i = 65; i <= 90; i++)
       {
           for (int j = 65; j <= 90; j++)
           {
               for (int k = 65; k <= 90; k++)
               {
                   word = word + char (i);
                   word = word + char (j);
                   word = word + char (k);
                   
                   counter++;
                   cout << "Trial [" << counter << "] : " << word << endl;
                   
                   if (password == word)
                   {
                       cout << "\nPassorw is " << word 
                            << "\nfound after " << counter << " Trial(s)." << endl;
                            return true;
                   }
                   word = "";
               }
           }
       }
       return false;
}

int main()
{
    geussPassword(ReadPassword());
    return 0;
}