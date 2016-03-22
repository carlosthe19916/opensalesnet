using org.ahren.manager.api.model;
using org.ahren.manager.api.model.provider;
using org.ahren.manager.api.model.search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace org.ahren.manager.api.ef.entities
{
    public class OficinaProvider : IOficinaProvider
    {

        public IOficinaModel create(string denominacion, String ubigeo)
        {
            using (var ctx = new OpensalesContext())
            {
                OficinaEntity entity = new OficinaEntity();
                entity.denominacion = denominacion;
                entity.ubigeo = ubigeo;

                ctx.OficinasEntity.Add(entity);
                ctx.SaveChanges();

                return new OficinaAdapter(entity);
            }        
        }

        public IOficinaModel findById(string oficinaId)
        {
            using (var ctx = new OpensalesContext())
            {
                OficinaEntity entity = ctx.OficinasEntity.Find(oficinaId);
                return new OficinaAdapter(entity);
            }  
        }

        public void remove(IOficinaModel oficina)
        {
            using (var ctx = new OpensalesContext())
            {
                OficinaEntity entity = ctx.OficinasEntity.Find(oficina.getId());
                ctx.OficinasEntity.Remove(entity);
                ctx.SaveChanges();
            }
        }

        public IList<IOficinaModel> getAll()
        {
            throw new NotImplementedException();
        }

        public IList<IOficinaModel> getAll(int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public IList<IOficinaModel> search(string filterText)
        {
            throw new NotImplementedException();
        }

        public IList<IOficinaModel> search(string filterText, int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public IList<IOficinaModel> searchByAttributes(IDictionary<string, object> attributes)
        {
            throw new NotImplementedException();
        }

        public IList<IOficinaModel> searchByAttributes(IDictionary<string, object> attributes, int firstResult, int maxResults)
        {
            throw new NotImplementedException();
        }

        public SearchResultsModel<IOficinaModel> search(SearchCriteriaModel criteria)
        {
            throw new NotImplementedException();
        }

        public SearchResultsModel<IOficinaModel> search(SearchCriteriaModel criteria, string filterText)
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            throw new NotImplementedException();
        }

    }
}
