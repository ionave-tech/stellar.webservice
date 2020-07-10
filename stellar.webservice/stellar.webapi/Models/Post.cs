using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Post
    {
        public Nullable<Int32> Id { get; set; }
        public string PostId { get; set; }
        public string UserId { get; set; }
        public string SubscriptionId { get; set; }
        public string CategoryId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }

    }
}