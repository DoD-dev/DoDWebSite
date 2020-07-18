using Dapper;
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
        public Tag Add(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Tag Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAll()
        {
            return this.database.Query<Tag>("SELECT * FROM Tag").ToList();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Tag Update(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
