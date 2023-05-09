/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

 double Akkerman( double m, double n)
{
    if (m > 0 && n > 0)
    
        return Akkerman( n - 1, Akkerman(m, n-1));
    
    else if (m > 0 && n == 0)
    
        return Akkerman(m - 1, 1);
    
    else if(m == 0) n=n+1; 
    
        return n;
}

System.Console.WriteLine(Akkerman(0,2)); 

 
 
 