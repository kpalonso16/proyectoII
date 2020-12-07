using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Cat_Mant;
using DAL.Cat_Mant;
using System.Data;
using System.Web.Services;


namespace Proyecto
{
    public partial class VerClientes : System.Web.UI.Page
    {

        #region VARIABLES GLOBALES
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        cls_Estados_DAL Obj_Estados_DAL = new cls_Estados_DAL();
        public string Nombre, Apellidos,sResultado, _ID;
        public cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
        cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar_DatosEstados();
                Cargar_DatosClientes();
            }
        }


        public void Cargar_DatosEstados()
        {
            DataTable mydt = Obj_Estados_BLL.ListartFiltro_Estados("".ToString().Trim());
            ddlEstadoCliente.DataSource = mydt;

            ddlEstadoCliente.DataTextField = "TIPO";
            ddlEstadoCliente.DataValueField = "ID";
            ddlEstadoCliente.DataBind();
        }
        
        public void Cargar_DatosClientes()
        {
            DataTable dt = Obj_Clientes_BLL.ListarFiltro_Clientes(txtClienteBuscar.Text.Trim());

            dgvClientes.DataSource = dt;
            dgvClientes.DataBind();

        }
        [WebMethod]
        protected void dgvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)dgvClientes.Rows[e.RowIndex];
            Label id = dgvClientes.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            Label _Nombre = dgvClientes.Rows[e.RowIndex].FindControl("lbl_NombreEdit") as Label;
            Label _Apellidos = dgvClientes.Rows[e.RowIndex].FindControl("lbl_ApellidosEdit") as Label;

            Nombre = _Nombre.Text.ToString();
            Apellidos = _Apellidos.Text.ToString();
            Obj_Clientes_DAL.iID = Convert.ToInt32(id.Text.Trim());
            ID = id.Text.Trim();
           //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "confirmdeletion();", true);

           
            sResultado = Obj_Clientes_BLL.Eliminar_Clientes(id.Text.Trim());

            

            Cargar_DatosClientes();
        }

        protected void dgvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            dgvClientes.EditIndex = e.NewEditIndex;
            Cargar_DatosClientes();
            //Cargar_DatosOcupaciones();
        }


        protected void dgvClientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList ddList = (DropDownList)e.Row.FindControl("DropDownList1_Edit");

                    //return DataTable havinf department data
                    DataTable mydt = Obj_Estados_BLL.ListartFiltro_Estados("".ToString().Trim());
                    ddList.DataSource = mydt;

                    ddList.DataTextField = "TIPO";
                    ddList.DataValueField = "ID";
                    ddList.DataBind();
                    DataRowView dr = e.Row.DataItem as DataRowView;
                    ddList.SelectedValue = dr["TIPO"].ToString();
                }

            }
        }

        protected void dgvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label id = dgvClientes.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox nombre = dgvClientes.Rows[e.RowIndex].FindControl("txt_NombreEdit") as TextBox;
            TextBox apellidos = dgvClientes.Rows[e.RowIndex].FindControl("txt_ApellidosEdit") as TextBox;
            TextBox identificacion = dgvClientes.Rows[e.RowIndex].FindControl("txt_IdentificacionEdit") as TextBox;
            TextBox correo = dgvClientes.Rows[e.RowIndex].FindControl("txt_CorreoEdit") as TextBox;
            TextBox telefono = dgvClientes.Rows[e.RowIndex].FindControl("txt_telefonoEdit") as TextBox;
            DropDownList EditValue = dgvClientes.Rows[e.RowIndex].FindControl("DropDownList1_Edit") as DropDownList;

            Obj_Clientes_DAL.iID = Convert.ToInt32(id.Text.Trim());
            Obj_Clientes_DAL.sNombre = nombre.Text.Trim();
            Obj_Clientes_DAL.sApellidos = apellidos.Text.Trim();
            Obj_Clientes_DAL.sIdentificacion = identificacion.Text.Trim();
            Obj_Clientes_DAL.sCorreo = correo.Text.Trim();
            Obj_Clientes_DAL.sTelefono = telefono.Text.Trim();
            Obj_Clientes_DAL.iIDEstado = Convert.ToInt32(ddlEstadoCliente.SelectedValue);

            string sResultado = Obj_Clientes_BLL.Editar_Clientes(Obj_Clientes_DAL);

            dgvClientes.EditIndex = -1;
            Cargar_DatosClientes();
            Cargar_DatosEstados();
        }

        protected void dgvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            dgvClientes.EditIndex = -1;
            Cargar_DatosClientes();
            Cargar_DatosEstados();
        }

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Obj_Clientes_DAL.sNombre = txtNombreCliente.Text.Trim();
            Obj_Clientes_DAL.sApellidos = txtApellidos.Text.Trim();
            Obj_Clientes_DAL.sIdentificacion = txtIdentificacion.Text.Trim();
            Obj_Clientes_DAL.sCorreo = txtCorreo.Text.Trim();
            Obj_Clientes_DAL.sTelefono = txtTelefono.Text.Trim();
            Obj_Clientes_DAL.iIDEstado = Convert.ToInt32(ddlEstadoCliente.SelectedValue);

            string sResultado = Obj_Clientes_BLL.Guardar_Clientes(Obj_Clientes_DAL);

            if (sResultado == string.Empty)
            {
                txtNombreCliente.Text = string.Empty;
                txtApellidos.Text = string.Empty;
                txtIdentificacion.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                txtTelefono.Text = string.Empty;

                Cargar_DatosClientes();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('" + @"SE PRESENTO UN ERROR A LA HORA DE GUARDAR LA INFORMACIÓN DIGITADA.\n\nDETALLE ERROR: [  " + sResultado.Replace('"', ' ').Replace("'", "").Replace("\n", "").Replace("\r", " ") + " ]." + "')", true);
                txtClienteBuscar.Text = string.Empty;
                Cargar_DatosClientes();
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_DatosClientes();
        }
    }
}