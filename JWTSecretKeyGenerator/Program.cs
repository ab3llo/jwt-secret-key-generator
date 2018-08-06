using System;
using System.Security.Cryptography;

namespace JWTSecretKeyGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press enter to generate secret key");

			ConsoleKeyInfo keyPressed = Console.ReadKey();

			if (keyPressed.Key == ConsoleKey.Enter)
			{
				HMACSHA256 hmac = new HMACSHA256();
				string key = Convert.ToBase64String(hmac.Key);

				Console.WriteLine($"Please add this secret key to the app config: {key}");
			}
		}
	}
}
