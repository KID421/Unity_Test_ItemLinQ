using UnityEngine;

public enum ItemType { weapon, prop };

[CreateAssetMenu(menuName = "KID/道具資料", fileName = "道具資料")]
public class ItemData : ScriptableObject
{
    public string _name;
    public Sprite sprite;
    public ItemType itemType;

    public bool A;
    public bool B;
}
