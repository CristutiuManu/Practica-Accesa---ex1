using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOOP
{
    public abstract class Persoane
    {

        abstract public int GetMuncitor(int x);

        abstract public int RemoveMuncitor(int x);

        abstract public int GetNumarVizitatori();
         public String BileteVandute()
        {
            if (GetNumarVizitatori() > 100)
                return "Nu mai sunt bilete!";
            else return "Inca mai sunt bilete!";
        }

    }
}
