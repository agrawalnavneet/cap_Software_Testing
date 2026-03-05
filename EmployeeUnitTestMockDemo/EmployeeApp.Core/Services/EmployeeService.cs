using EmployeeApp.Core.Models;
using EmployeeApp.Core.Repository;
public sealed class EmployeeService
{
    private readonly IEmployeeRepository _repo;

    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
    }

    public Employee GetEmployeeOrThrow(int id)
    {
        if(id <= 0) throw new ArgumentOutOfRangeException(nameof(id),"ID must be positive");

        var employee = _repo.GetById(id);
        if(employee is null) throw new KeyNotFoundException($"Employee with ID {id} not found");

        return employee;
    }
}