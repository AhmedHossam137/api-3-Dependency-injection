namespace api_3_Dependency_injection.DTOs
{
    public class displayCatalogDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public List<string> productname { get; set; } = new List<string>();
    }
}
