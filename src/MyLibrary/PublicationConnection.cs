using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using DAO;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace MyLibrary
{
    public class PublicationConnection
    {
        public static DataSet ListPublication(String description, DateTime dateFrom, DateTime dateTo, String user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar, 255);
            parameter.Value = description;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_DESDE", SqlDbType.DateTime);
            parameter.Value = dateFrom;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_HASTA", SqlDbType.DateTime);
            parameter.Value = dateTo;
            parameters.Add(parameter);


            parameter = new SqlParameter("@USERNAME", SqlDbType.NVarChar, 50);
            parameter.Value = user;
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_PUBLICACIONES", Connection.Type.StoredProcedure, parameters);

            return ds;

        }

        public static SqlDataReader GetPublicationForEdit(Int32 id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PUBLI_ID", id));
            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_PUBLICACION_FOR_MODIFY", Connection.Type.StoredProcedure, parameters);

            return reader;
        }


        public static List<PublicationStateDAO> GetPublicationStates()
        {
            List<PublicationStateDAO> publicationStates = new List<PublicationStateDAO>();

            SqlDataReader reader = Connection.GetDataReader("SELECT * FROM EL_GROUP_BY.Estado_Publicacion");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PublicationStateDAO publicationState = GetPublicationState(reader);
                    publicationStates.Add(publicationState);
                }
                reader.NextResult();
            }

            reader.Close();

            return publicationStates;

        }

        private static PublicationStateDAO GetPublicationState(SqlDataReader reader)
        {
            PublicationStateDAO publicationState = new PublicationStateDAO();

            publicationState.StateID = reader.GetInt32(reader.GetOrdinal("Estado_Publicacion_ID"));
            publicationState.Description = reader.GetString(reader.GetOrdinal("Estado_Publicacion_Descripcion"));
            publicationState.Editable = reader.GetBoolean(reader.GetOrdinal("Estado_Publicacion_Modificable"));

            return publicationState;
        }

        public static List<RubroDAO> GetRubros()
        {
            List<RubroDAO> rubros = new List<RubroDAO>();

            SqlDataReader reader = Connection.GetDataReader("SELECT * FROM EL_GROUP_BY.Rubro");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RubroDAO rubro = GetRubro(reader);
                    rubros.Add(rubro);
                }
                reader.NextResult();
            }

            reader.Close();

            return rubros;

        }

        private static RubroDAO GetRubro(SqlDataReader reader)
        {
            RubroDAO rubro = new RubroDAO();

            rubro.Id = reader.GetInt32(reader.GetOrdinal("Rubro_ID"));
            rubro.Descripcion = reader.GetString(reader.GetOrdinal("Rubro_Descripcion"));
            
            return rubro;
        }

        public static void CreatePublications(PublicationDAO publication, BindingList<DateTime> batchDates, BindingList<UbicationDAO> ubicaciones, Int32 idEmpresa, RubroDAO rubro)
        {
            Int32 publicID;

            foreach (DateTime EspecDate in batchDates)
            {
                publication.EspecDate = EspecDate;
                publicID = CreatePublication(publication, idEmpresa, rubro);

                UbicationConnection.CreateUbications(publicID, ubicaciones);
            }
        }        

        private static int CreatePublication(PublicationDAO publication, Int32 idEmpresa, RubroDAO rubro)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;
            
            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar, 255);
            parameter.Value = publication.Description;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 255);
            parameter.Value = publication.Espectaculo_Direccion;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_ESPEC", SqlDbType.DateTime);
            parameter.Value = publication.EspecDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_VENCIMIENTO", SqlDbType.DateTime);
            parameter.Value = publication.EspecDate.AddMonths(6);
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_ID", SqlDbType.Int);
            parameter.Value = rubro.Id;
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMPRESA_ID", SqlDbType.Int);
            parameter.Value = idEmpresa;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_PUBLI", SqlDbType.DateTime);
            parameter.Value = publication.PublicDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CANT_LOC", SqlDbType.Int);
            parameter.Value = publication.CantLoc;
            parameters.Add(parameter);

            parameter = new SqlParameter("@USERNAME", SqlDbType.NVarChar, 50);
            parameter.Value = publication.Username;
            parameters.Add(parameter);

            parameter = new SqlParameter("@GRADO_ID", SqlDbType.Int);
            parameter.Value = publication.GradeID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@ESTADO_ID", SqlDbType.Int);
            parameter.Value = publication.StateID;
            parameters.Add(parameter);

            // Obtiene el id de la publicacion creada
            SqlParameter publiId = new SqlParameter("@PUBLI_ID", SqlDbType.Int);
            publiId.Size = sizeof(int);
            publiId.Direction = ParameterDirection.Output;
            parameters.Add(publiId);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_ESPECTACULO_PUBLICACION", Connection.Type.StoredProcedure, parameters);

            return Convert.ToInt32(publiId.Value);
        
        }


        public static void EditPublication(PublicationDAO publication, BindingList<UbicationDAO> ubicaciones, BindingList<UbicationDAO> deletedUbicaciones, RubroDAO rubro)
        {
            BindingList<UbicationDAO> insertedUbications = new BindingList<UbicationDAO>();

            foreach (UbicationDAO ubicacion in ubicaciones)
            {
                if (ubicacion.UbicacionId == 0)
                    insertedUbications.Add(ubicacion);
            }

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@PUBLI_ID", SqlDbType.Int);
            parameter.Value = publication.PubliID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@ESPEC_ID", SqlDbType.Int);
            parameter.Value = publication.Espectaculo_ID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar, 255);
            parameter.Value = publication.Description;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 255);
            parameter.Value = publication.Espectaculo_Direccion;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_ESPEC", SqlDbType.DateTime);
            parameter.Value = publication.EspecDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_VENCIMIENTO", SqlDbType.DateTime);
            parameter.Value = publication.EspecDate.AddMonths(6);
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_ID", SqlDbType.Int);
            parameter.Value = rubro.Id;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_PUBLI", SqlDbType.DateTime);
            parameter.Value = publication.PublicDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CANT_LOC", SqlDbType.Int);
            parameter.Value = publication.CantLoc;
            parameters.Add(parameter);

            parameter = new SqlParameter("@GRADO_ID", SqlDbType.Int);
            parameter.Value = publication.GradeID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@ESTADO_ID", SqlDbType.Int);
            parameter.Value = publication.StateID;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.EDITAR_ESPECTACULO_PUBLICACION", Connection.Type.StoredProcedure, parameters);

            UbicationConnection.CreateUbications(publication.PubliID, insertedUbications);
            UbicationConnection.DeleteUbications(publication.PubliID, deletedUbicaciones);

        }

        public static bool CheckPublicationExits(PublicationDAO publication, RubroDAO rubro)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@PUBLI_ID", SqlDbType.Int);
            parameter.Value = publication.PubliID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar,255);
            parameter.Value = publication.Description;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_PUBLI", SqlDbType.DateTime);
            parameter.Value = publication.PublicDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_ESPEC", SqlDbType.DateTime);
            parameter.Value = publication.EspecDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 255);
            parameter.Value = publication.Espectaculo_Direccion;
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_ID", SqlDbType.Int);
            parameter.Value = rubro.Id;
            parameters.Add(parameter);

            parameter = new SqlParameter("@GRADO_ID", SqlDbType.Int);
            parameter.Value = publication.GradeID;
            parameters.Add(parameter);
            
            SqlParameter result = new SqlParameter("@EXISTE", SqlDbType.Bit);
            result.Size = sizeof(bool);
            result.Direction = ParameterDirection.Output;
            parameters.Add(result);

            Connection.WriteInTheBase("EL_GROUP_BY.EXISTE_ESPECTACULO_PUBLICACION", Connection.Type.StoredProcedure, parameters);

            return Convert.ToBoolean(result.Value);
        }

    }
}
