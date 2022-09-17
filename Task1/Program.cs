// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Input()
{
    int count = 0;
    //int num = 0;
    string str = String.Empty;
while (true)
{
    str = Console.ReadLine();
        if(str == "stop")
        {
            break;
        }
    
        else if(Convert.ToInt32(str) > 0)
        {
        count++;
        
        }
    
}
return count;
}


System.Console.WriteLine(Input());
