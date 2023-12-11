using BinaryMVC.Contracts;

namespace BinaryMVC.Services
{
    public class BinaryService : iBinaryService
    {
        public async Task<int> BinaryToDecimal(int[] binary)
        {
            int[] binaryReversed =binary.Reverse().ToArray();
            int i = 0;
            int decimalValue = 0;
            while(i < binary.Length)
            {
                decimalValue += (binaryReversed[i]* (int)Math.Pow(2,i));
                i++;
            }
            return decimalValue;

        }
    }
}
