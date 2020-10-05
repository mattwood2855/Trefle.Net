using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class SearchResponseLinksDto
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
