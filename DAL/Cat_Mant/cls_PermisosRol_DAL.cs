using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
    public class cls_PermisosRol_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iRolID, _iPermisoID;

        private DataTable _DtPermisosRol;
        private char _cBanAxn;



        #endregion

        #region vARIABLES PUBLICAS

        public int iRolID { get => _iRolID; set => _iRolID = value; }
        public int iPermisoID { get => _iPermisoID; set => _iPermisoID = value; }
        public DataTable dtPermisosRol { get => _DtPermisosRol; set => _DtPermisosRol = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
