using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Module.DiscordRPC
{
	class RichPresenceWrapper : IRichPresence
    {
        public RichPresence Data;

        string IRichPresence.State { get => Data.State; set => Data.State = value; }
        string IRichPresence.Details { get => Data.Details; set => Data.Details = value; }
        long IRichPresence.StartTimestamp { get => Data.StartTimestamp; set => Data.StartTimestamp = value; }
        long IRichPresence.EndTimestamp { get => Data.EndTimestamp; set => Data.EndTimestamp = value; }
        string IRichPresence.LargeImageKey { get => Data.LargeImageKey; set => Data.LargeImageKey = value; }
        string IRichPresence.LargeImageText { get => Data.LargeImageText; set => Data.LargeImageText = value; }
        string IRichPresence.SmallImageKey { get => Data.SmallImageKey; set => Data.SmallImageKey = value; }
        string IRichPresence.SmallImageText { get => Data.SmallImageText; set => Data.SmallImageText = value; }
        string IRichPresence.PartyId { get => Data.PartyId; set => Data.PartyId = value; }
        int IRichPresence.PartySize { get => Data.PartySize; set => Data.PartySize = value; }
        int IRichPresence.PartyMax { get => Data.PartyMax; set => Data.PartyMax = value; }
        string IRichPresence.MatchSecret { get => Data.MatchSecret; set => Data.MatchSecret = value; }
        string IRichPresence.JoinSecret { get => Data.JoinSecret; set => Data.JoinSecret = value; }
        string IRichPresence.SpectateSecret { get => Data.SpectateSecret; set => Data.SpectateSecret = value; }
        bool IRichPresence.Instance { get => Data.Instance; set => Data.Instance = value; }
    }
}
