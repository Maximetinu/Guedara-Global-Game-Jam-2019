using UnityEngine;
using UnityEngine.UI;

public class EnableUnlockedDialogues : MonoBehaviour
{
    public Button oldCoupleButton, coupleButton, petButton, familyButton;
    
    // Start is called before the first frame update
    void Start()
    {
        petButton.interactable = UnlockDialogues.catUnlock;
        coupleButton.interactable = UnlockDialogues.coupleUnlock;
        oldCoupleButton.interactable = UnlockDialogues.oldCoupleUnlock;
        familyButton.interactable = UnlockDialogues.familyUnlock;
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
