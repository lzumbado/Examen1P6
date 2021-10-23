using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface ITipoInquilinoService
    {
        Task<DBEntity> Create(TipoInquilinoEntity entity);
        Task<DBEntity> Delete(TipoInquilinoEntity entity);
        Task<IEnumerable<TipoInquilinoEntity>> Get();
        Task<TipoInquilinoEntity> GetById(TipoInquilinoEntity entity);
        Task<DBEntity> Update(TipoInquilinoEntity entity);
    }

    public class TipoInquilinoService : ITipoInquilinoService
    {
        private readonly IDataAccess sql;

        public TipoInquilinoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<TipoInquilinoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<TipoInquilinoEntity>("dbo.TipoInquilinoObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo GetById
        public async Task<TipoInquilinoEntity> GetById(TipoInquilinoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<TipoInquilinoEntity>("dbo.TipoInquilinoObtener", new
                { entity.Id_TipoInquilino });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(TipoInquilinoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.TipoInquilinoInsertar", new
                {
                    entity.Descripcion,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(TipoInquilinoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.TipoInquilinoActualizar", new
                {
                    entity.Id_TipoInquilino,
                    entity.Descripcion,
                    entity.Estado

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(TipoInquilinoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.TipoInquilinoEliminar", new
                {
                    entity.Id_TipoInquilino,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }






        #endregion



    }
}
