﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IUsersRolesDao<T>
    {
        List<T> FindAll();
        int Add(T t);
        int Del(T t);
        int Change(T t);
        List<T> FenYe<K>(int pageIndex, int pageSize, out int Count, Expression<Func<T, bool>> where, Expression<Func<T, K>> order);

    }
}
