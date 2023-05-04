using System;
using System.Collections.Generic;
using System.Text;

namespace AddGenerator
{
    interface IAddress
    {
        string generateIPv4();
        string generateSubnet();
    }
}
