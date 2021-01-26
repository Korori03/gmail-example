using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


class Gmail
{
    public static string strEmail = string.Empty;
	
	public static string strFromEmail = "abc@gmail.com";
	public static string strFromEmailPass = "abc123";
	
    public string Email 
    {
        get { return strEmail; }
        set { strEmail = value; }
    }

        
    public static string strMessage = string.Empty;
    public string Message
    {
        get { return strMessage; }
        set { strMessage = value; }
    }

    public static string strSubject = string.Empty;
    public string Subject 
    {
        get { return strSubject; }
        set { strSubject = value; }
    }
       
    public static string strFrom = string.Empty;
    public string From 
    {
        get { return strFrom; }
        set { strFrom = value; }
    }
   
   public static string strFromPass = string.Empty;
    public string FromPass 
	
    {
        get { return strFromPass; }
        set { strFromPass = value; }
    }

       
    public static string Emailer()
    
{

       

        try
        {
            MailMessage message = new MailMessage();
            message.Body = strMessage;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Subject = strSubject;
            message.To.Add(strEmail);
            message.From = new MailAddress(strFrom);

            message.From = new MailAddress(strFromEmail);
            SmtpClient client = new SmtpClient("smtp-relay.gmail.com", 587)
            {
                Credentials = new NetworkCredential(strFromEmail, strFromEmailPass),
                EnableSsl = true
            };



            client.Send(message);
            return "true";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }
}
