﻿using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;
using TMPro;
using Managers;
using Player;
using Weapons;

public class DialogueManager : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] Dialogue startingDialogue;

    Dialogue currentDialogue;

    bool firstTime = true;

    // Start is called before the first frame update
    void Awake()
    {
        if(LevelManager.Instance == null)
            return;
    }

    public void UpdateDialogue(BaseWeapon weapon)
    {

        /*if (LevelManager.Instance == null || 
           LevelManager.Instance.Player == null || 
           !LevelManager.Instance.Player.TryGetComponent(out PlayerWeaponMutation currentWeapon))
            return;

        Dialogue newDialogue;
        if (firstTime)
        {
            newDialogue = weapon.objectDialogue[0];
            firstTime = false;
        }
        else
        {
            newDialogue = weapon.objectDialogue[Random.Range(0, weapon.objectDialogue.Length)];
        }
        textComponent.text = newDialogue.GetDialogue();*/

    }

}
