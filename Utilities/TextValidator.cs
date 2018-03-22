using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    public class TextValidator
    {
        public object MessageBox { get; private set; }

        static public bool ValidarFloat(string texto)
        {
            return new Regex(@"^[0-9]*(?:\,[0-9]*)?$").IsMatch(texto);
        }

        static public bool ValidarString(string nomape)
        {
            return new Regex(@"^[A-Za-z ]+${2,50}").IsMatch(nomape);
        }

        static public bool ValidarStringEntero(string domicilio)
        {
            return new Regex(@"^.*(?=.*[0-9])(?=.*[a-zA-ZÒ—\s]).*$").IsMatch(domicilio);
        }

        static public bool ValidarTelefono(string tel)
        {
            return new Regex(@"^\s*?[0-9]{7,13}\s*$").IsMatch(tel);
        }

        static public bool ValidarEntero(string tel)
        {
            return new Regex(@"^\s*?[0-9]{2,8}\s*$").IsMatch(tel);
        }

        static public bool ValidarMail(string mail)
        {
            return new Regex(@"^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$").IsMatch(mail);
        }
    }
}
