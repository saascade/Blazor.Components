using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.Components.ComponentLibraries.BlankSlate;

public class EmptyComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Nothing;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            _ => component.GetType().Name.ToLowerSnakeCase()
        };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent => null;
}