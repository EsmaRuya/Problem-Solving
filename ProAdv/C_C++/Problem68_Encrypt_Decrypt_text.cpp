#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a text and encrypt it, then decrypt it.
*/

string ReadText()
{
    string text = "";
    cout << "Enter your Text: ";
    cin >> text;
    return text;
}

string Encrypt(string txt, short EncryptionKey)
{
    for (int i = 0; i < txt.length(); i++)
    {
        txt[i] = char(int(txt[i])+EncryptionKey);
    }
    return txt;
}

string Decrypt(string txt, short EncryptionKey)
{
    for (int i = 0; i < txt.length(); i++)
    {
        txt[i] = char(int(txt[i])-EncryptionKey);
    }
    return txt;
}


int main()
{
    const short EncryptionKey = 2;
    string txt = ReadText();
    cout << "\nText before encrypt : " << txt << endl;
    cout << "Text after encrypt : " <<  Encrypt(txt, EncryptionKey) << endl;
   cout << "Text after decrypt : " <<  Decrypt(Encrypt(txt, EncryptionKey),EncryptionKey) << endl;
  
    
    return 0;
}