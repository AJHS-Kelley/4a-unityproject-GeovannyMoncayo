namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 25;
        float myFloat = -1.234f;
        bool yon = true;
        string words = "so true";
        Console.WriteLine("This is my Int: " + myInt);
        Console.WriteLine("This is my Float: " + myFloat);
        Console.WriteLine("This is my yes or no: " + yon);
        Console.WriteLine("This is my words: " + words);

        for (int i = 20; i > 0; i--) {
            Console.WriteLine("You have " + i + " seconds left");
        }
        Console.WriteLine("Happy Birthday!");
    }
}
