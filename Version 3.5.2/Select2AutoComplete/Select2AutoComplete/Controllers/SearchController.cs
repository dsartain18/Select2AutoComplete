using Select2AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Select2AutoComplete.Controllers
{
    [RoutePrefix("api/search")]
    public class SearchController : ApiController
    {

        /// <summary>
        /// Searches for matching help documents
        /// </summary>
        /// <param name="term">Search Term</param>
        /// <returns>List of Matching Help Documents</returns>
        [Route("search")]
        [HttpGet]
        public HttpResponseMessage Search(string term)
        {
            List<HelpDocument> helpDocuments = GetDocuments();

            List<HelpDocument> matchingDocuments = helpDocuments.Where(x => x.Title.ToLower().Contains(term.ToLower())).ToList();


            return Request.CreateResponse(HttpStatusCode.OK, matchingDocuments);

        }

        /// <summary>
        /// Creates list of fake help documents
        /// </summary>
        /// <returns>List of Help Documents</returns>
        private List<HelpDocument> GetDocuments()
        {
            List<HelpDocument> helpDocuments = new List<HelpDocument>();

            HelpDocument doc1 = new HelpDocument()
            {
                ID = 1,
                Title = "Test Help Document",
                MediaLink = "http://www.google.com"
            };

            HelpDocument doc2 = new HelpDocument()
            {
                ID = 1,
                Title = "Second Document",
                MediaLink = "http://www.yahoo.com"
            };

            HelpDocument doc3 = new HelpDocument()
            {
                ID = 1,
                Title = "Test Help Document with Media Link",
                MediaLink = "http://www.cnn.com"
            };

            HelpDocument doc4 = new HelpDocument()
            {
                ID = 1,
                Title = "Fourth Help Document",
                MediaLink = "http://www.msn.com"
            };

            HelpDocument doc5 = new HelpDocument()
            {
                ID = 1,
                Title = "Another Test Help Document with Media Link",
                MediaLink = "http://www.google.com"
            };

            helpDocuments.Add(doc1);
            helpDocuments.Add(doc2);
            helpDocuments.Add(doc3);
            helpDocuments.Add(doc4);
            helpDocuments.Add(doc5);

            return helpDocuments;
        }
    }
}
