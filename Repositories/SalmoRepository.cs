using HtmlAgilityPack;
using LiturgiaAPI.Models;
using LiturgiaAPI.Repositories.Interfaces;
using LiturgiaAPI.Shared;
using Microsoft.AspNetCore.Components;
using static LiturgiaAPI.Shared.WebScraping;

namespace LiturgiaAPI.Repositories
{
    public class EvangelhoRepository : IEvangelhoRepository
    {
        
        private WebScraping _webScraping { get; set; }

        public EvangelhoRepository(WebScraping webScraping)
        {
            _webScraping = webScraping;
        }

        EvangelhoModel evangelhoModel = new EvangelhoModel();

        public EvangelhoModel Get()
        {
            foreach (HtmlNode node in _webScraping.Buscar(PaginaLiturgia.EVANGELHO).GetElementbyId("evangelho").ChildNodes)
            {
                if (node.Name.Equals("h3"))
                    evangelhoModel.Titulo = node.InnerText;

                if (node.Name.Equals("div"))
                    evangelhoModel.Conteudo = node.InnerText;
            }

            return evangelhoModel;
        }
    }
}
