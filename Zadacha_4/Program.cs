int a = -5, b = -7, c = -30;
if (a > b)
    {
       if (a > c) 
        {
            Console.Write($" Максимальное число {a}");
        }
        else
        {
            Console.Write($" Максимальное число {c}");
        }
    }
 else
    {
        if (b > c) 
            Console.Write($" Максимальное число {b}");
        else
        {
            Console.Write($" Максимальное число {c}");
        }
    }