using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>();

    public void TypeOfProp()
    {
        var result = items.Where((x) => x.itemType == ItemType.prop);

        CreateItem(result);
    }

    private void CreateItem(IEnumerable<ItemData> result)
    {
        for (int i = 0; i < transform.childCount; i++) Destroy(transform.GetChild(i).gameObject);

        foreach (var item in result)
        {
            GameObject temp = Instantiate(new GameObject(), transform);
            temp.AddComponent<Image>().sprite = item.sprite;
        }
    }
}
