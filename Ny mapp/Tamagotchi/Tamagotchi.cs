
using System;
public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;

    private bool isAlive = true;

    public string Name;

    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach()
    {

    }

    public void Tick()
    {

    }

    public void PrintStats()
    {
        if (hunger > 0 && boredom > 0)
            Console.ReadLine($"Din Tamagotchi har {hunger}");
        Console.ReadLine($"Din Tamagotchi är {boredom}");


        else (hunger < 100 || boredom < 100)
        {
            Console.WriteLine("Din Tamagotchi har dött eller tagit livet av sig");
        }

    }

    public bool GetAlive()
    {
        return false;
    }




}



