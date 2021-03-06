﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Deventure.DataLayer.Interfaces;

namespace UpWorky.DataLayer.Repositories
{
    public class BaseSinglePkNameRepository<T> : BaseSinglePkRepository<T> where T : class, IDataAccessObjectWithName, new()
    {
        public async Task<IList<T>> GetListByNames(IList<string> names, IList<string> navigationProperties = null)
        {
            for (var i = 0; i < names.Count; i++)
            {
                names[i] = names[i].ToLower();
            }
            return await GetListAsync(entity => names.Contains(entity.Name.ToLower()), navigationProperties).ConfigureAwait(false);
        }

        public async Task<T> GetSingleByNameAsync(string name)
        {
            return await GetSingleAsync(entity => entity.Name == name).ConfigureAwait(false);
        }
    }
}
