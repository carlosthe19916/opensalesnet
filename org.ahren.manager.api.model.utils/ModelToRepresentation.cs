using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.ahren.manager.api.beans.representations;

namespace org.ahren.manager.api.model.utils
{
    public class ModelToRepresentation
    {
        public static OficinaRepresentation toRepresentation(IOficinaModel model)
        {
            if (model == null)
                return null;

            OficinaRepresentation rep = new OficinaRepresentation();
            rep.id = model.getId();
            rep.denominacion = model.getDenominacion();
            rep.ubigeo = model.getUbigeo();
            return rep;
        }
    }
}
