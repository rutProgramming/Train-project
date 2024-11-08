namespace Train_project.classes
{
   public enum typeWork { driver,cleaner,workerOffice}
    public class Employee
    {
       
        public int EmployeeCode { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress{ get; set; }
        public typeWork EmployeType { get; set; }
        public string EmployeePhone { get; set; }
        public int Salary { get; set; }
        public DateTime EmployedFrom { get; set; }
        public  Employee()
        {
                
        }
        public  Employee(int employeeCode, string employeeId, string employeeName, string employeeAddress, typeWork employeType, string employeePhone, int salary, DateTime employedFrom)
        {
            EmployeeCode = employeeCode;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
            EmployeType = employeType;
            EmployeePhone = employeePhone;
            Salary = salary;
            EmployedFrom = employedFrom;
        }
    }
}
