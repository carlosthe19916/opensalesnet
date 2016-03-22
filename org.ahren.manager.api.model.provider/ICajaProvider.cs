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
    public interface ICajaProvider : IProvider
    {
        ICajaModel create(String denominacion);

        ICajaModel findById(String cajaId);

        void remove(ICajaModel caja);

        List<ICajaModel> getAll(IOficinaModel oficina);

        List<ICajaModel> getAll(IOficinaModel oficina, int firstResult, int maxResults);

        List<ICajaModel> search(IOficinaModel oficina, String filterText);

        List<ICajaModel> search(IOficinaModel oficina, String filterText, int firstResult, int maxResults);

        List<ICajaModel> searchByAttributes(IOficinaModel oficina, Dictionary<String, String> attributes);

        List<ICajaModel> searchByAttributes(IOficinaModel oficina, Dictionary<String, String> attributes, int firstResult, int maxResults);

        SearchResultsModel<ICajaModel> search(IOficinaModel oficina, SearchCriteriaModel criteria);

        SearchResultsModel<ICajaModel> search(IOficinaModel oficina, SearchCriteriaModel criteria, String filterText);
    }

}
