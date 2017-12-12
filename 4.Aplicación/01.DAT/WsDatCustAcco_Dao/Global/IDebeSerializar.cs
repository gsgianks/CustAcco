using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WsDatCustAcco_Dao.Global
{
    public interface IDebeSerializar
    {
        XElement Xml();
    }
}
