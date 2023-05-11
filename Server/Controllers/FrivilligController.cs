﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Repositories;
using Microsoft.AspNetCore.Cors;
using Miljøfestivalen.Shared;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/brugere")]
    public class ShelterListController : ControllerBase
    {

        private IFrivilligRepository FrivilligRepo;

        public ShelterListController(IFrivilligRepository repo)
        {
            FrivilligRepo = repo;
        }

        [HttpGet]
        [EnableCors("policy")]
        public IEnumerable<Bruger> Get()
        {
            Console.WriteLine("get ");
            return FrivilligRepo.GetBrugere();
        }
    }
}

