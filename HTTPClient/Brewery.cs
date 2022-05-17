

    using System;
    using Newtonsoft.Json;

    public partial class Brewery
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brewery_type")]
        public string BreweryType { get; set; }

        [JsonProperty("street")]
        public object Street { get; set; }

        [JsonProperty("address_2")]
        public object Address2 { get; set; }

        [JsonProperty("address_3")]
        public object Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county_province")]
        public object CountyProvince { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("longitude")]
        public object Longitude { get; set; }

        [JsonProperty("latitude")]
        public object Latitude { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website_url")]
        public object WebsiteUrl { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
