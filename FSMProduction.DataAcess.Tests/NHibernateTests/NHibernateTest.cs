using System;
using FSMProductionDataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSMProduction.DataAcess.Tests.EntityFrameworkTests
{
    
    
        [TestClass]
        public class EntityFrameworkTest
        {
            [TestMethod]
            public void Get_all_returns_all_workgroup()
            {
                EfWorkgroupDal workgroupDal = new EfWorkgroupDal();

                var result = workgroupDal.GetList();

                Assert.AreEqual(1, result.Count);
            }
            [TestMethod]
            public void Get_all_parameter_returns_filtered_workgroup()
            {
                EfWorkgroupDal workgroupDal = new EfWorkgroupDal();
                var result = workgroupDal.GetList(p => p.Description.Contains("FS"));
                Assert.AreEqual(1, result.Count);
            }
        }
    }
  