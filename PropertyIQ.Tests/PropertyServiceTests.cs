using Moq;
using PropertyIQ.Domain.Entities;
using PropertyIQ.Domain.Repository;
using PropertyIQ.Services.Services;
using Xunit;

namespace PropertyIQ.Tests
{
    public class PropertyServiceTests
    {
        public Mock<IPropertyRepository> mockPropertyRepo;
        public Mock<IRepositoryManager> mockRepoManager;

        public PropertyServiceTests()
        {
            mockPropertyRepo = new Mock<IPropertyRepository>();
            mockRepoManager = new Mock<IRepositoryManager>();
            mockRepoManager.Setup(s => s.PropertyRepository).Returns(mockPropertyRepo.Object);
        }

        [Fact]
        public void GetProperty_Pass()
        {
            // Arrange
            mockPropertyRepo.Setup(p => p.GetByIdAsync(1, default)).ReturnsAsync(new Property { PropertyId = 1, Name = "Property 1" });
            PropertyService propertyService = new PropertyService(mockRepoManager.Object);

            // Act
            Property property = propertyService.GetById(1).GetAwaiter().GetResult();

            // Assert
            Assert.Equal("Property 1", property.Name);
        }
    }
}