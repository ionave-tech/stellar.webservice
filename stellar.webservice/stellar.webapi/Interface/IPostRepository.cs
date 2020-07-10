using API.Models;
using System.Collections.Generic;

namespace API.Interface
{
    interface IPostRepository
    {
        IEnumerable<Post> GetAll();
    }
}
