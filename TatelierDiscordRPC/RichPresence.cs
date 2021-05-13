namespace Tatelier.Module.DiscordRPC
{
	[System.Serializable]
	struct RichPresence
	{
		public string State; /* max 128 bytes */
		public string Details; /* max 128 bytes */
		public long StartTimestamp;
		public long EndTimestamp;
		public string LargeImageKey; /* max 32 bytes */
		public string LargeImageText; /* max 128 bytes */
		public string SmallImageKey; /* max 32 bytes */
		public string SmallImageText; /* max 128 bytes */
		public string PartyId; /* max 128 bytes */
		public int PartySize;
		public int PartyMax;
		public string MatchSecret; /* max 128 bytes */
		public string JoinSecret; /* max 128 bytes */
		public string SpectateSecret; /* max 128 bytes */
		public bool Instance;
    }
}