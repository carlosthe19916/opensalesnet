using System;
using System.Collections.Generic;

namespace org.ahren.manager.api.model.search
{

    public class SearchResultsModel<T>
    {

        public IList<T> models = new List<T>();
        public int totalSize { get; set; }

        public SearchResultsModel()
        {
            models = new List<T>();
        }

    }
}
