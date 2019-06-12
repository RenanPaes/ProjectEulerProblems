using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerProblems.uteis
{
    class Validacao
    {
        public bool ValidaOption(int option)
        {
            while (option < 0 || option > 663)
            {
                return false;
            }
            return true;
        }
    }
}
