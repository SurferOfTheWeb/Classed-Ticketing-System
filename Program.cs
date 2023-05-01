Ticket tempTicket = new Ticket();

// Each question further defines our ticket object, which will eventually help us fill out the new line in our csv file

Console.Write("What are you looking to create? (Ticket, Enhancement, Task)\n > "); string ticketType = Console.ReadLine().ToLower();

Console.Write("Please summarize your item here\n > "); tempTicket.issue = Console.ReadLine();

Console.Write("\nPlease enter the priority of your item (High, Medium, Low)\n > "); tempTicket.priority = Console.ReadLine();

Console.Write("\nPlease enter the status of your item (Open, Closed)\n > "); tempTicket.openStatus = Console.ReadLine();

Console.Write("\nPlease enter your name\n > "); tempTicket.nameOfClient = Console.ReadLine();

Console.Write("\nPlease enter who was assigned to your item\n > "); tempTicket.nameOfHelper = Console.ReadLine();

Console.Write("\nPlease enter who is watching your item (please seperate people with the '|' character)\n > "); string helpers = Console.ReadLine();

if( helpers.Contains("|")) { tempTicket.watchers = helpers.Split("|").ToList(); }
else { tempTicket.watchers.Add(helpers); }

// After our first round of questions, we narrow it down by asking questions pertinent to each type of ticket via if statements

if(ticketType == "ticket"){
    string newEntry = System.IO.File.ReadAllLines("tickets.csv").Length + 1 + ",";

    using (StreamWriter w = File.AppendText("tickets.csv")){
        newEntry += tempTicket.csvConversion();
        Console.Write("Please describe the severity of your issue\n > "); newEntry += "," + Console.ReadLine();
        w.WriteLine(newEntry);
    }
}

if(ticketType == "enhancement"){
    string newEntry = System.IO.File.ReadAllLines("enhancements.csv").Length + 1 + ",";

    using (StreamWriter w = File.AppendText("enhancements.csv")){
        newEntry += tempTicket.csvConversion();
        Console.Write("Please describe the software you'd like to enhance\n > "); newEntry += "," + Console.ReadLine();
        Console.Write("Please describe the cost of your enhancement\n > "); newEntry += "," + Console.ReadLine();
        Console.Write("Please describe why you believe this is an enhancement\n > "); newEntry += "," + Console.ReadLine();
        Console.Write("Please estimate how long it would take to develop\n > "); newEntry += "," + Console.ReadLine();
        w.WriteLine(newEntry);
    }
}

if(ticketType == "task"){
    string newEntry = System.IO.File.ReadAllLines("tasks.csv").Length + 1 + ",";

    using (StreamWriter w = File.AppendText("tasks.csv")){
        newEntry += tempTicket.csvConversion();
        Console.Write("Please describe the name of your project\n > "); newEntry += "," + Console.ReadLine();
        Console.Write("Please describe the due date of your project\n > "); newEntry += "," + Console.ReadLine();
        w.WriteLine(newEntry);
    }
}

Console.WriteLine("Thank you for using Grant's ticket reporting service!\n");