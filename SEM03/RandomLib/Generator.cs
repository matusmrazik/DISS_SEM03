namespace RandomLib
{
    public abstract class Generator<TResult>
    {
        public abstract void Seed(int seed);

        public abstract TResult Next();
    }
}
