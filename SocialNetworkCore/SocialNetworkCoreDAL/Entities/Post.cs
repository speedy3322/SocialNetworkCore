using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace SocialNetworkCoreDAL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        #region foreign keys

        public int UserId { get; set; }
        public int? GroupId { get; set; }

        #endregion

        #region navigation properties

        public User User { get; set; }
        public Group Group { get; set; }

        public IList<Comment> Comments { get; set; }

        #endregion
    }
}