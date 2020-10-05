using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class MetaDto
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
