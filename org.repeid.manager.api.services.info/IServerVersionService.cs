using System;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations.info;
using System.ServiceModel.Web;

namespace org.repeid.manager.api.services.info
{
    [ServiceContract]
    public interface IServerVersionService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/serverinfo")]
        ServerInfoRepresentation getVersion();
    }
}
