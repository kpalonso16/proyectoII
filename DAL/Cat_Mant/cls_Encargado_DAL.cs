using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_Encargado_DAL
    {

        #region VARIABLES PRIVADAS

        private int _iIDOcupacion;
        private int _iID;


        private string _sNombreCompleto, _sTelefono;

        //private DataTable _DtEncargado;
        //private char _cBanAxn;


        #endregion

        #region vARIABLES PUBLICAS
        public int iIDOcupacion { get => _iIDOcupacion; set => _iIDOcupacion = value; }
        public string sNombreCompleto { get => _sNombreCompleto; set => _sNombreCompleto = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public int IID { get => _iID; set => _iID = value; }
        //public DataTable dtEncargado { get => _DtEncargado; set => _DtEncargado = value; }
        //public char cBanAxn { get => _cBanAxn; set => _cBanAxn = value; }

        #endregion
    }
}
