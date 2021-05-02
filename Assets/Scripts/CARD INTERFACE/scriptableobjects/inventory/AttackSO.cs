using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AttackSO : Consumable
{
    [Header("Attack Data")]
    [TextArea(2, 5)]
    [SerializeField] private string useText;

    public override string GetDisplayText()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(Name).AppendLine();
        builder.Append("<color=green>Use</color> : ").Append(useText).AppendLine();
        

        return builder.ToString();

    }
}
