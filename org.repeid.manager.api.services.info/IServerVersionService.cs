using System;
using System.ServiceModel;
using org.ahren.manager.api.beans.representations.info;

namespace org.repeid.manager.api.services.info
{
    [ServiceContract]
    public interface IServerVersionService
    {
        [OperationContract]
        ServerInfoRepresentation getVersion();
    }
}
