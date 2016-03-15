using System;

namespace org.ahren.manager.api.model.exceptions
{
    public class ModelException : SystemException
    {

        private Object[] parameters;

        public ModelException()
        {
        }

        public ModelException(String message) : base (message)
        {
        }

        public ModelException(String message, params Object[] parameters) : base(message)
        {
            this.parameters = parameters;
        }

        public ModelException(String message, Exception cause) : base(message, cause)
        {
        }

        public ModelException(Exception cause) : base("", cause)
        {
        }

        public Object[] getParameters()
        {
            return parameters;
        }

        public void setParameters(Object[] parameters)
        {
            this.parameters = parameters;
        }
    }

}