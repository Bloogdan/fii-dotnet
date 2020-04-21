using System.Collections.Generic;
using System.Linq;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace ModelWCF
{
    public class API
    {
        private ModelContainer context;

        public API()
        {
            context = MyPhotosContext.GetContext();
        }
        //done
        public int AddTag(Tag tag)
        {
            Tag fromDB = context.Tags.Where(t => t.Type == tag.Type && t.Name == tag.Name).FirstOrDefault();
            if (fromDB == null)
                context.Tags.Add(tag);
            return context.SaveChanges();
        }

        //done
        public int AddPhoto(Photo photo)
        {
            Photo fromDB = context.Photos.Where(p => p.Path == photo.Path).FirstOrDefault();
            if (fromDB == null)
                context.Photos.Add(photo);
            else if (fromDB.Deleted == true)
                fromDB.Deleted = false;
            return context.SaveChanges();
        }

        //done
        public int DeleteTag(Tag tag)
        {
            Tag fromDB = context.Tags.Find(tag.TagId);
            context.Tags.Remove(fromDB);
            return context.SaveChanges();
        }

        //done
        public int DeletePhoto(Photo photo)
        {
            Photo fromDB = context.Photos.Find(photo.PhotoId);
            fromDB.Deleted = true;
            return context.SaveChanges();
        }

        //done
        public List<Tag> GetAllTags()
        {
            return context.Tags.ToList();
        }

        //done
        public List<Photo> GetAllPhotos()
        {
            return context.Photos.Where(p => p.Deleted == false).ToList();
        }

        //done
        public List<Tag> GetTagsOfPhoto(Photo photo)
        {
            Photo fromDB = context.Photos.Include("Tags").Where(p => p.PhotoId == photo.PhotoId).FirstOrDefault();
            return fromDB.Tags.ToList();
        }

        //done
        public List<Photo> GetPhotosWithTags(List<Tag> tags)
        {
            bool contains;
            List<Photo> returnPhotos = new List<Photo>();
            foreach (Photo photo in context.Photos.Include("Tags"))
            {
                contains = true;
                foreach (Tag tag in tags)
                {
                    Tag fromDB = context.Tags.Find(tag.TagId);
                    if (!photo.Tags.Contains(fromDB))
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
        public int AddTagToPhoto(Photo photo, Tag tag)
        {
            Photo photoFromDB = context.Photos.Find(photo.PhotoId);
            Tag tagFromDB = context.Tags.Find(tag.TagId);
            photoFromDB.Tags.Add(tagFromDB);
            return context.SaveChanges();
        }

        //done
        public void DeleteTagFromPhoto(Photo photo, Tag tag)
        {
            Tag fromDB = context.Tags.Find(tag.TagId);
            context.Photos.Include("Tags").Where(p => p.PhotoId == photo.PhotoId).FirstOrDefault().Tags.Remove(fromDB);
            context.SaveChanges();

            List<Tag> tags = new List<Tag>();
            tags.Add(fromDB);
            if (GetPhotosWithTags(tags).Count == 0)
            {
                DeleteTag(fromDB);
            }
        }

        //done
        public Photo GetPhotoByPath(string path)
        {
            return context.Photos.Where(p => p.Path == path).FirstOrDefault();
        }

        //done
        public List<Tag> GetTagsOfType(string tagType)
        {
            return context.Tags.Where(t => t.Type == tagType).ToList();
        }

        //done
        public int UpdatePhotoPath(string oldPath, string newPath)
        {
            Photo photo = GetPhotoByPath(oldPath);
            Photo fromDB = context.Photos.Find(photo.PhotoId);
            fromDB.Path = newPath;
            return context.SaveChanges();
        }

        //done
        public Tag GetTag(Tag tag)
        {
            return context.Tags.Where(t => t.Type == tag.Type && t.Name == tag.Name).FirstOrDefault();
        }
    }
}
