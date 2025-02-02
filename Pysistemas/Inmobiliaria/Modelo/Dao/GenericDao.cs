using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Inmobiliaria.Modelo.Dao
{
    public class GenericDao<T, TId> : IDisposable, IGenericDao<T, TId> where T : class
    {

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes
        protected InmobiliariaEntities DbContext { get; }

        public GenericDao()
        {
            DbContext = new InmobiliariaEntities();
        }
        public virtual IList<T> ObtenerLista()
        {
            return DbContext.Set<T>().ToList();
        }

        public virtual IList<T> ObtenerDesdeFiltros(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = DbContext.Set<T>().Where(predicate);
            return query.ToList();
        }

        public virtual T ObtenerDesdePk(object id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public virtual T Agregar(T entity)
        {

            DbContext.Set<T>().Add(entity);
            DbContext.Entry(entity).State = EntityState.Added;




            return entity;
        }

        public virtual T Actualizar(T entity)
        {

            DbContext.Set<T>().Attach(entity);

            DbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual void Remover(T entity)
        {
            DbContext.Set<T>().Attach(entity);
            DbContext.Entry(entity).State = EntityState.Deleted;

        }

        public void Guardar()
        {
            DbContext.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~GenericDao() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
