// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;//is this good?? not professionally.

enum Sandwiches
{
    Burger,
    Hoagie,
    Hotdog,
    Taco,
    Cuban
};
//forward declaration
void PrintLunchOrder(Sandwiches order);

int main()
{
    Sandwiches lunch = Sandwiches::Hotdog;
    PrintLunchOrder(lunch);

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
    num = nullptr;
    if(num != nullptr)
        cout << *num << "\n";

    //seed the random # generator
    srand(time(NULL));
    //get a random #
    int random = rand();//range of 0-RAND_MAX
    int grade = rand() % 101; //range 0-100

    //templates
    vector<int> highScores;//stack instance
    highScores.push_back(rand());
    highScores.push_back(rand());
    highScores.push_back(rand());
    highScores.push_back(rand());
    highScores.push_back(rand());
    cout << "--------HIGH SCORES----------\n";
    for (size_t i = 0; i < highScores.size(); i++)
    {
        cout << highScores[i] << "\n";
    }
}
void PrintLunchOrder(Sandwiches order)
{
    double price = 0;
    switch (order)
    {
    case Burger:
        price = 8.99;
        break;
    case Hoagie:
        price = 10.99;
        break;
    case Hotdog:
        price = 6.99;
        break;
    case Taco:
        price = 4.99;
        break;
    case Cuban:
        price = 12.99;
        break;
    default:
        break;
    }
    cout << order << " costs " << price << "\n";
}