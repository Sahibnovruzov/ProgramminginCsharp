using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Personel
    {

        private string Azkimlik;

        public string AZKIMLIK
        
        {
            get
            {
                return Azkimlik.Substring(1, 2) + "*******"+Azkimlik.Substring(3, 3);
            }
            set
            {
                bool control = false;
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool isnumber =char.IsNumber(value[i]);
                        if (isnumber)
                        {

                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }
                    if (control)
                    {
                        Console.WriteLine("Kimlik numarasinda gecersiz karakter bulundu");
                    }
                    else
                    {
                        Azkimlik = value;
                    }
                  
                }
                else
                {
                    Console.WriteLine("Basarisiz");

                }
            }
        
        

        
        }

    }
}
/* public int kg2
      { //Property 


          set
          {
              kg = value;
          }
          get
          {
              return kg;
          }

      }
     */