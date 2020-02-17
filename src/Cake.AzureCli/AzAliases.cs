
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
        /// az account lock create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az account lock delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az account lock list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockList(this ICakeContext context) {
        }

        /// <summary>
        /// az account lock show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// az account lock update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group subscription add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupSubscriptionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group subscription remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupSubscriptionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az account management-group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountManagementGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az account clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountClear(this ICakeContext context) {
        }

        /// <summary>
        /// az account get-access-token
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountGetAccessToken(this ICakeContext context) {
        }

        /// <summary>
        /// az account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az account list-locations
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountListLocations(this ICakeContext context) {
        }

        /// <summary>
        /// az account set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountSet(this ICakeContext context) {
        }

        /// <summary>
        /// az account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr config content-trust show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigContentTrustShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr config content-trust update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigContentTrustUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr config retention show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigRetentionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr config retention update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrConfigRetentionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr credential renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCredentialRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az acr credential show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCredentialShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr helm repo add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmRepoAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az acr helm delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr helm list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr helm push
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmPush(this ICakeContext context) {
        }

        /// <summary>
        /// az acr helm show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrHelmShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az acr network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az acr pack build
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrPackBuild(this ICakeContext context) {
        }

        /// <summary>
        /// az acr replication create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr replication delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr replication list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr replication show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr replication update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrReplicationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository show-manifests
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShowManifests(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository show-tags
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryShowTags(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository untag
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryUntag(this ICakeContext context) {
        }

        /// <summary>
        /// az acr repository update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRepositoryUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr scope-map create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr scope-map delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr scope-map list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr scope-map show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr scope-map update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrScopeMapUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task credential add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task credential list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task credential remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task credential update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCredentialUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task timer add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task timer list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task timer remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task timer update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskTimerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task cancel-run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCancelRun(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task list-runs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskListRuns(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task logs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskLogs(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskRun(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task show-run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskShowRun(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr task update-run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTaskUpdateRun(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token credential delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token credential generate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCredentialGenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr token update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrTokenUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook get-config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookGetConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook list-events
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookListEvents(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook ping
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookPing(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr webhook update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrWebhookUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr build
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrBuild(this ICakeContext context) {
        }

        /// <summary>
        /// az acr check-health
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCheckHealth(this ICakeContext context) {
        }

        /// <summary>
        /// az acr check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az acr create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az acr delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az acr import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrImport(this ICakeContext context) {
        }

        /// <summary>
        /// az acr list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrList(this ICakeContext context) {
        }

        /// <summary>
        /// az acr login
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrLogin(this ICakeContext context) {
        }

        /// <summary>
        /// az acr run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrRun(this ICakeContext context) {
        }

        /// <summary>
        /// az acr show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrShow(this ICakeContext context) {
        }

        /// <summary>
        /// az acr show-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az acr update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAcrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app credential delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app credential list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app credential reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCredentialReset(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app owner add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app owner list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app owner remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppOwnerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission admin-consent
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionAdminConsent(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission grant
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionGrant(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app permission list-grants
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppPermissionListGrants(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ad app update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdAppUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group member add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group member check
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberCheck(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group member list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group member remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupMemberRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group owner add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group owner list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group owner remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupOwnerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group get-member-groups
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupGetMemberGroups(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ad signed-in-user list-owned-objects
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSignedInUserListOwnedObjects(this ICakeContext context) {
        }

        /// <summary>
        /// az ad signed-in-user show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSignedInUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp credential delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp credential list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp credential reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCredentialReset(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp owner list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpOwnerList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp create-for-rbac
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpCreateForRbac(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ad sp update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdSpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user get-member-groups
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserGetMemberGroups(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserList(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ad user update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdUserUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor configuration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor configuration show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor configuration update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorConfigurationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor recommendation disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor recommendation enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az advisor recommendation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAdvisorRecommendationList(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool scale
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolScale(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az aks nodepool upgrade
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksNodepoolUpgrade(this ICakeContext context) {
        }

        /// <summary>
        /// az aks browse
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksBrowse(this ICakeContext context) {
        }

        /// <summary>
        /// az aks create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az aks delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az aks disable-addons
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksDisableAddons(this ICakeContext context) {
        }

        /// <summary>
        /// az aks enable-addons
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksEnableAddons(this ICakeContext context) {
        }

        /// <summary>
        /// az aks get-credentials
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// az aks get-upgrades
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetUpgrades(this ICakeContext context) {
        }

        /// <summary>
        /// az aks get-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksGetVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az aks install-cli
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksInstallCli(this ICakeContext context) {
        }

        /// <summary>
        /// az aks install-connector
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksInstallConnector(this ICakeContext context) {
        }

        /// <summary>
        /// az aks list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksList(this ICakeContext context) {
        }

        /// <summary>
        /// az aks remove-connector
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRemoveConnector(this ICakeContext context) {
        }

        /// <summary>
        /// az aks remove-dev-spaces
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRemoveDevSpaces(this ICakeContext context) {
        }

        /// <summary>
        /// az aks rotate-certs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksRotateCerts(this ICakeContext context) {
        }

        /// <summary>
        /// az aks scale
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksScale(this ICakeContext context) {
        }

        /// <summary>
        /// az aks show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksShow(this ICakeContext context) {
        }

        /// <summary>
        /// az aks update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az aks update-credentials
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpdateCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// az aks upgrade
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpgrade(this ICakeContext context) {
        }

        /// <summary>
        /// az aks upgrade-connector
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUpgradeConnector(this ICakeContext context) {
        }

        /// <summary>
        /// az aks use-dev-spaces
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksUseDevSpaces(this ICakeContext context) {
        }

        /// <summary>
        /// az aks wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAksWait(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account mru set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountMruSet(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account mru show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountMruShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account sp create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountSpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account sp reset-credentials
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountSpResetCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account storage add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account storage remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account storage sync-storage-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountStorageSyncStorageKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account-filter create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account-filter delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account-filter list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account-filter show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams account-filter update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAccountFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset get-encryption-key
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetGetEncryptionKey(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset get-sas-urls
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetGetSasUrls(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset list-streaming-locators
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetListStreamingLocators(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset-filter create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset-filter delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset-filter list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset-filter show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams asset-filter update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsAssetFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy option add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy option remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy option update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyOptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams content-key-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsContentKeyPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams job update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsJobUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventReset(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventStart(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventStop(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-event wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveEventWait(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-output create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-output delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-output list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams live-output show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsLiveOutputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint akamai add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointAkamaiAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint akamai remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointAkamaiRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint scale
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointScale(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointStart(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointStop(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-endpoint wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingEndpointWait(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator get-paths
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorGetPaths(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator list-content-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorListContentKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-locator show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingLocatorShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams streaming-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsStreamingPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform output add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformOutputAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform output remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformOutputRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformList(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ams transform update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAmsTransformUpdate(this ICakeContext context) {
        }

        /// <summary>
        ///  apply-network-updates
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void ApplyNetworkUpdates(this ICakeContext context) {
        }

        /// <summary>
        ///  backup
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void Backup(this ICakeContext context) {
        }

        /// <summary>
        ///  check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void CheckName(this ICakeContext context) {
        }

        /// <summary>
        ///  create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void Create(this ICakeContext context) {
        }

        /// <summary>
        ///  delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void Delete(this ICakeContext context) {
        }

        /// <summary>
        ///  list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void List(this ICakeContext context) {
        }

        /// <summary>
        ///  show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void Show(this ICakeContext context) {
        }

        /// <summary>
        ///  update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void Update(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig credential list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig credential regenerate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCredentialRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature filter add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature filter delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature filter list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature filter show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature lock
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureLock(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureSet(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig feature unlock
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigFeatureUnlock(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvExport(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvImport(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv lock
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvLock(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvSet(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig kv unlock
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigKvUnlock(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig revision list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigRevisionList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigList(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appconfig update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppconfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseList(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase list-addresses
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseListAddresses(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase list-plans
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseListPlans(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice ase update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceAseUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice hybrid-connection set-key
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceHybridConnectionSetKey(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice plan create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice plan delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice plan list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanList(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice plan show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanShow(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice plan update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppservicePlanUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice vnet-integration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// az appservice list-locations
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzAppserviceListLocations(this ICakeContext context) {
        }

        /// <summary>
        /// az backup container list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup container unregister
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupContainerUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// az backup item list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup item set-policy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemSetPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// az backup item show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupItemShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup job list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup job show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup job stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobStop(this ICakeContext context) {
        }

        /// <summary>
        /// az backup job wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupJobWait(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy get-default-for-vm
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyGetDefaultForVm(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy list-associated-items
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyListAssociatedItems(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicySet(this ICakeContext context) {
        }

        /// <summary>
        /// az backup policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup protection backup-now
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionBackupNow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup protection check-vm
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionCheckVm(this ICakeContext context) {
        }

        /// <summary>
        /// az backup protection disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az backup protection enable-for-azurefileshare
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionEnableForAzurefileshare(this ICakeContext context) {
        }

        /// <summary>
        /// az backup protection enable-for-vm
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupProtectionEnableForVm(this ICakeContext context) {
        }

        /// <summary>
        /// az backup recoverypoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRecoverypointList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup recoverypoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRecoverypointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup restore files mount-rp
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreFilesMountRp(this ICakeContext context) {
        }

        /// <summary>
        /// az backup restore files unmount-rp
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreFilesUnmountRp(this ICakeContext context) {
        }

        /// <summary>
        /// az backup restore restore-azurefiles
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreAzurefiles(this ICakeContext context) {
        }

        /// <summary>
        /// az backup restore restore-azurefileshare
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreAzurefileshare(this ICakeContext context) {
        }

        /// <summary>
        /// az backup restore restore-disks
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupRestoreRestoreDisks(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault backup-properties set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultBackupPropertiesSet(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault backup-properties show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultBackupPropertiesShow(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultList(this ICakeContext context) {
        }

        /// <summary>
        /// az backup vault show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBackupVaultShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account autostorage-keys sync
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountAutostorageKeysSync(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account login
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountLogin(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountSet(this ICakeContext context) {
        }

        /// <summary>
        /// az batch account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application package activate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageActivate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application package create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application package delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application package list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application package show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationPackageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application summary list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSummaryList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application summary show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSummaryShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationSet(this ICakeContext context) {
        }

        /// <summary>
        /// az batch application show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchApplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch certificate create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch certificate delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch certificate list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch certificate show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job all-statistics show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobAllStatisticsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job prep-release-status list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobPrepReleaseStatusList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job task-counts show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobTaskCountsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobReset(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobSet(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobStop(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleReset(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleSet(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch job-schedule stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchJobScheduleStop(this ICakeContext context) {
        }

        /// <summary>
        /// az batch location quotas show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchLocationQuotasShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node file delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node file download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node file list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node file show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node remote-desktop download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeRemoteDesktopDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node remote-login-settings show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeRemoteLoginSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node scheduling disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeSchedulingDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node scheduling enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeSchedulingEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node service-logs upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeServiceLogsUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node user create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node user delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node user reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeUserReset(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node reboot
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeReboot(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node reimage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeReimage(this ICakeContext context) {
        }

        /// <summary>
        /// az batch node show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchNodeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool all-statistics show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAllStatisticsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool autoscale disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool autoscale enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool autoscale evaluate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolAutoscaleEvaluate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool node-counts list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolNodeCountsList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool supported-images list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolSupportedImagesList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool usage-metrics list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolUsageMetricsList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolReset(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool resize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolResize(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolSet(this ICakeContext context) {
        }

        /// <summary>
        /// az batch pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task file delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task file download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task file list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task file show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task subtask list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskSubtaskList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task reactivate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskReactivate(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskReset(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// az batch task stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBatchTaskStop(this ICakeContext context) {
        }

        /// <summary>
        /// az billing enrollment-account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingEnrollmentAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az billing enrollment-account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingEnrollmentAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az billing invoice list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingInvoiceList(this ICakeContext context) {
        }

        /// <summary>
        /// az billing invoice show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingInvoiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az billing period list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingPeriodList(this ICakeContext context) {
        }

        /// <summary>
        /// az billing period show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBillingPeriodShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot authsetting create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot authsetting delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot authsetting list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingList(this ICakeContext context) {
        }

        /// <summary>
        /// az bot authsetting list-providers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingListProviders(this ICakeContext context) {
        }

        /// <summary>
        /// az bot authsetting show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotAuthsettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot directline create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot directline delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot directline show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDirectlineShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot email create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot email delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot email show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotEmailShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot facebook create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot facebook delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot facebook show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotFacebookShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot kik create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot kik delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot kik show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotKikShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot msteams create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot msteams delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot msteams show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotMsteamsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot skype create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot skype delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot skype show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSkypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot slack create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot slack delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot slack show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSlackShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot sms create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot sms delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot sms show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotSmsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot telegram create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot telegram delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot telegram show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotTelegramShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot webchat show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotWebchatShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az bot delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az bot download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az bot prepare-deploy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPrepareDeploy(this ICakeContext context) {
        }

        /// <summary>
        /// az bot prepare-publish
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPreparePublish(this ICakeContext context) {
        }

        /// <summary>
        /// az bot publish
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotPublish(this ICakeContext context) {
        }

        /// <summary>
        /// az bot show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotShow(this ICakeContext context) {
        }

        /// <summary>
        /// az bot update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzBotUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cache delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cache list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheList(this ICakeContext context) {
        }

        /// <summary>
        /// az cache purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCachePurge(this ICakeContext context) {
        }

        /// <summary>
        /// az cache show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCacheShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain disable-https
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainDisableHttps(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain enable-https
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainEnableHttps(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainList(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn custom-domain show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnCustomDomainShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn edge-node list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEdgeNodeList(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint load
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointLoad(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointPurge(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointStart(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointStop(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn endpoint validate-custom-domain
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnEndpointValidateCustomDomain(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn origin list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnOriginList(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn origin show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnOriginShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn profile usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnProfileUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn name-exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnNameExists(this ICakeContext context) {
        }

        /// <summary>
        /// az cdn usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCdnUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudList(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud list-profiles
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudListProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud register
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudRegister(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudSet(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud unregister
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// az cloud update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCloudUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account keys regenerate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountKeysRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account list-kinds
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListKinds(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account list-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cognitiveservices account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCognitiveservicesAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption budget create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption budget delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption budget list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetList(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption budget show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionBudgetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption marketplace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionMarketplaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption pricesheet show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionPricesheetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption reservation detail list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionReservationDetailList(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption reservation summary list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionReservationSummaryList(this ICakeContext context) {
        }

        /// <summary>
        /// az consumption usage list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConsumptionUsageList(this ICakeContext context) {
        }

        /// <summary>
        /// az container attach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerAttach(this ICakeContext context) {
        }

        /// <summary>
        /// az container create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az container delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az container exec
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerExec(this ICakeContext context) {
        }

        /// <summary>
        /// az container export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerExport(this ICakeContext context) {
        }

        /// <summary>
        /// az container list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// az container logs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerLogs(this ICakeContext context) {
        }

        /// <summary>
        /// az container restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az container start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerStart(this ICakeContext context) {
        }

        /// <summary>
        /// az container stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzContainerStop(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra keyspace show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraKeyspaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb cassandra table update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCassandraTableUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionExists(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb collection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCollectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb database create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb database delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb database exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseExists(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb gremlin graph update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbGremlinGraphUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb keys regenerate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbKeysRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb collection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbCollectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb mongodb database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbMongodbDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql container update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlContainerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb sql database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbSqlDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table throughput show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableThroughputShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table throughput update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableThroughputUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb table show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb check-name-exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCheckNameExists(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb failover-priority-change
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbFailoverPriorityChange(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbList(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az cosmosdb update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzCosmosdbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment operation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment operation show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentExport(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment validate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentValidate(this ICakeContext context) {
        }

        /// <summary>
        /// az deployment wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentWait(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager artifact-source create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager artifact-source delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager artifact-source show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager artifact-source update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerArtifactSourceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager rollout delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager rollout restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager rollout show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager rollout stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerRolloutStop(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-topology create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-topology delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-topology show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-topology update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceTopologyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-unit create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-unit delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-unit show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager service-unit update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerServiceUnitUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager step create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager step delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager step show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepShow(this ICakeContext context) {
        }

        /// <summary>
        /// az deploymentmanager step update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDeploymentmanagerStepUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az disk create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az disk delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az disk grant-access
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskGrantAccess(this ICakeContext context) {
        }

        /// <summary>
        /// az disk list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskList(this ICakeContext context) {
        }

        /// <summary>
        /// az disk revoke-access
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskRevokeAccess(this ICakeContext context) {
        }

        /// <summary>
        /// az disk show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskShow(this ICakeContext context) {
        }

        /// <summary>
        /// az disk update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az disk wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDiskWait(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account blob-storage add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account blob-storage delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account blob-storage list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account blob-storage show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account blob-storage update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountBlobStorageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account compute-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account compute-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account compute-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account compute-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account compute-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountComputePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account data-lake-store add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account data-lake-store delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account data-lake-store list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account data-lake-store show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDataLakeStoreShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account firewall create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account firewall delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account firewall list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account firewall show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account firewall update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountFirewallUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog assembly list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogAssemblyList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog assembly show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogAssemblyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog credential create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog credential delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog credential list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog credential show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog credential update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogCredentialUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog external-data-source list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogExternalDataSourceList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog external-data-source show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogExternalDataSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog package list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogPackageList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog package show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogPackageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog procedure list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogProcedureList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog procedure show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogProcedureShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog schema list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogSchemaList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog schema show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogSchemaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-partition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTablePartitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-partition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTablePartitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-stats list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableStatsList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-stats show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableStatsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-type list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableTypeList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog table-type show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTableTypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog tvf list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTvfList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog tvf show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogTvfShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog view list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogViewList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla catalog view show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaCatalogViewShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job pipeline list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobPipelineList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job pipeline show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobPipelineShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job recurrence list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobRecurrenceList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job recurrence show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobRecurrenceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobList(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job submit
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobSubmit(this ICakeContext context) {
        }

        /// <summary>
        /// az dla job wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlaJobWait(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account firewall create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account firewall delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account firewall list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallList(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account firewall show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account firewall update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountFirewallUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account network-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account network-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account network-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account network-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountNetworkRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account trusted-provider create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account trusted-provider delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account trusted-provider list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderList(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account trusted-provider show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account trusted-provider update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountTrustedProviderUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account enable-key-vault
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountEnableKeyVault(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access remove-all
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessRemoveAll(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access remove-entry
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessRemoveEntry(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSet(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access set-entry
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetEntry(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access set-owner
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetOwner(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access set-permission
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessSetPermission(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs access show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAccessShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs append
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsAppend(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs join
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsJoin(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsList(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs move
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsMove(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs preview
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsPreview(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs remove-expiry
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsRemoveExpiry(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs set-expiry
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsSetExpiry(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs test
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsTest(this ICakeContext context) {
        }

        /// <summary>
        /// az dls fs upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDlsFsUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project task show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectList(this ICakeContext context) {
        }

        /// <summary>
        /// az dms project show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsProjectShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dms check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az dms check-status
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCheckStatus(this ICakeContext context) {
        }

        /// <summary>
        /// az dms create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az dms delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az dms list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsList(this ICakeContext context) {
        }

        /// <summary>
        /// az dms list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az dms show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az dms start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsStart(this ICakeContext context) {
        }

        /// <summary>
        /// az dms stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsStop(this ICakeContext context) {
        }

        /// <summary>
        /// az dms wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzDmsWait(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain key regenerate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainKeyRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain topic create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain topic delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain topic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain topic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid domain update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridDomainUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid event-subscription create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid event-subscription delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid event-subscription list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid event-subscription show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid event-subscription update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridEventSubscriptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic key regenerate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicKeyRegenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic-type list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic-type list-event-types
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeListEventTypes(this ICakeContext context) {
        }

        /// <summary>
        /// az eventgrid topic-type show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventgridTopicTypeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub consumer-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub consumer-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub consumer-group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub consumer-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub consumer-group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubConsumerGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs eventhub update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsEventhubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias break-pair
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasBreakPair(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasExists(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias fail-over
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasFailOver(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs georecovery-alias show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsGeorecoveryAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az eventhubs namespace update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzEventhubsNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az extension add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az extension list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// az extension list-available
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionListAvailable(this ICakeContext context) {
        }

        /// <summary>
        /// az extension remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az extension show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az extension update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzExtensionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az feature list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureList(this ICakeContext context) {
        }

        /// <summary>
        /// az feature register
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureRegister(this ICakeContext context) {
        }

        /// <summary>
        /// az feature show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeatureShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config access-restriction add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config access-restriction remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config access-restriction set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionSet(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config access-restriction show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAccessRestrictionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config appsettings delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config appsettings list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config appsettings set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigAppsettingsSet(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config container delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config container set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerSet(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config hostname add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config hostname delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config hostname get-external-ip
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameGetExternalIp(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config hostname list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigHostnameList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config ssl bind
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslBind(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config ssl delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config ssl list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config ssl unbind
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslUnbind(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config ssl upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSslUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp config show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp cors add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp cors remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp cors show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCorsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment container config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentContainerConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment container show-cd-url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentContainerShowCdUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment slot auto-swap
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotAutoSwap(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment slot create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment slot delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment slot list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment slot swap
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSlotSwap(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source config-local-git
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfigLocalGit(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source config-zip
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceConfigZip(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source sync
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceSync(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment source update-token
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentSourceUpdateToken(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment user set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentUserSet(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment user show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment list-publishing-credentials
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentListPublishingCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp deployment list-publishing-profiles
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDeploymentListPublishingProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp devops-pipeline create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDevopsPipelineCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp hybrid-connection add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp hybrid-connection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp hybrid-connection remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappHybridConnectionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp plan create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp plan delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp plan list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp plan show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp plan update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappPlanUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp vnet-integration add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp vnet-integration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp vnet-integration remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappVnetIntegrationRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappList(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp list-consumption-locations
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappListConsumptionLocations(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappShow(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappStart(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappStop(this ICakeContext context) {
        }

        /// <summary>
        /// az functionapp update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFunctionappUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment operation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment operation show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentExport(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentShow(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment validate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentValidate(this ICakeContext context) {
        }

        /// <summary>
        /// az group deployment wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDeploymentWait(this ICakeContext context) {
        }

        /// <summary>
        /// az group lock create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az group lock delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az group lock list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockList(this ICakeContext context) {
        }

        /// <summary>
        /// az group lock show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// az group lock update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az group exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupExists(this ICakeContext context) {
        }

        /// <summary>
        /// az group export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupExport(this ICakeContext context) {
        }

        /// <summary>
        /// az group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az group wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzGroupWait(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight application create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight application delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight application list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationList(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight application show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight application wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightApplicationWait(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight monitor disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight monitor enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight monitor show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightMonitorShow(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action execute
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionExecute(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionList(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action list-execution-history
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionListExecutionHistory(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action promote
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionPromote(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight script-action show-execution-details
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightScriptActionShowExecutionDetails(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightList(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight list-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight resize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightResize(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight rotate-disk-encryption-key
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightRotateDiskEncryptionKey(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightShow(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az hdinsight wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzHdinsightWait(this ICakeContext context) {
        }

        /// <summary>
        /// az identity create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az identity delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az identity list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityList(this ICakeContext context) {
        }

        /// <summary>
        /// az identity list-operations
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityListOperations(this ICakeContext context) {
        }

        /// <summary>
        /// az identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az image template customizer add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az image template customizer clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerClear(this ICakeContext context) {
        }

        /// <summary>
        /// az image template customizer remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCustomizerRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az image template output add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az image template output clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputClear(this ICakeContext context) {
        }

        /// <summary>
        /// az image template output remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateOutputRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az image template create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az image template delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az image template list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateList(this ICakeContext context) {
        }

        /// <summary>
        /// az image template run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateRun(this ICakeContext context) {
        }

        /// <summary>
        /// az image template show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az image template show-runs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateShowRuns(this ICakeContext context) {
        }

        /// <summary>
        /// az image template update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az image template wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageTemplateWait(this ICakeContext context) {
        }

        /// <summary>
        /// az image create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az image delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az image show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az image update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzImageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps access-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps access-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps access-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps access-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps access-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsAccessPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate generate-verification-code
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateGenerateVerificationCode(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps certificate verify
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCertificateVerify(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps linked-hub create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps linked-hub delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps linked-hub list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps linked-hub show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps linked-hub update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsLinkedHubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot dps update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotDpsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate generate-verification-code
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateGenerateVerificationCode(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub certificate verify
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCertificateVerify(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub consumer-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub consumer-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub consumer-group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub consumer-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubConsumerGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub devicestream show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubDevicestreamShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub job cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub job list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub job show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubJobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub message-enrichment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub message-enrichment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub message-enrichment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub message-enrichment update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubMessageEnrichmentUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub policy renew-key
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyRenewKey(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route test
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteTest(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub route update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub routing-endpoint create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub routing-endpoint delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub routing-endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub routing-endpoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubRoutingEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub manual-failover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubManualFailover(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub show-connection-string
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub show-quota-metrics
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowQuotaMetrics(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub show-stats
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubShowStats(this ICakeContext context) {
        }

        /// <summary>
        /// az iot hub update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotHubUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp key create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp key delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp key update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpKeyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository get-provision-status
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryGetProvisionStatus(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryList(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iot pnp repository update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotPnpRepositoryUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az iotcentral app create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az iotcentral app delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az iotcentral app list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppList(this ICakeContext context) {
        }

        /// <summary>
        /// az iotcentral app show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppShow(this ICakeContext context) {
        }

        /// <summary>
        /// az iotcentral app update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzIotcentralAppUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate contact add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate contact delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate contact list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateContactList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer admin add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer admin delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer admin list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate issuer update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateIssuerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate pending delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate pending merge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingMerge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate pending show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePendingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate get-default-policy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateGetDefaultPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateImport(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate list-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificatePurge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate set-attributes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateSetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault certificate show-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCertificateShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key backup
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyBackup(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyImport(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key list-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyPurge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key set-attributes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeySetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault key show-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultKeyShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret backup
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretBackup(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret list-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretPurge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretSet(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret set-attributes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretSetAttributes(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault secret show-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSecretShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition show-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage sas-definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageSasDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage backup
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageBackup(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStoragePurge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage regenerate-key
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRegenerateKey(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage show-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageShowDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault storage update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultStorageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault delete-policy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultDeletePolicy(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultList(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault purge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultPurge(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault recover
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultRecover(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault set-policy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultSetPolicy(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultShow(this ICakeContext context) {
        }

        /// <summary>
        /// az keyvault update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKeyvaultUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterStart(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterStop(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto cluster wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoClusterWait(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseList(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseShow(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az kusto database wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzKustoDatabaseWait(this ICakeContext context) {
        }

        /// <summary>
        /// az lab arm-template list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArmTemplateList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab arm-template show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArmTemplateShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab artifact list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab artifact-source list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactSourceList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab artifact-source show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabArtifactSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab custom-image create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az lab custom-image delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab custom-image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab custom-image show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabCustomImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab environment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az lab environment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab environment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab environment show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabEnvironmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab formula delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab formula export-artifacts
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaExportArtifacts(this ICakeContext context) {
        }

        /// <summary>
        /// az lab formula list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab formula show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabFormulaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab gallery-image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabGalleryImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab secret delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab secret list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab secret set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretSet(this ICakeContext context) {
        }

        /// <summary>
        /// az lab secret show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabSecretShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm apply-artifacts
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmApplyArtifacts(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm claim
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmClaim(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmStart(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vm stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVmStop(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vnet get
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVnetGet(this ICakeContext context) {
        }

        /// <summary>
        /// az lab vnet list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// az lab delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lab get
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLabGet(this ICakeContext context) {
        }

        /// <summary>
        /// az lock create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az lock delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az lock list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockList(this ICakeContext context) {
        }

        /// <summary>
        /// az lock show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// az lock update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappList(this ICakeContext context) {
        }

        /// <summary>
        /// az managedapp show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedappShow(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices assignment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices assignment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices assignment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices assignment show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesAssignmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az managedservices definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzManagedservicesDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az maps account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMapsAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb db create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb db delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb db list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb db show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server configuration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server configuration set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server configuration show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server firewall-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server firewall-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server firewall-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server firewall-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server firewall-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server replica create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server replica list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server replica stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server vnet-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server vnet-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server vnet-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server vnet-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server vnet-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server georestore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerList(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server-logs download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az mariadb server-logs list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMariadbServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group enable-receiver
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupEnableReceiver(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor action-group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActionGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert action-group add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertActionGroupAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert action-group remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertActionGroupRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert scope add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertScopeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert scope remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertScopeRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log alert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor activity-log list-categories
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorActivityLogListCategories(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale profile create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale profile delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale profile list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale profile list-timezones
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileListTimezones(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale profile show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale rule copy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleCopy(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor autoscale update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorAutoscaleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings categories list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCategoriesList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings categories show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCategoriesShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor diagnostic-settings update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorDiagnosticSettingsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace pack disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace pack enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace pack list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspacePackList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace get-schema
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceGetSchema(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace get-shared-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceGetSharedKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace list-management-groups
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceListManagementGroups(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace list-usages
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-analytics workspace update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogAnalyticsWorkspaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-profiles create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-profiles delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-profiles list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-profiles show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor log-profiles update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorLogProfilesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics alert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics alert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics alert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics alert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics alert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsList(this ICakeContext context) {
        }

        /// <summary>
        /// az monitor metrics list-definitions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMonitorMetricsListDefinitions(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql db create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql db delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql db list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql db show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server configuration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server configuration set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server configuration show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server firewall-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server firewall-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server firewall-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server firewall-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server firewall-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server replica create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server replica list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server replica stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server vnet-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server vnet-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server vnet-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server vnet-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server vnet-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server georestore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerList(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server-logs download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az mysql server-logs list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzMysqlServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account ad add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account ad list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account ad remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountAdRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles pool update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles snapshot create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles snapshot delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles snapshot list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles snapshot show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesSnapshotShow(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume export-policy add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume export-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume export-policy remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeExportPolicyRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeList(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles volume update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesVolumeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az netappfiles list-mount-targets
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetappfilesListMountTargets(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway address-pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway address-pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway address-pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway address-pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway address-pool update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAddressPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway auth-cert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway auth-cert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway auth-cert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway auth-cert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway auth-cert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayAuthCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-ip create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-ip delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-ip list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-ip show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-ip update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-port create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-port delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-port list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-port show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway frontend-port update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayFrontendPortUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-listener create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-listener delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-listener list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-listener show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-listener update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpListenerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-settings create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-settings delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-settings list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-settings show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway http-settings update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayHttpSettingsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway probe create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway probe delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway probe list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway probe show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway probe update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayProbeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway redirect-config create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway redirect-config delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway redirect-config list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway redirect-config show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway redirect-config update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRedirectConfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition list-server-variables
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionListServerVariables(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule condition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleConditionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule set create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule set delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule set list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule set show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule set update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleSetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule list-request-headers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleListRequestHeaders(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule list-response-headers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleListResponseHeaders(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rewrite-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRewriteRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway root-cert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway root-cert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway root-cert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway root-cert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway root-cert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRootCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-cert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-cert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-cert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-cert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-cert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslCertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-policy predefined list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyPredefinedList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-policy predefined show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyPredefinedShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-policy list-options
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyListOptions(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-policy set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicySet(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway ssl-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewaySslPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway url-path-map update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUrlPathMapUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-config list-rule-sets
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigListRuleSets(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-config set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-config show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule match-condition add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule match-condition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule match-condition remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleMatchConditionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy custom-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCustomRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule exclusion add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule exclusion list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule exclusion remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleExclusionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule rule-set add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule rule-set list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule rule-set remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy managed-rule rule-set update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyManagedRuleRuleSetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy policy-setting list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyPolicySettingList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy policy-setting update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyPolicySettingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway waf-policy wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWafPolicyWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway show-backend-health
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayShowBackendHealth(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayStart(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayStop(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network application-gateway wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkApplicationGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network asg create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network asg delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network asg list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgList(this ICakeContext context) {
        }

        /// <summary>
        /// az network asg show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network asg update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkAsgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network ddos-protection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network ddos-protection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network ddos-protection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network ddos-protection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network ddos-protection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDdosProtectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetACreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetADelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetARemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set a update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set aaaa update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetAaaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set caa update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname set-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameSetRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set cname show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetCnameShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set mx update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetMxUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ns update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetNsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set ptr update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetPtrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set soa show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSoaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set soa update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSoaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set srv update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetSrvUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set txt update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetTxtUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns record-set list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsRecordSetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneExport(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneImport(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneList(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns zone update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsZoneUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network dns list-references
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkDnsListReferences(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route auth create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route auth delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route auth list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route auth show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteAuthShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway connection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway connection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway connection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway connection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway connection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route gateway update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering connection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering connection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering connection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering peer-connection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringPeerConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering peer-connection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringPeerConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route peering update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port link list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port link show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port link update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLinkUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port location list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLocationList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port location show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortLocationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route port update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRoutePortUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route get-stats
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteGetStats(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route list-arp-tables
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListArpTables(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route list-route-tables
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListRouteTables(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route list-service-providers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteListServiceProviders(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network express-route wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkExpressRouteWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb address-pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb address-pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb address-pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb address-pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbAddressPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb frontend-ip create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb frontend-ip delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb frontend-ip list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb frontend-ip show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb frontend-ip update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbFrontendIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-pool update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb inbound-nat-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbInboundNatRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb outbound-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb outbound-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb outbound-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb outbound-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb outbound-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbOutboundRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb probe create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb probe delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb probe list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb probe show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb probe update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbProbeUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbList(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network lb update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network local-gateway wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkLocalGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nat gateway wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNatGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config address-pool add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigAddressPoolAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config address-pool remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigAddressPoolRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config inbound-nat-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigInboundNatRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config inbound-nat-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigInboundNatRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigList(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic ip-config update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicIpConfigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicList(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic list-effective-nsg
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicListEffectiveNsg(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic show-effective-route-table
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicShowEffectiveRouteTable(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nic wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNicWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgList(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network nsg update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkNsgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns link vnet wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsLinkVnetWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetACreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetADelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetARemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set a update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set aaaa update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetAaaaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname set-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameSetRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set cname update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetCnameUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set mx update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetMxUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set ptr update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetPtrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set soa show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSoaShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set soa update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSoaUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set srv update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetSrvUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt add-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtAddRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt remove-record
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtRemoveRecord(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set txt update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetTxtUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns record-set list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsRecordSetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-dns zone wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateDnsZoneWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint list-types
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointListTypes(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-endpoint update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service connection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service connection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceList(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network private-link-service update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPrivateLinkServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network profile delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network profile list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// az network profile show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip prefix create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip prefix delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip prefix list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixList(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip prefix show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip prefix update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpPrefixUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpList(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network public-ip update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkPublicIpUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule list-service-communities
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleListServiceCommunities(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterList(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-filter update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteFilterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table route create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table route delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table route list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteList(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table route show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table route update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableRouteUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableList(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network route-table update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkRouteTableUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy-definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy-definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy-definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy-definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint policy-definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointPolicyDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network service-endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkServiceEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointList(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint show-geographic-hierarchy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointShowGeographicHierarchy(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager endpoint update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerEndpointUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile check-dns
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileCheckDns(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileList(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network traffic-manager profile update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkTrafficManagerProfileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet peering create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet peering delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet peering list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet peering show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet peering update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetPeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet list-available-delegations
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetListAvailableDelegations(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet subnet update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetSubnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet check-ip-address
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetCheckIpAddress(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet list-endpoint-services
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetListEndpointServices(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway aad assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway aad remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway aad show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayAadShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway ipsec-policy add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway ipsec-policy clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyClear(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway ipsec-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayIpsecPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway revoked-cert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRevokedCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway revoked-cert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRevokedCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway root-cert create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRootCertCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway root-cert delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayRootCertDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway vpn-client generate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayVpnClientGenerate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway vpn-client show-url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayVpnClientShowUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway list-advertised-routes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListAdvertisedRoutes(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway list-bgp-peer-status
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListBgpPeerStatus(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway list-learned-routes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayListLearnedRoutes(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayReset(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vnet-gateway wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVnetGatewayWait(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection ipsec-policy add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection ipsec-policy clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyClear(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection ipsec-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionIpsecPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection shared-key reset
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyReset(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection shared-key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection shared-key update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionSharedKeyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vpn-connection update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVpnConnectionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter peering create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter peering delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter peering list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter peering show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter peering update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterPeeringUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterList(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network vrouter update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkVrouterUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorList(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor query
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorQuery(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorStart(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher connection-monitor stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConnectionMonitorStop(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher flow-log configure
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherFlowLogConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher flow-log show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherFlowLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureList(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture show-status
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureShowStatus(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher packet-capture stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherPacketCaptureStop(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher troubleshooting show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTroubleshootingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher troubleshooting start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTroubleshootingStart(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher configure
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherList(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher run-configuration-diagnostic
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherRunConfigurationDiagnostic(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher show-next-hop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowNextHop(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher show-security-group-view
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowSecurityGroupView(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher show-topology
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherShowTopology(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher test-connectivity
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTestConnectivity(this ICakeContext context) {
        }

        /// <summary>
        /// az network watcher test-ip-flow
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkWatcherTestIpFlow(this ICakeContext context) {
        }

        /// <summary>
        /// az network list-service-tags
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkListServiceTags(this ICakeContext context) {
        }

        /// <summary>
        /// az network list-usages
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzNetworkListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftList(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift scale
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftScale(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftShow(this ICakeContext context) {
        }

        /// <summary>
        /// az openshift wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzOpenshiftWait(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy assignment show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyAssignmentShow(this ICakeContext context) {
        }

        /// <summary>
        /// az policy definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az policy definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az policy definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy event list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyEventList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation deployment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationDeploymentList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy remediation show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyRemediationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az policy set-definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy set-definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az policy set-definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy set-definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az policy set-definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicySetDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az policy state list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyStateList(this ICakeContext context) {
        }

        /// <summary>
        /// az policy state summarize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPolicyStateSummarize(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres db create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres db delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres db list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres db show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server configuration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server configuration set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationSet(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server configuration show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerConfigurationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server firewall-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server firewall-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server firewall-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server firewall-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server firewall-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server replica create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server replica list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server replica stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerReplicaStop(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server vnet-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server vnet-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server vnet-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server vnet-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server vnet-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server georestore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerGeorestore(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerList(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server-logs download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerLogsDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az postgres server-logs list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPostgresServerLogsList(this ICakeContext context) {
        }

        /// <summary>
        /// az ppg create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az ppg delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az ppg list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgList(this ICakeContext context) {
        }

        /// <summary>
        /// az ppg show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgShow(this ICakeContext context) {
        }

        /// <summary>
        /// az ppg update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzPpgUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az provider operation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderOperationList(this ICakeContext context) {
        }

        /// <summary>
        /// az provider operation show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderOperationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az provider list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderList(this ICakeContext context) {
        }

        /// <summary>
        /// az provider register
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderRegister(this ICakeContext context) {
        }

        /// <summary>
        /// az provider show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderShow(this ICakeContext context) {
        }

        /// <summary>
        /// az provider unregister
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzProviderUnregister(this ICakeContext context) {
        }

        /// <summary>
        /// az redis firewall-rules create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis firewall-rules delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az redis firewall-rules list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesList(this ICakeContext context) {
        }

        /// <summary>
        /// az redis firewall-rules show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesShow(this ICakeContext context) {
        }

        /// <summary>
        /// az redis firewall-rules update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisFirewallRulesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis patch-schedule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis patch-schedule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az redis patch-schedule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az redis patch-schedule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisPatchScheduleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis server-link create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis server-link delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az redis server-link list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// az redis server-link show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisServerLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// az redis create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az redis delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az redis export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisExport(this ICakeContext context) {
        }

        /// <summary>
        /// az redis force-reboot
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisForceReboot(this ICakeContext context) {
        }

        /// <summary>
        /// az redis import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisImport(this ICakeContext context) {
        }

        /// <summary>
        /// az redis list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisList(this ICakeContext context) {
        }

        /// <summary>
        /// az redis list-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisListKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az redis regenerate-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisRegenerateKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az redis show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisShow(this ICakeContext context) {
        }

        /// <summary>
        /// az redis update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRedisUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay hyco update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayHycoUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay namespace update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayList(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayShow(this ICakeContext context) {
        }

        /// <summary>
        /// az relay wcfrelay update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRelayWcfrelayUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations catalog show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsCatalogShow(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationList(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation list-history
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationListHistory(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation merge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationMerge(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation split
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationSplit(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation-order calculate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderCalculate(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation-order list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderList(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation-order purchase
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderPurchase(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation-order show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderShow(this ICakeContext context) {
        }

        /// <summary>
        /// az reservations reservation-order-id list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzReservationsReservationOrderIdList(this ICakeContext context) {
        }

        /// <summary>
        /// az resource link create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource link delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az resource link list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkList(this ICakeContext context) {
        }

        /// <summary>
        /// az resource link show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkShow(this ICakeContext context) {
        }

        /// <summary>
        /// az resource link update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLinkUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource lock create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource lock delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az resource lock list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockList(this ICakeContext context) {
        }

        /// <summary>
        /// az resource lock show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockShow(this ICakeContext context) {
        }

        /// <summary>
        /// az resource lock update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceLockUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az resource invoke-action
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceInvokeAction(this ICakeContext context) {
        }

        /// <summary>
        /// az resource list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceList(this ICakeContext context) {
        }

        /// <summary>
        /// az resource move
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceMove(this ICakeContext context) {
        }

        /// <summary>
        /// az resource show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az resource tag
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceTag(this ICakeContext context) {
        }

        /// <summary>
        /// az resource update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az resource wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzResourceWait(this ICakeContext context) {
        }

        /// <summary>
        /// az role assignment create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az role assignment delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az role assignment list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentList(this ICakeContext context) {
        }

        /// <summary>
        /// az role assignment list-changelogs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleAssignmentListChangelogs(this ICakeContext context) {
        }

        /// <summary>
        /// az role definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az role definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az role definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az role definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRoleDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az search admin-key renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchAdminKeyRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az search admin-key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchAdminKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az search query-key create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az search query-key delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az search query-key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchQueryKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az search service create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az search service delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az search service list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceList(this ICakeContext context) {
        }

        /// <summary>
        /// az search service show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az search service update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSearchServiceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az security alert list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertList(this ICakeContext context) {
        }

        /// <summary>
        /// az security alert show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security alert update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAlertUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az security auto-provisioning-setting list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingList(this ICakeContext context) {
        }

        /// <summary>
        /// az security auto-provisioning-setting show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security auto-provisioning-setting update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityAutoProvisioningSettingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az security contact create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az security contact delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az security contact list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactList(this ICakeContext context) {
        }

        /// <summary>
        /// az security contact show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityContactShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security discovered-security-solution list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityDiscoveredSecuritySolutionList(this ICakeContext context) {
        }

        /// <summary>
        /// az security discovered-security-solution show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityDiscoveredSecuritySolutionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security external-security-solution list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityExternalSecuritySolutionList(this ICakeContext context) {
        }

        /// <summary>
        /// az security external-security-solution show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityExternalSecuritySolutionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security jit-policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityJitPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az security jit-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityJitPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security location list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityLocationList(this ICakeContext context) {
        }

        /// <summary>
        /// az security location show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityLocationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security pricing create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az security pricing list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingList(this ICakeContext context) {
        }

        /// <summary>
        /// az security pricing show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityPricingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security setting list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecuritySettingList(this ICakeContext context) {
        }

        /// <summary>
        /// az security setting show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecuritySettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security task list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTaskList(this ICakeContext context) {
        }

        /// <summary>
        /// az security task show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTaskShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security topology list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTopologyList(this ICakeContext context) {
        }

        /// <summary>
        /// az security topology show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityTopologyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az security workspace-setting create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az security workspace-setting delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az security workspace-setting list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingList(this ICakeContext context) {
        }

        /// <summary>
        /// az security workspace-setting show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSecurityWorkspaceSettingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias break-pair
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasBreakPair(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasExists(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias fail-over
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasFailOver(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus georecovery-alias show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusGeorecoveryAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus migration abort
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationAbort(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus migration complete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationComplete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus migration show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus migration start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusMigrationStart(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceExists(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus namespace update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusNamespaceUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus queue update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusQueueUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic authorization-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicAuthorizationRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic subscription update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicSubscriptionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicList(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az servicebus topic update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzServicebusTopicUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sf application certificate add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfApplicationCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster certificate add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster certificate remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCertificateRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster client-certificate add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterClientCertificateAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster client-certificate remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterClientCertificateRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster durability update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterDurabilityUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster node add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster node remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster node-type add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterNodeTypeAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster reliability update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterReliabilityUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster setting remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterSettingRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster setting set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterSettingSet(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster upgrade-type set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterUpgradeTypeSet(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// az sf cluster show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSfClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-definition create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-definition delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-definition list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionList(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-definition show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-definition update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageDefinitionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionList(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sig image-version wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigImageVersionWait(this ICakeContext context) {
        }

        /// <summary>
        /// az sig create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sig delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sig list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigList(this ICakeContext context) {
        }

        /// <summary>
        /// az sig show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sig update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSigUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr cors add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr cors list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsList(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr cors remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr key renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrKeyRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrList(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrShow(this ICakeContext context) {
        }

        /// <summary>
        /// az signalr update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSignalrUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot grant-access
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotGrantAccess(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot revoke-access
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotRevokeAccess(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotShow(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az snapshot wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSnapshotWait(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db audit-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbAuditPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db audit-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbAuditPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db op cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbOpCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db op list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbOpList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db replica create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db replica delete-link
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaDeleteLink(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db replica list-links
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaListLinks(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db replica set-primary
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbReplicaSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db tde list-activity
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeListActivity(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db tde set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeSet(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db tde show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbTdeShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db threat-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbThreatPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db threat-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbThreatPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db copy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbCopy(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db export
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbExport(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db import
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbImport(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db list-deleted
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListDeleted(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db list-editions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListEditions(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db list-usages
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db rename
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbRename(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db show-connection-string
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// az sql db update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDbUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw pause
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwPause(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw resume
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwResume(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql dw update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlDwUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool op cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolOpCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool op list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolOpList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool list-dbs
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolListDbs(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool list-editions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolListEditions(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql elastic-pool update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlElasticPoolUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group set-primary
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql failover-group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlFailoverGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql instance-failover-group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql instance-failover-group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql instance-failover-group set-primary
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupSetPrimary(this ICakeContext context) {
        }

        /// <summary>
        /// az sql instance-failover-group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql instance-failover-group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlInstanceFailoverGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi ad-admin create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi ad-admin delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi ad-admin list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi ad-admin update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiAdAdminUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi key create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi key delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi tde-key set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiTdeKeySet(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi tde-key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiTdeKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql mi update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMiUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql midb create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql midb delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql midb list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql midb restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az sql midb show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlMidbShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server ad-admin create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server ad-admin delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server ad-admin list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server ad-admin update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerAdAdminUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server conn-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerConnPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server conn-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerConnPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server dns-alias create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server dns-alias delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server dns-alias list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server dns-alias set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasSet(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server dns-alias show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDnsAliasShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server firewall-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server firewall-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server firewall-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server firewall-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server firewall-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerFirewallRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server key create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server key delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server key list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server tde-key set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerTdeKeySet(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server tde-key show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerTdeKeyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server vnet-rule create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server vnet-rule delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server vnet-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server vnet-rule show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server vnet-rule update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerVnetRuleUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server list-usages
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql server wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlServerWait(this ICakeContext context) {
        }

        /// <summary>
        /// az sql virtual-cluster delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql virtual-cluster list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql virtual-cluster show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVirtualClusterShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group ag-listener create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group ag-listener delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group ag-listener list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group ag-listener show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group ag-listener update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupAgListenerUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm add-to-group
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmAddToGroup(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmList(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm remove-from-group
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmRemoveFromGroup(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// az sql vm update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlVmUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az sql list-usages
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlListUsages(this ICakeContext context) {
        }

        /// <summary>
        /// az sql show-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzSqlShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account keys list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountKeysList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account keys renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountKeysRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account management-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account management-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account management-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account management-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountManagementPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account network-rule add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account network-rule list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account network-rule remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountNetworkRuleRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account check-name
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountCheckName(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account revoke-delegation-keys
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountRevokeDelegationKeys(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account show-connection-string
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShowConnectionString(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account show-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountShowUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az storage account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob copy cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob copy start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob copy start-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobCopyStartBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob incremental-copy cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobIncrementalCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob incremental-copy start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobIncrementalCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob lease acquire
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseAcquire(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob lease break
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseBreak(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob lease change
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseChange(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob lease release
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseRelease(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob lease renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobLeaseRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob service-properties delete-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesDeletePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob service-properties delete-policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesDeletePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob service-properties show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob service-properties update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobServicePropertiesUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob delete-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDeleteBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob download-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobDownloadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob set-tier
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSetTier(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob snapshot
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSnapshot(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob sync
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobSync(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob undelete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUndelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob upload-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUploadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage blob url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageBlobUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container immutability-policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container immutability-policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container immutability-policy extend
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyExtend(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container immutability-policy lock
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyLock(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container immutability-policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerImmutabilityPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container lease acquire
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseAcquire(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container lease break
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseBreak(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container lease change
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseChange(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container lease release
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseRelease(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container lease renew
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLeaseRenew(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container legal-hold clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldClear(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container legal-hold set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldSet(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container legal-hold show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerLegalHoldShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerPolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container set-permission
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerSetPermission(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage container show-permission
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageContainerShowPermission(this ICakeContext context) {
        }

        /// <summary>
        /// az storage cors add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az storage cors clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsClear(this ICakeContext context) {
        }

        /// <summary>
        /// az storage cors list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCorsList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage directory show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageDirectoryShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity insert
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityInsert(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity merge
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityMerge(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity query
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityQuery(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity replace
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityReplace(this ICakeContext context) {
        }

        /// <summary>
        /// az storage entity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageEntityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file copy cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file copy start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyStart(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file copy start-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileCopyStartBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file delete-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDeleteBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file download-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileDownloadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file resize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileResize(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file upload-batch
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUploadBatch(this ICakeContext context) {
        }

        /// <summary>
        /// az storage file url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageFileUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az storage logging show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageLoggingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage logging update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageLoggingUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageClear(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message get
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageGet(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message peek
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessagePeek(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message put
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessagePut(this ICakeContext context) {
        }

        /// <summary>
        /// az storage message update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMessageUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage metrics show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMetricsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage metrics update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageMetricsUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueuePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage queue stats
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageQueueStats(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share metadata show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareMetadataShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share metadata update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareMetadataUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageSharePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share snapshot
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareSnapshot(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share stats
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareStats(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage share url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageShareUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table policy create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table policy delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table policy list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table policy show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyShow(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table policy update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTablePolicyUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table exists
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableExists(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table generate-sas
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableGenerateSas(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableList(this ICakeContext context) {
        }

        /// <summary>
        /// az storage table stats
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageTableStats(this ICakeContext context) {
        }

        /// <summary>
        /// az storage copy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageCopy(this ICakeContext context) {
        }

        /// <summary>
        /// az storage remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzStorageRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az tag add-value
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagAddValue(this ICakeContext context) {
        }

        /// <summary>
        /// az tag create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az tag delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az tag list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagList(this ICakeContext context) {
        }

        /// <summary>
        /// az tag remove-value
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzTagRemoveValue(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set convert
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetConvert(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set list-sizes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetListSizes(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm availability-set update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmAvailabilitySetUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm boot-diagnostics disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az vm boot-diagnostics enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az vm boot-diagnostics get-boot-log
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmBootDiagnosticsGetBootLog(this ICakeContext context) {
        }

        /// <summary>
        /// az vm diagnostics get-default-config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiagnosticsGetDefaultConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az vm diagnostics set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiagnosticsSet(this ICakeContext context) {
        }

        /// <summary>
        /// az vm disk attach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// az vm disk detach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// az vm encryption disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az vm encryption enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az vm encryption show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmEncryptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension image list-names
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageListNames(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension image list-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension image show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionSet(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm extension wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmExtensionWait(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host group create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host group delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host group list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host group show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host group update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGroupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host get-instance-view
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm host update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmHostUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az vm identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az vm identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image terms accept
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsAccept(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image terms cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image terms show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageTermsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image accept-terms
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageAcceptTerms(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image list-offers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListOffers(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image list-publishers
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListPublishers(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az vm image show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm monitor log show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmMonitorLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm nic add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az vm nic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm nic remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az vm nic set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicSet(this ICakeContext context) {
        }

        /// <summary>
        /// az vm nic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm run-command invoke
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandInvoke(this ICakeContext context) {
        }

        /// <summary>
        /// az vm run-command list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm run-command show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRunCommandShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm secret add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az vm secret format
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretFormat(this ICakeContext context) {
        }

        /// <summary>
        /// az vm secret list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm secret remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmSecretRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az vm unmanaged-disk attach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// az vm unmanaged-disk detach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// az vm unmanaged-disk list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUnmanagedDiskList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm user delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm user reset-ssh
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserResetSsh(this ICakeContext context) {
        }

        /// <summary>
        /// az vm user update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUserUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm capture
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmCapture(this ICakeContext context) {
        }

        /// <summary>
        /// az vm convert
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmConvert(this ICakeContext context) {
        }

        /// <summary>
        /// az vm create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm deallocate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDeallocate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vm generalize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmGeneralize(this ICakeContext context) {
        }

        /// <summary>
        /// az vm get-instance-view
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmList(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list-ip-addresses
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListIpAddresses(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list-sizes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListSizes(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list-usage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListUsage(this ICakeContext context) {
        }

        /// <summary>
        /// az vm list-vm-resize-options
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmListVmResizeOptions(this ICakeContext context) {
        }

        /// <summary>
        /// az vm open-port
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmOpenPort(this ICakeContext context) {
        }

        /// <summary>
        /// az vm perform-maintenance
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmPerformMaintenance(this ICakeContext context) {
        }

        /// <summary>
        /// az vm redeploy
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRedeploy(this ICakeContext context) {
        }

        /// <summary>
        /// az vm resize
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmResize(this ICakeContext context) {
        }

        /// <summary>
        /// az vm restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az vm show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vm start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmStart(this ICakeContext context) {
        }

        /// <summary>
        /// az vm stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmStop(this ICakeContext context) {
        }

        /// <summary>
        /// az vm update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vm wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmWait(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss diagnostics get-default-config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiagnosticsGetDefaultConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss diagnostics set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiagnosticsSet(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss disk attach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiskAttach(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss disk detach
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDiskDetach(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss encryption disable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionDisable(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss encryption enable
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionEnable(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss encryption show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssEncryptionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension image list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageList(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension image list-names
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageListNames(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension image list-versions
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageListVersions(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension image show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionImageShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionList(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionSet(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss extension show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssExtensionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss nic list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicList(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss nic list-vm-nics
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicListVmNics(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss nic show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssNicShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss rolling-upgrade cancel
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeCancel(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss rolling-upgrade get-latest
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeGetLatest(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss rolling-upgrade start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRollingUpgradeStart(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss run-command invoke
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandInvoke(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss run-command list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandList(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss run-command show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRunCommandShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss deallocate
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDeallocate(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss delete-instances
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssDeleteInstances(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss get-instance-view
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssGetInstanceView(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss get-os-upgrade-history
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssGetOsUpgradeHistory(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssList(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss list-instance-connection-info
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstanceConnectionInfo(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss list-instance-public-ips
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstancePublicIps(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss list-instances
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListInstances(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss list-skus
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssListSkus(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss perform-maintenance
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssPerformMaintenance(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss reimage
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssReimage(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss scale
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssScale(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssShow(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssStart(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssStop(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss update-instances
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssUpdateInstances(this ICakeContext context) {
        }

        /// <summary>
        /// az vmss wait
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzVmssWait(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp auth show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappAuthShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp auth update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappAuthUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config access-restriction add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config access-restriction remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config access-restriction set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config access-restriction show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAccessRestrictionShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config appsettings delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config appsettings list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config appsettings set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigAppsettingsSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config backup create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config backup list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config backup restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config backup show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config backup update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigBackupUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config connection-string delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config connection-string list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config connection-string set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigConnectionStringSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config container delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config container set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config container show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigContainerShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config hostname add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config hostname delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config hostname get-external-ip
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameGetExternalIp(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config hostname list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigHostnameList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config snapshot list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSnapshotList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config snapshot restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSnapshotRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config ssl bind
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslBind(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config ssl delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config ssl list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config ssl unbind
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslUnbind(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config ssl upload
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSslUpload(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config storage-account add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config storage-account delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config storage-account list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config storage-account update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigStorageAccountUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp config show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappConfigShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp cors add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp cors remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp cors show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCorsShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deleted list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeletedList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deleted restore
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeletedRestore(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment container config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentContainerConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment container show-cd-url
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentContainerShowCdUrl(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment slot auto-swap
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotAutoSwap(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment slot create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment slot delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment slot list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment slot swap
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSlotSwap(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source config-local-git
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfigLocalGit(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source config-zip
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceConfigZip(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source sync
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceSync(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment source update-token
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentSourceUpdateToken(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment user set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentUserSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment user show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentUserShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment list-publishing-credentials
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentListPublishingCredentials(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp deployment list-publishing-profiles
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDeploymentListPublishingProfiles(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp hybrid-connection add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp hybrid-connection list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp hybrid-connection remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappHybridConnectionRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp identity assign
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityAssign(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp identity remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp identity show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappIdentityShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp log config
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogConfig(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp log download
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogDownload(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp log show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp log tail
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappLogTail(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp traffic-routing clear
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingClear(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp traffic-routing set
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingSet(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp traffic-routing show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappTrafficRoutingShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp vnet-integration add
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationAdd(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp vnet-integration list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp vnet-integration remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappVnetIntegrationRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob continuous list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob continuous remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob continuous start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousStart(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob continuous stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobContinuousStop(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob triggered list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob triggered log
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredLog(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob triggered remove
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredRemove(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp webjob triggered run
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappWebjobTriggeredRun(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp browse
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappBrowse(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp create
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCreate(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp create-remote-connection
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappCreateRemoteConnection(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp delete
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappDelete(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp list
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappList(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp list-runtimes
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappListRuntimes(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp restart
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappRestart(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp show
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappShow(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp ssh
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappSsh(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp start
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappStart(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp stop
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappStop(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp up
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappUp(this ICakeContext context) {
        }

        /// <summary>
        /// az webapp update
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzWebappUpdate(this ICakeContext context) {
        }

        /// <summary>
        /// az configure
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzConfigure(this ICakeContext context) {
        }

        /// <summary>
        /// az feedback
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFeedback(this ICakeContext context) {
        }

        /// <summary>
        /// az find
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzFind(this ICakeContext context) {
        }

        /// <summary>
        /// az interactive
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzInteractive(this ICakeContext context) {
        }

        /// <summary>
        /// az login
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLogin(this ICakeContext context) {
        }

        /// <summary>
        /// az logout
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzLogout(this ICakeContext context) {
        }

        /// <summary>
        /// az rest
        /// </summary>
        /// <returns></returns>
        [CakeMethodAlias]
        public static void AzRest(this ICakeContext context) {
        }

    }
}

