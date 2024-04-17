namespace Reelist.UI.Styles;

public class Font : NotifyPropertyChanged
{
  private string? _family;
  private int _size;
  private FontStyle _style;
  private FontWeight _weight;

  public string? Family
  {
    get => _family;
    set => SetProperty(ref _family, value);
  }

  public int Size
  {
    get => _size;
    set => SetProperty(ref _size, value);
  }

  public FontStyle Style
  {
    get => _style;
    set => SetProperty(ref _style, value);
  }

  public FontWeight Weight
  {
    get => _weight;
    set => SetProperty(ref _weight, value);
  }
}
