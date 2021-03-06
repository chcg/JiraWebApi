﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi
{
    /// <summary>
    /// Representation of a JIRA filter.
    /// </summary>
    public sealed class Filter : ComparableElement
    {
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        public Filter()
        { }

        /// <summary>
        /// Description of the JIRA filter.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Owner name of the JIRA filter.
        /// </summary>
        [JsonProperty("owner")]
        public User Owner { get; set; }

        /// <summary>
        /// JQL string of the JIRA filter.
        /// </summary>
        [JsonProperty("jql")]
        public string Jql { get; set; }

        /// <summary>
        /// Url of the filters view web page.
        /// </summary>
        [JsonProperty("viewUrl")]
        public Uri ViewUrl { get; private set; }

        /// <summary>
        /// Url of the filters search web page.
        /// </summary>
        [JsonProperty("searchUrl")]
        public Uri SearchUrl { get; private set; }

        /// <summary>
        /// Signals if the filter is marked as favourite.
        /// </summary>
        [JsonProperty("favourite")]
        public bool IsFavourite { get; set; }

        /// <summary>
        /// Share permissions of the JIRA filter
        /// </summary>
        [JsonProperty("sharePermissions")]
        public IEnumerable<Permission> SharePermissions { get; set; }

        /// <summary>
        /// Subscriptions of the JIRA filter.
        /// </summary>
        [JsonProperty("subscriptions")]
        public Subscriptions Subscriptions { get; set; }
    }
}
