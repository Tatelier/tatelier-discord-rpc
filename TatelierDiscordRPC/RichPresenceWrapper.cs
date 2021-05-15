using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Module.DiscordRPC
{
	class RichPresenceWrapper : IRichPresence
    {
        public RichPresence Data;

        byte[] bytes = new byte[128];

        string GetText(IntPtr ptr)
		{
            Array.Clear(bytes, 0, bytes.Length);
            Marshal.Copy(ptr, bytes, 0, bytes.Length);

            string result = Encoding.UTF8.GetString(bytes);
            int index = result.IndexOf('\0');
            if (index >= 0) result = result.Substring(0, index);
            return result;
        }

        void SetText(string text, ref IntPtr ptr)
        {
			if (ptr != IntPtr.Zero)
			{
                Marshal.FreeHGlobal(ptr);
			}

			if (string.IsNullOrEmpty(text))
            {
                ptr = IntPtr.Zero;
                return;
            }
            var count = Encoding.UTF8.GetByteCount(text);
            var buffer = Marshal.AllocHGlobal(count + 1);
            for (int i = 0; i < count + 1; i++)
            {
                Marshal.WriteByte(buffer, i, 0);
            }

            Marshal.Copy(Encoding.UTF8.GetBytes(text), 0, buffer, count);
            ptr = buffer;
        }

        string IRichPresence.State { get => GetText(Data.State); set => SetText(value, ref Data.State); }
        string IRichPresence.Details { get => GetText(Data.Details); set => SetText(value, ref Data.Details); }
        long IRichPresence.StartTimestamp { get => Data.StartTimestamp; set => Data.StartTimestamp = value; }
        long IRichPresence.EndTimestamp { get => Data.EndTimestamp; set => Data.EndTimestamp = value; }
        string IRichPresence.LargeImageKey { get => GetText(Data.LargeImageKey); set => SetText(value, ref Data.LargeImageKey); }
        string IRichPresence.LargeImageText { get => GetText(Data.LargeImageText); set => SetText(value, ref Data.LargeImageText); }
        string IRichPresence.SmallImageKey { get => GetText(Data.SmallImageKey); set => SetText(value, ref Data.SmallImageKey); }
        string IRichPresence.SmallImageText { get => GetText(Data.SmallImageText); set => SetText(value, ref Data.SmallImageText); }
        string IRichPresence.PartyId { get => GetText(Data.PartyId); set => SetText(value, ref Data.State); }
        int IRichPresence.PartySize { get => Data.PartySize; set => Data.PartySize = value; }
        int IRichPresence.PartyMax { get => Data.PartyMax; set => Data.PartyMax = value; }
        string IRichPresence.MatchSecret { get => GetText(Data.MatchSecret); set => SetText(value, ref Data.MatchSecret); }
        string IRichPresence.JoinSecret { get => GetText(Data.JoinSecret); set => SetText(value, ref Data.JoinSecret); }
        string IRichPresence.SpectateSecret { get => GetText(Data.SpectateSecret); set => SetText(value, ref Data.SpectateSecret); }
        bool IRichPresence.Instance { get => Data.Instance; set => Data.Instance = value; }

        public RichPresenceWrapper()
		{
            Data = new RichPresence();
		}
    }
}
