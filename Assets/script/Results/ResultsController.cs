using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsController : MonoBehaviour {


	[SerializeField] GameLogic gameLogic;
    [SerializeField]BalloonController balloonController;

    private float coun = 0.0f;
	private float alpha = 0.0f;
	private GameObject clear;
	private GameObject gameOver;
	private GameObject clearImage;
	private GameObject overImage;

    public bool reEvent;

	

	void Awake( ) {
		clear = GameObject.Find ("GameClear");
		gameOver = GameObject.Find ("GameOver");
		clearImage = GameObject.Find ("CLEAR!");
		overImage = GameObject.Find ("game_over2");
        reEvent = true;
	}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	public void GameClear( ) {

		if (clearImage.transform.position.y <= 2.0f) {
            reEvent = false;
            return;
		}
		
		if (alpha <= 0.6f) {
			// フェードアウト
			alpha += 0.01f;
			clear.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 255, alpha);
		}

		if ( alpha > 0.6f && clearImage.transform.position.y > 2.0f ) {
			balloonController.BalloonDestroy();
			clearImage.transform.position -= new Vector3 (0, 0.05f, 0 );
		}

	}

	public void GameOver( ) {

		if (overImage.transform.position.y <= 2.0f) {
            reEvent = false;
            return;
		}
		
		if (alpha <= 0.6f) {
            // フェードアウト
			alpha += 0.01f;
			gameOver.GetComponent<SpriteRenderer> ().color = new Color ( 0, 0, 0, alpha);
		}

		if ( alpha > 0.6f && overImage.transform.position.y > 2.0f ) {			
			overImage.transform.position -= new Vector3 (0, 0.05f, 0 );
		}

	}

}
