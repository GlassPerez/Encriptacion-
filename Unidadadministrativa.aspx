<%@ Page Title="" Language="C#" MasterPageFile="../MasterPages/Administrador.Master" AutoEventWireup="true" Inherits="ctrlArchivos.vista.Unidadadministrativa" %>

<script runat="server">

   
</script>





<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <link href="../css/Forms.css" rel="stylesheet" type="text/css" />
    <script src="../JS/Alerts.js"></script>
    <script src="../JS/validarboton.js"></script>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div id="contenido">
        
        <br />
             
      

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

            <asp:DropDownList ID="ddlniveluadm" runat="server"></asp:DropDownList>
            </div>
        </div>

    
    
        <div class="MyToolBar">
            <div class="MyButton">
                  <asp:Button ID="Btnagregauni" runat="server" Text="Button" OnClick="Btnagregauni_Click"  />
                  </div>
              
               </div>

   
    
</asp:Content>


