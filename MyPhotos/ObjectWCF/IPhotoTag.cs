using ModelWCF;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface IPhotoTag
    {
        [OperationContract]
        int AddTag(Tag tag);

        [OperationContract]
        int AddPhoto(Photo photo);

        [OperationContract]
        int AddTagToPhoto(Photo photo, Tag tag);

        [OperationContract]
        Tag GetTag(Tag tag);

        [OperationContract]
        List<Tag> GetAllTags();

        [OperationContract]
        List<Tag> GetTagsOfType(string tagType);

        [OperationContract]
        List<Tag> GetTagsOfPhoto(Photo photo);

        [OperationContract]
        List<Photo> GetAllPhotos();

        [OperationContract]
        List<Photo> GetPhotosWithTags(List<Tag> tags);

        [OperationContract]
        Photo GetPhotoByPath(string path);

        [OperationContract]
        int UpdatePhotoPath(string oldPath, string newPath);

        [OperationContract]
        int DeleteTag(Tag tag);

        [OperationContract]
        int DeletePhoto(Photo photo);

        [OperationContract]
        void DeleteTagFromPhoto(Photo photo, Tag tag);
    }
}
