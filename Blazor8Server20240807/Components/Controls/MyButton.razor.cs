using Microsoft.AspNetCore.Components;

namespace Blazor8Server20240807.Components.Controls
{
    public partial class MyButton
    {
        int count = 0;
        [Parameter] public string? ButtonText { get; set; }
        [Parameter] public string? ButtonNum { get; set; }

        private string _buttonText = "我是按鈕";

        async Task ChangeCount()
        {
            count++;

            ButtonText = _buttonText;

            string text = $"{ButtonText} {count}";

            ButtonText = await Task.FromResult(text);
        }

        protected override bool ShouldRender()
        {
            switch(ButtonNum)
            {
                case "btn1":
                    return true;
                case "btn2":
                    return false;
            }
            return false;
        }
    }
}
