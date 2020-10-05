using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class PlantResponseDto
    {
        [JsonProperty("data")]
        public PlantResponseDataDto Data { get; set; }
    }
}
