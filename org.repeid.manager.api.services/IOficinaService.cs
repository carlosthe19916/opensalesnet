using System;
using System.Collections.Generic;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations;
using org.ahren.manager.api.beans.representation.search;
using System.ServiceModel.Web;

namespace org.ahren.manager.api.services
{
    [ServiceContract]
    public interface IOficinaService
    {

        //TipoDocumentoResource oficina(String oficinaId);

        [WebInvoke]
        [OperationContract]
        void create(OficinaRepresentation rep);

        [WebGet]
        [OperationContract]
        IList<OficinaRepresentation> search(String abreviatura, String denominacion, String tipoPersona, 
            Boolean estado, String filterText, Int32 firstResult, Int32 maxResults);

        [WebInvoke]
        [OperationContract]        
        SearchResultsRepresentation<OficinaRepresentation> search(SearchCriteriaRepresentation criteria);            

    }
}
