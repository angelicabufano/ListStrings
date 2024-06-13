namespace ListStrings;

internal class Program {
    static void Main(string[] args) {

        List<string> strings = new List<string>();

        strings.Add("Pink");
        strings.Add("Red");
        strings.Add("Magenta");
        strings.Add("Burgundy");
        strings.Add("Black");

        strings.AddRange(new string[] { "Green", "Yellow" });       // adds green and yellow to current list

        Console.WriteLine($"Enter a color: ");                // prompt user to type in a color
        var color = Console.ReadLine();                      // read color user typed in
        if(strings.Contains(color)) {
            Console.WriteLine($"Color already exists!");         // if statement is true, message will display that the color already exists
        } else {
            strings.Add(color);                             // if statement is not true, the color will be added
            Console.WriteLine("Added...");        
        }

        // var count = strings.Count;          // 5

        foreach (string str in strings) {
            Console.Write($"{str} ");
        }

    }
}
