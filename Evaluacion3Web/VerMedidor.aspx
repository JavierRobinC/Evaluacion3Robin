<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="Evaluacion3Web.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="tipoDb1">Filtrar Medidor</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipoDb1_SelectedIndexChanged" runat="server" ID="tipoDb1">
                            <asp:ListItem Value="1" Text="Digital"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Analogico"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="Aun no existen Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="NroMedidor" HeaderText="Numero Medidor" />
                            <asp:BoundField DataField="TipoMdr" HeaderText="Tipo Medidor" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
