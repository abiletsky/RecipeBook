using Newtonsoft.Json;
using RecipeBook.Properties;
using SixLabors.ImageSharp.Formats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RecipeBook
{
    public class RecipeModel
    {
        [JsonProperty("Creator")]
        public string Creator { get; set; }
        [JsonProperty("Category")]
        public string Category { get; set; }
        [JsonProperty("Image")]
        public string ImageUrl { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("Base64Image")]
        public string Base64Image { get; set; }
        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("yieldAmount")]
        public YieldAmount YieldAmount;
        [JsonProperty("Ingredients")]
        public List<IngredientModel> Ingredients;
        [JsonProperty("Directions")]
        public List<DirectionModel> Directions;

        [JsonIgnore]
        public System.Drawing.Image Image => GetImage(Base64Image);

        private static System.Drawing.Image GetImage(string b64)
        {
            b64 = b64.Trim();
            if (string.IsNullOrWhiteSpace(b64))
                return Resources.MissingRecipe;
            return System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(b64)));
        }
    }

    public class IngredientModel
    {
        public double? Qty;
        public string Unit
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
    }

    public class DirectionModel
    {
        public string Direction
        {
            get; set;
        }
    }
    public class YieldAmount
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("singularUnit")]
        public string SingularUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("qty")]
        public double? Qty { get; set; }

        [JsonProperty("pluralUnit")]
        public string PluralUnit { get; set; }
    }
}
