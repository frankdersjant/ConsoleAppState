namespace ConsoleAppState.States
{
    public abstract class AbstractCatState
    {
        protected CatContext Handle { get; set; }
        public AbstractCatState(CatContext handle)
        {
            Handle = handle;
        }

        //virtual - dummy implementation - CAN override 
        //abstract - MUST override!!!
        public virtual void GetsFed(int amount, int HappyWith) { }
        public virtual void BowlEmpty() { }
        public virtual void WorldBeware() { }

    }
}
