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

        public string MyProperty
        {
            get { return name; }
        }

        public Element()
        {

        }

        public Element(int number, string symbol, string name)
        {
            this.number = number;
            this.symbol = symbol;
            this.name = name;
        }
    }
}
