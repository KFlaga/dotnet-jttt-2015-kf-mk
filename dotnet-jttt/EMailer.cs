﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Drawing;

namespace dotnet_jttt
{
    class EMailer : IAction
    {
        string adress;
        Image img;

        public EMailer()
        {

        }

        public void DoAction(object[] args)
        {
            adress = ((List<string>)args[0])[0];
            img = (Image)args[1];
        }
    }
}
