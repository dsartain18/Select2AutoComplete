using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Select2AutoComplete.Models
{
    public class HelpDocument
    {
        /// <summary>
        /// Help Document ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Help Document Description
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Help Document Media Link
        /// </summary>
        public string MediaLink { get; set; }
    }
}