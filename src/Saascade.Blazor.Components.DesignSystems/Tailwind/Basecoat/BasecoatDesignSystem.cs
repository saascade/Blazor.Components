using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;
using System.Diagnostics.Metrics;

namespace Saascade.Blazor.Components.DesignSystems.Tailwind.Basecoat;

//https://basecoatui.com/
public class BasecoatDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Tailwind;
 

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

    public string[] GetStylesheetReferences() => 
        [
            """ <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/basecoat-css@0.3.11/dist/basecoat.cdn.min.css"> """ 
        ];

    public string[] GetJavaScriptReferences() => 
        [ 
         """ <script src="https://cdn.jsdelivr.net/npm/basecoat-css@0.3.11/dist/js/all.min.js" defer></script> """
        ];
}