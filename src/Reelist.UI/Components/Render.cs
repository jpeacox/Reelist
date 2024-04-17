using OneOf;

namespace Reelist.UI.Components;

public static partial class Render
{
  public static void Mount(OneOf<string, bool, UIComponent>? component)
  {
    if (component is null)
    {
      return;
    }
    var result = component.Value.Match(
      str => Text(str),
      boolean => boolean ? Text(boolean.ToString()) : null,
      uiComponent => uiComponent
    );
    result?.InternalRender();
  }
}
