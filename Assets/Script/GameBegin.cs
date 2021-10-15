using Assets.Script.Client;
using Assets.Script.Constants;
using UnityEngine;

public class GameBegin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SlackClient.SendSlackMsg(MsgConst.BEGIN_MSG);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
