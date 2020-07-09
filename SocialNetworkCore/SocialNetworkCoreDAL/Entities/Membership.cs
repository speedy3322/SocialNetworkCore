
namespace SocialNetworkCoreDAL.Entities
{
    public class Membership
    {
        public int Id { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsAdmin { get; set; }

        #region foreign keys

        public int GroupId { get; set; }
        public int UserId { get; set; }

        #endregion

        #region navigation properties

        public Group Group { get; set; }
        public User User { get; set; }

        #endregion
    }
}