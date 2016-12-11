using EMI_CodeAssignment.Business.Core;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Business.Tests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Tests
{
    [TestClass]
    public class RepositoryBaseUnitTests
    {
        [TestMethod]
        public void DeleteById_CallsGetQueryAndDeleteOnlyOneTime()
        {
            // Arrange
            Entity ent = new Entity();
            Entity ent2 = new Entity();

            Mock<IDataContext> dbMock = new Mock<IDataContext>();
            dbMock.Setup(t => t.GetQuery<Entity>()).Returns(() =>
            {
                return new List<Entity>() { ent, ent2 }.AsQueryable();
            });

            EntityRepo repo = new EntityRepo(dbMock.Object);

            // Act
            repo.Delete(ent.Id);
            repo.Delete(ent2.Id);

            // Assert
            dbMock.Verify(t => t.GetQuery<Entity>(), Times.Exactly(2));
            dbMock.Verify(t => t.Delete(ent), Times.Once);
            dbMock.Verify(t => t.Delete(ent2), Times.Once);
            dbMock.Verify(t => t.Delete(It.IsAny<Entity>()), Times.Exactly(2));
        }
    }
}
