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

        /// <summary>
        /// inicializa o construtor classe padrão <c>nomePokemon</c>
        /// </summary>
        /// <list type="bullet">
        /// <item>Nome,Tipo,Vida,Dano</item>
        /// </list>
        /// <Pokemon>
        /// <value>valor aqui</value>
        /// <param name="nomePokemon"></param>
        /// <param name="tipoPokemon"></param>
        /// <param name="nivelPokemon"></param>

        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            Random r = new Random();
            r.Next();
           
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
