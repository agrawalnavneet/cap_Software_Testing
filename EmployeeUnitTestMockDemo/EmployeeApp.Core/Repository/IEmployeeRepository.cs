using EmployeeApp.Core.Models;
namespace EmployeeApp.Core.Repository
{
    public interface IEmployeeRepository
    {
        Employee? GetById(int id);
        IReadOnlyCollection<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}