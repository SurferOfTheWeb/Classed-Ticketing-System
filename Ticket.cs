class Ticket
{
    public string issue { get; set; }
    public string nameOfClient { get; set; }
    public string nameOfHelper { get; set; }
    public List<String> watchers { get; set; }
    public string priority { get; set; }
    public string openStatus { get; set; }

    public Ticket(string givenIssue, string givenClient, string givenHelper, List<String> givenWatchers, string givenPriority, string givenOpenStatus)
    {
        this.issue = givenIssue;
        this.nameOfClient = givenClient;
        this.nameOfHelper = givenHelper;
        this.watchers = givenWatchers;
        this.priority = givenPriority;
        this.openStatus = givenOpenStatus;
    }
    public Ticket(){
        this.issue = null;
        this.nameOfClient = null;
        this.nameOfHelper = null;
        this.watchers = new List<string>();
        this.priority = null;
        this.openStatus = null;
    }

    public string csvConversion(){
        return issue + "," + openStatus + "," + priority + "," + nameOfClient + "," + nameOfHelper + "," + string.Join("|", watchers);
    }
}