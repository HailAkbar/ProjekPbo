using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Models
{
    public class Pengelola : User, IUser
    {
        public override string GetRole()
        {
            return "Pengelola";
        }
    }
}
