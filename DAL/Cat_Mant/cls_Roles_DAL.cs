using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
    public class cls_Roles_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iIDRol;
        private string _sDescripcion;

        private DataTable _DtRoles;
        private char _cBanAxn;
        #endregion

        #region VARIABLES PUBLICAS
        public int iIDRol { get => _iIDRol; set => _iIDRol = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public DataTable dtRoles { get => _DtRoles; set => _DtRoles = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }
        #endregion
    }
}
