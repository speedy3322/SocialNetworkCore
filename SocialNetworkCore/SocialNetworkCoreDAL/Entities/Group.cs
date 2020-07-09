using System.Collections;
using System.Collections.Generic;

namespace SocialNetworkCoreDAL.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }

        #region foreign keys

        #endregion

        #region navigation properties

        public IList<Membership> Memberships { get; set; }
        public IList<Post> Posts { get; set; }

        #endregion
    }
}