﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricardo01.Dominio
{
    class Login
    {
        private String usuario;
        private String password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
