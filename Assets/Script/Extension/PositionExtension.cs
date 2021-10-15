using Assets.Script.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Extension
{
    public static class PositionExtension
    {
        public static float VerifyPositionY(this GameObject Player)
        {
            switch (Player.gameObject.transform.localPosition.y)
            {
                case PositionConst.PosY0:
                    return PositionConst.PosY1;
                case PositionConst.PosY1:
                    return PositionConst.PosY2;
                case PositionConst.PosY2:
                    return PositionConst.PosY3;
                case PositionConst.PosY3:
                    return PositionConst.PosY4;
                case PositionConst.PosY4:
                    return PositionConst.PosY5;
                case PositionConst.PosY5:
                    return PositionConst.PosYFim;
            }
            return PositionConst.PosY0;
        }
        public static Vector3 VerifyKillPosition(this int kill)
        {
            switch (kill)
            {
                case 1:
                    return new Vector3(PositionConst.SideAX, PositionConst.PosY1, PositionConst.PosZ);
                case 2:
                    return new Vector3(PositionConst.SideAX, PositionConst.PosY2, PositionConst.PosZ);
                case 3:
                    return new Vector3(PositionConst.SideAX, PositionConst.PosY3, PositionConst.PosZ);
                case 4:
                    return new Vector3(PositionConst.SideAX, PositionConst.PosY4, PositionConst.PosZ);
                case 5:
                    return new Vector3(PositionConst.SideAX, PositionConst.PosY5, PositionConst.PosZ);
                case 6:
                    return new Vector3(PositionConst.SideBX, PositionConst.PosY1, PositionConst.PosZ);
                case 7:
                    return new Vector3(PositionConst.SideBX, PositionConst.PosY2, PositionConst.PosZ);
                case 8:
                    return new Vector3(PositionConst.SideBX, PositionConst.PosY3, PositionConst.PosZ);
                case 9:
                    return new Vector3(PositionConst.SideBX, PositionConst.PosY4, PositionConst.PosZ);
                case 10:
                    return new Vector3(PositionConst.SideBX, PositionConst.PosY5,PositionConst.PosZ);
            }
            return new Vector3(0,0,0);
        }
    }
}
