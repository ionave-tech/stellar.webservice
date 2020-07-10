using API.Models;
using API.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using API.Interface;

namespace API.Repository
{
    public class PostRepository : IPostRepository
    {
        public PostRepository()
        {
        }

        public IEnumerable<Post> GetAll()
        {
            DataTable dt = new DataTable();
            PostData pData = new PostData();

            dt = pData.SelectAll();

            var posts = new List<Post>(dt.Rows.Count);

            foreach (DataRow row in dt.Rows)
            {
                var post = new Post()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    PostId = row["PostId"].ToString(),
                    UserId = row["UserId"].ToString(),
                    SubscriptionId = row["SubscriptionId"].ToString(),
                    CategoryId = row["CategoryId"].ToString(),
                    Subject = row["Subject"].ToString(),
                    Details = row["Details"].ToString(),
                    Link = row["Link"].ToString(),
                    Status = row["Status"].ToString()
                };

                posts.Add(post);
            }

            return posts;
        }

    }
}