using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private Button PlayersAttackButton;
    [SerializeField] private Button PlayersHealButton;
    [SerializeField] private Button EnemysAttackButton;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();

        PlayersAttackButton.onClick.AddListener(gameManager.PlayerAttack);

        PlayersHealButton.onClick.AddListener(gameManager.PlayerHeal);

        EnemysAttackButton.onClick.AddListener(gameManager.EnemyAttack);
    }


}
