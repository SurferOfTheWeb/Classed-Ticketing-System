string newEntry = System.IO.File.ReadAllLines("tickets.csv").Length + 1 + ",";

using (StreamWriter w = File.AppendText("tickets.csv")){
    
    Ticket tempTicket = new Ticket();

    // Each question further defines our ticket object, which will eventually help us fill out the new line in our csv file

    Console.Write("Please summarize your issue here\n > "); tempTicket.issue = Console.ReadLine();

    Console.Write("\nPlease enter the status of your issue (Open, Closed)\n > "); tempTicket.openStatus = Console.ReadLine();

    Console.Write("\nPlease enter the priority of your issue (High, Medium, Low)\n > "); tempTicket.priority = Console.ReadLine();

    Console.Write("\nPlease enter your name\n > "); tempTicket.nameOfClient = Console.ReadLine();

    Console.Write("\nPlease enter who was assigned to your issue\n > "); tempTicket.nameOfHelper = Console.ReadLine();

    Console.Write("\nPlease enter who is watching your issue (please seperate people with the '|' character)\n > "); string helpers = Console.ReadLine();

    if( helpers.Contains("|")) { tempTicket.watchers = helpers.Split("|").ToList(); }
    else { tempTicket.watchers.Add(helpers); }

    newEntry += tempTicket.csvConversion();

    w.WriteLine(newEntry);
}
