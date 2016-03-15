using System;

namespace org.ahren.manager.api.beans.representation.search
{
    public class PagingRepresentation
    {
       
        private int page { get; set; }

        private int pageSize;

        public int getPage()
        {
            return page;
        }

        public void setPage(int page)
        {
            this.page = page;
        }

        public int getPageSize()
        {
            return pageSize;
        }

        public void setPageSize(int pageSize)
        {
            this.pageSize = pageSize;
        }

    }
}
