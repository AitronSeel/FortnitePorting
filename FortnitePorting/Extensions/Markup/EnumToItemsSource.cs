using System;
using System.Linq;
using System.Windows.Markup;

namespace FortnitePorting.Extensions.Markup;

public class EnumToItemsSource : MarkupExtension
{
    private readonly Type _type;
    public EnumToItemsSource(Type type)
    {
        _type = type;
    }
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var values = Enum.GetValues(_type).Cast<Enum>();
        return values.Select(x => x.GetDescription()).ToList();
    }
}