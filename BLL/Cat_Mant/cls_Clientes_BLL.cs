using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL.SVC_BD;
using DAL.Cat_Mant;

namespace BLL.Cat_Mant
{
    public class cls_Clientes_BLL
    {

        #region VARIABLES GLOBALES
        
        SVC_BD.GeneralClient Cliente_WCF = new SVC_BD.GeneralClient();
        DataTable dt = new DataTable();

        #endregion


        public DataTable ListarFiltro_Clientes(string sFiltro)
        {
            if (sFiltro == string.Empty)
            {

                dt = new DataTable("Clientes");
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("opcion", "6", "select");

                return Cliente_WCF.ListarFiltrar("Clientes", "sp_Clientes", dt);
            }
            else
            {
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("opcion", "6", "selectfilt");
                dt.Rows.Add("@Nombre", "6", sFiltro);

                return Cliente_WCF.ListarFiltrar("Clientes", "sp_Clientes", dt);
            }
        }

        public string Guardar_Clientes(cls_Clientes_DAL Obj_Clientes_DAL)
        {
            dt = new DataTable("Clientes");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "insert");
            //dt.Rows.Add("@ID", "1", 1);

            dt.Rows.Add("@Nombre", "6", Obj_Clientes_DAL.sNombre);
            dt.Rows.Add("@Apellidos", "6", Obj_Clientes_DAL.sApellidos);
            dt.Rows.Add("@Identificacion", "6", Obj_Clientes_DAL.sIdentificacion);
            dt.Rows.Add("@Correo", "6", Obj_Clientes_DAL.sCorreo);
            dt.Rows.Add("@Telefono", "6", Obj_Clientes_DAL.sTelefono);
            dt.Rows.Add("@IDEstado", "1", Obj_Clientes_DAL.iIDEstado);

            string sResultado = Cliente_WCF.Ins_Upd_Delete("sp_Clientes", "NORMAL", dt).ToString().Trim();

            if (string.IsNullOrEmpty(sResultado))
            {
                return string.Empty;
            }
            else
            {
                return sResultado;
            }
        }

        public string Editar_Clientes(cls_Clientes_DAL Obj_Clientes_DAL)
        {


            dt = new DataTable("Clientes");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "update");
            //dt.Rows.Add("@ID", "1", 1);
            dt.Rows.Add("@ID", "6", Obj_Clientes_DAL.iID);
            dt.Rows.Add("@Nombre", "6", Obj_Clientes_DAL.sNombre);
            dt.Rows.Add("@Apellidos", "6", Obj_Clientes_DAL.sApellidos);
            dt.Rows.Add("@Identificacion", "6", Obj_Clientes_DAL.sIdentificacion);
            dt.Rows.Add("@Correo", "6", Obj_Clientes_DAL.sCorreo);
            dt.Rows.Add("@Telefono", "6", Obj_Clientes_DAL.sTelefono);
            dt.Rows.Add("@IDEstado", "1", Obj_Clientes_DAL.iIDEstado);

            string sResultado = Cliente_WCF.Ins_Upd_Delete("sp_Clientes", "NORMAL", dt).ToString().Trim();

            if (string.IsNullOrEmpty(sResultado))
            {
                return string.Empty;
            }
            else
            {
                return sResultado;
            }
        }

        public string Eliminar_Clientes(string sFiltro)
        {
            dt = new DataTable("Clientes");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "delete");
            dt.Rows.Add("@ID", "1", sFiltro);

            string sReultado = Cliente_WCF.Ins_Upd_Delete("sp_Clientes", "NORMAL", dt).ToString().Trim();

            if (string.IsNullOrEmpty(sReultado))
            {
                return string.Empty;
            }
            else
            {
                return sReultado;
            }
        }

    }
}
