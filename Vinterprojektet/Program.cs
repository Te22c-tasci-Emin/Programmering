
int kazuyaHp = 100;

int heihatchiHp = 100;

kazuyaHp = 100;

heihatchiHp = 100;

int weaponedmg = 100;

string weaponsdmg = "WDamgage";

String kazuyaName = "kazuya";
String heihatchiName = "heihatchi";

string player1 = "player12";
string player2 = "player21";

string spade = "spade";
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


while (kazuyaHp > 0 && heihatchiHp > 0) //om kazuyas hp är över 0 så spelas skripten under
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


    int doesheyahit = generator.Next(100);  //hans accuracy/bådas accuracy
    if (doesheyahit < kazuyaAccuracy) // accuracy större änhit
    {
        int heihatchidamage = generator.Next(kazuyaWeaponDamage); //beroende på vapnet så gör man olika mycket dmg och olika mycket accuracy 
        kazuyaHp -= heihatchidamage; //när kazuya tar dmg från heihatchi dra av hp från kazuya
        kazuyaHp = Math.Max(0, kazuyaHp); // returnar största värde av antingen 0 eller kazuya hp
        Console.WriteLine($"{heihatchiName} Slår och gör {heihatchidamage} damage gjord, nya hp = {kazuyaHp}"); 
    }
    else
    {
        Console.WriteLine($"{heihatchiName} Slår och gör Missed AHHAHAHAHAHAH");
    }
    int doesKuzuaHit = generator.Next(100); //detta är samma som koden ovanför
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

    if (heihatchiHp <= 0 || kazuyaHp <= 0) //om heihatchi hp är mindre eller lika med 0 (det betyder att han kan ta dmg och gå -10 även då kommer scripten fungera) //detsamma gäller för kazuya

    {
        int initialCoins = 0; //pengar man börjar med = 0
        int coinsEarned = calculateCoinsEarned(); //pengar man tjänar ska plussas på
        int totalCoins = initialCoins + coinsEarned; //totala pengar 

        Console.WriteLine($"You earned {coinsEarned} coins in this round."); //den skriver hur mycket pengar man tjänat under denna runda
        Console.WriteLine($"Total coins: {totalCoins}"); //totala ammount


        Console.ReadLine();

        Console.WriteLine("There is a secret lurking....."); //hidden message

        //casin

        if (casino.ToLower() == "casino") //om man skriver casino oavsett om man skriver 
        {
            int cardsDealt = 0; //börjar slänga kort från noll. så början är noll
            Console.Clear(); //tömmer skärmen
            Casino(totalCoins); //skriver totala 

        }

    }
}
//behöver fixa casino så man kan gamba :thumbsup:
//if player type Casino then take them to black jack table and gamba


static int Casino(int money)
{
    Console.WriteLine("YOU CHOOSE TO HIT OR RUN"); //skriver om 
    string cardsHit = Console.ReadLine(); //skriver hur mycket man hittat


    if (cardsHit == "Hit") //om man skriver hit
    {
        int cardsDealt = Random.Shared.Next(1, 11); //kort(kan dra mellan 1 till 11)
        Console.WriteLine($"Well well well... You earned {cardsDealt} well well"); //siffran man dragit

    }

    return money; //money earned eller lost
}


static int calculateCoinsEarned()
{

    // Random generator = new Random ();
    int coinsEarned = Random.Shared.Next(1, 101);
    return coinsEarned;
}


//bool spade = false; 

//if (hit = 11)
//{
 //   spade = true;
//}

//måste fixa så att det inte blir en shikane utan det blir en straight.
//om man rullar en spade så får man fortfarande option/möjlighet att köra igen för hit eller skip