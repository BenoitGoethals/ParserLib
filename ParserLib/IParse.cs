using System.Collections.Generic;

namespace ParserLib
{
    public interface IParse<T>
    {
        List<T> Parse();
    }
}
