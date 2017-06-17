<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../MasterPages/Administrador.Master" CodeBehind="Udadministrativa.aspx.cs" Inherits="ctrlArchivos.vista.Udadministrativa" %>


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <link href="../css/Forms.css" rel="stylesheet" type="text/css" />
    <script src="../JS/Alerts.js"></script>
    <script src="../JS/validarboton.js"></script>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div id="contenido">
        
        <br />
             
          <div class="MyToolBar">
            <div class="MyButton">
                
                <asp:Button ID="btnbuscar" runat="server" Text="Buscar" OnClick="btnbuscar_Click" />
            </div>
            <div class ="MyButton">
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" />                
            </div>
            <div class ="MyButton">
                 <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" />
            </div>
              
              
              
             
              
              
              
        </div>

        <div class="mysection">        
            
            <div class="mycontrol">
                Identificador:
                <br />

                <asp:TextBox ID="Txtiduni" runat="server"></asp:TextBox>
            </div>

            <div class="mycontrol">

                Nombre de la unidad:<br />

                <asp:TextBox ID="Txtnomuni" runat="server"></asp:TextBox>

            </div>

            <div class="mycontrol">
                Telefono:<br />

                <asp:TextBox ID="Txtteluni" runat="server"></asp:TextBox>
                       

            </div>

            <div class="mycontrol">
                E-mail:<br />
                <asp:TextBox ID="Txtemailuni" runat="server"></asp:TextBox>
                               
            </div>

            <div class="mycontrol">
                Domicilio:<br />
                <asp:TextBox ID="Txtdomiunni" runat="server"></asp:TextBox>
                
            </div>
            
            <div class="mycontrol">
                Pertenencia de unidad administrativa:<br />

                <asp:DropDownList ID="ddlunipert" runat="server"></asp:DropDownList>
            </div>
        </div>


        <div class="mycontrol">
                Nivel de unidad administrativa:<br />

                <asp:DropDownList ID="ddlnomnivel" runat="server" OnSelectedIndexChanged="ddlnomnivel_SelectedIndexChanged">
                </asp:DropDownList>
              

                <br />

                <asp:Label ID="lblidnivel" runat="server" Text="hola"></asp:Label>
            </div>
        </div>

    
    
        <div class="MyToolBar">
            <div class="MyButton">
                    <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
                  </div>
              
               </div>

    
</asp:Content>
