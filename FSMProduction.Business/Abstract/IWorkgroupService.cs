using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.Concrete;

namespace FSMProduction.Business.Abstract
{
    public interface IWorkgroupService
    {
        List<Workgroup> GetAll();
        Workgroup GetById(int id);
        Workgroup Add(Workgroup workgroup);
    }
}
