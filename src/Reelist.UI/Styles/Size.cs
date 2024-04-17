using OneOf;

namespace Reelist.UI.Styles;

public class Size
{
  public OneOf<Autoable, int> Top { get; set; }
  public OneOf<Autoable, int> Right { get; set; }
  public OneOf<Autoable, int> Bottom { get; set; }
  public OneOf<Autoable, int> Left { get; set; }

  public Size(
    OneOf<Autoable, int> px)
  {
    Top = Right = Bottom = Left = px;
  }

  public Size(
    OneOf<Autoable, int> ypx,
    OneOf<Autoable, int> xpx)
  {
    Top = Bottom = ypx;
    Right = Left = xpx;
  }

  public Size(
    OneOf<Autoable, int> top,
    OneOf<Autoable, int> xpx,
    OneOf<Autoable, int> bottom)
  {
    Top = top;
    Right = Left = xpx;
    Bottom = bottom;
  }

  public Size(
    OneOf<Autoable, int> top,
    OneOf<Autoable, int> right,
    OneOf<Autoable, int> bottom,
    OneOf<Autoable, int> left)
  {
    Top = top;
    Right = right;
    Bottom = bottom;
    Left = left;
  }
}
