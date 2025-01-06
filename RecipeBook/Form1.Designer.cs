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
            searchControl1 = new DevExpress.XtraEditors.SearchControl();
            RecipeGridControl = new DevExpress.XtraGrid.GridControl();
            RecipeView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            ImageCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            layoutViewField_layoutViewColumn1_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            CategoryCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ImageUrl = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
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
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipeGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // searchControl1
            // 
            searchControl1.Location = new System.Drawing.Point(12, 25);
            searchControl1.Name = "searchControl1";
            searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            searchControl1.Size = new System.Drawing.Size(100, 20);
            searchControl1.TabIndex = 0;
            // 
            // RecipeGridControl
            // 
            RecipeGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeGridControl.DataSource = typeof(RecipeModel);
            RecipeGridControl.Location = new System.Drawing.Point(0, 0);
            RecipeGridControl.MainView = RecipeView;
            RecipeGridControl.Name = "RecipeGridControl";
            RecipeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            RecipeGridControl.Size = new System.Drawing.Size(808, 585);
            RecipeGridControl.TabIndex = 1;
            RecipeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { RecipeView, gridView1 });
            // 
            // RecipeView
            // 
            RecipeView.CardMinSize = new System.Drawing.Size(393, 339);
            RecipeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { ImageCol, CategoryCol, ImageUrl, CreatorCol, NameCol });
            RecipeView.GridControl = RecipeGridControl;
            RecipeView.Name = "RecipeView";
            RecipeView.OptionsBehavior.AllowExpandCollapse = false;
            RecipeView.OptionsBehavior.AllowRuntimeCustomization = false;
            RecipeView.OptionsBehavior.AllowSwitchViewModes = false;
            RecipeView.OptionsBehavior.Editable = false;
            RecipeView.OptionsItemText.TextToControlDistance = 9;
            RecipeView.OptionsMultiRecordMode.MultiColumnScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            RecipeView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            RecipeView.OptionsView.AllowHotTrackFields = false;
            RecipeView.OptionsView.ShowCardCaption = false;
            RecipeView.OptionsView.ShowCardExpandButton = false;
            RecipeView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            RecipeView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            RecipeView.TemplateCard = layoutViewCard1;
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
            ImageCol.UnboundDataType = typeof(SixLabors.ImageSharp.Image);
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutViewField_layoutViewColumn1_4
            // 
            layoutViewField_layoutViewColumn1_4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            layoutViewField_layoutViewColumn1_4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutViewField_layoutViewColumn1_4.EditorPreferredWidth = 381;
            layoutViewField_layoutViewColumn1_4.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            layoutViewField_layoutViewColumn1_4.Location = new System.Drawing.Point(0, 0);
            layoutViewField_layoutViewColumn1_4.Name = "layoutViewField_layoutViewColumn1_4";
            layoutViewField_layoutViewColumn1_4.Size = new System.Drawing.Size(389, 30);
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
            layoutViewField_layoutViewColumn1_3.EditorPreferredWidth = 323;
            layoutViewField_layoutViewColumn1_3.Location = new System.Drawing.Point(0, 114);
            layoutViewField_layoutViewColumn1_3.Name = "layoutViewField_layoutViewColumn1_3";
            layoutViewField_layoutViewColumn1_3.Size = new System.Drawing.Size(389, 24);
            layoutViewField_layoutViewColumn1_3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1_3.TextSize = new System.Drawing.Size(49, 13);
            // 
            // ImageUrl
            // 
            ImageUrl.Caption = "ImageUrl";
            ImageUrl.FieldName = "ImageUrl";
            ImageUrl.LayoutViewField = layoutViewField_layoutViewColumn1_2;
            ImageUrl.Name = "ImageUrl";
            ImageUrl.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 323;
            layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 86);
            layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1_2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(49, 13);
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
            layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 323;
            layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 58);
            layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(389, 28);
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
            layoutViewField_layoutViewColumn1.EditorPreferredWidth = 323;
            layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 30);
            layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(389, 28);
            layoutViewField_layoutViewColumn1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.CustomizationFormText = "TemplateCard";
            layoutViewCard1.GroupBordersVisible = false;
            layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_layoutViewColumn1_1, layoutViewField_layoutViewColumn1_2, layoutViewField_layoutViewColumn1_3, layoutViewField_layoutViewColumn1_4, layoutViewField_layoutViewColumn1 });
            layoutViewCard1.Name = "layoutViewCard1";
            layoutViewCard1.OptionsItemText.TextToControlDistance = 9;
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
            // RecipeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(808, 585);
            Controls.Add(RecipeGridControl);
            Controls.Add(searchControl1);
            DoubleBuffered = true;
            Name = "RecipeForm";
            Text = "Recipe Book";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipeGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl RecipeGridControl;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView RecipeView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn NameCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn CategoryCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn ImageUrl;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn CreatorCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn ImageCol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

