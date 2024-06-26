namespace Studies.Michel.PromoEvents.API.Models
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string Location { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int PeopleCount { get; set; }
        public string Batch { get; set; }
        public string ImageURL { get; set; }
    }
}
