using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class CalculoIR
    {
        private decimal salarioAnual;
        public CalculoIR(decimal salarioAnual)
        {
            this.salarioAnual = salarioAnual;
        }

        public decimal Calcular()
        {
            if (salarioAnual <= 1499.15m)
                return 0;
            if (salarioAnual <= 2246.75m)
                return salarioAnual * 0.075m - 112.43m;
            if (salarioAnual <= 2995.7m)
                return salarioAnual * 0.15m - 280.94m;
            if (salarioAnual <= 3743.19m)
                return salarioAnual * 0.225m - 505.62m;
            return salarioAnual * 0.275m - 692.78m;

        }
    }
}
