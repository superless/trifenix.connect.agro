using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Función encargada de condicionar la forma de compilar e ingresar paramentros de BD
/// </summary>
namespace trifenix.connect.agro_model
{

#if CONNECT
    public abstract class DocumentLocal
    {
        public abstract string Id { get; set; }

        public abstract string ClientId { get; set; }
    }
#else
    using Cosmonaut;
    using trifenix.connect.db.model;

    public abstract class DocumentLocal : DocumentBase, ISharedCosmosEntity
    {
       
    }

#endif
}
