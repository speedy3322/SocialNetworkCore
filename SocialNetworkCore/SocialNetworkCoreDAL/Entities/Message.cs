using System;

namespace SocialNetworkCoreDAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime SendAt { get; set; }

        #region foreign keys

        public int UserId { get; set; }
        public int FriendshipId { get; set; }

        #endregion

        #region navigation properties

        public User User { get; set; }
        public Friendship Friendship { get; set; }

        #endregion
    }
}