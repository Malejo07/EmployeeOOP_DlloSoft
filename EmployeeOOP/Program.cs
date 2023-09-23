using EmployeeOOP.Classes;
using System;

namespace EmployeeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("OOP APPLICATION");
                Console.WriteLine("---------------");

                //Declarar algunas variables
                int day, month, year, id, sales;
                string firstName, lastName;
                decimal salary, commissionPercentaje,hours, hoursValue, Base;

                Console.Write("Ingresar el día: ");
                day = Convert.ToInt32(Console.ReadLine());//ToInt32, ToDecimal, ToDouble, ToFloat, ToBoolel, para cambiar el console Read Line

                Console.Write("Ingresar el mes: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año: ");
                year = Convert.ToInt32(Console.ReadLine());

                //Instanciar la clase Date.cs
                Date dateObject = new Date(year, month, day);
                Console.Write("\n"); //Salto de línea
                Console.WriteLine(dateObject.ToString()); //23/50/23232

                
                Console.Write("\n***Datos Salario Empleado***");

                Console.Write("\nIngrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Ingrese salario devengado: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                //Esta es la forma de crear objetos a partir de una clase concreta
                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = salary

                    //salaryEmployee.Id = 123;
                    //salaryEmployee.FirstName = "Juan";
                    //salaryEmployee.LastName = "Gómez";
                    //salaryEmployee.BirthDate = dateObject;
                    //salaryEmployee.HiringDate = dateObject;
                    //salaryEmployee.IsActive = true;
                };

                Console.Clear();
                Console.WriteLine(salaryEmployee);


                Console.WriteLine("\n***Contrato empleado por horas***");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Ingrese las horas trabajadas: ");
                hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de la hora: ");
                hoursValue = Convert.ToDecimal(Console.ReadLine());

                HourlyEmployee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Hours = hours,
                    HoursValue = hoursValue
                };

                Console.Clear();
                Console.WriteLine(hourlyEmployee);


                Console.WriteLine("***Comisión del Empleado***");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Ingrese el valor de las ventas: ");
                sales = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el porcentaje de comisión: ");
                commissionPercentaje = Convert.ToDecimal(Console.ReadLine());

                CommissionEmployee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate=dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Sales = sales,
                    CommissionPercentaje= commissionPercentaje / 100
                };
                Console.Clear();
                Console.WriteLine(commissionEmployee);

                
                Console.WriteLine("***Comisión base empleado***");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Ingrese la comisión base del empleado: ");
                Base = Convert.ToInt32(Console.ReadLine());

                BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Base = Base,
                };
                Console.Clear();
                Console.WriteLine(baseCommissionEmployee);
            }
            catch (Exception ex)
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);
            }
        }
    }
}