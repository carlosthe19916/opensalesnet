using org.ahren.manager.api.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    public class OficinaAdapter : OficinaModel
    {
        private OficinaEntity oficinaEntity;

        public OficinaAdapter(OficinaEntity oficinaEntity)
        {
            this.oficinaEntity = oficinaEntity;
        }

        String getId()
        {
            return oficinaEntity.id;
        }

        String getDenominacion()
        {
            return oficinaEntity.denominacion;
        }

        String getUbigeo()
        {
            return oficinaEntity.ubigeo;
        }

        ISet<CajaModel> getCajas()
        {
            return null;
        }

        ISet<BovedaModel> getBovedas()
        {
            return null;
        }

        string OficinaModel.getId()
        {
            throw new NotImplementedException();
        }

        string OficinaModel.getDenominacion()
        {
            throw new NotImplementedException();
        }

        string OficinaModel.getUbigeo()
        {
            throw new NotImplementedException();
        }

        ISet<CajaModel> OficinaModel.getCajas()
        {
            throw new NotImplementedException();
        }

        ISet<BovedaModel> OficinaModel.getBovedas()
        {
            throw new NotImplementedException();
        }
    }
}
