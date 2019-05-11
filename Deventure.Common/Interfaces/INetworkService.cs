﻿namespace Deventure.Common.Interfaces
{
	public interface INetworkService
	{
		void SignalNoInternetConnection();
		bool DeviceHasInternetConnectivity();
		void SignalServerConnectionDown();
	}
}