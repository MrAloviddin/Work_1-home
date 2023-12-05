using Work_1_home;

string[] name = Enum.GetNames(typeof(Month));
int[] number = (int[])Enum.GetValues(typeof(Month));

Console.WriteLine("1)Tug'ulgan yil/oy/kun kiriting: ");
Console.WriteLine("2)Hozirdan boshlab qolgan oylarni chiqarish");
Console.WriteLine("3)Hozirgi oyning nomini olish");
belgi:
Console.Write("command: ");
int command = Convert.ToInt32(Console.ReadLine());
if (command == 1)
{

    Console.Write("yil/oy/kun : ");
    string? birthData = Console.ReadLine();
    string[]? data = birthData.Split('/');
    for (int i = 0; i < number.Length; i++)
    {
        if (Convert.ToInt32(data[1]) == number[i])
        {
            Console.WriteLine($"Siz tugulgan oy: {name[i]}");
        }

    }


}
if (command == 2)
{
    int nowMonth = DateTime.Now.Month;
    for (int i = nowMonth; i <= 12; i++)
    {
        Console.WriteLine(Enum.GetName(typeof(Month), i));
    }

    Console.WriteLine();


}
if (command == 3)
{
    for (int i = 0; i < number.Length; i++)
    {
        if (DateTime.Now.Month == number[i])
        {
            Console.WriteLine(name[i]);
        }
    }

    Console.WriteLine();

}
goto belgi;