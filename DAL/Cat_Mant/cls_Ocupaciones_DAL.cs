using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Ocupaciones_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iID;
        private string _sDescripcion;

        //private DataTable _DtOcupaciones;
        //private char _cBanAxn;

        #endregion

        #region vARIABLES PUBLICAS

        public int iID { get => _iID; set => _iID = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        //public DataTable dtOcupaciones { get => _DtOcupaciones; set => _DtOcupaciones = value; }
        //public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }


        #endregion
    }
}
