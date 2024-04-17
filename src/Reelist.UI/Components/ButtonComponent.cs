using Reelist.UI.Styles;

namespace Reelist.UI.Components;

public class ButtonComponent(
  string text,
  string? name = null,
  string? id = null,
  ComponentStyles? styles = null
) : UIComponent(name, id, styles)
{
  public string Text { get; set; } = text;

  public override void Render()
  {
    throw new NotImplementedException();
  }
}

public static partial class Render
{
  public static ButtonComponent Button(string text, string? name = null, string? id = null, ComponentStyles? styles = null)
  {
    return new ButtonComponent(text, name, id, styles);
  }
}