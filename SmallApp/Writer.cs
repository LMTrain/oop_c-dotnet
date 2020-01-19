public abstract class Writer : IVlogger
{
    public abstract void Vlog();

    public void vLOG()
    {
        throw new System.NotImplementedException();
    }

    public abstract void Write();
}
