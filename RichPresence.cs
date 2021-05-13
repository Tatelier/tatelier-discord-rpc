namespace Tatelier.Module.DiscordRPC
{
	[System.Serializable]
	struct RichPresence : IRichPresence
	{
		string State; /* max 128 bytes */
		string Details; /* max 128 bytes */
		long StartTimestamp;
		long EndTimestamp;
		string LargeImageKey; /* max 32 bytes */
		string LargeImageText; /* max 128 bytes */
		string SmallImageKey; /* max 32 bytes */
		string SmallImageText; /* max 128 bytes */
		string PartyId; /* max 128 bytes */
		int PartySize;
		int PartyMax;
		string MatchSecret; /* max 128 bytes */
		string JoinSecret; /* max 128 bytes */
		string SpectateSecret; /* max 128 bytes */
		bool Instance;

        string IRichPresence.State { get => State; set => State = value; }
        string IRichPresence.Details { get => Details; set => Details = value; }
        long IRichPresence.StartTimestamp { get => StartTimestamp; set => StartTimestamp = value; }
        long IRichPresence.EndTimestamp { get => EndTimestamp; set => EndTimestamp = value; }
        string IRichPresence.LargeImageKey { get => LargeImageKey; set => LargeImageKey = value; }
        string IRichPresence.LargeImageText { get => LargeImageText; set => LargeImageText = value; }
        string IRichPresence.SmallImageKey { get => SmallImageKey; set => SmallImageKey = value; }
        string IRichPresence.SmallImageText { get => SmallImageText; set => SmallImageText = value; }
        string IRichPresence.PartyId { get => PartyId; set => PartyId = value; }
        int IRichPresence.PartySize { get => PartySize; set => PartySize = value; }
        int IRichPresence.PartyMax { get => PartyMax; set => PartyMax = value; }
        string IRichPresence.MatchSecret { get => MatchSecret; set => MatchSecret = value; }
        string IRichPresence.JoinSecret { get => JoinSecret; set => JoinSecret = value; }
        string IRichPresence.SpectateSecret { get => SpectateSecret; set => SpectateSecret = value; }
        bool IRichPresence.Instance { get => Instance; set => Instance = value; }
    }
}