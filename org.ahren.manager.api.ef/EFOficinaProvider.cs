using org.ahren.manager.api.model;
using org.ahren.manager.api.model.provider;
using org.ahren.manager.api.model.search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    public class OficinaProvider : IOficinaProvider
    {

        public OficinaModel create(string denominacion)
        {
            Context cc = new Context();
            cc.
            OficinaEntity entity = new OficinaEntity();
            entity.denominacion = denominacion;
            return new OficinaAdapter(entity);
        }

        public OficinaModel findById(string oficinaId)
        {
            throw new NotImplementedException();
        }

        public void remove(OficinaModel oficina)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> getAll()
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> getAll(int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> search(string filterText)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> search(string filterText, int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> searchByAttributes(IDictionary<string, object> attributes)
        {
            throw new NotImplementedException();
        }

        public IList<OficinaModel> searchByAttributes(IDictionary<string, object> attributes, int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria)
        {
            throw new NotImplementedException();
        }

        public SearchResultsModel<OficinaModel> search(SearchCriteriaModel criteria, string filterText)
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            throw new NotImplementedException();
        }

    }
}
