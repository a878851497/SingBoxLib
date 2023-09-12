﻿namespace SingBoxLib.Configuration.Route;

public sealed class GeositeConfig
{
    [JsonProperty("path")]
    public string? Path { get; set; }

    [JsonProperty("download_url")]
    public string? DownloadUrl { get; set; }

    [JsonProperty("download_detour")]
    public string? DownloadDetour { get; set; }
}