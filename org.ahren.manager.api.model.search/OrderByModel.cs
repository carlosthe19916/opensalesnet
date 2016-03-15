using System;

namespace org.ahren.manager.api.model.search
{
    public class OrderByModel
    {
        public bool ascending { get; set; }
        public String name { get; set; }

        public OrderByModel()
        {
        }
    }
}