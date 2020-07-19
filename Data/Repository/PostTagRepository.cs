using Dapper;
using Dapper.Contrib.Extensions;
using Data.Data_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class PostTagRepository : IPostTagRepository
    {
        private IDbConnection database;
        public PostTagRepository(string connectionString)
        {
            this.database = new SqlConnection(connectionString);
        }
        public int Add(PostTag postTag)
        {
            return (int)this.database.Insert(postTag);
        }

        public int Add(int postId, int tagId)
        {
            return (int)this.database.Insert(new PostTag() { PostId = postId, TagId = tagId });
        }

        public int Add(List<PostTag> postTags)
        {
            return this.database.Execute("INSERT INTO PostTag (PostId,TagId) VALUES (@postId,@tagId)", postTags);
        }

        public List<PostTag> GetAll()
        {
            return this.database.GetAll<PostTag>().ToList();
        }

        public List<PostTag> GetByPostId(int postId)
        {
            return this.database.Query<PostTag>("SELECT * FROM PostTag WHERE PostId = @postId", new { postId = postId }).ToList();
        }

        public PostTag GetByPostIdAndTagId(int postId, int tagId)
        {
            return this.database.Query<PostTag>("SELECT * FROM PostTag WHERE PostId = @postId AND TagId = @tagId", new { postId = postId, tagId = tagId }).FirstOrDefault();
        }

        public List<PostTag> GetByTagId(int tagId)
        {
            return this.database.Query<PostTag>("SELECT * FROM PostTag WHERE TagId = @tagId", new { tagId = tagId }).ToList();
        }

        public bool Remove(PostTag postTag)
        {
            return this.database.Delete(postTag);
        }

        public bool Remove(List<PostTag> postTags)
        {
            for (int i = 0; i < postTags.Count - 1; i++)
            {
                this.database.Delete(postTags[i]);
            }
            return this.database.Delete(postTags[postTags.Count]);
        }

        public int Remove(int postId, int tagId)
        {
            return this.database.Execute("DELETE FROM PostTag WHERE PostId = @postId AND TagId = @tagId", new { postId = postId, tagId = tagId });
        }

        public int RemoveByPostId(int postId)
        {
            return this.database.Execute("DELETE FROM PostTag WHERE PostId = @postId", new { postId = postId });
        }

        public int RemoveByTagId(int tagId)
        {
            return this.database.Execute("DELETE FROM PostTag WHERE TagId = @tagId", new { tagId = tagId });
        }
    }
}
