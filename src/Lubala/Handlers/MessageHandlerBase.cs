﻿using System;

namespace Lubala
{
	public abstract class MessageHandlerBase : IMessageHandler
	{
		public abstract void HandleCore(HostContext context);
	}
}
