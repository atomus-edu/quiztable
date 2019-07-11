using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTableCS
{
    public class Element
    {
        private int number;

        public int Number
        {
            get { return number; }
        }

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        private string type; // pink, yellow, blue

        public string Type
        {
            get { return type; }
        }

        private string link; // wiki link

        public string Link
        {
            get { return link; }
        }

        public Element()
        {

        }

        public Element(int number, string symbol, string name, string type, string link)
        {
            this.number = number;
            this.symbol = symbol;
            this.name = name;
            this.type = type;
            this.link = link;
        }

        public Element(int number, string symbol, string name, string type)
        {
            this.number = number;
            this.symbol = symbol;
            this.name = name;
            this.type = type;
            this.link = "https://uk.wikipedia.org/wiki/" + this.name;
        }
    }
}
