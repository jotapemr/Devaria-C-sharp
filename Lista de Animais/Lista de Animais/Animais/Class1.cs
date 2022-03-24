using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Animais.Classes_de_animais
{

    class Animal
    {
        public string Nome { get; set; }
        public object Quatidadedemamas { get; internal set; }
    }
    internal class Mamífero : Animal
    {
        public int Quatidadedemamas { get; set; }
    }

    class Réptil : Animal
    {
        public bool Controlartemperatura { get; set; } = false;
    }

    class Ave : Animal
    {
        public bool Tempena { get; set; } = true;
    }

    class Peixe : Animal
    {
        public int quatidadenadadeira { get; set; }
    }

}
