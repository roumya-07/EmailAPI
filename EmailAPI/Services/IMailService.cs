﻿using EmailAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailAPI.Services
{
   public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
