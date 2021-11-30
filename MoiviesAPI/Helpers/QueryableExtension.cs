using MoiviesAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiviesAPI.Helpers
{
    public static class QueryableExtension
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, PaginationDTO pagination)
        {
            return queryable
                .Skip((pagination.Page - 1) * pagination.RecordsPerPage)
                .Take(pagination.RecordsPerPage);
        }
    }
}
