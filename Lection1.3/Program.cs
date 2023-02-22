// Функции (Методы) продолжение, и цикл for.
//Виды методов
// Вид 1. Не возвращают и не принимают

/*void Method1()
{
    Console.WriteLine("Какой либо текст...");
}
Method1(); */ // Вызываем метод

// Вид 2. Принимают, но не возвращают

/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Какой то текст..."); */

/* void Method21(string msg, int count)
 {
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
 }
 Method21("Text", 3); */
 // Так же можно указыать именованные аргументы (тогда последовательность указания не обязательна)- Method21(count: 3, msg: "Text");

//Вид 3. Возвращают, но не принимают.

/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/

//Вид 4. Принимают и возвращают.

/* string Method4(int count, string Text)
{
    int i = 0;
    string result = string.Empty;
    
    while(i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4(3, "qwerty\t\t\t"); // \t - Делает пробел.
Console.WriteLine(res); */

// Цикл for:

/*string Method4(int count, string Text)
{
    string result = string.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + Text;  
    }
    return result;
}
string res = Method4(3, "qwerty\t\t\t"); // \t - Делает пробел.
Console.WriteLine(res); */

// Цикл в цикле.

//Таблица умножения.
/*for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); // Такой ввод данных называется интерполяцией.
    }
    Console.WriteLine(" ");
} */

// Изменение и добавление...

/*string text = "– Я думаю, – сказал князь, улыбаясь,"
            +  "– что, ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. Вы так красноречивы."
            + "Вы дадите мне чаю?";

// srting text = "qwerty"
//               [012345]
// text[3] - покажет букву r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
         if(text[i] == oldValue) result = result + $"{newValue}";
         else result = result + $"{text[i]}";
    }
    return result;
}
Console.WriteLine(text);
Console.WriteLine(" ");
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine(" ");
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText); */


// Сортировка чисел в массиве.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length -1; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];       // эти 3 строчки обмен двух переменных местами
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
