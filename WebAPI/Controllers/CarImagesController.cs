﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class CarImagesController : ControllerBase
    {
        ICarImagesService carImagesService;
        public CarImagesController()
        {

        }
    }
}
