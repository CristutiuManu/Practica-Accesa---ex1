using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOOP
{
    class Fabrica : Persoane
    {
        int nrMuncitori = 5;
        public override int GetMuncitor(int x)
        {
           return nrMuncitori += x;
        }

        public override int RemoveMuncitor(int x)
        {
            return nrMuncitori -= x;
        }

        public override int GetNumarVizitatori()
        {
            return 30;
        }


        
    }
}
