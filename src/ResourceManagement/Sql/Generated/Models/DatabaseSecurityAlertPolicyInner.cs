// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about a database Threat Detection policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseSecurityAlertPolicyInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseSecurityAlertPolicyInner
        /// class.
        /// </summary>
        public DatabaseSecurityAlertPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseSecurityAlertPolicyInner
        /// class.
        /// </summary>
        /// <param name="state">Specifies the state of the policy. If state is
        /// Enabled, storageEndpoint and storageAccountAccessKey are required.
        /// Possible values include: 'New', 'Enabled', 'Disabled'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="kind">Resource kind.</param>
        /// <param name="disabledAlerts">Specifies the semicolon-separated list
        /// of alerts that are disabled, or empty string to disable no alerts.
        /// Possible values: Sql_Injection; Sql_Injection_Vulnerability;
        /// Access_Anomaly; Usage_Anomaly.</param>
        /// <param name="emailAddresses">Specifies the semicolon-separated list
        /// of e-mail addresses to which the alert is sent.</param>
        /// <param name="emailAccountAdmins">Specifies that the alert is sent
        /// to the account administrators. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="storageEndpoint">Specifies the blob storage endpoint
        /// (e.g. https://MyAccount.blob.core.windows.net). This blob storage
        /// will hold all Threat Detection audit logs. If state is Enabled,
        /// storageEndpoint is required.</param>
        /// <param name="storageAccountAccessKey">Specifies the identifier key
        /// of the Threat Detection audit storage account. If state is Enabled,
        /// storageAccountAccessKey is required.</param>
        /// <param name="retentionDays">Specifies the number of days to keep in
        /// the Threat Detection audit logs.</param>
        /// <param name="useServerDefault">Specifies whether to use the default
        /// server policy. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public DatabaseSecurityAlertPolicyInner(SecurityAlertPolicyState state, string id = default(string), string name = default(string), string type = default(string), string location = default(string), string kind = default(string), string disabledAlerts = default(string), string emailAddresses = default(string), SecurityAlertPolicyEmailAccountAdmins? emailAccountAdmins = default(SecurityAlertPolicyEmailAccountAdmins?), string storageEndpoint = default(string), string storageAccountAccessKey = default(string), int? retentionDays = default(int?), SecurityAlertPolicyUseServerDefault? useServerDefault = default(SecurityAlertPolicyUseServerDefault?))
            : base(id, name, type)
        {
            Location = location;
            Kind = kind;
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            EmailAccountAdmins = emailAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            UseServerDefault = useServerDefault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource kind.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets or sets specifies the state of the policy. If state is
        /// Enabled, storageEndpoint and storageAccountAccessKey are required.
        /// Possible values include: 'New', 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public SecurityAlertPolicyState State { get; set; }

        /// <summary>
        /// Gets or sets specifies the semicolon-separated list of alerts that
        /// are disabled, or empty string to disable no alerts. Possible
        /// values: Sql_Injection; Sql_Injection_Vulnerability; Access_Anomaly;
        /// Usage_Anomaly.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disabledAlerts")]
        public string DisabledAlerts { get; set; }

        /// <summary>
        /// Gets or sets specifies the semicolon-separated list of e-mail
        /// addresses to which the alert is sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailAddresses")]
        public string EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets specifies that the alert is sent to the account
        /// administrators. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailAccountAdmins")]
        public SecurityAlertPolicyEmailAccountAdmins? EmailAccountAdmins { get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net). This blob storage will
        /// hold all Threat Detection audit logs. If state is Enabled,
        /// storageEndpoint is required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageEndpoint")]
        public string StorageEndpoint { get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier key of the Threat Detection
        /// audit storage account. If state is Enabled, storageAccountAccessKey
        /// is required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of days to keep in the Threat
        /// Detection audit logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionDays")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use the default server policy.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.useServerDefault")]
        public SecurityAlertPolicyUseServerDefault? UseServerDefault { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}