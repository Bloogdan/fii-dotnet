using ModelWCF;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class PhotoTag : IPhotoTag
    {
        private API API = new API();

        int IPhotoTag.AddTag(Tag tag)
        {
            return API.AddTag(tag);
        }

        int IPhotoTag.AddPhoto(Photo photo)
        {
            return API.AddPhoto(photo);
        }

        int IPhotoTag.AddTagToPhoto(Photo photo, Tag tag)
        {
            return API.AddTagToPhoto(photo, tag);
        }

        Tag IPhotoTag.GetTag(Tag tag)
        {
            return API.GetTag(tag);
        }

        List<Tag> IPhotoTag.GetAllTags()
        {
            return API.GetAllTags();
        }

        List<Tag> IPhotoTag.GetTagsOfType(string tagType)
        {
            return API.GetTagsOfType(tagType);
        }

        List<Tag> IPhotoTag.GetTagsOfPhoto(Photo photo)
        {
            return API.GetTagsOfPhoto(photo);
        }

        List<Photo> IPhotoTag.GetAllPhotos()
        {
            return API.GetAllPhotos();
        }

        List<Photo> IPhotoTag.GetPhotosWithTags(List<Tag> tags)
        {
            return API.GetPhotosWithTags(tags);
        }

        Photo IPhotoTag.GetPhotoByPath(string path)
        {
            return API.GetPhotoByPath(path);
        }

        int IPhotoTag.UpdatePhotoPath(string oldPath, string newPath)
        {
            return API.UpdatePhotoPath(oldPath, newPath);
        }

        int IPhotoTag.DeleteTag(Tag tag)
        {
            return API.DeleteTag(tag);
        }

        int IPhotoTag.DeletePhoto(Photo photo)
        {
            return API.DeletePhoto(photo);
        }

        void IPhotoTag.DeleteTagFromPhoto(Photo photo, Tag tag)
        {
            API.DeleteTagFromPhoto(photo, tag);
        }
    }
}
