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

        Dictionary<string, BitmapImage> imageCache = new Dictionary<string, BitmapImage>(StringComparer.OrdinalIgnoreCase); // Probably no need to cache anymore since small image size

        void RecipeView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                switch (e.Column.FieldName)
                {
                    case "Image":
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

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            var recipes = LoadRecipesFromJson();
            RecipeGridControl.DataSource = recipes;

            CreatorDropDown.Properties.Items.AddRange(recipes.Select(r => r.Creator).Distinct().ToArray());
            CreatorDropDown.Properties.Items.Add(string.Empty);
            CategoryDropDown.Properties.Items.AddRange(recipes.Select(r => r.Category).Distinct().ToArray()); // Empty category already exists from manual recipes
        }

        private static List<RecipeModel> LoadRecipesFromJson()
        {
            var recipesDir = @"../../../Recipes";
            var recipeFiles = Directory.GetFiles(recipesDir, "*.json");
            var recipes = new List<RecipeModel>();

            // TODO: Some recipes appear to be duplicated, need to investigate
            foreach (var recipeFile in recipeFiles)
            {
                var recipeList = JsonConvert.DeserializeObject<List<RecipeModel>>(File.ReadAllText(recipeFile));
                recipes.AddRange(recipeList);
            }

            return recipes;
        }

        private void CreatorDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CreatorDropDown.EditValue.ToString()) || !CreatorDropDown.Properties.Items.Contains(CreatorDropDown.EditValue))
            {
                RecipeView.ActiveFilterString = string.Empty;
                return;
            }
            RecipeView.ActiveFilterString = $"Contains([Creator], '{CreatorDropDown.EditValue}')";
        }

        private void CategoryDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryDropDown.EditValue.ToString()) || !CategoryDropDown.Properties.Items.Contains(CategoryDropDown.EditValue))
            {
                RecipeView.ActiveFilterString = string.Empty;
                return;
            }
            RecipeView.ActiveFilterString = $"Contains([Category], '{CategoryDropDown.EditValue}')";
        }

        private void RecipeView_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            if (e.HitInfo.InFieldSortButton || e.HitInfo.InFieldFilterButton)
            {
                e.Handled = true;
                return;
            }
            var row = RecipeView.GetRow(e.RowHandle) as RecipeModel;
            RecipePopup.ShowDialog(this, new Rectangle(500, 500, 500, 500));
            Debug.WriteLine("Card clicked " + e.RowHandle + " " + row.Name);
        }
    }
}
