using Assets.Script.Client;
using Assets.Script.Constants;
using Assets.Script.Extension;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    public int RandKill;
    public Vector3 Vector;
    void Start()
    {
        RandKill = Random.Range(1, 10);
        Vector = RandKill.VerifyKillPosition();
        print(RandKill);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (Player.gameObject.transform.localPosition.y == PositionConst.PosY5)
            {
                MovementPlayer(PositionConst.PosXbegin, Player.VerifyPositionY());
                SlackClient.SendSlackMsg(MsgConst.VICTORY_MSG);
                SceneManager.LoadScene(SceneConst.WINNER);
            }
            else
            {
                MovementPlayer(PositionConst.SideBX, Player.VerifyPositionY());
                if (Vector.y == Player.gameObject.transform.localPosition.y && Vector.x == Player.gameObject.transform.localPosition.x)
                {
                    SlackClient.SendSlackMsg(MsgConst.GAME_OVER);
                    SceneManager.LoadScene(SceneConst.GAME_OVER_SC);
                }
                else
                {
                    SlackClient.SendSlackMsg(MsgConst.ADVANCE_MSG_SIDE_B);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Player.gameObject.transform.localPosition.y == PositionConst.PosY5)
            {
                MovementPlayer(PositionConst.PosXbegin, Player.VerifyPositionY());
                SlackClient.SendSlackMsg(MsgConst.VICTORY_MSG);
                SceneManager.LoadScene(SceneConst.WINNER); ;
            }
            else 
            {
                MovementPlayer(PositionConst.SideAX, Player.VerifyPositionY());
                if (Vector.y == Player.gameObject.transform.localPosition.y && Vector.x == Player.gameObject.transform.localPosition.x)
                {
                    SlackClient.SendSlackMsg(MsgConst.GAME_OVER);
                    SceneManager.LoadScene(SceneConst.GAME_OVER_SC);
                }
                else
                {
                    SlackClient.SendSlackMsg(MsgConst.ADVANCE_MSG_SIDE_A);
                }
            }
        }
    }
    public void MovementPlayer(float x,float y)
    {
        Player.gameObject.transform.localPosition = new Vector3(x,y,PositionConst.PosZ);
    }
}
