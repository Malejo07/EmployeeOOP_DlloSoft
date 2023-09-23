using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion Properties

        #region Methods
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\t El salario base es: {Base:P2}" +
                $"\n\t Salario total: {GetValueToPay():C2} \n\t";
        }

        #endregion Methods
    }
}