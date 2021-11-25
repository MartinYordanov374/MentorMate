namespace FirstSteps
{
    public interface IFighter
    {
        bool IsAlive { get; }

        int ProduceHit();
        void ReceiveHit(int forseApplied);
    }
}