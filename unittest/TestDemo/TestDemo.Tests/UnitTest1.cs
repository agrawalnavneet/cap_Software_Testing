using Moq;
using NUnit.Framework;

public class PersonTests
{
    [Test]
    public void GetPerson_ShouldReturnPerson()
    {
        // Arrange
        var mockRepo = new Mock<IPersonRepository>();

        mockRepo.Setup(x => x.GetPerson()).Returns(new Person
        {
            Id = 1,
            Name = "Navneet",
            City = "Jhansi"
        });

        var service = new PersonService(mockRepo.Object);

        // Act
        var result = service.GetPerson();

        // Assert
        Assert.AreEqual(1, result.Id);
    }
}