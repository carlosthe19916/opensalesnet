using org.ahren.manager.api.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    public class OficinaAdapter : IOficinaModel
    {
        private OficinaEntity oficinaEntity;

        public OficinaAdapter(OficinaEntity oficinaEntity)
        {
            this.oficinaEntity = oficinaEntity;
        }                

        string IOficinaModel.getId()
        {
            return oficinaEntity.id;
        }

        string IOficinaModel.getDenominacion()
        {
            return oficinaEntity.denominacion;
        }

        string IOficinaModel.getUbigeo()
        {
            return oficinaEntity.ubigeo;
        }

        ISet<ICajaModel> IOficinaModel.getCajas()
        {
            throw new NotImplementedException();
        }

        ISet<IBovedaModel> IOficinaModel.getBovedas()
        {
            throw new NotImplementedException();
        }
    }
}
