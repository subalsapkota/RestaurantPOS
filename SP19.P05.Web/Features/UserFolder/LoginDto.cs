﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P05.Web.Features.UserFolder
{
    public class LoginDto
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
