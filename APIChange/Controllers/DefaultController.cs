using APIChange.Controllers.Validators;
using APIChange.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIChange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        
        public ConversionDTO GetConversion([FromQuery] GetConversionDTO dto)
        {
            double euro = 0;
            double dollar = 0;
            double yen = 0;

            switch (dto.Currency)
            {
                case "Euro":
                    euro = dto.Montant;
                    dollar = euro * 1.09;
                    yen = euro * 162.64;
                    break;
                case "Yen":
                    euro = dto.Montant / 162.64;
                    dollar = euro * 1.09;
                    yen = euro * 162.64;
                    break;
                case "Dollar":
                    euro = dto.Montant / 1.09;
                    dollar = dto.Montant;
                    yen = euro * 162.64;
                    break;
            }
            return new ConversionDTO(euro, dollar, yen);
        }

            [HttpPost]

        public string Login([FromBody] RegisterDTO dto)
        {
            return ("Enregistrement OK");
        }

        
    }
}

