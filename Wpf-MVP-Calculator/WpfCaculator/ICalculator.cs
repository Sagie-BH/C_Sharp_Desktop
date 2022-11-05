using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCalculator.Presentor;

namespace WpfCalculator
{
    public interface ICalculator
    {
        int Zero { get; }
        int One { get; }
        int Two { get; }
        int Three { get; }
        int Four { get; }
        int Five { get; }
        int Six { get; }
        int Seven { get; }
        int Eight { get; }
        int Nine { get; }

        CalcPresentor Presentor { set; }
        string Plus { get; }
        string Subtract { get; }
        string Multiply { get; }
        string Divided { get; }
        string Result { get; set; }
    }
}
