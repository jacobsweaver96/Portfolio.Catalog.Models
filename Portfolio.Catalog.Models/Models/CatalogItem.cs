namespace Portfolio.Catalog.Models.Models
{
    public class CatalogItem
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// Volume of this item (not always required)
        /// </summary>
        public int? Count { get; set; }
    }
}
