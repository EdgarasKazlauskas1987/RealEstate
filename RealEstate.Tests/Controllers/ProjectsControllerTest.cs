using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Models.Abstract;
using RealEstate.Models;
using RealEstate.Controllers;
using System.Web.Mvc;

namespace RealEstate.Tests.Controllers
{
    [TestClass]
    public class ProjectsControllerTest
    {
        

        [TestMethod]
        public void getAllBooks()
        {
            var repo = Mock.Create<IProjectRepository>();
            Mock.Arrange(() => repo.GetAll()).Returns(
                new[]
                {
                    new Project(),
                    new Project(),
                    new Project()
                });
            var controller = new ProjectsController(repo);

            var result = (ViewResult)controller.Index();
            var model = (IEnumerable<Project>)result.Model;

            Assert.AreEqual(3, model.Count());
        }

    }
}
