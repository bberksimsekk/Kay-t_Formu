using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KayıtFormuOdev.ASP_Kontrolleri
{
    public partial class KayıtFormu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ltbn_kayıt_Click(object sender, EventArgs e)
        {
            bool KayıtBaşarılı = true;
            if (!string.IsNullOrEmpty(tb_kullanıcı.Text))
            {
                if ((tb_kullanıcı.Text.Length) <= 25)
                {
                    if (!string.IsNullOrEmpty(tb_email.Text))
                    {
                        if (tb_email.Text.Length <= 150)
                        {
                            if (!string.IsNullOrEmpty(tb_sifre.Text))
                            {
                                if (tb_sifre.Text.Length <= 20)
                                {
                                    if (this.tb_email.Text.Contains('@') || this.tb_email.Text.Contains('.'))
                                    {
                                        if (KayıtBaşarılı)
                                        {
                                            KayıtBaşarılı = true;
                                            lbl_mesaj.Visible = true;
                                            lbl_mesaj.Text = "Hoşgeldiniz";
                                        }
                                    }
                                    else
                                    {
                                        KayıtBaşarılı = false;
                                        lbl_mesaj.Visible = true;
                                        lbl_mesaj.Text = "Lütfen geçerli bir e-mail giriniz.";
                                    }
                                }
                                else
                                {
                                    KayıtBaşarılı = false;
                                    lbl_mesaj.Visible = true;
                                    lbl_mesaj.Text = "Şifre en fazla 20 karakterden oluşabilir.";
                                }

                            }
                            else
                            {
                                KayıtBaşarılı = false;
                                lbl_mesaj.Visible = true;
                                lbl_mesaj.Text = "Şifre boş bırakılamaz.";
                            }
                        }
                        else
                        {
                            KayıtBaşarılı = false;
                            lbl_mesaj.Visible = true;
                            lbl_mesaj.Text = "Lütfen geçerli bir email giriniz.";
                        }
                    }
                    else
                    {
                        KayıtBaşarılı = false;
                        lbl_mesaj.Visible = true;
                        lbl_mesaj.Text = "Email boş bırakılamaz.";
                    }
                }
                else
                {
                    KayıtBaşarılı = false;
                    lbl_mesaj.Visible = true;
                    lbl_mesaj.Text = "Kullanıcı adı en fazla 25 karakterden oluşabilir.";
                }
            }
            else
            {
                KayıtBaşarılı = false;
                lbl_mesaj.Visible = true;
                lbl_mesaj.Text = "Kullanıcı adı boş bırakılamaz.";
            }
        }
    }
}