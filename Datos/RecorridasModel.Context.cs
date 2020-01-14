﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_Recorridas_ITEntities : DbContext
    {
        public BD_Recorridas_ITEntities()
            : base("name=BD_Recorridas_ITEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_RECORRIDAS> TB_RECORRIDAS { get; set; }
        public virtual DbSet<TB_SALONES> TB_SALONES { get; set; }
        public virtual DbSet<TB_USER_IT> TB_USER_IT { get; set; }
        public virtual DbSet<TB_RECORRIDAS_SALONES> TB_RECORRIDAS_SALONES { get; set; }
    
        public virtual int SP_AGREGAR_SALON_RECORRIDA(Nullable<int> id_recorrida, Nullable<int> id_salon, bool? estado)
        {
            var id_recorridaParameter = id_recorrida.HasValue ?
                new ObjectParameter("id_recorrida", id_recorrida) :
                new ObjectParameter("id_recorrida", typeof(int));
    
            var id_salonParameter = id_salon.HasValue ?
                new ObjectParameter("id_salon", id_salon) :
                new ObjectParameter("id_salon", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AGREGAR_SALON_RECORRIDA", id_recorridaParameter, id_salonParameter, estadoParameter);
        }
    
        public virtual int SP_CREAR_SALON(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREAR_SALON", nombreParameter);
        }
    
        public virtual int SP_CREAR_SOPORTISTA(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREAR_SOPORTISTA", nombreParameter);
        }
    
        public virtual int SP_ELIMINAR_SALON(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_SALON", idParameter);
        }
    
        public virtual int SP_ELIMINAR_SOPORTISTA(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_SOPORTISTA", idParameter);
        }
    
        public virtual int SP_JOB_ULTIMA_RECORRIDA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_JOB_ULTIMA_RECORRIDA");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_NUEVA_RECORRIDA(string nombre_user, string detalle)
        {
            var nombre_userParameter = nombre_user != null ?
                new ObjectParameter("nombre_user", nombre_user) :
                new ObjectParameter("nombre_user", typeof(string));
    
            var detalleParameter = detalle != null ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_NUEVA_RECORRIDA", nombre_userParameter, detalleParameter);
        }
    
        public virtual ObjectResult<SP_TRAER_HISTORIAL_Result> SP_TRAER_HISTORIAL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TRAER_HISTORIAL_Result>("SP_TRAER_HISTORIAL");
        }
    }
}