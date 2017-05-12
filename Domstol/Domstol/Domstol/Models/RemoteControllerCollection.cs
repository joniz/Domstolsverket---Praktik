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
				ControllerName = "TRC4",
				ControllerImage = new Image() { Source = "RemoteControllers/TRC4/TRC4.png" },
				ControllerButtons = new List<Button>()
				{
					new Button(){ Image = "RemoteControllers/TRC4/Call.png"},
					new Button(){ Image = "RemoteControllers/TRC4/Endcall.png"},
					new Button(){ Image = "RemoteControllers/TRC4/Layout.png"},
					new Button() { Image = "RemoteControllers/TRC4/Micoff.png"},
					new Button() { Image = "RemoteControllers/TRC4/Phonebook.png"},
					new Button() { Image = "RemoteControllers/TRC4/Presentation.png"},
					new Button() { Image = "RemoteControllers/TRC4/Zoom.png"}
				}

			},

		new RemoteController()
		{
			ControllerName = "TRC5",
			ControllerImage = new Image() { Source = "RemoteControllers/TRC5/TRC5.png" },
			ControllerButtons = new List<Button>()
			{
				new Button() { Image = "RemoteControllers/TRC5/Arrows.png"},
				new Button() { Image = "RemoteControllers/TRC5/Call.png"},
				new Button() { Image = "RemoteControllers/TRC5/Clear.png"},
				new Button() { Image = "RemoteControllers/TRC5/Endcall.png"},
				new Button() { Image = "RemoteControllers/TRC5/Functions.png"},
				new Button() { Image = "RemoteControllers/TRC5/Home.png"},
				new Button() { Image = "RemoteControllers/TRC5/Layout.png"},
				new Button() { Image = "RemoteControllers/TRC5/Micoff.png"},
				new Button() { Image = "RemoteControllers/TRC5/Numbers.png"},
				new Button() { Image = "RemoteControllers/TRC5/Phonebook.png"},
				new Button() { Image = "RemoteControllers/TRC5/Presentation.png"},
				new Button() { Image = "RemoteControllers/TRC5/Volume.png"},
				new Button() { Image = "RemoteControllers/TRC5/Zoom.png"}
			}

		},

		new RemoteController()
		{
			ControllerName = "TRC6",
			ControllerImage = new Image() { Source = "RemoteControllers/TRC6/TRC6.png" },
			ControllerButtons = new List<Button>()
			{
				new Button() { Image = "RemoteControllers/TRC6/Arrows.png"},
				new Button() { Image = "RemoteControllers/TRC6/Back.png"},
				new Button() { Image = "RemoteControllers/TRC6/Call.png"},
				new Button() { Image = "RemoteControllers/TRC6/Endcall.png"},
				new Button() { Image = "RemoteControllers/TRC6/Micoff.png"},
				new Button() { Image = "RemoteControllers/TRC6/Numbers.png"},
				new Button() { Image = "RemoteControllers/TRC6/Volume.png"}
			}
		}
		};
	}
}
