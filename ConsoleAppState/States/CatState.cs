using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppState.States
{
    public abstract class CatState
    {
        protected CatContext Handle { get; set; }
        public CatState(CatContext handle)
        {
            Handle = handle;
        }

        public abstract void GetsFed(int amount, int HappyWith);
        public virtual void BowlEmpty() { }
        public virtual void Comtemplating(){ }

    }
}
