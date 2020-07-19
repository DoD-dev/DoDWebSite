using Data.Data_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface ITagRepository
    {
        Tag Find(int id);
        List<Tag> GetAll();
        Tag Update(Tag tag);
        int Add(Tag tag);
        bool Remove(int id);
    }
}
