using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;

namespace AlphaLog.Core
{
    public class Produto : Entity
    {
        public virtual string Nome { get; protected set; }

        public virtual double PesoUnitario { get; protected set; }

        public virtual int DiasValidade { get; protected set; }

        protected Produto()
        {
        }

        public Produto(string nome, double pesoUnitario, int diasValidade)
        {
            Nome = nome;
            PesoUnitario = pesoUnitario;
            DiasValidade = diasValidade;
        }
    }
}
