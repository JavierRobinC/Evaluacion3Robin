<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="VerLectura.aspx.cs" Inherits="Evaluacion3Web.VerLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">    
                    <div class="form-group">                    
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="Aun no existen Lecturas" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="NumeroMed" HeaderText="Tipo Medidor" />
                            <asp:BoundField DataField="FechaLec" HeaderText="Fecha Lectura" />
                            <asp:BoundField DataField="HoraLec" HeaderText="Hora" />
                            <asp:BoundField DataField="MinutoLec" HeaderText="Minutos" />
                            <asp:BoundField DataField="ValorConsumo" HeaderText="Consumo" />                           
                        </Columns>
                    </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
