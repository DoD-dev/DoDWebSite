using Dapper;
using Dapper.Contrib.Extensions;
using Data.Data_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Data.Repository
{
    public class PostRepository : IPostRepository
    {
        private IDbConnection database;
        public PostRepository(string connectionString)
        {
            this.database = new SqlConnection(connectionString);
        }
        public int Add(Post post)
        {
            return (int)this.database.Insert(post);
        }

        public Post Find(int id)
        {
            return this.database.Get<Post>(id);
        }

        public List<Post> GetAll()
        {
            return this.database.GetAll<Post>().ToList();
        }

        public bool Remove(int id)
        {
            return this.database.Delete(new Post() { Id = id });
        }

        public Post Update(Post post)
        {
            this.database.Update(post);
            return post;
        }
    }
}
