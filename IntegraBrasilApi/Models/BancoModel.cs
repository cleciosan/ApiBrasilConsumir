using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        
        public string Ispb { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }
    }

}