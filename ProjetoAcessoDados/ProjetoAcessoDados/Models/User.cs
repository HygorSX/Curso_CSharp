﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace ProjetoAcessoDados.Models
{
    [Table("[User]")]
    public class User
    {
        public User()
        => Roles = new List<Role>();
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }


        public List<Role> Roles { get; set; }
    }
}
