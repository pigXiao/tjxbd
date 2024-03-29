﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;
using IBLL;
using IDAO;
using IocContainer;
using System.Data;

namespace BLL
{
    public class HumanFileBll : IHumanFileBll
    {
        IHumanFileDao<human_file> dao = IocCreate.CreateDao<IHumanFileDao<human_file>>("HumanFileDao");

        public int Add(human_file t)
        {
            return dao.Add(t);
        }

        public int Change(human_file t)
        {
            return dao.Change(t);
        }

        public int Del(human_file t)
        {
            return dao.Del(t);
        }

        public List<human_file> FindAll()
        {
            return dao.FindAll();
        }

        public List<human_file> FindAllHumanFileByState(int pageInxex, int pageSize, out int count, System.Linq.Expressions.Expression<Func<human_file, bool>> where)
        {
            return dao.FindAllHumanFileByState(pageInxex, pageSize, out count, where);
        }

        public List<human_file> FindCheckList(int pageInxex, int pageSize, out int count)
        {
            return dao.FindCheckList(pageInxex, pageSize, out count);
        }

        public human_file FindHumanFileByHumanId(string humanid)
        {
            return dao.FindHumanFileByHumanId(humanid);
        }
        public DataTable Selectfirst(string fileName)
        {
            return dao.Selectfirst(fileName);
        }

        public DataTable SelectSecond(string id, string fileName)
        {
            return dao.SelectSecond(id, fileName);
        }
        public DataTable SelectThird(string id, string fileName)
        {
            return dao.SelectThird(id, fileName);
        }
        public List<human_file> FenYe(int pageIndex, int pageSize, out int Count)
        {
            return dao.FenYe<int>(pageIndex, pageSize, out Count, e => e.huf_id != 0, e => e.huf_id);
        }

        public List<human_file> SelectWhere(int id)
        {
            return dao.SelectWhere(t => t.huf_id == id);
        }

        
    }
}
