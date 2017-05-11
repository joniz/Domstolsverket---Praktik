using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Domstol
{
	public static class RemoteControllerCollection
	{

		public static List<RemoteController> RemoteControllers = new List<RemoteController>()
		{
			new RemoteController()
			{
				ControllerName = "Första kontrollen",
				ControllerImage = new Image() { Source = "RemoteControllers/kontroll1.png" },
				ControllerButtons = new List<Button>()
				{
					new Button(){Text="Första kontrollen Knapp1"},
					new Button(){Text="Första kontrollen Knapp2"},
					new Button(){Text="Första kontrollen Knapp3"}


				}

			},

		new RemoteController()
		{
			ControllerName = "Andra kontrollen",
			ControllerImage = new Image() { Source = "RemoteControllers/kontroll2.png" },
			ControllerButtons = new List<Button>()
			{
				new Button(){Text="Andra kontrollen Knapp1"},
				new Button(){Text="Andra kontrollen Knapp2"},
				new Button(){Text="Andra kontrollen Knapp3"}


			}

		},

		new RemoteController()
		{
			ControllerName = "Tredje kontrollen",
			ControllerImage = new Image() { Source = "RemoteControllers/kontroll3.png" },
			ControllerButtons = new List<Button>()
			{
				new Button(){Text="Tredje kontrollen Knapp1"},
				new Button(){Text="Tredje kontrollen Knapp2"},
				new Button(){Text="Tredje kontrollen Knapp3"}


			}
		}
		};
	}
}
