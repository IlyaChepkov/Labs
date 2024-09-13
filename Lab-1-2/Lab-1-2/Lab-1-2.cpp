// Lab-1-2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.

#include <iostream>
#include <cmath>
using namespace std;


int main(int argc, char* argv[])
{
    bool isHuman = false;

    setlocale(LC_ALL, "");

    // подключение пользовательского интерфейса

    if (argc <= 1 || strcmp(argv[1], "false") != 0)
    {
        cout << "Введите число - количество чисел в последовательности.\n";
        isHuman = true;
    }

    // объявление переменных

    int n;
    float avd;
    int degreeCount = 0;
    int odd5Count = 0;
    int prevExcCount = 0;
    int min;
    int max;
    int prev = -1;
    int prevPrev = -1;
    int current;

    cin >> n;
    if (isHuman)
    {
        cout << "Введите число\n";
    }
    cin >> current;

    min = current;
    max = current;
    avd = current;

    for (int i = 0; i < n; i++)
    {
        float log = log2(current);

        // проверка на простое число

        if (current % 2 != 0 || current == 2 && current != 1)
        {
            bool marker = true;
            for (int i = 3; i < sqrt(current); i += 2)
            {
                if (current % i == 0)
                {
                    marker = false;
                    break;
                }
            }
            if (marker)
            {
                cout << current;
                if (isHuman)
                {
                    cout << "\nЧисло простое\n";
                }
                
            }
            else if (isHuman)
            {
                cout << "Число сложное\n";
            }
        }
        else if (isHuman)
        {
            cout << "Число сложное\n";
        }

        // проверка на степень двойки

        if (log - (int)log == 0)
        {
            cout << current;
            degreeCount++;
        }

        // проверка на кратность 5

        if (current % 5 == 0)
        {
            odd5Count++;
        }

        // проверка на 6 пункт

        if (prevPrev != -1)
        {
            if (prevPrev + prev < current)
            {
                prevExcCount++;
            }
        }

        // поиск минимума

        if (min > current)
        {
            min = current;
        }

        // поиск максимума

        if (max < current)
        {
            max = current;
        }

        // запись нового значения в current, обновление значения в prev-ах

        avd += current;
        prevPrev = prev;
        prev = current;
        if (n - 1 != i)
        {
            cin >> current;
        }
    }

    // вывод всех значений


    if (isHuman)
    {
        cout << "Среднее арифметическое - ";
        cout << avd / n;
        cout << "\nРазница минимума и максимума - ";
        cout << max - min;
        cout << "\nКол-во чисел кратных 5 - ";
        cout << odd5Count;
        cout << "\nКол-во чисел являющимися степенью 2 - ";
        cout << degreeCount;
        cout << "\nКол-во чисел больше суммы двух предыдущих - ";
        cout << prevExcCount;
    }
    else
    {
        cout << avd / n;
        cout << max - min;
        cout << odd5Count;
        cout << degreeCount;
        cout << prevExcCount;
    }
    
}
