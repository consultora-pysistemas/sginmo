using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Inmobiliaria.Modelo.Dao
{
    public interface IGenericDao<T, TId>
    {
        IList<T> ObtenerLista();
        IList<T> ObtenerDesdeFiltros(Expression<Func<T, bool>> predicate);
        T ObtenerDesdePk(Object id);
        T Agregar(T entity);
        T Actualizar(T entity);
        void Remover(T entity);
        void Guardar();
    }
}
