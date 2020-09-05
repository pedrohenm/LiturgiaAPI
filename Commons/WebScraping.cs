using HtmlAgilityPack;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiturgiaAPI.Shared
{
    public class WebScraping
    {
        public enum PaginaLiturgia
        {
            LEITURA,
            SALMO,
            EVANGELHO
        }

        public HtmlDocument Buscar(PaginaLiturgia paginaLiturgia) 
        {
            var diaAtual = DateTime.Now.Day;
            var scraper = new HtmlWeb();
            var url = $"https://www.portadeassis.com.br/servicos/liturgia-diaria?data=2020-09-0{diaAtual}&month=9&year=2020";
            var page = new List<HtmlDocument>
                {
                    scraper.Load($"{url}#1-leitura"),
                    scraper.Load($"{url}#salmo"),
                    scraper.Load($"{url}#evangelho")
                };

            return page[(int)paginaLiturgia];
        }

    }
}
