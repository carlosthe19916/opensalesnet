using System;
using System.Collections.Generic;
using org.ahren.manager.api.beans.representation.search;
using org.ahren.manager.api.beans.representations;

namespace org.ahren.manager.api.services.impl
{
    public class OficinaService : IOficinaService
    {
        public void create(OficinaRepresentation rep)
        {
            throw new NotImplementedException();
        }

        public SearchResultsRepresentation<OficinaRepresentation> search(SearchCriteriaRepresentation criteria)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaRepresentation> search(string abreviatura, string denominacion, string tipoPersona, bool estado, string filterText, int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }
    }
}
