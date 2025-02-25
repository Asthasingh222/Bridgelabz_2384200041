
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    // AES encryption requires a key of 16, 24, or 32 bytes (for AES-128, AES-192, AES-256)
    // Ensure the key is **exactly** 32 characters long for AES-256
    static readonly string key = "12345678901234567890123456789012";

    static void Main()
    {
        string csvFile = "employees_encrypted.csv"; // CSV file to store encrypted data

        // Sample Employee Data with encrypted fields (Email & Salary)
        string[] employees = {
            "ID,Name,Email,Salary", // CSV Header
            $"1,Alice,{Encrypt("alice@example.com")},{Encrypt("50000")}",
            $"2,Bob,{Encrypt("bob@example.com")},{Encrypt("60000")}"
        };

        // Write the encrypted employee data to the CSV file
        File.WriteAllLines(csvFile, employees);
        Console.WriteLine($"Encrypted CSV saved: {csvFile}");

        // Read from the encrypted CSV and decrypt the data
        Console.WriteLine("\nDecrypted Data:");
        var lines = File.ReadAllLines(csvFile);
        foreach (var line in lines)
        {
            var columns = line.Split(',');

            if (columns[0] != "ID") // Skip header row
            {
                Console.WriteLine($"ID: {columns[0]}, Name: {columns[1]}, Email: {Decrypt(columns[2])}, Salary: {Decrypt(columns[3])}");
            }
        }
    }

    /// Encrypts a given text using AES-256 encryption
    static string Encrypt(string text)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key); // Convert key to byte array
            aes.IV = new byte[16]; // AES requires a 16-byte IV (default: all zeros)

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var writer = new StreamWriter(cs))
                {
                    writer.Write(text); // Write plaintext into CryptoStream
                }
                return Convert.ToBase64String(ms.ToArray()); // Convert encrypted bytes to Base64 string
            }
        }
    }

    /// Decrypts an AES-256 encrypted string
    static string Decrypt(string encryptedText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key); // Convert key to byte array
            aes.IV = new byte[16]; // Same 16-byte IV used in encryption

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (var reader = new StreamReader(cs))
            {
                return reader.ReadToEnd(); // Read decrypted text
            }
        }
    }
}

