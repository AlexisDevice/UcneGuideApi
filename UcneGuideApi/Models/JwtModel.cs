namespace UcneGuideApi.Models;

using System;
using System.Collections.Generic;

public class JwtModel
{
    public string Sub { get; set; }
    public string Iss { get; set; }
    public string Aud { get; set; }
    public DateTime Exp { get; set; }
    public List<string> Roles { get; set; }
    public string Name { get; set; }
}
