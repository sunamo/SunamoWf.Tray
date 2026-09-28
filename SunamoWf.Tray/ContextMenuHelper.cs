namespace SunamoWf.Tray;

/// <summary>
/// Builds a WinForms tray icon context menu.
/// </summary>
public class ContextMenuHelper
{
    /// <summary>
    /// Creates a context menu strip with an optional single "quit" entry.
    /// </summary>
    public static ContextMenuStrip Get(string quitText, EventHandler onQuit)
    {
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

        if (onQuit != null)
        {
            contextMenuStrip.Items.Add(ToolStripButtonHelper.Get(quitText, onQuit));
        }

        return contextMenuStrip;
    }
}
