﻿using System;

namespace Deventure.Common.Interfaces
{
	public interface ILoggingService
	{
		void LogException(Exception ex);

		void LogException(string strackTrace);

		void LogInfo(string info);

        void LogInfo(string tag, string info);
    }
}