using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components.Base;

public interface IDesignSystem
{
    CssFramework CssFramework { get; }

    string GetClassesForComponent<T>(T component) where T : BaseComponent;
    //string? GetStyleForComponent<T>(T component) where T : BaseComponent;

    string[] GetStylesheetReferences();
    string[] GetJavaScriptReferences(); 
}

