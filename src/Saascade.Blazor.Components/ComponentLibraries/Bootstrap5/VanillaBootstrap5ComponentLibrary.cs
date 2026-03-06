using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.Components.ComponentLibraries.Bootstrap5;

public class VanillaBootstrap5ComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Bootstrap5;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            nameof(Button) => "btn",
            nameof(Card) => "card",
            nameof(Column) => "col",
            _ => component.GetType().Name.ToLowerSnakeCase()
        }; 
}
