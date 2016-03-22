using System;
using System.Collections.Generic;
using org.ahren.manager.api.beans.representations.info;
using org.repeid.manager.api.services.info;

namespace org.ahren.manager.api.services.info.impl
{
    public class ServerInfoService : IServerInfoService
    {
        public ServerInfoRepresentation getVersion()
        {
            ServerInfoRepresentation serverInfo = new ServerInfoRepresentation();
            serverInfo.version = "1.0.0.Final";
            return serverInfo;
        }
    }
}
