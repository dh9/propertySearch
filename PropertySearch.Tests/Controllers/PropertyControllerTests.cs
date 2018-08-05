using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertySearch.Controllers;
using AutoFixture;
using AutoFixture.AutoMoq;
using PropertySearch.Repositories;
using Moq;
using PropertySearch.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PropertySearch.Models;

namespace PropertySearch.Tests.Controllers
{
    [TestClass]
    public class PropertyControllerTests
    {
        private IFixture _fixture = new Fixture();
        private Mock<IPropertyRepository> _propertyRepository;

        [TestInitialize]
        public void Initialize()
        {
            _propertyRepository = _fixture.Create<Mock<IPropertyRepository>>();
        }

        [TestMethod]
        public void Search_InvalidModel_ReturnsModel()
        {
            //Arrange
            var model = _fixture.Create<PropertySearchViewModel>();
            
            var controller = new PropertyController(_propertyRepository.Object);
            //Set model to be invalid
            controller.ModelState.AddModelError("test", "test");

            //Act
            var result = controller.Search(model);

            //Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            var viewModel = viewResult.Model as PropertySearchViewModel;
            Assert.IsNotNull(viewModel);
            Assert.AreSame(model, viewModel);

            //Never call repository
            _propertyRepository.Verify(x => x.GetProperties(It.IsAny<Requirements>()), Times.Never);
        }
    }
}