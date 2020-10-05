using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class SearchResponsePlantDataDto
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("bibliography")]
        public string Bibliography { get; set; }

        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("family_common_name")]
        public string FamilyCommonName { get; set; }

        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("genus_id")]
        public int GenusId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("links")]
        public SearchResponsePlantDataLinksDto Links { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("synonyms")]
        public IEnumerable<string> Synonyms { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
