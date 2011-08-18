using System.Collections.Generic;
using System.ServiceModel;

namespace SampleWcf.Web
{

    [ServiceContract]
    public interface IFileTracker
    {

        [OperationContract]
        void Track(IEnumerable<string> files);

    }

}
