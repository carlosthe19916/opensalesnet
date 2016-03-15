using System;

namespace org.ahren.manager.api.model.search {
    public class PagingModel
    {
        public int page { get; set; }
        public int pageSize { get; set; }
       
        public PagingModel()
        {
        }
    }
}
