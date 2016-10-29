using UnityEngine;
using System.Collections;

public class BattleUiManager : MonoBehaviour {

    [SerializeField]GameLogic gameLogic;
    [SerializeField]BattleUiController battleUiController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        switch(gameLogic.gameStatus) {
            case (int)GameLogic.GAME_STATUS.Clear:
                battleUiController.GameClear();
                break;
            case (int)GameLogic.GAME_STATUS.Over:
                battleUiController.GameOver();
                break;
        }
	
	}
}
