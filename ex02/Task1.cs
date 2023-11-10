namespace ex02
{
    public enum preference{a,b,c,d}

    public class Task1
    {
        static int index = 0;

        public Task1( string title, string description, DateTime date, preference myPreference)
        {
            Id = index++;
            Title = title;
            Description = description;
            Date = date;
            MyPreference = myPreference;
        }
        public int Id { get;}
        public string Title  { get; set; }

        public string Description { get; set; }

        public DateTime Date   { get; set; }

        public preference MyPreference { get; set; }



}
}