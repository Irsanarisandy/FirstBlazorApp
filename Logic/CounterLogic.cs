using Microsoft.AspNetCore.Components;

namespace FirstBlazorApp.Logic
{
    public class CounterLogic : ComponentBase
    {
        protected int currentCount = 0;

        [Parameter]
        public int IncrementAmount { get; set; } = 1;

        protected void IncrementCount()
        {
            currentCount += IncrementAmount;
        }
    }
}