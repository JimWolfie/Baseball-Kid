using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Sundry: Consumable
{
    [Header("Sundry data")]
    [SerializeField]private string useText = "does stuff";

    public override string GetDisplayText()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(Name).AppendLine();
        builder.Append("<Color=green>Use: ").Append(useText).Append("</color").AppendLine();
        builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
        builder.Append("Sell Price: ").Append(SellPrice).Append(" gold").AppendLine();

        return builder.ToString();

    }
}
