using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("width")]
    public int width { get; set; }

    [JsonProperty("height")]
    public int height { get; set; }

    [JsonProperty("scaleFactor")]
    public int scaleFactor { get; set; }

    [JsonProperty("imageName")]
    public string imageName { get; set; }

    [JsonProperty("expires")]
    public int expires { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("downloadURL")]
    public string downloadURL { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
