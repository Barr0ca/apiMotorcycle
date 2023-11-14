using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiMotorcycle.Model
{
    public class Empresas
    {
        public int ID { get; set; }

        public String? nomeEmpresa { get; set; }

        public String? enderecoEmpresa { get; set; }

        public String? whatsappEmpresa { get; set; }

        public String? telefoneEmpresa { get; set; }

        public String? imagensEmpresa { get; set; }
    }
}