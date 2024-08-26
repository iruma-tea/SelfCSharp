using System;

namespace SelfCSharp.Chap09;

public partial class MyPartial
{
    public string Greet()
    {
        return $"こんにちは、{this.LastName}{this.FirstName}さん！";
    }
}
