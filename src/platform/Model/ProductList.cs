using Sitecore.ContentSearch;

namespace ProductSearch.Platform.Models
{
    public class ProductList
    {

        [IndexField(" _uniqueid")]
        public string ProductId { get; set; }

        [IndexField("_displayname")]
        public string ProductName { get; set; }

        [IndexField("productcategory_sm")]
        public string ProductCategory { get; set; }
    }
}