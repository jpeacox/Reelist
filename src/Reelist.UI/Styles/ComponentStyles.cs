using System.Drawing;
using OneOf;

namespace Reelist.UI.Styles;

public class ComponentStyles(
    OneOf<Color, string>? backgroundColor = null,
    OneOf<Color, string>? color = null,
    OneOf<Color, string>? borderColor = null,
    BorderStyle? borderStyle = null,
    OneOf<Size, Autoable, int>? borderWidth = null,
    OneOf<Size, Autoable, int>? padding = null,
    OneOf<Size, Autoable, int>? margin = null,
    OneOf<Sizing, Autoable, int>? width = null,
    OneOf<Sizing, Autoable, int>? height = null,
    OneOf<Sizing, Autoable, int>? minWidth = null,
    OneOf<Sizing, Autoable, int>? maxWidth = null,
    OneOf<Sizing, Autoable, int>? minHeight = null,
    OneOf<Sizing, Autoable, int>? maxHeight = null,
    OneOf<Autoable, int>? left = null,
    OneOf<Autoable, int>? top = null,
    OneOf<Autoable, int>? right = null,
    OneOf<Autoable, int>? bottom = null,
    OneOf<Font, string>? font = null,
    Alignment textAlign = Alignment.Left,
    Position position = Position.Relative
  ) : NotifyPropertyChanged
{
  #region Backing Fields

  private OneOf<Color, string>? _backgroundColor = backgroundColor;
  private OneOf<Color, string>? _color = color;
  private OneOf<Color, string>? _borderColor = borderColor;
  private BorderStyle? _borderStyle = borderStyle;
  private OneOf<Size, Autoable, int> _borderWidth = borderWidth ?? 0;
  #region Layout Properties
  private OneOf<Size, Autoable, int> _padding = padding ?? 0;
  private OneOf<Size, Autoable, int> _margin = margin ?? 0;
  private OneOf<Sizing, Autoable, int> _width = width ?? Autoable.Auto;
  private OneOf<Sizing, Autoable, int> _height = height ?? Autoable.Auto;
  private OneOf<Sizing, Autoable, int> _minWidth = minWidth ?? Autoable.Auto;
  private OneOf<Sizing, Autoable, int> _maxWidth = maxWidth ?? Autoable.Auto;
  private OneOf<Sizing, Autoable, int> _minHeight = minHeight ?? Autoable.Auto;
  private OneOf<Sizing, Autoable, int> _maxHeight = maxHeight ?? Autoable.Auto;
  private OneOf<Autoable, int>? _left = left;
  private OneOf<Autoable, int>? _top = top;
  private OneOf<Autoable, int>? _right = right;
  private OneOf<Autoable, int>? _bottom = bottom;
  #endregion
  #region Font Properties
  private OneOf<Font, string>? _font = font;
  private Alignment _textAlign = textAlign;
  #endregion
  private Position _position = position;

  #endregion

  public OneOf<Color, string>? BackgroundColor
  {
    get => _backgroundColor;
    set => SetProperty(ref _backgroundColor, value);
  }
  public OneOf<Color, string>? Color
  {
    get => _color;
    set => SetProperty(ref _color, value);
  }
  public OneOf<Color, string>? BorderColor
  {
    get => _borderColor;
    set => SetProperty(ref _borderColor, value);
  }
  public BorderStyle? BorderStyle
  {
    get => _borderStyle;
    set => SetProperty(ref _borderStyle, value);
  }
  public OneOf<Size, Autoable, int> BorderWidth
  {
    get => _borderWidth;
    set => SetProperty(ref _borderWidth, value);
  }
  public OneOf<Size, Autoable, int> Padding
  {
    get => _padding;
    set => SetProperty(ref _padding, value);
  }
  public OneOf<Size, Autoable, int> Margin
  {
    get => _margin;
    set => SetProperty(ref _margin, value);
  }
  public OneOf<Sizing, Autoable, int> Width
  {
    get => _width;
    set => SetProperty(ref _width, value);
  }
  public OneOf<Sizing, Autoable, int> Height
  {
    get => _height;
    set => SetProperty(ref _height, value);
  }
  public OneOf<Sizing, Autoable, int> MinWidth
  {
    get => _minWidth;
    set => SetProperty(ref _minWidth, value);
  }
  public OneOf<Sizing, Autoable, int> MaxWidth
  {
    get => _maxWidth;
    set => SetProperty(ref _maxWidth, value);
  }
  public OneOf<Sizing, Autoable, int> MinHeight
  {
    get => _minHeight;
    set => SetProperty(ref _minHeight, value);
  }
  public OneOf<Sizing, Autoable, int> MaxHeight
  {
    get => _maxHeight;
    set => SetProperty(ref _maxHeight, value);
  }
  public OneOf<Autoable, int>? Left
  {
    get => _left;
    set => SetProperty(ref _left, value);
  }
  public OneOf<Autoable, int>? Top
  {
    get => _top;
    set => SetProperty(ref _top, value);
  }
  public OneOf<Autoable, int>? Right
  {
    get => _right;
    set => SetProperty(ref _right, value);
  }
  public OneOf<Autoable, int>? Bottom
  {
    get => _bottom;
    set => SetProperty(ref _bottom, value);
  }
  public OneOf<Font, string>? Font
  {
    get => _font;
    set => SetProperty(ref _font, value);
  }
  public Alignment TextAlign
  {
    get => _textAlign;
    set
    {
      if (_textAlign == value) return;
      _textAlign = value;
      OnPropertyChanged();
    }
  }
  public Position Position
  {
    get => _position;
    set
    {
      if (_position == value) return;
      _position = value;
      OnPropertyChanged();
    }
  }
}
