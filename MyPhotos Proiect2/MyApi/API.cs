using System.Collections.Generic;
using System.Linq;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace MyApi
{
    public static class API
    {
        //done
        public static int AddTag(Tag tag)
        {
            ModelContainer context = new ModelContainer();
            Tag fromDB = context.Tags.Where(t => t.Type == tag.Type && t.Name == tag.Name).FirstOrDefault();
            if (fromDB == null)
                context.Tags.Add(tag);
            return context.SaveChanges();
        }

        //done
        public static int AddPhoto(Photo photo)
        {
            ModelContainer context = new ModelContainer();
            Photo fromDB = context.Photos.Where(p => p.Path == photo.Path).FirstOrDefault();
            if (fromDB == null)
                context.Photos.Add(photo);
            else if (fromDB.Deleted == true)
                fromDB.Deleted = false;
            return context.SaveChanges();
        }

        //done
        public static int DeleteTag(Tag tag)
        {
            ModelContainer context = new ModelContainer();
            context.Tags.Remove(tag);
            return context.SaveChanges();
        }

        //done
        public static int DeletePhoto(Photo photo)
        {
            ModelContainer context = new ModelContainer();
            /*
                Photo p = context.Photos.Find(photo.PhotoId);
                p.Deleted = true;
            */
            photo.Deleted = true;
            return context.SaveChanges();
        }

        //done
        public static List<Tag> GetAllTags()
        {
            ModelContainer context = new ModelContainer();
            return context.Tags.ToList();
        }

        //done
        public static List<Photo> GetAllPhotos()
        {
            ModelContainer context = new ModelContainer();
            return context.Photos.Where(p => p.Deleted == false).ToList();
        }

        //done
        public static List<Tag> GetTagsOfPhoto(Photo photo)
        {
            ModelContainer context = new ModelContainer();
            return photo.Tags.ToList();
        }

        //done
        public static List<Photo> GetPhotosWithTags(List<Tag> tags)
        {
            ModelContainer context = new ModelContainer();
            bool contains;
            List<Photo> returnPhotos = new List<Photo>();
            foreach (Photo photo in context.Photos)
            {
                contains = true;
                foreach (Tag tag in tags)
                {
                    if (!photo.Tags.Contains(tag))
                    {
                        contains = false;
                        break;
                    }
                }
                if (contains)
                    returnPhotos.Add(photo);
            }
            return returnPhotos;
        }

        //done
        public static int AddTagToPhoto(Photo photo, Tag tag)
        {
            ModelContainer context = new ModelContainer();
            photo.Tags.Add(tag);
            return context.SaveChanges();
        }

        //done
        public static void DeleteTagFromPhoto(Photo photo, Tag tag)
        {
            ModelContainer context = new ModelContainer();
            photo.Tags.Remove(tag);
            context.SaveChanges();

            List<Tag> tags = new List<Tag>();
            tags.Add(tag);
            if (GetPhotosWithTags(tags).Count == 0)
            {
                DeleteTag(tag);
            }
        }

        //done
        public static Photo GetPhotoByPath(string path)
        {
            ModelContainer context = new ModelContainer();
            return context.Photos.Where(p => p.Path == path).FirstOrDefault();
        }

        //done
        public static List<Tag> GetTagsOfType(string tagType)
        {
            ModelContainer context = new ModelContainer();
            return context.Tags.Where(t => t.Type == tagType).ToList();
        }

        //done
        public static int UpdatePhotoPath(string oldPath, string newPath)
        {
            ModelContainer context = new ModelContainer();
            Photo photo = GetPhotoByPath(oldPath);
            photo.Path = newPath;
            return context.SaveChanges();
        }

        //done
        public static Tag GetTag(Tag tag)
        {
            ModelContainer context = new ModelContainer();
            return context.Tags.Where(t => t.Type == tag.Type && t.Name == tag.Name).FirstOrDefault();
        }
    }
}
