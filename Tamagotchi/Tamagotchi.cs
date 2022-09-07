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
        hunger-=3;
    }
    public string Hi()
    {
        int i = generator.Next(words.Count);
        if(words.Count != 0)
        {
            ReduceBoredom(3);
            return words[i];
        }
        else
        {
            return null;
        }
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom(2);
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
        hunger += 6;
        boredom += 4;
        if (hunger > 20 || boredom > 20)
        {
            isAlive = false;
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom(int val)
    {
        boredom-=val;
    }
}
