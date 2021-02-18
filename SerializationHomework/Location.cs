using System;

namespace SerializationHomework
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string TimeZoneId { get; set; }
        public string LoсalTime { get; set; }
        public int LoсalTimeEpoch { get; set; }
        public string UtcOffset { get; set; }
    }
}