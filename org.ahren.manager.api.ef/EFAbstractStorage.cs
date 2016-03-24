using org.ahren.manager.api.ef.entities;
using org.ahren.manager.api.model.search;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef
{

    public abstract class EFAbstractStorage<T> where T : class
    {

        protected OpensalesContext Context;

        public EFAbstractStorage()
        {
            Context = new OpensalesContext();
        }

        protected SearchResultsModel<T> find(SearchCriteriaModel criteria)
        {
            SearchResultsModel<T> results = new SearchResultsModel<T>();
            IQueryable<T> sequence = Context.Set<T>();

            // Set some default in the case that paging information was not
            // included in the request.
            PagingModel paging = criteria.paging;
            if (paging == null)
            {
                paging = new PagingModel();
                paging.page = 1;
                paging.pageSize = 20;
            }
            int page = paging.page;
            int pageSize = paging.pageSize;
            int start = (page - 1) * pageSize;

            applySearchCriteriaToQuery(criteria, sequence, false);

            sequence.Skip(start);
            sequence.Take(pageSize + 1);
            bool hasMore = false;

            // Now query for the actual results
            List<T> resultList = sequence.ToList();

            // Check if we got back more than we actually needed.
            if (resultList.Count > pageSize)
            {
                resultList.RemoveAt(resultList.Count - 1);
                hasMore = true;
            }

            // If there are more results than we needed, then we will need to do
            // another
            // query to determine how many rows there are in total
            int totalSize = start + sequence.Count();
            if (hasMore)
            {
                totalSize = executeCountQuery(criteria, Context.Set<T>());
            }
            results.totalSize = totalSize;
            results.models = resultList;

            return results;
        }

        protected int executeCountQuery(SearchCriteriaModel criteria, IQueryable<T> sequence)
        {
            applySearchCriteriaToQuery(criteria, sequence, true);
            return sequence.Count();
        }


        protected void applySearchCriteriaToQuery(SearchCriteriaModel criteria, IQueryable<T> sequence, bool countOnly) 
        {        
            IList<SearchCriteriaFilterModel> filters = criteria.filters;
            if (filters != null && filters.Count > 0) {
                foreach (var filter in filters) 
                {                                                                    
                    if (filter.op == SearchCriteriaFilterOperator.eq) {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.Equal(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);                                             
                        sequence = sequence.Where(lambda);               
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.bool_eq)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Boolean));
                        BinaryExpression expression = Expression.Equal(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.gt)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.GreaterThan(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.gte)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.GreaterThanOrEqual(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.lt)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.LessThan(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.lte)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.LessThanOrEqual(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.neq)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        MemberExpression Left = Expression.MakeMemberAccess(parameter, typeof(T).GetProperty(filter.name));
                        ConstantExpression Right = Expression.Constant(filter.value, typeof(Object));
                        BinaryExpression expression = Expression.NotEqual(Left, Right);
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
                        sequence = sequence.Where(lambda);
                    }
                    else if (filter.op == SearchCriteriaFilterOperator.like)
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        var getter = Expression.Property(parameter, filter.name);                   
                        var stringContainsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                        var containsCall = Expression.Call(getter, stringContainsMethod, Expression.Constant(filter.value, typeof(string)));
                        Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(containsCall, parameter);
                        sequence = sequence.Where(lambda);
                    }
                }
            }
            IList<OrderByModel> orders = criteria.orders;
            if (orders != null && orders.Count > 0 && !countOnly) 
            {
                foreach (var orderBy in orders) 
                {
                    if (orderBy.ascending) 
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));                      
                        var sortExpression = Expression.Lambda<Func<T, object>>(Expression.Property(parameter, orderBy.name), parameter);
                        sequence = ((IOrderedQueryable<T>)sequence).OrderBy(sortExpression);
                    }
                    else 
                    {
                        ParameterExpression parameter = Expression.Parameter(typeof(T));
                        var sortExpression = Expression.Lambda<Func<T, object>>(Expression.Property(parameter, orderBy.name), parameter);
                        sequence = ((IOrderedQueryable<T>)sequence).OrderByDescending(sortExpression);
                    }
                }
            }
            else
            {
                sequence = ((IOrderedQueryable<T>)sequence).OrderBy(x => (true));
            }
        }
    }
}
