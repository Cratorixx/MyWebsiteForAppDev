using Microsoft.AspNetCore.Components;

namespace LocalBlazorSite.Components.Pages.CommentandRate
{
    public partial class CommentandRate
    {
        protected string userName = "";
        protected string userComment = "";
        protected double rating = 0;
        protected string warningMessage = "";

        protected void SetRating(double selectedRating)
        {
            rating = selectedRating;
            StateHasChanged();
        }

        protected void HandleSubmit()
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                warningMessage = "Please fill out the Name field before submitting (you can use 'Anonymous' if you prefer).";
            }
            else
            {
                warningMessage = "";
                // Handle successful submission workflow here later
            }
            StateHasChanged();
        }
    }
}