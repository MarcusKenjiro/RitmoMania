using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetir : MonoBehaviour
{
    public GameController gameController;

    private void OnMouseDown()
    {

        if (gameController.gameState == GameState.RESPONDER)
        {
            gameController.RepetirFun();
            //gameController.StartCoroutine("Repetir", idBotao);
        }
    }
}
