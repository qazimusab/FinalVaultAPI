﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Vault.Models
{
    public class Comptadora
    {
        public Comptadora()
        {
            
        }
        public Comptadora(Computer aspNetComputer)
        {
            ComputerName = aspNetComputer.ComputerName;
            DepartmentName = aspNetComputer.DepartmentName;
            if(aspNetComputer.ComputerId != 0)
                ComputerId = aspNetComputer.ComputerId;
            Credentials = aspNetComputer.Credentials.Select(aspNetCredential => new Credencial(aspNetCredential)).ToList();
        }

     

        public string ComputerName { get; set; }
        public string DepartmentName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComputerId { get; set; }
        public List<Credencial> Credentials { set; get; }
    }
}