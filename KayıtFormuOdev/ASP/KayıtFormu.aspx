<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayıtFormu.aspx.cs" Inherits="KayıtFormuOdev.ASP_Kontrolleri.KayıtFormu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/KayıtFormuStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="KayıtPanel">
            <div class="satir" style="text-align:center">
                <img src="Images/ryan-reynolds-hugh-jackman.gif" width="300" />
            </div>
        <div class="Satır">
            Kullanıcı Adı: <br />
            <asp:TextBox ID="tb_kullanıcı" runat="server" CssClass="MetinKutu" PlaceHolder="Kullanıcı Adı Giriniz!"></asp:TextBox>
        </div>
        <div class="Satır">
            Email: <br />
            <asp:TextBox ID="tb_email" runat="server" CssClass="MetinKutu" PlaceHolder="Email Giriniz!"></asp:TextBox>
        </div>
        <div class="Satır">
            Şifre: <br />
            <asp:TextBox ID="tb_sifre" runat="server" CssClass="MetinKutu" PlaceHolder="Şifreyi giriniz!"></asp:TextBox>
        </div>
        <div class="Satır" style="margin-top: 25px">
            <asp:LinkButton ID="ltbn_kayıt" runat="server" Text="Kayıt Ol" CssClass="KayıtButon" OnClick="ltbn_kayıt_Click"></asp:LinkButton>
        </div>
        <div>
            <asp:Label ID="lbl_mesaj" runat="server" CssClass="HataMesajı" Visible="false"></asp:Label>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
