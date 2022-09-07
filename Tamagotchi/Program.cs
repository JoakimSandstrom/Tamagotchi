Tamagotchi tama = new Tamagotchi();
int[] time = new int[2];
string newWord;
int i = 0;
time[0]=1;
time[1]=1;


//Name The Tamagotchi
Console.WriteLine("Name Your Tamagotchi: ");
tama.name = Console.ReadLine();
Console.WriteLine("Your Tamagotchis Name Is "+tama.name);
Console.WriteLine("Press Enter To Continue...");
Console.ReadLine();


// Main Program
while(i==0)
{
    // Display Homescreen/Menu
    Console.Clear();
    Home(tama, time);

    // Choose What To Do
    switch(Console.ReadLine())
    {
    case "1":   // Teach New Word
        Console.Clear();
        Console.WriteLine("What Word Do You Want To Teach "+tama.name+"?");
        newWord = Console.ReadLine();
        if(newWord == null)
        {
            newWord = "Stupid";
        }
        tama.Teach(newWord);
        Console.Clear();
        Console.WriteLine(tama.name+" Learned To Say "+newWord);
        break;

    case "2":   // Say 
        string word = tama.Hi();
        if(word==null)
        {
            Console.WriteLine(tama.name+" Is Not Smart Enough To Speak. Try Teaching It A Word Or Two First");
            tama.hunger--;
            tama.boredom--;
            time[1]--;
        }
        else
        {
            Console.WriteLine("You Said Hi To "+tama.name);
            Console.WriteLine(tama.name+" Says "+word);
        }
        
        break;
    case "3":   // Feed
        Console.WriteLine("You Feed "+tama.name+"...");
        tama.Feed();
        if(tama.hunger<5)
        {
            Console.WriteLine(tama.name+" Seems Satisfied... For Now...");
        }
        else
        {
            Console.WriteLine(tama.name+" Enjoyed The Meel... But It Seems They Are Still Hungry...");
        }
        break;
    case "4":   // Do Nothing
        Console.WriteLine("You Selfishly Spent An Hour Without Taking Care Of "+tama.name+".");
        break;
    default:    // Error Message
        Console.WriteLine("Oops, The Program Could Not Recognize Your Input. Press Enter To Try Again...");
        time[1]--;
        tama.boredom--;
        tama.hunger--;
        break;
    }

    Console.WriteLine("Press Enter To Continue...");
    Console.ReadLine();

    // Pass Time
    if(time[1]==10)
    {   // Go To Next Day
        time[0]++;
        time[1]=1;
        tama.Sleep();

        if(tama.hunger>=15)
        {
            Console.WriteLine(tama.name+" Is Starving... If You Don't Feed Them Soon Something Unfortunate Might Happen...");
        }
        if(tama.boredom>=15)
        {
            Console.WriteLine(tama.name+" Is Bored Out Of Their Mind... If You Don't Play With Them Something Unfortunate Might Happen...");
        }
        if(tama.hunger>=20)
        {
            Console.WriteLine(tama.name+" Became To Hungry And Escaped... They Now Feed On The Souls Of The Innocent...");
            Console.WriteLine("GAME OVER!");
            i++;
        }
        if(tama.boredom>=20)
        {
            Console.WriteLine(tama.name+" Became To Bored And Escaped... They Found The Joy That You Could Not Give Them In Causing Minor Inconviniences For People All Over The World...");
            Console.WriteLine("GAME OVER!");
            i++;
        }
        Console.Clear();
        Console.WriteLine("Day "+time[0]+" Is Over, Time To Sleep...");
        Console.WriteLine("Now Starts Day "+time[0]+"!");

        Console.WriteLine("Press Enter To Continue...");
        Console.ReadLine();
    }
    else
    {   // Add An Hour
        time[1]++;
        tama.Tick();

        if(tama.hunger>=15)
        {
            Console.WriteLine(tama.name+" Is Starving... If You Don't Feed Them Soon Something Unfortunate Might Happen...");
        }
        if(tama.boredom>=15)
        {
            Console.WriteLine(tama.name+" Is Bored Out Of Their Mind... If You Don't Play With Them Something Unfortunate Might Happen...");
        }
        if(tama.hunger>=20)
        {
            Console.WriteLine(tama.name+" Became To Hungry And Escaped... They Now Feed On The Souls Of The Innocent...");
            Console.WriteLine("GAME OVER!");
            i++;
        }
        if(tama.boredom>=20)
        {
            Console.WriteLine(tama.name+" Became To Bored And Escaped... They Found The Joy That You Could Not Give Them In Causing Minor Inconviniences For People All Over The World...");
            Console.WriteLine("GAME OVER!");
            i++;
        }
    }
}


Console.ReadLine();

static void Home(Tamagotchi tama, int[] time)
{
    Console.Clear();

    Console.WriteLine(tama.name+" | Day: "+time[0]+" | Hour: "+time[1]+"/10");
    Console.Write("Hunger: "+tama.hunger+" | Boredom: "+tama.boredom+" | ");
    if (tama.GetAlive() == true)
    {
        Console.WriteLine(tama.name+" Is Alive!");
    }
    else
    {
        Console.WriteLine(tama.name+" Is Dead...");
    }
    Console.WriteLine("---------------");
    Console.WriteLine("What Would You Like To Do Today?");
    Console.WriteLine("1. Teach "+tama.name+" A New Word.");
    Console.WriteLine("2. Say Hi To "+tama.name+".");
    Console.WriteLine("3. Feed "+tama.name+".");
    Console.WriteLine("4. Do Nothing.");
}