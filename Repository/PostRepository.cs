using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellingYourKids.Contracts;
using TellingYourKids.Models;

namespace TellingYourKids.Repository
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Post>> GetAllApprovedPostsAsync(bool trackChanges) =>
            await FindByCondition(p => p.Status.Equals("Approved"), trackChanges)
            .OrderBy(p => p.Date)
            .ToListAsync();

        public async Task<IEnumerable<Post>> GetAllUnApprovedPostsAsync(bool trackChanges) =>
            await FindByCondition(p => p.Status.Equals("Not Approved"), trackChanges)
            .OrderBy(p => p.Date)
            .ToListAsync();


        public async Task<Post> GetPostAsync(int postId, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(postId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Post>> GetByIdsAsync(IEnumerable<int> ids, bool trackChanges) =>
            await FindByCondition(p => ids.Contains(p.Id), trackChanges)
            .ToListAsync();


        public void CreatePost(Post post) => Create(post);

        public void DeletePost(Post post)
        {
            Delete(post);
        }
    }
}
