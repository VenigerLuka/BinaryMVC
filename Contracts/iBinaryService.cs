namespace BinaryMVC.Contracts
{
    public interface iBinaryService
    {
        Task<int> BinaryToDecimal(int[] binary);
    }
}
