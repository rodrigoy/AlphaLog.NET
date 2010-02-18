using System;
using System.Collections.Generic;
using SharpArch.Core.DomainModel;


namespace AlphaLog.Core 
{
    public class Carga : Entity
    {

        public virtual string Pallet { get; protected set; }
        public virtual DateTime Embalagem { get; protected set; }
        public virtual Produto Produto { get; protected set; }
        public virtual long Quantidade { get; protected set; }
        // public virtual double PesoReal { get; set; }

        protected Carga()
        {
        }

        public Carga(string pallet, Produto produto, long quantidade)
        {
            Embalagem = DateTime.Today;
            Pallet = pallet;
            Produto = produto;
            Quantidade = quantidade;
        }

        public virtual double PesoCalculado
        {
            get {return Produto.PesoUnitario*Quantidade; }
        }
    }
}
