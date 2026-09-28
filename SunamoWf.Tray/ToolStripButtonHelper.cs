namespace SunamoWf.Tray;

/// <summary>
/// Creates ToolStripButton instances for context menus.
/// </summary>
public class ToolStripButtonHelper
{
    /// <summary>
    /// Creates a ToolStripButton with the given text and click handler.
    /// </summary>
    public static ToolStripButton Get(string text, EventHandler onClick)
    {
        ToolStripButton toolStripButton = new ToolStripButton
        {
            Text = text
        };
        toolStripButton.Click += onClick;
        return toolStripButton;
    }
}
