using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace TrabajoPracticoWinForm
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo>lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLExpress; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as NombreMarca, C.Descripcion as NombreCategoria, Precio, ImagenUrl FROM ARTICULOS as A, CATEGORIAS AS C, MARCAS AS M, IMAGENES AS I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagen = new Imagen();
                    aux.ID = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca.Descripcion = lector["NombreMarca"].ToString();
                    aux.Categoria.Descripcion = lector["NombreCategoria"].ToString();
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Imagen.ImagenUrl = (string)lector["ImagenUrl"];
                    lista.Add(aux);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
