using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
    public class cls_Servicios_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iID, _iIDTipo;
        private string _sNombre, _sDescripcion;

        private DataTable _DtServicios;
        private char _cBanAxn;
        #endregion

        #region VARIABLES PUBLICAS
        public int sSD { get => _iID; set => _iID = value; }
        public int iIDTipo { get => _iIDTipo; set => _iIDTipo = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public DataTable dtServicios { get => _DtServicios; set => _DtServicios = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }
        #endregion
    }
}
