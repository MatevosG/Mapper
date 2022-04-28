using System;
using AutoMapper;


namespace Mapper_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Id = 1;
            employee.Name = "test";
            employee.Surname = "testtest";
            employee.Age = "78";
            employee.Address = "hervashen";

            var config = new MapperConfiguration(cfg=>cfg.AddProfile<MapperProfile>());
            IMapper mapper = config.CreateMapper();
            var empDTO = mapper.Map<EmployeeDto>(employee);
        }
    }
}