using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Reader.Web.PageModel;
using Reader.Web.Services;

namespace Reader.Web.Pages.Author
{
    public class AuthorsViewModel : ComponentBase
    {
        [Inject] AuthorService ServiceAuthor { get; set; }

        protected List<AuthorItemViewModel> Models { get; set; }

        protected override async Task OnInitializedAsync()
        {
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                try
                {
                    Models = ServiceAuthor.GetListAllModel();
                }
                catch (Exception e)
                {
                }
            }
        }
    }
}
