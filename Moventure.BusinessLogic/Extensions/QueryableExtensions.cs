﻿using System.Collections.Generic;
using System.Linq;
using Deventure.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace UpWorky.DataLayer.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplyNavigationProperties<T>(this IQueryable<T> dbQuery, IList<string> navigationProperties)
            where T : class, IDataAccessObject
        {
            if (navigationProperties != null)
            {
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));
            }

            return dbQuery;
        }
    }
}
