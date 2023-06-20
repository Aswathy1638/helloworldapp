using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyWebApp.Models
{
    public class Product
    {
        public string MyProperty { get; set; }
        [JsonPropertyName]=
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryDescription { get; set;} = string.Empty;
        public string ProductCategoryName { get; set;} = string.Empty;
            
    }
}
