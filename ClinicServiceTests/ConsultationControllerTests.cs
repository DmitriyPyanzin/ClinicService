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
    public class ConsultationControllerTests
    {
        private ConsultationController _consultationController;
        private Mock<IConsultationRepository> _mocConsultationRepository;

        public ConsultationControllerTests()
        {
            _mocConsultationRepository = new Mock<IConsultationRepository>();
            _consultationController = new ConsultationController(_mocConsultationRepository.Object);
        }

        public static readonly object[][] CorrectConsultationData =
        {
            new object[] { new DateTime(2024, 10, 2), 1, 1, "Прививка" },
            new object[] { new DateTime(2024, 10, 2), 2, 2, "Осмотр" },
            new object[] { new DateTime(2024, 10, 2), 2, 1, "Осмотр" },
        };

        public List<Consultation> Consultations()
        {
            List<Consultation> list = new List<Consultation>();
            list.Add(new Consultation());
            list.Add(new Consultation());
            list.Add(new Consultation());

            return list;
        }

        public Random random = new Random();

        [Theory]
        [MemberData(nameof(CorrectConsultationData))]
        public void CreateConsultationTest(DateTime ConsultationDate, int clientId, int petId, string description)
        {
            _mocConsultationRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Consultation>())).Returns(1).Verifiable();

            var operationResult = _consultationController.Create(new CreateConsultationRequest
            {
                ConsultationDate = ConsultationDate,
                ClientId = clientId,
                PetId = petId,
                Description = description
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocConsultationRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        [Theory]
        [MemberData(nameof(CorrectConsultationData))]
        public void UpdateConsultationTest(DateTime ConsultationDate, int clientId, int petId, string description)
        {
            _mocConsultationRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Consultation>())).Returns(1).Verifiable();

            var operationResult = _consultationController.Update(new UpdateConsultationRequest
            {
                ConsultationDate = ConsultationDate,
                ClientId = clientId,
                PetId = petId,
                Description = description
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocConsultationRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        [Fact]
        public void DeleteConsultationTest() {

            int rand = random.Next(0, 2);

            _mocConsultationRepository.Setup(repository =>
                repository.Delete(rand)).Returns(1).Verifiable();

            var operationResult = _consultationController.Delete(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocConsultationRepository.Verify(repository =>
                repository.Delete(rand), Times.AtLeastOnce());
        }

        [Fact]
        public void GetAllConsultationsTest()
        {
            _mocConsultationRepository.Setup(repository =>
                repository.GetAll()).Returns(Consultations());

            var operationResult = _consultationController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Consultation>>(((OkObjectResult)operationResult.Result).Value);

            _mocConsultationRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());
        }

        [Fact]
        public void GetByIdTest()
        {
            int rand = random.Next(0, 2);

            _mocConsultationRepository.Setup(repository =>
                repository.GetById(rand)).Returns(Consultations()[rand]);

            var operationResult = _consultationController.GetById(rand);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<Consultation>(((OkObjectResult)operationResult.Result).Value);

            _mocConsultationRepository.Verify(repository =>
                repository.GetById(rand), Times.AtLeastOnce());
        }
    }
}
