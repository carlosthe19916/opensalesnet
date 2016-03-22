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

    public interface IOficinaProvider : IProvider
    {
        IOficinaModel create(String denominacion, String ubigeo);

        IOficinaModel findById(String oficinaId);

        void remove(IOficinaModel oficina);

        IList<IOficinaModel> getAll();

        IList<IOficinaModel> getAll(int firstResult, int maxResults);

        IList<IOficinaModel> search(String filterText);

        IList<IOficinaModel> search(String filterText, int firstResult, int maxResults);

        IList<IOficinaModel> searchByAttributes(IDictionary<String, Object> attributes);

        IList<IOficinaModel> searchByAttributes(IDictionary<String, Object> attributes, int firstResult, int maxResults);

        SearchResultsModel<IOficinaModel> search(SearchCriteriaModel criteria);

        SearchResultsModel<IOficinaModel> search(SearchCriteriaModel criteria, String filterText);
    }

}
