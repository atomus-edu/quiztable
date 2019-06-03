using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTableCS
{
    static public class QuizTable
    {
        static public Element[,] elements = new Element[10, 10];
        
        static public void Initialize()
        {
            // row 1
            elements[0, 0] = new Element(1, "H", "Hydrogen");
            elements[0, 7] = new Element(2, "He", "Helium");

            // row 2
            elements[1, 0] = new Element(3, "Li", "Hydrogen");
            elements[1, 1] = new Element(4, "Be", "Helium");
            elements[1, 2] = new Element(5, "B", "Hydrogen");
            elements[1, 3] = new Element(6, "C", "Hydrogen");
            elements[1, 4] = new Element(7, "N", "Helium");
            elements[1, 5] = new Element(8, "O", "Helium");
            elements[1, 6] = new Element(9, "F", "Helium");
            elements[1, 7] = new Element(10, "Ne", "Helium");

            // row 3
            elements[2, 0] = new Element(11, "Na", "Hydrogen");
            elements[2, 1] = new Element(12, "Mg", "Helium");
            elements[2, 2] = new Element(13, "Al", "Hydrogen");
            elements[2, 3] = new Element(14, "Si", "Hydrogen");
            elements[2, 4] = new Element(15, "P", "Helium");
            elements[2, 5] = new Element(16, "S", "Helium");
            elements[2, 6] = new Element(17, "Cl", "Helium");
            elements[2, 7] = new Element(18, "Ar", "Helium");

            // row 4
            elements[3, 0] = new Element(19, "K", "Hydrogen");
            elements[3, 1] = new Element(20, "Ca", "Helium");
            elements[3, 2] = new Element(21, "Sc", "Hydrogen");
            elements[3, 3] = new Element(22, "Ti", "Hydrogen");
            elements[3, 4] = new Element(23, "V", "Helium");
            elements[3, 5] = new Element(24, "Cr", "Helium");
            elements[3, 6] = new Element(25, "Mn", "Helium");
            elements[3, 7] = new Element(26, "Fe", "Helium");
            elements[3, 8] = new Element(27, "Co", "Helium");
            elements[3, 9] = new Element(28, "Ni", "Helium");

            // row 5
            elements[4, 0] = new Element(29, "Cu", "Hydrogen");
            elements[4, 1] = new Element(30, "Zn", "Helium");
            elements[4, 2] = new Element(31, "Ga", "Hydrogen");
            elements[4, 3] = new Element(32, "Ge", "Hydrogen");
            elements[4, 4] = new Element(33, "As", "Helium");
            elements[4, 5] = new Element(34, "Se", "Helium");
            elements[4, 6] = new Element(35, "Br", "Helium");
            elements[4, 7] = new Element(36, "Kr", "Helium");

            // row 6
            elements[5, 0] = new Element(37, "Rb", "Hydrogen");
            elements[5, 1] = new Element(38, "Sr", "Helium");
            elements[5, 2] = new Element(39, "Y", "Hydrogen");
            elements[5, 3] = new Element(40, "Zr", "Hydrogen");
            elements[5, 4] = new Element(41, "Nb", "Helium");
            elements[5, 5] = new Element(42, "Mo", "Helium");
            elements[5, 6] = new Element(43, "Tc", "Helium");
            elements[5, 7] = new Element(44, "Ru", "Helium");
            elements[5, 8] = new Element(45, "Rh", "Helium");
            elements[5, 9] = new Element(46, "Pd", "Helium");

            // row 7
            elements[6, 0] = new Element(47, "Ag", "Hydrogen");
            elements[6, 1] = new Element(48, "Cd", "Helium");
            elements[6, 2] = new Element(49, "In", "Hydrogen");
            elements[6, 3] = new Element(50, "Sn", "Hydrogen");
            elements[6, 4] = new Element(51, "Sb", "Helium");
            elements[6, 5] = new Element(52, "Te", "Helium");
            elements[6, 6] = new Element(53, "I", "Helium");
            elements[6, 7] = new Element(54, "Xe", "Helium");

            // row 8
            elements[7, 0] = new Element(55, "Cs", "Hydrogen");
            elements[7, 1] = new Element(56, "Ba", "Helium");
            elements[7, 2] = new Element(57, "La*", "Hydrogen");
            elements[7, 3] = new Element(72, "Hf", "Hydrogen");
            elements[7, 4] = new Element(73, "Ta", "Helium");
            elements[7, 5] = new Element(74, "W", "Helium");
            elements[7, 6] = new Element(75, "Re", "Helium");
            elements[7, 7] = new Element(76, "Os", "Helium");
            elements[7, 8] = new Element(77, "Ir", "Helium");
            elements[7, 9] = new Element(78, "Pt", "Helium");


            // row 9
            elements[8, 0] = new Element(79, "Au", "Hydrogen");
            elements[8, 1] = new Element(80, "Hg", "Helium");
            elements[8, 2] = new Element(81, "Tl", "Hydrogen");
            elements[8, 3] = new Element(82, "Pb", "Hydrogen");
            elements[8, 4] = new Element(83, "Bi", "Helium");
            elements[8, 5] = new Element(84, "Po", "Helium");
            elements[8, 6] = new Element(85, "At", "Helium");
            elements[8, 7] = new Element(86, "Rn", "Helium");

            // row 10
            elements[9, 0] = new Element(87, "Fr", "Hydrogen");
            elements[9, 1] = new Element(88, "Ra", "Helium");
            elements[9, 2] = new Element(89, "Ac**", "Hydrogen");
            elements[9, 3] = new Element(104, "C", "Hydrogen");
            elements[9, 4] = new Element(105, "N", "Helium");
            elements[9, 5] = new Element(106, "O", "Helium");
            elements[9, 6] = new Element(107, "F", "Helium");
            elements[9, 7] = new Element(108, "Ne", "Helium");
            elements[9, 8] = new Element(109, "He", "Helium");
            elements[9, 9] = new Element(110, "He", "Helium");
        }
    }
}