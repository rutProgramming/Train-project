using Train_project.classes;
using Train_project.DataContext;

namespace Train_project.services
{
    public class EmployeeService
    {
        public DataContextManager DataContextE { get; set; }= new DataContextManager(); 
        valid valid=new valid();
        public List<Employee> Get()
        {
            return DataContextE.Data_Context.Employees;
        }
        public Employee GetById(int id)
        {
            return DataContextE.Data_Context.Employees.Find(employee => employee.EmployeeCode == id);
        }
        public bool AddEmployee(Employee employee)
        {
            if (valid.IsIdValid(employee.EmployeeId) && valid.IsIsraeliPhoneNumberValid(employee.EmployeePhone)) 
            {
                DataContextE.Data_Context.Employees.Add(employee);
                return true;
            }
            return false;
        }
        public bool UpdateEmployee(int id, Employee employee)
        {
            int indexEmployee = DataContextE.Data_Context.Employees.FindIndex(employee => employee.EmployeeCode == id);
            if (indexEmployee != -1)
            {
                DataContextE.Data_Context.Employees[indexEmployee] = employee;
                return true;
            }
            return false;

        }
        public bool DeleteEmployee(int id)
        {
            Employee employee = DataContextE.Data_Context.Employees.Find(employee => employee.EmployeeCode == id);
            if (employee != null)
            {
                DataContextE.Data_Context.Employees.Remove(employee);
                return true;
            }
            return false;

        }
    }
}
