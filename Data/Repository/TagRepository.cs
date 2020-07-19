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
    public class TagRepository : ITagRepository
    {
        private IDbConnection database;
        public TagRepository(string connectionString)
        {
            this.database = new SqlConnection(connectionString);
        }
        public int Add(Tag tag)
        {
            return (int)this.database.Insert(tag);
        }

        public Tag Find(int id)
        {
            return this.database.Get<Tag>(id);
        }

        public List<Tag> GetAll()
        {
            return this.database.GetAll<Tag>().ToList();
        }

        public bool Remove(int id)
        {
            return this.database.Delete(new Tag() { Id = id });
        }

        public Tag Update(Tag tag)
        {
            this.database.Update(tag);
            return tag;
        }
    }
}
