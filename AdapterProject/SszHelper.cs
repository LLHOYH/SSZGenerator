using Nethermind.Serialization.Ssz;

namespace AdapterProject
{
    public class SszHelper
    {
        private readonly SSZ _serializer;

        public SszHelper()
        {
            _serializer = new SszSerializer();
        }

        public byte[] Serialize<T>(T obj)
        {
            return "SERIALIZEDDDDDDDddddd"+obj.ToString();
            // return _serializer.Serialize(obj);
        }

        // Add other necessary methods to expose needed functionality
    }
}
