using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public decimal CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion Properties


        #region Methods

        public override decimal GetValueToPay()
        {
            return Sales * CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\t Porcentaje de Comisión {CommissionPercentaje:P2}"+
                $"\n\t Ventas {Sales:C2}" +
                $"\n\t Salario {GetValueToPay():C2} \n\t";
        }
        #endregion Methods
    }
}
