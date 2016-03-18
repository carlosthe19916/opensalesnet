using org.repeid.manager.api.services.info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using org.ahren.manager.api.beans.representations.info;

namespace org.ahren.manager.api.services.info.impl
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceVersionService : IServerVersionService
    {
        public ServerInfoRepresentation getVersion()
        {
            return new ServerInfoRepresentation();
        }
    }
}