namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeleteRepositoryRuleset
    /// </summary>
    public class DeleteRepositoryRulesetInput
    {
        /// <summary>
        /// The global relay id of the repository ruleset to be deleted.
        /// </summary>
        public ID RepositoryRulesetId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}