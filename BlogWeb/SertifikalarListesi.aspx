<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SertifikalarListesi.aspx.cs" Inherits="BlogWeb.SertifikalarListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
         
     <form id="Form1" runat="server">
 <table class="table table-bordered">
     <tr>
         <th>ID</th>
         <th>SERTİFİKALAR</th>
         <th>İŞLEMLER</th>
      
     </tr>
     <tbody>
         <asp:Repeater ID="Repeater1" runat="server">
             <ItemTemplate>
                 <tr>
                     <td><%#Eval("ID") %></td>
                     <td><%#Eval("SERTIFIKALAR") %></td>
                     <td>
                         <asp:HyperLink NavigateUrl='<%# "SertifikaSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1"
                             runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                         <asp:HyperLink NavigateUrl='<%# "SertifikaGuncelle.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2"
                             runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>

                     </td>

                 </tr>
             </ItemTemplate>
         </asp:Repeater>
     </tbody>
 </table>
     <asp:HyperLink NavigateUrl="~/SertifikaEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">YENİ SERTİFİKA EKLE</asp:HyperLink>
     </form>
</asp:Content>
