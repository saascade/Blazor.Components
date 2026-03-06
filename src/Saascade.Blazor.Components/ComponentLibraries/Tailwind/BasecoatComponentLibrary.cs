using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.Components.ComponentLibraries.Tailwind;

//https://basecoatui.com/
public class BasecoatComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Tailwind;
 

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            nameof(Button) => "btn",
            nameof(PrimaryButton) => "btn-primary",
            nameof(SecondaryButton) => "btn-secondary",
            nameof(DestructiveButton) => "btn-destructive",

            nameof (Card) => "card",  
            _ => component.GetType().Name.ToLowerSnakeCase()
        };
     
}