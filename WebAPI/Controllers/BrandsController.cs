using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class BrandsController: ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
           _brandService = brandService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("update")]
        public IActionResult UpDate(Brand brand)
        {
            var result = _brandService.UpDate(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
