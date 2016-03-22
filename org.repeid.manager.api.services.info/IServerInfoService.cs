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
        [WebInvoke(Method = "GET", UriTemplate = "/serverinfo/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ServerInfoRepresentation getVersion();
    }
}
