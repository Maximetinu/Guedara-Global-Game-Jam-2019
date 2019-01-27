using System.Collections;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine.Events;

public class EnableUnlockedDialogues : MonoBehaviour
{
    public Button oldCoupleButton, coupleButton, petButton, familyButton;

    public UnityEvent ifNothingUnlocked;

    public float nothingUnlockedWait = 2f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        petButton.interactable = UnlockDialogues.catUnlock;
        coupleButton.interactable = UnlockDialogues.coupleUnlock;
        oldCoupleButton.interactable = UnlockDialogues.oldCoupleUnlock;
        familyButton.interactable = UnlockDialogues.familyUnlock;

        if (!UnlockDialogues.catUnlock && !UnlockDialogues.coupleUnlock && !UnlockDialogues.oldCoupleUnlock &&
            !UnlockDialogues.familyUnlock)
        {
            yield return new WaitForSeconds(nothingUnlockedWait);
            ifNothingUnlocked.Invoke();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            petButton.interactable = true;
            coupleButton.interactable = true;
            oldCoupleButton.interactable = true;
            familyButton.interactable = true;
        }
    }
}
