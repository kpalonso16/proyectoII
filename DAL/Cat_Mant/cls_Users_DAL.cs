using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
    public class cls_Users_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iUserID, _iIDRol;
        private string _sNombre, _sApellidos, _sIdentificacion, _sUser, _sPass, _sCorreo;

        private DataTable _DtUsers;
        private char _cBanAxn;
        #endregion

        #region VARIABLES PUBLICAS

        public int iUserID { get => _iUserID; set => _iUserID = value; }
        public int iIDRol { get => _iIDRol; set => _iIDRol = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public string sUser { get => _sUser; set => _sUser = value; }
        public string sPass { get => _sPass; set => _sPass = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public DataTable dtUsers { get => _DtUsers; set => _DtUsers = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
