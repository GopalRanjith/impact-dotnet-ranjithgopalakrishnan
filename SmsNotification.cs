using System;

namespace CSharpLearning
{
	public class SmsNotification : Notification
	{
		public override void Send()
		{
			Console.WriteLine("Sending SMS Notification");
		}
	}
}