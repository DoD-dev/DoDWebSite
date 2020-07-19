using Data.Data_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IPostTagRepository
    {
        List<PostTag> GetByPostId(int postId);
        List<PostTag> GetByTagId(int tagId);
        PostTag GetByPostIdAndTagId(int postId, int tagId);
        List<PostTag> GetAll();
        int Add(PostTag postTag);
        int Add(int postId, int tagId);
        int Add(List<PostTag> postTags);
        bool Remove(PostTag postTag);
        bool Remove(List<PostTag> postTags);
        int Remove(int postId,int tagId);
        int RemoveByPostId(int postId);
        int RemoveByTagId(int tagId);

    }
}
