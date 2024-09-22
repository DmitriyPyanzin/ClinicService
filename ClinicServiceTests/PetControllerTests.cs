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
    public class PetControllerTests
    {
        private PetController _petController;
        private Mock<IPetRepository> _mocPetRepository;

        public PetControllerTests()
        {
            _mocPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mocPetRepository.Object);
        }

        public static readonly object[][] CorrectPetData =
        {
            new object[] { new DateTime(2015, 1, 11), 1, "Шарик", "Собака", "Двортерьер" },
            new object[] { new DateTime(2020, 4, 25), 2, "Барсик", "Кошка", "Шотландец" },
            new object[] { new DateTime(2019, 6, 30), 2, "Яша", "Кошка", "Сфинкс" },
        };

        public List<Pet> Pets()
        {
            List<Pet> list = new List<Pet>();
            list.Add(new Pet());
            list.Add(new Pet());
            list.Add(new Pet());

            return list;
        }

        public Random random = new Random();

        [Theory]
        [MemberData(nameof(CorrectPetData))]
        public void CreatePetTest(DateTime birthday, int clientId, string name, string type, string breed)
        {
            _mocPetRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Pet>())).Returns(1).Verifiable();

            var operationResult = _petController.Create(new CreatePetRequest
            {
                Birthday = birthday,
                ClientId = clientId,
                Name = name,
                Type = type,
                Breed = breed
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocPetRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }

        [Theory]
        [MemberData(nameof(CorrectPetData))]
        public void UpdatePetTest(DateTime birthday, int clientId, string name, string type, string breed)
        {
            _mocPetRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Pet>())).Returns(1).Verifiable();

            var operationResult = _petController.Update(new UpdatePetRequest
            {
                Birthday = birthday,
                ClientId = clientId,
                Name = name,
                Type = type,
                Breed = breed
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocPetRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }

        [Fact]
        public void DeletePetTest() {

            int rand = random.Next(0, 2);

            _mocPetRepository.Setup(repository =>
                repository.Delete(rand)).Returns(1).Verifiable();

            var operationResult = _petController.Delete(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocPetRepository.Verify(repository =>
                repository.Delete(rand), Times.AtLeastOnce());
        }

        [Fact]
        public void GetAllPetsTest()
        {
            _mocPetRepository.Setup(repository =>
                repository.GetAll()).Returns(Pets());

            var operationResult = _petController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);

            _mocPetRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());
        }

        [Fact]
        public void GetByIdTest()
        {
            int rand = random.Next(0, 2);

            _mocPetRepository.Setup(repository =>
                repository.GetById(rand)).Returns(Pets()[rand]);

            var operationResult = _petController.GetById(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<Pet>(((OkObjectResult)operationResult.Result).Value);

            _mocPetRepository.Verify(repository =>
                repository.GetById(rand), Times.AtLeastOnce());
        }
    }
}
