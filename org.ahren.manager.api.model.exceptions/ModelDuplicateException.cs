using System;

namespace org.ahren.manager.api.model.exceptions
{
    public class ModelDuplicateException : ModelException
    {

        private String duplicateFieldName;

        public ModelDuplicateException()
        {
        }

        public ModelDuplicateException(String message) : base(message)
        {
        }

        public ModelDuplicateException(String message, String duplicateFieldName) : base(message)
        {
            this.duplicateFieldName = duplicateFieldName;
        }

        public ModelDuplicateException(String message, Exception cause) : base(message, cause)
        {
        }

        public ModelDuplicateException(Exception cause) : base("", cause)
        {
        }

        public String getDuplicateFieldName()
        {
            return duplicateFieldName;
        }

    }

}