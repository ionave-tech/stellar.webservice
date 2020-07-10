using System;
using System.Collections.Generic;
using System.Web.Http;
using API.Interface;
using API.Repository;
using API.Models;

namespace API.Controllers
{
    [RoutePrefix("Post")]
    public class PostController : ApiController
    {
        static readonly IPostRepository repository = new PostRepository();

        ///<summary>Returns All Post.</summary>
        [Authorize]
        [Route("all")]
        public IEnumerable<Post> GetAll()
        {
            try
            {
                return repository.GetAll();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}