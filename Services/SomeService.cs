using IssueRepro30147.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IssueRepro30147.Services
{
    public interface ISomeService
    {
        void ConvertToDictionary<T>(List<T> collection) 
            where T : IUniqueResource;
    }

    public class SomeService : ISomeService
    {
        public void ConvertToDictionary<T>(List<T> collection)
            where T : IUniqueResource

        {
            var dictionary = collection.ToDictionary(t => t.Id, t => t);
        }
    }
}
