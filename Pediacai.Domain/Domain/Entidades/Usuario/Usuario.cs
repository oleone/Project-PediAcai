using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime DateRecorder { get; set; }
        public DateTime LastAcess { get; set; }
    }
}
