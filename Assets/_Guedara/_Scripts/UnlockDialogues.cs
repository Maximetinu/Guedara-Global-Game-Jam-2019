using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDialogues : MonoBehaviour
{
    public bool restart = false;
    public static bool catUnlock = false;

    public static bool familyUnlock = false;

    public static bool studentUnlock = false;

    public static bool coupleUnlock = false;

    public static bool oldCoupleUnlock = false;

    void Start()
    {
        if (restart)
        {
            ResetAll();
        }
    }

    public void UnlockCat()
    {
        UnlockDialogues.catUnlock = true;
    }
    
    public void UnlockFamily()
    {
        UnlockDialogues.familyUnlock = true;
    }
    
    public void UnlockStudent()
    {
        UnlockDialogues.studentUnlock = true;
    }
    
    public void UnlockCouple()
    {
        UnlockDialogues.coupleUnlock = true;
    }
    
    public void UnlockOldCouple()
    {
        UnlockDialogues.oldCoupleUnlock = true;
    }

    public void ResetAll()
    {
        catUnlock = false;
        familyUnlock = false;
        studentUnlock = false;
        coupleUnlock = false;
        oldCoupleUnlock = false;
    }
}
