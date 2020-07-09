using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace SocialNetworkCoreDAL.Entities
{
    public class User : IdentityUser<int>
    {
        #region navigation properties

        public IList<Friendship> RequestedFriendships { get; set; }
        public IList<Friendship> AcceptedFriendships { get; set; }
        public IList<Post> Posts { get; set; }

        #endregion
    }
}
