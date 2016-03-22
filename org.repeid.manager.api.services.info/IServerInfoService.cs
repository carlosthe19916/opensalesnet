using System;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations.info;
using System.ServiceModel.Web;

namespace org.repeid.manager.api.services.info
{
    [ServiceContract]
    public interface IServerInfoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/serverinfo/")]
        ServerInfoRepresentation getVersion();
    }
}
