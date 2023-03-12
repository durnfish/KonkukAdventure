using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptable Object/Building Data")]
public class BuildingData : ScriptableObject
{
    public int buildingNum; // �ǹ� ��ȣ
    public string buildingName; // �ǹ� �̸�
    public BuildingType buildingType; // �ǹ� Ÿ��


    [TextArea] public string buildingDescription;  // �ǹ� ����

}
