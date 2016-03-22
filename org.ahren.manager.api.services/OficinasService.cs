using System;
using System.Collections.Generic;
using org.ahren.manager.api.beans.representations;
using org.ahren.manager.api.beans.representations.info;
using org.ahren.manager.api.beans.representation.search;
using org.ahren.manager.api.model;
using org.ahren.manager.api.model.provider;
using org.ahren.manager.api.model.exceptions;
using org.ahren.manager.api.model.utils;
using org.ahren.manager.api.model.search;

namespace org.ahren.manager.api.services.impl
{

    public class OficinasService : IOficinasService
    {

        private IOficinaProvider oficinaProvider;  

        public OficinasService(IOficinaProvider oficinaProvider)
        {
            this.oficinaProvider = oficinaProvider;
        }

        public OficinaRepresentation create(OficinaRepresentation rep)
        {
            try
            {
                OficinaModel oficina = oficinaProvider.create(rep.denominacion, rep.ubigeo);
                return ModelToRepresentation.toRepresentation(oficina);
            }
            catch (ModelDuplicateException e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<OficinaRepresentation> search(String filterText, String denominacion, Int32 firstResult, Int32 maxResults)
        {
            firstResult = (firstResult != null ? firstResult : -1);
            maxResults = (maxResults != null ? maxResults : -1);

            IList<OficinaRepresentation> results = new List<OficinaRepresentation>();
            IList<OficinaModel> models;
            if (filterText != null)
            {
                models = oficinaProvider.search(filterText.Trim(), firstResult, maxResults);
            }
            else if (denominacion != null)
            {
                IDictionary<String, Object> attributes = new Dictionary<String, Object>();
                if (denominacion != null)
                {
                    attributes.Add(IOficinaProviderConstants.DENOMINACION, denominacion);
                }
                models = oficinaProvider.searchByAttributes(attributes, firstResult, maxResults);
            }
            else
            {
                models = oficinaProvider.getAll(firstResult, maxResults);
            }

            foreach (var model in models)
            {
                results.Add(ModelToRepresentation.toRepresentation(model));
            }
            return results;
        }

        public SearchResultsRepresentation<OficinaRepresentation> searchCriteria(SearchCriteriaRepresentation criteria)
        {
            SearchCriteriaModel criteriaModel = new SearchCriteriaModel();

            // set filter and order
            foreach (var filter in criteria.filters)
            {
                SearchCriteriaFilterOperator op = (SearchCriteriaFilterOperator)Enum.Parse(typeof(SearchCriteriaFilterOperator), filter.op.ToString());
                criteriaModel.addFilter(filter.name, filter.value, op);
            }
            foreach (var order in criteria.orders)
            {
                criteriaModel.addOrder(order.name, order.ascending);
            }

            // set paging
            PagingRepresentation paging = criteria.paging;
            if (paging == null)
            {
                paging = new PagingRepresentation();
                paging.page = 1;
                paging.pageSize = 20;
            }
            criteriaModel.setPageSize(paging.pageSize);
            criteriaModel.setPage(paging.page);

            // extract filterText
            String filterText = criteria.filterText;

            // search
            SearchResultsModel<OficinaModel> results = null;
            if (filterText == null)
            {
                results = oficinaProvider.search(criteriaModel);
            }
            else
            {
                results = oficinaProvider.search(criteriaModel, filterText);
            }

            SearchResultsRepresentation<OficinaRepresentation> rep = new SearchResultsRepresentation<OficinaRepresentation>();
            IList<OficinaRepresentation> items = new List<OficinaRepresentation>();
            foreach (var model in results.models)
            {
                items.Add(ModelToRepresentation.toRepresentation(model));
            }
            rep.items = items;
            rep.totalSize = results.totalSize;
            return rep;
        }

    }
}
