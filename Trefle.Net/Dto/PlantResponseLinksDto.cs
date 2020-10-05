using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class PlantResponseLinksDto
    {
        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }
    }
}
