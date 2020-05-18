using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>() {
                new Item(0, "Diamond Sword", "A sword made with diamond.",
                new Dictionary<string, int>
                {
                    {"Power", 15 },
                    {"Defence", 10 }
                }),
                new Item(1, "Diamond ore", "minecraft lmao",
                new Dictionary<string, int>
                {
                    {"Value", 999 }
                }),
                new Item(2, "Silver Pick", "Used for mining",
                new Dictionary<string, int>
                {
                    {"Power", 5 },
                    {"Mining", 333 }
                })
            };
    }
}
