using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Application.Services.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Tests.Api.Application.PropertyManagement
{
    [TestClass]
    public class TenantServiceTests
    {
        [TestMethod]
        public async Task Add_Should_Return_ServiceResponse()
        {
            //Arragnges
            var repository = new Mock<ITenantRepository>();
            var logger = new Mock<ILogger<ServiceBase<ITenantRepository>>>();
            repository
                    .Setup(x => x.AddAsync(It.IsAny<Tenant>()))
                    .Returns(Task.FromResult(new Tenant())); //This is async so we need to do Task.FromResult
            var service = new TenantService(repository.Object, logger.Object);

            //Act
            var response = await service.Add(new Tenant());

            //Assert
            Assert.IsInstanceOfType(response, typeof(IServiceResponse<Tenant>));
        }

        [TestMethod]
        public async Task Update_Should_Return_ServiceResponse()
        {
            //Arragnges
            var repository = new Mock<ITenantRepository>();
            var logger = new Mock<ILogger<ServiceBase<ITenantRepository>>>();
            repository
                    .Setup(x => x.Update(It.IsAny<Tenant>()))
                    .Returns(new Tenant());
            var service = new TenantService(repository.Object, logger.Object);

            //Act
            var response = await service.Update(new Tenant());

            //Assert
            Assert.IsInstanceOfType(response, typeof(IServiceResponse<Tenant>));
        }


        [TestMethod]
        public async Task Delete_Should_Return_ServiceResponse()
        {
            //Arragnges
            var repository = new Mock<ITenantRepository>();
            var logger = new Mock<ILogger<ServiceBase<ITenantRepository>>>();
            repository
                    .Setup(x => x.DeleteByIdAsync(It.IsAny<int>()))
                    .Returns(new Task(() => { }));
            var service = new TenantService(repository.Object, logger.Object);

            //Act
            var response = await service.DeleteById(1);

            //Assert
            Assert.IsInstanceOfType(response, typeof(IServiceResponse<Tenant>));
        }

        [TestMethod]
        public async Task Get_Should_Return_ServiceResponse()
        {
            //Arragnges
            var repository = new Mock<ITenantRepository>();
            var logger = new Mock<ILogger<ServiceBase<ITenantRepository>>>();
            repository
                    .Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                    .Returns(Task.FromResult(new Tenant()));
            var service = new TenantService(repository.Object, logger.Object);

            //Act
            var response = await service.GetById(1);

            //Assert
            Assert.IsInstanceOfType(response, typeof(IServiceResponse<Tenant>));
        }

        [TestMethod]
        public async Task GetAll_Should_Return_ServiceResponse()
        {
            //Arragnges
            var repository = new Mock<ITenantRepository>();
            var logger = new Mock<ILogger<ServiceBase<ITenantRepository>>>();
            repository
                    .Setup(x => x.GetAllAsync())
                    .Returns(Task.FromResult(new List<Tenant>() as IEnumerable<Tenant>));
            var service = new TenantService(repository.Object, logger.Object);

            //Act
            var response = await service.GetAll();

            //Assert
            Assert.IsInstanceOfType(response, typeof(IServiceResponse<IEnumerable<Tenant>>));
        }
    }
}
