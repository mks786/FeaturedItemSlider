using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Sunkist.FeaturedItemSlider.Models;

namespace Sunkist.FeaturedItemSlider.Handlers {
    public class FeaturedItemSliderWidgetPartHandler : ContentHandler {
        public FeaturedItemSliderWidgetPartHandler(IRepository<FeaturedItemSliderWidgetPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}