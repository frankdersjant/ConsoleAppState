using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppState.States
{
    public class Contemplating : CatState
    {
        public Contemplating(CatContext Handle) : base(Handle)
        {

        }
        public override void GetsFed(int amount, int HappyWith)
        {
            throw new NotImplementedException();
        }
    }
}
