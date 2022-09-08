//Показывает 3ю цифру 3х значного чила или сообщает об ошибке.
Console.Write("Введите Трехзначное число  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99)
    Console.WriteLine( "ERROR!");
else
    Console.WriteLine(Convert.ToString(n)[2]);


