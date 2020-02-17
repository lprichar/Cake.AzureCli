
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace Cake.AzureCli
{
    [CakeAliasCategory("Az")]
    public static class AzAliases
    {
        private static void AppendArguments(ref string baseCommand, ProcessArgumentBuilder arguments)
        {
            if (arguments != null)
            {
                baseCommand += " " + arguments.Render().TrimEnd();
            }
        }

        private static void AppendIfNonNull(ref string baseCommand, string paramName, string setting)
        {
            if (!string.IsNullOrEmpty(setting))
            {
                baseCommand += $" {paramName}={setting}";
            }
        }

        /// <summary>
        /// "az configure".
        /// Manage Azure CLI configuration. This command is interactive.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// "az feedback".
        /// Send feedback to the Azure CLI Team!
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeedback(this ICakeContext context) {
        }

        /// <summary>
        /// "az find".
        /// I'm an AI robot, my advice is based on our Azure documentation as well as the usage patterns of Azure CLI and Azure ARM users. Using me improves Azure products and documentation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFind(this ICakeContext context) {
        }

        /// <summary>
        /// "az interactive".
        /// Start interactive mode. Installs the Interactive extension if not installed already.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzInteractive(this ICakeContext context) {
        }

        /// <summary>
        /// "az login".
        /// Log in to Azure.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLogin(this ICakeContext context) {
        }

        /// <summary>
        /// "az logout".
        /// Log out to remove access to Azure subscriptions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLogout(this ICakeContext context) {
        }

        /// <summary>
        /// "az rest".
        /// Invoke a custom request.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRest(this ICakeContext context) {
        }

        /// <summary>
        /// "az account clear".
        /// Clear all subscriptions from the CLI's local cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az account get-access-token".
        /// Get a token for utilities to access Azure.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountGetAccessToken(this ICakeContext context) {
        }

        /// <summary>
        /// "az account list".
        /// Get a list of subscriptions for the logged in account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az account list-locations".
        /// List supported regions for the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountListLocations(this ICakeContext context) {
        }

        /// <summary>
        /// "az account set".
        /// Set a subscription to be the current active subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az account show".
        /// Get the details of a subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az account lock create".
        /// Create a subscription lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az account lock delete".
        /// Delete a subscription lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az account lock list".
        /// List lock information in the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockList(this ICakeContext context) {
        }

        /// <summary>
        /// "az account lock show".
        /// Show the details of a subscription lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az account lock update".
        /// Update a subscription lock.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group create".
        /// Create a new management group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group delete".
        /// Delete an existing management group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group list".
        /// List all management groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group show".
        /// Get a specific management group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group update".
        /// Update an existing management group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group subscription add".
        /// Add a subscription to a management group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupSubscriptionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az account management-group subscription remove".
        /// Remove an existing subscription from a management group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupSubscriptionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr build".
        /// Queues a quick build, providing streaming logs for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrBuild(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr check-health".
        /// Gets health information on the environment and optionally a target registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCheckHealth(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr check-name".
        /// Checks if an Azure Container Registry name is valid and available for use.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr create".
        /// Creates an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr delete".
        /// Deletes an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr import".
        /// Imports an image to an Azure Container Registry from another Container Registry. Import removes the need to docker pull, docker tag, docker push.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr list".
        /// Lists all the container registries under the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr login".
        /// Log in to an Azure Container Registry through the Docker CLI.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrLogin(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr run".
        /// Queues a quick run providing streamed logs for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr show".
        /// Get the details of an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr show-usage".
        /// Get the storage usage for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr update".
        /// Update an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr config content-trust show".
        /// Show the configured content-trust policy for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigContentTrustShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr config content-trust update".
        /// Update content-trust policy for an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigContentTrustUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr config retention show".
        /// Show the configured retention policy for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigRetentionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr config retention update".
        /// Update retention policy for an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigRetentionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr credential renew".
        /// Regenerate login credentials for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCredentialRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr credential show".
        /// Get the login credentials for an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCredentialShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr helm delete".
        /// Delete a helm chart version in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr helm list".
        /// List all helm charts in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr helm push".
        /// Push a helm chart package to an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmPush(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr helm show".
        /// Describe a helm chart in an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr helm repo add".
        /// Add a helm chart repository from an Azure Container Registry through the Helm CLI.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmRepoAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr network-rule add".
        /// Add a network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr network-rule list".
        /// List network rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr network-rule remove".
        /// Remove a network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr pack build".
        /// Queues a quick build task that builds an app and pushes it into an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrPackBuild(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr replication create".
        /// Create a replicated region for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr replication delete".
        /// Delete a replicated region from an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr replication list".
        /// List all of the regions for a geo-replicated Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr replication show".
        /// Get the details of a replicated region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr replication update".
        /// Updates a replication.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository delete".
        /// Delete a repository or image in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository list".
        /// List repositories in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository show".
        /// Get the attributes of a repository or image in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository show-manifests".
        /// Show manifests of a repository in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShowManifests(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository show-tags".
        /// Show tags for a repository in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShowTags(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository untag".
        /// Untag an image in an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryUntag(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr repository update".
        /// Update the attributes of a repository or image in an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr scope-map create".
        /// Create a scope map for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr scope-map delete".
        /// Delete a scope map for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr scope-map list".
        /// List all scope maps for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr scope-map show".
        /// Show details and attributes of a scope map for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr scope-map update".
        /// Update a scope map for an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task cancel-run".
        /// Cancel a specified run of an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCancelRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task create".
        /// Creates a series of steps for building, testing and OS & Framework patching containers. Tasks support triggers from git commits and base image updates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task delete".
        /// Delete a task from an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task list".
        /// List the tasks for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task list-runs".
        /// List all of the executed runs for an Azure Container Registry, with the ability to filter by a specific Task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskListRuns(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task logs".
        /// Show logs for a particular run. If no run-id is supplied, show logs for the last created run.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskLogs(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task run".
        /// Manually trigger a task that might otherwise be waiting for git commits or base image update triggers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task show".
        /// Get the properties of a named task for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task show-run".
        /// Get the properties of a specified run of an Azure Container Registry Task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskShowRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task update".
        /// Update a task for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task update-run".
        /// Patch the run properties of an Azure Container Registry Task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskUpdateRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task credential add".
        /// Add a custom registry login credential to the task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task credential list".
        /// List all the custom registry credentials for task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task credential remove".
        /// Remove credential for a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task credential update".
        /// Update the registry login credential for a task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task identity assign".
        /// Update the managed identity for a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task identity remove".
        /// Remove managed identities for a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task identity show".
        /// Display the managed identities for task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task timer add".
        /// Add a timer trigger to a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task timer list".
        /// List all timer triggers for a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task timer remove".
        /// Remove a timer trigger from a task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr task timer update".
        /// Update the timer trigger for a task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token create".
        /// Create a token associated with a scope map for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token delete".
        /// Delete a token for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token list".
        /// List all tokens for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token show".
        /// Show details and attributes of a token for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token update".
        /// Update a token (replace associated scope map) for an Azure Container Registry.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token credential delete".
        /// Delete a token credential.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr token credential generate".
        /// Generate or replace one or both passwords of a token for an Azure Container Registry. For using token and password to access a container registry, see https://aka.ms/acr/repo-permissions.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCredentialGenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook create".
        /// Create a webhook for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook delete".
        /// Delete a webhook from an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook get-config".
        /// Get the service URI and custom headers for the webhook.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookGetConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook list".
        /// List all of the webhooks for an Azure Container Registry.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookList(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook list-events".
        /// List recent events for a webhook.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookListEvents(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook ping".
        /// Trigger a ping event for a webhook.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookPing(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook show".
        /// Get the details of a webhook.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az acr webhook update".
        /// Update a webhook.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app create".
        /// Create a web application, web API or native application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app delete".
        /// Delete an application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app list".
        /// List applications.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app show".
        /// Get the details of an application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app update".
        /// Update an application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app credential delete".
        /// Delete an application's password or certificate credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app credential list".
        /// List an application's password or certificate credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app credential reset".
        /// Append or overwrite an application's password or certificate credentials.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app owner add".
        /// Add an application owner.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app owner list".
        /// List application owners.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app owner remove".
        /// Remove an application owner.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission add".
        /// Add an API permission.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission admin-consent".
        /// Grant Application & Delegated permissions through admin-consent.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionAdminConsent(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission delete".
        /// Remove an API permission.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission grant".
        /// Grant the app an API Delegated permissions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionGrant(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission list".
        /// List API permissions the application has requested.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad app permission list-grants".
        /// List Oauth2 permission grants.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionListGrants(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group create".
        /// Create a group in the directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group delete".
        /// Delete a group from the directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group get-member-groups".
        /// Gets a collection of object IDs of groups of which the specified group is a member.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupGetMemberGroups(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group list".
        /// List groups in the directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group show".
        /// Gets group information from the directory.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group member add".
        /// Add a member to a group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group member check".
        /// Check if a member is in a group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberCheck(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group member list".
        /// Gets the members of a group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group member remove".
        /// Remove a member from a group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group owner add".
        /// Add a group owner.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group owner list".
        /// List group owners.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad group owner remove".
        /// Remove a group owner.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad signed-in-user list-owned-objects".
        /// Get the list of directory objects that are owned by the user.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSignedInUserListOwnedObjects(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad signed-in-user show".
        /// Gets the details for the currently logged-in user.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSignedInUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp create".
        /// Create a service principal.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp create-for-rbac".
        /// Create a service principal and configure its access to Azure resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCreateForRbac(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp delete".
        /// Delete a service principal and its role assignments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp list".
        /// List service principals.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp show".
        /// Get the details of a service principal.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp update".
        /// Update a service principal.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp credential delete".
        /// Delete a service principal's credential.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp credential list".
        /// List a service principal's credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp credential reset".
        /// Reset a service principal credential.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad sp owner list".
        /// List service principal owners.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user create".
        /// Create an Azure Active Directory user.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user delete".
        /// Delete a user.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user get-member-groups".
        /// Get groups of which the user is a member.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserGetMemberGroups(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user list".
        /// List Azure Active Directory users.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user show".
        /// Gets user information from the directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ad user update".
        /// Update Azure Active Directory users.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor configuration list".
        /// List Azure Advisor configuration for the entire subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor configuration show".
        /// Show Azure Advisor configuration for the given subscription or resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor configuration update".
        /// Update Azure Advisor configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor recommendation disable".
        /// Disable Azure Advisor recommendations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor recommendation enable".
        /// Enable Azure Advisor recommendations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az advisor recommendation list".
        /// List Azure Advisor recommendations.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks browse".
        /// Show the dashboard for a Kubernetes cluster in a web browser.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksBrowse(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks create".
        /// Create a new managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks delete".
        /// Delete a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks disable-addons".
        /// Disable Kubernetes addons.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksDisableAddons(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks enable-addons".
        /// Enable Kubernetes addons.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksEnableAddons(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks get-credentials".
        /// Get access credentials for a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks get-upgrades".
        /// Get the upgrade versions available for a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetUpgrades(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks get-versions".
        /// Get the versions available for creating a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks install-cli".
        /// Download and install kubectl, the Kubernetes command-line tool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksInstallCli(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks install-connector".
        /// Install the ACI Connector on a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksInstallConnector(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks list".
        /// List managed Kubernetes clusters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksList(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks remove-connector".
        /// Remove the ACI Connector from a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRemoveConnector(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks remove-dev-spaces".
        /// Remove Azure Dev Spaces from a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRemoveDevSpaces(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks rotate-certs".
        /// Rotate certificates and keys on a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRotateCerts(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks scale".
        /// Scale the node pool in a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksScale(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks show".
        /// Show the details for a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks update".
        /// Update a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks update-credentials".
        /// Update credentials for a managed Kubernetes cluster, like service principal.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpdateCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks upgrade".
        /// Upgrade a managed Kubernetes cluster to a newer version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpgrade(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks upgrade-connector".
        /// Upgrade the ACI Connector on a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpgradeConnector(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks use-dev-spaces".
        /// Use Azure Dev Spaces with a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUseDevSpaces(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks wait".
        /// Wait for a managed Kubernetes cluster to reach a desired state.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool add".
        /// Add a node pool to the managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool delete".
        /// Delete the agent pool in the managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool list".
        /// List node pools in the managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool scale".
        /// Scale the node pool in a managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolScale(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool show".
        /// Show the details for a node pool in the managed Kubernetes cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool update".
        /// Update a node pool to enable/disable cluster-autoscaler or change min-count or max- count.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az aks nodepool upgrade".
        /// Upgrade the node pool in a managed Kubernetes cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolUpgrade(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account check-name".
        /// Checks whether the Media Service resource name is available.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account create".
        /// Create an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account delete".
        /// Delete an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account list".
        /// List Azure Media Services accounts for the entire subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account show".
        /// Show the details of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account update".
        /// Update the details of an Azure Media Services account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account mru set".
        /// Set the type and number of media reserved units for an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountMruSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account mru show".
        /// Show the details of media reserved units for an Azure Media Services account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountMruShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account sp create".
        /// Create a service principal and configure its access to an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountSpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account sp reset-credentials".
        /// Generate a new client secret for a service principal configured for an Azure Media Services account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountSpResetCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account storage add".
        /// Attach a secondary storage to an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account storage remove".
        /// Detach a secondary storage from an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account storage sync-storage-keys".
        /// Synchronize storage account keys for a storage account associated with an Azure Media Services account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageSyncStorageKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account-filter create".
        /// Create an account filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account-filter delete".
        /// Delete an account filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account-filter list".
        /// List all the account filters of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account-filter show".
        /// Show the details of an account filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams account-filter update".
        /// Update the details of an account filter.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset create".
        /// Create an asset.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset delete".
        /// Delete an asset.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset get-encryption-key".
        /// Get the asset storage encryption keys used to decrypt content created by version 2 of the Media Services API.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetGetEncryptionKey(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset get-sas-urls".
        /// Lists storage container URLs with shared access signatures (SAS) for uploading and downloading Asset content. The signatures are derived from the storage account keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetGetSasUrls(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset list".
        /// List all the assets of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset list-streaming-locators".
        /// List streaming locators which are associated with this asset.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetListStreamingLocators(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset show".
        /// Show the details of an asset.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset update".
        /// Update the details of an asset.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset-filter create".
        /// Create an asset filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset-filter delete".
        /// Delete an asset filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset-filter list".
        /// List all the asset filters of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset-filter show".
        /// Show the details of an asset filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams asset-filter update".
        /// Update the details of an asset filter.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy create".
        /// Create a new content key policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy delete".
        /// Delete a content key policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy list".
        /// List all the content key policies within an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy show".
        /// Show an existing content key policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy update".
        /// Update an existing content key policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy option add".
        /// Add a new option to an existing content key policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy option remove".
        /// Remove an option from an existing content key policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams content-key-policy option update".
        /// Update an option from an existing content key policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job cancel".
        /// Cancel a job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job create".
        /// Create and start a job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job delete".
        /// Delete a job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job list".
        /// List all the jobs of a transform within an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job show".
        /// Show the details of a job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams job update".
        /// Update an existing job.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event create".
        /// Create a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event delete".
        /// Delete a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event list".
        /// List all the live events of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event reset".
        /// Reset a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event show".
        /// Show the details of a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event start".
        /// Start a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event stop".
        /// Stop a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event update".
        /// Update the details of a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-event wait".
        /// Place the CLI in a waiting state until a condition of the live event is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-output create".
        /// Create a live output.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-output delete".
        /// Delete a live output.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-output list".
        /// List all the live outputs in a live event.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams live-output show".
        /// Show the details of a live output.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint create".
        /// Create a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint delete".
        /// Delete a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint list".
        /// List all the streaming endpoints within an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint scale".
        /// Set the scale of a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointScale(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint show".
        /// Show the details of a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint start".
        /// Start a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint stop".
        /// Stop a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint update".
        /// Update the details of a streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint wait".
        /// Place the CLI in a waiting state until a condition of the streaming endpoint is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint akamai add".
        /// Add an AkamaiAccessControl to an existing streaming endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointAkamaiAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-endpoint akamai remove".
        /// Remove an AkamaiAccessControl from an existing streaming endpoint.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointAkamaiRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator create".
        /// Create a streaming locator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator delete".
        /// Delete a Streaming Locator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator get-paths".
        /// List paths supported by a streaming locator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorGetPaths(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator list".
        /// List all the streaming locators within an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator list-content-keys".
        /// List content keys used by a streaming locator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorListContentKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-locator show".
        /// Show the details of a streaming locator.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-policy create".
        /// Create a streaming policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-policy delete".
        /// Delete a Streaming Policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-policy list".
        /// List all the streaming policies within an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams streaming-policy show".
        /// Show the details of a streaming policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform create".
        /// Create a transform.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform delete".
        /// Delete a transform.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform list".
        /// List all the transforms of an Azure Media Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform show".
        /// Show the details of a transform.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform update".
        /// Update the details of a transform.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform output add".
        /// Add an output to an existing transform.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformOutputAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az ams transform output remove".
        /// Remove an output from an existing transform.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformOutputRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig create".
        /// Create an App Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig delete".
        /// Delete an App Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig list".
        /// Lists all App Configurations under the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig show".
        /// Show properties of an App Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig update".
        /// Update an App Configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig credential list".
        /// List access keys of an App Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig credential regenerate".
        /// Regenerate an access key for an App Configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCredentialRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature delete".
        /// Delete feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature disable".
        /// Disable a feature flag to turn it OFF for use.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature enable".
        /// Enable a feature flag to turn it ON for use.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature list".
        /// List feature flags.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature lock".
        /// Lock a feature flag to prohibit write operations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureLock(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature set".
        /// Set a feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature show".
        /// Show all attributes of a feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature unlock".
        /// Unlock a feature to gain write operations.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureUnlock(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature filter add".
        /// Add a filter to a feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature filter delete".
        /// Delete a filter from a feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature filter list".
        /// List all filters for a feature flag.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig feature filter show".
        /// Show filters of a feature flag.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv delete".
        /// Delete key-values.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv export".
        /// Export configurations to another place from your App Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv import".
        /// Import configurations into your App Configuration from another place.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv list".
        /// List key-values.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv lock".
        /// Lock a key-value to prohibit write operations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvLock(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv restore".
        /// Restore key-values.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv set".
        /// Set a key-value.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv show".
        /// Show all attributes of a key-value.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig kv unlock".
        /// Unlock a key-value to gain write operations.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvUnlock(this ICakeContext context) {
        }

        /// <summary>
        /// "az appconfig revision list".
        /// Lists revision history of key-values.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigRevisionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice list-locations".
        /// List regions where a plan sku is available.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceListLocations(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase create".
        /// Create app service environment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase delete".
        /// Delete app service environment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase list".
        /// List app service environments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase list-addresses".
        /// List VIPs associated with an app service environment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseListAddresses(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase list-plans".
        /// List app service plans associated with an app service environment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseListPlans(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase show".
        /// Show details of an app service environment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice ase update".
        /// Update app service environment.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice hybrid-connection set-key".
        /// Set the key that all apps in an appservice plan use to connect to the hybrid- connections in that appservice plan.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceHybridConnectionSetKey(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice plan create".
        /// Create an app service plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice plan delete".
        /// Delete an app service plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice plan list".
        /// List app service plans.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanList(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice plan show".
        /// Get the app service plans for a resource group or a set of resource groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice plan update".
        /// Update an app service plan. See https://docs.microsoft.com/azure/app-service/app- service-plan-manage#move-an-app-to-another-app-service-plan to learn more.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az appservice vnet-integration list".
        /// List the virtual network integrations used in an appservice plan.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup container list".
        /// List containers registered to a Recovery services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup container show".
        /// Show details of a container registered to a Recovery services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup container unregister".
        /// Unregister a Backup Container to make the underlying 'resource' be protected by another vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup item list".
        /// List all backed up items within a container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup item set-policy".
        /// Update the policy associated with this item. Use this to change policies of the backup item.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemSetPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup item show".
        /// Show details of a particular backed up item.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup job list".
        /// List all backup jobs of a Recovery Services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup job show".
        /// Show details of a particular job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup job stop".
        /// Suspend or terminate a currently running job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup job wait".
        /// Wait until either the job completes or the specified timeout value is reached.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy create".
        /// Create a new policy for the given BackupManagementType and workloadType.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy delete".
        /// Delete a backup policy which doesn't have any associated backup items.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy get-default-for-vm".
        /// Get the default policy with default values to backup a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyGetDefaultForVm(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy list".
        /// List all policies for a Recovery services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy list-associated-items".
        /// List all items protected by a backup policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyListAssociatedItems(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy set".
        /// Update the existing policy with the provided details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicySet(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup policy show".
        /// Show details of a particular policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup protection backup-now".
        /// Perform an on-demand backup of a backed up item.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionBackupNow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup protection check-vm".
        /// Find out whether the virtual machine is protected or not. If protected, it returns the recovery services vault ID, otherwise it returns empty.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionCheckVm(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup protection disable".
        /// Stop protecting a backed up item. Can retain the backed up data forever or choose to delete it.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup protection enable-for-azurefileshare".
        /// Start protecting a previously unprotected Azure File share within an Azure Storage account as per the specified policy to a Recovery services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionEnableForAzurefileshare(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup protection enable-for-vm".
        /// Start protecting a previously unprotected Azure VM as per the specified policy to a Recovery services vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionEnableForVm(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup recoverypoint list".
        /// List all recovery points of a backed up item.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRecoverypointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup recoverypoint show".
        /// Shows details of a particular recovery point.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRecoverypointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup restore restore-azurefiles".
        /// Restore backed up Azure Workloads in a Recovery services vault to another registered container or to the same container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreAzurefiles(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup restore restore-azurefileshare".
        /// Restore backed up Azure Workloads in a Recovery services vault to another registered container or to the same container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreAzurefileshare(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup restore restore-disks".
        /// Restore disks of the backed VM from the specified recovery point.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreDisks(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup restore files mount-rp".
        /// Download a script which mounts files of a recovery point.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreFilesMountRp(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup restore files unmount-rp".
        /// Close access to the recovery point.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreFilesUnmountRp(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault create".
        /// Create a new Recovery Services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault delete".
        /// Delete an existing Recovery services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault list".
        /// List Recovery service vaults within a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultList(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault show".
        /// Show details of a particular Recovery service vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault backup-properties set".
        /// Sets backup related properties of the Recovery Services vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultBackupPropertiesSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az backup vault backup-properties show".
        /// Gets backup related properties of the Recovery Services vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultBackupPropertiesShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account create".
        /// Create a Batch account with the specified parameters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account delete".
        /// Deletes the specified Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account list".
        /// List the Batch accounts associated with a subscription or resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account login".
        /// Log in to a Batch account through Azure Active Directory or Shared Key authentication.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountLogin(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account set".
        /// Update properties for a Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account show".
        /// Get a specified Batch account or the currently set account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account autostorage-keys sync".
        /// Synchronizes access keys for the auto-storage account configured for the specified Batch account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountAutostorageKeysSync(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account keys list".
        /// Gets the account keys for the specified Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch account keys renew".
        /// Regenerates the specified account key for the Batch account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application create".
        /// Adds an application to the specified Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application delete".
        /// Deletes an application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application list".
        /// Lists all of the applications in the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application set".
        /// Update properties for a Batch application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application show".
        /// Gets information about the specified application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application package activate".
        /// Activates a Batch application package.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageActivate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application package create".
        /// Create a Batch application package record and activate it.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application package delete".
        /// Deletes an application package record and its associated binary file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application package list".
        /// Lists all of the application packages in the specified application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application package show".
        /// Gets information about the specified application package.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application summary list".
        /// Lists all of the applications available in the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSummaryList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch application summary show".
        /// Gets information about the specified application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSummaryShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch certificate create".
        /// Add a certificate to a Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch certificate delete".
        /// Delete a certificate from a Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch certificate list".
        /// Lists all of the Certificates that have been added to the specified Account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch certificate show".
        /// Gets information about the specified Certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job create".
        /// Add a job to a Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job delete".
        /// Deletes a Job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job disable".
        /// Disables the specified Job, preventing new Tasks from running.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job enable".
        /// Enables the specified Job, allowing new Tasks to run.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job list".
        /// List all of the jobs or job schedule in a Batch account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job reset".
        /// Update the properties of a Batch job. Unspecified properties which can be updated are reset to their defaults.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job set".
        /// Update the properties of a Batch job. Updating a property in a subgroup will reset the unspecified properties of that group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job show".
        /// Gets information about the specified Job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job stop".
        /// Terminates the specified Job, marking it as completed.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job all-statistics show".
        /// Get lifetime summary statistics for all of the jobs in a Batch account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobAllStatisticsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job prep-release-status list".
        /// Lists the execution status of the Job Preparation and Job Release Task for the specified Job across the Compute Nodes where the Job has run.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobPrepReleaseStatusList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job task-counts show".
        /// Gets the Task counts for the specified Job.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobTaskCountsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule create".
        /// Add a Batch job schedule to an account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule delete".
        /// Deletes a Job Schedule from the specified Account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule disable".
        /// Disables a Job Schedule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule enable".
        /// Enables a Job Schedule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule list".
        /// Lists all of the Job Schedules in the specified Account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule reset".
        /// Reset the properties of a job schedule.  An updated job specification only applies to new jobs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule set".
        /// Update the properties of a job schedule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule show".
        /// Gets information about the specified Job Schedule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch job-schedule stop".
        /// Terminates a Job Schedule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch location quotas show".
        /// Gets the Batch service quotas for the specified subscription at the given location.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchLocationQuotasShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node delete".
        /// Removes Compute Nodes from the specified Pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node list".
        /// Lists the Compute Nodes in the specified Pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node reboot".
        /// Restarts the specified Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeReboot(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node reimage".
        /// Reinstalls the operating system on the specified Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeReimage(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node show".
        /// Gets information about the specified Compute Node.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node file delete".
        /// Deletes the specified file from the Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node file download".
        /// Download the content of the a node file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node file list".
        /// Lists all of the files in Task directories on the specified Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node file show".
        /// Gets the properties of the specified Compute Node file.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node remote-desktop download".
        /// Gets the Remote Desktop Protocol file for the specified Compute Node.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeRemoteDesktopDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node remote-login-settings show".
        /// Gets the settings required for remote login to a Compute Node.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeRemoteLoginSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node scheduling disable".
        /// Disables Task scheduling on the specified Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeSchedulingDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node scheduling enable".
        /// Enables Task scheduling on the specified Compute Node.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeSchedulingEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node service-logs upload".
        /// Upload Azure Batch service log files from the specified Compute Node to Azure Blob Storage.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeServiceLogsUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node user create".
        /// Add a user account to a Batch compute node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node user delete".
        /// Deletes a user Account from the specified Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch node user reset".
        /// Update the properties of a user account on a Batch compute node. Unspecified properties which can be updated are reset to their defaults.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool create".
        /// Create a Batch pool in an account. When creating a pool, choose arguments from either Cloud Services Configuration or Virtual Machine Configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool delete".
        /// Deletes a Pool from the specified Account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool list".
        /// Lists all of the Pools in the specified Account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool reset".
        /// Update the properties of a Batch pool. Unspecified properties which can be updated are reset to their defaults.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool resize".
        /// Resize or stop resizing a Batch pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolResize(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool set".
        /// Update the properties of a Batch pool. Updating a property in a subgroup will reset the unspecified properties of that group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool show".
        /// Gets information about the specified Pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool all-statistics show".
        /// Get lifetime summary statistics for all of the pools in a Batch account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAllStatisticsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool autoscale disable".
        /// Disables automatic scaling for a Pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool autoscale enable".
        /// Enables automatic scaling for a Pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool autoscale evaluate".
        /// Gets the result of evaluating an automatic scaling formula on the Pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleEvaluate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool node-counts list".
        /// Gets the number of Compute Nodes in each state, grouped by Pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolNodeCountsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool supported-images list".
        /// Lists all Virtual Machine Images supported by the Azure Batch service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolSupportedImagesList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch pool usage-metrics list".
        /// Lists the usage metrics, aggregated by Pool across individual time intervals, for the specified Account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolUsageMetricsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task create".
        /// Create Batch tasks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task delete".
        /// Deletes a Task from the specified Job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task list".
        /// Lists all of the Tasks that are associated with the specified Job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task reactivate".
        /// Reactivates a Task, allowing it to run again even if its retry count has been exhausted.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskReactivate(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task reset".
        /// Reset the properties of a Batch task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task show".
        /// Gets information about the specified Task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task stop".
        /// Terminates the specified Task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task file delete".
        /// Deletes the specified Task file from the Compute Node where the Task ran.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task file download".
        /// Download the content of a Batch task file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task file list".
        /// Lists the files in a Task's directory on its Compute Node.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task file show".
        /// Gets the properties of the specified Task file.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az batch task subtask list".
        /// Lists all of the subtasks that are associated with the specified multi-instance Task.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskSubtaskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing enrollment-account list".
        /// Lists the enrollment accounts the caller has access to.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingEnrollmentAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing enrollment-account show".
        /// Gets a enrollment account by name.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingEnrollmentAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing invoice list".
        /// List all available invoices of the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingInvoiceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing invoice show".
        /// Retrieve invoice of specific name of the subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingInvoiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing period list".
        /// Lists the available billing periods for a subscription in reverse chronological order.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingPeriodList(this ICakeContext context) {
        }

        /// <summary>
        /// "az billing period show".
        /// Gets a named billing period.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingPeriodShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot create".
        /// Create a new v4 SDK bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot delete".
        /// Delete an existing bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot download".
        /// Download an existing bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot prepare-deploy".
        /// Add scripts/config files for publishing with `az webapp deployment`.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPrepareDeploy(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot prepare-publish".
        /// (Maintenance mode) Add scripts to your local source code directory to be able to publish back using `az bot publish` for v3 SDK bots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPreparePublish(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot publish".
        /// Publish to a bot's associated app service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPublish(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot show".
        /// Get an existing bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot update".
        /// Update an existing bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot authsetting create".
        /// Create an OAuth connection setting on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot authsetting delete".
        /// Delete an OAuth connection setting on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot authsetting list".
        /// Show all OAuth connection settings on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot authsetting list-providers".
        /// List details for all service providers available for creating OAuth connection settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingListProviders(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot authsetting show".
        /// Show details of an OAuth connection setting on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot directline create".
        /// Create the DirectLine Channel on a bot with only v3 protocol enabled.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot directline delete".
        /// Delete the Directline Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot directline show".
        /// Get details of the Directline Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot email create".
        /// Create the Email Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot email delete".
        /// Delete the email Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot email show".
        /// Get details of the email Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot facebook create".
        /// Create the Facebook Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot facebook delete".
        /// Delete the Facebook Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot facebook show".
        /// Get details of the Facebook Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot kik create".
        /// Create the Kik Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot kik delete".
        /// Delete the Kik Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot kik show".
        /// Get details of the Kik Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot msteams create".
        /// Create the Microsoft Teams Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot msteams delete".
        /// Delete the Microsoft Teams Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot msteams show".
        /// Get details of the Microsoft Teams Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot skype create".
        /// Create the Skype Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot skype delete".
        /// Delete the Skype Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot skype show".
        /// Get details of the Skype Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot slack create".
        /// Create the Slack Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot slack delete".
        /// Delete the Slack Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot slack show".
        /// Get details of the Slack Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot sms create".
        /// Create the SMS Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot sms delete".
        /// Delete the SMS Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot sms show".
        /// Get details of the SMS Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot telegram create".
        /// Create the Telegram Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot telegram delete".
        /// Delete the Telegram Channel on a bot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot telegram show".
        /// Get details of the Telegram Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az bot webchat show".
        /// Get details of the Webchat Channel on a bot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotWebchatShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cache delete".
        /// Delete an object from the cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cache list".
        /// List the contents of the object cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cache purge".
        /// Clear the entire CLI object cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCachePurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az cache show".
        /// Show the contents of a specific object in the cache.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn name-exists".
        /// Check the availability of a resource name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnNameExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn usage".
        /// Check the quota and actual usage of the CDN profiles under the given subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain create".
        /// Create a new custom domain to provide a hostname for a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain delete".
        /// Delete the custom domain of a CDN.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain disable-https".
        /// Disable https delivery of the custom domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainDisableHttps(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain enable-https".
        /// Enable https delivery of the custom domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainEnableHttps(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain list".
        /// Lists all of the existing custom domains within an endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn custom-domain show".
        /// Show details for the custom domain of a CDN.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn edge-node list".
        /// Edgenodes are the global Point of Presence (POP) locations used to deliver CDN content to end users.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEdgeNodeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint create".
        /// Create a named endpoint to connect to a CDN.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint delete".
        /// Delete a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint list".
        /// List available endpoints for a CDN.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint load".
        /// Pre-load content for a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointLoad(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint purge".
        /// Purge pre-loaded content for a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointPurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint show".
        /// Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint start".
        /// Start a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint stop".
        /// Stop a CDN endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint update".
        /// Update a CDN endpoint to manage how content is delivered.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn endpoint validate-custom-domain".
        /// Validates the custom domain mapping to ensure it maps to the correct CDN endpoint in DNS.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointValidateCustomDomain(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn origin list".
        /// Lists all of the existing origins within an endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnOriginList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn origin show".
        /// Gets an existing origin within an endpoint.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnOriginShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile create".
        /// Create a new CDN profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile delete".
        /// Delete a CDN profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile list".
        /// List CDN profiles.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile show".
        /// Gets a CDN profile with the specified profile name under the specified subscription and resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile update".
        /// Update a CDN profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cdn profile usage".
        /// Checks the quota and actual usage of endpoints under the given CDN profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud list".
        /// List registered clouds.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud list-profiles".
        /// List the supported profiles for a cloud.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudListProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud register".
        /// Register a cloud.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudRegister(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud set".
        /// Set the active cloud.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud show".
        /// Get the details of a registered cloud.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud unregister".
        /// Unregister a cloud.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// "az cloud update".
        /// Update the configuration of a cloud.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account create".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account delete".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account list".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account list-kinds".
        /// List all valid kinds for Azure Cognitive Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListKinds(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account list-skus".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account list-usage".
        /// List usages for Azure Cognitive Services account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account show".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account update".
        /// Manage Azure Cognitive Services accounts.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account keys list".
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account keys regenerate".
        /// Manage Azure Cognitive Services accounts.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountKeysRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account network-rule add".
        /// Add a network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account network-rule list".
        /// List network rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cognitiveservices account network-rule remove".
        /// Remove a network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption budget create".
        /// Create a budget for an Azure subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption budget delete".
        /// Delete a budget for an Azure subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption budget list".
        /// List budgets for an Azure subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption budget show".
        /// Show budget for an Azure subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption marketplace list".
        /// List the marketplace for an Azure subscription within a billing period.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionMarketplaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption pricesheet show".
        /// Show the price sheet for an Azure subscription within a billing period.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionPricesheetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption reservation detail list".
        /// List the details of a reservation by order id or reservation id.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionReservationDetailList(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption reservation summary list".
        /// List reservation summaries for daily or monthly by order Id or reservation id.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionReservationSummaryList(this ICakeContext context) {
        }

        /// <summary>
        /// "az consumption usage list".
        /// List the details of Azure resource consumption, either as an invoice or within a billing period.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionUsageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az container attach".
        /// Attach local standard output and error streams to a container in a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerAttach(this ICakeContext context) {
        }

        /// <summary>
        /// "az container create".
        /// Create a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az container delete".
        /// Delete a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az container exec".
        /// Execute a command from within a running container of a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerExec(this ICakeContext context) {
        }

        /// <summary>
        /// "az container export".
        /// Export a container group in yaml format.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az container list".
        /// List container groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az container logs".
        /// Examine the logs for a container in a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerLogs(this ICakeContext context) {
        }

        /// <summary>
        /// "az container restart".
        /// Restarts all containers in a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az container show".
        /// Get the details of a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az container start".
        /// Starts all containers in a container group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az container stop".
        /// Stops all containers in a container group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb check-name-exists".
        /// Checks if an Azure Cosmos DB account name exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCheckNameExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb create".
        /// Creates a new Azure Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb delete".
        /// Deletes an Azure Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb failover-priority-change".
        /// Changes the failover priority for the Azure Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbFailoverPriorityChange(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb list".
        /// List Azure Cosmos DB database accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb show".
        /// Get the details of an Azure Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb update".
        /// Update an Azure Cosmos DB database account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace create".
        /// Create an Cassandra keyspace under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace delete".
        /// Delete the Cassandra keyspace under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace list".
        /// List the Cassandra keyspaces under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace show".
        /// Show the details of a Cassandra keyspace under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace throughput show".
        /// Get the throughput of the Cassandra keyspace under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra keyspace throughput update".
        /// Update the throughput of the Cassandra keyspace under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table create".
        /// Create an Cassandra table under an Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table delete".
        /// Delete the Cassandra table under an Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table list".
        /// List the Cassandra tables under an Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table show".
        /// Show the details of a Cassandra table under an Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table update".
        /// Update an Cassandra table under an Azure Cosmos DB Cassandra keyspace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table throughput show".
        /// Get the throughput of the Cassandra table under an Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb cassandra table throughput update".
        /// Update the throughput of the Cassandra table under an Azure Cosmos DB Cassandra keyspace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection create".
        /// Creates an Azure Cosmos DB collection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection delete".
        /// Deletes an Azure Cosmos DB collection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection exists".
        /// Returns a boolean indicating whether the collection exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection list".
        /// Lists all Azure Cosmos DB collections.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection show".
        /// Shows an Azure Cosmos DB collection and its offer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb collection update".
        /// Updates an Azure Cosmos DB collection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb database create".
        /// Creates an Azure Cosmos DB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb database delete".
        /// Deletes an Azure Cosmos DB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb database exists".
        /// Returns a boolean indicating whether the database exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb database list".
        /// Lists all Azure Cosmos DB databases.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb database show".
        /// Shows an Azure Cosmos DB database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database create".
        /// Create an Gremlin database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database delete".
        /// Delete the Gremlin database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database list".
        /// List the Gremlin databases under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database show".
        /// Show the details of a Gremlin database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database throughput show".
        /// Get the throughput of the Gremlin database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin database throughput update".
        /// Update the throughput of the Gremlin database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph create".
        /// Create an Gremlin graph under an Azure Cosmos DB Gremlin database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph delete".
        /// Delete the Gremlin graph under an Azure Cosmos DB Gremlin database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph list".
        /// List the Gremlin graphs under an Azure Cosmos DB Gremlin database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph show".
        /// Show the details of a Gremlin graph under an Azure Cosmos DB Gremlin database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph update".
        /// Update an Gremlin graph under an Azure Cosmos DB Gremlin database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph throughput show".
        /// Get the throughput of the Gremlin graph under an Azure Cosmos DB Gremlin database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb gremlin graph throughput update".
        /// Update the throughput of the Gremlin graph under an Azure Cosmos DB Gremlin database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb keys list".
        /// List the access keys or connection strings for a Azure Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb keys regenerate".
        /// Regenerates an access key for the specified Azure Cosmos DB database account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbKeysRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection create".
        /// Create an MongoDB collection under an Azure Cosmos DB MongoDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection delete".
        /// Delete the MongoDB collection under an Azure Cosmos DB MongoDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection list".
        /// List the MongoDB collections under an Azure Cosmos DB MongoDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection show".
        /// Show the details of a MongoDB collection under an Azure Cosmos DB MongoDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection update".
        /// Update an MongoDB collection under an Azure Cosmos DB MongoDB database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection throughput show".
        /// Get the throughput of the MongoDB collection under an Azure Cosmos DB MongoDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb collection throughput update".
        /// Update the throughput of the MongoDB collection under an Azure Cosmos DB MongoDB database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database create".
        /// Create an MongoDB database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database delete".
        /// Delete the MongoDB database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database list".
        /// List the MongoDB databases under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database show".
        /// Show the details of a MongoDB database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database throughput show".
        /// Get the throughput of the MongoDB database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb mongodb database throughput update".
        /// Update the throughput of the MongoDB database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb network-rule add".
        /// Adds a virtual network rule to an existing Cosmos DB database account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb network-rule list".
        /// Lists the virtual network accounts associated with a Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb network-rule remove".
        /// Adds a virtual network rule to an existing Cosmos DB database account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container create".
        /// Create an SQL container under an Azure Cosmos DB SQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container delete".
        /// Delete the SQL container under an Azure Cosmos DB SQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container list".
        /// List the SQL containers under an Azure Cosmos DB SQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container show".
        /// Show the details of a SQL container under an Azure Cosmos DB SQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container update".
        /// Update an SQL container under an Azure Cosmos DB SQL database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container throughput show".
        /// Get the throughput of the SQL container under an Azure Cosmos DB SQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql container throughput update".
        /// Update the throughput of the SQL container under an Azure Cosmos DB SQL database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database create".
        /// Create an SQL database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database delete".
        /// Delete the SQL database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database list".
        /// List the SQL databases under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database show".
        /// Show the details of a SQL database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database throughput show".
        /// Get the throughput of the SQL database under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb sql database throughput update".
        /// Update the throughput of the SQL database under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table create".
        /// Create an Table under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table delete".
        /// Delete the Table under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table list".
        /// List the Tables under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableList(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table show".
        /// Show the details of a Table under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table throughput show".
        /// Get the throughput of the Table under an Azure Cosmos DB account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az cosmosdb table throughput update".
        /// Update the throughput of the Table under an Azure Cosmos DB account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment create".
        /// Start a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment delete".
        /// Delete a deployment at subscription scope.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment export".
        /// Export the template used for a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment list".
        /// List deployments at subscription scope.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment show".
        /// Show a deployment at subscription scope.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment validate".
        /// Validate whether a template is syntactically correct.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentValidate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment wait".
        /// Place the CLI in a waiting state until a deployment condition is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment operation list".
        /// List a deployment's operations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az deployment operation show".
        /// Get a deployment's operation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager artifact-source create".
        /// Creates an artifact source.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager artifact-source delete".
        /// Deletes an artifact source.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager artifact-source show".
        /// Get the details of an artifact source.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager artifact-source update".
        /// Updates an artifact source.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager rollout delete".
        /// Deletes a rollout resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager rollout restart".
        /// Restarts the rollout.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager rollout show".
        /// Gets the rollout.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager rollout stop".
        /// Stop the rollout.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service create".
        /// Creates a service under the specified service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service delete".
        /// Deletes the service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service show".
        /// Get the details of a service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service update".
        /// Updates the service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-topology create".
        /// Creates a service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-topology delete".
        /// Deletes the service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-topology show".
        /// Get the details of a service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-topology update".
        /// Updates the service topology.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-unit create".
        /// Creates a service unit under the specified service and service topology.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-unit delete".
        /// Deletes the service unit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-unit show".
        /// Get the details of a service unit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager service-unit update".
        /// Updates the service unit.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager step create".
        /// Creates the step.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager step delete".
        /// Deletes the step.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager step show".
        /// Get the details of the step.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az deploymentmanager step update".
        /// Updates the step.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk create".
        /// Create a managed disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk delete".
        /// Delete a managed disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk grant-access".
        /// Grant a resource access to a managed disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskGrantAccess(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk list".
        /// List managed disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk revoke-access".
        /// Revoke a resource's read access to a managed disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskRevokeAccess(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk show".
        /// Gets information about a disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk update".
        /// Update a managed disk.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az disk wait".
        /// Place the CLI in a waiting state until a condition of a managed disk is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account create".
        /// Create a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account delete".
        /// Delete a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account list".
        /// List available Data Lake Analytics accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account show".
        /// Get the details of a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account update".
        /// Update a Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account blob-storage add".
        /// Links an Azure Storage account to the specified Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account blob-storage delete".
        /// Updates the specified Data Lake Analytics account to remove an Azure Storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account blob-storage list".
        /// Gets the first page of Azure Storage accounts, if any, linked to the specified Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account blob-storage show".
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account blob-storage update".
        /// Updates an Azure Storage account linked to the specified Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account compute-policy create".
        /// Create a compute policy in the Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account compute-policy delete".
        /// Delete a compute policy in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account compute-policy list".
        /// List compute policies in the a Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account compute-policy show".
        /// Retrieve a compute policy in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account compute-policy update".
        /// Update a compute policy in the Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account data-lake-store add".
        /// Updates the specified Data Lake Analytics account to include the additional Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account data-lake-store delete".
        /// Updates the Data Lake Analytics account specified to remove the specified Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account data-lake-store list".
        /// Gets the first page of Data Lake Store accounts linked to the specified Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account data-lake-store show".
        /// Gets the specified Data Lake Store account details in the specified Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account firewall create".
        /// Create a firewall rule in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account firewall delete".
        /// Delete a firewall rule in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account firewall list".
        /// List firewall rules in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account firewall show".
        /// Retrieve a firewall rule in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla account firewall update".
        /// Update a firewall rule in a Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog assembly list".
        /// Retrieves the list of assemblies from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogAssemblyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog assembly show".
        /// Retrieves the specified assembly from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogAssemblyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog credential create".
        /// Create a new catalog credential for use with an external data source.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog credential delete".
        /// Delete a catalog credential.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog credential list".
        /// List catalog credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog credential show".
        /// Retrieve a catalog credential.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog credential update".
        /// Update a catalog credential for use with an external data source.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog database list".
        /// Retrieves the list of databases from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog database show".
        /// Retrieves the specified database from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog external-data-source list".
        /// Retrieves the list of external data sources from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogExternalDataSourceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog external-data-source show".
        /// Retrieves the specified external data source from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogExternalDataSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog package list".
        /// Retrieves the list of packages from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogPackageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog package show".
        /// Retrieves the specified package from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogPackageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog procedure list".
        /// Retrieves the list of procedures from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogProcedureList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog procedure show".
        /// Retrieves the specified procedure from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogProcedureShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog schema list".
        /// Retrieves the list of schemas from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogSchemaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog schema show".
        /// Retrieves the specified schema from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogSchemaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table list".
        /// List tables in a database or schema.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table show".
        /// Retrieves the specified table from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-partition list".
        /// Retrieves the list of table partitions from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTablePartitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-partition show".
        /// Retrieves the specified table partition from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTablePartitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-stats list".
        /// List table statistics in a database, table, or schema.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableStatsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-stats show".
        /// Retrieves the specified table statistics from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableStatsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-type list".
        /// Retrieves the list of table types from the Data Lake Analytics catalog.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableTypeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog table-type show".
        /// Retrieves the specified table type from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableTypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog tvf list".
        /// List table valued functions in a database or schema.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTvfList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog tvf show".
        /// Retrieves the specified table valued function from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTvfShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog view list".
        /// List views in a database or schema.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogViewList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla catalog view show".
        /// Retrieves the specified view from the Data Lake Analytics catalog.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogViewShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job cancel".
        /// Cancel a Data Lake Analytics job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job list".
        /// List Data Lake Analytics jobs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job show".
        /// Get information for a Data Lake Analytics job.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job submit".
        /// Submit a job to a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobSubmit(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job wait".
        /// Wait for a Data Lake Analytics job to finish.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job pipeline list".
        /// List job pipelines in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobPipelineList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job pipeline show".
        /// Retrieve a job pipeline in a Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobPipelineShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job recurrence list".
        /// List job recurrences in a Data Lake Analytics account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobRecurrenceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dla job recurrence show".
        /// Retrieve a job recurrence in a Data Lake Analytics account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobRecurrenceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account create".
        /// Creates a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account delete".
        /// Delete a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account enable-key-vault".
        /// Enable the use of Azure Key Vault for encryption of a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountEnableKeyVault(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account list".
        /// Lists available Data Lake Store accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account show".
        /// Get the details of a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account update".
        /// Updates a Data Lake Store account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account firewall create".
        /// Creates a firewall rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account firewall delete".
        /// Deletes a firewall rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account firewall list".
        /// Lists firewall rules in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account firewall show".
        /// Get the details of a firewall rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account firewall update".
        /// Updates a firewall rule in a Data Lake Store account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account network-rule create".
        /// Creates a virtual network rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account network-rule delete".
        /// Deletes a virtual network rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account network-rule list".
        /// Lists virtual network rules in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account network-rule show".
        /// Get the details of a virtual network rule in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account network-rule update".
        /// Updates a virtual network rule in a Data Lake Store account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account trusted-provider create".
        /// Creates or updates the specified trusted identity provider.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account trusted-provider delete".
        /// Deletes the specified trusted identity provider from the specified Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account trusted-provider list".
        /// Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account trusted-provider show".
        /// Gets the specified Data Lake Store trusted identity provider.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls account trusted-provider update".
        /// Updates the specified trusted identity provider.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs append".
        /// Append content to a file in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAppend(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs create".
        /// Creates a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs delete".
        /// Delete a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs download".
        /// Download a file or folder from a Data Lake Store account to the local machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs join".
        /// Join files in a Data Lake Store account into one file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsJoin(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs list".
        /// List the files and folders in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs move".
        /// Move a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsMove(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs preview".
        /// Preview the content of a file in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsPreview(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs remove-expiry".
        /// Remove the expiration time for a file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsRemoveExpiry(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs set-expiry".
        /// Set the expiration time for a file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsSetExpiry(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs show".
        /// Get file or folder information in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs test".
        /// Test for the existence of a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsTest(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs upload".
        /// Upload a file or folder to a Data Lake Store account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access remove-all".
        /// Remove the access control list for a file or folder.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessRemoveAll(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access remove-entry".
        /// Remove entries for the access control list of a file or folder.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessRemoveEntry(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access set".
        /// Replace the existing access control list for a file or folder.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access set-entry".
        /// Update the access control list for a file or folder.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetEntry(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access set-owner".
        /// Set the owner information for a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetOwner(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access set-permission".
        /// Set the permissions for a file or folder in a Data Lake Store account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetPermission(this ICakeContext context) {
        }

        /// <summary>
        /// "az dls fs access show".
        /// Display the access control list (ACL).  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms check-name".
        /// Check if a given DMS instance name is available in a given region as well as the name's validity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms check-status".
        /// Perform a health check and return the status of the service and virtual machine size.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCheckStatus(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms create".
        /// Create an instance of the Data Migration Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms delete".
        /// Delete an instance of the Data Migration Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms list".
        /// List the DMS instances within your currently configured subscription (to set this use "az account set"). If provided, only show the instances within a given resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms list-skus".
        /// List the SKUs that are supported by the Data Migration Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms show".
        /// Show the details for an instance of the Data Migration Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms start".
        /// Start an instance of the Data Migration Service. It can then be used to run data migrations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms stop".
        /// Stop an instance of the Data Migration Service. While stopped, it can't be used to run data migrations and the owner won't be billed.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms wait".
        /// Place the CLI in a waiting state until a condition of the DMS instance is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project check-name".
        /// Check if a given Project name is available within a given instance of DMS as well as the name's validity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project create".
        /// Create a migration Project which can contain multiple Tasks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project delete".
        /// Delete a Project.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project list".
        /// List the Projects within an instance of DMS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project show".
        /// Show the details of a migration Project.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task cancel".
        /// Cancel a Task if it's currently queued or running.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task check-name".
        /// Check if a given Task name is available within a given instance of DMS as well as the name's validity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task create".
        /// Create and start a migration Task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task delete".
        /// Delete a migration Task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task list".
        /// List the Tasks within a Project. Some tasks may have a status of Unknown, which indicates that an error occurred while querying the status of that task.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az dms project task show".
        /// Show the details of a migration Task. Use the "--expand" to get more details.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain create".
        /// Create a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain delete".
        /// Delete a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain list".
        /// List available domains.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain show".
        /// Get the details of a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain update".
        /// Update a domain.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain key list".
        /// List shared access keys of a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain key regenerate".
        /// Regenerate a shared access key of a domain.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainKeyRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain topic create".
        /// Create a domain topic under a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain topic delete".
        /// Delete a domain topic under a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain topic list".
        /// List available topics in a domain.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid domain topic show".
        /// Get the details of a domain topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid event-subscription create".
        /// Create a new event subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid event-subscription delete".
        /// Delete an event subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid event-subscription list".
        /// List event subscriptions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid event-subscription show".
        /// Get the details of an event subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid event-subscription update".
        /// Update an event subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic create".
        /// Create a topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic delete".
        /// Delete a topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic list".
        /// List available topics.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic show".
        /// Get the details of a topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic update".
        /// Update a topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic key list".
        /// List shared access keys of a topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic key regenerate".
        /// Regenerate a shared access key of a topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicKeyRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic-type list".
        /// List registered topic types.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic-type list-event-types".
        /// List the event types supported by a topic type.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeListEventTypes(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventgrid topic-type show".
        /// Get the details for a topic type.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub create".
        /// Creates the EventHubs Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub delete".
        /// Deletes the Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub list".
        /// List the EventHub by Namepsace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub show".
        /// Shows the Eventhub Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub update".
        /// Updates the EventHubs Eventhub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule create".
        /// Creates Authorizationrule for the given Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule delete".
        /// Deletes the Authorizationrule of Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule list".
        /// Shows the list of Authorization-rules by Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule show".
        /// Shows the details of Authorizationrule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule update".
        /// Updates Authorizationrule for the given Eventhub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule keys list".
        /// Shows the connection strings of Authorizationrule for the Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub authorization-rule keys renew".
        /// Regenerate the connection strings of Authorizationrule for the namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub consumer-group create".
        /// Creates the EventHub ConsumerGroup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub consumer-group delete".
        /// Deletes the ConsumerGroup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub consumer-group list".
        /// List the ConsumerGroup by Eventhub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub consumer-group show".
        /// Shows the ConsumerGroup Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs eventhub consumer-group update".
        /// Updates the EventHub ConsumerGroup.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias break-pair".
        /// Disables Geo-Disaster Recovery Configuration Alias and stops replicating changes from primary to secondary namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasBreakPair(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias delete".
        /// Delete Geo-Disaster Recovery Configuration Alias.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias exists".
        /// Check the availability of Geo-Disaster Recovery Configuration Alias Name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias fail-over".
        /// Invokes Geo-Disaster Recovery Configuration Alias to point to the secondary namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasFailOver(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias list".
        /// Gets all Alias(Disaster Recovery configurations).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias set".
        /// Sets a Geo-Disaster Recovery Configuration Alias for the give Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias show".
        /// Shows properties of Geo-Disaster Recovery Configuration Alias for Primay or Secondary Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias authorization-rule list".
        /// List of Authorizationrule by EventHubs Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias authorization-rule show".
        /// Show properties of EventHubs Geo-Disaster Recovery Configuration Alias and Namespace Authorizationrule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs georecovery-alias authorization-rule keys list".
        /// Shows the keys and connection strings of Authorizationrule for the EventHubs Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace create".
        /// Creates the EventHubs Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace delete".
        /// Deletes the Namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace exists".
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace list".
        /// Lists the EventHubs Namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace show".
        /// Shows the Event Hubs Namespace Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace update".
        /// Updates the EventHubs Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule create".
        /// Creates Authorizationrule for the given Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule delete".
        /// Deletes the Authorizationrule of the namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule list".
        /// Shows the list of Authorizationrule by Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule show".
        /// Shows the details of Authorizationrule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule update".
        /// Updates Authorizationrule for the given Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule keys list".
        /// Shows the connection strings for namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace authorization-rule keys renew".
        /// Regenerate the connection strings of Authorizationrule for the namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace network-rule add".
        /// Add a network rule for a namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace network-rule list".
        /// Show properties of Network rule of the given Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az eventhubs namespace network-rule remove".
        /// Remove network rule for a namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension add".
        /// Add an extension.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension list".
        /// List the installed extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension list-available".
        /// List publicly available extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionListAvailable(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension remove".
        /// Remove an extension.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension show".
        /// Show an extension.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az extension update".
        /// Update an extension.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az feature list".
        /// List preview features.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureList(this ICakeContext context) {
        }

        /// <summary>
        /// "az feature register".
        /// Register a preview feature.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureRegister(this ICakeContext context) {
        }

        /// <summary>
        /// "az feature show".
        /// Gets the preview feature with the specified name.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp create".
        /// Create a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp delete".
        /// Delete a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp list".
        /// List function apps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp list-consumption-locations".
        /// List available locations for running function apps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappListConsumptionLocations(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp restart".
        /// Restart a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp show".
        /// Get the details of a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp start".
        /// Start a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp stop".
        /// Stop a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp update".
        /// Update a function app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config set".
        /// Set the function app's configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config show".
        /// Get the details of a function app's configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config access-restriction add".
        /// Adds an Access Restriction to the functionapp, or updates if the Action of the Ip- Address or Subnet already exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config access-restriction remove".
        /// Removes an Access Restriction from the functionapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config access-restriction set".
        /// Sets if SCM site is using the same restrictions as the main site.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config access-restriction show".
        /// Show Access Restriction settings for functionapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config appsettings delete".
        /// Delete a function app's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config appsettings list".
        /// Show settings for a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config appsettings set".
        /// Update a function app's settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config container delete".
        /// Delete a function app container's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config container set".
        /// Set a function app container's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config container show".
        /// Get details of a function app container's settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config hostname add".
        /// Bind a hostname to a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config hostname delete".
        /// Unbind a hostname from a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config hostname get-external-ip".
        /// Get the external-facing IP address for a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameGetExternalIp(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config hostname list".
        /// List all hostname bindings for a function app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config ssl bind".
        /// Bind an SSL certificate to a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslBind(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config ssl delete".
        /// Delete an SSL certificate from a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config ssl list".
        /// List SSL certificates for a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config ssl unbind".
        /// Unbind an SSL certificate from a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslUnbind(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp config ssl upload".
        /// Upload an SSL certificate to a function app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp cors add".
        /// Add allowed origins.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp cors remove".
        /// Remove allowed origins.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp cors show".
        /// Show allowed origins.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment list-publishing-credentials".
        /// Get the details for available function app publishing credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentListPublishingCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment list-publishing-profiles".
        /// Get the details for available function app deployment profiles.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentListPublishingProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment container config".
        /// Configure continuous deployment via containers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentContainerConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment container show-cd-url".
        /// Get the URL which can be used to configure webhooks for continuous deployment.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentContainerShowCdUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment slot auto-swap".
        /// Configure deployment slot auto swap.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotAutoSwap(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment slot create".
        /// Create a deployment slot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment slot delete".
        /// Delete a deployment slot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment slot list".
        /// List all deployment slots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment slot swap".
        /// Change deployment slots for a function app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotSwap(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source config".
        /// Manage deployment from git or Mercurial repositories.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source config-local-git".
        /// Get a URL for a git repository endpoint to clone and push to for function app deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfigLocalGit(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source config-zip".
        /// Perform deployment using the kudu zip push deployment for a function app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfigZip(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source delete".
        /// Delete a source control deployment configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source show".
        /// Get the details of a source control deployment configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source sync".
        /// Synchronize from the repository. Only needed under manual integration mode.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceSync(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment source update-token".
        /// Update source control token cached in Azure app service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceUpdateToken(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment user set".
        /// Update deployment credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentUserSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp deployment user show".
        /// Gets publishing user.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp devops-pipeline create".
        /// Create an Azure DevOps pipeline for a function app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDevopsPipelineCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp hybrid-connection add".
        /// Add a hybrid-connection to a functionapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp hybrid-connection list".
        /// List the hybrid-connections on a functionapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp hybrid-connection remove".
        /// Remove a hybrid-connection from a functionapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp identity assign".
        /// Assign or disable managed service identity to the web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp identity remove".
        /// Disable web app's managed service identity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp identity show".
        /// Display web app's managed service identity.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp plan create".
        /// Create an App Service Plan for an Azure Function.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp plan delete".
        /// Delete an App Service Plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp plan list".
        /// List App Service Plans.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp plan show".
        /// Get the App Service Plans for a resource group or a set of resource groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp plan update".
        /// Update an App Service plan for an Azure Function.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp vnet-integration add".
        /// Add a regional virtual network integration to a functionapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp vnet-integration list".
        /// List the virtual network integrations on a functionapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az functionapp vnet-integration remove".
        /// Remove a regional virtual network integration from functionapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az group create".
        /// Create a new resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az group delete".
        /// Delete a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az group exists".
        /// Check if a resource group exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az group export".
        /// Captures a resource group as a template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az group list".
        /// List resource groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az group show".
        /// Gets a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az group update".
        /// Update a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az group wait".
        /// Place the CLI in a waiting state until a condition of the resource group is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment create".
        /// Start a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment delete".
        /// Deletes a deployment from the deployment history.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment export".
        /// Export the template used for a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment list".
        /// Get all the deployments for a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment show".
        /// Gets a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment validate".
        /// Validate whether a template is syntactically correct.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentValidate(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment wait".
        /// Place the CLI in a waiting state until a deployment condition is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment operation list".
        /// Gets all deployments operations for a deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az group deployment operation show".
        /// Get a deployment's operation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az group lock create".
        /// Create a resource group lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az group lock delete".
        /// Delete a resource group lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az group lock list".
        /// List lock information in the resource-group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockList(this ICakeContext context) {
        }

        /// <summary>
        /// "az group lock show".
        /// Show the details of a resource group lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az group lock update".
        /// Update a resource group lock.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight create".
        /// Create a new cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight delete".
        /// Deletes the specified HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight list".
        /// List HDInsight clusters in a resource group or subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightList(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight list-usage".
        /// Lists the usages for the specified location.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight resize".
        /// Resizes the specified HDInsight cluster to the specified size.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightResize(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight rotate-disk-encryption-key".
        /// Rotate the disk encryption key of the specified HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightRotateDiskEncryptionKey(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight show".
        /// Gets the specified cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight update".
        /// Patch HDInsight cluster with the specified parameters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight wait".
        /// Place the CLI in a waiting state until an operation is complete.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight application create".
        /// Create an application for a HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight application delete".
        /// Deletes the specified application on the HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight application list".
        /// Lists all of the applications for the HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight application show".
        /// Gets properties of the specified application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight application wait".
        /// Place the CLI in a waiting state until an operation is complete.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight monitor disable".
        /// Disable the Azure Monitor logs integration on an HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight monitor enable".
        /// Enable the Azure Monitor logs integration on an HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight monitor show".
        /// Get the status of Azure Monitor logs integration on an HDInsight cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action delete".
        /// Deletes a specified persisted script action of the cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action execute".
        /// Execute script actions on the specified HDInsight cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionExecute(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action list".
        /// Lists all the persisted script actions for the specified cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action list-execution-history".
        /// Lists all scripts' execution history for the specified cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionListExecutionHistory(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action promote".
        /// Promotes the specified ad-hoc script execution to a persisted script.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionPromote(this ICakeContext context) {
        }

        /// <summary>
        /// "az hdinsight script-action show-execution-details".
        /// Gets the script execution detail for the given script execution ID.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionShowExecutionDetails(this ICakeContext context) {
        }

        /// <summary>
        /// "az identity create".
        /// Create or update an identity in the specified subscription and resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az identity delete".
        /// Deletes the identity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az identity list".
        /// List Managed Service Identities.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityList(this ICakeContext context) {
        }

        /// <summary>
        /// "az identity list-operations".
        /// Lists available operations for the Managed Identity provider.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityListOperations(this ICakeContext context) {
        }

        /// <summary>
        /// "az identity show".
        /// Gets the identity.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az image create".
        /// Create a custom Virtual Machine Image from managed disks or snapshots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az image delete".
        /// Deletes an Image.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az image list".
        /// List custom VM images.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az image show".
        /// Gets an image.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az image update".
        /// Update custom VM images.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template create".
        /// Create an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template delete".
        /// Delete image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template list".
        /// List image builder templates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template run".
        /// Build an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateRun(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template show".
        /// Show an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template show-runs".
        /// Show an image builder template's run outputs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateShowRuns(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template update".
        /// Update an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template wait".
        /// Place the CLI in a waiting state until a condition of the template is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template customizer add".
        /// Add an image builder customizer to an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template customizer clear".
        /// Remove all image builder customizers from an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template customizer remove".
        /// Remove an image builder customizer from an image builder template.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template output add".
        /// Add an image builder output distributor to an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template output clear".
        /// Remove all image builder output distributors from an image builder template.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az image template output remove".
        /// Remove an image builder output distributor from an image builder template.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps create".
        /// Create an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps delete".
        /// Delete an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps list".
        /// List Azure IoT Hub device provisioning services.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps show".
        /// Get the details of an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps update".
        /// Update an Azure IoT Hub device provisioning service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps access-policy create".
        /// Create a new shared access policy in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps access-policy delete".
        /// Delete a shared access policies in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps access-policy list".
        /// List all shared access policies in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps access-policy show".
        /// Show details of a shared access policies in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps access-policy update".
        /// Update a shared access policy in an Azure IoT Hub device provisioning service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate create".
        /// Create/upload an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate delete".
        /// Delete an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate generate-verification-code".
        /// Generate a verification code for an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateGenerateVerificationCode(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate list".
        /// List all certificates contained within an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate show".
        /// Show information about a particular Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate update".
        /// Update an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps certificate verify".
        /// Verify an Azure IoT Hub Device Provisioning Service certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateVerify(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps linked-hub create".
        /// Create a linked IoT hub in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps linked-hub delete".
        /// Update a linked IoT hub in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps linked-hub list".
        /// List all linked IoT hubs in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps linked-hub show".
        /// Show details of a linked IoT hub in an Azure IoT Hub device provisioning service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot dps linked-hub update".
        /// Update a linked IoT hub in an Azure IoT Hub device provisioning service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub create".
        /// Create an Azure IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub delete".
        /// Delete an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub list".
        /// List IoT hubs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub list-skus".
        /// List available pricing tiers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub manual-failover".
        /// Initiate a manual failover for the IoT Hub to the geo-paired disaster recovery region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubManualFailover(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub show".
        /// Get the details of an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub show-connection-string".
        /// Show the connection strings for an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub show-quota-metrics".
        /// Get the quota metrics for an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowQuotaMetrics(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub show-stats".
        /// Get the statistics for an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowStats(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub update".
        /// Update metadata for an IoT hub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate create".
        /// Create/upload an Azure IoT Hub certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate delete".
        /// Deletes an Azure IoT Hub certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate generate-verification-code".
        /// Generates a verification code for an Azure IoT Hub certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateGenerateVerificationCode(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate list".
        /// Lists all certificates contained within an Azure IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate show".
        /// Shows information about a particular Azure IoT Hub certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate update".
        /// Update an Azure IoT Hub certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub certificate verify".
        /// Verifies an Azure IoT Hub certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateVerify(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub consumer-group create".
        /// Create an event hub consumer group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub consumer-group delete".
        /// Delete an event hub consumer group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub consumer-group list".
        /// List event hub consumer groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub consumer-group show".
        /// Get the details for an event hub consumer group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub devicestream show".
        /// Get IoT Hub's device streams endpoints.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubDevicestreamShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub job cancel".
        /// Cancel a job in an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub job list".
        /// List the jobs in an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub job show".
        /// Get the details of a job in an IoT hub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub message-enrichment create".
        /// Create a message enrichment for chosen endpoints in your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub message-enrichment delete".
        /// Delete a message enrichment in your IoT hub (by key).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub message-enrichment list".
        /// Get information on all message enrichments for your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub message-enrichment update".
        /// Update a message enrichment in your IoT hub (by key).  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub policy create".
        /// Create a new shared access policy in an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub policy delete".
        /// Delete a shared access policy from an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub policy list".
        /// List shared access policies of an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub policy renew-key".
        /// Regenerate keys of a shared access policy of an IoT hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyRenewKey(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub policy show".
        /// Get the details of a shared access policy of an IoT hub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route create".
        /// Create a route in IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route delete".
        /// Delete all or mentioned route for your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route list".
        /// Get all the routes in IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route show".
        /// Get information about the route in IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route test".
        /// Test all routes or mentioned route in IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteTest(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub route update".
        /// Update a route in IoT Hub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub routing-endpoint create".
        /// Add an endpoint to your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub routing-endpoint delete".
        /// Delete all or mentioned endpoint for your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub routing-endpoint list".
        /// Get information on all the endpoints for your IoT Hub.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot hub routing-endpoint show".
        /// Get information on mentioned endpoint for your IoT Hub.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp key create".
        /// Create a key for the given repository.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp key delete".
        /// Delete a key from the given repository.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp key list".
        /// List repository's keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp key show".
        /// Get the details of a repository key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp key update".
        /// Update the key for the given repository.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository create".
        /// Create an IoT Plug and Play repository.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository delete".
        /// Delete an IoT Plug and Play repository.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository get-provision-status".
        /// Returns the IoT Plug and Play repository provisioning status.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryGetProvisionStatus(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository list".
        /// List IoT Plug and Play repositories.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository show".
        /// Gets the details for an IoT Plug and Play repository.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iot pnp repository update".
        /// Update an IoT Plug and Play repository.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iotcentral app create".
        /// Create an IoT Central application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az iotcentral app delete".
        /// Delete an IoT Central application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az iotcentral app list".
        /// List IoT Central applications.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppList(this ICakeContext context) {
        }

        /// <summary>
        /// "az iotcentral app show".
        /// Get the details of an IoT Central application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az iotcentral app update".
        /// Update metadata for an IoT Central application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault create".
        /// Create a key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault delete".
        /// Delete a key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault delete-policy".
        /// Delete security policy settings for a Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultDeletePolicy(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault list".
        /// List key vaults.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault list-deleted".
        /// Gets information about the deleted vaults in a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault purge".
        /// Permanently deletes the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultPurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault recover".
        /// Recover a key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault set-policy".
        /// Update security policy settings for a Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSetPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault show".
        /// Show details of a key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault update".
        /// Update the properties of a key vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate create".
        /// Create a Key Vault certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate delete".
        /// Deletes a certificate from a specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate download".
        /// Download the public portion of a Key Vault certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate get-default-policy".
        /// Get the default policy for self-signed certificates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateGetDefaultPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate import".
        /// Import a certificate into KeyVault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate list".
        /// List certificates in a specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate list-deleted".
        /// Lists the deleted certificates in the specified vault currently available for recovery.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate list-versions".
        /// List the versions of a certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate purge".
        /// Permanently deletes the specified deleted certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate recover".
        /// Recovers the deleted certificate back to its current version under /certificates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate set-attributes".
        /// Updates the specified attributes associated with the given certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateSetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate show".
        /// Gets information about a certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate show-deleted".
        /// Retrieves information about the specified deleted certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate contact add".
        /// Add a contact to the specified vault to receive notifications of certificate operations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate contact delete".
        /// Remove a certificate contact from the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate contact list".
        /// Lists the certificate contacts for a specified key vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer create".
        /// Create a certificate issuer record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer delete".
        /// Deletes the specified certificate issuer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer list".
        /// List certificate issuers for a specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer show".
        /// Lists the specified certificate issuer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer update".
        /// Update a certificate issuer record.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer admin add".
        /// Add admin details for a specified certificate issuer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer admin delete".
        /// Remove admin details for the specified certificate issuer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate issuer admin list".
        /// List admins for a specified certificate issuer.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate pending delete".
        /// Deletes the creation operation for a specific certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate pending merge".
        /// Merges a certificate or a certificate chain with a key pair existing on the server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingMerge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault certificate pending show".
        /// Gets the creation operation of a certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key backup".
        /// Requests that a backup of the specified key be downloaded to the client.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyBackup(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key create".
        /// Creates a new key, stores it, then returns key parameters and attributes to the client.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key delete".
        /// Deletes a key of any type from storage in Azure Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key import".
        /// Import a private key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key list".
        /// List keys in the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key list-deleted".
        /// Lists the deleted keys in the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key list-versions".
        /// Retrieves a list of individual key versions with the same key name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key purge".
        /// Permanently deletes the specified key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyPurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key recover".
        /// Recovers the deleted key to its latest version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key restore".
        /// Restores a backed up key to a vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key set-attributes".
        /// The update key operation changes specified attributes of a stored key and can be applied to any key type and key version stored in Azure Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeySetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key show".
        /// Gets the public part of a stored key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault key show-deleted".
        /// Gets the public part of a deleted key.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault network-rule add".
        /// Add a network rule to the network ACLs for a Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault network-rule list".
        /// Lists the network rules from the network ACLs for a Key Vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault network-rule remove".
        /// Removes a network rule from the network ACLs for a Key Vault.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret backup".
        /// Backs up the specified secret.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretBackup(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret delete".
        /// Deletes a secret from a specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret download".
        /// Download a secret from a KeyVault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret list".
        /// List secrets in a specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret list-deleted".
        /// Lists deleted secrets for the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret list-versions".
        /// List all versions of the specified secret.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret purge".
        /// Permanently deletes the specified secret.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretPurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret recover".
        /// Recovers the deleted secret to the latest version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret restore".
        /// Restores a backed up secret to a vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret set".
        /// Create a secret (if one doesn't exist) or update a secret in a KeyVault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret set-attributes".
        /// Updates the attributes associated with a specified secret in a given key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretSetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret show".
        /// Get a specified secret from a given key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault secret show-deleted".
        /// Gets the specified deleted secret.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage add".
        /// Creates or updates a new storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage backup".
        /// Backs up the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageBackup(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage list".
        /// List storage accounts managed by the specified key vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage list-deleted".
        /// Lists deleted storage accounts for the specified vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage purge".
        /// Permanently deletes the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStoragePurge(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage recover".
        /// Recovers the deleted storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage regenerate-key".
        /// Regenerates the specified key value for the given storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRegenerateKey(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage remove".
        /// Deletes a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage restore".
        /// Restores a backed up storage account to a vault.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage show".
        /// Gets information about a specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage show-deleted".
        /// Gets the specified deleted storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage update".
        /// Updates the specified attributes associated with the given storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition create".
        /// Creates or updates a new SAS definition for the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition delete".
        /// Deletes a SAS definition from a specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition list".
        /// List storage SAS definitions for the given storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition list-deleted".
        /// Lists deleted SAS definitions for the specified vault and storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition recover".
        /// Recovers the deleted SAS definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionRecover(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition show".
        /// Gets information about a SAS definition for the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition show-deleted".
        /// Gets the specified deleted sas definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az keyvault storage sas-definition update".
        /// Updates the specified attributes associated with the given SAS definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster create".
        /// Create a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster delete".
        /// Delete a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster list".
        /// List a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster show".
        /// Get a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster start".
        /// Start a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster stop".
        /// Stop a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster update".
        /// Update a Kusto cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto cluster wait".
        /// Wait for a managed Kusto cluster to reach a desired state.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database create".
        /// Create a Kusto database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database delete".
        /// Delete a Kusto database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database list".
        /// List a Kusto database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database show".
        /// Get a Kusto database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database update".
        /// Update a Kusto database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az kusto database wait".
        /// Wait for a managed Kusto database to reach a desired state.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab delete".
        /// Delete lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab get".
        /// Get lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabGet(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab arm-template list".
        /// List azure resource manager templates in a given artifact source.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArmTemplateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab arm-template show".
        /// Get the details of an ARM template in a lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArmTemplateShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab artifact list".
        /// List artifacts in a given artifact source.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab artifact-source list".
        /// List artifact sources in a given lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactSourceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab artifact-source show".
        /// Get artifact source.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab custom-image create".
        /// Create a custom image in a DevTest Lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab custom-image delete".
        /// Delete custom image.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab custom-image list".
        /// List custom images in a given lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab custom-image show".
        /// Get custom image.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab environment create".
        /// Create an environment in a lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab environment delete".
        /// Delete an environment from a lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab environment list".
        /// List environments in a lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab environment show".
        /// Get the details for an environment of a lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab formula delete".
        /// Delete formula.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab formula export-artifacts".
        /// Export artifacts from a formula.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaExportArtifacts(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab formula list".
        /// List formulas in a given lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab formula show".
        /// Show formulae from an Azure DevTest Lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab gallery-image list".
        /// List gallery images in a given lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabGalleryImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab secret delete".
        /// Delete secret.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab secret list".
        /// List secrets in a given user profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab secret set".
        /// Set a secret for a lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab secret show".
        /// Get secret.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm apply-artifacts".
        /// Apply artifacts to a virtual machine in Azure DevTest Lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmApplyArtifacts(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm claim".
        /// Claim a virtual machine from the Lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmClaim(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm create".
        /// Create a VM in a lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm delete".
        /// Delete virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm list".
        /// List the VMs in an Azure DevTest Lab.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm show".
        /// Get virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm start".
        /// Start a virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vm stop".
        /// Stop a virtual machine This operation can take a while to complete.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vnet get".
        /// Get virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVnetGet(this ICakeContext context) {
        }

        /// <summary>
        /// "az lab vnet list".
        /// List virtual networks in a given lab.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lock create".
        /// Create a lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az lock delete".
        /// Delete a lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az lock list".
        /// List lock information.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockList(this ICakeContext context) {
        }

        /// <summary>
        /// "az lock show".
        /// Show the properties of a lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az lock update".
        /// Update a lock.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp create".
        /// Create a managed application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp delete".
        /// Delete a managed application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp list".
        /// List managed applications.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappList(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp show".
        /// Gets a managed application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp definition create".
        /// Create a managed application definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp definition delete".
        /// Delete a managed application definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp definition list".
        /// List managed application definitions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedapp definition show".
        /// Gets a managed application definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices assignment create".
        /// Creates a new registration assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices assignment delete".
        /// Deletes the registration assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices assignment list".
        /// List all the registration assignments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices assignment show".
        /// Gets a registration assignment.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices definition create".
        /// Creates a new registration definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices definition delete".
        /// Deletes a registration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices definition list".
        /// List all the registration definitions under the default scope or under the subscription provided.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az managedservices definition show".
        /// Gets a registration definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account create".
        /// Create a maps account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account delete".
        /// Delete a maps account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account list".
        /// Show all maps accounts in a subscription or in a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account show".
        /// Show the details of a maps account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account update".
        /// Update the properties of a maps account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account keys list".
        /// List the keys to use with the Maps APIs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az maps account keys renew".
        /// Renew either the primary or secondary key for use with the Maps APIs.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb db create".
        /// Create a MariaDB database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb db delete".
        /// Delete a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb db list".
        /// List the databases for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb db show".
        /// Show the details of a database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server create".
        /// Create a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server delete".
        /// Delete a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server georestore".
        /// Geo-restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server list".
        /// List available servers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server restart".
        /// Restart a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server restore".
        /// Restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server show".
        /// Get the details of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server update".
        /// Update a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server wait".
        /// Wait for server to satisfy certain conditions.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server configuration list".
        /// List the configuration values for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server configuration set".
        /// Update the configuration of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server configuration show".
        /// Get the configuration for a server.".  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server firewall-rule create".
        /// Create a new firewall rule for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server firewall-rule delete".
        /// Delete a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server firewall-rule list".
        /// List all firewall rules for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server firewall-rule show".
        /// Get the details of a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server firewall-rule update".
        /// Update a firewall rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server replica create".
        /// Create a read replica for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server replica list".
        /// List all read replicas for a given server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server replica stop".
        /// Stop replication to a read replica and make it a read/write server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server vnet-rule create".
        /// Create a virtual network rule to allows access to a MariaDB server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server vnet-rule delete".
        /// Deletes the virtual network rule with the given name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server vnet-rule list".
        /// Gets a list of virtual network rules in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server vnet-rule show".
        /// Gets a virtual network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server vnet-rule update".
        /// Update a virtual network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server-logs download".
        /// Download log files.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az mariadb server-logs list".
        /// List log files for a server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group create".
        /// Create a new action group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group delete".
        /// Delete an action group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group enable-receiver".
        /// Enable a receiver in an action group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupEnableReceiver(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group list".
        /// List action groups under a resource group or the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group show".
        /// Show the details of an action group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor action-group update".
        /// Update an action group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log list".
        /// List and query activity log events.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log list-categories".
        /// List the event categories of activity logs.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogListCategories(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert create".
        /// Create a default activity log alert.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert delete".
        /// Delete an activity log alert.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert list".
        /// List activity log alerts under a resource group or the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert show".
        /// Get an activity log alert.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert update".
        /// Update the details of this activity log alert.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert action-group add".
        /// Add action groups to this activity log alert. It can also be used to overwrite existing webhook properties of particular action groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertActionGroupAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert action-group remove".
        /// Remove action groups from this activity log alert.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertActionGroupRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert scope add".
        /// Add scopes to this activity log alert.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertScopeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor activity-log alert scope remove".
        /// Removes scopes from this activity log alert.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertScopeRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale create".
        /// Create new autoscale settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale delete".
        /// Deletes and autoscale setting.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale list".
        /// Lists the autoscale settings for a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale show".
        /// Show autoscale setting details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale update".
        /// Update autoscale settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale profile create".
        /// Create a fixed or recurring autoscale profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale profile delete".
        /// Delete an autoscale profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale profile list".
        /// List autoscale profiles.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale profile list-timezones".
        /// Look up time zone information.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileListTimezones(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale profile show".
        /// Show details of an autoscale profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale rule copy".
        /// Copy autoscale rules from one profile to another.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleCopy(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale rule create".
        /// Add a new autoscale rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale rule delete".
        /// Remove autoscale rules from a profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor autoscale rule list".
        /// List autoscale rules for a profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings create".
        /// Create diagnostic settings for the specified resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings delete".
        /// Deletes existing diagnostic settings for the specified resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings list".
        /// Gets the active diagnostic settings list for the specified resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings show".
        /// Gets the active diagnostic settings for the specified resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings update".
        /// Update diagnostic settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings categories list".
        /// Lists the diagnostic settings categories for the specified resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCategoriesList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor diagnostic-settings categories show".
        /// Gets the diagnostic settings category for the specified resource.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCategoriesShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace create".
        /// Create a workspace instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace delete".
        /// Delete a workspace instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace get-schema".
        /// Get the schema for a given workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceGetSchema(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace get-shared-keys".
        /// Get the shared keys for a workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceGetSharedKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace list".
        /// Get a list of workspaces under a resource group or a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace list-management-groups".
        /// Get a list of management groups connected to a workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceListManagementGroups(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace list-usages".
        /// Get a list of usage metrics for a workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace show".
        /// Show a workspace instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace update".
        /// Update a workspace instance.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace pack disable".
        /// Disable an intelligence pack for a given workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace pack enable".
        /// Enable an intelligence pack for a given workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-analytics workspace pack list".
        /// List all the intelligence packs possible and whether they are enabled or disabled for a given workspace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-profiles create".
        /// Create a log profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-profiles delete".
        /// Deletes the log profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-profiles list".
        /// List the log profiles.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-profiles show".
        /// Gets the log profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor log-profiles update".
        /// Update a log profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics list".
        /// List the metric values for a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics list-definitions".
        /// Lists the metric definitions for the resource.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsListDefinitions(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics alert create".
        /// Create a metric-based alert rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics alert delete".
        /// Delete a metrics-based alert rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics alert list".
        /// List metric-based alert rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics alert show".
        /// Show a metrics-based alert rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az monitor metrics alert update".
        /// Update a metric-based alert rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql db create".
        /// Create a MySQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql db delete".
        /// Delete a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql db list".
        /// List the databases for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql db show".
        /// Show the details of a database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server create".
        /// Create a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server delete".
        /// Delete a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server georestore".
        /// Geo-restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server list".
        /// List available servers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server restart".
        /// Restart a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server restore".
        /// Restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server show".
        /// Get the details of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server update".
        /// Update a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server wait".
        /// Wait for server to satisfy certain conditions.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server configuration list".
        /// List the configuration values for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server configuration set".
        /// Update the configuration of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server configuration show".
        /// Get the configuration for a server.".  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server firewall-rule create".
        /// Create a new firewall rule for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server firewall-rule delete".
        /// Delete a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server firewall-rule list".
        /// List all firewall rules for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server firewall-rule show".
        /// Get the details of a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server firewall-rule update".
        /// Update a firewall rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server replica create".
        /// Create a read replica for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server replica list".
        /// List all read replicas for a given server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server replica stop".
        /// Stop replication to a read replica and make it a read/write server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server vnet-rule create".
        /// Create a virtual network rule to allows access to a MySQL server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server vnet-rule delete".
        /// Deletes the virtual network rule with the given name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server vnet-rule list".
        /// Gets a list of virtual network rules in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server vnet-rule show".
        /// Gets a virtual network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server vnet-rule update".
        /// Update a virtual network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server-logs download".
        /// Download log files.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az mysql server-logs list".
        /// List log files for a server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles list-mount-targets".
        /// List the mount targets of an Azure NetApp Files (ANF) volume.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesListMountTargets(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account create".
        /// Create a new Azure NetApp Files (ANF) account. Note that active directories are added using the subgroup commands.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account delete".
        /// Delete the specified ANF account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account list".
        /// List ANF accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account show".
        /// Get the specified ANF account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account update".
        /// Set/modify the tags for a specified ANF account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account ad add".
        /// Add an active directory to the account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account ad list".
        /// List the active directories of an account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles account ad remove".
        /// Remove an active directory from the account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles pool create".
        /// Create a new Azure NetApp Files (ANF) pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles pool delete".
        /// Delete the specified ANF pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles pool list".
        /// L:ist the ANF pools for the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles pool show".
        /// Get the specified ANF pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles pool update".
        /// Update the tags of the specified ANF pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles snapshot create".
        /// Create a new Azure NetApp Files (ANF) snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles snapshot delete".
        /// Delete the specified ANF snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles snapshot list".
        /// List the snapshots of an ANF volume.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles snapshot show".
        /// Get the specified ANF snapshot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume create".
        /// Create a new Azure NetApp Files (ANF) volume. Export policies are applied with the subgroup commands but note that volumes are always created with a default export policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume delete".
        /// Delete the specified ANF volume.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume list".
        /// List the ANF Pools for the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume show".
        /// Get the specified ANF volume.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume update".
        /// Update the specified ANF volume with the values provided. Unspecified values will remain unchanged. Export policies are amended/created with the subgroup commands.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume export-policy add".
        /// Add a new rule to the export policy for a volume.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume export-policy list".
        /// List the export policy rules for a volume.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az netappfiles volume export-policy remove".
        /// Remove a rule from the export policy for a volume by rule index. The current rules can be obtained by performing the subgroup list command.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network list-service-tags".
        /// List all service tags which are below to different resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkListServiceTags(this ICakeContext context) {
        }

        /// <summary>
        /// "az network list-usages".
        /// List the number of network resources in a region that are used against a subscription quota.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway create".
        /// Create an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway delete".
        /// Delete an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway list".
        /// List application gateways.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway show".
        /// Get the details of an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway show-backend-health".
        /// Get information on the backend health of an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayShowBackendHealth(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway start".
        /// Start an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway stop".
        /// Stop an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway update".
        /// Update an application gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway wait".
        /// Place the CLI in a waiting state until a condition of the application gateway is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway address-pool create".
        /// Create an address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway address-pool delete".
        /// Delete an address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway address-pool list".
        /// List address pools.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway address-pool show".
        /// Get the details of an address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway address-pool update".
        /// Update an address pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway auth-cert create".
        /// Create an authorization certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway auth-cert delete".
        /// Delete an authorization certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway auth-cert list".
        /// List authorization certificates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway auth-cert show".
        /// Show an authorization certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway auth-cert update".
        /// Update an authorization certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-ip create".
        /// Create a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-ip delete".
        /// Delete a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-ip list".
        /// List frontend IP addresses.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-ip show".
        /// Get the details of a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-ip update".
        /// Update a frontend IP address.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-port create".
        /// Create a frontend port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-port delete".
        /// Delete a frontend port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-port list".
        /// List frontend ports.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-port show".
        /// Get the details of a frontend port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway frontend-port update".
        /// Update a frontend port.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-listener create".
        /// Create an HTTP listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-listener delete".
        /// Delete an HTTP listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-listener list".
        /// List HTTP listeners.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-listener show".
        /// Get the details of an HTTP listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-listener update".
        /// Update an HTTP listener.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-settings create".
        /// Create HTTP settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-settings delete".
        /// Delete HTTP settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-settings list".
        /// List HTTP settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-settings show".
        /// Get the details of a gateway's HTTP settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway http-settings update".
        /// Update HTTP settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway identity assign".
        /// Assign a managed service identity to an application-gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway identity remove".
        /// Remove the managed service identity of an application-gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway identity show".
        /// Show the managed service identity of an application-gateway.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway probe create".
        /// Create a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway probe delete".
        /// Delete a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway probe list".
        /// List probes.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway probe show".
        /// Get the details of a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway probe update".
        /// Update a probe.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway redirect-config create".
        /// Create a redirect configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway redirect-config delete".
        /// Delete a redirect configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway redirect-config list".
        /// List redirect configurations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway redirect-config show".
        /// Get the details of a redirect configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway redirect-config update".
        /// Update a redirect configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule create".
        /// Create a rewrite rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule delete".
        /// Delete a rewrite rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule list".
        /// List rewrite rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule list-request-headers".
        /// Lists all available request headers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleListRequestHeaders(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule list-response-headers".
        /// Lists all available response headers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleListResponseHeaders(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule show".
        /// Get the details of a rewrite rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule update".
        /// Update a rewrite rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition create".
        /// Create a rewrite rule condition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition delete".
        /// Delete a rewrite rule condition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition list".
        /// List rewrite rule conditions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition list-server-variables".
        /// Lists all available server variables.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionListServerVariables(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition show".
        /// Get the details of a rewrite rule condition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule condition update".
        /// Update a rewrite rule condition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule set create".
        /// Create a rewrite rule set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule set delete".
        /// Delete a rewrite rule set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule set list".
        /// List rewrite rule sets.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule set show".
        /// Get the details of a rewrite rule set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rewrite-rule set update".
        /// Update a rewrite rule set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway root-cert create".
        /// Upload a trusted root certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway root-cert delete".
        /// Delete a trusted root certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway root-cert list".
        /// List trusted root certificates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway root-cert show".
        /// Get the details of a trusted root certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway root-cert update".
        /// Update a trusted root certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rule create".
        /// Create a rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rule delete".
        /// Delete a rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rule list".
        /// List rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rule show".
        /// Get the details of a rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway rule update".
        /// Update a rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-cert create".
        /// Upload an SSL certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-cert delete".
        /// Delete an SSL certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-cert list".
        /// List SSL certificates.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-cert show".
        /// Get the details of an SSL certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-cert update".
        /// Update an SSL certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-policy list-options".
        /// Lists available SSL options for configuring SSL policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyListOptions(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-policy set".
        /// Update or clear SSL policy settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicySet(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-policy show".
        /// Get the details of gateway's SSL policy settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-policy predefined list".
        /// Lists all SSL predefined policies for configuring SSL policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyPredefinedList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway ssl-policy predefined show".
        /// Gets SSL predefined policy with the specified policy name.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyPredefinedShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map create".
        /// Create a URL path map.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map delete".
        /// Delete a URL path map.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map list".
        /// List URL path maps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map show".
        /// Get the details of a URL path map.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map update".
        /// Update a URL path map.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map rule create".
        /// Create a rule for a URL path map.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway url-path-map rule delete".
        /// Delete a rule of a URL path map.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-config list-rule-sets".
        /// Get information on available WAF rule sets, rule groups, and rule IDs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigListRuleSets(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-config set".
        /// Update the firewall configuration of a web application.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-config show".
        /// Get the firewall configuration of a web application.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy create".
        /// Create an application gateway WAF policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy delete".
        /// Delete an application gateway WAF policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy list".
        /// List application gateway WAF policies.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy show".
        /// Get the details of an application gateway WAF policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy update".
        /// Update an application gateway WAF policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy wait".
        /// Place the CLI in a waiting state until a condition of the application gateway WAF policy is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule create".
        /// Create an application gateway WAF policy custom rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule delete".
        /// Delete an application gateway WAF policy custom rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule list".
        /// List application gateway WAF policy custom rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule show".
        /// Get the details of an application gateway WAF policy custom rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule update".
        /// Update an application gateway WAF policy custom rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule match-condition add".
        /// A match condition to an application gateway WAF policy custom rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule match-condition list".
        /// List application gateway WAF policy custom rule match conditions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy custom-rule match-condition remove".
        /// Remove a match condition from an application gateway WAF policy custom rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule exclusion add".
        /// Add an OWASP CRS exclusion rule to the WAF policy managed rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule exclusion list".
        /// List all OWASP CRS exclusion rules that are applied on a Waf policy managed rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule exclusion remove".
        /// List all OWASP CRS exclusion rules that are applied on a Waf policy managed rules.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule rule-set add".
        /// Add managed rule set to the WAF policy managed rules. For rule set and rules, please visit: https://docs.microsoft.com/en-us/azure/web-application-firewall/ag/application- gateway-crs-rulegroups-rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule rule-set list".
        /// List all managed rule set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule rule-set remove".
        /// Remove a managed rule set by rule set group name if rule_group_name is specified. Otherwise, remove all rule set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy managed-rule rule-set update".
        /// Update(Override) existing rule set of a WAF policy managed rules. For rule set and rules, please visit: https://docs.microsoft.com/en-us/azure/web-application- firewall/ag/application-gateway-crs-rulegroups-rules.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy policy-setting list".
        /// List properties of a web application firewall global configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyPolicySettingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network application-gateway waf-policy policy-setting update".
        /// Update properties of a web application firewall global configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyPolicySettingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network asg create".
        /// Create an application security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network asg delete".
        /// Delete an application security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network asg list".
        /// List all application security groups in a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network asg show".
        /// Get details of an application security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network asg update".
        /// Update an application security group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network ddos-protection create".
        /// Create a DDoS protection plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network ddos-protection delete".
        /// Delete a DDoS protection plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network ddos-protection list".
        /// List DDoS protection plans.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network ddos-protection show".
        /// Show details of a DDoS protection plan.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network ddos-protection update".
        /// Update a DDoS protection plan.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns list-references".
        /// Returns the DNS records specified by the referencing targetResourceIds.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsListReferences(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set list".
        /// List all record sets within a DNS zone.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a add-record".
        /// Add an A record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a create".
        /// Create an empty A record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetACreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a delete".
        /// Delete an A record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetADelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a list".
        /// List all A record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a remove-record".
        /// Remove an A record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetARemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a show".
        /// Get the details of an A record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set a update".
        /// Update an A record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa add-record".
        /// Add an AAAA record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa create".
        /// Create an empty AAAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa delete".
        /// Delete an AAAA record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa list".
        /// List all AAAA record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa remove-record".
        /// Remove AAAA record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa show".
        /// Get the details of an AAAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set aaaa update".
        /// Update an AAAA record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa add-record".
        /// Add a CAA record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa create".
        /// Create an empty CAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa delete".
        /// Delete a CAA record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa list".
        /// List all CAA record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa remove-record".
        /// Remove a CAA record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa show".
        /// Get the details of a CAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set caa update".
        /// Update a CAA record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname create".
        /// Create an empty CNAME record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname delete".
        /// Delete a CNAME record set and its associated record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname list".
        /// List the CNAME record set in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname remove-record".
        /// Remove a CNAME record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname set-record".
        /// Set the value of a CNAME record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameSetRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set cname show".
        /// Get the details of a CNAME record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx add-record".
        /// Add an MX record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx create".
        /// Create an empty MX record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx delete".
        /// Delete an MX record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx list".
        /// List all MX record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx remove-record".
        /// Remove an MX record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx show".
        /// Get the details of an MX record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set mx update".
        /// Update an MX record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns add-record".
        /// Add an NS record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns create".
        /// Create an empty NS record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns delete".
        /// Delete an NS record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns list".
        /// List all NS record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns remove-record".
        /// Remove an NS record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns show".
        /// Get the details of an NS record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ns update".
        /// Update an NS record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr add-record".
        /// Add a PTR record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr create".
        /// Create an empty PTR record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr delete".
        /// Delete a PTR record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr list".
        /// List all PTR record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr remove-record".
        /// Remove a PTR record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr show".
        /// Get the details of a PTR record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set ptr update".
        /// Update a PTR record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set soa show".
        /// Get the details of an SOA record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSoaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set soa update".
        /// Update properties of an SOA record.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSoaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv add-record".
        /// Add an SRV record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv create".
        /// Create an empty SRV record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv delete".
        /// Delete an SRV record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv list".
        /// List all SRV record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv remove-record".
        /// Remove an SRV record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv show".
        /// Get the details of an SRV record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set srv update".
        /// Update an SRV record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt add-record".
        /// Add a TXT record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt create".
        /// Create an empty TXT record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt delete".
        /// Delete a TXT record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt list".
        /// List all TXT record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt remove-record".
        /// Remove a TXT record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt show".
        /// Get the details of a TXT record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns record-set txt update".
        /// Update a TXT record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone create".
        /// Create a DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone delete".
        /// Delete a DNS zone and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone export".
        /// Export a DNS zone as a DNS zone file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone import".
        /// Create a DNS zone using a DNS zone file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone list".
        /// List DNS zones.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone show".
        /// Get a DNS zone parameters. Does not show DNS records within the zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network dns zone update".
        /// Update a DNS zone properties. Does not modify DNS records within the zone.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route create".
        /// Create an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route delete".
        /// Delete an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route get-stats".
        /// Get the statistics of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGetStats(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route list".
        /// List all ExpressRoute circuits for the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route list-arp-tables".
        /// Show the current Address Resolution Protocol (ARP) table of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListArpTables(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route list-route-tables".
        /// Show the current routing table of an ExpressRoute circuit peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListRouteTables(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route list-service-providers".
        /// List available ExpressRoute service providers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListServiceProviders(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route show".
        /// Get the details of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route update".
        /// Update settings of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route wait".
        /// Place the CLI in a waiting state until a condition of the ExpressRoute is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route auth create".
        /// Create a new link authorization for an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route auth delete".
        /// Delete a link authorization of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route auth list".
        /// List link authorizations of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route auth show".
        /// Get the details of a link authorization of an ExpressRoute circuit.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway create".
        /// Create an ExpressRoute gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway delete".
        /// Delete an ExpressRoute gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway list".
        /// List ExpressRoute gateways.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway show".
        /// Get the details of an ExpressRoute gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway update".
        /// Update settings of an ExpressRoute gateway.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway connection create".
        /// Create an ExpressRoute gateway connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway connection delete".
        /// Delete an ExpressRoute gateway connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway connection list".
        /// List ExpressRoute gateway connections.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway connection show".
        /// Get the details of an ExpressRoute gateway connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route gateway connection update".
        /// Update an ExpressRoute gateway connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering create".
        /// Create peering settings for an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering delete".
        /// Delete peering settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering list".
        /// List peering settings of an ExpressRoute circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering show".
        /// Get the details of an express route peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering update".
        /// Update peering settings of an ExpressRoute circuit.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering connection create".
        /// Create connections between two ExpressRoute circuits.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering connection delete".
        /// Delete an ExpressRoute circuit connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering connection show".
        /// Get the details of an ExpressRoute circuit connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering peer-connection list".
        /// Gets all global reach peer connections associated with a private peering in an express route circuit.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringPeerConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route peering peer-connection show".
        /// Gets the specified Peer Express Route Circuit Connection from the specified express route circuit.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringPeerConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port create".
        /// Create an ExpressRoute port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port delete".
        /// Delete an ExpressRoute port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port list".
        /// List ExpressRoute ports.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port show".
        /// Get the details of an ExpressRoute port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port update".
        /// Update settings of an ExpressRoute port.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port identity assign".
        /// Assign a managed service identity to an ExpressRoute Port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port identity remove".
        /// Remove the managed service identity of an ExpressRoute Port.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port identity show".
        /// Show the managed service identity of an ExpressRoute Port.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port link list".
        /// List ExpressRoute links.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port link show".
        /// Get the details of an ExpressRoute link.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port link update".
        /// Manage MACsec configuration of an ExpressRoute Link.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port location list".
        /// List ExpressRoute port locations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLocationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network express-route port location show".
        /// Get the details of an ExpressRoute port location.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLocationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb create".
        /// Create a load balancer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb delete".
        /// Delete a load balancer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb list".
        /// List load balancers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb show".
        /// Get the details of a load balancer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb update".
        /// Update a load balancer.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb address-pool create".
        /// Create an address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb address-pool delete".
        /// Delete an address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb address-pool list".
        /// List address pools.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb address-pool show".
        /// Get the details of an address pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb frontend-ip create".
        /// Create a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb frontend-ip delete".
        /// Delete a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb frontend-ip list".
        /// List frontend IP addresses.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb frontend-ip show".
        /// Get the details of a frontend IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb frontend-ip update".
        /// Update a frontend IP address.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-pool create".
        /// Create an inbound NAT address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-pool delete".
        /// Delete an inbound NAT address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-pool list".
        /// List inbound NAT address pools.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-pool show".
        /// Get the details of an inbound NAT address pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-pool update".
        /// Update an inbound NAT address pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-rule create".
        /// Create an inbound NAT rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-rule delete".
        /// Delete an inbound NAT rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-rule list".
        /// List inbound NAT rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-rule show".
        /// Get the details of an inbound NAT rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb inbound-nat-rule update".
        /// Update an inbound NAT rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb outbound-rule create".
        /// Create an outbound-rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb outbound-rule delete".
        /// Delete an outbound-rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb outbound-rule list".
        /// List outbound rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb outbound-rule show".
        /// Get the details of an outbound rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb outbound-rule update".
        /// Update an outbound-rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb probe create".
        /// Create a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb probe delete".
        /// Delete a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb probe list".
        /// List probes.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb probe show".
        /// Get the details of a probe.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb probe update".
        /// Update a probe.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb rule create".
        /// Create a load balancing rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb rule delete".
        /// Delete a load balancing rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb rule list".
        /// List load balancing rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb rule show".
        /// Get the details of a load balancing rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network lb rule update".
        /// Update a load balancing rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway create".
        /// Create a local VPN gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway delete".
        /// Delete a local VPN gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway list".
        /// List all local VPN gateways in a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway show".
        /// Get the details of a local VPN gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway update".
        /// Update a local VPN gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network local-gateway wait".
        /// Place the CLI in a waiting state until a condition of the local gateway is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway create".
        /// Create a NAT gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway delete".
        /// Delete a NAT gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway list".
        /// List NAT gateways.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway show".
        /// Show details of a NAT gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway update".
        /// Update a NAT gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nat gateway wait".
        /// Place the CLI in a waiting state until a condition of the NAT gateway is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic create".
        /// Create a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic delete".
        /// Delete a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic list".
        /// List network interfaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic list-effective-nsg".
        /// List all effective network security groups applied to a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicListEffectiveNsg(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic show".
        /// Get the details of a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic show-effective-route-table".
        /// Show the effective route table applied to a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicShowEffectiveRouteTable(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic update".
        /// Update a network interface.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic wait".
        /// Place the CLI in a waiting state until a condition of the network interface is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config create".
        /// Create an IP configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config delete".
        /// Delete an IP configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config list".
        /// List the IP configurations of a NIC.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config show".
        /// Show the details of an IP configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config update".
        /// Update an IP configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config address-pool add".
        /// Add an address pool to an IP configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigAddressPoolAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config address-pool remove".
        /// Remove an address pool of an IP configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigAddressPoolRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config inbound-nat-rule add".
        /// Add an inbound NAT rule to an IP configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigInboundNatRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nic ip-config inbound-nat-rule remove".
        /// Remove an inbound NAT rule of an IP configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigInboundNatRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg create".
        /// Create a network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg delete".
        /// Delete a network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg list".
        /// List network security groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg show".
        /// Get information about a network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg update".
        /// Update a network security group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg rule create".
        /// Create a network security group rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg rule delete".
        /// Delete a network security group rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg rule list".
        /// List all rules in a network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg rule show".
        /// Get the details of a network security group rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network nsg rule update".
        /// Update a network security group rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet create".
        /// Create a virtual network link to the specified Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet delete".
        /// Delete a virtual network link to the specified Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet list".
        /// List the virtual network links to the specified Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet show".
        /// Get a virtual network link to the specified Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet update".
        /// Update a virtual network link's properties. Does not modify virtual network within the link.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns link vnet wait".
        /// Place the CLI in a waiting state until a condition of the virtual network link to the specified Private DNS zone is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set list".
        /// List all record sets within a Private DNS zone.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a add-record".
        /// Add an A record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a create".
        /// Create an empty A record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetACreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a delete".
        /// Delete an A record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetADelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a list".
        /// List all A record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a remove-record".
        /// Remove an A record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetARemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a show".
        /// Get the details of an A record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set a update".
        /// Update an A record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa add-record".
        /// Add an AAAA record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa create".
        /// Create an empty AAAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa delete".
        /// Delete an AAAA record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa list".
        /// List all AAAA record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa remove-record".
        /// Remove AAAA record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa show".
        /// Get the details of an AAAA record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set aaaa update".
        /// Update an AAAA record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname create".
        /// Create an empty CNAME record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname delete".
        /// Delete a CNAME record set and its associated record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname list".
        /// List the CNAME record set in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname remove-record".
        /// Remove a CNAME record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname set-record".
        /// Set the value of a CNAME record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameSetRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname show".
        /// Get the details of a CNAME record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set cname update".
        /// Update a CNAME record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx add-record".
        /// Add an MX record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx create".
        /// Create an empty MX record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx delete".
        /// Delete an MX record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx list".
        /// List all MX record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx remove-record".
        /// Remove an MX record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx show".
        /// Get the details of an MX record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set mx update".
        /// Update an MX record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr add-record".
        /// Add a PTR record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr create".
        /// Create an empty PTR record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr delete".
        /// Delete a PTR record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr list".
        /// List all PTR record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr remove-record".
        /// Remove a PTR record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr show".
        /// Get the details of a PTR record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set ptr update".
        /// Update a PTR record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set soa show".
        /// Get the details of an SOA record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSoaShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set soa update".
        /// Update properties of an SOA record.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSoaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv add-record".
        /// Add an SRV record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv create".
        /// Create an empty SRV record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv delete".
        /// Delete an SRV record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv list".
        /// List all SRV record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv remove-record".
        /// Remove an SRV record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv show".
        /// Get the details of an SRV record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set srv update".
        /// Update an SRV record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt add-record".
        /// Add a TXT record.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt create".
        /// Create an empty TXT record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt delete".
        /// Delete a TXT record set and all associated records.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt list".
        /// List all TXT record sets in a zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt remove-record".
        /// Remove a TXT record from its record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt show".
        /// Get the details of a TXT record set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns record-set txt update".
        /// Update a TXT record set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone create".
        /// Create a Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone delete".
        /// Delete a Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone list".
        /// List Private DNS zones.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone show".
        /// Get a Private DNS zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone update".
        /// Update a Private DNS zone's properties. Does not modify Private DNS records or virtual network links within the zone.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-dns zone wait".
        /// Place the CLI in a waiting state until a condition of the Private DNS zone is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint create".
        /// Create a private endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint delete".
        /// Delete a private endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint list".
        /// List private endpoints.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint list-types".
        /// Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointListTypes(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint show".
        /// Get the details of a private endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-endpoint update".
        /// Update a private endpoint.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service create".
        /// Create a private link service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service delete".
        /// Delete a private link service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service list".
        /// List private link services.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service show".
        /// Get the details of a private link service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service update".
        /// Update a private link service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service connection delete".
        /// Delete a private link service endpoint connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network private-link-service connection update".
        /// Update a private link service endpoint connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network profile delete".
        /// Delete a network profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network profile list".
        /// List network profiles.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network profile show".
        /// Get the details of a network profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip create".
        /// Create a public IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip delete".
        /// Delete a public IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip list".
        /// List public IP addresses.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip show".
        /// Get the details of a public IP address.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip update".
        /// Update a public IP address.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip prefix create".
        /// Create a public IP prefix resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip prefix delete".
        /// Delete a public IP prefix resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip prefix list".
        /// List public IP prefix resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip prefix show".
        /// Get the details of a public IP prefix resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network public-ip prefix update".
        /// Update a public IP prefix resource.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter create".
        /// Create a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter delete".
        /// Delete a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter list".
        /// List route filters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter show".
        /// Get the details of a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter update".
        /// Update a route filter.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule create".
        /// Create a rule in a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule delete".
        /// Delete a rule from a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule list".
        /// List rules in a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule list-service-communities".
        /// Gets all the available BGP service communities.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleListServiceCommunities(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule show".
        /// Get the details of a rule in a route filter.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-filter rule update".
        /// Update a rule in a route filter.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table create".
        /// Create a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table delete".
        /// Delete a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table list".
        /// List route tables.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table show".
        /// Get the details of a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table update".
        /// Update a route table.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table route create".
        /// Create a route in a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table route delete".
        /// Delete a route from a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table route list".
        /// List routes in a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table route show".
        /// Get the details of a route in a route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network route-table route update".
        /// Update a route in a route table.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint list".
        /// List what values of endpoint services are available for use.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy create".
        /// Create a service endpoint policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy delete".
        /// Delete a service endpoint policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy list".
        /// List service endpoint policies.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy show".
        /// Get the details of a service endpoint policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy update".
        /// Update a service endpoint policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy-definition create".
        /// Create a service endpoint policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy-definition delete".
        /// Delete a service endpoint policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy-definition list".
        /// List service endpoint policy definitions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy-definition show".
        /// Get the details of a service endpoint policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network service-endpoint policy-definition update".
        /// Update a service endpoint policy definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint create".
        /// Create a traffic manager endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint delete".
        /// Delete a traffic manager endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint list".
        /// List traffic manager endpoints.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint show".
        /// Get the details of a traffic manager endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint show-geographic-hierarchy".
        /// Get the default geographic hierarchy used by the geographic traffic routing method.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointShowGeographicHierarchy(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager endpoint update".
        /// Update a traffic manager endpoint.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile check-dns".
        /// Check the availability of a relative DNS name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileCheckDns(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile create".
        /// Create a traffic manager profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile delete".
        /// Delete a traffic manager profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile list".
        /// List traffic manager profiles.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile show".
        /// Get the details of a traffic manager profile.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network traffic-manager profile update".
        /// Update a traffic manager profile.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet check-ip-address".
        /// Check if a private IP address is available for use within a virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetCheckIpAddress(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet create".
        /// Create a virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet delete".
        /// Delete a virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet list".
        /// List virtual networks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet list-endpoint-services".
        /// List which services support VNET service tunneling in a given region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetListEndpointServices(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet show".
        /// Get the details of a virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet update".
        /// Update a virtual network.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet peering create".
        /// Create a virtual network peering connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet peering delete".
        /// Delete a peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet peering list".
        /// List peerings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet peering show".
        /// Show details of a peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet peering update".
        /// Update a peering.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet create".
        /// Create a subnet and associate an existing NSG and route table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet delete".
        /// Delete a subnet.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet list".
        /// List the subnets in a virtual network.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet list-available-delegations".
        /// List the services available for subnet delegation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetListAvailableDelegations(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet show".
        /// Show details of a subnet.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet subnet update".
        /// Update a subnet.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway create".
        /// Create a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway delete".
        /// Delete a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway list".
        /// List virtual network gateways.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway list-advertised-routes".
        /// List the routes of a virtual network gateway advertised to the specified peer.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListAdvertisedRoutes(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway list-bgp-peer-status".
        /// Retrieve the status of BGP peers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListBgpPeerStatus(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway list-learned-routes".
        /// This operation retrieves a list of routes the virtual network gateway has learned, including routes learned from BGP peers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListLearnedRoutes(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway reset".
        /// Reset a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway show".
        /// Get the details of a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway update".
        /// Update a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway wait".
        /// Place the CLI in a waiting state until a condition of the virtual network gateway is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway aad assign".
        /// Assign/Update AAD(Azure Active Directory) authentication to a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway aad remove".
        /// Remove AAD(Azure Active Directory) authentication from a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway aad show".
        /// Show AAD(Azure Active Directory) authentication of a virtual network gateway.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway ipsec-policy add".
        /// Add a virtual network gateway IPSec policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway ipsec-policy clear".
        /// Delete all IPsec policies on a virtual network gateway.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway ipsec-policy list".
        /// List IPSec policies associated with a virtual network gateway.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway revoked-cert create".
        /// Revoke a certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRevokedCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway revoked-cert delete".
        /// Delete a revoked certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRevokedCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway root-cert create".
        /// Upload a root certificate.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRootCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway root-cert delete".
        /// Delete a root certificate.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRootCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway vpn-client generate".
        /// Generate VPN client configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayVpnClientGenerate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vnet-gateway vpn-client show-url".
        /// Retrieve a pre-generated VPN client configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayVpnClientShowUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection create".
        /// Create a VPN connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection delete".
        /// Delete a VPN connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection list".
        /// List all VPN connections in a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection show".
        /// Get the details of a VPN connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection update".
        /// Update a VPN connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection ipsec-policy add".
        /// Add a VPN connection IPSec policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection ipsec-policy clear".
        /// Delete all IPsec policies on a VPN connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection ipsec-policy list".
        /// List IPSec policies associated with a VPN connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection shared-key reset".
        /// Reset a VPN connection shared key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyReset(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection shared-key show".
        /// Retrieve a VPN connection shared key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vpn-connection shared-key update".
        /// Update a VPN connection shared key.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter create".
        /// Create a virtual router.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter delete".
        /// Deletes the specified Virtual Router.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter list".
        /// List all virtual routers under a subscription or a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter show".
        /// Gets the specified Virtual Router.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter update".
        /// Update a virtual router.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter peering create".
        /// Create a virtual router peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter peering delete".
        /// Deletes the specified peering from a Virtual Router.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter peering list".
        /// Lists all Virtual Router Peerings in a Virtual Router resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter peering show".
        /// Gets the specified Virtual Router Peering.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network vrouter peering update".
        /// Update a virtual router peering.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher configure".
        /// Configure the Network Watcher service for different regions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher list".
        /// List Network Watchers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher run-configuration-diagnostic".
        /// Run a configuration diagnostic on a target resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherRunConfigurationDiagnostic(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher show-next-hop".
        /// Get information on the 'next hop' of a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowNextHop(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher show-security-group-view".
        /// Get detailed security information on a VM for the currently configured network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowSecurityGroupView(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher show-topology".
        /// Get the network topology of a resource group, virtual network or subnet.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowTopology(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher test-connectivity".
        /// Test if a connection can be established between a Virtual Machine and a given endpoint.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTestConnectivity(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher test-ip-flow".
        /// Test IP flow to/from a VM given the currently configured network security group rules.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTestIpFlow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor create".
        /// Create a connection monitor.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor delete".
        /// Delete a connection monitor for the given region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor list".
        /// List connection monitors for the given region.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor query".
        /// Query a snapshot of the most recent connection state of a connection monitor.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorQuery(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor show".
        /// Shows a connection monitor by name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor start".
        /// Start the specified connection monitor.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher connection-monitor stop".
        /// Stop the specified connection monitor.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher flow-log configure".
        /// Configure flow logging on a network security group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherFlowLogConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher flow-log show".
        /// Get the flow log configuration of a network security group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherFlowLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture create".
        /// Create and start a packet capture session.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture delete".
        /// Delete a packet capture session.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture list".
        /// List all packet capture sessions within a resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureList(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture show".
        /// Show details of a packet capture session.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture show-status".
        /// Show the status of a packet capture session.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureShowStatus(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher packet-capture stop".
        /// Stop a running packet capture session.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher troubleshooting show".
        /// Get the results of the last troubleshooting operation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTroubleshootingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az network watcher troubleshooting start".
        /// Troubleshoot issues with VPN connections or gateway connectivity.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTroubleshootingStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift create".
        /// Create a new managed OpenShift cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift delete".
        /// Delete a managed OpenShift cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift list".
        /// List managed OpenShift clusters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftList(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift scale".
        /// Scale the compute pool in a managed OpenShift cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftScale(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift show".
        /// Show the details for a managed OpenShift cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az openshift wait".
        /// Wait for a managed OpenShift cluster to reach a desired state.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment create".
        /// Create a resource policy assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment delete".
        /// Delete a resource policy assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment list".
        /// List resource policy assignments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment show".
        /// Show a resource policy assignment.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment identity assign".
        /// Add a system assigned identity to a policy assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment identity remove".
        /// Remove a managed identity from a policy assignment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy assignment identity show".
        /// Show a policy assignment's managed identity.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy definition create".
        /// Create a policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy definition delete".
        /// Delete a policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy definition list".
        /// List policy definitions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy definition show".
        /// Show a policy definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy definition update".
        /// Update a policy definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy event list".
        /// List policy events.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyEventList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation cancel".
        /// Cancel a resource policy remediation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation create".
        /// Create a resource policy remediation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation delete".
        /// Delete a resource policy remediation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation list".
        /// List resource policy remediations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation show".
        /// Show a resource policy remediation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy remediation deployment list".
        /// Lists deployments for a resource policy remediation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy set-definition create".
        /// Create a policy set definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy set-definition delete".
        /// Delete a policy set definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy set-definition list".
        /// List policy set definitions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy set-definition show".
        /// Show a policy set definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy set-definition update".
        /// Update a policy set definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy state list".
        /// List policy compliance states.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyStateList(this ICakeContext context) {
        }

        /// <summary>
        /// "az policy state summarize".
        /// Summarize policy compliance states.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyStateSummarize(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres db create".
        /// Create a PostgreSQL database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres db delete".
        /// Delete a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres db list".
        /// List the databases for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres db show".
        /// Show the details of a database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server create".
        /// Create a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server delete".
        /// Delete a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server georestore".
        /// Geo-restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server list".
        /// List available servers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server restart".
        /// Restart a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server restore".
        /// Restore a server from backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server show".
        /// Get the details of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server update".
        /// Update a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server wait".
        /// Wait for server to satisfy certain conditions.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server configuration list".
        /// List the configuration values for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server configuration set".
        /// Update the configuration of a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server configuration show".
        /// Get the configuration for a server.".  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server firewall-rule create".
        /// Create a new firewall rule for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server firewall-rule delete".
        /// Delete a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server firewall-rule list".
        /// List all firewall rules for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server firewall-rule show".
        /// Get the details of a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server firewall-rule update".
        /// Update a firewall rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server replica create".
        /// Create a read replica for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server replica list".
        /// List all read replicas for a given server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server replica stop".
        /// Stop replication to a read replica and make it a read/write server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server vnet-rule create".
        /// Create a virtual network rule to allows access to a PostgreSQL server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server vnet-rule delete".
        /// Deletes the virtual network rule with the given name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server vnet-rule list".
        /// Gets a list of virtual network rules in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server vnet-rule show".
        /// Gets a virtual network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server vnet-rule update".
        /// Update a virtual network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server-logs download".
        /// Download log files.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az postgres server-logs list".
        /// List log files for a server.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ppg create".
        /// Create a proximity placement group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az ppg delete".
        /// Delete a proximity placement group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az ppg list".
        /// List proximity placement groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgList(this ICakeContext context) {
        }

        /// <summary>
        /// "az ppg show".
        /// Get a proximity placement group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az ppg update".
        /// Update a proximity placement group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider list".
        /// Gets all resource providers for a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderList(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider register".
        /// Register a provider.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderRegister(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider show".
        /// Gets the specified resource provider.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider unregister".
        /// Unregister a provider.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider operation list".
        /// Get operations from all providers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az provider operation show".
        /// Get an individual provider's operations.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis create".
        /// Create new Redis Cache instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis delete".
        /// Deletes a Redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis export".
        /// Export data stored in a Redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis force-reboot".
        /// Reboot specified Redis node(s).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisForceReboot(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis import".
        /// Import data into a Redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis list".
        /// List Redis Caches.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisList(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis list-keys".
        /// Retrieve a Redis cache's access keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisListKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis regenerate-keys".
        /// Regenerate Redis cache's access keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisRegenerateKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis show".
        /// Gets a Redis cache (resource description).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis update".
        /// Update a Redis cache.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis firewall-rules create".
        /// Create a redis cache firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis firewall-rules delete".
        /// Deletes a single firewall rule in a specified redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis firewall-rules list".
        /// Gets all firewall rules in the specified redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesList(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis firewall-rules show".
        /// Gets a single firewall rule in a specified redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis firewall-rules update".
        /// Update a redis cache firewall rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis patch-schedule create".
        /// Create patching schedule for Redis cache.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis patch-schedule delete".
        /// Deletes the patching schedule of a redis cache (requires Premium SKU).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis patch-schedule show".
        /// Gets the patching schedule of a redis cache (requires Premium SKU).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis patch-schedule update".
        /// Update the patching schedule for Redis cache.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis server-link create".
        /// Adds a server link to the Redis cache (requires Premium SKU).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis server-link delete".
        /// Deletes the linked server from a redis cache (requires Premium SKU).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis server-link list".
        /// Gets the list of linked servers associated with this redis cache (requires Premium SKU).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// "az redis server-link show".
        /// Gets the detailed information about a linked server of a redis cache (requires Premium SKU).  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco create".
        /// Create the Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco delete".
        /// Deletes the Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco list".
        /// List the Hybrid Connection by Relay Service Namepsace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco show".
        /// Shows the Relay Service Hybrid Connection Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco update".
        /// Updates the Relay Service Hybrid Connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule create".
        /// Create Authorization Rule for given Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule delete".
        /// Deletes the Authorization Rule of the given Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule list".
        /// Shows list of Authorization Rule by Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule show".
        /// Shows the details of Authorization Rule for given Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule update".
        /// Create Authorization Rule for given Relay Service Hybrid Connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for Relay Service Hybrid Connection.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay hyco authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for Relay Service Hybrid Connection.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace create".
        /// Create a Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace delete".
        /// Deletes the Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace exists".
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace list".
        /// List the Relay Service Namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace show".
        /// Shows the Relay Service Namespace details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace update".
        /// Updates a Relay Service Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule create".
        /// Create Authorization Rule for the given Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule delete".
        /// Deletes the Authorization Rule of the Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule list".
        /// Shows the list of Authorization Rule by Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule show".
        /// Shows the details of Relay Service Namespace Authorization Rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule update".
        /// Updates Authorization Rule for the given Relay Service Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for Relay Service Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay namespace authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for the Relay Service Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay create".
        /// Create the Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay delete".
        /// Deletes the Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay list".
        /// List the WCF Relay by Relay Service Namepsace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay show".
        /// Shows the Relay Service WCF Relay Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay update".
        /// Updates existing Relay Service WCF Relay.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule create".
        /// Create Authorization Rule for the given Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule delete".
        /// Delete the Authorization Rule of Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule list".
        /// List of Authorization Rule by Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule show".
        /// Show properties of Authorization Rule for the given Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule update".
        /// Update Authorization Rule for the given Relay Service WCF Relay.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for the given Relay Service WCF Relay.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az relay wcfrelay authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for Relay Service WCF Relay.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations catalog show".
        /// Get catalog of available reservation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsCatalogShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation list".
        /// Get all reservations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation list-history".
        /// Get history of a reservation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationListHistory(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation merge".
        /// Merge two reservations.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationMerge(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation show".
        /// Get details of a reservation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation split".
        /// Split a reservation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationSplit(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation update".
        /// Updates the applied scopes of the reservation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation-order calculate".
        /// Calculate price for a reservation order.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderCalculate(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation-order list".
        /// Get all reservation orders.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderList(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation-order purchase".
        /// Purchase reservation order.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderPurchase(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation-order show".
        /// Get a specific reservation order.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az reservations reservation-order-id list".
        /// Get list of applicable reservation order ids.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderIdList(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource create".
        /// Create a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource delete".
        /// Delete a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource invoke-action".
        /// Invoke an action on the resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceInvokeAction(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource list".
        /// List resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource move".
        /// Moves resources from one resource group to another(can be under different subscription).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceMove(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource show".
        /// Get the details of a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource tag".
        /// Tag a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceTag(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource update".
        /// Update a resource.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource wait".
        /// Place the CLI in a waiting state until a condition of a resources is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource link create".
        /// Create a new link between resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource link delete".
        /// Delete a link between resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource link list".
        /// List resource links.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource link show".
        /// Gets a resource link with the specified ID.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource link update".
        /// Update link between resources.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource lock create".
        /// Create a resource-level lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource lock delete".
        /// Delete a resource-level lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource lock list".
        /// List lock information in the resource-level.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockList(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource lock show".
        /// Show the details of a resource-level lock.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az resource lock update".
        /// Update a resource-level lock.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az role assignment create".
        /// Create a new role assignment for a user, group, or service principal.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az role assignment delete".
        /// Delete role assignments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az role assignment list".
        /// List role assignments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// "az role assignment list-changelogs".
        /// List changelogs for role assignments.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentListChangelogs(this ICakeContext context) {
        }

        /// <summary>
        /// "az role definition create".
        /// Create a custom role definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az role definition delete".
        /// Delete a role definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az role definition list".
        /// List role definitions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az role definition update".
        /// Update a role definition.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az search admin-key renew".
        /// Regenerates either the primary or secondary admin API key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchAdminKeyRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az search admin-key show".
        /// Gets the primary and secondary admin API keys for the specified Azure Search service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchAdminKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az search query-key create".
        /// Generates a new query key for the specified Search service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az search query-key delete".
        /// Deletes the specified query key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az search query-key list".
        /// Returns the list of query API keys for the given Azure Search service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az search service create".
        /// Creates a Search service in the given resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az search service delete".
        /// Deletes a Search service in the given resource group, along with its associated resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az search service list".
        /// Gets a list of all Search services in the given resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az search service show".
        /// Gets the Search service with the given name in the given resource group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az search service update".
        /// Update partition and replica of the given search service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security alert list".
        /// List security alerts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security alert show".
        /// Shows a security alert.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security alert update".
        /// Updates a security alert status.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security auto-provisioning-setting list".
        /// List the auto provisioning settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security auto-provisioning-setting show".
        /// Shows an auto provisioning setting.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security auto-provisioning-setting update".
        /// Updates your automatic provisioning settings on the subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security contact create".
        /// Creates a security contact.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security contact delete".
        /// Deletes a security contact.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az security contact list".
        /// List security contact.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security contact show".
        /// Shows a security contact.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security discovered-security-solution list".
        /// List the discovered security solutions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityDiscoveredSecuritySolutionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security discovered-security-solution show".
        /// Shows a discovered security solution.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityDiscoveredSecuritySolutionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security external-security-solution list".
        /// List the external security solutions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityExternalSecuritySolutionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security external-security-solution show".
        /// Shows an external security solution.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityExternalSecuritySolutionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security jit-policy list".
        /// List your Just in Time network access policies.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityJitPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security jit-policy show".
        /// Shows a Just in Time network access policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityJitPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security location list".
        /// Shows the Azure Security Center Home region location.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityLocationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security location show".
        /// Shows the Azure Security Center Home region location.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityLocationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security pricing create".
        /// Updates the Azure Security Center Pricing tier for the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security pricing list".
        /// Shows the Azure Security Center Pricing tier for the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security pricing show".
        /// Shows the Azure Security Center Pricing tier for the subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security setting list".
        /// List security settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecuritySettingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security setting show".
        /// Shows a security setting.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecuritySettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security task list".
        /// List security tasks (recommendations).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security task show".
        /// Shows a security task (recommendation).  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security topology list".
        /// Shows the network topology in your subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTopologyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security topology show".
        /// Shows the network topology in your subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTopologyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az security workspace-setting create".
        /// Creates a workspace settings in your subscription - these settings let you control which workspace will hold your security data.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az security workspace-setting delete".
        /// Deletes the workspace settings in your subscription - this will make the security events on the subscription be reported to the default workspace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az security workspace-setting list".
        /// Shows the workspace settings in your subscription - these settings let you control which workspace will hold your security data.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingList(this ICakeContext context) {
        }

        /// <summary>
        /// "az security workspace-setting show".
        /// Shows the workspace settings in your subscription - these settings let you control which workspace will hold your security data.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias break-pair".
        /// Disables Service Bus Geo-Disaster Recovery Configuration Alias and stops replicating changes from primary to secondary namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasBreakPair(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias delete".
        /// Deletes Service Bus Geo-Disaster Recovery Configuration Alias request accepted.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias exists".
        /// Check if Geo Recovery Alias Name is available.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias fail-over".
        /// Invokes Service Bus Geo-Disaster Recovery Configuration Alias failover and re-configure the alias to point to the secondary namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasFailOver(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias list".
        /// Gets all Alias(Disaster Recovery configurations).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias set".
        /// Sets Service Bus Geo-Disaster Recovery Configuration Alias for the give Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias show".
        /// Shows properties of Service Bus Geo-Disaster Recovery Configuration Alias for Primay/Secondary Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias authorization-rule list".
        /// Shows the list of Authorization Rule by Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias authorization-rule show".
        /// Gets an authorization rule for a namespace by rule name.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus georecovery-alias authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for the Service Bus Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus migration abort".
        /// Disable the Service Bus Migration of Standard to Premium namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationAbort(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus migration complete".
        /// Completes the Service Bus Migration of Standard to Premium namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationComplete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus migration show".
        /// Shows properties of properties of Service Bus Migration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus migration start".
        /// Create and Start Service Bus Migration of Standard to Premium namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace create".
        /// Create a Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace delete".
        /// Deletes the Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace exists".
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace list".
        /// List the Service Bus Namespaces.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace show".
        /// Shows the Service Bus Namespace details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace update".
        /// Updates a Service Bus Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule create".
        /// Create Authorization Rule for the given Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule delete".
        /// Deletes the Authorization Rule of the Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule list".
        /// Shows the list of Authorization Rule by Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule show".
        /// Shows the details of Service Bus Namespace Authorization Rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule update".
        /// Updates Authorization Rule for the given Service Bus Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for Service Bus Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for the Service Bus Namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace network-rule add".
        /// Add a network rule for a namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace network-rule list".
        /// Show properties of Network rule of the given Namespace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus namespace network-rule remove".
        /// Remove network rule for a namespace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue create".
        /// Create the Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue delete".
        /// Deletes the Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue list".
        /// List the Queue by Service Bus Namepsace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue show".
        /// Shows the Service Bus Queue Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue update".
        /// Updates existing Service Bus Queue.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule create".
        /// Create Authorization Rule for the given Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule delete".
        /// Delete the Authorization Rule of Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule list".
        /// List of Authorization Rule by Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule show".
        /// Show properties of Authorization Rule for the given Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule update".
        /// Update Authorization Rule for the given Service Bus Queue.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for the given Service Bus Queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus queue authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for Service Bus Queue.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic create".
        /// Create the Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic delete".
        /// Deletes the Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic list".
        /// List the Topic by Service Bus Namepsace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic show".
        /// Shows the Service Bus Topic Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic update".
        /// Updates the Service Bus Topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule create".
        /// Create Authorization Rule for given Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule delete".
        /// Deletes the Authorization Rule of the given Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule list".
        /// Shows list of Authorization Rule by Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule show".
        /// Shows the details of Authorization Rule for given Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule update".
        /// Create Authorization Rule for given Service Bus Topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule keys list".
        /// List the keys and connection strings of Authorization Rule for Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic authorization-rule keys renew".
        /// Regenerate keys of Authorization Rule for Service Bus Topic.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription create".
        /// Create the ServiceBus Subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription delete".
        /// Deletes the Service Bus Subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription list".
        /// List the Subscription by Service Bus Topic.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription show".
        /// Shows Service Bus Subscription Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription update".
        /// Updates the ServiceBus Subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription rule create".
        /// Create the ServiceBus Rule for Subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription rule delete".
        /// Deletes the ServiceBus Rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription rule list".
        /// List the ServiceBus Rule by Subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription rule show".
        /// Shows ServiceBus Rule Details.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az servicebus topic subscription rule update".
        /// Updates the ServiceBus Rule for Subscription.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf application certificate add".
        /// Add a new certificate to the Virtual Machine Scale Sets that make up the cluster to be used by hosted applications.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfApplicationCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster create".
        /// Create a new Azure Service Fabric cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster list".
        /// List cluster resources.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster show".
        /// Get cluster resource.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster certificate add".
        /// Add a secondary cluster certificate to the cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster certificate remove".
        /// Remove a certificate from a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCertificateRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster client-certificate add".
        /// Add a common name or certificate thumbprint to the cluster for client authentication.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterClientCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster client-certificate remove".
        /// Remove client certificates or subject names used for authentication.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterClientCertificateRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster durability update".
        /// Update the durability tier or VM SKU of a node type in the cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterDurabilityUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster node add".
        /// Add nodes to a node type in a cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster node remove".
        /// Remove nodes from a node type in a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster node-type add".
        /// Add a new node type to a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeTypeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster reliability update".
        /// Update the reliability tier for the primary node in a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterReliabilityUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster setting remove".
        /// Remove settings from a cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterSettingRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster setting set".
        /// Update the settings of a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterSettingSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sf cluster upgrade-type set".
        /// Change the  upgrade type for a cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterUpgradeTypeSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig create".
        /// Create a share image gallery.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig delete".
        /// Delete a Shared Image Gallery.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig list".
        /// List share image galleries.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig show".
        /// Retrieves information about a Shared Image Gallery.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig update".
        /// Update a share image gallery.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-definition create".
        /// Create a gallery image definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-definition delete".
        /// Delete a gallery image.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-definition list".
        /// List gallery Image Definitions in a gallery.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-definition show".
        /// Retrieves information about a gallery Image Definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-definition update".
        /// Update a share image defintiion.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version create".
        /// Create a new image version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version delete".
        /// Delete a gallery Image Version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version list".
        /// List gallery Image Versions in a gallery Image Definition.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version show".
        /// Retrieves information about a gallery Image Version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version update".
        /// Update a share image version.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sig image-version wait".
        /// Wait for image version related operation.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr create".
        /// Creates a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr delete".
        /// Deletes a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr list".
        /// Lists all the SignalR Service under the current subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrList(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr restart".
        /// Restart an existing SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr show".
        /// Get the details of a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr update".
        /// Update an existing SignalR Service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr cors add".
        /// Add allowed origins to a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr cors list".
        /// List allowed origins of a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr cors remove".
        /// Remove allowed origins from a SignalR Service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr key list".
        /// List the access keys for a SignalR Service.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az signalr key renew".
        /// Regenerate the access key for a SignalR Service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrKeyRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot create".
        /// Create a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot delete".
        /// Deletes a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot grant-access".
        /// Grant read access to a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotGrantAccess(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot list".
        /// List snapshots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot revoke-access".
        /// Revoke read access to a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotRevokeAccess(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot show".
        /// Gets information about a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot update".
        /// Update a snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az snapshot wait".
        /// Place the CLI in a waiting state until a condition of a snapshot is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql list-usages".
        /// Gets all subscription usage metrics in a given location.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql show-usage".
        /// Gets a subscription usage metric.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db copy".
        /// Create a copy of a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbCopy(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db create".
        /// Create a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db delete".
        /// Delete a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db export".
        /// Export a database to a bacpac.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbExport(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db import".
        /// Imports a bacpac into an existing database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbImport(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db list".
        /// List databases a server or elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db list-deleted".
        /// Gets a list of deleted databases that can be restored.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db list-editions".
        /// Show database editions available for the currently active subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListEditions(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db list-usages".
        /// Returns database usages.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db rename".
        /// Rename a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbRename(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db restore".
        /// Create a new database by restoring from a backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db show".
        /// Get the details for a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db show-connection-string".
        /// Generates a connection string to a database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db update".
        /// Update a database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db audit-policy show".
        /// Gets a database's blob auditing policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbAuditPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db audit-policy update".
        /// Update a database's auditing policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbAuditPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db op cancel".
        /// Cancels the asynchronous operation on the database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbOpCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db op list".
        /// Gets a list of operations performed on the database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbOpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db replica create".
        /// Create a database as a readable secondary replica of an existing database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db replica delete-link".
        /// Permanently stop data replication between two database replicas.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaDeleteLink(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db replica list-links".
        /// List the replicas of a database and their replication status.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaListLinks(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db replica set-primary".
        /// Set the primary replica database by failing over from the current primary replica database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db tde list-activity".
        /// Returns a database's transparent data encryption operation result.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeListActivity(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db tde set".
        /// Sets a database's transparent data encryption configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db tde show".
        /// Gets a database's transparent data encryption configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db threat-policy show".
        /// Gets a database's threat detection policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbThreatPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql db threat-policy update".
        /// Update a database's threat detection policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbThreatPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw create".
        /// Create a data warehouse.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw delete".
        /// Delete a data warehouse.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw list".
        /// List data warehouses for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw pause".
        /// Pauses a datawarehouse.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwPause(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw resume".
        /// Resumes a datawarehouse.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwResume(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw show".
        /// Get the details for a data warehouse.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql dw update".
        /// Update a data warehouse.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool create".
        /// Create an elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool delete".
        /// Deletes an elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool list".
        /// Gets all elastic pools in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool list-dbs".
        /// Gets a list of databases in an elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolListDbs(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool list-editions".
        /// List elastic pool editions available for the active subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolListEditions(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool show".
        /// Gets an elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool update".
        /// Update an elastic pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool op cancel".
        /// Cancels the asynchronous operation on the elastic pool.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolOpCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql elastic-pool op list".
        /// Gets a list of operations performed on the elastic pool.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolOpList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group create".
        /// Creates a failover group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group delete".
        /// Deletes a failover group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group list".
        /// Lists the failover groups in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group set-primary".
        /// Set the primary of the failover group by failing over all databases from the current primary server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group show".
        /// Gets a failover group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql failover-group update".
        /// Updates the failover group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql instance-failover-group create".
        /// Creates an instance failover group between two connected managed instances.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql instance-failover-group delete".
        /// Deletes a failover group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql instance-failover-group set-primary".
        /// Set the primary of the instance failover group by failing over all databases from the current primary managed instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql instance-failover-group show".
        /// Gets a failover group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql instance-failover-group update".
        /// Updates the instance failover group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi create".
        /// Create a managed instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi delete".
        /// Delete a managed instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi list".
        /// List available managed instances.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi show".
        /// Get the details for a managed instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi update".
        /// Update a managed instance.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi ad-admin create".
        /// Creates a new managed instance Active Directory administrator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi ad-admin delete".
        /// Deletes an existing managed instance Active Directory Administrator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi ad-admin list".
        /// Returns a list of managed instance Active Directory Administrators.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi ad-admin update".
        /// Updates an existing managed instance Active Directory administrator.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi key create".
        /// Creates a SQL Instance key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi key delete".
        /// Deletes a SQL Instance key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi key list".
        /// Gets a list of managed instance keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi key show".
        /// Shows a SQL Instance key.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi tde-key set".
        /// Sets the SQL Instance's encryption protector.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiTdeKeySet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql mi tde-key show".
        /// Gets a managed instance encryption protector.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiTdeKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql midb create".
        /// Create a managed database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql midb delete".
        /// Delete a managed database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql midb list".
        /// List managed databases on a managed instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql midb restore".
        /// Restore a managed database.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql midb show".
        /// Get the details for a managed database.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server create".
        /// Create a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server delete".
        /// Deletes a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server list".
        /// List available servers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server list-usages".
        /// Returns server usages.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server show".
        /// Gets a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server update".
        /// Update a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server wait".
        /// Place the CLI in a waiting state until a condition of the SQL server is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server ad-admin create".
        /// Create a new server Active Directory administrator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server ad-admin delete".
        /// Deletes an existing server Active Directory Administrator.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server ad-admin list".
        /// Returns a list of server Administrators.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server ad-admin update".
        /// Update an existing server Active Directory administrator.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server conn-policy show".
        /// Gets a server's secure connection policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerConnPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server conn-policy update".
        /// Updates a server's secure connection policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerConnPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server dns-alias create".
        /// Creates a server dns alias.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server dns-alias delete".
        /// Deletes the server DNS alias with the given name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server dns-alias list".
        /// Gets a list of server DNS aliases for a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server dns-alias set".
        /// Sets a server to which DNS alias should point.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server dns-alias show".
        /// Gets a server DNS alias.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server firewall-rule create".
        /// Create a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server firewall-rule delete".
        /// Deletes a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server firewall-rule list".
        /// List a server's firewall rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server firewall-rule show".
        /// Shows the details for a firewall rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server firewall-rule update".
        /// Update a firewall rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server key create".
        /// Creates a server key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server key delete".
        /// Deletes a server key.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server key list".
        /// Gets a list of server keys.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server key show".
        /// Shows a server key.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server tde-key set".
        /// Sets the server's encryption protector.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerTdeKeySet(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server tde-key show".
        /// Gets a server encryption protector.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerTdeKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server vnet-rule create".
        /// Create a virtual network rule to allows access to an Azure SQL server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server vnet-rule delete".
        /// Deletes the virtual network rule with the given name.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server vnet-rule list".
        /// Gets a list of virtual network rules in a server.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server vnet-rule show".
        /// Gets a virtual network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql server vnet-rule update".
        /// Update a virtual network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql virtual-cluster delete".
        /// Delete a virtual cluster.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql virtual-cluster list".
        /// List available virtual clusters.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql virtual-cluster show".
        /// Get the details for a virtual cluster.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm add-to-group".
        /// Adds SQL virtual machine to a SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmAddToGroup(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm create".
        /// Creates a SQL virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm delete".
        /// Deletes a SQL virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm list".
        /// Lists all SQL virtual machines in a resource group or subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm remove-from-group".
        /// Remove SQL virtual machine from its current SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmRemoveFromGroup(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm show".
        /// Gets a SQL virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm update".
        /// Updates the properties of a SQL virtual machine.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group create".
        /// Creates a SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group delete".
        /// Deletes a SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group list".
        /// Lists all SQL virtual machine groups in a resource group or subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group show".
        /// Gets a SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group update".
        /// Updates a SQL virtual machine group if there are not SQL virtual machines attached to the group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group ag-listener create".
        /// Creates an availability group listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group ag-listener delete".
        /// Deletes an availability group listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group ag-listener list".
        /// Lists all availability group listeners in a SQL virtual machine group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group ag-listener show".
        /// Gets an availability group listener.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az sql vm group ag-listener update".
        /// Updates an availability group listener.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage copy".
        /// Copy files or directories to or from Azure storage.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCopy(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage remove".
        /// Delete blobs or files from Azure Storage.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account check-name".
        /// Checks that the storage account name is valid and is not already in use.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account create".
        /// Create a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account delete".
        /// Delete a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account generate-sas".
        /// Generates a shared access signature for the account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account list".
        /// List storage accounts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account revoke-delegation-keys".
        /// Revoke all user delegation keys for a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountRevokeDelegationKeys(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account show".
        /// Show storage account properties.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account show-connection-string".
        /// Get the connection string for a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account show-usage".
        /// Show the current count and limit of the storage accounts under the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account update".
        /// Update the properties of a storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account keys list".
        /// List the access keys or Kerberos keys (if active directory enabled) for a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account keys renew".
        /// Regenerate one of the access keys or Kerberos keys (if active directory enabled) for a storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account management-policy create".
        /// Creates the data policy rules associated with the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account management-policy delete".
        /// Deletes the managementpolicy associated with the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account management-policy show".
        /// Gets the managementpolicy associated with the specified storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account management-policy update".
        /// Updates the data policy rules associated with the specified storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account network-rule add".
        /// Add a network rule.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account network-rule list".
        /// List network rules.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage account network-rule remove".
        /// Remove a network rule.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob delete".
        /// Mark a blob or snapshot for deletion.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob delete-batch".
        /// Delete blobs from a blob container recursively.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDeleteBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob download".
        /// Downloads a blob to a file path, with automatic chunking and progress notifications.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob download-batch".
        /// Download blobs from a blob container recursively.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDownloadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob exists".
        /// Check for the existence of a blob in a container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob generate-sas".
        /// Generates a shared access signature for the blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob list".
        /// List blobs in a given container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob set-tier".
        /// Set the block or page tiers on the blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSetTier(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob show".
        /// Get the details of a blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob snapshot".
        /// Creates a read-only snapshot of a blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSnapshot(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob sync".
        /// Sync blobs recursively to a storage blob container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSync(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob undelete".
        /// The undelete Blob operation restores the contents and metadata of soft deleted blob or snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUndelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob update".
        /// Sets system properties on the blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob upload".
        /// Upload a file to a storage blob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob upload-batch".
        /// Upload files from a local directory to a blob container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUploadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob url".
        /// Create the url to access a blob.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob copy cancel".
        /// Aborts a pending copy_blob operation, and leaves a destination blob with zero length and full metadata.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob copy start".
        /// Copies a blob asynchronously. Use `az storage blob show` to check the status of the blobs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob copy start-batch".
        /// Copy multiple blobs or files to a blob container. Use `az storage blob show` to check the status of the blobs.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyStartBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob incremental-copy cancel".
        /// Aborts a pending copy_blob operation, and leaves a destination blob with zero length and full metadata.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobIncrementalCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob incremental-copy start".
        /// Copies an incremental copy of a blob asynchronously.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobIncrementalCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob lease acquire".
        /// Requests a new lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseAcquire(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob lease break".
        /// Breaks the lease, if the blob has an active lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseBreak(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob lease change".
        /// Changes the lease ID of an active lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseChange(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob lease release".
        /// Releases the lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseRelease(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob lease renew".
        /// Renews the lease.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob metadata show".
        /// Returns all user-defined metadata for the specified blob or snapshot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob metadata update".
        /// Sets user-defined metadata for the specified blob as one or more name-value pairs.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob service-properties show".
        /// Gets the properties of a storage account's Blob service, including Azure Storage Analytics.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob service-properties update".
        /// Update storage blob service properties.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob service-properties delete-policy show".
        /// Show the storage blob delete-policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesDeletePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage blob service-properties delete-policy update".
        /// Update the storage blob delete-policy.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesDeletePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container create".
        /// Create a container in a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container delete".
        /// Marks the specified container for deletion.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container exists".
        /// Check for the existence of a storage container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container generate-sas".
        /// Generate a SAS token for a storage container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container list".
        /// List containers in a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container set-permission".
        /// Sets the permissions for the specified container or stored access policies that may be used with Shared Access Signatures.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerSetPermission(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container show".
        /// Returns all user-defined metadata and system properties for the specified container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container show-permission".
        /// Gets the permissions for the specified container.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerShowPermission(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container immutability-policy create".
        /// Creates or updates an unlocked immutability policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container immutability-policy delete".
        /// Aborts an unlocked immutability policy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container immutability-policy extend".
        /// Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyExtend(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container immutability-policy lock".
        /// Sets the ImmutabilityPolicy to Locked state.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyLock(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container immutability-policy show".
        /// Gets the existing immutability policy along with the corresponding ETag in response headers and body.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container lease acquire".
        /// Requests a new lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseAcquire(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container lease break".
        /// Break the lease, if the container has an active lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseBreak(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container lease change".
        /// Change the lease ID of an active lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseChange(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container lease release".
        /// Release the lease.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseRelease(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container lease renew".
        /// Renews the lease.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseRenew(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container legal-hold clear".
        /// Clears legal hold tags.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container legal-hold set".
        /// Sets legal hold tags.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container legal-hold show".
        /// Get the legal hold properties of a container.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container metadata show".
        /// Returns all user-defined metadata for the specified container.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container metadata update".
        /// Sets one or more user-defined name-value pairs for the specified container.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container policy create".
        /// Create a stored access policy on the containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container policy delete".
        /// Delete a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container policy list".
        /// List stored access policies on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container policy show".
        /// Show a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage container policy update".
        /// Set a stored access policy on a containing object.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage cors add".
        /// Add a CORS rule to a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage cors clear".
        /// Remove all CORS rules from a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage cors list".
        /// List all CORS rules for a storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory create".
        /// Creates a new directory under the specified share or parent directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory delete".
        /// Deletes the specified empty directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory exists".
        /// Check for the existence of a storage directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory list".
        /// List directories in a share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory show".
        /// Returns all user-defined metadata and system properties for the specified directory.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory metadata show".
        /// Returns all user-defined metadata for the specified directory.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage directory metadata update".
        /// Sets one or more user-defined name-value pairs for the specified directory.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity delete".
        /// Deletes an existing entity in a table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity insert".
        /// Insert an entity into a table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityInsert(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity merge".
        /// Updates an existing entity by merging the entity's properties.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityMerge(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity query".
        /// List entities which satisfy a query.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityQuery(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity replace".
        /// Updates an existing entity in a table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityReplace(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage entity show".
        /// Get an entity from the specified table.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file delete".
        /// Marks the specified file for deletion.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file delete-batch".
        /// Delete files from an Azure Storage File Share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDeleteBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file download".
        /// Downloads a file to a file path, with automatic chunking and progress notifications.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file download-batch".
        /// Download files from an Azure Storage File Share to a local directory in a batch operation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDownloadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file exists".
        /// Check for the existence of a file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file generate-sas".
        /// Generates a shared access signature for the file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file list".
        /// List files and directories in a share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file resize".
        /// Resizes a file to the specified size.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileResize(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file show".
        /// Returns all user-defined metadata, standard HTTP properties, and system properties for the file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file update".
        /// Sets system properties on the file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file upload".
        /// Upload a file to a share that uses the SMB 3.0 protocol.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file upload-batch".
        /// Upload files from a local directory to an Azure Storage File Share in a batch operation.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUploadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file url".
        /// Create the url to access a file.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file copy cancel".
        /// Aborts a pending copy_file operation, and leaves a destination file  with zero length and full metadata.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file copy start".
        /// Copies a file asynchronously.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file copy start-batch".
        /// Copy multiple files or blobs to a file share.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyStartBatch(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file metadata show".
        /// Returns all user-defined metadata for the specified file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage file metadata update".
        /// Sets user-defined metadata for the specified file as one or more name-value pairs.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage logging show".
        /// Show logging settings for a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageLoggingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage logging update".
        /// Update logging settings for a storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageLoggingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message clear".
        /// Deletes all messages from the specified queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message delete".
        /// Deletes the specified message.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message get".
        /// Retrieves one or more messages from the front of the queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageGet(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message peek".
        /// Retrieves one or more messages from the front of the queue, but does not alter the visibility of the message.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessagePeek(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message put".
        /// Adds a new message to the back of the message queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessagePut(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage message update".
        /// Updates the visibility timeout of a message.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage metrics show".
        /// Show metrics settings for a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMetricsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage metrics update".
        /// Update metrics settings for a storage account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMetricsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue create".
        /// Creates a queue under the given account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue delete".
        /// Deletes the specified queue and any messages it contains.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue exists".
        /// Returns a boolean indicating whether the queue exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue generate-sas".
        /// Generates a shared access signature for the queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue list".
        /// List queues in a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue stats".
        /// Retrieves statistics related to replication for the Queue service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueStats(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue metadata show".
        /// Retrieves user-defined metadata and queue properties on the specified queue.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue metadata update".
        /// Sets user-defined metadata on the specified queue.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue policy create".
        /// Create a stored access policy on the containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue policy delete".
        /// Delete a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue policy list".
        /// List stored access policies on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue policy show".
        /// Show a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage queue policy update".
        /// Set a stored access policy on a containing object.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share create".
        /// Creates a new share under the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share delete".
        /// Marks the specified share for deletion.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share exists".
        /// Check for the existence of a file share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share generate-sas".
        /// Generates a shared access signature for the share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share list".
        /// List the file shares in a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share show".
        /// Returns all user-defined metadata and system properties for the specified share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share snapshot".
        /// Creates a snapshot of an existing share under the specified account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareSnapshot(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share stats".
        /// Gets the approximate size of the data stored on the share, rounded up to the nearest gigabyte.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareStats(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share update".
        /// Sets service-defined properties for the specified share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share url".
        /// Create a URI to access a file share.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share metadata show".
        /// Returns all user-defined metadata for the specified share.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share metadata update".
        /// Sets one or more user-defined name-value pairs for the specified share.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share policy create".
        /// Create a stored access policy on the containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share policy delete".
        /// Delete a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share policy list".
        /// List stored access policies on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share policy show".
        /// Show a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage share policy update".
        /// Set a stored access policy on a containing object.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table create".
        /// Creates a new table in the storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table delete".
        /// Deletes the specified table and any data it contains.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table exists".
        /// Returns a boolean indicating whether the table exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableExists(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table generate-sas".
        /// Generates a shared access signature for the table.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table list".
        /// List tables in a storage account.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table stats".
        /// Retrieves statistics related to replication for the Table service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableStats(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table policy create".
        /// Create a stored access policy on the containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table policy delete".
        /// Delete a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table policy list".
        /// List stored access policies on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table policy show".
        /// Show a stored access policy on a containing object.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az storage table policy update".
        /// Set a stored access policy on a containing object.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az tag add-value".
        /// Creates a tag value.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagAddValue(this ICakeContext context) {
        }

        /// <summary>
        /// "az tag create".
        /// Creates a tag in the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az tag delete".
        /// Deletes a tag from the subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az tag list".
        /// Gets the names and values of all resource tags that are defined in a subscription.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagList(this ICakeContext context) {
        }

        /// <summary>
        /// "az tag remove-value".
        /// Deletes a tag value.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagRemoveValue(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm capture".
        /// Capture information for a stopped VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmCapture(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm convert".
        /// Convert a VM with unmanaged disks to use managed disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmConvert(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm create".
        /// Create an Azure Virtual Machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm deallocate".
        /// Deallocate a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDeallocate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm delete".
        /// Delete a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm generalize".
        /// Mark a VM as generalized, allowing it to be imaged for multiple deployments.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmGeneralize(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm get-instance-view".
        /// Get instance information about a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list".
        /// List details of Virtual Machines.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list-ip-addresses".
        /// List IP addresses associated with a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListIpAddresses(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list-sizes".
        /// List available sizes for VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListSizes(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list-skus".
        /// Get details for compute-related resource SKUs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list-usage".
        /// List available usage resources for VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm list-vm-resize-options".
        /// List available resizing options for VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListVmResizeOptions(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm open-port".
        /// Opens a VM to inbound traffic on specified ports.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmOpenPort(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm perform-maintenance".
        /// The operation to perform maintenance on a virtual machine.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmPerformMaintenance(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm redeploy".
        /// Redeploy an existing VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRedeploy(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm resize".
        /// Update a VM's size.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmResize(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm restart".
        /// Restart VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm show".
        /// Get the details of a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm start".
        /// Start a stopped VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm stop".
        /// Power off (stop) a running VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm update".
        /// Update the properties of a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm wait".
        /// Place the CLI in a waiting state until a condition of the VM is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set convert".
        /// Convert an Azure Availability Set to contain VMs with managed disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetConvert(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set create".
        /// Create an Azure Availability Set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set delete".
        /// Delete an availability set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set list".
        /// List availability sets.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set list-sizes".
        /// List VM sizes for an availability set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetListSizes(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set show".
        /// Get information for an availability set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm availability-set update".
        /// Update an Azure Availability Set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm boot-diagnostics disable".
        /// Disable the boot diagnostics on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm boot-diagnostics enable".
        /// Enable the boot diagnostics on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm boot-diagnostics get-boot-log".
        /// Get the boot diagnostics log from a VM.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsGetBootLog(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm diagnostics get-default-config".
        /// Get the default configuration settings for a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiagnosticsGetDefaultConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm diagnostics set".
        /// Configure the Azure VM diagnostics extension.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiagnosticsSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm disk attach".
        /// Attach a managed persistent disk to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm disk detach".
        /// Detach a managed disk from a VM.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm encryption disable".
        /// Disable disk encryption on the OS disk and/or data disks. Decrypt mounted disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm encryption enable".
        /// Enable disk encryption on the OS disk and/or data disks. Encrypt mounted disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm encryption show".
        /// Show encryption status.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension delete".
        /// Remove an extension attached to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension list".
        /// List the extensions attached to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension set".
        /// Set extensions for a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension show".
        /// Display information about extensions attached to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension wait".
        /// Place the CLI in a waiting state until a condition of a virtual machine extension is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension image list".
        /// List the information on available extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension image list-names".
        /// List the names of available extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageListNames(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension image list-versions".
        /// List the versions for available extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm extension image show".
        /// Display information for an extension.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host create".
        /// Create a dedicated host.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host delete".
        /// Delete a dedicated host.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host get-instance-view".
        /// Get instance information about a dedicated host.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host list".
        /// List dedicated hosts.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host show".
        /// Get the details of a dedicated host.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host update".
        /// Update a dedicated host.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host group create".
        /// Create a dedicated host group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host group delete".
        /// Delete a dedicated host group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host group list".
        /// List dedicated host groups.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host group show".
        /// Get the details of a dedicated host group.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm host group update".
        /// Update a dedicated host group.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm identity assign".
        /// Enable managed service identity on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm identity remove".
        /// Remove managed service identities from a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm identity show".
        /// Display VM's managed identity info.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image accept-terms".
        /// Accept Azure Marketplace term so that the image can be used to create VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageAcceptTerms(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image list".
        /// List the VM/VMSS images available in the Azure Marketplace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image list-offers".
        /// List the VM image offers available in the Azure Marketplace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListOffers(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image list-publishers".
        /// List the VM image publishers available in the Azure Marketplace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListPublishers(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image list-skus".
        /// List the VM image SKUs available in the Azure Marketplace.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image show".
        /// Get the details for a VM image available in the Azure Marketplace.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image terms accept".
        /// Accept Azure Marketplace image terms so that the image can be used to create VMs.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsAccept(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image terms cancel".
        /// Cancel Azure Marketplace image terms.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm image terms show".
        /// Get the details of Azure Marketplace image terms.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm monitor log show".
        /// Executes a query against the Log Analytics workspace linked with a vm.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmMonitorLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm nic add".
        /// Add existing NICs to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm nic list".
        /// List the NICs available on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm nic remove".
        /// Remove NICs from a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm nic set".
        /// Configure settings of a NIC attached to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm nic show".
        /// Display information for a NIC attached to a VM.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm run-command invoke".
        /// Execute a specific run command on a vm.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandInvoke(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm run-command list".
        /// Lists all available run commands for a subscription in a location.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm run-command show".
        /// Gets specific run command for a subscription in a location.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm secret add".
        /// Add a secret to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm secret format".
        /// Transform secrets into a form that can be used by VMs and VMSSes.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretFormat(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm secret list".
        /// List secrets on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm secret remove".
        /// Remove a secret from a VM.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm unmanaged-disk attach".
        /// Attach an unmanaged persistent disk to a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm unmanaged-disk detach".
        /// Detach an unmanaged disk from a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm unmanaged-disk list".
        /// List unmanaged disks of a VM.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm user delete".
        /// Delete a user account from a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm user reset-ssh".
        /// Reset the SSH configuration on a VM.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserResetSsh(this ICakeContext context) {
        }

        /// <summary>
        /// "az vm user update".
        /// Update a user account.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss create".
        /// Create an Azure Virtual Machine Scale Set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss deallocate".
        /// Deallocate VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDeallocate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss delete".
        /// Deletes a VM scale set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss delete-instances".
        /// Delete VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDeleteInstances(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss get-instance-view".
        /// View an instance of a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss get-os-upgrade-history".
        /// Gets list of OS upgrades on a VM scale set instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssGetOsUpgradeHistory(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss list".
        /// List VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss list-instance-connection-info".
        /// Get the IP address and port number used to connect to individual VM instances within a set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstanceConnectionInfo(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss list-instance-public-ips".
        /// List public IP addresses of VM instances within a set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstancePublicIps(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss list-instances".
        /// Gets a list of all virtual machines in a VM scale sets.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstances(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss list-skus".
        /// Gets a list of SKUs available for your VM scale set, including the minimum and maximum VM instances allowed for each SKU.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss perform-maintenance".
        /// Perform maintenance on one or more virtual machines in a VM scale set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssPerformMaintenance(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss reimage".
        /// Reimage VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssReimage(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss restart".
        /// Restart VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss scale".
        /// Change the number of VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssScale(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss show".
        /// Get details on VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss start".
        /// Start VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss stop".
        /// Power off (stop) VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss update".
        /// Update a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss update-instances".
        /// Upgrade VMs within a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssUpdateInstances(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss wait".
        /// Place the CLI in a waiting state until a condition of a scale set is met.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssWait(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss diagnostics get-default-config".
        /// Show the default config file which defines data to be collected.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiagnosticsGetDefaultConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss diagnostics set".
        /// Enable diagnostics on a VMSS.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiagnosticsSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss disk attach".
        /// Attach managed data disks to a scale set or its instances.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss disk detach".
        /// Detach managed data disks from a scale set or its instances.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss encryption disable".
        /// Disable the encryption on a VMSS with managed disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss encryption enable".
        /// Encrypt a VMSS with managed disks.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionEnable(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss encryption show".
        /// Show encryption status.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension delete".
        /// Delete an extension from a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension list".
        /// List extensions associated with a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension set".
        /// Add an extension to a VMSS or update an existing extension.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension show".
        /// Show details on a VMSS extension.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension image list".
        /// List the information on available extensions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension image list-names".
        /// Gets a list of virtual machine extension image types.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageListNames(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension image list-versions".
        /// Gets a list of virtual machine extension image versions.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss extension image show".
        /// Gets a virtual machine extension image.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss identity assign".
        /// Enable managed service identity on a VMSS.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss identity remove".
        /// Remove user assigned identities from a VM scaleset.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss identity show".
        /// Display VM scaleset's managed identity info.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss nic list".
        /// Gets all network interfaces in a virtual machine scale set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss nic list-vm-nics".
        /// Gets information about all network interfaces in a virtual machine in a virtual machine scale set.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicListVmNics(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss nic show".
        /// Get the specified network interface in a virtual machine scale set.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss rolling-upgrade cancel".
        /// Cancels the current virtual machine scale set rolling upgrade.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeCancel(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss rolling-upgrade get-latest".
        /// Gets the status of the latest virtual machine scale set rolling upgrade.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeGetLatest(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss rolling-upgrade start".
        /// Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss run-command invoke".
        /// Execute a specific run command on a Virtual Machine Scale Set instance.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandInvoke(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss run-command list".
        /// Lists all available run commands for a subscription in a location.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandList(this ICakeContext context) {
        }

        /// <summary>
        /// "az vmss run-command show".
        /// Gets specific run command for a subscription in a location.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp browse".
        /// Open a web app in a browser.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappBrowse(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp create".
        /// Create a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp create-remote-connection".
        /// Creates a remote connection using a tcp tunnel to your web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCreateRemoteConnection(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp delete".
        /// Delete a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp list".
        /// List web apps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp list-runtimes".
        /// List available built-in stacks which can be used for web apps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappListRuntimes(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp restart".
        /// Restart a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappRestart(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp show".
        /// Get the details of a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp ssh".
        /// SSH command establishes a ssh session to the web container and developer would get a shell terminal remotely.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappSsh(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp start".
        /// Start a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp stop".
        /// Stop a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp up".
        /// Create a webapp and deploy code from a local workspace to the app. The command is required to run from the folder where the code is present. Current support includes Node, Python, .NET Core and ASP.NET. Node, Python apps are created as Linux apps. .Net Core, ASP.NET apps are created as Windows apps.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappUp(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp update".
        /// Update a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp auth show".
        /// Show the authentification settings for the webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappAuthShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp auth update".
        /// Update the authentication settings for the webapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappAuthUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config set".
        /// Set a web app's configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config show".
        /// Get the details of a web app's configuration.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config access-restriction add".
        /// Adds an Access Restriction to the webapp, or updates if the Action of the Ip-Address or Subnet already exists.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config access-restriction remove".
        /// Removes an Access Restriction from the webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config access-restriction set".
        /// Sets if SCM site is using the same restrictions as the main site.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config access-restriction show".
        /// Show Access Restriction settings for webapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config appsettings delete".
        /// Delete web app settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config appsettings list".
        /// Get the details of a web app's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config appsettings set".
        /// Set a web app's settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config backup create".
        /// Create a backup of a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config backup list".
        /// List backups of a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config backup restore".
        /// Restore a web app from a backup.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config backup show".
        /// Show the backup schedule for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config backup update".
        /// Configure a new backup schedule for a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config connection-string delete".
        /// Delete a web app's connection strings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config connection-string list".
        /// Get a web app's connection strings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config connection-string set".
        /// Update a web app's connection strings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config container delete".
        /// Delete a web app container's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config container set".
        /// Set a web app container's settings.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config container show".
        /// Get details of a web app container's settings.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config hostname add".
        /// Bind a hostname to a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config hostname delete".
        /// Unbind a hostname from a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config hostname get-external-ip".
        /// Get the external-facing IP address for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameGetExternalIp(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config hostname list".
        /// List all hostname bindings for a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config snapshot list".
        /// List the restorable snapshots for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config snapshot restore".
        /// Restore a web app snapshot.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSnapshotRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config ssl bind".
        /// Bind an SSL certificate to a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslBind(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config ssl delete".
        /// Delete an SSL certificate from a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config ssl list".
        /// List SSL certificates for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config ssl unbind".
        /// Unbind an SSL certificate from a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslUnbind(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config ssl upload".
        /// Upload an SSL certificate to a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslUpload(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config storage-account add".
        /// Add an Azure storage account configuration to a web app. (Linux Web Apps and Windows Containers Web Apps Only).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config storage-account delete".
        /// Delete a web app's Azure storage account configuration. (Linux Web Apps and Windows Containers Web Apps Only).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config storage-account list".
        /// Get a web app's Azure storage account configurations. (Linux Web Apps and Windows Containers Web Apps Only).
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp config storage-account update".
        /// Update an existing Azure storage account configuration on a web app. (Linux Web Apps and Windows Containers Web Apps Only).  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp cors add".
        /// Add allowed origins.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp cors remove".
        /// Remove allowed origins.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp cors show".
        /// Show allowed origins.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deleted list".
        /// List web apps that have been deleted.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeletedList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deleted restore".
        /// Restore a deleted web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeletedRestore(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment list-publishing-credentials".
        /// Get the details for available web app publishing credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentListPublishingCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment list-publishing-profiles".
        /// Get the details for available web app deployment profiles.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentListPublishingProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment container config".
        /// Configure continuous deployment via containers.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentContainerConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment container show-cd-url".
        /// Get the URL which can be used to configure webhooks for continuous deployment.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentContainerShowCdUrl(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment slot auto-swap".
        /// Configure deployment slot auto swap.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotAutoSwap(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment slot create".
        /// Create a deployment slot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment slot delete".
        /// Delete a deployment slot.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment slot list".
        /// List all deployment slots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment slot swap".
        /// Change deployment slots for a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotSwap(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source config".
        /// Manage deployment from git or Mercurial repositories.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source config-local-git".
        /// Get a URL for a git repository endpoint to clone and push to for web app deployment.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfigLocalGit(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source config-zip".
        /// Perform deployment using the kudu zip push deployment for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfigZip(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source delete".
        /// Delete a source control deployment configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source show".
        /// Get the details of a source control deployment configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source sync".
        /// Synchronize from the repository. Only needed under manual integration mode.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceSync(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment source update-token".
        /// Update source control token cached in Azure app service.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceUpdateToken(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment user set".
        /// Update deployment credentials.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentUserSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp deployment user show".
        /// Gets publishing user.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp hybrid-connection add".
        /// Add a hybrid-connection to a webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp hybrid-connection list".
        /// List the hybrid-connections on a webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp hybrid-connection remove".
        /// Remove a hybrid-connection from a webapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp identity assign".
        /// Assign or disable managed service identity to the web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp identity remove".
        /// Disable web app's managed service identity.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp identity show".
        /// Display web app's managed service identity.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp log config".
        /// Configure logging for a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogConfig(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp log download".
        /// Download a web app's log history as a zip file.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogDownload(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp log show".
        /// Get the details of a web app's logging configuration.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp log tail".
        /// Start live log tracing for a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogTail(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp traffic-routing clear".
        /// Clear the routing rules and send all traffic to production.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingClear(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp traffic-routing set".
        /// Configure routing traffic to deployment slots.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingSet(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp traffic-routing show".
        /// Display the current distribution of traffic across slots.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingShow(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp vnet-integration add".
        /// Add a regional virtual network integration to a webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationAdd(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp vnet-integration list".
        /// List the virtual network integrations on a webapp.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp vnet-integration remove".
        /// Remove a regional virtual network integration from webapp.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob continuous list".
        /// List all continuous webjobs on a selected web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob continuous remove".
        /// Delete a specific continuous webjob.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob continuous start".
        /// Start a specific continuous webjob on a selected web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousStart(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob continuous stop".
        /// Stop a specific continuous webjob.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousStop(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob triggered list".
        /// List all triggered webjobs hosted on a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredList(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob triggered log".
        /// Get history of a specific triggered webjob hosted on a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredLog(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob triggered remove".
        /// Delete a specific triggered webjob hosted on a web app.
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredRemove(this ICakeContext context) {
        }

        /// <summary>
        /// "az webapp webjob triggered run".
        /// Run a specific triggered webjob hosted on a web app.  
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredRun(this ICakeContext context) {
        }

    }
}

