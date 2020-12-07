<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEncargados.aspx.cs" Inherits="Proyecto.VerEncargados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div >
        <br />
        <br />
        <br />
        <asp:Label ID="lblNombreEncargado" runat="server" Text="Nombre de Encargado"></asp:Label>
        &nbsp;<asp:TextBox ID="txtNombreEncargadoBuscar" runat="server"></asp:TextBox>
        
        &nbsp;<asp:Button ID="btnBuscarNombreEncargado" runat="server" Text="Buscar Encargado" OnClick="btnBuscarNombreEncargado_Click" />
        <input type="button" name="btn_nuevo" value="Ingresar Nuevo Encargado" onclick="mostrar_ocultar_div('Encargados')" /> 
        
        
        <br />
        <br />
     </div>
   
    <div id="Encargados" style="display:none; margin-left:auto;margin-right:auto;" >
        <asp:Label ID="lbl_NombreEncargado" runat="server" Text="Nombre Encargado"></asp:Label>
        <asp:TextBox ID="txt_NombreEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOcupacion" runat="server" Text="Ocupacion"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="37px" Width="455px"></asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblTelefono" runat="server" Text="Numero de Telefono"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardarEncargado" runat="server" Text="Agregar nuevo encargado" OnClick="btnGuardarEncargado_Click" />
        <input type="button" name="btn_cancelar" value="Cancelar" onclick="mostrar_ocultar_div('Encargados')" /> 
    </div>
        
    <br />
    <asp:GridView ID="dgvEncargados" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" 
        OnRowCancelingEdit="dgvEncargados_RowCancelingEdit"
OnRowEditing="dgvEncargados_RowEditing" OnRowUpdating="dgvEncargados_RowUpdating"  
        onrowdatabound="dgvEncargados_RowDataBound" OnRowDeleting="dgvEncargados_RowDeleting" HorizontalAlign="Center">
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
                        <asp:Button ID="btn_Delete" runat="server" Text="Delete" CommandName="delete" />  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="NombreCompleto">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("NombreCompleto") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("NombreCompleto") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Telefono">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_telefono" runat="server" Text='<%#Eval("Telefono") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_telefono" runat="server" Text='<%#Eval("Telefono") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
             <asp:TemplateField HeaderText="Descripcion">
                 <EditItemTemplate>
                     <asp:DropDownList ID="DropDownList1_Edit" runat="server">
                     </asp:DropDownList>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:Label ID="lbl_IDOcupacion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
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
	        obj.style.display = (obj.style.display=='none') ? 'block' : 'none';

       }
   </script>
    
</asp:Content>
