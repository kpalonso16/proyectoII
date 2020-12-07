using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Cat_Mant;
using DAL.Cat_Mant;
using System.Data;

namespace Proyecto
{
    public partial class VerEncargados : System.Web.UI.Page
    {

        #region VARIABLES GLOBALES
        cls_ServiciosEncargado_BLL Obj_Encargado_BLL = new cls_ServiciosEncargado_BLL();
        cls_Encargado_DAL Obj_Encargado_DAL = new cls_Encargado_DAL();

        cls_Ocupaciones_BLL Obj_Ocupaciones_BLL= new cls_Ocupaciones_BLL();
        cls_Ocupaciones_DAL Obj_Ocupaciones_DAL = new cls_Ocupaciones_DAL();
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar_DatosEncargado();
                Cargar_DatosOcupaciones();
            }
        }

        public void Cargar_DatosEncargado()
        {
            DataTable dt = Obj_Encargado_BLL.ListarFiltro_ServiciosEncargado(txtNombreEncargadoBuscar.Text.Trim());
            
            dgvEncargados.DataSource = dt;
            dgvEncargados.DataBind();

        }

        public void Cargar_DatosOcupaciones()
        {
            
            DataTable mydt = Obj_Ocupaciones_BLL.ListartFiltro_Ocupaciones(string.Empty);
            DropDownList1.DataSource = mydt;
           
            DropDownList1.DataTextField = "DESCRIPCION";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();


        }

        protected void dgvEncargados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)dgvEncargados.Rows[e.RowIndex];
            Label id = dgvEncargados.Rows[e.RowIndex].FindControl("lbl_ID") as Label;

            Obj_Encargado_DAL.IID = Convert.ToInt32(id.Text.Trim());

            string sResultado = Obj_Encargado_BLL.Eliminar_ServiciosEncargados(id.Text.Trim());

            Cargar_DatosEncargado();
        }

        protected void dgvEncargados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            dgvEncargados.EditIndex = e.NewEditIndex;
            Cargar_DatosEncargado();
            //Cargar_DatosOcupaciones();
        }


        protected void dgvEncargados_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList ddList = (DropDownList)e.Row.FindControl("DropDownList1_Edit");

                    //return DataTable havinf department data
                    DataTable mydt = Obj_Ocupaciones_BLL.ListartFiltro_Ocupaciones("".ToString().Trim());
                    ddList.DataSource = mydt;

                    ddList.DataTextField = "DESCRIPCION";
                    ddList.DataValueField = "ID";
                    ddList.DataBind();
                    DataRowView dr = e.Row.DataItem as DataRowView;
                    ddList.SelectedValue = dr["Descripcion"].ToString();
                }

            }
        }

        protected void dgvEncargados_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label id = dgvEncargados.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox name = dgvEncargados.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox telefono = dgvEncargados.Rows[e.RowIndex].FindControl("txt_telefono") as TextBox;
           DropDownList EditValue = dgvEncargados.Rows[e.RowIndex].FindControl("DropDownList1_Edit") as DropDownList;
           


            Obj_Encargado_DAL.IID = Convert.ToInt32(id.Text.Trim());
            Obj_Encargado_DAL.sNombreCompleto = name.Text.Trim();
            Obj_Encargado_DAL.iIDOcupacion = Convert.ToInt32(EditValue.Text);
            Obj_Encargado_DAL.sTelefono = telefono.Text.Trim();

            string sResultado = Obj_Encargado_BLL.Editar_ServiciosEncargado(Obj_Encargado_DAL);

            dgvEncargados.EditIndex = -1;
            Cargar_DatosEncargado();
            Cargar_DatosOcupaciones();
        }

        protected void dgvEncargados_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            dgvEncargados.EditIndex = -1;
            Cargar_DatosEncargado();
            Cargar_DatosOcupaciones();
        }

        protected void btnBuscarNombreEncargado_Click(object sender, EventArgs e)
        {
            Cargar_DatosEncargado();
            //Cargar_DatosOcupaciones();
        }

        protected void btnGuardarEncargado_Click(object sender, EventArgs e)
        {
            Obj_Encargado_DAL.sNombreCompleto = txt_NombreEncargado.Text.Trim();
            Obj_Encargado_DAL.iIDOcupacion = Convert.ToInt32(DropDownList1.SelectedValue);
            Obj_Encargado_DAL.sTelefono = txtTelefono.Text.Trim();

            string sResultado = Obj_Encargado_BLL.Guardar_ServiciosEncargado(Obj_Encargado_DAL);

            if (sResultado == string.Empty)
            {
                txt_NombreEncargado.Text = string.Empty;
                //txtOcupacion.Text = string.Empty;
                txtTelefono.Text = string.Empty;

                Cargar_DatosEncargado();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('" + @"SE PRESENTO UN ERROR A LA HORA DE GUARDAR LA INFORMACIÓN DIGITADA.\n\nDETALLE ERROR: [  " + sResultado.Replace('"', ' ').Replace("'", "").Replace("\n", "").Replace("\r", " ") + " ]." + "')", true);
                txtNombreEncargadoBuscar.Text = string.Empty;
                Cargar_DatosEncargado();
            }

        }

        
    }
}