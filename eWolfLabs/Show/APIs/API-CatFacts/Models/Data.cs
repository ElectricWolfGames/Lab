namespace API_CatFacts.Models
{
    public class Class1
    {
        public int __v { get; set; }
        public string _id { get; set; }
        public DateTime createdAt { get; set; }
        public bool deleted { get; set; }
        public string source { get; set; }
        public Status status { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public DateTime updatedAt { get; set; }
        public bool used { get; set; }
        public string user { get; set; }
    }

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Status
    {
        public int sentCount { get; set; }
        public bool verified { get; set; }
    }
}