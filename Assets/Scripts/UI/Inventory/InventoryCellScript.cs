using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCellScript : ACell
{
    public int id=-1;
    public Text text;
    public bool selected = false;

    public void DrawCell(ItemScriptableObject item, int count, int id)
    {
        this.item = item;
        this.id = id;
        Image.sprite = item.itemSprite;
        Image.color = new Color(1, 1, 1, 1);
        text.text = count.ToString();
    }
    public override void ClearCell()
    {
        this.item = null;
        this.id = -1;
        Image.sprite = null;
        Image.color = new Color(1, 1, 1, 0);
        text.text = "";
    }

    public override void OnMouseEnter()
    {
        if (!selected)
        {
            gameObject.GetComponent<Image>().color = new Color(0.59f, 0.29f, 0.29f, 1);
        }

    }
    public override void OnMouseExit()
    {
        if (!selected)
        {
            gameObject.GetComponent<Image>().color = new Color(1f, 0.8f, 0.44f, 1);
        }
    }

    public virtual void OnMouseClick()
    {
        if(item!=null)
        {
            gameObject.GetComponentInParent<InventoryPanel>().ChangeSelected(this);
        }

    }
}
