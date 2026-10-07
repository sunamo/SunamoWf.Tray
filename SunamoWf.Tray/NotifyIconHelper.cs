namespace SunamoWf.Tray;

/// <summary>
/// Creates and configures a WinForms system tray icon (NotifyIcon).
/// </summary>
public class NotifyIconHelper
{
    private static Action<bool> s_setCancelClosing;

    /// <summary>
    /// Creates a tray NotifyIcon with a double-click handler, a context menu, and optional extra context menu items.
    /// </summary>
    /// <remarks>
    /// Into contextMenuStrip insert ContextMenuHelper.Get.
    /// </remarks>
    public static void Create(Action<bool> setCancelClosing, Stream streamIcon, EventHandler onDoubleClick,
        ContextMenuStrip contextMenuStrip, Dictionary<string, Action> contextMenuItems = null)
    {
        s_setCancelClosing = setCancelClosing;

        NotifyIcon notifyIcon = new NotifyIcon
        {
            Icon = new Icon(streamIcon),
            Visible = true,
            ContextMenuStrip = contextMenuStrip
        };

        notifyIcon.Click += onDoubleClick;

        if (contextMenuItems != null)
        {
            foreach (KeyValuePair<string, Action> item in contextMenuItems)
            {
                notifyIcon.ContextMenuStrip.Items.Add(ToolStripButtonHelper.Get(item.Key, (sender, eventArgs) => item.Value()));
            }
        }
    }
}
