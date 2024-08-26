using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoForca.Models
{
    public class Word
    {
        public Word(String tips, string text)
        {
            this.Tips = tips;
            this.Text = text;
        }
        public string Tips { get; set; }
        public string Text { get; set; }
    }
}
