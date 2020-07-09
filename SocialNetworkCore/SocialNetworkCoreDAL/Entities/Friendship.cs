using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SocialNetworkCoreDAL.Entities
{
    public class Friendship
    {
        public int Id { get; set; }
        public bool IsAccepted { get; set; }

        #region foreign keys
        
        public int RequestUserId { get; set; }
        public int AcceptUserId { get; set; }

        #endregion

        #region navigation properties

        public User RequestUser { get; set; }
        public User AcceptUser { get; set; }
        public IList<Message> Messages { get; set; }

        #endregion
    }
}
