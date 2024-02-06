using UnityEngine;

[CreateAssetMenu(fileName = "EquipmentData", menuName = "Item/Equipment", order = 0)]
public class EquipmentStatsData : ScriptableObject
{
    public string Name;
    public int Level;
    public int Atk;
    public int Def;
    public int Hp;
    public int Critical;
    public int Gold;
}
