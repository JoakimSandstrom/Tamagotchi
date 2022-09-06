public class Tamagotchi
{
    public int hunger = 0;
    public int boredom = 0;
    private List<string> words = new List<string>();
    private bool isAlive = true;
    private Random generator = new Random();
    public string name = "";

    public void Feed()
    {
        hunger--;
    }
    public string Hi()
    {
        int i = generator.Next(words.Count);
        ReduceBoredom();
        return words[i];
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 20 || boredom > 20)
        {
            isAlive = false;
        }
    }
    public void Sleep()
    {
        hunger += 5;
        boredom += 2;
        if (hunger > 20 || boredom > 20)
        {
            isAlive = false;
        }
    }
    public void PrintStats()
    {
        Console.Write("");
        if (isAlive == false)
        {
            Console.WriteLine(name+" Is Dead...");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(name+" Is Somehow Still Alive");
            Console.WriteLine(name+"'s Hunger Is At "+hunger);
            Console.WriteLine(name+"'s Boredom Is At "+boredom);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadLine();
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        boredom--;
    }
}
