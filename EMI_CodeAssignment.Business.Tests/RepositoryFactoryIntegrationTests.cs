using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EMI_CodeAssignment.Entities;
using EMI_CodeAssignment.Business.Interfaces;
using System.Linq.Expressions;
using System.Linq;
using EMI_CodeAssignment.Business.Core;
using System.Reflection;
using System.Collections.Generic;
using EMI_CodeAssignment.Business.Tests.Classes;

namespace EMI_CodeAssignment.Business.Tests
{
    [TestClass]
    public class RepositoryFactoryIntegrationTests
    {
        [TestMethod]
        public void RegisterRepository_ReflectsInStore()
        {
            // Arrange
            FieldInfo storeDictField = typeof(RepositoryFactory).GetFields(BindingFlags.Static | BindingFlags.NonPublic).Where(t => t.Name == "repositoryTypesStore").FirstOrDefault();

            // Act
            RepositoryFactory.RegisterRepository<Entity, EntityRepo>();

            // Assert
            var val = (storeDictField.GetValue(null) as Dictionary<Type, Type>)[typeof(Entity)];
            Assert.IsNotNull(val);
            Assert.IsTrue(val == typeof(EntityRepo));
        }
    }

    
}
