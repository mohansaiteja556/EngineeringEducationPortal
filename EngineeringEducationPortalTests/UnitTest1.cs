using System;
using EEP_Models.Models;
using EEP_Repository;
using EEP_Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EngineeringEducationPortalTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
           
            Mock<RepositoryDept> chk = new Mock<RepositoryDept>();
            
            Department mockdept = new Department();
            mockdept.DeptId = "101";
            mockdept.DeptName = "ECE";
            mockdept.DeptRole = "10345";
            chk.Setup(x => x.Deptadd(It.IsAny<Department>())).Returns(5);

            //ACT
            ServiceDept ob = new ServiceDept(chk.Object);
            
            int i= ob.serviceaddemp(mockdept);
           //Assert
            Assert.Equals(i, 1);
        }
    }
}
