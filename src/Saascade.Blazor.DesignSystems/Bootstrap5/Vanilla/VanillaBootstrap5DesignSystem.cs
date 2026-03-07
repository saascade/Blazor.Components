using Microsoft.AspNetCore.Components;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;
using Saascade.Blazor.Components;

namespace Saascade.Blazor.DesignSystems.Bootstrap5.Vanilla;

public class VanillaBootstrap5DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Bootstrap5;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            nameof(Button) => "btn",
            nameof(Card) => "card",
            nameof(Column) => "col",
            _ => component.GetType().Name.ToLowerSnakeCase()
        };

    public string[] GetStylesheetReferences() => [];
    public string[] GetJavaScriptReferences() => [];
}
