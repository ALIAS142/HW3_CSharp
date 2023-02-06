// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 3432 -> да

System.Console.WriteLine("Enter five-digit number:     ");

string strNumberA = Console.ReadLine();
int NumberA = Convert.ToInt32(strNumberA);

int NumberB = NumberA/10000;
int NumberC = NumberA%10;
int NumberD = (NumberA%10000)/10; 

if (NumberB == NumberC) 
{
     NumberD = (NumberA%10000)/10; 
}

    int result = ((NumberA%10000) - (NumberA%10)) / 10;
    int result2 = result/100;
    int result3 = result%10;

if (result2 == result3)
{
    System.Console.WriteLine("Its a palindrom");
}
else {
    System.Console.WriteLine("Its not a palindrom");
}









 

