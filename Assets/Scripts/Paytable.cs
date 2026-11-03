using UnityEngine;
using System.Collections.Generic;

public class Paytable : MonoBehaviour
{
    [System.Serializable]
    public class PayEntry
    {
        public string symbolName;
        public int threeOfAKind;
        public int twoOfAKind;
    }

    public List<PayEntry> paytable = new List<PayEntry>();

    public int GetPayout(string symbolName, int count)
    {
        foreach (var entry in paytable)
        {
            if (entry.symbolName == symbolName)
            {
                if (count >= 3) return entry.threeOfAKind;
                if (count == 2) return entry.twoOfAKind;
            }
        }
        return 0;
    }
}
