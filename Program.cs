
string csvPath = "C:\\Users\\grant\\source\\repos\\Ticketing System\\Ticketing System\\tickets.csv";

List<string> newEntry = new List<string>(); 

newEntry.Add(System.IO.File.ReadAllLines(csvPath).Length + 1 + ",");

Console.Write("Please summarize your issue here\n > "); newEntry[0] += Console.ReadLine() + ",";

Console.Write("\nPlease enter the status of your issue (Open, Closed)\n > "); newEntry[0] += Console.ReadLine() + ",";

Console.Write("\nPlease enter the priority of your issue (High, Medium, Low)\n > "); newEntry[0] += Console.ReadLine() + ",";

Console.Write("\nPlease enter your name\n > "); newEntry[0] += Console.ReadLine() + ",";

Console.Write("\nPlease enter who was assigned to your issue\n > "); newEntry[0] += Console.ReadLine() + ",";

Console.Write("\nPlease enter who is watching your issue (please seperate people with the '|' character)\n > "); newEntry[0] += Console.ReadLine();

File.AppendAllLines(csvPath, newEntry);
