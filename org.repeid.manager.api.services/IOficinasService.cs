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
        [WebInvoke(Method = "POST", UriTemplate = "/oficinas", 
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        OficinaRepresentation create(OficinaRepresentation rep);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/oficinas?filterText={filterText}&denominacion={denominacion}&firstResult={firstResult}&maxResults={maxResults}", 
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<OficinaRepresentation> search(String filterText, String denominacion, Int32 firstResult, Int32 maxResults);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/oficinas/search", 
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]        
        SearchResultsRepresentation<OficinaRepresentation> searchCriteria(SearchCriteriaRepresentation criteria);

    }
}
