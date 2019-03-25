using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using Versa2._0.Models;

namespace Versa2._0.Funcoes
{
    public class EnviarEmails
    {
        public static void Enviar(TipoEmail _TipoEmail, EnviarEmail _objModelMail)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(new MailAddress("contato@versaconsorcios.com.br"));
            mail.From = new MailAddress(_objModelMail.Email);
            var corpoEmail = new StringBuilder();
            var estilo1 = " style=" + '"' + "font-family:Tahoma, Geneva, sans-serif !important;" + ";font-size:36px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:inherit;background-color:#34696d;color:#ffffff;text-align:center;vertical-align:top" + '"' + "colspan=" + '"' + "2" + '"';
            var estilo2 = " style=" + '"' + "font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:inherit;text-align:right;vertical-align:top" + '"';
            var estilo3 = " style=" + '"' + "font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:inherit;text-align:left;vertical-align:top" + '"';
            //Montar o corpo do Email
            if (_TipoEmail == TipoEmail.VendaSuaCota)
            {
                corpoEmail = new StringBuilder();
                corpoEmail.AppendLine("<html>");
                corpoEmail.AppendLine("<body style=" + '"' + "margin: 0; padding: 0; " + '"' + ">");
                corpoEmail.AppendLine("<table style=" + '"' + "border-collapse:collapse; border-spacing:0" + '"' + " class=" + '"' + "tg" + '"' + ">");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<th" + estilo1 + ">" + "Versa Consórcios - Venda Sua Cota" + "</th>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Nome:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Nome + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "E-Mail:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Email + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Telefone:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Telefone + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Celular:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Celular + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Administradora:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Administradora + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Tipo Consórcio:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.TipoConsorcio + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Grupo:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Grupo + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Cota:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Cota + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Contemplado:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Contemplado + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Total de Parcelas:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.TotalParcelas + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Parcelas Pagas:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.ParcelasPagas + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Parcelas em Atraso:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.ParcelasEmAtraso + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Valor do Bem: R$" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.ValorDoBem + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Valor da Parcela: R$" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.ValorDaParcela + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Valor do Saldo Devedor: R$" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.SaldoDevedor + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Informações Adicionais:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Adicionais + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("</table>");
                corpoEmail.AppendLine("</body>");
                mail.Subject = "Enviado Pelo Site Versa Consórcios - Venda Sua Cota";
            }
            else if (_TipoEmail == TipoEmail.CotasAVenda)
            {
                corpoEmail = new StringBuilder();
                corpoEmail.AppendLine("<html>");
                corpoEmail.AppendLine("<body style=" + '"' + "margin: 0; padding: 0; " + '"' + ">");
                corpoEmail.AppendLine("<table style=" + '"' + "border-collapse:collapse; border-spacing:0" + '"' + " class=" + '"' + "tg" + '"' + ">");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<th" + estilo1 + ">" + "Versa Consórcios - Cotas a Venda" + "</th>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Nome:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Nome + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "E-Mail:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Email + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Telefone:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Telefone + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Celular:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Celular + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo1 + ">" + "Dados da Cotas a Comprar" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" +  "</td>");
                corpoEmail.AppendLine("</tr>");

                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Administradora:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Administradora + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Tipo Consórcio:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.TipoConsorcio + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Grupo:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Grupo + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Cota:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Cota + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Crédito:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Credito + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("</table>");
                corpoEmail.AppendLine("</body>");
                mail.Subject = "Enviado Pelo Site Versa Consórcios - Cota à Venda";
            }
            else if (_TipoEmail == TipoEmail.Contato)
            {
                corpoEmail = new StringBuilder();
                corpoEmail.AppendLine("<html>");
                corpoEmail.AppendLine("<body style=" + '"' + "margin: 0; padding: 0; " + '"' + ">");
                corpoEmail.AppendLine("<table style=" + '"' + "border-collapse:collapse; border-spacing:0" + '"' + " class=" + '"' + "tg" + '"' + ">");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<th" + estilo1 + ">" + "Versa Consórcios - Contato" + "</th>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Nome:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Nome + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "E-Mail:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Email + "</td>");
                corpoEmail.AppendLine("</tr>");
                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Telefone:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Telefone + "</td>");
                corpoEmail.AppendLine("</tr>");

