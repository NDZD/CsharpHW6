// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string CrossPoint(double b1, double k1, double b2, double k2)
    {
        double x;
        double y;
        string a = String.Empty;
        string b = String.Empty;
        if (k1 == k2)
        {
            System.Console.WriteLine("Прямые параллельны!");
        }


        else if ((k1 == k2) && (b1 == b2))
        {
            System.Console.WriteLine("Прямые совпадают!");
        }

        else 
        {
            x = (b2 - b1)/ (k1 - k2);
            y = k2 * (b2 - b1)/ (k1 - k2) + b2;
            a = Convert.ToString(x);
            b = Convert.ToString(y);
        }
        return ($"({a} ; {b})");
    }
    System.Console.WriteLine(CrossPoint(2, 4, 3, 5));