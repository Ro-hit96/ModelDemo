namespace ModelDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }//? is use to allow Null
        public int Price { get; set; }
    }
}
