using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Blazor8Server20240807.Components.Controls
{
    public class MyButton3: ComponentBase
    {
        [Parameter] public string? ButtonText { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, $"<button class=\"btn btn-primary\">{ButtonText}</button>");
            base.BuildRenderTree(builder);
        }
    }
}
