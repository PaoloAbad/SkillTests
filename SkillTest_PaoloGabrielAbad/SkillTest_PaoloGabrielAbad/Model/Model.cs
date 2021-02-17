using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest_PaoloGabrielAbad.ViewModel
{
    public interface ISorterModel
    {
        string Input { get ; set; }
        bool HasError { get; set; }
        string Output { get; set; }
        string Error { get; set; }
    }
}
