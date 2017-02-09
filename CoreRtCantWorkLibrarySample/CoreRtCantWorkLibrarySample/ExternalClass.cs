using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreRtCantWorkLibrarySample
{
	public class ExternalClass
	{
		public async Task TestMethodAsync()
		{
			Console.WriteLine("Called TestMethodAsync()");
			//error occurred in await.
			await Task.Delay(1);
			Console.WriteLine("Waited 1 millisecond.");
		}
	}
}
