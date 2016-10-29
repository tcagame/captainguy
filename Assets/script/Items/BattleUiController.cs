using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BattleUiController : MonoBehaviour {

    [SerializeField]ResultsController reController;
    [SerializeField]BattleUiManager battleUiManager;

    public GameObject retry;
	public GameObject title;
	public GameObject moveControllerPanel;

	public GameObject bossHp;
	public GameObject playerHp;
	public GameObject stamina;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GameClear() {
        moveControllerPanel.SetActive (false);
		bossHp.SetActive (false);
		playerHp.SetActive (false);
		stamina.SetActive (false);
        if ( reController.reEvent == false ) {
            retry.SetActive (true);
	        title.SetActive (true);
        }
    }

    public void GameOver() {
        moveControllerPanel.SetActive (false);
        bossHp.SetActive (false);
		playerHp.SetActive (false);
		stamina.SetActive (false);
        if ( reController.reEvent == false ) {
		    retry.SetActive (true);
		    title.SetActive (true);
        }
    }

    public void OnRetryButtonClicked() {
		SceneManager.LoadScene ("Battle");
	}

	public void OnOverButtonClicked() {
		SceneManager.LoadScene ("Title");
	}
}
