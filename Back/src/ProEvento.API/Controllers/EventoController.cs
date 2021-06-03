﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento =new Evento[] {

            new Evento () {
               EventoId = 1,
               Tema = "Angular e Dotnet 5",
               Local = "Rio de Janeiro",
               Lote = "1 lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
               ImagemURL = "Foto.png"
           },
            new Evento () {
               EventoId = 2,
               Tema = "Angular e Suas Novidades",
               Local = "São Paulo",
               Lote = "2 lote",
               QtdPessoas = 350,
               DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
               ImagemURL = "Foto1.png"
           }
           };
            public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }
    
         [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}