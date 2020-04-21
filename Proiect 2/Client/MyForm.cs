using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using ModelWCF;

namespace ClientWCF
{
    public partial class MyForm : Form
    {
        private List<Tag> filters;
        private PhotoTagClient controller;
        public MyForm()
        {
            controller = new PhotoTagClient();
            filters = new List<Tag>();

            InitializeComponent();
            listPhotos_Draw();
        }

        private void buttonLoadFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = loadFolderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
                ProcessDirectory(loadFolderDialog.SelectedPath);
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            addPhotoDialog.Title = "Add path for photo";
            DialogResult dialogResult = addPhotoDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
                ProcessFile(addPhotoDialog.FileName);
        }

        public void ProcessDirectory(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public void ProcessFile(string path)
        {
            if (path.EndsWith(".jpg") || path.EndsWith(".png") || path.EndsWith(".jpeg"))
            {
                /*
                Console.WriteLine("Processed file '{0}'.", path);
                */

                Photo photo = new Photo()
                {
                    Path = path,
                    CreatedAt = DateTime.Now
                };
                if (controller.AddPhoto(photo) > 0)
                    listPhotos_Draw();
            }
        }

        private void listPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                photoBox.Image = Image.FromFile(listPhotos.SelectedItem.ToString());
            }
            catch (FileNotFoundException ex)
            {
                addPhotoDialog.Title = "Photo not found - Add new path";
                DialogResult dialogResult = addPhotoDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    if (addPhotoDialog.FileName.EndsWith(".jpg") || addPhotoDialog.FileName.EndsWith(".png") || addPhotoDialog.FileName.EndsWith(".jpeg"))
                    {
                        controller.UpdatePhotoPath(listPhotos.SelectedItem.ToString(), addPhotoDialog.FileName);
                        listPhotos.Items[listPhotos.SelectedIndex] = addPhotoDialog.FileName;
                        photoBox.Image = Image.FromFile(listPhotos.SelectedItem.ToString());
                    }
                }
            }
            catch (NullReferenceException ex)
            {

            }

            listTags_Draw();
        }

        public void comboTypes_OnDropDown(object sender, EventArgs e)
        {
            comboTypes.BeginUpdate();
            comboTypes.Items.Clear();
            List<string> types = controller.GetAllTags().Select(t => t.Type).Distinct().ToList();
            foreach (string type in types)
                comboTypes.Items.Add(type);
            comboTypes.EndUpdate();
        }

        public void comboNames_OnDropDown(object sender, EventArgs e)
        {
            comboNames.BeginUpdate();
            comboNames.Items.Clear();
            if (comboTypes.SelectedIndex != -1)
                foreach (Tag tag in controller.GetTagsOfType(comboTypes.SelectedItem.ToString()))
                    comboNames.Items.Add(tag.Name);
            comboNames.EndUpdate();
        }

        private void buttonRemovePhoto_Click(object sender, EventArgs e)
        {
            if (listPhotos.SelectedIndex != -1)
            {
                Photo photo = controller.GetPhotoByPath(listPhotos.SelectedItem.ToString());
                controller.DeletePhoto(photo);
                listPhotos_Draw();
            }
        }

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            Tag tag = new Tag()
            {
                Type = comboTypes.Text,
                Name = comboNames.Text
            };
            if (tag.Type != "" && tag.Name != "")
            {
                if (listPhotos.SelectedIndex != -1)
                {
                    controller.AddTag(tag);
                    Tag tagFromDB = controller.GetTag(tag);
                    Photo photoFromDB = controller.GetPhotoByPath(listPhotos.SelectedItem.ToString());
                    controller.AddTagToPhoto(photoFromDB, tagFromDB);
                    listTags_Draw();
                }
            }
        }

        private void listPhotos_Draw()
        {
            listPhotos.BeginUpdate();
            listPhotos.Items.Clear();
            List<Photo> photos = controller.GetPhotosWithTags(filters);
            foreach (Photo photo in photos)
            {
                listPhotos.Items.Add(photo.Path);
            }
            listPhotos.EndUpdate();
            listPhotos.SelectedIndex = -1;
            photoBox.Image = null;
        }

        private void listTags_Draw()
        {
            if (listPhotos.SelectedIndex != -1)
            {
                listTags.BeginUpdate();
                listTags.Items.Clear();
                Photo photo = controller.GetPhotoByPath(listPhotos.Items[listPhotos.SelectedIndex].ToString());
                List<Tag> tags = controller.GetTagsOfPhoto(photo);
                foreach (Tag tag in tags)
                {
                    string t = tag.Type + ": " + tag.Name;
                    listTags.Items.Add(t);
                }
                listTags.EndUpdate();
            }
        }

        private void buttonRemoveTag_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', ':' };
            if (listPhotos.SelectedIndex != -1)
            {
                if (listTags.SelectedIndex != -1)
                {
                    Tag tag = new Tag()
                    {
                        Type = listTags.SelectedItem.ToString().Split(delimiterChars)[0],
                        Name = listTags.SelectedItem.ToString().Split(delimiterChars)[2]
                    };
                    controller.DeleteTagFromPhoto(controller.GetPhotoByPath(listPhotos.Items[listPhotos.SelectedIndex].ToString()), controller.GetTag(tag));
                    listTags_Draw();
                }
            }

        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', ':' };
            if (listPhotos.SelectedIndex != -1)
            {
                if (listTags.SelectedIndex != -1)
                {
                    Tag tag = new Tag()
                    {
                        Type = listTags.SelectedItem.ToString().Split(delimiterChars)[0],
                        Name = listTags.SelectedItem.ToString().Split(delimiterChars)[2]
                    };
                    Tag fromDB = controller.GetTag(tag);
                    filters.Add(fromDB);
                    listFilters_Draw();
                    listPhotos_Draw();
                }
            }
        }

        private void listFilters_Draw()
        {
            listFilters.BeginUpdate();
            listFilters.Items.Clear();
            foreach (Tag filter in filters)
            {
                string t = filter.Type + ": " + filter.Name;
                listFilters.Items.Add(t);
            }
            listFilters.EndUpdate();
        }

        private void buttonRemoveFilter_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', ':' };
            if (listFilters.SelectedIndex != -1)
            {
                Tag tag = new Tag()
                {
                    Type = listFilters.SelectedItem.ToString().Split(delimiterChars)[0],
                    Name = listFilters.SelectedItem.ToString().Split(delimiterChars)[2]
                };
                Tag fromDB = controller.GetTag(tag);
                foreach(Tag _tag in filters)
                {
                    if (fromDB.TagId == _tag.TagId)
                    {
                        filters.Remove(_tag);
                        break;
                    }
                }
                listFilters_Draw();
                listTags_Draw();
                listPhotos_Draw();
            }
        }
    }
}
