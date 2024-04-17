using static Reelist.UI.Components.Render;

namespace Reelist.UI;

public class Sample
{
  public static void SampleMethod()
  {
    var comp = Text(name: "test", styles: new(
      backgroundColor: "red",
      color: "black"))
      .Children(
        Button("Button A!"),
        Button("Button B!")
    );
    Mount(comp);
  }
}
