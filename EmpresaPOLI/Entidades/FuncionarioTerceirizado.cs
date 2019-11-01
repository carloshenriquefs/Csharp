using System;
using System.Collections.Generic;

namespace EmpresaPOLI {
    class FuncionarioTerceirizado : Funcionarios {
        public double CobrancaAdicional { get; set; }

        public FuncionarioTerceirizado () {

        }

        public FuncionarioTerceirizado (string nome, int horas, double valorporhoras, double cobrancaadicional) : base (nome, horas, valorporhoras) {
            this.CobrancaAdicional = cobrancaadicional;
        }

        public override double FormadePagamento () {
            return base.FormadePagamento () + 1.1 * CobrancaAdicional;
        }

    }
}