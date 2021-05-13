

namespace Tatelier.Module.DiscordRPC
{
    public class TatelierDiscordRPC : ITatelierDiscordRPC
    {
		public const string DLLPath = ".ttle_modules\\discord-rpc\\discord-rpc.dll";
	
		EventHandlers handlers;

		RichPresenceWrapper presence;

		public IRichPresence Presence { get => presence; }

		/// <summary>
		/// 初期化処理
		/// </summary>
		/// <param name="clientId">クライアント(アプリケーションID)</param>
		public int Initialize(string clientId)
		{
			presence = new RichPresenceWrapper();
			Presence.LargeImageKey = "tatelier";
			Presence.LargeImageText = "Tatelier";
			Presence.SmallImageKey = "tatelier";
			Presence.SmallImageText = "Tatelier";

			handlers = new EventHandlers();

			DiscordRPCAPI.Initialize(clientId, ref handlers, true, null);

			return 0;
		}


		/// <summary>
		/// 更新処理
		/// </summary>
		public int UpdatePresence()
		{
			DiscordRPCAPI.UpdatePresence(ref presence.Data);

			return 0;
		}

		/// <summary>
		/// 終了処理
		/// </summary>
		public int Shotdown()
        {
			DiscordRPCAPI.Shutdown();

			return 0;
        }
	}
}
