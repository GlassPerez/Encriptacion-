<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../MasterPages/Administrador.Master" CodeBehind="buscarunidad.aspx.cs" Inherits="ctrlArchivos.vista.buscarunidad" %>

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
                <asp:Button ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />                
            </div>
            <div class ="MyButton">
                 <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click" />
            </div>
              
              
              
             
              
              
              
        </div>

        <div class="mysection">        
            
            <div class="mycontrol">
                selecciona:
                <br />
                 <asp:DropDownList ID="ddlunidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlunidad_SelectedIndexChanged">
        </asp:DropDownList>
            </div>


            <div class="mycontrol">
                Identificador:
                <br />

                <asp:TextBox ID="Txtiduni" runat="server" Enabled="False"></asp:TextBox>
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
              <asp:DropDownList ID="ddlnivel" runat="server">
    </asp:DropDownList>       

                <br />
            </div>
       
        </div>
       
    
      

    
    
        <div class="MyToolBar">
            <div class="MyButton">
                    
                  </div>
                            
               <asp:Button ID="btnelimina" runat="server" Text="eliminar" OnClick="btnelimina_Click" />
                            
               <asp:Button ID="btnactualiza" runat="server" Text="Actualizar" OnClick="btnactualiza_Click" />
                            
               </div>

   
    
</asp:Content>
