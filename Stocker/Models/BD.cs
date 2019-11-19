using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Stocker.Models
{
    public static class BD
    {
        public static string connectionstring = "Server=.;Database= Stocker;Trusted_Connection=True;";
        private static SqlConnection Conectar()
        {
            SqlConnection Com = new SqlConnection(connectionstring);
            Com.Open();
            return Com;
        }

        private static void Desconectar(SqlConnection Conexion)
        {
            Conexion.Close();
        }
        public static Productos Destacada()
        {         
                Productos Dest = new Productos();
                SqlConnection Conexion = Conectar();
                SqlCommand Consulta = Conexion.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.Text;
                Consulta.CommandText = "SELECT * FROM Productos WHERE Destacado = 'True' ";
                SqlDataReader DataReader = Consulta.ExecuteReader();
                while (DataReader.Read())
                {
                    Dest.IdProducto = Convert.ToInt32(DataReader["IdProducto"]);
                    Dest.FkTipoPrenda = Convert.ToInt32(DataReader["FkTipoPrenda"]);
                    Dest.FkMarca = Convert.ToInt32(DataReader["FkMarca"]);
                    Dest.FkSexo = Convert.ToInt32(DataReader["FkSexo"]);
                    Dest.FkEquipo = Convert.ToInt32(DataReader["FkEquipo"]);
                    Dest.Titulo = DataReader["Titulo"].ToString();
                    Dest.Descipcion = DataReader["Descipcion"].ToString();
                    Dest.Imagen = DataReader["Imagen"].ToString();
                    Dest.Precio = Convert.ToInt32(DataReader["Precio"]);
                    Dest.ReBaja = Convert.ToBoolean(DataReader["ReBaja"]);
                    Dest.Destacado = Convert.ToBoolean(DataReader["Destacado"]);
                }
                Desconectar(Conexion);
                return Dest;
            }


        public static List<Tipos_De_Prenda> ListadoTipoProducto()
        {
            List<Tipos_De_Prenda> ListaTProd = new List<Tipos_De_Prenda>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Tipos_De_Prenda";
            SqlDataReader DataReader = Consulta.ExecuteReader();
            while (DataReader.Read())
            {
                Tipos_De_Prenda Prod = new Tipos_De_Prenda();
                Prod.IdTipoPrenda = Convert.ToInt32(DataReader["IdTipoPrenda"]);
                Prod.NombreTipoPrenda = DataReader["NombreTipoPrenda"].ToString();
                ListaTProd.Add(Prod);
            }
            Desconectar(Conexion);
            return ListaTProd;

        }

        public static Productos TraerProducto(int Id)
        {
            Productos UnProducto = new Productos();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Productos WHERE IdProducto = " + Id;
            SqlDataReader DataReader = Consulta.ExecuteReader();
            while (DataReader.Read())
            {

                UnProducto.IdProducto = Convert.ToInt32(DataReader["IdProducto"]);
                UnProducto.FkTipoPrenda = Convert.ToInt32(DataReader["FkTipoPrenda"]);
                UnProducto.FkMarca = Convert.ToInt32(DataReader["FkMarca"]);
                UnProducto.FkSexo = Convert.ToInt32(DataReader["FkSexo"]);
                UnProducto.FkEquipo = Convert.ToInt32(DataReader["FkEquipo"]);
                UnProducto.Titulo = DataReader["Titulo"].ToString();
                UnProducto.Descipcion = DataReader["Descipcion"].ToString();
                UnProducto.Imagen = DataReader["Imagen"].ToString();
                UnProducto.Precio = Convert.ToInt32(DataReader["Precio"]);
                UnProducto.ReBaja = Convert.ToBoolean(DataReader["ReBaja"]);
                UnProducto.Destacado = Convert.ToBoolean(DataReader["Destacado"]);
            }
            Desconectar(Conexion);
            return UnProducto;
        }

        public static List<Productos> ListadoDeProductosXEquipo(int IdEqui)
        {
            List<Productos> ListProduc = new List<Productos>();
            Productos UnProducto = new Productos();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Productos WHERE IdEquipo= " + IdEqui;
            SqlDataReader DataReader = Consulta.ExecuteReader();
            while (DataReader.Read())
            {
                UnProducto.IdProducto = Convert.ToInt32(DataReader["IdProducto"]);
                UnProducto.FkTipoPrenda = Convert.ToInt32(DataReader["FkTipoPrenda"]);
                UnProducto.FkMarca = Convert.ToInt32(DataReader["FkMarca"]);
                UnProducto.FkSexo = Convert.ToInt32(DataReader["FkSexo"]);
                UnProducto.FkEquipo = Convert.ToInt32(DataReader["FkEquipo"]);
                UnProducto.Titulo = DataReader["Titulo"].ToString();
                UnProducto.Descipcion = DataReader["Descipcion"].ToString();
                UnProducto.Imagen = DataReader["Imagen"].ToString();
                UnProducto.Precio = Convert.ToInt32(DataReader["Precio"]);
                UnProducto.ReBaja = Convert.ToBoolean(DataReader["ReBaja"]);
                UnProducto.Destacado = Convert.ToBoolean(DataReader["Destacado"]);
                ListProduc.Add(UnProducto);
            }
            Desconectar(Conexion);
            return ListProduc;

        }

        public static List<Productos> ListadoDeProductosXTipo(int IdTipo)
        {
            List<Productos> ListProduc = new List<Productos>();
            Productos UnProducto = new Productos();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Productos WHERE Tipos_De_Prenda= " + IdTipo;
            SqlDataReader DataReader = Consulta.ExecuteReader();
            while (DataReader.Read())
            {
                UnProducto.IdProducto = Convert.ToInt32(DataReader["IdProducto"]);
                UnProducto.FkTipoPrenda = Convert.ToInt32(DataReader["FkTipoPrenda"]);
                UnProducto.FkMarca = Convert.ToInt32(DataReader["FkMarca"]);
                UnProducto.FkSexo = Convert.ToInt32(DataReader["FkSexo"]);
                UnProducto.FkEquipo = Convert.ToInt32(DataReader["FkEquipo"]);
                UnProducto.Titulo = DataReader["Titulo"].ToString();
                UnProducto.Descipcion = DataReader["Descipcion"].ToString();
                UnProducto.Imagen = DataReader["Imagen"].ToString();
                UnProducto.Precio = Convert.ToInt32(DataReader["Precio"]);
                UnProducto.ReBaja = Convert.ToBoolean(DataReader["ReBaja"]);
                UnProducto.Destacado = Convert.ToBoolean(DataReader["Destacado"]);
                ListProduc.Add(UnProducto);
            }
            Desconectar(Conexion);
            return ListProduc;

        }

        public static List<Productos> ListadoDeProductosBack()
        {
            List<Productos> ListProdu = new List<Productos>();

            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Productos";
            SqlDataReader DataReader = Consulta.ExecuteReader();
            while (DataReader.Read())
            {
                Productos Prod = new Productos();
                Prod.IdProducto = Convert.ToInt32(DataReader["IdProducto"]);
                Prod.FkTipoPrenda = Convert.ToInt32(DataReader["FkTipoPrenda"]);
                Prod.FkMarca = Convert.ToInt32(DataReader["FkMarca"]);
                Prod.FkSexo = Convert.ToInt32(DataReader["FkSexo"]);
                Prod.FkEquipo = Convert.ToInt32(DataReader["FkEquipo"]);
                Prod.Titulo = DataReader["Titulo"].ToString();
                Prod.Descipcion = DataReader["Descipcion"].ToString();
                Prod.Imagen = DataReader["Imagen"].ToString();
                Prod.Precio = Convert.ToInt32(DataReader["Precio"]);
                Prod.ReBaja = Convert.ToBoolean(DataReader["ReBaja"]);
                Prod.Destacado = Convert.ToBoolean(DataReader["Destacado"]);
                ListProdu.Add(Prod);
            }
            Desconectar(Conexion);
            return ListProdu;

        }

        public static void SacarDestacar(int Id)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "UPDATE Productos SET Destacada=0 WHERE IdProducto=" + Id;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }
        public static void Destacar(int Id)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "UPDATE Productos SET Destacada=1 WHERE IdProducto=" + Id;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }
        public static void SacarReBaja(int Id)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "UPDATE Productos SET ReBaja=0 WHERE IdProducto=" + Id;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }
        public static void ReBaja(int Id)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "UPDATE Productos SET ReBaja=1 WHERE IdProducto=" + Id;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }

        public static bool BuscarUsuario(Usuario user)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "SELECT * FROM Usuario Where Username LIKE '" + user.Username + "' AND Password LIKE '" + user.Password + "'";
            SqlDataReader DataReader = Consulta.ExecuteReader();
            if (DataReader.Read())
            {
                Desconectar(Conexion);
                return true;

            }
            else
            {
                Desconectar(Conexion);
                return false;
            }


        }

        public static void CrearProducto(Productos Prod)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "INSERT INTO Productos(FkTipoPrenda, FkMarca, FkSexo, FkEquipo, Titulo, Descipcion, Imagen, Precio, ReBaja, Destacado)" +
            " VALUES ('" + Prod.FkTipoPrenda + "','" + Prod.FkMarca + "','" + Prod.FkSexo + "','" + Prod.FkEquipo + "','" + Prod.Titulo + "','" + Prod.Descipcion + "','" + Prod.Imagen + "','" + Prod.Precio + "','" + "','False', 'False')";
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }

        public static void EditarProd(Productos Prod)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "UPDATE Productos SET FkTipoPrenda='" + Prod.FkTipoPrenda + "', FkMarca = '" + Prod.FkMarca + "', FkSexo = '" + Prod.FkSexo + "', FkEquipo = '" + Prod.FkEquipo + "', Titulo = '" + Prod.Titulo + "', Descipcion = '" + Prod.Descipcion + "', Imagen = '" + Prod.Imagen + "', Precio = '" + Prod.Precio + "'WHERE IdProducto="+ Prod.IdProducto ;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }
        public static void BorrarProd(int IdProd)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.CommandText = "DELETE FROM Productos WHERE IdProducto=" + IdProd;
            Consulta.ExecuteNonQuery();
            Desconectar(Conexion);
        }


    }
}