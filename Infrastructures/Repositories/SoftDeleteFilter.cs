﻿using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Infrastructures.Repositories
{
    public static class SoftDeleteFilter
    {
        public static IQueryable<T> ApplyIsNotDeletedFilter<T>(this IQueryable<T> query) where T : class, IHasSoftDelete
        {
            return query.Where(x => x.IsNotDeleted == true);
        }
        public static IQueryable<T> ApplyIsDeletedFilter<T>(this IQueryable<T> query) where T : class, IHasSoftDelete
        {
            return query.Where(x => x.IsNotDeleted == false);
        }
    }
}
