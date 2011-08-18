using System.Runtime.Serialization;

namespace SampleWcf.Web
{

    [DataContract]
    public struct FileDescriptor
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Contents { get; set; }
    }

}
