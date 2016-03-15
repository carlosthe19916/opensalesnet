using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace org.ahren.manager.api.model
{
    public interface HistorialCajaModel : Model
    {
        String getId();

        DateTime getFechaApertura();

        DateTime getFechaCierre();

    }
}