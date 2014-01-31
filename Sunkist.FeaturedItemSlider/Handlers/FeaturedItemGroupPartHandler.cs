using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Sunkist.FeaturedItemSlider.Models;

namespace Sunkist.FeaturedItemSlider.Handlers {
    public class FeaturedItemGroupPartHandler : ContentHandler {
        public FeaturedItemGroupPartHandler(IRepository<FeaturedItemGroupPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            var featuredItemGroupPart = context.ContentItem.As<FeaturedItemGroupPart>();
            if (featuredItemGroupPart != null) {
                context.Metadata.DisplayText = featuredItemGroupPart.Name;
            }
        }
    }
}