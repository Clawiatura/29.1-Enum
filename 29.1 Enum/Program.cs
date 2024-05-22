using System.ComponentModel.DataAnnotations;
Console.Write("Введите порядковый номер месяца: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Enum.IsDefined(typeof(Mont), number))
{
    Mont numberMont = (Mont)number;
    Console.WriteLine($"Выбраный месяц: {numberMont}");
}
else
{
    Console.WriteLine("Недопустимый номер");
        }



for (int i = 1; i < 13; i++)
{

      Enum.GetValues(typeof(Mont));
    
        Console.WriteLine($"Выбран месяц: {i} - {Enum.GetName(typeof(Mont),i)} ");
    
}




enum Mont
{
    
    January = 1,
    February = 2,
    March = 3, 
    April = 4, 
    May = 5, 
    June = 6, 
    July = 7, 
    August = 8, 
    September = 9, 
    October = 10, 
    November = 11,
    December = 12,
}
