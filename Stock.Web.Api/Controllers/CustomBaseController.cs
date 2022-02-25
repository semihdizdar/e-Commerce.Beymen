﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Core.DTOs;

namespace Stock.Web.Api.Controllers
{

    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }
            else
            {
                return new ObjectResult(response)
                {
                    StatusCode = response.StatusCode
                };
            }
               

        }
      
    }
}

