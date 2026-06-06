using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Models
{
    public abstract class User
    {
        private int Id { get; set; }
        public int id
        {
            get {  return Id; }
            set { Id = value; }
        }
        private string Nama { get; set; }
        public string nama
            {
                get { return Nama; }
                set { Nama = value; }
        }
        private string Email { get; set; }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        private string Sandi { get; set; }
        public string sandi
        {
            get { return Sandi; }
            set { Sandi = value; }
        }
        private string NomorHp { get; set; }
        public string nomorHp
        {
            get { return NomorHp; }
            set { NomorHp = value; }
        }

        public abstract string GetRole(); 
    }
}
