using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {
        private string _name;
        private int _edad;
        private int _numero;
        private string _correo;

        public string Nombre
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public Account()
        {

        }

        public Account(string name,int edad,int numero, string correo)
        {
            _name = name;
            _edad = edad;
            _numero = numero;
            _correo = correo;
        }
    }

}
