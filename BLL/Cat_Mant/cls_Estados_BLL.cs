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
    public class cls_Estados_BLL
    {
        #region VARIABLES GLOBALES

        SVC_BD.GeneralClient Cliente_WCF = new SVC_BD.GeneralClient();
        DataTable dt = new DataTable();

        #endregion

        public DataTable ListartFiltro_Estados(string sFiltro)
        {
            if (sFiltro == string.Empty)
            {

                dt = new DataTable("Estados");
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("@opcion", "6", "select");
                return Cliente_WCF.ListarFiltrar("Estados", "sp_Estados", dt);
            }
            else
            {
                dt = Cliente_WCF.GetDataTable(null);
                dt.Rows.Add("opcion", "6", "selectfilt");
                dt.Rows.Add("@Tipo", "6", sFiltro);

                return Cliente_WCF.ListarFiltrar("Estados", "sp_Estados", dt);
            }
        }
    }
}
