namespace api_3_Dependency_injection.Models
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string quantity { get; set; }
        public virtual catlog CatlogID { get; set; }

    }
}
