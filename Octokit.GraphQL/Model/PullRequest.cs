namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// A repository pull request.
    /// </summary>
    public class PullRequest : QueryEntity
    {
        public PullRequest(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// The number of additions in this pull request.
        /// </summary>
        public int Additions { get; }

        /// <summary>
        /// A list of Users assigned to this object.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public UserConnection Assignees(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Assignees(first, after, last, before), Octokit.GraphQL.Model.UserConnection.Create);

        /// <summary>
        /// The actor who authored the comment.
        /// </summary>
        public IActor Author => this.CreateProperty(x => x.Author, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// Author's association with the subject of the comment.
        /// </summary>
        public CommentAuthorAssociation AuthorAssociation { get; }

        /// <summary>
        /// Identifies the base Ref associated with the pull request.
        /// </summary>
        public Ref BaseRef => this.CreateProperty(x => x.BaseRef, Octokit.GraphQL.Model.Ref.Create);

        /// <summary>
        /// Identifies the name of the base Ref associated with the pull request, even if the ref has been deleted.
        /// </summary>
        public string BaseRefName { get; }

        /// <summary>
        /// Identifies the body of the pull request.
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Identifies the body of the pull request rendered to HTML.
        /// </summary>
        public string BodyHTML { get; }

        /// <summary>
        /// Identifies the body of the pull request rendered to text.
        /// </summary>
        public string BodyText { get; }

        /// <summary>
        /// The number of changed files in this pull request.
        /// </summary>
        public int ChangedFiles { get; }

        /// <summary>
        /// `true` if the pull request is closed
        /// </summary>
        public bool Closed { get; }

        /// <summary>
        /// Identifies the date and time when the object was closed.
        /// </summary>
        public DateTimeOffset? ClosedAt { get; }

        /// <summary>
        /// A list of comments associated with the pull request.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public IssueCommentConnection Comments(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Comments(first, after, last, before), Octokit.GraphQL.Model.IssueCommentConnection.Create);

        /// <summary>
        /// A list of commits present in this pull request's head branch not present in the base branch.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public PullRequestCommitConnection Commits(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Commits(first, after, last, before), Octokit.GraphQL.Model.PullRequestCommitConnection.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset? CreatedAt { get; }

        /// <summary>
        /// Check if this comment was created via an email reply.
        /// </summary>
        public bool CreatedViaEmail { get; }

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        public int? DatabaseId { get; }

        /// <summary>
        /// The number of deletions in this pull request.
        /// </summary>
        public int Deletions { get; }

        /// <summary>
        /// The actor who edited this pull request's body.
        /// </summary>
        public IActor Editor => this.CreateProperty(x => x.Editor, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the head Ref associated with the pull request.
        /// </summary>
        public Ref HeadRef => this.CreateProperty(x => x.HeadRef, Octokit.GraphQL.Model.Ref.Create);

        /// <summary>
        /// Identifies the name of the head Ref associated with the pull request, even if the ref has been deleted.
        /// </summary>
        public string HeadRefName { get; }

        /// <summary>
        /// The repository associated with this pull request's head Ref.
        /// </summary>
        public Repository HeadRepository => this.CreateProperty(x => x.HeadRepository, Octokit.GraphQL.Model.Repository.Create);

        /// <summary>
        /// The owner of the repository associated with this pull request's head Ref.
        /// </summary>
        public IRepositoryOwner HeadRepositoryOwner => this.CreateProperty(x => x.HeadRepositoryOwner, Octokit.GraphQL.Model.Internal.StubIRepositoryOwner.Create);

        public string Id { get; }

        /// <summary>
        /// The head and base repositories are different.
        /// </summary>
        public bool IsCrossRepository { get; }

        /// <summary>
        /// A list of labels associated with the object.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public LabelConnection Labels(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Labels(first, after, last, before), Octokit.GraphQL.Model.LabelConnection.Create);

        /// <summary>
        /// The moment the editor made the last edit
        /// </summary>
        public DateTimeOffset? LastEditedAt { get; }

        /// <summary>
        /// `true` if the pull request is locked
        /// </summary>
        public bool Locked { get; }

        /// <summary>
        /// The commit that was created when this pull request was merged.
        /// </summary>
        public Commit MergeCommit => this.CreateProperty(x => x.MergeCommit, Octokit.GraphQL.Model.Commit.Create);

        /// <summary>
        /// Whether or not the pull request can be merged based on the existence of merge conflicts.
        /// </summary>
        public MergeableState Mergeable { get; }

        /// <summary>
        /// Whether or not the pull request was merged.
        /// </summary>
        public bool Merged { get; }

        /// <summary>
        /// The date and time that the pull request was merged.
        /// </summary>
        public DateTimeOffset? MergedAt { get; }

        /// <summary>
        /// Identifies the milestone associated with the pull request.
        /// </summary>
        public Milestone Milestone => this.CreateProperty(x => x.Milestone, Octokit.GraphQL.Model.Milestone.Create);

        /// <summary>
        /// Identifies the pull request number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// A list of Users that are participating in the Pull Request conversation.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public UserConnection Participants(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Participants(first, after, last, before), Octokit.GraphQL.Model.UserConnection.Create);

        /// <summary>
        /// The commit that GitHub automatically generated to test if this pull request could be merged. This field will not return a value if the pull request is merged, or if the test merge commit is still being generated. See the `mergeable` field for more details on the mergeability of the pull request.
        /// </summary>
        public Commit PotentialMergeCommit => this.CreateProperty(x => x.PotentialMergeCommit, Octokit.GraphQL.Model.Commit.Create);

        /// <summary>
        /// List of project cards associated with this pull request.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public ProjectCardConnection ProjectCards(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.ProjectCards(first, after, last, before), Octokit.GraphQL.Model.ProjectCardConnection.Create);

        /// <summary>
        /// Identifies when the comment was published at.
        /// </summary>
        public DateTimeOffset? PublishedAt { get; }

        /// <summary>
        /// A list of reactions grouped by content left on the subject.
        /// </summary>
        public IQueryable<ReactionGroup> ReactionGroups => this.CreateProperty(x => x.ReactionGroups);

        /// <summary>
        /// A list of Reactions left on the Issue.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="content">Allows filtering Reactions by emoji.</param>
        /// <param name="orderBy">Allows specifying the order in which reactions are returned.</param>
        public ReactionConnection Reactions(int? first = null, string after = null, int? last = null, string before = null, ReactionContent? content = null, ReactionOrder orderBy = null) => this.CreateMethodCall(x => x.Reactions(first, after, last, before, content, orderBy), Octokit.GraphQL.Model.ReactionConnection.Create);

        /// <summary>
        /// The repository associated with this node.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Model.Repository.Create);

        /// <summary>
        /// The HTTP path for this pull request.
        /// </summary>
        public string ResourcePath { get; }

        /// <summary>
        /// The HTTP path for reverting this pull request.
        /// </summary>
        public string RevertResourcePath { get; }

        /// <summary>
        /// The HTTP URL for reverting this pull request.
        /// </summary>
        public string RevertUrl { get; }

        /// <summary>
        /// A list of review requests associated with the pull request.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public ReviewRequestConnection ReviewRequests(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.ReviewRequests(first, after, last, before), Octokit.GraphQL.Model.ReviewRequestConnection.Create);

        /// <summary>
        /// A list of reviews associated with the pull request.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="states">A list of states to filter the reviews.</param>
        /// <param name="author">Filter by author of the review.</param>
        public PullRequestReviewConnection Reviews(int? first = null, string after = null, int? last = null, string before = null, IEnumerable<PullRequestReviewState> states = null, string author = null) => this.CreateMethodCall(x => x.Reviews(first, after, last, before, states, author), Octokit.GraphQL.Model.PullRequestReviewConnection.Create);

        /// <summary>
        /// Identifies the state of the pull request.
        /// </summary>
        public PullRequestState State { get; }

        /// <summary>
        /// A list of reviewer suggestions based on commit history and past review comments.
        /// </summary>
        public IQueryable<SuggestedReviewer> SuggestedReviewers => this.CreateProperty(x => x.SuggestedReviewers);

        /// <summary>
        /// A list of events, comments, commits, etc. associated with the pull request.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="since">Allows filtering timeline events by a `since` timestamp.</param>
        public PullRequestTimelineConnection Timeline(int? first = null, string after = null, int? last = null, string before = null, DateTimeOffset? since = null) => this.CreateMethodCall(x => x.Timeline(first, after, last, before, since), Octokit.GraphQL.Model.PullRequestTimelineConnection.Create);

        /// <summary>
        /// Identifies the pull request title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; }

        /// <summary>
        /// The HTTP URL for this pull request.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Can user react to this subject
        /// </summary>
        public bool ViewerCanReact { get; }

        /// <summary>
        /// Check if the viewer is able to change their subscription status for the repository.
        /// </summary>
        public bool ViewerCanSubscribe { get; }

        /// <summary>
        /// Check if the current viewer can update this object.
        /// </summary>
        public bool ViewerCanUpdate { get; }

        /// <summary>
        /// Reasons why the current viewer can not update this comment.
        /// </summary>
        public IQueryable<CommentCannotUpdateReason> ViewerCannotUpdateReasons => this.CreateProperty(x => x.ViewerCannotUpdateReasons);

        /// <summary>
        /// Did the viewer author this comment.
        /// </summary>
        public bool ViewerDidAuthor { get; }

        /// <summary>
        /// Identifies if the viewer is watching, not watching, or ignoring the subscribable entity.
        /// </summary>
        public SubscriptionState ViewerSubscription { get; }

        internal static PullRequest Create(IQueryProvider provider, Expression expression)
        {
            return new PullRequest(provider, expression);
        }
    }
}