using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Repository
{
    class PostRepository : IPostRepository
    {
        private IDbConnection database;
        public PostRepository(string connectionString)
        {
            this.database = new SqlConnection(connectionString);
        }
        public Post Add(Post post)
        {
            var id = this.database.Insert(post);
            post.Id = (int)id;
            return post;
        }

        public Post Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Post Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
