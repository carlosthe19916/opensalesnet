using System;
using System.Collections.Generic;

namespace org.ahren.manager.api.model.search
{
    public class SearchCriteriaModel
    {
        public IList<SearchCriteriaFilterModel> filters { get; set; }
        public IList<OrderByModel> orders { get; set; }
        public PagingModel paging { get; set; }

        public SearchCriteriaModel()
        {
        }
               
        public void addFilter(String name, Object value, SearchCriteriaFilterOperator op)
        {
            SearchCriteriaFilterModel filter = new SearchCriteriaFilterModel();
            filter.name = name;
            filter.value = value;
            filter.op = op;
            filters.Add(filter);
        }

        public void addFilter(SearchCriteriaFilterModel filter)
        {
            filters.Add(filter);
        }

        public void addOrder(String name, bool ascending)
        {
            OrderByModel orderBy = new OrderByModel();
            orderBy.name = name;
            orderBy.ascending = ascending;
            orders.Add(orderBy);
        }

        public void addOrder(OrderByModel orderBy)
        {
            orders.Add(orderBy);
        }
      
        public void setPage(int page)
        {
            if (this.paging == null)
                this.paging = new PagingModel();
            this.paging.page = page;
        }

        public void setPageSize(int pageSize)
        {
            if (this.paging == null)
                this.paging = new PagingModel();
            this.paging.pageSize = pageSize; 
        }

    }

}