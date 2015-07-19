using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAsYoureToldAPI
{
	public class DoAsYoureToldStore
	{
		private static readonly List<string> _entries = new List<string>
		{
			"Stop it",
			"Tidy up",
			"Behave",
			"Be quiet",
			"Calm down",
			"Clean your teeth",
			"Comb your hair",
			"Don't do that",
			"Eat your greens",
			"Go and play",
			"Go to bed",
			"Hurry up",
			"I said NO",
			"Not now",
			"Take care",
			"Wash your face",
			"Sit down",
			"Say please and thank you"
		};

		public string GetRandom()
		{
			return _entries[new Random().Next(0, 17)];
		}
	}
}
