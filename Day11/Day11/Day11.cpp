// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;//is this good?? not professionally.

int main()
{
    //std -- namespace
    //:: -- scope resolution operator  (like "System." in C#)
    //cout -- console output stream
    //<< -- insertion operator
    std::cout << "Hello World!\n" << 5 << "\n";

    char best[] = "Batman";//adds a \0 at the end
    char meh[] = { 'A','q','u','a','m','e','h','\0'};//does NOT add \0 (null terminator)
    cout << best << "\n" << meh;
    //sizeof
    cout << "\n";
    for (size_t i = 0; i < sizeof(best)/sizeof(char); i++)
    {
        cout << best[i] << ".";
    }
    cout << "\n";

    int* num = new int(5);
    cout << *num << "\n";
    delete num;//clean up the memory
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
