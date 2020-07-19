using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IPostRepository
    {
        Post Find(int id);
        List<Post> GetAll();
        Post Update(Post post);
        int Add(Post post);
        bool Remove(int id);
    }
}
