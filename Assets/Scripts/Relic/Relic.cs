using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Relic
{
    public RelicInfo relicInfo;

    public Relic oppositeRelic = null;

    public PersonalityType oppositeCategory;

    public Relic() { }

    public Relic(RelicInfo relicInfo) : this()
    {
        this.relicInfo = relicInfo;
        oppositeCategory = GetOppositeCategory(relicInfo.Category);
    }

    public static PersonalityType GetOppositeCategory(PersonalityType personalityType)
    {
        return personalityType switch
        {
            PersonalityType.Logic => PersonalityType.Passion,
            PersonalityType.Passion => PersonalityType.Logic,
            PersonalityType.Moral => PersonalityType.Unethic,
            PersonalityType.Unethic => PersonalityType.Moral,
            PersonalityType.Detour => PersonalityType.Strong,
            PersonalityType.Strong => PersonalityType.Detour,
            _ => PersonalityType.Inside,
        };
    }

    public static string GetRarityString(int rarity)
    {
        return rarity switch
        {
            0 => "��ͨ",
            1 => "ϡ��",
            _ => "����",
        };
    }

    public static string GetCategoryString(PersonalityType personalityType)
    {
        return personalityType switch
        {
            PersonalityType.Logic => "�߼�",
            PersonalityType.Passion => "����",
            PersonalityType.Moral => "����",
            PersonalityType.Unethic => "�޼�",
            PersonalityType.Detour => "�ػ�",
            PersonalityType.Strong => "ǿ��",
            _ => "����",
        };
    }
}