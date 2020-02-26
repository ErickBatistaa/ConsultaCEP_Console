using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api_Estagio
{
    interface ApiService
    {
        [Get("/posts/{id}")]
        Task<ApiResponse> GetAddressAsync(string id);
    }
}
