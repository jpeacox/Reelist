using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Reelist.UI;

public abstract class NotifyPropertyChanged : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;

  protected void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

  protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string name = "")
  {
    if (field is not null && field.Equals(value)) return;
    field = value;
    OnPropertyChanged(name);
  }
}
