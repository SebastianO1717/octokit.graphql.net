namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of RegenerateVerifiableDomainToken
    /// </summary>
    public class RegenerateVerifiableDomainTokenPayload : QueryableValue<RegenerateVerifiableDomainTokenPayload>
    {
        internal RegenerateVerifiableDomainTokenPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The verification token that was generated.
        /// </summary>
        public string VerificationToken { get; }

        internal static RegenerateVerifiableDomainTokenPayload Create(Expression expression)
        {
            return new RegenerateVerifiableDomainTokenPayload(expression);
        }
    }
}