using AppJogoForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoForca.Repositories
{
    public class WordRepositorie
    {
        private List<Word> _words;

        public WordRepositorie()
        {
            _words = new List<Word>();
            _words.Add(new Word("Nome", "Joao".ToUpper()));
            _words.Add(new Word("Fruta", "Maça".ToUpper()));
            _words.Add(new Word("Objeto", "Cadeira".ToUpper()));
            _words.Add(new Word("Comida", "Baiana".ToUpper()));
            _words.Add(new Word("Carro", "Mercedes".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("País", "Alemanha".ToUpper()));

        }

        public Word GetRandomWord()
        {
            Random r = new Random();
            var number = r.Next(0,_words.Count);
            return _words[number];
        }
    }
}
