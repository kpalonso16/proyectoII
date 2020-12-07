<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="Proyecto.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script src="Scripts/sweetalert2.min.js"></script>

<link rel="stylesheet" href="Scripts/sweetalert2.min.css">
    <div>
        <br />
        <br />
        <br />
        &nbsp;<asp:Label ID="lblBuscar" runat="server" Text="Nombre cliente"></asp:Label>
        &nbsp;<asp:TextBox ID="txtClienteBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar Cliente" OnClick="btnBuscar_Click" />
        <input type="button" name="btn_nuevo" value="Ingresar Nuevo Cliente" onclick="mostrar_ocultar_div('Clientes')" /> 
        <br />
        <br />
    </div>

    <div id="Clientes" style="display:none; margin-left:auto;margin-right:auto;">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblApellidos" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblIdentificacion" runat="server" Text="Cedula de Identidad"></asp:Label>
        <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCorreo" runat="server" Text="Correo Electronico"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        
        <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEstadoCliente" runat="server" Text="Estado del Cliente"></asp:Label>
        <asp:DropDownList ID="ddlEstadoCliente" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardarCliente" runat="server" Text="Agregar nuevo Cliente" OnClick="btnGuardarCliente_Click" />
        <input type="button" name="btn_cancelar" value="Cancelar" onclick="mostrar_ocultar_div('Clientes')" /> 
    </div>
    <br />
    <asp:GridView ID="dgvClientes" runat="server" CellPadding="4" ForeColor="#333333"  GridLines="None" HorizontalAlign="Center"
        AutoGenerateColumns="False"
        OnRowCancelingEdit="dgvClientes_RowCancelingEdit"
OnRowEditing="dgvClientes_RowEditing" OnRowUpdating="dgvClientes_RowUpdating"  
        onrowdatabound="dgvClientes_RowDataBound" OnRowDeleting="dgvClientes_RowDeleting">
        <Columns>  
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
              <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Delete" runat="server" Text="Delete" OnClientClick="functionConfirm();" CommandName="Delete"/>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Nombre">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_NombreEdit" runat="server" Text='<%#Eval("Nombre") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_NombreEdit" runat="server" Text='<%#Eval("Nombre") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Apellidos">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ApellidosEdit" runat="server" Text='<%#Eval("Apellidos") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_ApellidosEdit" runat="server" Text='<%#Eval("Apellidos") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Identificacion">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_IdentificacionEdit" runat="server" Text='<%#Eval("Identificacion") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_IdentificacionEdit" runat="server" Text='<%#Eval("Identificacion") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Correo">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_CorreoEdit" runat="server" Text='<%#Eval("Correo") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_CorreoEdit" runat="server" Text='<%#Eval("Correo") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Telefono">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_telefonoEdit" runat="server" Text='<%#Eval("Telefono") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_telefonoEdit" runat="server" Text='<%#Eval("Telefono") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
             <asp:TemplateField HeaderText="Tipo">
                 <EditItemTemplate>
                     <asp:DropDownList ID="DropDownList1_Edit" runat="server">
                     </asp:DropDownList>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:Label ID="lbl_Tipo" runat="server" Text='<%# Eval("Tipo") %>'></asp:Label>
                 </ItemTemplate>
             </asp:TemplateField>
         </Columns>  




        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <script type="text/javascript">

        function mostrar_ocultar_div(bloq) {

            obj = document.getElementById(bloq);
            obj.style.display = (obj.style.display == 'none') ? 'block' : 'none';

        }
    </script>

        <script type="text/javascript">
            var javacriptVariable = "<%=Nombre+' '+Apellidos%>";
        function successalert() {
            swal({
                title: 'Eliminado con exito el cliente: '+javacriptVariable,
                text: 'Ha eliminado con exito el cliente seleccionado',
                type: 'success'           
            }).then(function () {
                // Redirect the user
                window.location.href = "VerClientes.aspx";
                console.log('The Ok Button was clicked.');
            });
           
        }
       
        </script>

    <script type="text/javascript">
        function errorAlert() {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'User or Password Incorrect',
            });
        }
    </script>

    <script type="text/javascript">
        function confirmdeletion() {
            swal({
                title: 'Are you sure?',
                text: "You won't be able to revert this!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((function (){
                if (result.isConfirmed) {
                    return true;
                    swal(
                        'Deleted!',
                        'Your file has been deleted.',
                        'success'
                    )
                } else {
                    return false;
                }
            }));
        }

    </script>
   <script type="text/javascript">
       function functionConfirm(event) {
           swal({
               title: 'Are you sure?',
               text: "You won't be able to revert this!",
               type: 'warning',
               showCancelButton: true,
               confirmButtonColor: '#3085d6',
               cancelButtonColor: '#d33',
               confirmButtonText: 'Yes, delete it!',
               cancelButtonText: 'No, cancel!',
               confirmButtonClass: 'btn btn-success',
               cancelButtonClass: 'btn btn-danger',
               buttonsStyling: false
           }).then(function (result) {
               if (result) {
                   $.ajax({
                       type: "POST",
                       url: "Default4.aspx/DeleteClick",
                       data: '{}',
                       contentType: "application/json; charset=utf-8",
                       dataType: "json",
                       success: function (r) {
                           swal("Data Transfered SuccessFully", r.d, "success");
                       }
                   });
               }
           },
               function (dismiss) {
                   if (dismiss == 'cancel') {
                       swal(
                           'Cancelled',
                           'Your imaginary file is safe :)',
                           'error')
                   }
               });
       }
   </script>

</asp:Content>
