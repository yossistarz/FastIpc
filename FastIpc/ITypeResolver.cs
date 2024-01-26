using System;
using System.Collections.Generic;
using System.Text;

namespace CVV
{
    public interface ITypeResolver
    {
        Type ResolveType(Type type);
    }
}
