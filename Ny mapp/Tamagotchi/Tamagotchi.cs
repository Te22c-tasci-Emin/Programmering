
using System.Collections.Generic;
using System.Reflection.Metadata;
using System;
using System.ComponentModel.DataAnnotations;
public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;

    private bool isAlive = true;

    public string Name;

    public void Feed()
    {
        while (hunger < 10 || boredom < 10)
        {
            hunger--;
        }
    }
    public void Hi()
    {
        int i = Random.Shared.Next(7);
        Console.WriteLine(words[i]);

        reduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{Name}] learns: {word}");
        words.Add(word);
        reduceBoredom();


    }

    public void Tick()
    {
        //om man inte matar eller leker så blir den kaput
        hunger -= 1;
        boredom -= 1;

        if (isAlive == false)
        {
            Console.Clear();
            Console.WriteLine("dog");
        }

    }

    public void PrintStats()
    {
        if (hunger > 0 && boredom > 0)
        {
            Console.WriteLine($"Din Tamagotchi har {hunger}");
            Console.WriteLine($"Din Tamagotchi är {boredom}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Din Tamagotchi har dött eller tagit livet av sig");
        }

    }

    public bool GetAlive()
    {
        return false;
    }

    private void reduceBoredom()
    {
        boredom--;

    }



}



