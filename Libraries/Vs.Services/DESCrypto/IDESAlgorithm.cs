namespace Vs.Services.Descrypto
{
    public interface IDESAlgorithm
    {
        string Decrypt(string ciphertext, string key);
        string Encrypt(string plaintext, string key);
    }
}