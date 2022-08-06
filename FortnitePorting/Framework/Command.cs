using System;
using System.Windows.Input;

namespace FortnitePorting.Framework;

public abstract class Command : ICommand
{
    public abstract bool CanExecute(object? parameter);

    public abstract void Execute(object? parameter);

    public event EventHandler? CanExecuteChanged;
}