using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Tatelier.Module.DiscordRPC
{
	[Serializable, StructLayout(LayoutKind.Sequential)]
	struct RichPresence
	{
		public IntPtr State; /* max 128 bytes */
		public IntPtr Details; /* max 128 bytes */
		public long StartTimestamp;
		public long EndTimestamp;
		public IntPtr LargeImageKey; /* max 32 bytes */
		public IntPtr LargeImageText; /* max 128 bytes */
		public IntPtr SmallImageKey; /* max 32 bytes */
		public IntPtr SmallImageText; /* max 128 bytes */
		public IntPtr PartyId; /* max 128 bytes */
		public int PartySize;
		public int PartyMax;
		public IntPtr MatchSecret; /* max 128 bytes */
		public IntPtr JoinSecret; /* max 128 bytes */
		public IntPtr SpectateSecret; /* max 128 bytes */
		public bool Instance;

		public RichPresence(string a)
		{
			State = Marshal.AllocHGlobal(128);
			Details = Marshal.AllocHGlobal(128);
			StartTimestamp = 0;
			EndTimestamp = 0;
			LargeImageKey = Marshal.AllocHGlobal(32);
			LargeImageText = Marshal.AllocHGlobal(128);
			SmallImageKey = Marshal.AllocHGlobal(32);
			SmallImageText = Marshal.AllocHGlobal(128);
			PartyId = Marshal.AllocHGlobal(128);
			PartySize = 0;
			PartyMax = 0;
			MatchSecret = Marshal.AllocHGlobal(128);
			JoinSecret = Marshal.AllocHGlobal(128);
			SpectateSecret = Marshal.AllocHGlobal(128);
			Instance = false;
		}
	}
}