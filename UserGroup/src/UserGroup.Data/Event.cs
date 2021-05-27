using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserGroup.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        [System.Text.Json.Serialization.JsonPropertyName("speakers")]

        [NotMapped]
        public string[]? UserGroupSpeakers { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
