namespace FortnitePorting.Framework;

public abstract class ViewModelCommand<TViewModel> : Command where TViewModel : ViewModel
{
    private readonly TViewModel _context;
    
    protected ViewModelCommand(TViewModel viewModel)
    {
        _context = viewModel;
    }
    
    public override bool CanExecute(object? parameter)
    {
        return true;
    }

    public abstract override void Execute(object? parameter);
}