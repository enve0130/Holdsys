namespace Holdsystemet;
class Program
{
    static void Main(string[] args)
    {
        try //id = 0
        {
            Studerende stest1 = new Studerende(0, "Hans Jensen", "Gadevej 1", "101002-8289");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }

        try //navn = x
        {
            Studerende stest1 = new Studerende(01, "x", "Gadevej 1", "101002-8289");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fejl: {ex.Message}");
        }

        try //Cpr mindre end 11 tegn
        {
            Studerende stest1 = new Studerende(1, "Hans Jensen", "Gadevej 1", "101002");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fejl: {ex.Message}");
        }
        Studerende s1 = new Studerende(01, "Hans Jensen", "Gadevej 1", "101002-8289");
        Studerende s2 = new Studerende(02, "Søren Sol", "Stien 12", "010102-8391");
        Studerende s3 = new Studerende(03, "Falah Salah", "Falkevej 3", "111101-2781");

        //Opgave 1 test
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);

        Hold h1 = new Hold("Datamatiker", "Roskilde", "a", 2023, true);
        Hold h2 = new Hold("IT-teknolog", "Næstved", "b", 2023, false);
        Hold h3 = new Hold("Autoteknolog", "Køge", "c", 2023, true);

        //Opgave 2 test
        Console.WriteLine(h1);
        Console.WriteLine(h2);
        Console.WriteLine(h3);

        //Opgave 3 test, opretter flere studerende for testen
        Studerende s4 = new Studerende(04, "Tim Jensen", "Gadevej 1", "101002-8289");
        Studerende s5 = new Studerende(05, "Valder Sol", "Stien 12", "010102-8391");
        Studerende s6 = new Studerende(06, "Ahmed Salah", "Falkevej 3", "111101-2781");
        Studerende s7 = new Studerende(07, "Morten Jensen", "Gadevej 1", "101002-8289");
        Studerende s8 = new Studerende(08, "Susanne Sol", "Stien 12", "010102-8391");
        Studerende s9 = new Studerende(09, "Ali Salah", "Falkevej 3", "111101-2781");

        h1.Adderstuderende(s1);
        h1.Adderstuderende(s2);
        h1.Adderstuderende(s3);

        h2.Adderstuderende(s4);
        h2.Adderstuderende(s5);
        h2.Adderstuderende(s6);

        h3.Adderstuderende(s7);
        h3.Adderstuderende(s8);
        h3.Adderstuderende(s9);

        h1.PrintHoldetsElever();










    }
}

