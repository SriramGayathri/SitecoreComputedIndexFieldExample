using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System.Collections.Specialized;

namespace ProductSearch.Platform.ComputedFields
{
    public class ProductCategory : AbstractComputedIndexField
    {
        
        public override object ComputeFieldValue(IIndexable indexable)
        {
            Assert.ArgumentNotNull(indexable, "indexable");

            var item = (Item)(indexable as SitecoreIndexableItem);

            if (item == null)
            {
                Log.Warn(string.Format("{0} : unsupported IIndexable type : {1}", this, indexable.GetType()), this);
                return null;
            }

            if (!item.TemplateID.Equals(Templates.Fields.ProductTemplateID))
            {
                Log.Warn(string.Format("{0} : unsupported Template type : {1}", this, indexable.GetType()), this);
                return null;
            }

            GroupedDroplistField CategoryField = item.Fields[Templates.Fields.CategoryFieldId];

            GroupedDroplistField AllergyField = item.Fields[Templates.Fields.AllergyFieldId];

            GroupedDroplistField IngredientField = item.Fields[Templates.Fields.IngredientsFieldId];
            

            StringCollection categories = new StringCollection
            {
                AllergyField?.Value?.ToLower(),
                CategoryField?.Value?.ToLower(),
                IngredientField?.Value?.ToLower()
                
            };
            string.Join(" ", categories);

            return categories;
        }
    }
}