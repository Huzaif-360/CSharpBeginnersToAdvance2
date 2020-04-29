using System;
//using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace CSharpIntermediateToAdvance
{
    partial class Program
    {
        /*Lecture 37
         * Interfaces and Polymorphism

           As software developer: reduce the impact of change.
            OCP: Open Close Principal.
                OCP: Open for expension but close for modification

            */
        var encoder = new VideoEncoder();
        encoder.RegistrationNotificationChannel(new MailNotificationChannel());
            //encoder.RegistrationNotificationChannel(new SmsNotificationChannel());
            Encoder.Encode(new VideoEncoder());

            }

    //Class 1

    public interface INotificationChannel
    {
        void Send(Message message);
    }

    //Class 2
    public class Mail
    {

    }

    //Class 3
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("SENDING THE EMAIL....");
        }
    }

    //Class 4
    public class Message
    {
        //Implementation
    }
}



