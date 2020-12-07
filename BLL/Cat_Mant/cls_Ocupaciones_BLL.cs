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
    public class cls_Ocupaciones_BLL
    {
        #region VARIABLES GLOBALES
        SVC_BD.GeneralClient Cliente_WCF_Ocu = new SVC_BD.GeneralClient();
        DataTable dt = new DataTable();
        DataTable myDt = new DataTable();
        #endregion


        public DataTable ListartFiltro_Ocupaciones(string sFiltro)
        { 
            if (sFiltro == string.Empty)
            {

                dt = new DataTable("Ocupaciones");
                dt = Cliente_WCF_Ocu.GetDataTable(null);
                dt.Rows.Add("@opcion", "6", "select");
                return Cliente_WCF_Ocu.ListarFiltrar("Ocupaciones", "sp_Ocupaciones", dt);
            }
            else
            {
                dt = Cliente_WCF_Ocu.GetDataTable(null);
                dt.Rows.Add("opcion", "6", "selectfilt");
                dt.Rows.Add("@Descripcion", "6", sFiltro);

                return Cliente_WCF_Ocu.ListarFiltrar("Ocupaciones", "sp_Ocupaciones", dt);
            }
        }

    }
}
