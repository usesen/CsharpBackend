using System;
using FSMProductionDataAccess.Concrete.EntityFramework;
using FSMProductionDataAccess.Concrete.NHibernate;
using FSMProductionDataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSMProduction.DataAcess.Tests.EntityFrameworkTests
{
    
    
        [TestClass]
        public class NHibernateTest
    {
            [TestMethod]
            public void Get_all_returns_all_workgroup()
            {
                NhWorkgroupDal workgroupDal = new NhWorkgroupDal(new SqlServerHelper());

                var result = workgroupDal.GetList();

                Assert.AreEqual(1, result.Count);
            }
            [TestMethod]
            public void Get_all_parameter_returns_filtered_workgroup()
            {
                NhWorkgroupDal workgroupDal = new NhWorkgroupDal(new SqlServerHelper());
                var result = workgroupDal.GetList(p => p.Description.Contains("FS"));
                Assert.AreEqual(1, result.Count);
            }
        }
    }
  