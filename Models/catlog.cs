namespace api_3_Dependency_injection.Models
{
    public class catlog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }

        // Change this to a collection to store multiple products
        public virtual ICollection<product> productname { get; set; }
    }
}
