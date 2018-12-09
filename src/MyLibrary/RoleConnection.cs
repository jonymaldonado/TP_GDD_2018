﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;

namespace MyLibrary
{
    public class RoleConnection
    {
        public static void LoadDGV(DataGridView dgv)
        {
            dgv.DataSource = Connection.GetDataSet("SELECT * FROM EL_GROUP_BY.ROL").Tables[0];
        }

        public static void SearchRole(DataGridView dgv, string word)
        {
            dgv.DataSource = Connection.GetDataSet("SELECT * FROM EL_GROUP_BY.ROL WHERE Rol_Nombre LIKE '%" + word + "%'").Tables[0];
        }

        public static Int32 GetRoleId(String name)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@nombre", name));
            int result = Connection.queryForInt("EL_GROUP_BY.DAME_ID_X_NOMBRE", Connection.Type.StoredProcedure, parameters);

            Connection.CloseConnection();

            return result;
        }

        public static void SaveRole(RoleDAO role)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 25);
            parameter.Value = role.Name;
            parameters.Add(parameter);

            parameter = new SqlParameter("@HABILITADO", SqlDbType.Bit, 10);
            parameter.Value = role.State;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.GUARDAR_ROL", Connection.Type.StoredProcedure, parameters);

        }

        public static void DeleteRole(Int32 id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", id));

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_ROL", Connection.Type.StoredProcedure, parameters);
        }

        public static void AddFunction(RoleDAO role, FunctionDAO function)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@Rol_Id", SqlDbType.Int, 100);
            parameter.Value = role.Id;
            parameters.Add(parameter);

            parameter = new SqlParameter("@Funcionalidad_Id", SqlDbType.Int, 100);
            parameter.Value = function.Id;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.AGREGAR_FUNCIONALIDAD_A_ROL", Connection.Type.StoredProcedure, parameters);
        }

        public static void DeleteFunction(RoleDAO role, FunctionDAO function)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@Rol_Id", SqlDbType.Int, 100);
            parameter.Value = role.Id;
            parameters.Add(parameter);

            parameter = new SqlParameter("@Funcionalidad_Id", SqlDbType.Int, 100);
            parameter.Value = function.Id;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_FUNCIONALIDAD_A_ROL", Connection.Type.StoredProcedure, parameters);
        }

        public static void UpdateName(Int32 id, String newName, Boolean available)
        {
            Int32 state;

            if (available)
            {
                state = 1;
            }
            else
            {
                state = 0;
            }

            Connection.WriteInTheBase("UPDATE EL_GROUP_BY.ROL SET Rol_Habilitado = " + state.ToString() + ", Rol_Nombre = '" + newName + "' WHERE Rol_Id = " + id.ToString());

            //Si se deshabilita el rol, se lo eliminamos a los usuarios que lo poseen
            if (state == 0)
            {
                Connection.WriteInTheBase("DELETE EL_GROUP_BY.Rol_Usuario WHERE Rol_Id = " + id.ToString());
            }
        }

        public static List<RoleDAO> GetRolesForUser(Int32 id, string spname)
        {
            List<RoleDAO> roles = new List<RoleDAO>();

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@USER_ID", id));

            SqlDataReader reader = Connection.GetDataReader(spname, Connection.Type.StoredProcedure, parameters);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RoleDAO rol = GetRoleDAO(reader);
                    roles.Add(rol);
                }
            }

            reader.Close();

            return roles;
        }
        
        private static RoleDAO GetRoleDAO(SqlDataReader reader)
        {
            RoleDAO role = new RoleDAO();

            role.Id = reader.GetInt32(reader.GetOrdinal("Rol_ID"));
            role.Name = reader.GetString(reader.GetOrdinal("Rol_Nombre"));
            role.State = reader.GetBoolean(reader.GetOrdinal("Rol_Habilitado"));

            return role;
        }

        public static void AddUserRole(Int32 userid, RoleDAO role)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USER_ID", SqlDbType.Int);
            parameter.Value = userid;
            parameters.Add(parameter);

            parameter = new SqlParameter("@ROL_ID", SqlDbType.Int);
            parameter.Value = role.Id;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.AGREGAR_ROL_A_USUARIO", Connection.Type.StoredProcedure, parameters);
        }

        public static void DeleteUserRole(Int32 userid, RoleDAO role)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USER_ID", SqlDbType.Int);
            parameter.Value = userid;
            parameters.Add(parameter);

            parameter = new SqlParameter("@ROL_ID", SqlDbType.Int);
            parameter.Value = role.Id;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_ROL_A_USUARIO", Connection.Type.StoredProcedure, parameters);
        }


    }
}
