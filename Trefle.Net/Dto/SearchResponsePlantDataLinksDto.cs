using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class SearchResponsePlantDataLinksDto
    {
        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("plant")]
        public string Plant { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
