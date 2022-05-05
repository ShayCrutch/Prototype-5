using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffcultyScript : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int diffculty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDiffculty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDiffculty()
    {
        Debug.Log(gameObject.name + " Was Clicked");
        gameManager.StartGame(diffculty);
    }
}
