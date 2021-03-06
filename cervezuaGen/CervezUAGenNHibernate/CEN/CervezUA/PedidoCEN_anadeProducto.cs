
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using CervezUAGenNHibernate.Exceptions;
using CervezUAGenNHibernate.EN.CervezUA;
using CervezUAGenNHibernate.CAD.CervezUA;


/*PROTECTED REGION ID(usingCervezUAGenNHibernate.CEN.CervezUA_Pedido_anadeProducto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace CervezUAGenNHibernate.CEN.CervezUA
{
public partial class PedidoCEN
{
public void AnadeProducto (int p_oid, CervezUAGenNHibernate.EN.CervezUA.LineaPedidoEN producto)
{
            /*PROTECTED REGION ID(CervezUAGenNHibernate.CEN.CervezUA_Pedido_anadeProducto) ENABLED START*/

            // Write here your custom code...
            PedidoEN pedido = ReadOID(p_oid);

            pedido.Lineas.Add(producto);

            /*PROTECTED REGION END*/
        }
}
}
