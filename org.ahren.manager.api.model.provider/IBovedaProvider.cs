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
    public interface IBovedaProvider : IProvider
    {
        IBovedaModel create(String denominacion);

        IBovedaModel findById(String bovedaId);

        void remove(IBovedaModel boveda);

        List<IBovedaModel> getAll(IOficinaModel oficina);

        List<IBovedaModel> getAll(IOficinaModel oficina, int firstResult, int maxResults);

        List<IBovedaModel> search(IOficinaModel oficina, String filterText);

        List<IBovedaModel> search(IOficinaModel oficina, String filterText, int firstResult, int maxResults);

        List<IBovedaModel> searchByAttributes(IOficinaModel oficina, Dictionary<String, String> attributes);

        List<IBovedaModel> searchByAttributes(IOficinaModel oficina, Dictionary<String, String> attributes, int firstResult, int maxResults);

        SearchResultsModel<IBovedaModel> search(IOficinaModel oficina, SearchCriteriaModel criteria);

        SearchResultsModel<IBovedaModel> search(IOficinaModel oficina, SearchCriteriaModel criteria, String filterText);
    }

}
