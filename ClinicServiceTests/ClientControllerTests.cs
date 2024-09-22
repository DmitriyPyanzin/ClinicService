using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Request;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClinicServiceTests
{
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mocClientRepository;

        public ClientControllerTests()
        {
            _mocClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mocClientRepository.Object);
        }

        public static readonly object[][] CorrectClientData =
        {
            new object[] { new DateTime(1990, 1, 11), "0000 000000", "Иванов", "Иван", "Иванович" },
            new object[] { new DateTime(1988, 4, 25), "1111 111111", "Петров", "Пётр", "Петрович" },
            new object[] { new DateTime(1979, 6, 30), "2222 222222", "Сидоров", "Сидор", "Сидорович" },
        };

        public List<Client> Clients()
        {
            List<Client> list = new List<Client>();
            list.Add(new Client());
            list.Add(new Client());
            list.Add(new Client());

            return list;
        }

        public Random random = new Random();

        [Theory]
        [MemberData(nameof(CorrectClientData))]
        public void CreateClientTest(DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _mocClientRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Client>())).Returns(1).Verifiable();

            var operationResult = _clientController.Create(new CreateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocClientRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        [Theory]
        [MemberData(nameof(CorrectClientData))]
        public void UpdateClientTest(DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _mocClientRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Client>())).Returns(1).Verifiable();

            var operationResult = _clientController.Update(new UpdateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocClientRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        [Fact]
        public void DeleteClientTest() {

            int rand = random.Next(0, 2);

            _mocClientRepository.Setup(repository =>
                repository.Delete(rand)).Returns(1).Verifiable();

            var operationResult = _clientController.Delete(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocClientRepository.Verify(repository =>
                repository.Delete(rand), Times.AtLeastOnce());
        }

        [Fact]
        public void GetAllClientsTest()
        {
            _mocClientRepository.Setup(repository =>
                repository.GetAll()).Returns(Clients());

            var operationResult = _clientController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Client>>(((OkObjectResult)operationResult.Result).Value);

            _mocClientRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());
        }

        [Fact]
        public void GetByIdTest()
        {
            int rand = random.Next(0, 2);

            _mocClientRepository.Setup(repository =>
                repository.GetById(rand)).Returns(Clients()[rand]);

            var operationResult = _clientController.GetById(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<Client>(((OkObjectResult)operationResult.Result).Value);

            _mocClientRepository.Verify(repository =>
                repository.GetById(rand), Times.AtLeastOnce());
        }
    }
}
