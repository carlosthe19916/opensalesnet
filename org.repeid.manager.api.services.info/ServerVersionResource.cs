namespace org.repeid.manager.api.services.info
{

    public interface ServerVersionResource
    {

        public Response getVersionPreflight();

        public VersionRepresentation getVersion();

    }
}
