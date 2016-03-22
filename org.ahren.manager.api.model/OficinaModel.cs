using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;

namespace org.ahren.manager.api.model
{
    public interface OficinaModel : Model
    {

        String getId();

        String getDenominacion();

        String getUbigeo();

        ISet<CajaModel> getCajas();

        ISet<BovedaModel> getBovedas();

    }

}
