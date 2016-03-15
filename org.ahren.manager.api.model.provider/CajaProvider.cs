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
    public interface CajaProvider : Provider
    {
        CajaModel create(String denominacion);

        CajaModel findById(String cajaId);

        void remove(CajaModel caja);

        List<CajaModel> getAll(OficinaModel oficina);

        List<CajaModel> getAll(OficinaModel oficina, int firstResult, int maxResults);

        List<CajaModel> search(OficinaModel oficina, String filterText);

        List<CajaModel> search(OficinaModel oficina, String filterText, int firstResult, int maxResults);

        List<CajaModel> searchByAttributes(OficinaModel oficina, Dictionary<String, String> attributes);

        List<CajaModel> searchByAttributes(OficinaModel oficina, Dictionary<String, String> attributes, int firstResult, int maxResults);

        SearchResultsModel<CajaModel> search(OficinaModel oficina, SearchCriteriaModel criteria);

        SearchResultsModel<CajaModel> search(OficinaModel oficina, SearchCriteriaModel criteria, String filterText);
    }

}
