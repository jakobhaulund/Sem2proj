using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Microsoft.AspNetCore.Cors;
using Miljøfestivalen.Shared;
using System.Diagnostics;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/brugere")]
    public class FrivilligController : ControllerBase
    {

        private IFrivilligRepository FrivilligRepo;

        public FrivilligController(IFrivilligRepository FriRepo)
        {
                FrivilligRepo = FriRepo;
        }

        [EnableCors("policy")]
        [HttpGet("hentallebrugere")]
        public async Task<IEnumerable<Bruger>> HentAlleBrugere()
        {
            return await FrivilligRepo.HentAlleBrugere();
        }
    }
}

