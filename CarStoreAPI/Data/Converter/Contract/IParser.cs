namespace CarStoreAPI.Data.Converter.Contract
{
    public interface IParser <O,D>
    {
        D Parse(O origin);
        List<D> Parse(IEnumerable<O> origin);
    }
}
