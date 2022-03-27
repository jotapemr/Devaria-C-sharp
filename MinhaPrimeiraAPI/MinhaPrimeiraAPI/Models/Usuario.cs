using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MinhaPrimeiraAPI.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set;}
        [JsonIgnore]   //framework
        public string Senha { get; set; }

    }
}
