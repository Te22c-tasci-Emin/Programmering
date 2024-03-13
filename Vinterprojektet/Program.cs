
int kazuyaHp = 100;

int heihatchiHp = 100;

int weaponedmg = 100;

string weaponsdmg = "WDamgage";

String kazuyaName = "kazuya";
String heihatchiName = "heihatchi";

string player1 = "player12";
string player2 = "player21";

string casino = "casino";

int kazuyaAccuracy = 100;
int kazuyaWeaponDamage = 30;


int heihatchiAccuracy = 100;
int heihatchiWeaponDamage = 30;

Random generator = new Random();




start();

void start()
{


    //ska lägga till option att vara player 1 eller 2

    Console.WriteLine("choose your character");

    Console.WriteLine("Player 1");

    Console.WriteLine("Player 2");

    while (player1 != "1" && player1 != "2")
    {
        player1 = Console.ReadLine(); //denna ska göra så att den ändrar värde.


    }

    if (player1 == "1")
    {
        Console.WriteLine("Welcome to Taken7");
    }


    else if (player2 == "2")
    {
        Console.WriteLine("Welcome to Taken7");
    }




    Console.ReadLine();

    Console.WriteLine("Choose your Weapons");

    Console.WriteLine("A) = Heihatchi hairline, B) = KAzuya outfit, C) HaDOKEN");

    // läs in val

    // Om man valt a, accuracy = 45
    // Om man valt b, accuracy = 60
    // Om man inte valt, accuracy = 80


    weaponsdmg = weaponsdmg.ToLower();

    if (weaponsdmg == "a)") //player 1 
    {

        kazuyaWeaponDamage = 45;
        kazuyaAccuracy = 70;

    }

    else if (weaponsdmg == "b)")
    {
        kazuyaWeaponDamage = 30;
        kazuyaAccuracy = 15;

    }

    else if (weaponsdmg == "c)")
    {
        kazuyaAccuracy = 20;
        kazuyaWeaponDamage = 90;

    }
    Console.ReadLine();
}


// //player 2     
// if (weaponsdmg2 == "a)")
// {

// }

// else if(weaponsdmg2 == "b)")
// {

// }

// else if (weaponsdmg2 == "c)")


