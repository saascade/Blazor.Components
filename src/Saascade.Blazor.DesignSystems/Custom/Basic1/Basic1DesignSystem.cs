using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.DesignSystems.Custom.Basic1;

public class Basic1DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Custom;
     

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetStandardCssClassesForBasicHtmlElements() ?? component.GetType().Name switch
        {
            _ => component.GetType().Name.ToLowerSnakeCase()
        }; 

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent => null;


    public string[] GetStylesheetReferences() =>
        [
        """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components/designSystems/custom/basic1/css/basic.css" /> """, 
        ];
    public string[] GetJavaScriptReferences() => [];

}