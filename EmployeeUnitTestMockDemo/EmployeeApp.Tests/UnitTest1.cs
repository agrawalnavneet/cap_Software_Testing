namespace EmployeeApp.Tests;

using Moq;
using EmployeeApp.Core.Models;
using EmployeeApp.Core.Repository;

public class EmployeeServiceTests
{
    [Test]
    public void GetEmployeeOrThrow_WithValidUser_ReturnsEmployee()
    {
        // Arrange
        var mockRepository = new Mock<IEmployeeRepository>();
        var validEmployee = new Employee
        {
            Id = 1,
            Name = "John Doe",
            Salary = 50000m
        };

        mockRepository
            .Setup(repo => repo.GetById(It.IsAny<int>()))
            .Returns(validEmployee);

        var employeeService = new EmployeeService(mockRepository.Object);

        // Act
        var result = employeeService.GetEmployeeOrThrow(1);

        // Assert
        Assert.That(result.Id, Is.EqualTo(1));
        Assert.That(result.Name, Is.EqualTo("John Doe"));
        Assert.That(result.Salary, Is.EqualTo(50000m));
        mockRepository.Verify(repo => repo.GetById(1), Times.Once);
    }
}
