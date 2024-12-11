using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;

    private void Start()
    {
        GetComponent<WriteText>().Run("Fortnite\nAmoung us", textLabel);
    } 
}
