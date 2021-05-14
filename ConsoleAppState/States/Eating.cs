using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppState.States
{
    public class Eating : CatState
    {
        private int Amount;
        private int HappyWith;

        public Eating(CatContext handle, int amount, int happyWith):base(handle)
        {
            Amount = amount;
            HappyWith = happyWith;
        }

        public override void BowlEmpty()
        {
            throw new NotImplementedException();
        }

        public override void Comtemplating()
        {
            throw new NotImplementedException();
        }

        public override void GetsFed(int amount, int HappyWith)
        {
            throw new NotImplementedException();
        }
    }
}
