namespace ClientWCF
{
    partial class MyForm
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
            this.loadFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonLoadFolder = new System.Windows.Forms.Button();
            this.listPhotos = new System.Windows.Forms.ListBox();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.listTags = new System.Windows.Forms.ListBox();
            this.listFilters = new System.Windows.Forms.ListBox();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.comboNames = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonRemoveTag = new System.Windows.Forms.Button();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.buttonRemoveFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.buttonRemovePhoto = new System.Windows.Forms.Button();
            this.addPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAddPhoto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoadFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listPhotos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboTypes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listTags, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listFilters, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.photoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboNames, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddPhoto.Location = new System.Drawing.Point(933, 3);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(149, 26);
            this.buttonAddPhoto.TabIndex = 2;
            this.buttonAddPhoto.Text = "Add Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonLoadFolder
            // 
            this.buttonLoadFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoadFolder.Location = new System.Drawing.Point(1088, 3);
            this.buttonLoadFolder.Name = "buttonLoadFolder";
            this.buttonLoadFolder.Size = new System.Drawing.Size(149, 26);
            this.buttonLoadFolder.TabIndex = 3;
            this.buttonLoadFolder.Text = "Load Folder";
            this.buttonLoadFolder.UseVisualStyleBackColor = true;
            this.buttonLoadFolder.Click += new System.EventHandler(this.buttonLoadFolder_Click);
            // 
            // listPhotos
            // 
            this.listPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.listPhotos, 2);
            this.listPhotos.FormattingEnabled = true;
            this.listPhotos.Location = new System.Drawing.Point(933, 37);
            this.listPhotos.Name = "listPhotos";
            this.listPhotos.Size = new System.Drawing.Size(304, 251);
            this.listPhotos.TabIndex = 1;
            this.listPhotos.Click += new System.EventHandler(this.listPhotos_SelectedIndexChanged);
            // 
            // comboTypes
            // 
            this.comboTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.Location = new System.Drawing.Point(933, 593);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(149, 21);
            this.comboTypes.TabIndex = 8;
            this.comboTypes.DropDown += new System.EventHandler(this.comboTypes_OnDropDown);
            // 
            // listTags
            // 
            this.listTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listTags.FormattingEnabled = true;
            this.listTags.Location = new System.Drawing.Point(933, 331);
            this.listTags.Name = "listTags";
            this.listTags.Size = new System.Drawing.Size(149, 251);
            this.listTags.TabIndex = 6;
            // 
            // listFilters
            // 
            this.listFilters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listFilters.FormattingEnabled = true;
            this.listFilters.Location = new System.Drawing.Point(1088, 331);
            this.listFilters.Name = "listFilters";
            this.listFilters.Size = new System.Drawing.Size(149, 251);
            this.listFilters.TabIndex = 10;
            // 
            // photoBox
            // 
            this.photoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photoBox.Location = new System.Drawing.Point(3, 3);
            this.photoBox.Name = "photoBox";
            this.tableLayoutPanel1.SetRowSpan(this.photoBox, 6);
            this.photoBox.Size = new System.Drawing.Size(924, 651);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 12;
            this.photoBox.TabStop = false;
            // 
            // comboNames
            // 
            this.comboNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboNames.FormattingEnabled = true;
            this.comboNames.Location = new System.Drawing.Point(1088, 593);
            this.comboNames.Name = "comboNames";
            this.comboNames.Size = new System.Drawing.Size(149, 21);
            this.comboNames.TabIndex = 13;
            this.comboNames.DropDown += new System.EventHandler(this.comboNames_OnDropDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAddTag, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRemoveTag, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddFilter, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRemoveFilter, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(933, 623);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(304, 31);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddTag.Location = new System.Drawing.Point(3, 4);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(70, 23);
            this.buttonAddTag.TabIndex = 0;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // buttonRemoveTag
            // 
            this.buttonRemoveTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveTag.Location = new System.Drawing.Point(79, 4);
            this.buttonRemoveTag.Name = "buttonRemoveTag";
            this.buttonRemoveTag.Size = new System.Drawing.Size(70, 23);
            this.buttonRemoveTag.TabIndex = 1;
            this.buttonRemoveTag.Text = "Rem. Tag";
            this.buttonRemoveTag.UseVisualStyleBackColor = true;
            this.buttonRemoveTag.Click += new System.EventHandler(this.buttonRemoveTag_Click);
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddFilter.Location = new System.Drawing.Point(155, 4);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(70, 23);
            this.buttonAddFilter.TabIndex = 2;
            this.buttonAddFilter.Text = "Add Filter";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // buttonRemoveFilter
            // 
            this.buttonRemoveFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveFilter.Location = new System.Drawing.Point(231, 4);
            this.buttonRemoveFilter.Name = "buttonRemoveFilter";
            this.buttonRemoveFilter.Size = new System.Drawing.Size(70, 23);
            this.buttonRemoveFilter.TabIndex = 3;
            this.buttonRemoveFilter.Text = "Rem. Filter";
            this.buttonRemoveFilter.UseVisualStyleBackColor = true;
            this.buttonRemoveFilter.Click += new System.EventHandler(this.buttonRemoveFilter_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.labelTags, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelFilters, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRemovePhoto, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(933, 297);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(304, 26);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // labelTags
            // 
            this.labelTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(3, 13);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(31, 13);
            this.labelTags.TabIndex = 0;
            this.labelTags.Text = "Tags";
            // 
            // labelFilters
            // 
            this.labelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(267, 13);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(34, 13);
            this.labelFilters.TabIndex = 1;
            this.labelFilters.Text = "Filters";
            // 
            // buttonRemovePhoto
            // 
            this.buttonRemovePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemovePhoto.Location = new System.Drawing.Point(95, 3);
            this.buttonRemovePhoto.Name = "buttonRemovePhoto";
            this.buttonRemovePhoto.Size = new System.Drawing.Size(112, 20);
            this.buttonRemovePhoto.TabIndex = 2;
            this.buttonRemovePhoto.Text = "Remove Photo";
            this.buttonRemovePhoto.UseVisualStyleBackColor = true;
            this.buttonRemovePhoto.Click += new System.EventHandler(this.buttonRemovePhoto_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MyForm";
            this.Text = "My Photos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog loadFolderDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonLoadFolder;
        private System.Windows.Forms.ListBox listPhotos;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.ListBox listTags;
        private System.Windows.Forms.ListBox listFilters;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.ComboBox comboNames;
        private System.Windows.Forms.OpenFileDialog addPhotoDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonRemoveTag;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.Button buttonRemoveFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Button buttonRemovePhoto;
    }
}

