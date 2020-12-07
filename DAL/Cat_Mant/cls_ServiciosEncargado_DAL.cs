using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
    public class cls_ServiciosEncargado_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iIDServicio, _iIDEncargado;

        private DataTable _DtServicios;
        private char _cBanAxn;
        #endregion

        #region VARIABLES PUBLICAS
        public int iIDServicio { get => _iIDServicio; set => _iIDServicio = value; }
        public int iIDEncargado { get => _iIDEncargado; set => _iIDEncargado = value; }
        public DataTable dtServicios { get => _DtServicios; set => _DtServicios = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
