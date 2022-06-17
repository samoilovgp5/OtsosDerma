using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count,  float width, float length)
        {
            if ((productType == 1 || productType == 2 || productType == 3) && (materialType == 1 || materialType == 2) && (count > 0 || width > 0 || length > 0))
            {
                double productTypeCoeff;
                if (productType == 1)
                {
                    productTypeCoeff = 1.1;
                }
                else if (productType == 2)
                {
                    productTypeCoeff = 2.5;
                }
                else
                {
                    productTypeCoeff = 8.43;
                }

                int kolvoNaOdnuEdinitsu = Convert.ToInt32(width * length * productTypeCoeff);
                return kolvoNaOdnuEdinitsu * count ;
            }
            else
            {
                return -1;
            }
        }
    }
}
