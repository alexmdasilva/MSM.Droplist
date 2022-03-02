namespace Application.Services
{
    public interface IXmlDeserializer
    {
        public TResult? DeserializeXml<TResult>(Stream stream);
    }
}