                corpoEmail.AppendLine("<tr>");
                corpoEmail.AppendLine("<td" + estilo2 + ">" + "Informações Adicionais:" + "</td>");
                corpoEmail.AppendLine("<td" + estilo3 + ">" + _objModelMail.Adicionais + "</td>");
                corpoEmail.AppendLine("</tr>");


                corpoEmail.AppendLine("</table>");
                corpoEmail.AppendLine("</body>");
                mail.Subject = "Enviado Pelo Site Versa Consórcios - Contato";
            }


            mail.Body = corpoEmail.ToString();
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["host"].ToString(),
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["usuario"].ToString(), ConfigurationManager.AppSettings["senha"].ToString()),// Login e senha do e-mail.
                EnableSsl = false
            };

            if (_objModelMail.Attachment != null)
            {
                if (_objModelMail.Attachment.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(_objModelMail.Attachment.FileName);
                    mail.Attachments.Add(new Attachment(_objModelMail.Attachment.InputStream, fileName));
                }
            }

            //enviar para o cliente a confirmação do email
            smtp.Send(mail);
            mail = new MailMessage();
            mail.To.Add(new MailAddress(_objModelMail.Email));
            mail.From = new MailAddress("contato@versaconsorcios.com.br");
            mail.Subject = "Enviado Pelo Site Versa Consórcios";
            mail.IsBodyHtml = true;

            StringBuilder strBody = new StringBuilder();
            strBody.AppendLine("<html>");
            strBody.AppendLine("<body style=" + '"' + "margin: 0; padding: 0; " + '"' + ">");
            strBody.AppendLine("<table border=" + '"' + "1" + '"' + " cellpadding=" + '"' + "0" + '"' + " cellspacing=" + '"' + "0" + '"' + " width=" + '"' + "600 " + '"' + "style=" + '"' + "border-collapse: collapse;" + '"' + ">");
            strBody.AppendLine("<tr>");
            strBody.AppendLine("<td align=" + '"' + "center" + '"' + "bgcolor=" + '"' + "#2f5362" + '"' + "style=" + '"' + "padding: 20px 0 30px 0;" + '"' + ">");
            strBody.AppendLine("<p style=" + '"' + "font-size: 40" + '"' + "> Versa Consórcios</p>");
            strBody.AppendLine("</td>");
            strBody.AppendLine("</tr>");
            strBody.AppendLine("<tr>");
            strBody.AppendLine("<td align=" + '"' + "center" + '"' + "bgcolor=" + '"' + "#ffffff" + '"' + "style=" + '"' + "padding: 40px 0 30px 0;" + '"' + ">");
            strBody.AppendLine("<p style=" + '"' + "font-size: 16" + '"' + "> <b>Seu pedido foi recebido por nossa equipe. Em breve entraremos em contato.</b><br/> <br/> </p>");
            strBody.AppendLine("<p style=" + '"' + "font-size: 16" + '"' + "> <b>Equipe Versa Consórcios</b><br/> <br/> </p><br/> <br/>");
            strBody.AppendLine("<p style=" + '"' + "font-size: 16" + '"' + "> <b>Telefone: (11) 3501-8247  (11) 9.8919-0560 WhatsApp</b><br/> <br/> </p><br/> <br/>");
            strBody.AppendLine("</td>");
            strBody.AppendLine("</tr>");
            strBody.AppendLine("</table>");
            strBody.AppendLine("</body>");
            mail.Body = strBody.ToString();
            smtp.Send(mail);
        }
    }
}