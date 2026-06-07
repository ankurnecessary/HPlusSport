namespace HPlusSport.API.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public virtual List<Product> Products { get; set; }
    }
}
