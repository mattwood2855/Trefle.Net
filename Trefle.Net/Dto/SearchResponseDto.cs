using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Trefle.Net.Dto
{
    [DataContract]
    public class SearchResponseDto
    {
        [JsonProperty("data")]
        public IEnumerable<SearchResponsePlantDataDto> Data { get; set; }

        [JsonProperty("links")]
        public SearchResponseLinksDto Links { get; set; }

        [JsonProperty("meta")]
        public MetaDto Meta { get; set; }
    }
}
