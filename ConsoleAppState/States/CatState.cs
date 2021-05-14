namespace ConsoleAppState.States
{
    public abstract class CatState
    {
        protected CatContext Handle { get; set; }
        public CatState(CatContext handle)
        {
            Handle = handle;
        }

        //abstract - must implement in derived class
        public abstract void GetsFed(int amount, int HappyWith);
        
        //virtual - dummy implementation
        public virtual void BowlEmpty() { }
        public virtual void WorldBeware() { }

    }
}
