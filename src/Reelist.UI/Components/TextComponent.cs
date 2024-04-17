using Reelist.UI.Styles;

namespace Reelist.UI.Components;

public class TextComponent(
  string? name = null,
  string? id = null,
  ComponentStyles? styles = null
) : UIComponent(name, id, styles)
{
  public override void Render()
  {
    throw new NotImplementedException();
  }
}

public static partial class Render
{
  public static TextComponent Text(string? name = null, string? id = null, ComponentStyles? styles = null)
  {
    return new TextComponent(name, id);
  }
}
