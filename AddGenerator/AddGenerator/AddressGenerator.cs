using System;
using System.Collections.Generic;
using System.Text;

namespace AddGenerator
{
    class AddressGenerator : IAddress
    {
        string bits;
        string[] otteti;
        string ipv4;
        string subnet;
        public AddressGenerator(string bits)
        {
            this.bits = bits;
        }
        public string generateIPv4()
        {
            otteti = bits.Split('.', '/');
            return $"{Convert.ToInt32(otteti[0], 2).ToString()}.{Convert.ToInt32(otteti[1], 2).ToString()}.{Convert.ToInt32(otteti[2], 2).ToString()}.{Convert.ToInt32(otteti[3], 2).ToString()}";

        }
        public string generateSubnet()
        {
            otteti = bits.Split('.', '/');
            string bit = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                if (i < Convert.ToInt32(otteti[4]))
                    bit += 1;

                else
                    bit += 0;
                if (i == 7)
                    bit += ".";
                if (i == 15)
                    bit += ".";
                if (i == 23)
                    bit += ".";

            }
            otteti = bit.Split('.');
            return $"{Convert.ToInt32(otteti[0], 2).ToString()}.{Convert.ToInt32(otteti[1], 2).ToString()}.{Convert.ToInt32(otteti[2], 2).ToString()}.{Convert.ToInt32(otteti[3], 2).ToString()}";

        }

    }
}
    
