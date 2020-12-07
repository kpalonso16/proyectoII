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
    public class cls_ServiciosEncargado_BLL
    {
        #region VARIABLES GLOBALES
        SVC_BD.GeneralClient Cliente_WCF = new SVC_BD.GeneralClient();
        DataTable dt = new DataTable();
        DataTable myDt = new DataTable();
        #endregion


        public DataTable ListarFiltro_ServiciosEncargado(string sFiltro)
        {
            if(sFiltro == string.Empty)
            {

                dt = new DataTable("Encargado");
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("opcion", "6", "select");

                return Cliente_WCF.ListarFiltrar("Encargado", "sp_Encargado", dt);
            }
            else
            {
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("opcion","6","selectfilt");
                dt.Rows.Add("@NombreCompleto", "6", sFiltro);

                return Cliente_WCF.ListarFiltrar("Encargado", "sp_Encargado", dt);
            }
        }

        public string Guardar_ServiciosEncargado(cls_Encargado_DAL Obj_Encargado_DAL)
        {
            dt = new DataTable("Encargado");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "insert");
            //dt.Rows.Add("@ID", "1", 1);
            dt.Rows.Add("@NombreCompleto", "6", Obj_Encargado_DAL.sNombreCompleto); 
            dt.Rows.Add("@IDOcupacion", "1", Obj_Encargado_DAL.iIDOcupacion);
            dt.Rows.Add("@Telefono", "6", Obj_Encargado_DAL.sTelefono);

            string sResultado = Cliente_WCF.Ins_Upd_Delete("sp_Encargado","NORMAL",dt).ToString().Trim();

            if (string.IsNullOrEmpty(sResultado))
            {
                return string.Empty;
            }
            else
            {
                return sResultado;
            }
        }

        public string Editar_ServiciosEncargado(cls_Encargado_DAL Obj_Encargado_DAL)
        {
            dt = new DataTable("Encargado");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "update");
            //dt.Rows.Add("@ID", "1", 1);
            dt.Rows.Add("@ID", "1", Obj_Encargado_DAL.IID);
            dt.Rows.Add("@NombreCompleto", "6", Obj_Encargado_DAL.sNombreCompleto);
            dt.Rows.Add("@IDOcupacion", "1", Obj_Encargado_DAL.iIDOcupacion);
            dt.Rows.Add("@Telefono", "6", Obj_Encargado_DAL.sTelefono);

            string sResultado = Cliente_WCF.Ins_Upd_Delete("sp_Encargado", "NORMAL", dt).ToString().Trim();

            if (string.IsNullOrEmpty(sResultado))
            {
                return string.Empty;
            }
            else
            {
                return sResultado;
            }
        }

        public string Eliminar_ServiciosEncargados(string sFiltro)
        {
            dt = new DataTable("Encargado");
            dt = Cliente_WCF.GetDataTable(null);
            dt.Rows.Add("@opcion", "6", "delete");
            dt.Rows.Add("@ID", "1", sFiltro);

            string sReultado = Cliente_WCF.Ins_Upd_Delete("sp_Encargado", "NORMAL", dt).ToString().Trim();

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
