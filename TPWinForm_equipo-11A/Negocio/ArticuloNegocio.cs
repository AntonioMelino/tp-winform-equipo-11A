using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography.X509Certificates;
using Negocio;

namespace TrabajoPracticoWinForm
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("SELECT DISTINCT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as NombreMarca, C.Descripcion as NombreCategoria, Precio, (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id) as ImagenUrl, A.IdMarca, A.IdCategoria FROM ARTICULOS as A, CATEGORIAS AS C, MARCAS AS M, IMAGENES AS I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo");
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as NombreMarca, C.Descripcion as NombreCategoria, Precio, (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id) as ImagenUrl, A.IdMarca, A.IdCategoria FROM ARTICULOS as A JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id JOIN MARCAS AS M ON A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.ID = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = datos.Lector["NombreMarca"].ToString();
                    aux.Categoria.ID = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = datos.Lector["NombreCategoria"].ToString();
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
                    lista.Add(aux);
                }
                return lista;
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
           
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.ID);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.ID);
                datos.setearParametro("@Precio", nuevo.Precio);
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
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.Marca.ID);
                datos.setearParametro("@idCategoria", articulo.Categoria.ID);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.ID);

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
        public int traerArt()
        {
            int art = 0;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT top 1 * FROM ARTICULOS ORDER BY id DESC ");
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {                    
                    art = Convert.ToInt32(datos.Lector["Id"]);
                }
                return art;
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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS WHERE Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as NombreMarca, C.Descripcion as NombreCategoria, Precio, ImagenUrl, A.IdMarca, A.IdCategoria, A.Id FROM ARTICULOS as A, CATEGORIAS AS C, MARCAS AS M, IMAGENES AS I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo AND ";

                switch (campo)
                {
                    case "Codigo":
                    case "Nombre":
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += campo + " LIKE '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += campo + " LIKE '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += campo + " LIKE '%" + filtro + "%'";
                                break;
                        }break;

                    case "Precio":
                        if (criterio == "Mayor a")
                        {
                            consulta += "Precio > " + filtro;
                        }
                        else if (criterio == "Menor a")
                        {
                            consulta += "Precio < " + filtro;
                        }
                        break;
                    case "Marca":
                        if (criterio == "Igual a")
                        {

                            consulta += "A.IdMarca = (SELECT Id FROM MARCAS WHERE Descripcion = '" + filtro + "')";
                        }
                        break;

                    case "Categoria":
                        if (criterio == "Igual a")
                        {
                            consulta += "A.IdCategoria = (SELECT Id FROM CATEGORIAS WHERE Descripcion = '" + filtro + "')";
                        }
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagen = new Imagen();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.ID = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = datos.Lector["NombreMarca"].ToString();
                    aux.Categoria.ID = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = datos.Lector["NombreCategoria"].ToString();
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void agregarImg(Articulo nuevo)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("INSERT INTO IMAGENES VALUES (@IdArticulo, @ImagenUrl)");
        //        datos.setearParametro("@IdArticulo", nuevo.Imagen.IDArticulo);
        //        datos.setearParametro("@ImagenUrl", nuevo.Imagen.ImagenUrl);
        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}
    }
}
