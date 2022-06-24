<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="Evaluacion3Web.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="row">
    <div class="col-lg-6 mx-auto">
        <div class="mensaje">
            <asp:Label runat="server" ID="mensajeLb1" CssClass="text-success"></asp:Label>
        </div>
        <div class="card">
            <div class="card-header bg-secondary text-white">
                <h3>Agregar Lectura</h3>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="medidorDd1">Seleccione Medidor</label>
                    <asp:DropDownList runat="server" ID="medidorDd1" CssClass="form-select">
                    </asp:DropDownList>
                </div>
                <div>
                    <label for="fechaTxt">Fecha Lectura</label>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </div>
                <div class="form-group">
                    <label for="horaTxt">Hora Lectura</label>
                    <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="minutosTxt">Minutos Lectura</label>
                    <asp:TextBox ID="minutosTxt" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="consumoTxt">Consumo</label>
                    <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="agregarBtn2" OnClick="agregarBtn2_Click" Text="Agregar Lectura" CssClass="btn btn-primary"/>
                </div>
            </div>
        </div>
    </div>
</div>







</asp:Content>

