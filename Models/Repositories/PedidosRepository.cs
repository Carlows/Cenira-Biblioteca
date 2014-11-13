using CeniraBiblioteca.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeniraBiblioteca.Models.Repositories
{
    public class PedidosRepository
    {
        public CeniraContext db = new CeniraContext();

        public void SavePedido(Pedidos pedido)
        {
            pedido.ID = 0;
            db.Pedidos.Add(pedido);

            db.SaveChanges();
        }

        public Pedidos CancelarPedido(int idPedido)
        {
            Pedidos dbEntry = db.Pedidos.Find(idPedido);
            if (dbEntry != null)
            {
                db.Pedidos.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}