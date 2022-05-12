using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224FirstApi.DAL;
using P224FirstApi.DAL.Entities;
using P224FirstApi.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductPostDto productPostDto)
        {
            Product product = new Product();
            product.Name = productPostDto.MehsulunAdi;
            product.Price = productPostDto.MehsulunQiymeti;
            product.DiscountPrice = productPostDto.MehsulunEndirimQiymeti;
            product.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status201Created, product);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<ProductListDto> productListDtos = await _context.Products.Where(p => !p.IsDeleted)
                .Select(x => new ProductListDto
                {
                    Id = x.Id,
                    MehsulunAdi = x.Name,
                    MehsulunQiymeti = x.Price
                }).ToListAsync();

            return Ok(productListDtos);
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return BadRequest();

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            if (product == null) return NotFound();

            ProductGetDto productGetDto = new ProductGetDto
            {
                Id = product.Id,
                MehsulunAdi = product.Name,
                MehsulunQiymeti = product.Price,
                MehsulunEndirimQiymeti = product.DiscountPrice
            };

            return Ok(productGetDto);
        }

        [HttpPut]
        [Route("{id?}")]
        public async Task<IActionResult> Put(int? id, ProductPutDto productPutDto)
        {
            if (id == null) return BadRequest();

            if (id != productPutDto.Id) return BadRequest();

            Product existedproduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == productPutDto.Id && !p.IsDeleted);

            if (existedproduct == null) return NotFound();

            existedproduct.Name = productPutDto.MehsulunAdi;
            existedproduct.Price = productPutDto.MehsulunQiymeti;
            existedproduct.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedproduct.DiscountPrice = productPutDto.MehsulunEndirimQiymeti;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id?}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            Product existedproduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            if (existedproduct == null) return NotFound();

            existedproduct.IsDeleted = true;
            existedproduct.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
