using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations;

namespace org.ahren.manager.api.services
{
    [ServiceContract]
    public interface IOficinaService
    {

        TipoDocumentoResource oficina(String oficinaId);

        void create(OficinaRepresentation rep);

        IList<OficinaRepresentation> search(String abreviatura,
            String denominacion, String tipoPersona,
            Boolean estado, String filterText,
            Int32 firstResult, Int32 maxResults);

        SearchResultsRepresentation<OficinaRepresentation> search(SearchCriteriaRepresentation criteria);


        [OperationContract]
        void AddProductDetail(string productName, string productDescription);

        [OperationContract]
        void UpdateProductDetail(int updateId, string productName, string productDescription);

        [OperationContract]
        void DeleteProductDetail(int id);

        [OperationContract]
        string EditProductDetail(int id);

        [OperationContract]
        string LoadAllProductDetail();

    }
}
