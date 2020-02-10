using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablaper.Models
{
    public class Elementosp
    {
        public string Elemento { get; set; }
        public string Css { get; set; }
        public string Estado { get; set; }

        public Elementosp(string element, string css, string status)
        {
            Elemento = element;
            Css = css;
            Estado = status;
        }
     
    }
}
