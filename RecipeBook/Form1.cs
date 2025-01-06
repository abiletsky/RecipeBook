using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Media.Imaging;
using DevExpress.XtraGrid.Views.Layout;

namespace RecipeBook
{
    public partial class RecipeForm : DevExpress.XtraEditors.XtraForm
    {
        public RecipeForm()
        {
            InitializeComponent();
        }

        Dictionary<string, BitmapImage> imageCache = new Dictionary<string, BitmapImage>(StringComparer.OrdinalIgnoreCase);
        void RecipeView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                switch (e.Column.FieldName)
                {
                    case "Image":
                        var view = sender as LayoutView;
                        string b64Img = (RecipeView.DataSource as IEnumerable<RecipeModel>).ElementAt(e.ListSourceRowIndex).Base64Image;
                        if (!imageCache.TryGetValue(b64Img, out BitmapImage value))
                        {
                            imageCache.Add(b64Img, value);
                        }
                        e.Value = value;
                        break;
                    case "Name":
                        e.Value = (RecipeView.DataSource as IEnumerable<RecipeModel>).ElementAt(e.ListSourceRowIndex).Name;
                        break;
                    case "Creator":
                        e.Value = (RecipeView.DataSource as IEnumerable<RecipeModel>).ElementAt(e.ListSourceRowIndex).Creator;
                        break;
                    case "Category":
                        e.Value = (RecipeView.DataSource as IEnumerable<RecipeModel>).ElementAt(e.ListSourceRowIndex).Category;
                        break;
                }
            }
            //}
            //if (e.Column.FieldName == "Image" && e.IsGetData)
            //{
            //    var view = sender as LayoutView;
            //    string b64Img = (RecipeView.DataSource as IEnumerable<RecipeModel>).ElementAt(e.ListSourceRowIndex).Base64Image;
            //    if (!imageCache.TryGetValue(b64Img, out BitmapImage value))
            //    {
            //        imageCache.Add(b64Img, value);
            //    }
            //    e.Value = value;
            //}
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var recipes = LoadRecipesFromJson();
            RecipeGridControl.DataSource = recipes;

        }

        private static List<RecipeModel> LoadRecipesFromJson()
        {
            var recipesDir = @"../../../Recipes";
            var recipeFiles = Directory.GetFiles(recipesDir, "*.json");
            var recipes = new List<RecipeModel>();

            foreach (var recipeFile in recipeFiles)
            {
                var recipeList = JsonConvert.DeserializeObject<List<RecipeModel>>(File.ReadAllText(recipeFile));
                recipes.AddRange(recipeList);
            }

            return recipes;
        }
    }
}
