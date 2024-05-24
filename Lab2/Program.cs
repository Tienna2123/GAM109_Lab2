using System;

public class UserData
{
    public int id;
    public string userName;
    public int level;
    public UserData(int id, string userName, int level)
    {
        this.id = id;
        this.userName = userName;
        this.level = level;
    }
    public void ShowData()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("User Name: " + userName);
        Console.WriteLine("Level: " + level);
    }
    public void ShowData(string name, dynamic attribute)
    {
        Console.WriteLine(name + ": " + attribute);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bai 1a");
        var x = 10;
        void bai1a()
        {
            Console.WriteLine("x = " + x);
        }
        bai1a();
        Console.WriteLine();

        Console.WriteLine("Bai 1b");
        void getDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }
        void bai1b()
        {
            getDetail(10);
            getDetail("Game");

        }
        bai1b();
        Console.WriteLine();


        Console.WriteLine("Bai 1c");
        UserData userData = new UserData(0, "first player", 10);
        userData.ShowData("level", userData.level);
        userData.ShowData("userName", userData.userName);
        userData.ShowData("id", userData.id);
        Console.WriteLine();


    }

}
