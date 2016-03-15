using System;

namespace org.ahren.manager.api.model.search
{
    public class SearchCriteriaFilterModel
    {
        public String name { get; set; }
        public Object value { get; set; }
        public SearchCriteriaFilterOperator op { get; set; }

        public SearchCriteriaFilterModel()
        {
        }
    }
}
