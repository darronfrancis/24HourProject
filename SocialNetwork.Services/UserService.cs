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

/*        public bool CreateUser(CreateUser user)
        {
            var entity = new User()
            {
                Name = user.Name,
                Email = user.Email
            };

            using (var context = new ApplicationDbContext())
            {
                context.Users.Add(entity);
                return context.SaveChanges() == 1;
            }
        }*/

        public IEnumerable<ListUser> GetUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                var query =
                    context
                        .Users
                        .Where(e => e != null)
                        .Select(
                            e =>
                                new ListUser
                                {
                                    Name = e.UserName,
                                }
                            );

                return query.ToArray();
            }
        }
    }
}
