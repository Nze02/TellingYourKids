using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellingYourKids.Models;

namespace TellingYourKids.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllApprovedPostsAsync(bool trackChanges);

        Task<IEnumerable<Post>> GetAllUnApprovedPostsAsync(bool trackChanges);

        Task<Post> GetPostAsync(int postId, bool trackChanges);

        Task<IEnumerable<Post>> GetByIdsAsync(IEnumerable<int> ids, bool trackChanges);

        void CreatePost(Post post);

        void DeletePost(Post post);
    }
}
