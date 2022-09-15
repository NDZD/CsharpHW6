// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int numberOfInputs()
// {
//     System.Console.WriteLine("Укажите какое количество чисел будет вводиться: ");
//     int m = Convert.ToInt32(Console.ReadLine());

//     return m;
// }




//numberOfInputs();


// int numbersGreaterZero(int n)
// {
//     int count = 0;
//     for (int i = 0; i < n; i++)
//     {
//         if (n > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

int Input()
{
    int num = 0;
while (Console.ReadLine() != "stop")
{
    num = Convert.ToInt32(Console.ReadLine());

}
return num;
}

int Count(int num)
{
    int count = 0;
    if(num > 0)
    {
        count++;
    }
    return count;
}
Count(Input());

