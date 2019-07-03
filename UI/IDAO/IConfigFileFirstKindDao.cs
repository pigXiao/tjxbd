﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace IDAO
{
    public interface IConfigFileFirstKindDao<T>
    {

        List<T> FindAll();
        int Add(T t);
        int Del(T t);
        int Change(T t);
        List<T> SelectWhere(Expression<Func<T, bool>> where);

    }
}
