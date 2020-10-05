﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trefle.Net.Dto
{
    public class PlantResponseDataDto
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("bibliography")]
        public string Bibliography { get; set; }

        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        //[JsonProperty("family")]
        //public string Family { get; set; }

        [JsonProperty("family_common_name")]
        public string FamilyCommonName { get; set; }

        //[JsonProperty("genus")]
        //public string Genus { get; set; }

        [JsonProperty("genus_id")]
        public int GenusId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("is_vegetable")]
        public bool IsVegetable { get; set; }

        [JsonProperty("links")]
        public PlantResponseLinksDto Links { get; set; }

        [JsonProperty("main_species_id")]
        public int MainSpeciesId { get; set; }

        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
