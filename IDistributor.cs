public interface IDistributor
{
    void Distribute(IPrinter printer);
    IDistributor Below();
    IDistributor Above();
}