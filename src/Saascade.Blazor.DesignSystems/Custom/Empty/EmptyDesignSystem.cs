using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.DesignSystems.Custom.Empty;

public class EmptyDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Custom;
     

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            _ => component.GetType().Name.ToLowerSnakeCase()
        }; 

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent => null;


    public string[] GetStylesheetReferences() => [];
    public string[] GetJavaScriptReferences() => [];
}