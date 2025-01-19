namespace RecipeBook
{
    partial class RecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeForm));
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            FreeTextSearch = new DevExpress.XtraEditors.SearchControl();
            RecipeGridControl = new DevExpress.XtraGrid.GridControl();
            RecipeView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            ImageCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            CategoryCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            CreatorCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            NameCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            CategoryDropDown = new DevExpress.XtraEditors.ComboBoxEdit();
            CreatorDropDown = new DevExpress.XtraEditors.ComboBoxEdit();
            itemsView1 = new DevExpress.XtraGrid.Views.Items.ItemsView();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            RecipePopup = new DevExpress.XtraEditors.HtmlContentPopup(components);
            recipeModelBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FreeTextSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipeGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoryDropDown.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CreatorDropDown.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePopup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // FreeTextSearch
            // 
            FreeTextSearch.Client = RecipeGridControl;
            FreeTextSearch.Location = new System.Drawing.Point(12, 26);
            FreeTextSearch.Name = "FreeTextSearch";
            FreeTextSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            FreeTextSearch.Properties.Client = RecipeGridControl;
            FreeTextSearch.Size = new System.Drawing.Size(174, 20);
            FreeTextSearch.TabIndex = 0;
            // 
            // RecipeGridControl
            // 
            RecipeGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeGridControl.DataSource = typeof(RecipeModel);
            RecipeGridControl.Location = new System.Drawing.Point(192, 0);
            RecipeGridControl.MainView = RecipeView;
            RecipeGridControl.Name = "RecipeGridControl";
            RecipeGridControl.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            RecipeGridControl.Size = new System.Drawing.Size(1271, 917);
            RecipeGridControl.TabIndex = 1;
            RecipeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { RecipeView, gridView1, itemsView1 });
            // 
            // RecipeView
            // 
            RecipeView.Appearance.FieldCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            RecipeView.Appearance.FieldCaption.Options.UseFont = true;
            RecipeView.CardHorzInterval = 8;
            RecipeView.CardMinSize = new System.Drawing.Size(393, 359);
            RecipeView.CardVertInterval = 10;
            RecipeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { ImageCol, CategoryCol, CreatorCol, NameCol });
            RecipeView.GridControl = RecipeGridControl;
            RecipeView.Name = "RecipeView";
            RecipeView.OptionsBehavior.AllowExpandCollapse = false;
            RecipeView.OptionsBehavior.AllowRuntimeCustomization = false;
            RecipeView.OptionsBehavior.AllowSwitchViewModes = false;
            RecipeView.OptionsBehavior.Editable = false;
            RecipeView.OptionsItemText.TextToControlDistance = 8;
            RecipeView.OptionsMultiRecordMode.MultiColumnScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            RecipeView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            RecipeView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            RecipeView.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            RecipeView.OptionsView.PartialCardsSimpleScrolling = DevExpress.Utils.DefaultBoolean.True;
            RecipeView.OptionsView.PartialCardWrapThreshold = 300;
            RecipeView.OptionsView.ShowCardCaption = false;
            RecipeView.OptionsView.ShowCardExpandButton = false;
            RecipeView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            RecipeView.OptionsView.ShowHeaderPanel = false;
            RecipeView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            RecipeView.TemplateCard = layoutViewCard1;
            RecipeView.CardClick += RecipeView_CardClick;
            RecipeView.CustomUnboundColumnData += RecipeView_CustomUnboundColumnData;
            // 
            // ImageCol
            // 
            ImageCol.Caption = "Image";
            ImageCol.ColumnEdit = repositoryItemPictureEdit1;
            ImageCol.FieldName = "Image";
            ImageCol.LayoutViewField = layoutViewField_layoutViewColumn1_4;
            ImageCol.Name = "ImageCol";
            ImageCol.Tag = "";
            // 
            // layoutViewField_layoutViewColumn1_4
            // 
            layoutViewField_layoutViewColumn1_4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            layoutViewField_layoutViewColumn1_4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutViewField_layoutViewColumn1_4.EditorPreferredWidth = 381;
            layoutViewField_layoutViewColumn1_4.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            layoutViewField_layoutViewColumn1_4.Location = new System.Drawing.Point(0, 0);
            layoutViewField_layoutViewColumn1_4.MaxSize = new System.Drawing.Size(389, 270);
            layoutViewField_layoutViewColumn1_4.MinSize = new System.Drawing.Size(389, 270);
            layoutViewField_layoutViewColumn1_4.Name = "layoutViewField_layoutViewColumn1_4";
            layoutViewField_layoutViewColumn1_4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2);
            layoutViewField_layoutViewColumn1_4.Size = new System.Drawing.Size(389, 270);
            layoutViewField_layoutViewColumn1_4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1_4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1_4.TextSize = new System.Drawing.Size(0, 0);
            layoutViewField_layoutViewColumn1_4.TextVisible = false;
            // 
            // CategoryCol
            // 
            CategoryCol.Caption = "Category";
            CategoryCol.FieldName = "Category";
            CategoryCol.LayoutViewField = layoutViewField_layoutViewColumn1_3;
            CategoryCol.Name = "CategoryCol";
            CategoryCol.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // layoutViewField_layoutViewColumn1_3
            // 
            layoutViewField_layoutViewColumn1_3.EditorPreferredWidth = 324;
            layoutViewField_layoutViewColumn1_3.Location = new System.Drawing.Point(0, 326);
            layoutViewField_layoutViewColumn1_3.MaxSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_3.MinSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_3.Name = "layoutViewField_layoutViewColumn1_3";
            layoutViewField_layoutViewColumn1_3.Size = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1_3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1_3.TextSize = new System.Drawing.Size(49, 13);
            // 
            // CreatorCol
            // 
            CreatorCol.Caption = "Creator";
            CreatorCol.FieldName = "Creator";
            CreatorCol.LayoutViewField = layoutViewField_layoutViewColumn1_1;
            CreatorCol.Name = "CreatorCol";
            CreatorCol.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 324;
            layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 298);
            layoutViewField_layoutViewColumn1_1.MaxSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_1.MinSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1_1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // NameCol
            // 
            NameCol.Caption = "Name";
            NameCol.FieldName = "Name";
            NameCol.LayoutViewField = layoutViewField_layoutViewColumn1;
            NameCol.Name = "NameCol";
            NameCol.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            layoutViewField_layoutViewColumn1.EditorPreferredWidth = 324;
            layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 270);
            layoutViewField_layoutViewColumn1.MaxSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1.MinSize = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.CustomizationFormText = "TemplateCard";
            layoutViewCard1.GroupBordersVisible = false;
            layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_layoutViewColumn1_1, layoutViewField_layoutViewColumn1_3, layoutViewField_layoutViewColumn1_4, layoutViewField_layoutViewColumn1 });
            layoutViewCard1.Name = "layoutViewTemplateCard";
            layoutViewCard1.OptionsItemText.TextToControlDistance = 8;
            layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewCard1.Text = "TemplateCard";
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5 });
            gridView1.GridControl = RecipeGridControl;
            gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Image";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Category";
            gridColumn2.FieldName = "RecipeModel.Category";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "ImageUrl";
            gridColumn3.FieldName = "RecipeModel.Image";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Creator";
            gridColumn4.FieldName = "RecipeModel.Creator";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Name";
            gridColumn5.FieldName = "RecipeModel.Name";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(12, 9);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(70, 14);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Free Search";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(12, 68);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(46, 14);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Creator";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(12, 126);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(56, 14);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Category";
            // 
            // CategoryDropDown
            // 
            CategoryDropDown.Location = new System.Drawing.Point(12, 146);
            CategoryDropDown.Name = "CategoryDropDown";
            CategoryDropDown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CategoryDropDown.Properties.DropDownRows = 12;
            CategoryDropDown.Properties.Sorted = true;
            CategoryDropDown.Size = new System.Drawing.Size(174, 20);
            CategoryDropDown.TabIndex = 8;
            CategoryDropDown.SelectedValueChanged += CategoryDropDown_SelectedValueChanged;
            // 
            // CreatorDropDown
            // 
            CreatorDropDown.Location = new System.Drawing.Point(12, 88);
            CreatorDropDown.Name = "CreatorDropDown";
            CreatorDropDown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CreatorDropDown.Properties.Sorted = true;
            CreatorDropDown.Size = new System.Drawing.Size(174, 20);
            CreatorDropDown.TabIndex = 7;
            CreatorDropDown.SelectedValueChanged += CreatorDropDown_SelectedValueChanged;
            // 
            // itemsView1
            // 
            itemsView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn6, gridColumn7, gridColumn8, gridColumn9 });
            itemsView1.GridControl = RecipeGridControl;
            itemsView1.HtmlTemplate.Styles = resources.GetString("itemsView1.HtmlTemplate.Styles");
            itemsView1.HtmlTemplate.Template = resources.GetString("itemsView1.HtmlTemplate.Template");
            itemsView1.Name = "itemsView1";
            itemsView1.OptionsBehavior.Editable = false;
            itemsView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            itemsView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Image";
            gridColumn6.FieldName = "Image";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Tag = "";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Category";
            gridColumn7.FieldName = "Category";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "Creator";
            gridColumn8.FieldName = "Creator";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "Name";
            gridColumn9.FieldName = "Name";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 3;
            // 
            // RecipePopup
            // 
            RecipePopup.DataContext = recipeModelBindingSource;
            RecipePopup.HtmlTemplate.Styles = resources.GetString("htmlContentPopup1.HtmlTemplate.Styles");
            RecipePopup.HtmlTemplate.Template = resources.GetString("htmlContentPopup1.HtmlTemplate.Template");
            // 
            // recipeModelBindingSource
            // 
            recipeModelBindingSource.DataSource = typeof(RecipeModel);
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1463, 917);
            Controls.Add(CategoryDropDown);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(RecipeGridControl);
            Controls.Add(FreeTextSearch);
            Controls.Add(CreatorDropDown);
            DoubleBuffered = true;
            Name = "RecipeForm";
            Text = "Recipe Book";
            Load += RecipeForm_Load;
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FreeTextSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipeGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoryDropDown.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CreatorDropDown.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePopup).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SearchControl FreeTextSearch;
        private DevExpress.XtraGrid.GridControl RecipeGridControl;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView RecipeView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn NameCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn CategoryCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn CreatorCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn ImageCol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit CategoryDropDown;
        private DevExpress.XtraEditors.ComboBoxEdit CreatorDropDown;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Views.Items.ItemsView itemsView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.HtmlContentPopup RecipePopup;
        private System.Windows.Forms.BindingSource recipeModelBindingSource;
    }
}

