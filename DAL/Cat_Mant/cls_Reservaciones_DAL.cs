using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Reservaciones_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iID, _iIDCliente, _iIDServicio, _iIDEncargado, _iIDEstado, _iIDUsuario;
        private DateTime _dFechaInicio, _dFechaFinalizacion, _dFechaReserva;

        private DataTable _DtReservaciones;
        private char _cBanAxn;
        #endregion

        #region VARIABLES PUBLICAS

        public int iID { get => _iID; set => _iID = value; }
        public int iIDCliente { get => _iIDCliente; set => _iIDCliente = value; }
        public int iIDServicio { get => _iIDServicio; set => _iIDServicio = value; }
        public int iIDEncargado { get => _iIDEncargado; set => _iIDEncargado = value; }
        public int iIDEstado { get => _iIDEstado; set => _iIDEstado = value; }
        public int iIDUsuario { get => _iIDUsuario; set => _iIDUsuario = value; }
        public DateTime dFechaInicio { get => _dFechaInicio; set => _dFechaInicio = value; }
        public DateTime dFechaFinalizacion { get => _dFechaFinalizacion; set => _dFechaFinalizacion = value; }
        public DateTime dFechaReserva { get => _dFechaReserva; set => _dFechaReserva = value; }
        public DataTable dtReservaciones { get => _DtReservaciones; set => _DtReservaciones = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }
        #endregion
    }
}
