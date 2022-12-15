using Sitecore.Data.Items;

namespace FullStackExperience.Models
{
    public class BannerModel
    {
        public string GuestEmail { get; set; }
        
        public string GuestName { get; set; }
        
        public Item ContentItem { get; set; }
    }
}
