using System;

namespace org.ahren.manager.api.model.exceptions
{
    public class ModelReadOnlyException : ModelException
    {
        public ModelReadOnlyException()
        {
        }

        public ModelReadOnlyException(String message) : base (message)
        {           
        }

        public ModelReadOnlyException(String message, Exception cause) : base (message, cause)
        {       
        }

        public ModelReadOnlyException(Exception cause) : base("", cause)
        {
        }
    }
}
