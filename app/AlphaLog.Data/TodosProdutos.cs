using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaLog.Core;
using AlphaLog.Core.DataInterfaces;
using SharpArch.Data.NHibernate;

namespace AlphaLog.Data
{
    public class TodosProdutos : Repository<Produto>, ITodosProdutos
    {
    }
}
