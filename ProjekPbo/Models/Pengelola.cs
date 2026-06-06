using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Models
{
    public class Pengelola : User
    {
        public override string GetRole()
        {
            return "Pengelola";
        }
    }
}
