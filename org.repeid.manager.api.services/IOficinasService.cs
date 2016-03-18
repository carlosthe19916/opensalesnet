using System;
using System.Collections.Generic;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations;
using org.ahren.manager.api.beans.representation.search;
using System.ServiceModel.Web;

namespace org.ahren.manager.api.services
{
    [ServiceContract]
    public interface IOficinasService
    {      

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/oficinas")]
        void create(OficinaRepresentation rep);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/oficinas")]
        IList<OficinaRepresentation> search(String denominacion, String filterText, Int32 firstResult, Int32 maxResults);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/oficinas/search")]
        SearchResultsRepresentation<OficinaRepresentation> search(SearchCriteriaRepresentation criteria);

    }
}
