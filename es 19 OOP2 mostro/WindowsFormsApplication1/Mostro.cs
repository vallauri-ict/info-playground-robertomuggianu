using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     public class Mostro
    {
        public string nome;
        public Mostro() : this("Mostro")   ///utillizzato per  richimare un alro costruttore  che e' string (in questo caso)
        {
        }
        public Mostro(string nome)
        {
            this.nome = nome;
        }
        public void Rivela()
        {
            MessageBox.Show(nome); ;
        }
    }
}
