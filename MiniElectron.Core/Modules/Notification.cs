using System.Threading.Tasks;

namespace MiniElectron.Core;

public static class Notification
{
    /// <summary>
    /// 当前系统是否支持桌面通知
    /// </summary>
    /// <param name="bridge"></param>
    /// <returns></returns>
    public static Task<Message> NotificationIsSupported(this Bridge bridge) => bridge.SendAsync("Notification.isSupported", isCallback: true);

    public sealed record ShowOptions
    {
        public string title { get; init; }
        public string subtitle { get; init; }
        public string body { get; init; }
        public string silent { get; init; }
        public string icon { get; init; }
        public bool hasReply { get; init; }
        public string timeoutType { get; init; }
        public string replyPlaceholder { get; init; }
        public string sound { get; init; }
        public string urgency { get; init; }
        public string closeButtonText { get; init; }
        public string toastXml { get; init; }
    }

    /// <summary>
    /// 即时向用户展示桌面通知
    /// </summary>
    /// <param name="bridge"></param>
    /// <param name="option"></param>
    /// <returns></returns>
    public static Task NotificationShow(this Bridge bridge, ShowOptions options = null) => bridge.SendAsync("Notification.show", options);
}