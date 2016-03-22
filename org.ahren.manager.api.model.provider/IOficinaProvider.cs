using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using org.ahren.manager.api.model;
using org.ahren.manager.api.model.search;

namespace org.ahren.manager.api.model.provider
{
    public class IOficinaProviderConstants { 
        public static String DENOMINACION = "denominacion";
    }

    public interface IOficinaProvider : Provider
    {
        OficinaModel create(String denominacion, String ubigeo);

        OficinaModel findById(String oficinaId);

        void remove(OficinaModel oficina);

        IList<OficinaModel> getAll();

        IList<OficinaModel> getAll(int firstResult, int maxResults);

        IList<OficinaModel> search(String filterText);

        IList<OficinaModel> search(String filterText, int firstResult, int maxResults);

        IList<OficinaModel> searchByAttributes(IDictionary<String, Object> attributes);

        IList<OficinaModel> searchByAttributes(IDictionary<String, Object> attributes, int firstResult, int maxResults);

        SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria);

        SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria, String filterText);
    }

}
