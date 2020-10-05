using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class PlantResponseMetaDto
    {
        [JsonProperty("last_modified")]
        public DateTime LastModified { get; set; }
    }
}
