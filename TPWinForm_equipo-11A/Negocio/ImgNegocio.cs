using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImgNegocio
    {
        public void agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", nuevo.IDArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
