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
    public interface BovedaProvider : Provider
    {
        BovedaModel create(String denominacion);

        BovedaModel findById(String bovedaId);

        void remove(BovedaModel boveda);

        List<BovedaModel> getAll(OficinaModel oficina);

        List<BovedaModel> getAll(OficinaModel oficina, int firstResult, int maxResults);

        List<BovedaModel> search(OficinaModel oficina, String filterText);

        List<BovedaModel> search(OficinaModel oficina, String filterText, int firstResult, int maxResults);

        List<BovedaModel> searchByAttributes(OficinaModel oficina, Dictionary<String, String> attributes);

        List<BovedaModel> searchByAttributes(OficinaModel oficina, Dictionary<String, String> attributes, int firstResult, int maxResults);

        SearchResultsModel<BovedaModel> search(OficinaModel oficina, SearchCriteriaModel criteria);

        SearchResultsModel<BovedaModel> search(OficinaModel oficina, SearchCriteriaModel criteria, String filterText);
    }

}
