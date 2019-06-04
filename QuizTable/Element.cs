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

        public Element()
        {

        }

        public Element(int number, string symbol, string name, string type)
        {
            this.number = number;
            this.symbol = symbol;
            this.name = name;
            this.type = type;
        }
    }
}
