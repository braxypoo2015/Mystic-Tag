using UnityEngine;

public class MysticCosmetics : MonoBehaviour
{
    [Header("Cosmetic Slots")]
    public GameObject hat;
    public GameObject faceAccessory;
    public GameObject backAccessory;

    public void EquipHat(GameObject cosmetic)
    {
        ReplaceCosmetic(ref hat, cosmetic);
    }

    public void EquipFaceAccessory(GameObject cosmetic)
    {
        ReplaceCosmetic(ref faceAccessory, cosmetic);
    }

    public void EquipBackAccessory(GameObject cosmetic)
    {
        ReplaceCosmetic(ref backAccessory, cosmetic);
    }

    private void ReplaceCosmetic(ref GameObject slot, GameObject cosmetic)
    {
        if (slot != null)
            slot.SetActive(false);

        slot = cosmetic;

        if (slot != null)
            slot.SetActive(true);
    }

    public void ClearCosmetics()
    {
        ClearSlot(ref hat);
        ClearSlot(ref faceAccessory);
        ClearSlot(ref backAccessory);
    }

    private void ClearSlot(ref GameObject slot)
    {
        if (slot != null)
            Destroy(slot);

        slot = null;
    }
}
