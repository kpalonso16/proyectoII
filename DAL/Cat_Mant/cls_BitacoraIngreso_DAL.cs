using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_BitacoraIngreso_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iID, _iIDCliente;
        private DateTime _dEntrada, _dSalida;
        private String _sDetalle;


        private DataTable _DtBitacoraIngreso;
        private char _cBanAxn;


        #endregion

        #region vARIABLES PUBLICAS

        public int iID { get => _iID; set => _iID = value; }
        public int iID_Cliente { get => _iIDCliente; set => _iIDCliente = value; }
        public DateTime dEntrada { get => _dEntrada; set => _dEntrada = value; }
        public DateTime dSalida { get => _dSalida; set => _dSalida = value; }
        public string sDetalle { get => _sDetalle; set => _sDetalle = value; }
        public DataTable dtBitacoraIngreso { get => _DtBitacoraIngreso; set => _DtBitacoraIngreso = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
