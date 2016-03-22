using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace org.ahren.manager.api.model
{
    public interface IBovedaModel : IModel
    {
        String getId();

        String getDenominacion();

        void setDenominacion(String denominacion);

        bool isAbierto();

        void setAbierto(bool abierto);

    }

}
