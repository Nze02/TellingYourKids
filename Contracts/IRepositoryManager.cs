using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Contracts
{
    public interface IRepositoryManager
    {
        IPostRepository Post { get; }
        Task SaveAsync();
    }
}
