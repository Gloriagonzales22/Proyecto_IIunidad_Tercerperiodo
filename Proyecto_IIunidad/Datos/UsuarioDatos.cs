using MySql.Data.MySqlClient;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDatos
    {
        public async Task<bool> LoginAsync(string codigo, string clave)
        {
            bool valido =false;
            try
            {
                string sql = "SELECT 1 FROM usuario WHERE IdUsuario=@codigo AND Clave=@clave;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                  await _conexion.OpenAsync();
                  using (MySqlCommand cmd = new MySqlCommand(sql, _conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.Add("@Codigo", MySqlDbType.VarChar, 20).Value = codigo;
                        cmd.Parameters.Add("@Clave", MySqlDbType.VarChar, 40).Value = clave;
                        valido = Convert.ToBoolean(await cmd.ExecuteScalarAsync());
                    }
                }
            }

            catch (Exception ex)
            {
  
            }
            return valido;  
        }

        public async Task<DataTable> DevolverListAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM usuario";
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(sql, _conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await cmd.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public async Task<bool> IngresarAsync(Usuario usuario)
        {
            bool ingreso = false;
            try
            {
                string sql = "INSERT INTO uuario VALUES(@IdUsuario, @Nombre, @Clave, @Correo,@Rol, @EstaActivo;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(sql, _conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 20).Value = usuario.IdUsuario;
                        cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 40).Value = usuario.Nombre;
                        cmd.Parameters.Add("@Clave", MySqlDbType.VarChar, 40).Value = usuario.Clave;
                        cmd.Parameters.Add("@Correo", MySqlDbType.VarChar, 50).Value = usuario.Correo;
                        cmd.Parameters.Add("@Rol", MySqlDbType.VarChar, 50).Value = usuario.Rol;
                        cmd.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = usuario.EstaActivo;

                        await cmd.ExecuteNonQueryAsync();
                        ingreso = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return ingreso;
        }

        public async Task <bool> ActualizarAsync(Usuario usuario)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE usuario SET Nombre=@Nombre, Clave=@Clave, Correo=@Correo, Rol=@Rol, EstaActivo@EstaActivo WHERE IdUsuario=@IdUsuario;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(sql, _conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 20).Value = usuario.IdUsuario;
                        cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 40).Value = usuario.Nombre;
                        cmd.Parameters.Add("@Clave", MySqlDbType.VarChar, 40).Value = usuario.Clave;
                        cmd.Parameters.Add("@Correo", MySqlDbType.VarChar, 50).Value = usuario.Correo;
                        cmd.Parameters.Add("@Rol", MySqlDbType.VarChar, 50).Value = usuario.Rol;
                        cmd.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = usuario.EstaActivo;

                        await cmd.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return actualizo;
        }

        public async Task<bool> BorrarAsync(string IdUsuario)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM usuario Where IdUsuarioNombre=@IdUsuario;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(sql, _conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 20).Value = IdUsuario;
                        await cmd.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return elimino;
        }

    }
}
