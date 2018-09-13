using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Gender
{
    Male,
    Female
}
public class dog
{
    public string namedog, nameowner;
    public int numberage;
    public Gender gender;

    public dog(string dogname, string ownername, int agenumber, Gender gender2)
    {
        this.namedog = dogname;
        this.nameowner = ownername;
        this.numberage = agenumber;
        this.gender = gender2;
    }

    public int bark(int numberbark)
    {

        for (int i = 0; i < numberbark; i++)
            Console.Write("Bark!");
        Console.WriteLine("");
        return 0;
    }

    public string getTag()
    {
        string tag,date,pronoun1,pronoun2;

        if (this.numberage > 1)
            date = "years";
        else
            date = "year";

        if (this.gender == Gender.Male)
        {
            pronoun1 = "His";
            pronoun2 = "he";
        }
        else
        {
            pronoun1 = "Her";
            pronoun2 = "she";
        }

        tag = $"If lost, call {nameowner}. {pronoun1} name is {namedog} and {pronoun2} is {numberage} {date} old.";

        return tag;
    }
}

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new dog("Indy", "Bob", 5, Gender.Male);
            var dog2 = new dog("Pepper", "Will", 1, Gender.Female);

            dog1.bark(3);       
            Console.WriteLine(dog1.getTag());

            dog2.bark(2);
            Console.WriteLine(dog2.getTag());

            Console.ReadKey();
        }
    }
}
