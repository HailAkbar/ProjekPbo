using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Models
{
    public class Donatur : User, IUser
    {
        public string Alamat { get; set; }
        public override string GetRole()
        {
            return "Donatur";
        }
    }
}
