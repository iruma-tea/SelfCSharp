using System;

namespace SelfCSharp.Chap09;

public partial class MyPartial
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public string Show()
    {
        return $"名前は{this.LastName}{this.FirstName}";
    }
}
