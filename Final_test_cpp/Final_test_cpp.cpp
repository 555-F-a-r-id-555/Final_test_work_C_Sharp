#include <iostream>
#include <cstdio>
#include <string>
#include <tchar.h>
using namespace std;

int main()
{
    // формирование и заполнение массива;
    int size, i;
    cin >> size;
    i = 0;
    string myStringArray[size];
    cout << "Enter strings: " << endl;
    while (i < size)
    {
        cin >> myStringArray[i];
        i++;
    }
    // Вычисление длины нового массива;
    int count = 0;
    for (auto item : myStringArray)
    {
        if (item.length() <= 3)
        {
            count++;
        }
    }
    // cout << "count = " << count << endl;
    // Заполнение массива;
    string newStringArray[count];
    int j = 0;
    for (auto item : myStringArray)
    {
        if (item.length() <= 3)
        {
            newStringArray[j] = item;
            j++;
        }
    }
    //---------------------------------------------
    cout << "Result: " << endl;
    cout << "[";
    for (int k = 0; k < size - 1; k++)
    {
        cout << "\"" << myStringArray[k] << "\", ";
    }
    cout << "\"" << myStringArray[size - 1] << "\""
         << "] => ";
    //---------------------------------------------
    cout << "[";
    for (int k = 0; k < count - 1; k++)
    {
        cout << "\"" << newStringArray[k] << "\", ";
    }
    cout << "\"" << newStringArray[count - 1] << "\""
         << "]";
}