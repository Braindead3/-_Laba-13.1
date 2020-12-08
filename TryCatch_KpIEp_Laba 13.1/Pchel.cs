using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_KpIEp_Laba_13._1
{
    public class Pchel
    {
        private int age;
        private string name;
        private enumPol pol;

        public Pchel(int age, string name, string pol)
        {
            Age = age;
            Name = name;
            Pol = pol;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<0)
                {
                    throw new PchelException("Отрицательный возраст невозможен.");
                }
                else
                {
                    age = value;
                }
            }
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool estNum = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i])==false)
                    {
                        estNum = true;
                        break;
                    }
                }
                if (estNum==true)
                {
                    throw new PchelException("В имени есть цифра");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Pol
        {
            get
            {
                return pol.ToString();
            }
            set
            {
                if (value==enumPol.мужской.ToString() || value==enumPol.женский.ToString())
                {
                    if (value == enumPol.мужской.ToString())
                    {
                        pol = enumPol.мужской;
                    }
                    else
                    {
                        pol = enumPol.женский;
                    }
                }
                else
                {
                    throw new PchelException("Выбирите male или female.");
                }

            }
        }

        public override string ToString()
        {
            return $"Имя:{name}\n" +
                $"Возраст:{age}\n" +
                $"Пол:{pol.ToString()}";
        }
    }
}
