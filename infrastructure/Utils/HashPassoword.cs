using System.Security.Cryptography;

namespace infrastructure.Utils;

public class HashPassword
{
    public static string Create(string password)
    {
        using Rfc2898DeriveBytes rng = new(password, 16, 10000);
        var salt = rng.Salt;
        var key = rng.GetBytes(32);

        var hash = new byte[48];
        Array.Copy(salt, 0, hash, 0, 16);
        Array.Copy(key, 0, hash, 16, 32);

        return Convert.ToBase64String(hash);
    }

    public static bool Verify(string hashedPassword, string password)
    {
        var hashBytes = Convert.FromBase64String(hashedPassword);
        var salt = new byte[16];
        Array.Copy(hashBytes, 0, salt, 0, 16);

        using Rfc2898DeriveBytes rng = new(password, salt, 10000);
        var key = rng.GetBytes(32);
        for (int i = 0; i < 32; i++)
        {
            if (key[i] != hashBytes[i + 16])
                return false;
        }
        return true;
    }
}
