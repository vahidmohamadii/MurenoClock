

namespace BusinessLayer.Interfaces;

public interface ICountOfQuery<T> where T : class
{
    int Count();

}
