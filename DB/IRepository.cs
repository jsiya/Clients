using System.Collections.Generic;
using System;

namespace Clients.DB;

internal interface IRepository<T>
{
    T? Get(Func<T, bool> predicate);
    IList<T>? GetList(Func<T, bool>? predicate = null);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
}
