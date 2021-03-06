﻿
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouLearn.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.Endereco);
        }

        public string Endereco { get; private set; }
    }
}
