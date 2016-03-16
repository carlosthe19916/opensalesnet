using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
	[DataContract]
    public enum SearchCriteriaFilterOperatorRepresentation
    {
        bool_eq, eq, neq, gt, gte, lt, lte, like
    };
}
