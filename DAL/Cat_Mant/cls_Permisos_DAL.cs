using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Permisos_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iPermisoID;
        private string _sDescripcion;

        private DataTable _DtPermisos;
        private char _cBanAxn;

        #endregion

        #region vARIABLES PUBLICAS

        public int iPermisoID { get => _iPermisoID; set => _iPermisoID = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public DataTable dtPermisos { get => _DtPermisos; set => _DtPermisos = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }


        #endregion
    }
}
