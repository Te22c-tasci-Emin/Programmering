//objekt med egenskaper
//metoder
// Weapon axe = new("Axe");

// food mat = new ("food");

// int damage = axe.Attack();

// Console.WriteLine(damage);


Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchi tama = new();


Console.WriteLine("Please choose a name for your Tamagotchi!");
tama.Name = Console.ReadLine();

Console.WriteLine($"Great! {tama.Name} is a beautiful name!");

while (tama.GetAlive() == true)
{
  Console.Clear();
  tama.PrintStats();
  Console.WriteLine("Now what do you want to do?");
  Console.WriteLine($"1. Teach {tama.Name} a new word");
  Console.WriteLine($"2. Talk to {tama.Name}");
  Console.WriteLine($"3. Feed {tama.Name}");
  Console.WriteLine($"4. Do nothing");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    tama.Teach(word);
  }
  if (doWhat == "2")
  {
    tama.Hi();
  }
  if (doWhat == "3")
  {
    tama.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  tama.Tick();
  Console.WriteLine("Press Enter to continue");
  Console.ReadLine();
}

Console.WriteLine($"OH NO! {tama.Name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();


tama.Teach("Sweet bonanza");
tama.Teach("pirotz3");
tama.Teach("sigma");
tama.Teach("Lion bar");
tama.Teach("Vi drar till lion bar");
tama.Teach("Den baren den galen och den stänger klockan 2");
tama.Teach("Plankstek 99kr med EN STOR STARK");
tama.Hi();




Console.ReadLine();