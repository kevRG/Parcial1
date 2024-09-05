using Microsoft.AspNetCore.Mvc;
using Parcial1.API.Data;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/diagnoses")]
    public class DiagnosesController:ControllerBase
    {
        private readonly DataContext dataContext;

        public DiagnosesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
