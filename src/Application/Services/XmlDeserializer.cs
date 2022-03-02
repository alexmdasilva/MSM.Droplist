using System.Xml.Serialization;

namespace Application.Services
{
    public class XmlDeserializer : IXmlDeserializer
    {
        public TResult? DeserializeXml<TResult>(Stream stream)
        {
            stream.Position = 0;

            var serializer = new XmlSerializer(typeof(TResult));

            return (TResult?)serializer.Deserialize(stream);
        }
    }
}
