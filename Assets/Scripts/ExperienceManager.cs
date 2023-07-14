using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    private static float EXP;

    private static int Kills;
    void Start()
    {
        EXP=0;
    }

    public static void setExp(float exp)
    { EXP = exp; }

    public static float getEXP()
    {
        return EXP;
    }

    public static void setKills(int kills)
    { Kills = kills; }

    public static int getKills()
    {
        return Kills;
    }
}
