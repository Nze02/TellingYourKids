using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellingYourKids.Contracts;
using TellingYourKids.Models;

namespace TellingYourKids.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IPostRepository _postRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IPostRepository Post
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_repositoryContext);

                return _postRepository;
            }
        }


        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
