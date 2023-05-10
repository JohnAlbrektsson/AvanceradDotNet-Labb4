using System.Text.Json.Serialization;

namespace AvanceradDotNet_Labb4.Models
{
    public class PersonInterest
    {
        public int Id { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }
        public int PersonID { get; set; }
        [JsonIgnore]
        public Interest? Interest { get; set; }
        public int InterestID { get; set; }
        [JsonIgnore]
        public Link? Link { get; set; }
        public int LinkID { get; set; }
    }
}
