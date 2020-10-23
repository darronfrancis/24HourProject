using SocialNetwork.Data;
using SocialNetwork.Data;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Services
{
    public class PostService
    {
        public readonly Guid _userId;
        public readonly int _postId;
        private Guid userId;

        public PostService(Guid userId)
        {
            this.userId = userId;
        }

        public PostService(Guid userId, int postId)
        {
            _userId = userId;
            _postId = postId;
        }

        public bool CreatePost(CreatePost post)
        {
            var entity = new Post()
            {
                Title = post.Title,
                Text = post.Text
            };

            using (var context = new ApplicationDbContext())
            {
                context.Posts.Add(entity);
                return context.SaveChanges() == 1;
            }
        }

        public IEnumerable<ListPost> GetPosts()
        {
            using (var context = new ApplicationDbContext())
            {
                var query =
                    context
                        .Posts
                        .Where(e => e.PostId == _postId)
                        .Select(
                            e =>
                                new ListPost
                                {
                                    PostId = e.PostId,
                                    Title = e.Title
                                }
                            );

                return query.ToArray();
            }
        }
    }
}
