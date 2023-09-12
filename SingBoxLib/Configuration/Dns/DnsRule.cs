﻿namespace SingBoxLib.Configuration.Dns;

public sealed class DnsRule
{
    [JsonProperty("inbound")]
    public List<string>? Inbound { get; set; }

    [JsonProperty("ip_version")]
    public int? IpVersion { get; set; }

    [JsonProperty("query_type")]
    public List<object>? QueryType { get; set; }

    [JsonProperty("network")]
    public string? Network { get; set; }

    [JsonProperty("auth_user")]
    public List<string>? AuthUser { get; set; }

    [JsonProperty("protocol")]
    public List<string>? Protocol { get; set; }

    [JsonProperty("domain")]
    public List<string>? Domain { get; set; }

    [JsonProperty("domain_suffix")]
    public List<string>? DomainSuffix { get; set; }

    [JsonProperty("domain_keyword")]
    public List<string>? DomainKeyword { get; set; }

    [JsonProperty("domain_regex")]
    public List<string>? DomainRegex { get; set; }

    [JsonProperty("geosite")]
    public List<string>? Geosite { get; set; }

    [JsonProperty("source_geoip")]
    public List<string>? SourceGeoip { get; set; }

    [JsonProperty("source_ip_cidr")]
    public List<string>? SourceIpCidr { get; set; }

    [JsonProperty("source_port")]
    public List<int>? SourcePort { get; set; }

    [JsonProperty("source_port_range")]
    public List<string>? SourcePortRange { get; set; }

    [JsonProperty("port")]
    public List<int>? Port { get; set; }

    [JsonProperty("port_range")]
    public List<string>? PortRange { get; set; }

    [JsonProperty("process_name")]
    public List<string>? ProcessName { get; set; }

    [JsonProperty("process_path")]
    public List<string>? ProcessPath { get; set; }

    [JsonProperty("package_name")]
    public List<string>? PackageName { get; set; }

    [JsonProperty("user")]
    public List<string>? User { get; set; }

    [JsonProperty("user_id")]
    public List<int>? UserId { get; set; }

    [JsonProperty("clash_mode")]
    public string? ClashMode { get; set; }

    [JsonProperty("invert")]
    public bool? Invert { get; set; }

    [JsonProperty("outbound")]
    public List<string>? Outbound { get; set; }

    [JsonProperty("server")]
    public string? Server { get; set; }

    [JsonProperty("disable_cache")]
    public bool? DisableCache { get; set; }

    [JsonProperty("rewrite_ttl")]
    public int? RewriteTtl { get; set; }
}