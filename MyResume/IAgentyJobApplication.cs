using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    interface IAgentyJobApplication
    {
        int InsertResume(MyResume.Models.MyResume request);
        MyResume.Models.MyResume GetResume(string id);

    }
}
