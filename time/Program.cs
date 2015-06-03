using System;
using System.Diagnostics;
using System.Linq;

namespace cstime
{
	class MainClass
	{
		public static void Main (string[] args) {
			var app = args.First ();
			var argv = args.Length > 1 ? args.Skip (1) : new [] { string.Empty };
			var si = new ProcessStartInfo {
				FileName = app,
				Arguments = string.Join (" ", argv),
				CreateNoWindow = false,
			};
			var sw = new Stopwatch ();
			var proc = new Process ();
			proc.StartInfo = si;
			proc.Start ();
			sw.Start ();
			proc.WaitForExit ();
			sw.Stop ();
			Console.WriteLine ("Execution time: {0}", sw.Elapsed.ToString ("c"));
			Environment.Exit (0);
		}
	}
}
