using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciertos
{
    internal class Repositorio
    {
        /// <summary>
        /// Método para Obtener los conciertos
        /// </summary>
        /// <returns></returns>
        public static DataSet ObtenerConciertos()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM CONCIERTOS";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return ds;
        }

        /// <summary>
        /// Método para crear un concierto.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static  bool CrearConcierto(Conciertos c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; INSERT INTO CONCIERTOS VALUES ('" + c.nombre + "', '" + c.fechaConcierto + "', '" + c.precioEntrada + "', '" + c.numeroAsiento + "', '" + c.descripcion + "')";
                
                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para eliminar un concierto.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarConcierto(Conciertos c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM CONCIERTOS WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para modificar un concierto.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ModificarConcierto(Conciertos c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE CONCIERTOS SET NOMBRE = '" + c.nombre + "', FECHACONCIERTO= '" + c.fechaConcierto + "', " + 
                    "PRECIOENTRADA = '" + c.precioEntrada + "', NUMEROASIENTO = '" + c.numeroAsiento + "', DESCRIPCION = '" + c.descripcion + "' " +
                    " WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }
}
