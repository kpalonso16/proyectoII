using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Clientes_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iID, _iIDEstado;
        private string _sNombre, _sApellidos, _sIdentificacion, _sCorreo, _sTelefono;

        private DataTable _DtClientes;
        private char _cBanAxn;


        #endregion

        #region vARIABLES PUBLICAS

        public int iID { get => _iID; set => _iID = value; }
        public int iIDEstado { get => _iIDEstado; set => _iIDEstado = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public DataTable dtClientes { get => _DtClientes; set => _DtClientes = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
