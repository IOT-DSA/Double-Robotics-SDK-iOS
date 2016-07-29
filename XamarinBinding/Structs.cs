using System;
using ObjCRuntime;

namespace DoubleRobotics
{
	[Native]
	public enum DRDriveDirection : long /* nint */
	{
		Stop = 0,
		Forward = 1,
		Backward = 2
	}
}
