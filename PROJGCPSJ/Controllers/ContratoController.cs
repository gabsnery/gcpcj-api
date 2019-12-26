using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PROJGCPSJ.Models;
using PROJGCPSJ.Repositorio;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PROJGCPSJ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {

        private IRepositorio<tbcontrato> _repositorio;

        public ContratoController(IRepositorio<tbcontrato> repositorio)
        {
            _repositorio = repositorio;


        }
        [EnableCors]
        [HttpGet()]
        public List<tbcontrato> Get(string body)
        {
            var empresaResult = _repositorio.SelectAll().ToList();
            return empresaResult;
        }

        [EnableCors]
        [HttpPost()]
        public void InsereContrato1()
        {
            var _contrato = new tbcontrato();
            var _Tbaditivo = new tbaditivo();
            _Tbaditivo.valortbaditivo = 10000;
            _Tbaditivo.motivotbaditivo = "dddd";
            _Tbaditivo.prazotbaditivo = 32;
            _contrato.objetocontrato = "dddd";
            _contrato.prazocontrato = 23;

            _contrato.tbaditivo.Add(_Tbaditivo);
            _repositorio.Add(_contrato);


        }

        [EnableCors]
        [HttpPost("InsereContrato")]
        public void InsereContrato()
        {
            var _contrato = new tbcontrato();
            var _Tbaditivo = new tbaditivo();
            _Tbaditivo.valortbaditivo = 10000;


            string body;
            using (var reader = new StreamReader(Request.Body))
            {
                body = reader.ReadToEnd();


                // Do something
            }

            Console.WriteLine("Body");
            Console.WriteLine(body);
            _contrato = JsonConvert.DeserializeObject<tbcontrato>(body);
            _contrato.tbaditivo.Add(_Tbaditivo);

            _repositorio.Add(_contrato);
            var rng = new Random();
            var empresaResult = _repositorio.SelectAll().ToList();

            //return _contrato;


        }
       /* [EnableCors]
        [HttpGet("{id}")]
        public tbcontrato Get(int id)
        {
            var empresaResult = _repositorio.SelectById(id, "Contratos");
            return empresaResult;
        }*/

    }
}