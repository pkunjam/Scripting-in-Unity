using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class LinqItem
{
    public string name;
    public int id;
    public int buff;
}

public class Challenge2 : MonoBehaviour {

    public List<LinqItem> items = new List<LinqItem>();

    void Start ()
    {
        var check = items.Any(i => i.id == 3);
        Debug.Log("ItemID " + check);


        var newItems = items.Where(i => i.buff > 20);

        foreach (var item in newItems)
        {
            Debug.Log(item.buff);
        }

        Debug.Log("Average of buff stats " + items.Average(i => i.buff));
	}

}

