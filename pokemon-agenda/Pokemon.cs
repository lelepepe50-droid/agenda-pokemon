using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{

    internal class Pokemon
    {
        string Nome;
        string Tipo;
        int Nivel;
        int Vida;
        int Dano;

        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Elétrico";
            //Nivel = 5;
            Vida = 100;
            Dano = 20;
        }
        // public posso usar da função em qualquer do meu projeto
        // private posso usar a função somente no seu arquivo original
        public void fnDescricao()
        {
            MessageBox.Show($"o Pokemon:{Nome}, tipo: {Tipo}," +
                $"nivel: {Nivel}, vida: {Vida}, Dano: {Dano}");
        }
    }
}
