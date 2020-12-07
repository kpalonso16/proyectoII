using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Estados_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iID;
        private string _sTipo;

        private DataTable _DtEstados;
        private char _cBanAxn;

        #endregion

        #region vARIABLES PUBLICAS

        public int iID { get => _iID; set => _iID = value; }
        public string sTipo { get => _sTipo; set => _sTipo = value; }
        public DataTable dtEstados { get => _DtEstados; set => _DtEstados = value; }
        public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
