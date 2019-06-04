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
            elements[0, 0] = new Element(1, "H", "Водень");
            elements[0, 7] = new Element(2, "He", "Гелій");

            // row 2
            elements[1, 0] = new Element(3, "Li", "Літій");
            elements[1, 1] = new Element(4, "Be", "Берилій");
            elements[1, 2] = new Element(5, "B", "Бор");
            elements[1, 3] = new Element(6, "C", "Карбон");
            elements[1, 4] = new Element(7, "N", "Нітроген");
            elements[1, 5] = new Element(8, "O", "Оксиген");
            elements[1, 6] = new Element(9, "F", "Флуор");
            elements[1, 7] = new Element(10, "Ne", "Неон");

            // row 3
            elements[2, 0] = new Element(11, "Na", "Натрій");
            elements[2, 1] = new Element(12, "Mg", "Магній");
            elements[2, 2] = new Element(13, "Al", "Алюміній");
            elements[2, 3] = new Element(14, "Si", "Силіцій");
            elements[2, 4] = new Element(15, "P", "Фосфор");
            elements[2, 5] = new Element(16, "S", "Сульфур");
            elements[2, 6] = new Element(17, "Cl", "Хлор");
            elements[2, 7] = new Element(18, "Ar", "Аргон");

            // row 4
            elements[3, 0] = new Element(19, "K", "Калій");
            elements[3, 1] = new Element(20, "Ca", "Кальцій");
            elements[3, 2] = new Element(21, "Sc", "Скандій");
            elements[3, 3] = new Element(22, "Ti", "Титан");
            elements[3, 4] = new Element(23, "V", "Ванадій");
            elements[3, 5] = new Element(24, "Cr", "Хром");
            elements[3, 6] = new Element(25, "Mn", "Манган");
            elements[3, 7] = new Element(26, "Fe", "Ферум");
            elements[3, 8] = new Element(27, "Co", "Кобальт");
            elements[3, 9] = new Element(28, "Ni", "Нікель");

            // row 5
            elements[4, 0] = new Element(29, "Cu", "Купрум");
            elements[4, 1] = new Element(30, "Zn", "Цинк");
            elements[4, 2] = new Element(31, "Ga", "Галій");
            elements[4, 3] = new Element(32, "Ge", "Германій");
            elements[4, 4] = new Element(33, "As", "Арсен");
            elements[4, 5] = new Element(34, "Se", "Селен	");
            elements[4, 6] = new Element(35, "Br", "Бром");
            elements[4, 7] = new Element(36, "Kr", "Криптон");

            // row 6
            elements[5, 0] = new Element(37, "Rb", "Рубідій");
            elements[5, 1] = new Element(38, "Sr", "Стронцій");
            elements[5, 2] = new Element(39, "Y", "Ітрій");
            elements[5, 3] = new Element(40, "Zr", "Цирконій");
            elements[5, 4] = new Element(41, "Nb", "Ніобій");
            elements[5, 5] = new Element(42, "Mo", "Молібден");
            elements[5, 6] = new Element(43, "Tc", "Технецій");
            elements[5, 7] = new Element(44, "Ru", "Рутеній");
            elements[5, 8] = new Element(45, "Rh", "Родій");
            elements[5, 9] = new Element(46, "Pd", "Паладій");

            // row 7
            elements[6, 0] = new Element(47, "Ag", "Аргентум");
            elements[6, 1] = new Element(48, "Cd", "Кадмій");
            elements[6, 2] = new Element(49, "In", "Індій");
            elements[6, 3] = new Element(50, "Sn", "Станум");
            elements[6, 4] = new Element(51, "Sb", "Стибій");
            elements[6, 5] = new Element(52, "Te", "Телур");
            elements[6, 6] = new Element(53, "I", "Йод");
            elements[6, 7] = new Element(54, "Xe", "Ксенон");

            // row 8
            elements[7, 0] = new Element(55, "Cs", "Цезій");
            elements[7, 1] = new Element(56, "Ba", "Барій");
            elements[7, 2] = new Element(57, "La*", "Лантан");
            elements[7, 3] = new Element(72, "Hf", "Гафній");
            elements[7, 4] = new Element(73, "Ta", "Тантал");
            elements[7, 5] = new Element(74, "W", "Вольфрам");
            elements[7, 6] = new Element(75, "Re", "Реній");
            elements[7, 7] = new Element(76, "Os", "Осмій");
            elements[7, 8] = new Element(77, "Ir", "Іридій");
            elements[7, 9] = new Element(78, "Pt", "Платина");


            // row 9
            elements[8, 0] = new Element(79, "Au", "Аурум");
            elements[8, 1] = new Element(80, "Hg", "Меркурій");
            elements[8, 2] = new Element(81, "Tl", "Талій");
            elements[8, 3] = new Element(82, "Pb", "Плюмбум");
            elements[8, 4] = new Element(83, "Bi", "Бісмут");
            elements[8, 5] = new Element(84, "Po", "Полоній");
            elements[8, 6] = new Element(85, "At", "Астат");
            elements[8, 7] = new Element(86, "Rn", "Радон");

            // row 10
            elements[9, 0] = new Element(87, "Fr", "Францій");
            elements[9, 1] = new Element(88, "Ra", "Радій");
            elements[9, 2] = new Element(89, "Ac**", "Актиній");
            elements[9, 3] = new Element(104, "Rf", "Резерфордій");
            elements[9, 4] = new Element(105, "Db", "Дубній");
            elements[9, 5] = new Element(106, "Sg", "Сіборгій");
            elements[9, 6] = new Element(107, "Bh", "Борій");
            elements[9, 7] = new Element(108, "Hs", "Гасій");
            elements[9, 8] = new Element(109, "Mt", "Майтнерій");
            elements[9, 9] = new Element(110, "Ds", "Дармштадтій");
        }
    }
}