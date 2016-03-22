using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;

namespace org.ahren.manager.api.model
{
    public interface IOficinaModel : IModel
    {

        String getId();

        String getDenominacion();

        String getUbigeo();

        ISet<ICajaModel> getCajas();

        ISet<IBovedaModel> getBovedas();

    }

}
