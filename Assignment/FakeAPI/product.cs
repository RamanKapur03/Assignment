using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*{
    "id": 1,
        "title": "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
        "price": 109.95,
        "description": "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
        "category": "men's clothing",
        "image": "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
        "rating": {
        "rate": 3.9,
            "count": 120
        }*/

namespace FakeAPI.FakeAPI
{
    class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("price")]
        public string Price { get; set; }


        [JsonProperty("desciption")]
        public string Description { get; set; }


        [JsonProperty("category")]
        public string Category { get; set; }


        /*[JsonProperty("rating")]
        public string Rating {
            { get; set; }
        }*/








    }
}
