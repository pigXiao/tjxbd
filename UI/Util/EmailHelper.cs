﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Threading;
namespace Util
{
    public class EmailHelper
    {
        private static string formMail = "2839095026@qq.com";
        private static string stmpHost = "smtp.qq.com";
        private static string stmpName = "2839095026@qq.com";
        private static string stmpPass = "hdmjpretgevqddcg";
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="body">内容</param>
        /// <param name="Email">目标邮箱</param>
        public static void SendEmail(string title,string body,string Email)
        {
            Thread th = new Thread(()=> {
                MailMessage msg = new MailMessage();
                msg.Subject = title;
                msg.Body = body;
                msg.From = new MailAddress(formMail);
                msg.To.Add(new MailAddress(Email));
                SmtpClient c = new SmtpClient(stmpHost);
                c.Port =25;
                c.Credentials = new NetworkCredential(stmpName, stmpPass);
                c.Send(msg);
            });
            th.IsBackground = false;
            th.Start();
           
        }


    }
}
