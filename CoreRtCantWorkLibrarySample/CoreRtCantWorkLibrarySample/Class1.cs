using System;
using System.Threading.Tasks;

namespace CoreRtCantWorkLibrarySample
{
	public class Class1
	{
		public async Task TestAsync()
		{
			Console.WriteLine("Called Test()");
			await new ExternalClass().TestMethodAsync();
			Console.WriteLine("Processed TestMethodAsync() with async");
		}
	}
}
