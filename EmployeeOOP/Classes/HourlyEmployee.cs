using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public decimal Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion Properties

        public override decimal GetValueToPay()
        {
            return Hours * HoursValue;
        }

        public override string ToString() 
        {
            return $"{base.ToString()} " +
                $"\n\t Horas {Hours}" +
                $"\n\t Valor de la hora {HoursValue:C2}" +
                $"\n\t Salario {GetValueToPay():C2} \n\t";
        }
    }
}