while (kazuyaHp > 0 && heihatchiHp > 0)
{
    Console.WriteLine("--------------- Ny Runda ----------------------");
    Console.WriteLine(@"         |    |              _.-7
           |\.-.|             ( ,(_                            
           | a a|              \\  \,
           ) ['||          _.--' \  \\
        .-'  '-''-..____.-'    ___)  )\
       F   _/-``-.__;-.-.--`--' . .' \_L_
      |   l  {~~} ,_\  '.'.      ` __.' )\
      (    -.;___,;  | '- _       :__.'( /
      | -.__ _/_.'.-'      '-._ .'      \\
      |     .'   |  -- _                 '\,
      |  \ /--,--{ .    '---.__.       .'  .'
      J  ;/ __;__]. '.-.            .-' )_/
      J  (-.     '\'. '. '-._.-.-'--._ /
      |  |  '. .' | \'. '.    ._       \
      |   \   T   |  \  '. '._  '-._    '.
      F   J   |   |  '.    .  '._   '-,_.--`
      F   \   \   F .  \    '.   '.  /
     J     \  |  J   \  '.   '.    '/
     J      '.L__|    .   \    '    |
     |   .    \  |     \   '.   '. /
     |    '    '.|      |    ,-.  (
     F   | ' ___  ',._   .  /   '. \
     F   (.'`|| (-._\ '.  \-      '-\
     \ .-'  ( L `._ '\ '._ (
     /'  |  /  '-._\      ''\
         `-'        <---- Demonen Kazuya");
    Console.WriteLine($"Demonen {kazuyaName} har nu {kazuyaHp} hp");


    int doesheyahit = generator.Next(100);
    if (doesheyahit < kazuyaAccuracy)
    {
        int heihatchidamage = generator.Next(kazuyaWeaponDamage);
        kazuyaHp -= heihatchidamage;
        kazuyaHp = Math.Max(0, kazuyaHp);
        Console.WriteLine($"{heihatchiName} Slår och gör {heihatchidamage} damage gjord, nya hp = {kazuyaHp}");
    }
    else
    {
        Console.WriteLine($"{heihatchiName} Slår och gör Missed AHHAHAHAHAHAH");
    }
    int doesKuzuaHit = generator.Next(100);
    if (doesKuzuaHit < kazuyaAccuracy)
    {
        int kazuyadamage = generator.Next(kazuyaWeaponDamage);
        heihatchiHp -= kazuyadamage;
        heihatchiHp = Math.Max(0, heihatchiHp);
        Console.WriteLine($"{kazuyaName} Slår och gör {kazuyadamage} damage gjord, nya hp = {heihatchiHp}");
        Console.WriteLine(@"                                  `$/              
           '__'                        O$               
       '_.-'                          $'              
    ''.-'`. .-':       'o      ___     ($o              
 ''.-'.-  .'   ;      ,st+.  .' , \    ($               
':_..-+''    :       'T   '^T==^;\;;-._ $\              
   ''''-,   ;       '    /  `-:-// / )$/              
        :   ;           /   /  :/ / /dP               
        :   :          /   :    )^-:_.l               
        ;    ;        /    ;    `.___, \           .-,
       :     :       :  /  ;.q$$$$$$b   \$$$p,    /  ;
       ;   :  ;      ; :   :$$$$$$$$$b   T$$$$b .'  / 
       ;   ;  :      ;   _.:$$$$$$$$$$    T$$P^''   /l 
       ;.__L_.:   .q$;  :$$$$$$$$$$$$$;_   TP .-'' / ; 
       :$$$$$$;.q$$$$$  $$$$$$$$$$$$$$$$b  / /  .' /  
        $$$$$$$$$$$$$;  $$$$$$$$P^'' '^Tb$b/   .'  :   
        :$$$$$$$$$$$$;  $$$$P^jp,      `$$_.+'    ;   
        $$$$$$$$$$$$$;  :$$$.d$$;`- _.-d$$ /     :    
        '^T$$$$$P^^'/   :$$$$$$P      d$$;/      ;    
                   :    $$$$$$P'-. .--$$P/      :     
                   ;    $$$$P'( ,    d$$:b     .$     
                   :    :$$P .-dP-'  $^'$$bqqpd$$     
                    `.   '' ' s')  .'  d$$$$$$$$'     
                      \           /;  :$$$$$$$P'      
                    _  '-, ;       '.  T$$$$P'        
                   / '-.'  :    .--.___.`^^'          
                  /      . :  .'                      
                  ),sss.  \  :  bug                   
                 : TP''Tb. ; ;                        
                 ;  Tb  dP   :                        
                 :   TbdP    ;                        
                  \   $P    /                         
                   `-.___.-''  ");

        Console.WriteLine("Press buttonis för att fortsätta.");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"{kazuyaName} Slår och gör Missed AHHAHAHAHAHAH");
    }
}

Console.WriteLine("Game over");

if (heihatchiHp <= 0 && kazuyaHp <= 0)
{
    Console.WriteLine("TIED");
}

else if (heihatchiHp <= 0)

{
    Console.WriteLine("Kazuya Wins");
}
else
{
    Console.WriteLine("Heihatchi Wins");

}


Console.ReadLine();


Console.Clear();

string s = "GG";
Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
Console.WriteLine(s);

shop();
Console.ReadLine();

Console.ReadLine();
Console.ReadLine();



void shop()
{
    System.Console.WriteLine(@"
 __________________________________________________________________________
|: : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : : |
| : : : : : : : : : : : : : : : :_________________________: : : : : : : : :|
|: : : : : : : : : : : : : : : _)                         (_ : : : : : : : |
| : : : : : : : : : : : : : : )_ :  Club 40 Gift Shoppe :  _( : : : : : : :|
|: : Elevator  : : : :__________)_________________________(__________  : : |
| _____________ : _ :/ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ\: _ :|
||  _________  | /_\ '.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.'.Z.' /_\ |
|| |    |    | |:=|=: |Flowers * Perfumes_________Lingerie * Candles| :=|=:|
|| |    |    | | : : :|   ______    _  .'         '.  _    ______   |: : : |
|| |    |    | |======| .' ,|,  '. /_\ |           | /_\ .'  ,|, '. |======|
|| |    |    |:|Lounge| | ;;;;;  | =|= |           | =|= |  ;;;;; | |Casino|
|| |    |    | |<---  | |_';;;'_n|     |  n______  |     |$_';;;'_| |  --->|
|| |    |    | |      | |_|-;-|__|     |-|_______|-|     |__|-;-|_| |      |
|| |    |    | |      | |________|     |           |     |________| |      |
|| |    |    | |      |                |           |                |      |
lc_|____|____|_|______|________________|           |________________|______|
");

    if (heihatchiHp <= 0 || kazuyaHp <= 0)

    {
        int initialCoins = 0;
        int coinsEarned = calculateCoinsEarned();
        int totalCoins = initialCoins + coinsEarned;

        Console.WriteLine($"You earned {coinsEarned} coins in this round.");
        Console.WriteLine($"Total coins: {totalCoins}");

        static int calculateCoinsEarned()
        {

            // Random generator = new Random ();
            int coinsEarned = Random.Shared.Next(1, 101);
            return coinsEarned;
        }
        Console.ReadLine();

        Console.WriteLine("There is a secret lurking.....");

        if (casino.ToLower() == "casino")
        {
            int cardsDealt = 0;
            Console.Clear();
            Casino(totalCoins);
        }

    }
}
//behöver fixa casino så man kan gamba :thumbsup:
//if player type Casino then take them to black jack table and gamba


static int Casino(int money)
{
    Console.WriteLine("YOU CHOOSE TO HIT OR RUN");
    string cardsHit = Console.ReadLine();

   
    if (cardsHit == "Hit")
    {
     int cardsDealt = Random.Shared.Next(1, 14);
     Console.WriteLine( $"Well well well... You earned {cardsDealt} well well");
    
    }

    return money;
}