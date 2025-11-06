namespace CreditApi
{
    public class CreditCard //Class to hold credit infos
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }

        public CreditCard(string name, string description) //A constructor
        {
            this.name = name;   
        }

    }
}
