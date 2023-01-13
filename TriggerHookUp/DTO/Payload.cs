﻿namespace Jenkins_TriggerHook.TriggerHookUp.DTO;

public class Payload
{
    public string @ref { get; set; }
    public string before { get; set; }
    public string after { get; set; }
    public string compare_url { get; set; }
    public List<Commit> commits { get; set; }
    public HeadCommit head_commit { get; set; }
    public Repository repository { get; set; }
    public Pusher pusher { get; set; }
    public Sender sender { get; set; }
}

public class Author
{
    public string name { get; set; }
    public string email { get; set; }
    public string username { get; set; }
}

public class Commit
{
    public string id { get; set; }
    public string message { get; set; }
    public string url { get; set; }
    public Author author { get; set; }
    public Committer committer { get; set; }
    public object verification { get; set; }
    public DateTime timestamp { get; set; }
    public List<object> added { get; set; }
    public List<object> removed { get; set; }
    public List<string> modified { get; set; }
}

public class Committer
{
    public string name { get; set; }
    public string email { get; set; }
    public string username { get; set; }
}

public class HeadCommit
{
    public string id { get; set; }
    public string message { get; set; }
    public string url { get; set; }
    public Author author { get; set; }
    public Committer committer { get; set; }
    public object verification { get; set; }
    public DateTime timestamp { get; set; }
    public List<object> added { get; set; }
    public List<object> removed { get; set; }
    public List<string> modified { get; set; }
}

public class InternalTracker
{
    public bool enable_time_tracker { get; set; }
    public bool allow_only_contributors_to_track_time { get; set; }
    public bool enable_issue_dependencies { get; set; }
}

public class Owner
{
    public int id { get; set; }
    public string login { get; set; }
    public string full_name { get; set; }
    public string email { get; set; }
    public string avatar_url { get; set; }
    public string language { get; set; }
    public bool is_admin { get; set; }
    public DateTime last_login { get; set; }
    public DateTime created { get; set; }
    public bool restricted { get; set; }
    public bool active { get; set; }
    public bool prohibit_login { get; set; }
    public string location { get; set; }
    public string website { get; set; }
    public string description { get; set; }
    public string visibility { get; set; }
    public int followers_count { get; set; }
    public int following_count { get; set; }
    public int starred_repos_count { get; set; }
    public string username { get; set; }
}

public class Permissions
{
    public bool admin { get; set; }
    public bool push { get; set; }
    public bool pull { get; set; }
}

public class Pusher
{
    public int id { get; set; }
    public string login { get; set; }
    public string full_name { get; set; }
    public string email { get; set; }
    public string avatar_url { get; set; }
    public string language { get; set; }
    public bool is_admin { get; set; }
    public DateTime last_login { get; set; }
    public DateTime created { get; set; }
    public bool restricted { get; set; }
    public bool active { get; set; }
    public bool prohibit_login { get; set; }
    public string location { get; set; }
    public string website { get; set; }
    public string description { get; set; }
    public string visibility { get; set; }
    public int followers_count { get; set; }
    public int following_count { get; set; }
    public int starred_repos_count { get; set; }
    public string username { get; set; }
}

public class Repository
{
    public int id { get; set; }
    public Owner owner { get; set; }
    public string name { get; set; }
    public string full_name { get; set; }
    public string description { get; set; }
    public bool empty { get; set; }
    public bool @private { get; set; }
    public bool fork { get; set; }
    public bool template { get; set; }
    public object parent { get; set; }
    public bool mirror { get; set; }
    public int size { get; set; }
    public string html_url { get; set; }
    public string ssh_url { get; set; }
    public string clone_url { get; set; }
    public string original_url { get; set; }
    public string website { get; set; }
    public int stars_count { get; set; }
    public int forks_count { get; set; }
    public int watchers_count { get; set; }
    public int open_issues_count { get; set; }
    public int open_pr_counter { get; set; }
    public int release_counter { get; set; }
    public string default_branch { get; set; }
    public bool archived { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Permissions permissions { get; set; }
    public bool has_issues { get; set; }
    public InternalTracker internal_tracker { get; set; }
    public bool has_wiki { get; set; }
    public bool has_pull_requests { get; set; }
    public bool has_projects { get; set; }
    public bool ignore_whitespace_conflicts { get; set; }
    public bool allow_merge_commits { get; set; }
    public bool allow_rebase { get; set; }
    public bool allow_rebase_explicit { get; set; }
    public bool allow_squash_merge { get; set; }
    public string default_merge_style { get; set; }
    public string avatar_url { get; set; }
    public bool @internal { get; set; }
    public string mirror_interval { get; set; }
}

public class Sender
{
    public int id { get; set; }
    public string login { get; set; }
    public string full_name { get; set; }
    public string email { get; set; }
    public string avatar_url { get; set; }
    public string language { get; set; }
    public bool is_admin { get; set; }
    public DateTime last_login { get; set; }
    public DateTime created { get; set; }
    public bool restricted { get; set; }
    public bool active { get; set; }
    public bool prohibit_login { get; set; }
    public string location { get; set; }
    public string website { get; set; }
    public string description { get; set; }
    public string visibility { get; set; }
    public int followers_count { get; set; }
    public int following_count { get; set; }
    public int starred_repos_count { get; set; }
    public string username { get; set; }
}