using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.web
{
    [ServiceContract]
    public interface IPrueba
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Posts")]
        String[] GetBlogPosts();
    }
}
