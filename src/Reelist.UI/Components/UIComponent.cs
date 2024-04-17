using OneOf;
using Reelist.UI.Styles;

namespace Reelist.UI.Components;

public abstract class UIComponent(
  string? name = null,
  string? id = null,
  ComponentStyles? styles = null)
{
  public ComponentStyles Styles { get; set; } = styles ?? new();
  public string? Name { get; set; } = name;
  public string? Id { get; set; } = id;

  public virtual OneOf<string, bool, UIComponent>? Children(params UIComponent[] components)
  {
    return components.Length switch
    {
      0 => false,
      1 => components[0],
      _ => string.Join("", components.Select(c => c.Name)),
    };
  }

  internal void InternalRender()
  {
    // I dunno yet
  }

  public abstract void Render();
}
