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
    public interface OficinaProvider : Provider
    {
        OficinaModel create(String denominacion);

        OficinaModel findById(String oficinaId);

        void remove(OficinaModel oficina);

        List<OficinaModel> getAll();

        List<OficinaModel> getAll(int firstResult, int maxResults);

        List<OficinaModel> search(String filterText);

        List<OficinaModel> search(String filterText, int firstResult, int maxResults);

        List<OficinaModel> searchByAttributes(Dictionary<String, String> attributes);

        List<OficinaModel> searchByAttributes(Dictionary<String, String> attributes, int firstResult, int maxResults);

        SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria);

        SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria, String filterText);
    }

}
