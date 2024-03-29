﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using IBLL;
using IDAO;
using IocContainer;
namespace BLL
{
    //IBLL.IEngageMajorReleaseBll bll = IocContainer.IocCreate.CreateBll<IBLL.IEngageMajorReleaseBll>("EngageMajorReleaseBll");

    class EngageMajorReleaseBll : IEngageMajorReleaseBll
    {
        IEngageMajorReleaseDao<engage_major_release> dao = IocCreate.CreateDao<IEngageMajorReleaseDao<engage_major_release>>("EngageMajorReleaseDao");

        public int Add(engage_major_release t)
        {
            return dao.Add(t);
        }

        public int Change(engage_major_release t)
        {
            return dao.Change(t);
        }

        public int Del(engage_major_release t)
        {
            return dao.Del(t);
        }

        public engage_major_release FindAEngageMajorReleaseByMreID(int id)
        {
            return dao.FindAEngageMajorReleaseByMreID(id);
        }

        public List<engage_major_release> FindAll()
        {
            return dao.FindAll();
        }

        public List<engage_major_release> FindAllEngageMajorReleaseByPage(int pageIndex, int pageSize, out int Count)
        {
            return dao.FindAllEngageMajorReleaseByPage(pageIndex, pageSize, out Count);
        }
    }
}
