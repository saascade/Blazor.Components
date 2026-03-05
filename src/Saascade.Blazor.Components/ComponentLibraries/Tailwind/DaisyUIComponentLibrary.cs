using Humanizer;
using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.Components.ComponentLibraries.Tailwind;

//https://daisyui.com/components/button/
public class DaisyUIComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Tailwind;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            nameof(A) => "link",

            nameof(Button) => "btn",
            nameof(PrimaryButton) => "btn btn-primary",
            nameof(SecondaryButton) => "btn btn-secondary",
            nameof(DestructiveButton) => "btn btn-error",
            
            nameof(AcceptButton) => "btn btn-success",
            nameof(SubmitButton) => "btn btn-primary",
            nameof(CloseButton) => "btn btn-secondary",
            nameof(CancelButton) => "btn btn-secondary",
            nameof(DeleteButton) => "btn btn-error",

            nameof(Card) => "card bg-base-100 w-96 shadow-sm",
            nameof (Carousel) => "carousel rounded-box",
            nameof(Hero) => "hero bg-base-200 min-h-screen",
            _ => component.GetType().Name.ToLowerSnakeCase()
        };
     

}