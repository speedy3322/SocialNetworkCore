using System;

namespace SocialNetworkCoreDAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        #region foreign keys

        public int UserId { get; set; }
        public int PostId { get; set; }

        #endregion

        #region navigation properties

        public User User { get; set; }
        public Post Post { get; set; }

        #endregion
    }
}