using HtmlAgilityPack;
using LiturgiaAPI.Models;
using LiturgiaAPI.Repositories.Interfaces;
using LiturgiaAPI.Shared;
using Microsoft.AspNetCore.Components;
using static LiturgiaAPI.Shared.WebScraping;

namespace LiturgiaAPI.Repositories
{
    public class LeituraRepository : ILeituraRepository
    {
        
        private WebScraping _webScraping { get; set; }

        public LeituraRepository(WebScraping webScraping)
        {
            _webScraping = webScraping;
        }

        LeituraModel leituraModel = new LeituraModel();

        public LeituraModel Get()
        {
            foreach (HtmlNode node in _webScraping.Buscar(PaginaLiturgia.LEITURA).GetElementbyId("evangelho").ChildNodes)
            {
                if (node.Name.Equals("h3"))
                    leituraModel.Titulo = node.InnerText;

                if (node.Name.Equals("div"))
                    leituraModel.Conteudo = node.InnerText;
            }

            return leituraModel;
        }
    }
}
