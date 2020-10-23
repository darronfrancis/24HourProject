using SocialNetwork.Data;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Services
{
    public class UserService
    {
        public readonly Guid _userId;
        
        public UserService(Guid userId)
        {
            _userId = userId;
        }
    }
}
