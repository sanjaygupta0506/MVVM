using DiseasePredictionAPI.ML_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiseasePredictionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseController : ControllerBase
    {
        private readonly PredictionService _service;

        public DiseaseController()
        {
            _service = new PredictionService();
        }

        [HttpPost]
        public IActionResult Predict(
            [FromBody] PatientData patient)
        {
            var result = _service.Predict(patient);

            return Ok(result);
        }
    }
}
