namespace Tatelier.Module.DiscordRPC
{
	public struct EventHandlers
	{
		public ReadyCallback readyCallback;
		public DisconnectedCallback disconnectedCallback;
		public ErrorCallback errorCallback;
	}
}