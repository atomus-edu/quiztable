using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTableCS
{
    static public class QuizTable
    {
        static public Color Violet = Color.FromArgb(90, 45, 174);
        static public Color LightViolet = Color.FromArgb(242, 247, 253);

        static public Element[,] elements = new Element[10, 10];
        static public List<Element> elems = new List<Element>();
        
        static public void Initialize()
        {
            // row 1
            elements[0, 0] = new Element(1, "H", "Водень", "pink", "");
            elements[0, 7] = new Element(2, "He", "Гелій", "pink", "");

            // row 2
            elements[1, 0] = new Element(3, "Li", "Літій", "pink", "");
            elements[1, 1] = new Element(4, "Be", "Берилій", "pink", "");
            elements[1, 2] = new Element(5, "B", "Бор", "yellow", "");
            elements[1, 3] = new Element(6, "C", "Карбон", "yellow", "");
            elements[1, 4] = new Element(7, "N", "Нітроген", "yellow", "");
            elements[1, 5] = new Element(8, "O", "Оксиген", "yellow", "");
            elements[1, 6] = new Element(9, "F", "Флуор", "yellow", "");
            elements[1, 7] = new Element(10, "Ne", "Неон", "yellow", "");

            // row 3
            elements[2, 0] = new Element(11, "Na", "Натрій", "pink", "");
            elements[2, 1] = new Element(12, "Mg", "Магній", "pink", "");
            elements[2, 2] = new Element(13, "Al", "Алюміній", "yellow", "");
            elements[2, 3] = new Element(14, "Si", "Силіцій", "yellow", "");
            elements[2, 4] = new Element(15, "P", "Фосфор", "yellow", "");
            elements[2, 5] = new Element(16, "S", "Сульфур", "yellow", "");
            elements[2, 6] = new Element(17, "Cl", "Хлор", "yellow", "");
            elements[2, 7] = new Element(18, "Ar", "Аргон", "yellow", "");

            // row 4
            elements[3, 0] = new Element(19, "K", "Калій", "pink", "");
            elements[3, 1] = new Element(20, "Ca", "Кальцій", "pink", "");
            elements[3, 2] = new Element(21, "Sc", "Скандій", "blue", "");
            elements[3, 3] = new Element(22, "Ti", "Титан", "blue", "");
            elements[3, 4] = new Element(23, "V", "Ванадій", "blue", "");
            elements[3, 5] = new Element(24, "Cr", "Хром", "blue", "");
            elements[3, 6] = new Element(25, "Mn", "Манган", "blue", "");
            elements[3, 7] = new Element(26, "Fe", "Ферум", "blue", "");
            elements[3, 8] = new Element(27, "Co", "Кобальт", "blue", "");
            elements[3, 9] = new Element(28, "Ni", "Нікель", "blue", "");

            // row 5
            elements[4, 0] = new Element(29, "Cu", "Купрум", "blue", "");
            elements[4, 1] = new Element(30, "Zn", "Цинк", "blue", "");
            elements[4, 2] = new Element(31, "Ga", "Галій", "yellow", "");
            elements[4, 3] = new Element(32, "Ge", "Германій", "yellow", "");
            elements[4, 4] = new Element(33, "As", "Арсен", "yellow", "");
            elements[4, 5] = new Element(34, "Se", "Селен", "yellow", "");
            elements[4, 6] = new Element(35, "Br", "Бром", "yellow", "");
            elements[4, 7] = new Element(36, "Kr", "Криптон", "yellow", "");

            // row 6
            elements[5, 0] = new Element(37, "Rb", "Рубідій", "pink", "");
            elements[5, 1] = new Element(38, "Sr", "Стронцій", "pink", "");
            elements[5, 2] = new Element(39, "Y", "Ітрій", "blue", "");
            elements[5, 3] = new Element(40, "Zr", "Цирконій", "blue", "");
            elements[5, 4] = new Element(41, "Nb", "Ніобій", "blue", "");
            elements[5, 5] = new Element(42, "Mo", "Молібден", "blue", "");
            elements[5, 6] = new Element(43, "Tc", "Технецій", "blue", "");
            elements[5, 7] = new Element(44, "Ru", "Рутеній", "blue", "");
            elements[5, 8] = new Element(45, "Rh", "Родій", "blue", "");
            elements[5, 9] = new Element(46, "Pd", "Паладій", "blue", "");

            // row 7
            elements[6, 0] = new Element(47, "Ag", "Аргентум", "blue", "");
            elements[6, 1] = new Element(48, "Cd", "Кадмій", "blue", "");
            elements[6, 2] = new Element(49, "In", "Індій", "yellow", "");
            elements[6, 3] = new Element(50, "Sn", "Станум", "yellow", "");
            elements[6, 4] = new Element(51, "Sb", "Стибій", "yellow", "");
            elements[6, 5] = new Element(52, "Te", "Телур", "yellow", "");
            elements[6, 6] = new Element(53, "I", "Йод", "yellow", "");
            elements[6, 7] = new Element(54, "Xe", "Ксенон", "yellow", "");

            // row 8
            elements[7, 0] = new Element(55, "Cs", "Цезій", "pink", "");
            elements[7, 1] = new Element(56, "Ba", "Барій", "pink", "");
            elements[7, 2] = new Element(57, "La*", "Лантан", "blue", "");
            elements[7, 3] = new Element(72, "Hf", "Гафній", "blue", "");
            elements[7, 4] = new Element(73, "Ta", "Тантал", "blue", "");
            elements[7, 5] = new Element(74, "W", "Вольфрам", "blue", "");
            elements[7, 6] = new Element(75, "Re", "Реній", "blue", "");
            elements[7, 7] = new Element(76, "Os", "Осмій", "blue", "");
            elements[7, 8] = new Element(77, "Ir", "Іридій", "blue", "");
            elements[7, 9] = new Element(78, "Pt", "Платина", "blue", "");


            // row 9
            elements[8, 0] = new Element(79, "Au", "Аурум", "blue", "");
            elements[8, 1] = new Element(80, "Hg", "Меркурій", "blue", "");
            elements[8, 2] = new Element(81, "Tl", "Талій", "yellow", "");
            elements[8, 3] = new Element(82, "Pb", "Плюмбум", "yellow", "");
            elements[8, 4] = new Element(83, "Bi", "Бісмут", "yellow", "");
            elements[8, 5] = new Element(84, "Po", "Полоній", "yellow", "");
            elements[8, 6] = new Element(85, "At", "Астат", "yellow", "");
            elements[8, 7] = new Element(86, "Rn", "Радон", "yellow", "");

            // row 10
            elements[9, 0] = new Element(87, "Fr", "Францій", "pink", "");
            elements[9, 1] = new Element(88, "Ra", "Радій", "pink", "");
            elements[9, 2] = new Element(89, "Ac**", "Актиній", "blue", "");
            elements[9, 3] = new Element(104, "Rf", "Резерфордій", "blue", "");
            elements[9, 4] = new Element(105, "Db", "Дубній", "blue", "");
            elements[9, 5] = new Element(106, "Sg", "Сіборгій", "blue", "");
            elements[9, 6] = new Element(107, "Bh", "Борій", "blue", "");
            elements[9, 7] = new Element(108, "Hs", "Гасій", "blue", "");
            elements[9, 8] = new Element(109, "Mt", "Майтнерій", "blue", "");
            elements[9, 9] = new Element(110, "Ds", "Дармштадтій", "blue", "");

            for (int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 10; j++)
                {
                    if(elements[i, j] != null)
                        elems.Add(elements[i, j]);
                }
            }
        }
    }
}